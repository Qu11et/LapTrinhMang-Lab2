namespace bai_2_lab_2
{
    partial class bai2
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
            this.btnread = new System.Windows.Forms.Button();
            this.txtfile = new System.Windows.Forms.RichTextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txturl = new System.Windows.Forms.TextBox();
            this.txtline = new System.Windows.Forms.TextBox();
            this.txtword = new System.Windows.Forms.TextBox();
            this.txtcharacter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnread
            // 
            this.btnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.Location = new System.Drawing.Point(7, 3);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(390, 37);
            this.btnread.TabIndex = 0;
            this.btnread.Text = "Read from File";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click_1);
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(403, 1);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(558, 507);
            this.txtfile.TabIndex = 1;
            this.txtfile.Text = " ";
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(8, 471);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(390, 42);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Words count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Character count";
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(216, 79);
            this.txtfilename.Multiline = true;
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(181, 40);
            this.txtfilename.TabIndex = 3;
            this.txtfilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(216, 128);
            this.txtsize.Multiline = true;
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(181, 40);
            this.txtsize.TabIndex = 3;
            this.txtsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(216, 176);
            this.txturl.Multiline = true;
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(181, 40);
            this.txturl.TabIndex = 3;
            this.txturl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtline
            // 
            this.txtline.Location = new System.Drawing.Point(216, 230);
            this.txtline.Multiline = true;
            this.txtline.Name = "txtline";
            this.txtline.Size = new System.Drawing.Size(181, 40);
            this.txtline.TabIndex = 3;
            this.txtline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(216, 287);
            this.txtword.Multiline = true;
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(181, 40);
            this.txtword.TabIndex = 3;
            this.txtword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcharacter
            // 
            this.txtcharacter.Location = new System.Drawing.Point(216, 346);
            this.txtcharacter.Multiline = true;
            this.txtcharacter.Name = "txtcharacter";
            this.txtcharacter.Size = new System.Drawing.Size(181, 40);
            this.txtcharacter.TabIndex = 3;
            this.txtcharacter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.txtcharacter);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.txtline);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.RichTextBox txtfile;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.TextBox txtline;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.TextBox txtcharacter;
    }
}

