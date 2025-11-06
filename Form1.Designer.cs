namespace WF_HomeWork_4
{
    partial class Notepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ToolStripMenuItemFile = new ToolStripMenuItem();
            ToolStripMenuItemCreate = new ToolStripMenuItem();
            ToolStripMenuItemOpen = new ToolStripMenuItem();
            ToolStripMenuItemSave = new ToolStripMenuItem();
            ToolStripMenuItemSaveAs = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            ToolStripMenuItemExit = new ToolStripMenuItem();
            ToolStripMenuItemReference = new ToolStripMenuItem();
            ToolStripMenuItemInfo = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemFile, ToolStripMenuItemReference });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            ToolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemCreate, ToolStripMenuItemOpen, ToolStripMenuItemSave, ToolStripMenuItemSaveAs, toolStripMenuItem1, ToolStripMenuItemExit });
            ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            ToolStripMenuItemFile.Size = new Size(48, 20);
            ToolStripMenuItemFile.Text = "Файл";
            // 
            // ToolStripMenuItemCreate
            // 
            ToolStripMenuItemCreate.Name = "ToolStripMenuItemCreate";
            ToolStripMenuItemCreate.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItemCreate.Size = new Size(235, 22);
            ToolStripMenuItemCreate.Text = "Создать";
            ToolStripMenuItemCreate.Click += ToolStripMenuItemCreate_Click;
            // 
            // ToolStripMenuItemOpen
            // 
            ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            ToolStripMenuItemOpen.ShortcutKeys = Keys.Control | Keys.O;
            ToolStripMenuItemOpen.Size = new Size(235, 22);
            ToolStripMenuItemOpen.Text = "Открыть";
            ToolStripMenuItemOpen.Click += ToolStripMenuItemOpen_Click;
            // 
            // ToolStripMenuItemSave
            // 
            ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            ToolStripMenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItemSave.Size = new Size(235, 22);
            ToolStripMenuItemSave.Text = "Сохранить";
            ToolStripMenuItemSave.Click += ToolStripMenuItemSave_Click;
            // 
            // ToolStripMenuItemSaveAs
            // 
            ToolStripMenuItemSaveAs.Name = "ToolStripMenuItemSaveAs";
            ToolStripMenuItemSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ToolStripMenuItemSaveAs.Size = new Size(235, 22);
            ToolStripMenuItemSaveAs.Text = "Сохранить как...";
            ToolStripMenuItemSaveAs.Click += ToolStripMenuItemSaveAs_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(232, 6);
            // 
            // ToolStripMenuItemExit
            // 
            ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            ToolStripMenuItemExit.ShortcutKeys = Keys.Alt | Keys.F4;
            ToolStripMenuItemExit.Size = new Size(235, 22);
            ToolStripMenuItemExit.Text = "Выход";
            ToolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
            // 
            // ToolStripMenuItemReference
            // 
            ToolStripMenuItemReference.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemInfo });
            ToolStripMenuItemReference.Name = "ToolStripMenuItemReference";
            ToolStripMenuItemReference.Size = new Size(65, 20);
            ToolStripMenuItemReference.Text = "Справка";
            // 
            // ToolStripMenuItemInfo
            // 
            ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            ToolStripMenuItemInfo.Size = new Size(180, 22);
            ToolStripMenuItemInfo.Text = "О программе";
            ToolStripMenuItemInfo.Click += ToolStripMenuItemInfo_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 426);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // Notepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Notepad";
            Text = "Блокнот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItemFile;
        private ToolStripMenuItem ToolStripMenuItemReference;
        private ToolStripMenuItem ToolStripMenuItemCreate;
        private ToolStripMenuItem ToolStripMenuItemOpen;
        private ToolStripMenuItem ToolStripMenuItemSave;
        private ToolStripMenuItem ToolStripMenuItemSaveAs;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItemExit;
        private ToolStripMenuItem ToolStripMenuItemInfo;
        private RichTextBox richTextBox1;
    }
}
