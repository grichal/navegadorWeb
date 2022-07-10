using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using Microsoft.Win32;


namespace Bunifu_Browser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
            var AppName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(AppName, 99999, RegistryValueKind.DWord);
            webBrowser1.Navigate("https://www.google.com/");
        }
        protected TitleBarTabs ParentTabs
        {
            get { 
                return (ParentForm as TitleBarTabs); 
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtSearchOrUrl.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }


        private void txtSearchOrUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSearchOrUrl.Text.Trim().Length > 0)
            {
                if (txtSearchOrUrl.Text.Contains("."))
                {
                    webBrowser1.Navigate(txtSearchOrUrl.Text.Trim());
                }
                else
                {
                
                    webBrowser1.Navigate("https://www.google.com/search?client=opera&q=" + txtSearchOrUrl.Text.Trim().Replace(" ",".") + "&sourceid=opera&ie=UTF-8&oe=UTF-8");                }
            }
        }


    }
}
