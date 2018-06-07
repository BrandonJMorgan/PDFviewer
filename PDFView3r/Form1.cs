using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //allows for file access

namespace PDFView3r
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pdfBrowser.ScriptErrorsSuppressed = true; //stops annoying JS script errors. remove code to find out 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); // create new object
            openFileDialog1.ShowDialog(); // shows the file dialog box
            string pdfpath = openFileDialog1.FileName; //converts file to string for pdf viewer to access 
            pdfBrowser.Navigate(pdfpath); // navigate to open file
        }
    }
}
