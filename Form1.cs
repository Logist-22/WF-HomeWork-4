using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_HomeWork_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = "";

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            textBoxInfo.Clear();
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Выберите файл для открытия";
                dialog.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы(*.*) | *.*";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                    textBoxInfo.Text = File.ReadAllText(filePath);
                    this.Text = $"{Path.GetFileNameWithoutExtension(filePath)} - Режим просмотра";
                    buttonEdit.Enabled = true;
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBoxInfo.Text, filePath);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                textBoxInfo.Text = form2.Result;
            }
        }
    }
}
