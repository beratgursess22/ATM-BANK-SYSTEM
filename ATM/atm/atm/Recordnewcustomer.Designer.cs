namespace atm
{
    partial class Recordnewcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recordnewcustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtpassoword = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.mskaccountno = new System.Windows.Forms.MaskedTextBox();
            this.btnsaved = new System.Windows.Forms.Button();
            this.btnrandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telphone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Acoount No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Passoword:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(170, 26);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(151, 34);
            this.txtname.TabIndex = 6;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(170, 76);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(151, 34);
            this.txtsurname.TabIndex = 7;
            // 
            // txtpassoword
            // 
            this.txtpassoword.Location = new System.Drawing.Point(170, 293);
            this.txtpassoword.Name = "txtpassoword";
            this.txtpassoword.Size = new System.Drawing.Size(151, 34);
            this.txtpassoword.TabIndex = 8;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(170, 131);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(151, 34);
            this.msktc.TabIndex = 9;
            this.msktc.ValidatingType = typeof(int);
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(170, 188);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(151, 34);
            this.msktel.TabIndex = 10;
            // 
            // mskaccountno
            // 
            this.mskaccountno.Location = new System.Drawing.Point(170, 241);
            this.mskaccountno.Mask = "000000";
            this.mskaccountno.Name = "mskaccountno";
            this.mskaccountno.Size = new System.Drawing.Size(151, 34);
            this.mskaccountno.TabIndex = 11;
            this.mskaccountno.ValidatingType = typeof(int);
            // 
            // btnsaved
            // 
            this.btnsaved.BackColor = System.Drawing.Color.DarkRed;
            this.btnsaved.Location = new System.Drawing.Point(170, 333);
            this.btnsaved.Name = "btnsaved";
            this.btnsaved.Size = new System.Drawing.Size(151, 36);
            this.btnsaved.TabIndex = 12;
            this.btnsaved.Text = "Saved";
            this.btnsaved.UseVisualStyleBackColor = false;
            this.btnsaved.Click += new System.EventHandler(this.btnsaved_Click);
            // 
            // btnrandom
            // 
            this.btnrandom.BackColor = System.Drawing.Color.DarkRed;
            this.btnrandom.Location = new System.Drawing.Point(327, 241);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(47, 36);
            this.btnrandom.TabIndex = 13;
            this.btnrandom.Text = "..";
            this.btnrandom.UseVisualStyleBackColor = false;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // Recordnewcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(386, 398);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.btnsaved);
            this.Controls.Add(this.mskaccountno);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.txtpassoword);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Recordnewcustomer";
            this.Text = "Record Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtpassoword;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.MaskedTextBox mskaccountno;
        private System.Windows.Forms.Button btnsaved;
        private System.Windows.Forms.Button btnrandom;
    }
}