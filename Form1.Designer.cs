namespace WF_HomeWork_4
{
    partial class Form1
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
            buttonLoad = new Button();
            buttonEdit = new Button();
            textBoxInfo = new TextBox();
            SuspendLayout();
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(154, 336);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(150, 30);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить файл";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(469, 336);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 30);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Dock = DockStyle.Top;
            textBoxInfo.Location = new Point(0, 0);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.ScrollBars = ScrollBars.Vertical;
            textBoxInfo.Size = new Size(800, 314);
            textBoxInfo.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInfo);
            Controls.Add(buttonEdit);
            Controls.Add(buttonLoad);
            Name = "Form1";
            Text = "Режим просмотра";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLoad;
        private Button buttonEdit;
        private TextBox textBoxInfo;
    }
}