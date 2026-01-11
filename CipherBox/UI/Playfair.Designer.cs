namespace CipherBox.UI
{
    partial class Playfair
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playfair));
            this.label1 = new System.Windows.Forms.Label();
            this.key_text_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formated_key_text_box = new System.Windows.Forms.TextBox();
            this.setup_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.matrix_text_box = new System.Windows.Forms.TextBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.formatted_plain_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.formated_encrypted_text_box = new System.Windows.Forms.TextBox();
            this.analysis_buutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cifrul Playfair. Se alege o cheie: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // key_text_box
            // 
            this.key_text_box.Location = new System.Drawing.Point(167, 12);
            this.key_text_box.Name = "key_text_box";
            this.key_text_box.Size = new System.Drawing.Size(263, 20);
            this.key_text_box.TabIndex = 15;
            this.key_text_box.TextChanged += new System.EventHandler(this.n_value_text_box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Se parcurge cheia de la stanga la dreapta si se pastreaza doar prima aparitie a f" +
    "iecarei litere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Se construieste o matrice de 5x5 fara litera J (J=I)";
            // 
            // formated_key_text_box
            // 
            this.formated_key_text_box.Location = new System.Drawing.Point(456, 53);
            this.formated_key_text_box.Name = "formated_key_text_box";
            this.formated_key_text_box.ReadOnly = true;
            this.formated_key_text_box.Size = new System.Drawing.Size(490, 20);
            this.formated_key_text_box.TabIndex = 18;
            // 
            // setup_button
            // 
            this.setup_button.Location = new System.Drawing.Point(15, 34);
            this.setup_button.Name = "setup_button";
            this.setup_button.Size = new System.Drawing.Size(134, 23);
            this.setup_button.TabIndex = 20;
            this.setup_button.Text = "Setup data for Playfair";
            this.setup_button.UseVisualStyleBackColor = true;
            this.setup_button.Click += new System.EventHandler(this.setup_button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // matrix_text_box
            // 
            this.matrix_text_box.Location = new System.Drawing.Point(15, 99);
            this.matrix_text_box.Multiline = true;
            this.matrix_text_box.Name = "matrix_text_box";
            this.matrix_text_box.ReadOnly = true;
            this.matrix_text_box.Size = new System.Drawing.Size(325, 82);
            this.matrix_text_box.TabIndex = 22;
            // 
            // to_be_decrypted_text_box
            // 
            this.to_be_decrypted_text_box.Location = new System.Drawing.Point(691, 465);
            this.to_be_decrypted_text_box.Multiline = true;
            this.to_be_decrypted_text_box.Name = "to_be_decrypted_text_box";
            this.to_be_decrypted_text_box.ReadOnly = true;
            this.to_be_decrypted_text_box.Size = new System.Drawing.Size(313, 32);
            this.to_be_decrypted_text_box.TabIndex = 34;
            // 
            // encrypted_text_box
            // 
            this.encrypted_text_box.Location = new System.Drawing.Point(15, 465);
            this.encrypted_text_box.Multiline = true;
            this.encrypted_text_box.Name = "encrypted_text_box";
            this.encrypted_text_box.Size = new System.Drawing.Size(313, 32);
            this.encrypted_text_box.TabIndex = 33;
            // 
            // to_be_encrypted_text_box
            // 
            this.to_be_encrypted_text_box.Location = new System.Drawing.Point(692, 335);
            this.to_be_encrypted_text_box.Multiline = true;
            this.to_be_encrypted_text_box.Name = "to_be_encrypted_text_box";
            this.to_be_encrypted_text_box.ReadOnly = true;
            this.to_be_encrypted_text_box.Size = new System.Drawing.Size(313, 32);
            this.to_be_encrypted_text_box.TabIndex = 32;
            // 
            // plain_text_box
            // 
            this.plain_text_box.Location = new System.Drawing.Point(15, 335);
            this.plain_text_box.Multiline = true;
            this.plain_text_box.Name = "plain_text_box";
            this.plain_text_box.Size = new System.Drawing.Size(313, 32);
            this.plain_text_box.TabIndex = 31;
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(15, 390);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(75, 23);
            this.decrypt_button.TabIndex = 30;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(15, 203);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(75, 23);
            this.encrypt_button.TabIndex = 29;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Encrypted Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Decrypted Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Encrypted Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Plain Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(807, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Mesajul se imparte in perechi de litere. Daca doua litere identice apar intr-o pe" +
    "reche, se insereaza litera X intre ele. Daca ramane o litera singura la final, s" +
    "e adauga litera X.";
            // 
            // formatted_plain_text
            // 
            this.formatted_plain_text.Location = new System.Drawing.Point(355, 335);
            this.formatted_plain_text.Multiline = true;
            this.formatted_plain_text.Name = "formatted_plain_text";
            this.formatted_plain_text.ReadOnly = true;
            this.formatted_plain_text.Size = new System.Drawing.Size(313, 32);
            this.formatted_plain_text.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Formatted Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(800, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Daca ambele litere din pereche se afla pe aceeasi linie in matrice, fiecare liter" +
    "a este inlocuita cu litera din dreapta ei. Daca litera este la capatul liniei, s" +
    "e revine la inceput.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(719, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Daca ambele litere din pereche se afla pe aceeasi coloana, fiecare litera este in" +
    "locuita cu litera de sub ea. Daca litera este pe ultima linie, se revine sus.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(911, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(533, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Decriptarea foloseste aceleasi reguli, dar deplasarea se face invers: stanga in l" +
    "oc de dreapta si sus in loc de jos.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Formatted Text";
            // 
            // formated_encrypted_text_box
            // 
            this.formated_encrypted_text_box.Location = new System.Drawing.Point(355, 465);
            this.formated_encrypted_text_box.Multiline = true;
            this.formated_encrypted_text_box.Name = "formated_encrypted_text_box";
            this.formated_encrypted_text_box.ReadOnly = true;
            this.formated_encrypted_text_box.Size = new System.Drawing.Size(313, 32);
            this.formated_encrypted_text_box.TabIndex = 42;
            // 
            // analysis_buutton
            // 
            this.analysis_buutton.Location = new System.Drawing.Point(16, 503);
            this.analysis_buutton.Name = "analysis_buutton";
            this.analysis_buutton.Size = new System.Drawing.Size(75, 23);
            this.analysis_buutton.TabIndex = 44;
            this.analysis_buutton.Text = "Criptanalysis";
            this.analysis_buutton.UseVisualStyleBackColor = true;
            this.analysis_buutton.Click += new System.EventHandler(this.analysis_buutton_Click);
            // 
            // Playfair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 533);
            this.Controls.Add(this.analysis_buutton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.formated_encrypted_text_box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.formatted_plain_text);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.matrix_text_box);
            this.Controls.Add(this.setup_button);
            this.Controls.Add(this.formated_key_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key_text_box);
            this.Controls.Add(this.label1);
            this.Name = "Playfair";
            this.Text = "Playfair";
            this.Load += new System.EventHandler(this.Playfair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key_text_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formated_key_text_box;
        private System.Windows.Forms.Button setup_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox matrix_text_box;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox formatted_plain_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox formated_encrypted_text_box;
        private System.Windows.Forms.Button analysis_buutton;
    }
}