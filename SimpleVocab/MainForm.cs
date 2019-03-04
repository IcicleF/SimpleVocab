using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVocab
{
    public struct WordOptions {
        public int modeOption;
        public int modeCustomType, modeCustomVal;

        public int wordlistOption;
    }

    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            txtCustom.Enabled = optCustom.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            WordOptions opt;

            if (optExhausive.Checked) {
                opt.modeOption = 0;
                opt.modeCustomType = opt.modeCustomVal = -1;
            }
            else if (optDefault.Checked) {
                opt.modeOption = 1;
                opt.modeCustomType = opt.modeCustomVal = -1;
            }
            else if (optCustom.Checked) {
                opt.modeOption = 2;
                opt.modeCustomType = 0;

                string cust = txtCustom.Text;
                if (cust.Contains('%')) {
                    cust = cust.Substring(0, cust.Length - 1);
                    opt.modeCustomType = 1;
                }
                if (!(int.TryParse(cust, out opt.modeCustomVal))) {
                    MessageBox.Show("模式字符串不合法！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
                return;

            if (optAllWords.Checked)
                opt.wordlistOption = 0;
            else if (optNotLearnedWords.Checked)
                opt.wordlistOption = 1;
            else if (optLearnedWords.Checked)
                opt.wordlistOption = 2;
            else if (optHardWords.Checked)
                opt.wordlistOption = 3;
            else
                return;

            WordCheckForm frmCheck = new WordCheckForm(opt);
            frmCheck.Show();
        }

        private void optCustom_CheckedChanged(object sender, EventArgs e) {
            txtCustom.Enabled = optCustom.Checked;
        }
    }
}
