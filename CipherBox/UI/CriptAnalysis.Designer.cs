namespace CipherBox.UI
{
    partial class CriptAnalysis
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
            this.analysis_encrypted_text_box = new System.Windows.Forms.TextBox();
            this.analyze_button = new System.Windows.Forms.Button();
            this.analysis_results_texxt_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // analysis_encrypted_text_box
            // 
            this.analysis_encrypted_text_box.Location = new System.Drawing.Point(12, 12);
            this.analysis_encrypted_text_box.Multiline = true;
            this.analysis_encrypted_text_box.Name = "analysis_encrypted_text_box";
            this.analysis_encrypted_text_box.Size = new System.Drawing.Size(776, 53);
            this.analysis_encrypted_text_box.TabIndex = 9;
            // 
            // analyze_button
            // 
            this.analyze_button.Location = new System.Drawing.Point(12, 71);
            this.analyze_button.Name = "analyze_button";
            this.analyze_button.Size = new System.Drawing.Size(75, 23);
            this.analyze_button.TabIndex = 15;
            this.analyze_button.Text = "Criptanalysis";
            this.analyze_button.UseVisualStyleBackColor = true;
            this.analyze_button.Click += new System.EventHandler(this.analyze_button_Click);
            // 
            // analysis_results_texxt_box
            // 
            this.analysis_results_texxt_box.Location = new System.Drawing.Point(12, 100);
            this.analysis_results_texxt_box.Multiline = true;
            this.analysis_results_texxt_box.Name = "analysis_results_texxt_box";
            this.analysis_results_texxt_box.ReadOnly = true;
            this.analysis_results_texxt_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.analysis_results_texxt_box.Size = new System.Drawing.Size(776, 338);
            this.analysis_results_texxt_box.TabIndex = 16;
            // 
            // CriptAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analysis_results_texxt_box);
            this.Controls.Add(this.analyze_button);
            this.Controls.Add(this.analysis_encrypted_text_box);
            this.Name = "CriptAnalysis";
            this.Text = "CriptAnalysis";
            this.Load += new System.EventHandler(this.CriptAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox analysis_encrypted_text_box;
        private System.Windows.Forms.Button analyze_button;
        private System.Windows.Forms.TextBox analysis_results_texxt_box;
    }
}