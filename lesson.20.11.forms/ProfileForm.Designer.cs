namespace lesson._20._11.forms
{
    partial class ProfileForm
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
            label1 = new Label();
            label2 = new Label();
            txtFilePath = new TextBox();
            btnSelectImage = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(29, 110);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "Шлях до фото:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(183, 34);
            label2.Name = "label2";
            label2.Size = new Size(263, 35);
            label2.TabIndex = 1;
            label2.Text = "Профіль користувача";
            label2.Click += label2_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Font = new Font("Segoe UI", 12F);
            txtFilePath.Location = new Point(29, 153);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(538, 34);
            txtFilePath.TabIndex = 2;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Font = new Font("Segoe UI", 13F);
            btnSelectImage.Location = new Point(573, 153);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(63, 34);
            btnSelectImage.TabIndex = 3;
            btnSelectImage.Text = "...";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 417);
            Controls.Add(btnSelectImage);
            Controls.Add(txtFilePath);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProfileForm";
            Text = "Налаштування профілю";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFilePath;
        private Button btnSelectImage;
    }
}
