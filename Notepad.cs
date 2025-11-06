using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WF_HomeWork_4
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            TitleName();
        }

        string filePath = "";
        private void TitleName()
        {
            if (string.IsNullOrEmpty(filePath))
                this.Text = $"Безымянный - Блокнот";
            else
                this.Text = $"{Path.GetFileNameWithoutExtension(filePath)} - Блокнот";
        }

        private void Saving()
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Сохранить файл";
                    dialog.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы(*.*) | *.*";
                    dialog.DefaultExt = "txt";
                    dialog.AddExtension = true;
                    if (string.IsNullOrEmpty(dialog.FileName))
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(dialog.FileName, richTextBox1.Text);
                            filePath = dialog.FileName;
                            MessageBox.Show("Файл успешно сохранен");
                            TitleName();
                        }
                    }
                }
            }
            else
            {
                File.WriteAllText(filePath, richTextBox1.Text);
                MessageBox.Show("Файл успешно сохранен");
            }

        }
        
        private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа, версия: HomeWork-4\nАвтор: Лихачев Е. В.", "Блокнот: сведения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemCreate_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в документе?", "Сохранение документа", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                switch (result)
                {
                    case DialogResult.Yes:
                        Saving();
                        richTextBox1.Clear();
                        filePath = "";
                        TitleName();
                        break;
                    case DialogResult.No:
                        richTextBox1.Clear();
                        filePath = "";
                        TitleName();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                richTextBox1.Clear();
                filePath = "";
                TitleName();
            }
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в документе?", "Сохранение документа", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                switch (result)
                {
                    case DialogResult.Yes:
                        Saving();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Выберите файл для открытия";
                dialog.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы(*.*) | *.*";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                    richTextBox1.Text = File.ReadAllText(filePath);
                    TitleName();
                }
            }
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            Saving();
            TitleName();
        }

        private void ToolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            filePath = "";
            Saving();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в документе?", "Сохранение документа", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                switch (result)
                {
                    case DialogResult.Yes:
                        Saving();                       
                        break;
                    case DialogResult.No:                       
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            this.Close();
        }
    }
}
