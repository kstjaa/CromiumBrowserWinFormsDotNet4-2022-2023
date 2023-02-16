using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CromiumBrowserWinFormsDotNet4_2022_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBrowswer();
        }

        public void InitializeBrowswer()
        {
            var settings = new CefSettings();
            Cef.Initialize(settings);
            Browser.Load("https://google.com");
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Browser.Load(Address.Text);
        }
    }
}
