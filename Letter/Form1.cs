using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letter
{
    public partial class Form1 : Form
    {
        private char[] Vowel = new char[8] {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
        private double check;
        public Form1()
        {
            InitializeComponent();
        }

        private void bDetect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbWord.Text)||double.TryParse(tbWord.Text,out double check))
            {
                MessageBox.Show("Lütfen harf grubu giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                char[] Compare = tbWord.Text.ToLower().ToCharArray();
                foreach (var text in Compare)
                {
                    if (Vowel.Contains(text) && !tbVowel.Text.Contains(text))
                    {
                        tbVowel.Text += text+ " ";
                    }
                    else if (!Vowel.Contains(text) && !tbSurd.Text.Contains(text))
                    {
                        tbSurd.Text += text+ " ";
                    }
                }
            }
           
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbVowel.Text = "";
            tbWord.Text = "";
            tbSurd.Text = "";
        }
    }
}
