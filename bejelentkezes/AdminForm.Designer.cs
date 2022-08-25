
namespace bejelentkezes
{
    partial class AdminForm
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
            this.listBox_admin = new System.Windows.Forms.ListBox();
            this.button_adminTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_admin
            // 
            this.listBox_admin.FormattingEnabled = true;
            this.listBox_admin.Location = new System.Drawing.Point(13, 13);
            this.listBox_admin.Name = "listBox_admin";
            this.listBox_admin.Size = new System.Drawing.Size(260, 108);
            this.listBox_admin.TabIndex = 0;
            // 
            // button_adminTorles
            // 
            this.button_adminTorles.Location = new System.Drawing.Point(13, 128);
            this.button_adminTorles.Name = "button_adminTorles";
            this.button_adminTorles.Size = new System.Drawing.Size(260, 23);
            this.button_adminTorles.TabIndex = 1;
            this.button_adminTorles.Text = "Törlés";
            this.button_adminTorles.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 163);
            this.Controls.Add(this.button_adminTorles);
            this.Controls.Add(this.listBox_admin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_admin;
        private System.Windows.Forms.Button button_adminTorles;
    }
}