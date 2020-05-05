using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebBrowser.Navigate("https://www.google.pl");
            WebBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = WebBrowser.DocumentTitle;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            WebBrowser browser = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                browser.Navigate(urlBox.Text);
            }
        }

        WebBrowser bTab = null;

        private void newTabButton_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Nowa karta";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount-1);

            bTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            bTab.Parent = tab;
            bTab.Dock = DockStyle.Fill;
            bTab.Navigate("https://www.google.pl");
            urlBox.Text = "https://www.google.pl";
            bTab.DocumentCompleted += BTab_DocumentCompleted;
        }

        private void BTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = bTab.DocumentTitle;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WebBrowser browser = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if(browser!=null)
            {
                if(browser.CanGoBack)
                {
                    browser.GoBack();
                }
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            WebBrowser browser = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoForward)
                {
                    browser.GoForward();
                }
            }
        }

        private void urlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                WebBrowser browser = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if(browser!=null)
                {
                    browser.Navigate(urlBox.Text);
                }
            }
        }
    }
}
