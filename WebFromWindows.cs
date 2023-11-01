using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Franklin_Templeton_DAL.InputForms
{
    public partial class WebFromWindows : Form
    {
        public WebFromWindows()
        {
            InitializeComponent();
            //InitializeWebView();
            webView21.Source=new Uri("https://www.google.com/");
            //webView21.Source = new Uri("https://64f087652e5ef21137f18a64--helpful-blancmange-27b217.netlify.app/");
        }

        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("https://google.com/"); // Replace with your React app URL }
        }
    }
}
