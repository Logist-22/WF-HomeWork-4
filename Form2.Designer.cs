namespace WF_HomeWork_4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxEdit = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxEdit
            // 
            textBoxEdit.Dock = DockStyle.Top;
            textBoxEdit.Location = new Point(0, 0);
            textBoxEdit.Multiline = true;
            textBoxEdit.Name = "textBoxEdit";
            textBoxEdit.Size = new Size(800, 314);
            textBoxEdit.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(139, 350);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 30);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(480, 350);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 30);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxEdit);
            Name = "Form2";
            Text = "Режим редактирования";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEdit;
        private Button buttonSave;
        private Button buttonCancel;
    }
}