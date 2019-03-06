using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVocab
{
    public partial class WordCheckForm : Form
    {
        private HashSet<string> allWords, learnedWords, hardWords;
        private List<string> targetWords;
        private int targetSize, currentPtr;
        private WordOptions options;

        private void SerializeWordListToFile(HashSet<string> list, string path) {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();
        }

        private HashSet<string> DeserializeWordListFromFile(string path) {
            if (!File.Exists(path))
                return new HashSet<string>();
            try {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                HashSet<string> ret = bf.Deserialize(fs) as HashSet<string>;
                fs.Close();
                return ret;
            }
            catch (IOException ex) {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SerializationException) {
                MessageBox.Show("单词集的格式不正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        private HashSet<string> LoadPlainTextWordList(string path) {
            try {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sw = new StreamReader(fs);
                HashSet<string> ret = new HashSet<string>();
                string line = null;
                while ((line = sw.ReadLine()) != null) {
                    ret.Add(line);
                }
                sw.Close();
                fs.Close();
                return ret;
            }
            catch (IOException) {
                MessageBox.Show("指定的文件不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        private void LoadWordLists() {
            if (options.wordlistOption < 3) {
                allWords = LoadPlainTextWordList("wordlist.txt");
                if (options.wordlistOption > 0)
                    learnedWords = DeserializeWordListFromFile("learned.bin");
            }
            hardWords = DeserializeWordListFromFile("hard.bin");
        }

        private void GenerateTargetWordList() {
            targetWords = new List<string>();
            if (options.wordlistOption == 3)
                targetWords.AddRange(hardWords);
            else {
                foreach (string word in allWords) {
                    if (options.wordlistOption == 0 ||
                        (options.wordlistOption == 1 && !learnedWords.Contains(word)) ||
                        (options.wordlistOption == 2 && learnedWords.Contains(word)))
                        targetWords.Add(word);
                }
            }
            // Debug.WriteLine("Before Shuffle: " + targetWords.Count.ToString());
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            var shuffledTargetWords = targetWords.OrderBy(item => rand.Next());
            List<string> newTargetWords = new List<string>();
            newTargetWords.AddRange(shuffledTargetWords);
            targetWords = newTargetWords;
            // Debug.WriteLine("After Shuffle: " + targetWords.Count.ToString());

            targetSize = targetWords.Count;
            if (options.modeOption == 1) {          // Default
                if (options.wordlistOption == 3)    // Hard words = 50%
                    targetSize = targetSize / 2;
                else                                // Others = 20%
                    targetSize = targetSize / 5;
            }
            else if (options.modeOption == 2) {     // Custom
                if (options.modeCustomType == 0)    // Count
                    targetSize = Math.Max(targetSize, options.modeCustomVal);
                else {                              // Percentage
                    int truncated = Math.Min(100, options.modeCustomVal);
                    targetSize = (int)(targetSize * (truncated / 100.0));
                }
            }
        }

        private void DisplayCurrentWord() {
            string word = targetWords[currentPtr];
            lblWord.Text = word;
            chkHard.Checked = hardWords.Contains(word);
            lblCounter.Text = string.Format("{0}/{1}", currentPtr + 1, targetSize);
        }

        private void DisplayNextWord() {
            if (++currentPtr < targetSize)
                DisplayCurrentWord();
            else {
                // TODO: trigger exit
            }
        }

        public WordCheckForm(WordOptions opt)
        {
            InitializeComponent();
            options = opt;
        }

        private void WordCheckForm_Load(object sender, EventArgs e) {
            LoadWordLists();
            if (allWords == null || hardWords == null)
                Application.Exit();
            if (options.wordlistOption == 1 || options.wordlistOption == 2)
                if (learnedWords == null)
                    Application.Exit();
            GenerateTargetWordList();

            currentPtr = 0;
            DisplayCurrentWord();
        }
    }
}
