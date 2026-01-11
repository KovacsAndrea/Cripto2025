namespace CipherBox.UI
{
    partial class Cezar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plain_text_box = new System.Windows.Forms.TextBox();
            this.to_be_decrypted_text_box = new System.Windows.Forms.TextBox();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.encrypted_text_box = new System.Windows.Forms.TextBox();
            this.to_be_decrypted_test_box = new System.Windows.Forms.TextBox();
            this.analysis_buutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cifrul lui Cezar inlocuieste fiecare litera din textul clar cu a treia litera car" +
    "e urmeaza in alfabet. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plain Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decrypted Text";
            // 
            // plain_text_box
            // 
            this.plain_text_box.Location = new System.Drawing.Point(26, 87);
            this.plain_text_box.Multiline = true;
            this.plain_text_box.Name = "plain_text_box";
            this.plain_text_box.Size = new System.Drawing.Size(340, 66);
            this.plain_text_box.TabIndex = 3;
            // 
            // to_be_decrypted_text_box
            // 
            this.to_be_decrypted_text_box.Location = new System.Drawing.Point(403, 87);
            this.to_be_decrypted_text_box.Multiline = true;
            this.to_be_decrypted_text_box.Name = "to_be_decrypted_text_box";
            this.to_be_decrypted_text_box.Size = new System.Drawing.Size(340, 66);
            this.to_be_decrypted_text_box.TabIndex = 5;
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(26, 45);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(75, 23);
            this.encrypt_button.TabIndex = 6;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encrypted Text";
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(26, 172);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(75, 23);
            this.decrypt_button.TabIndex = 8;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Encrypted Text";
            // 
            // encrypted_text_box
            // 
            this.encrypted_text_box.Location = new System.Drawing.Point(26, 214);
            this.encrypted_text_box.Multiline = true;
            this.encrypted_text_box.Name = "encrypted_text_box";
            this.encrypted_text_box.Size = new System.Drawing.Size(340, 66);
            this.encrypted_text_box.TabIndex = 10;
            // 
            // to_be_decrypted_test_box
            // 
            this.to_be_decrypted_test_box.Location = new System.Drawing.Point(402, 214);
            this.to_be_decrypted_test_box.Multiline = true;
            this.to_be_decrypted_test_box.Name = "to_be_decrypted_test_box";
            this.to_be_decrypted_test_box.Size = new System.Drawing.Size(340, 66);
            this.to_be_decrypted_test_box.TabIndex = 11;
            // 
            // analysis_buutton
            // 
            this.analysis_buutton.Location = new System.Drawing.Point(27, 406);
            this.analysis_buutton.Name = "analysis_buutton";
            this.analysis_buutton.Size = new System.Drawing.Size(75, 23);
            this.analysis_buutton.TabIndex = 12;
            this.analysis_buutton.Text = "Criptanalysis";
            this.analysis_buutton.UseVisualStyleBackColor = true;
            this.analysis_buutton.Click += new System.EventHandler(this.analysis_buutton_Click);
            // 
            // Cezar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analysis_buutton);
            this.Controls.Add(this.to_be_decrypted_test_box);
            this.Controls.Add(this.encrypted_text_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.to_be_decrypted_text_box);
            this.Controls.Add(this.plain_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cezar";
            this.Text = "Cezar";
            this.Load += new System.EventHandler(this.Cezar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox plain_text_box;
        private System.Windows.Forms.TextBox to_be_decrypted_text_box;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox encrypted_text_box;
        private System.Windows.Forms.TextBox to_be_decrypted_test_box;
        private System.Windows.Forms.Button analysis_buutton;
    }
}