using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace URLShortener
{
    public partial class MainWin : Form
    {
        private Dictionary<string, string> urlDict = new Dictionary<string, string>();

        public MainWin()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string input = tbLong.Text;

            if (input.StartsWith("http://") || input.StartsWith("https://"))
            {
                bool found = urlDict.ContainsValue(input);
                if (found)
                {
                    foreach (KeyValuePair<string, string> kv in urlDict)
                    {
                        if (kv.Value.Equals(input))
                        {
                            linkShort.Text = kv.Key;
                        }
                    }
                }
                else
                {
                    int shrt = urlDict.Count + 1;
                    string key;

                    if (input.StartsWith("http:"))
                        key = "http://" + shrt;
                    else
                        key = "https://" + shrt;
                    urlDict.Add(key, input);
                    linkShort.Text = key;
                }
                linkLong.Text = input;
            }
            else
            {
                MessageBox.Show("URLs provide must start with http:// or https://");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkShort_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string longURL = urlDict[linkShort.Text];

            try
            {
                Process.Start(longURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot start URL: " + ex.Message, "URL Start Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
