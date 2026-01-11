namespace CipherBox.UI
{
    partial class SubstPoli
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
            this.n_value_text_box = new System.Windows.Forms.TextBox();
            this.to_be_decrypted_text_box = new System.Windows.Forms.TextBox();
            this.encrypted_text_box = new System.Windows.Forms.TextBox();
            this.to_be_encrypted_text_box = new System.Windows.Forms.TextBox();
            this.plain_text_box = new System.Windows.Forms.TextBox();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generated_alfa_text_box = new System.Windows.Forms.TextBox();
            this.change_apfa_button = new System.Windows.Forms.Button();
            this.analysis_buutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cifrul Vigenere (substitutie polialfabetica)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valoarea lui n reprezinta numarul de permutari ale alfabetului:";
            // 
            // n_value_text_box
            // 
            this.n_value_text_box.Location = new System.Drawing.Point(509, 10);
            this.n_value_text_box.Name = "n_value_text_box";
            this.n_value_text_box.Size = new System.Drawing.Size(100, 20);
            this.n_value_text_box.TabIndex = 14;
            this.n_value_text_box.TextChanged += new System.EventHandler(this.n_value_text_box_TextChanged);
            // 
            // to_be_decrypted_text_box
            // 
            this.to_be_decrypted_text_box.Location = new System.Drawing.Point(408, 270);
            this.to_be_decrypted_text_box.Multiline = true;
            this.to_be_decrypted_text_box.Name = "to_be_decrypted_text_box";
            this.to_be_decrypted_text_box.ReadOnly = true;
            this.to_be_decrypted_text_box.Size = new System.Drawing.Size(362, 32);
            this.to_be_decrypted_text_box.TabIndex = 24;
            // 
            // encrypted_text_box
            // 
            this.encrypted_text_box.Location = new System.Drawing.Point(15, 270);
            this.encrypted_text_box.Multiline = true;
            this.encrypted_text_box.Name = "encrypted_text_box";
            this.encrypted_text_box.Size = new System.Drawing.Size(362, 32);
            this.encrypted_text_box.TabIndex = 23;
            // 
            // to_be_encrypted_text_box
            // 
            this.to_be_encrypted_text_box.Location = new System.Drawing.Point(408, 190);
            this.to_be_encrypted_text_box.Multiline = true;
            this.to_be_encrypted_text_box.Name = "to_be_encrypted_text_box";
            this.to_be_encrypted_text_box.ReadOnly = true;
            this.to_be_encrypted_text_box.Size = new System.Drawing.Size(362, 32);
            this.to_be_encrypted_text_box.TabIndex = 22;
            // 
            // plain_text_box
            // 
            this.plain_text_box.Location = new System.Drawing.Point(12, 190);
            this.plain_text_box.Multiline = true;
            this.plain_text_box.Name = "plain_text_box";
            this.plain_text_box.Size = new System.Drawing.Size(361, 32);
            this.plain_text_box.TabIndex = 21;
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(12, 228);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(75, 23);
            this.decrypt_button.TabIndex = 20;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(12, 148);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(75, 23);
            this.encrypt_button.TabIndex = 19;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Encrypted Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Decrypted Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Encrypted Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Plain Text";
            // 
            // generated_alfa_text_box
            // 
            this.generated_alfa_text_box.Location = new System.Drawing.Point(12, 36);
            this.generated_alfa_text_box.Multiline = true;
            this.generated_alfa_text_box.Name = "generated_alfa_text_box";
            this.generated_alfa_text_box.ReadOnly = true;
            this.generated_alfa_text_box.Size = new System.Drawing.Size(677, 97);
            this.generated_alfa_text_box.TabIndex = 25;
            this.generated_alfa_text_box.TextChanged += new System.EventHandler(this.generated_alfa_text_box_TextChanged);
            // 
            // change_apfa_button
            // 
            this.change_apfa_button.Location = new System.Drawing.Point(695, 34);
            this.change_apfa_button.Name = "change_apfa_button";
            this.change_apfa_button.Size = new System.Drawing.Size(75, 23);
            this.change_apfa_button.TabIndex = 26;
            this.change_apfa_button.Text = "Change";
            this.change_apfa_button.UseVisualStyleBackColor = true;
            this.change_apfa_button.Click += new System.EventHandler(this.change_apfa_button_Click);
            // 
            // analysis_buutton
            // 
            this.analysis_buutton.Location = new System.Drawing.Point(12, 415);
            this.analysis_buutton.Name = "analysis_buutton";
            this.analysis_buutton.Size = new System.Drawing.Size(75, 23);
            this.analysis_buutton.TabIndex = 27;
            this.analysis_buutton.Text = "Criptanalysis";
            this.analysis_buutton.UseVisualStyleBackColor = true;
            this.analysis_buutton.Click += new System.EventHandler(this.analysis_buutton_Click);
            // 
            // SubstPoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analysis_buutton);
            this.Controls.Add(this.change_apfa_button);
            this.Controls.Add(this.generated_alfa_text_box);
            this.Controls.Add(this.to_be_decrypted_text_box);
            this.Controls.Add(this.encrypted_text_box);
            this.Controls.Add(this.to_be_encrypted_text_box);
            this.Controls.Add(this.plain_text_box);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_value_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubstPoli";
            this.Text = "SubstPoli";
            this.Load += new System.EventHandler(this.SubstPoli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n_value_text_box;
        private System.Windows.Forms.TextBox to_be_decrypted_text_box;
        private System.Windows.Forms.TextBox encrypted_text_box;
        private System.Windows.Forms.TextBox to_be_encrypted_text_box;
        private System.Windows.Forms.TextBox plain_text_box;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox generated_alfa_text_box;
        private System.Windows.Forms.Button change_apfa_button;
        private System.Windows.Forms.Button analysis_buutton;
    }
}