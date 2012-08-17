using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IEJavascriptSpeedTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ResetOutput(){
            txtOutput.Text = "";
            wbTest.ObjectForScripting = new Benchmark(txt =>
            {
                txtOutput.Invoke((Action)(() => { txtOutput.Text += txt; }));
            });

            if(System.Diagnostics.Stopwatch.IsHighResolution){
                txtOutput.Text = "Operations timed using the system's high-resolution performance counter.";
            } else {
                txtOutput.Text = "Operations timed using the DateTime class.";
            }
        }

        private void wbTest_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            ResetOutput();
        }

        private void wbTest_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F5) {
                wbTest.ObjectForScripting = new Benchmark(txt =>
                {
                    txtOutput.Invoke((Action)(() => { txtOutput.Text += txt; }));
                });
                ResetOutput();
            }
        }        
    }
}
