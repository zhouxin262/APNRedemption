namespace APNRedemption
{
    partial class FormInputScript
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
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_script = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(616, 499);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 1;
            this.btn_import.Text = "确认导入";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(697, 499);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(161, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "导入新脚本将导致本系统中之前的记录被新导入的脚本内容所替代，确认要导入吗？";
            // 
            // tb_script
            // 
            this.tb_script.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_script.Location = new System.Drawing.Point(0, 0);
            this.tb_script.Name = "tb_script";
            this.tb_script.Size = new System.Drawing.Size(784, 493);
            this.tb_script.TabIndex = 4;
            this.tb_script.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 526);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(760, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // FormInputScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tb_script);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_import);
            this.Name = "FormInputScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入要导入的脚本";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tb_script;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}