using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WF_HomeWork_4
{
    public partial class Form2 : Form
    {
        public Form2(string text, string filePath)
        {
            InitializeComponent();
            textBoxEdit.Text = text;
            this.filePath = filePath;
        }

        public string Result { get; set; }
        public string filePath { get; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Result = textBoxEdit.Text;            
            File.WriteAllText(filePath, Result);                                        
            DialogResult = DialogResult.OK;            
        }        
    }
}
