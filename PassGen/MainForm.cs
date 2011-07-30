using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassGen
{
    public partial class MainForm : Form
    {
        private string salt = "#!#";
        private bool show = false;

        public MainForm()
        {
            InitializeComponent();

            this.numberTrackBar.Value = Properties.Settings.Default.Number;
            this.numberLabel.Text = this.numberTrackBar.Value.ToString();

            this.showTextToolStripMenuItem.Checked = Properties.Settings.Default.ShowText;
            this.show = this.showTextToolStripMenuItem.Checked;

            if (this.show == false)
            {
                saltTextbox.UseSystemPasswordChar = true;
                codeTextbox.UseSystemPasswordChar = true;
                outputTextbox.UseSystemPasswordChar = true;

                showSaltTextToolStripMenuItem.Checked = false;
                showCodeTextToolStripMenuItem.Checked = false;
                showOutputTextToolStripMenuItem.Checked = false;
            }
            else
            {
                saltTextbox.UseSystemPasswordChar = false;
                codeTextbox.UseSystemPasswordChar = false;
                outputTextbox.UseSystemPasswordChar = false;

                showSaltTextToolStripMenuItem.Checked = true;
                showCodeTextToolStripMenuItem.Checked = true;
                showOutputTextToolStripMenuItem.Checked = true;
            }
        }

        private string Md5(string strToEncrypt)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            byte[] bytes = ue.GetBytes(strToEncrypt);

            // encrypt bytes
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);

            // Convert the encrypted bytes back to a string (base 16)
            string hashString = "";

            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
            }

            return hashString.PadLeft(32, '0');
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple password generator/finder that generates passwords with unique characters.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            this.saltTextbox.Text = this.saltTextbox.Text.Trim();
            this.codeTextbox.Text = this.codeTextbox.Text.Trim();
            this.outputTextbox.Text = "";

            string abc = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";

            string hash = this.Md5(saltTextbox.Text + codeTextbox.Text + salt);
            char[] output = hash.ToCharArray(0, this.numberTrackBar.Value);
            bool upper = false;
            int last = 0;

            for (int i = 0; i < output.Length; i++)
            {
                try
                {
                    int val = Int32.Parse(output[i].ToString());

                    if (last + 4 < i)
                    {
                        switch (val)
                        {
                            case 0:
                            output[i] = '=';            
                            break;
                            case 1:
                            output[i] = '!';
                            break;
                            case 2:
                            output[i] = '"';
                            break;
                            case 3:
                            output[i] = '#';
                            break;
                            case 4:
                            output[i] = '¤';
                            break;
                            case 5:
                            output[i] = '%';
                            break;
                            case 6:
                            output[i] = '&';
                            break;
                            case 7:
                            output[i] = '/';
                            break;
                            case 8:
                            output[i] = '(';
                            break;
                            case 9:
                            output[i] = ')';
                            break;
                        }

                        last = i;
                    }

                    int index = 0;

                    while (true)
                    {
                        bool redo = false;

                        for (int j = 0; j < i; j++)
                        {
                            if (output[i] == output[j])
                            {
                                if (index < numbers.Length)
                                {
                                    output[i] = numbers[index];
                                    index++;
                                    redo = true;
                                }
                                else
                                {
                                    output[i] = abc[(abc.Length - index - 1)];
                                    index++;
                                    redo = true;
                                }
                            }
                        }

                        if (redo == false)
                        {
                            break;
                        }
                    }

                    upper = true;
                }
                catch (FormatException)
                {
                    if (upper)
                    {
                        output[i] = Convert.ToChar(output[i].ToString().ToUpper());
                        upper = false;
                    }

                    int index = 0;

                    while (true)
                    {
                        bool redo = false;

                        for (int j = 0; j < i; j++)
                        {
                            if (output[i] == output[j])
                            {
                                output[i] = abc[(abc.Length - index - 1)];
                                index++;
                                redo = true;
                            }
                        }

                        if (redo == false)
                        {
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                outputTextbox.Text += output[i];
            }
        }   

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(outputTextbox.Text);
        }

        private void showTextToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            show = showTextToolStripMenuItem.Checked;
            Properties.Settings.Default.ShowText = this.showTextToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();

            if (this.show == false)
            {
                saltTextbox.UseSystemPasswordChar = true;
                codeTextbox.UseSystemPasswordChar = true;
                outputTextbox.UseSystemPasswordChar = true;

                showSaltTextToolStripMenuItem.Checked = false;
                showCodeTextToolStripMenuItem.Checked = false;
                showOutputTextToolStripMenuItem.Checked = false;
            }
            else
            {
                saltTextbox.UseSystemPasswordChar = false;
                codeTextbox.UseSystemPasswordChar = false;
                outputTextbox.UseSystemPasswordChar = false;

                showSaltTextToolStripMenuItem.Checked = true;
                showCodeTextToolStripMenuItem.Checked = true;
                showOutputTextToolStripMenuItem.Checked = true;
            }
        }

        private void showSaltTextToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showSaltTextToolStripMenuItem.Checked == false)
            {
                saltTextbox.UseSystemPasswordChar = true;
            }
            else
            {
                saltTextbox.UseSystemPasswordChar = false;
            }
        }

        private void showCodeTextToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showCodeTextToolStripMenuItem.Checked == false)
            {
                codeTextbox.UseSystemPasswordChar = true;
            }
            else
            {
                codeTextbox.UseSystemPasswordChar = false;
            }
        }

        private void showOutputTextToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showOutputTextToolStripMenuItem.Checked == false)
            {
                outputTextbox.UseSystemPasswordChar = true;
            }
            else
            {
                outputTextbox.UseSystemPasswordChar = false;
            }
        }

        private void numberTrackBar_Scroll(object sender, EventArgs e)
        {
            this.numberLabel.Text = this.numberTrackBar.Value.ToString();
            Properties.Settings.Default.Number = this.numberTrackBar.Value;
            Properties.Settings.Default.Save();
        }
    }
}
