using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using Newtonsoft.Json;
using System.Net;
using System.IO;


namespace PluralSightDownloader
{
    public partial class Form1 : Form
    {
        private readonly ChromiumWebBrowser browser;

        public Form1()
        {
            InitializeComponent();
            Text = "PluralSight";

            WindowState = FormWindowState.Maximized;

            browser = new ChromiumWebBrowser("www.google.com")
            {
                Dock = DockStyle.Fill,
            };

            toolStripContainer1.ContentPanel.Controls.Add(browser);
            //toolStripContainer1.Dock = DockStyle.Bottom;
            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var version = String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: {3}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion, bitness);
            DisplayOutput(version);


        }

        public void DisplayOutput(string output)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text;
            if (string.IsNullOrEmpty(url))
            {
                url = @"https://www.pluralsight.com/a/signin?ReturnUrl=http%3A%2F%2Fwww.pluralsight.com%2F";
            }

            if (!url.Contains("http://") && !url.Contains("https://"))
            {
                url = "http://" + url;
            }

            Uri testUri = new Uri(url, UriKind.Absolute);

            browser.Load(url);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            DisplayOutput(browser.Left.ToString());

            string getTtitleJs = "$('#playerTitle').clone().children().remove().end().text().trim()";
            try
            {
                var a = browser.EvaluateScript(textBox1.Text);
                label1.Text = a.ToString();
            }
            catch (Exception err)
            {
                label1.Text = err.Message;

            }


        }

        private void btnParseJson_Click(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, string>> main = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(tbJson.Text);
            lbParsedJson.Text = "done";

            string dlAddress = @"c:\downloads\sql-2012-database-administration-pt3\";

            foreach (var item in main)
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(dlAddress + item.Key);
                foreach (var urls in item.Value)
                {
                    downloadTheFile(dlAddress + item.Key + "\\" + urls.Key.Replace(':', '_').Replace('/',' ').Replace('?',' '), urls.Value);
                }
                
            }
        }


        private void downloadTheFile(string fileName, string url) {

            string ext = Path.GetExtension(url);
            fileName += ext;
           
            WebClient webcl = new WebClient();
            webcl.DownloadFile(url, fileName);
            label1.Text += fileName + "\r\n";
        }
    }
}
