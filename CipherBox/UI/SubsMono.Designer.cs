namespace CipherBox.UI
{
    partial class SubsMono
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
            this.to_be_decrypted_text_box = new System.Windows.Forms.TextBox();
            this.encrypted_text_box = new System.Windows.Forms.TextBox();
            this.to_be_encrypted_text_box = new System.Windows.Forms.TextBox();
            this.plain_text_box = new System.Windows.Forms.TextBox();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.generate_permutation_button = new System.Windows.Forms.Button();
            this.generate_perm_radio = new System.Windows.Forms.RadioButton();
            this.input_perm_radio = new System.Windows.Forms.RadioButton();
            this.generated_perm_text_box = new System.Windows.Forms.TextBox();
            this.manual_perm_text_box = new System.Windows.Forms.TextBox();
            this.map_text_box = new System.Windows.Forms.TextBox();
            this.show_key_button = new System.Windows.Forms.Button();
            this.analysis_buutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cheia de criptare este o permutare aleatorie a alfabetului";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ABCDEFGHIJKLMNOPQRSTUVXYZ    ----->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MIPODSQ................FV";
            // 
            // to_be_decrypted_text_box
            // 
            this.to_be_decrypted_text_box.Location = new System.Drawing.Point(410, 284);
            this.to_be_decrypted_text_box.Multiline = true;
            this.to_be_decrypted_text_box.Name = "to_be_decrypted_text_box";
            this.to_be_decrypted_text_box.ReadOnly = true;
            this.to_be_decrypted_text_box.Size = new System.Drawing.Size(361, 58);
            this.to_be_decrypted_text_box.TabIndex = 21;
            // 
            // encrypted_text_box
            // 
            this.encrypted_text_box.Location = new System.Drawing.Point(13, 284);
            this.encrypted_text_box.Multiline = true;
            this.encrypted_text_box.Name = "encrypted_text_box";
            this.encrypted_text_box.Size = new System.Drawing.Size(361, 58);
            this.encrypted_text_box.TabIndex = 20;
            // 
            // to_be_encrypted_text_box
            // 
            this.to_be_encrypted_text_box.Location = new System.Drawing.Point(409, 169);
            this.to_be_encrypted_text_box.Multiline = true;
            this.to_be_encrypted_text_box.Name = "to_be_encrypted_text_box";
            this.to_be_encrypted_text_box.ReadOnly = true;
            this.to_be_encrypted_text_box.Size = new System.Drawing.Size(361, 58);
            this.to_be_encrypted_text_box.TabIndex = 19;
            // 
            // plain_text_box
            // 
            this.plain_text_box.Location = new System.Drawing.Point(13, 169);
            this.plain_text_box.Multiline = true;
            this.plain_text_box.Name = "plain_text_box";
            this.plain_text_box.Size = new System.Drawing.Size(361, 58);
            this.plain_text_box.TabIndex = 18;
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(13, 242);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(75, 23);
            this.decrypt_button.TabIndex = 17;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(13, 127);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(75, 23);
            this.encrypt_button.TabIndex = 16;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Encrypted Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Decrypted Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Encrypted Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Plain Text";
            // 
            // generate_permutation_button
            // 
            this.generate_permutation_button.Location = new System.Drawing.Point(418, 23);
            this.generate_permutation_button.Name = "generate_permutation_button";
            this.generate_permutation_button.Size = new System.Drawing.Size(61, 21);
            this.generate_permutation_button.TabIndex = 22;
            this.generate_permutation_button.Text = "Change";
            this.generate_permutation_button.UseVisualStyleBackColor = true;
            this.generate_permutation_button.Click += new System.EventHandler(this.generate_permutation_button_Click);
            // 
            // generate_perm_radio
            // 
            this.generate_perm_radio.AutoSize = true;
            this.generate_perm_radio.Location = new System.Drawing.Point(13, 31);
            this.generate_perm_radio.Name = "generate_perm_radio";
            this.generate_perm_radio.Size = new System.Drawing.Size(128, 17);
            this.generate_perm_radio.TabIndex = 28;
            this.generate_perm_radio.TabStop = true;
            this.generate_perm_radio.Text = "Generate Permutation";
            this.generate_perm_radio.UseVisualStyleBackColor = true;
            this.generate_perm_radio.CheckedChanged += new System.EventHandler(this.generate_perm_radio_CheckedChanged);
            // 
            // input_perm_radio
            // 
            this.input_perm_radio.AutoSize = true;
            this.input_perm_radio.Location = new System.Drawing.Point(13, 54);
            this.input_perm_radio.Name = "input_perm_radio";
            this.input_perm_radio.Size = new System.Drawing.Size(153, 17);
            this.input_perm_radio.TabIndex = 29;
            this.input_perm_radio.TabStop = true;
            this.input_perm_radio.Text = "Input Permutation Manually";
            this.input_perm_radio.UseVisualStyleBackColor = true;
            this.input_perm_radio.CheckedChanged += new System.EventHandler(this.input_perm_radio_CheckedChanged);
            // 
            // generated_perm_text_box
            // 
            this.generated_perm_text_box.Location = new System.Drawing.Point(172, 24);
            this.generated_perm_text_box.Name = "generated_perm_text_box";
            this.generated_perm_text_box.ReadOnly = true;
            this.generated_perm_text_box.Size = new System.Drawing.Size(240, 20);
            this.generated_perm_text_box.TabIndex = 30;
            // 
            // manual_perm_text_box
            // 
            this.manual_perm_text_box.Location = new System.Drawing.Point(172, 50);
            this.manual_perm_text_box.Name = "manual_perm_text_box";
            this.manual_perm_text_box.Size = new System.Drawing.Size(240, 20);
            this.manual_perm_text_box.TabIndex = 31;
            // 
            // map_text_box
            // 
            this.map_text_box.Location = new System.Drawing.Point(97, 77);
            this.map_text_box.Multiline = true;
            this.map_text_box.Name = "map_text_box";
            this.map_text_box.ReadOnly = true;
            this.map_text_box.Size = new System.Drawing.Size(673, 34);
            this.map_text_box.TabIndex = 32;
            // 
            // show_key_button
            // 
            this.show_key_button.Location = new System.Drawing.Point(12, 77);
            this.show_key_button.Name = "show_key_button";
            this.show_key_button.Size = new System.Drawing.Size(76, 21);
            this.show_key_button.TabIndex = 33;
            this.show_key_button.Text = "Show key";
            this.show_key_button.UseVisualStyleBackColor = true;
            this.show_key_button.Click += new System.EventHandler(this.show_key_button_Click);
            // 
            // analysis_buutton
            // 
            this.analysis_buutton.Location = new System.Drawing.Point(12, 415);
            this.analysis_buutton.Name = "analysis_buutton";
            this.analysis_buutton.Size = new System.Drawing.Size(75, 23);
            this.analysis_buutton.TabIndex = 34;
            this.analysis_buutton.Text = "Criptanalysis";
            this.analysis_buutton.UseVisualStyleBackColor = true;
            this.analysis_buutton.Click += new System.EventHandler(this.analysis_buutton_Click);
            // 
            // SubsMono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analysis_buutton);
            this.Controls.Add(this.show_key_button);
            this.Controls.Add(this.map_text_box);
            this.Controls.Add(this.manual_perm_text_box);
            this.Controls.Add(this.generated_perm_text_box);
            this.Controls.Add(this.input_perm_radio);
            this.Controls.Add(this.generate_perm_radio);
            this.Controls.Add(this.generate_permutation_button);
            this.Controls.Add(this.to_be_decrypted_text_box);
            this.Controls.Add(this.encrypted_text_box);
            this.Controls.Add(this.to_be_encrypted_text_box);
            this.Controls.Add(this.plain_text_box);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubsMono";
            this.Text = "SubsMono";
            this.Load += new System.EventHandler(this.SubsMono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox to_be_decrypted_text_box;
        private System.Windows.Forms.TextBox encrypted_text_box;
        private System.Windows.Forms.TextBox to_be_encrypted_text_box;
        private System.Windows.Forms.TextBox plain_text_box;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button generate_permutation_button;
        private System.Windows.Forms.RadioButton generate_perm_radio;
        private System.Windows.Forms.RadioButton input_perm_radio;
        private System.Windows.Forms.TextBox generated_perm_text_box;
        private System.Windows.Forms.TextBox manual_perm_text_box;
        private System.Windows.Forms.TextBox map_text_box;
        private System.Windows.Forms.Button show_key_button;
        private System.Windows.Forms.Button analysis_buutton;
    }
}