using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog MyOFD = new OpenFileDialog();
            MyOFD.Filter = "Text|*.txt";
            
            if (MyOFD.ShowDialog() == DialogResult.OK )
            {
                StreamReader MySR = new StreamReader(MyOFD.FileName);
                richTextBox1.Text=MySR.ReadToEnd();
                MySR.Close();                
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) 
        {
            SaveFileDialog MySFD = new SaveFileDialog();
            MySFD.Filter = "Text|*.txt";
            if (MySFD.ShowDialog()==DialogResult.OK)
            {
                StreamWriter MySW = new StreamWriter(MySFD.FileName);
                MySW.Write(richTextBox1.Text);
                MySW.Close();
            }
            
        
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELP WITH WHAT ????");
        }
    }
}
