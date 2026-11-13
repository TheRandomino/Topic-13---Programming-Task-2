namespace Topic_13___Programming_Task_2
{
    partial class Form1
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
            this.lblQ1Result = new System.Windows.Forms.Label();
            this.grpQ1 = new System.Windows.Forms.GroupBox();
            this.radQ1A3 = new System.Windows.Forms.RadioButton();
            this.radQ1A2 = new System.Windows.Forms.RadioButton();
            this.radQ1A1 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblQ2Result = new System.Windows.Forms.Label();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.grpQ2 = new System.Windows.Forms.GroupBox();
            this.radQ2A5 = new System.Windows.Forms.RadioButton();
            this.radQ2A4 = new System.Windows.Forms.RadioButton();
            this.radQ2A3 = new System.Windows.Forms.RadioButton();
            this.radQ2A2 = new System.Windows.Forms.RadioButton();
            this.radQ2A1 = new System.Windows.Forms.RadioButton();
            this.grpQ1.SuspendLayout();
            this.grpQ2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQ1Result
            // 
            this.lblQ1Result.AutoSize = true;
            this.lblQ1Result.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ1Result.Location = new System.Drawing.Point(310, 34);
            this.lblQ1Result.Name = "lblQ1Result";
            this.lblQ1Result.Size = new System.Drawing.Size(80, 21);
            this.lblQ1Result.TabIndex = 0;
            this.lblQ1Result.Text = "Question 1:";
            this.lblQ1Result.Visible = false;
            // 
            // grpQ1
            // 
            this.grpQ1.Controls.Add(this.radQ1A3);
            this.grpQ1.Controls.Add(this.radQ1A2);
            this.grpQ1.Controls.Add(this.radQ1A1);
            this.grpQ1.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQ1.Location = new System.Drawing.Point(12, 12);
            this.grpQ1.Name = "grpQ1";
            this.grpQ1.Size = new System.Drawing.Size(292, 116);
            this.grpQ1.TabIndex = 1;
            this.grpQ1.TabStop = false;
            this.grpQ1.Text = "Question1: Who is Canto 3 centered around?";
            // 
            // radQ1A3
            // 
            this.radQ1A3.AutoSize = true;
            this.radQ1A3.Location = new System.Drawing.Point(6, 82);
            this.radQ1A3.Name = "radQ1A3";
            this.radQ1A3.Size = new System.Drawing.Size(75, 25);
            this.radQ1A3.TabIndex = 2;
            this.radQ1A3.Text = "Sinclair";
            this.radQ1A3.UseVisualStyleBackColor = true;
            // 
            // radQ1A2
            // 
            this.radQ1A2.AutoSize = true;
            this.radQ1A2.Location = new System.Drawing.Point(7, 51);
            this.radQ1A2.Name = "radQ1A2";
            this.radQ1A2.Size = new System.Drawing.Size(78, 25);
            this.radQ1A2.TabIndex = 1;
            this.radQ1A2.Text = "Vergilius";
            this.radQ1A2.UseVisualStyleBackColor = true;
            // 
            // radQ1A1
            // 
            this.radQ1A1.AutoSize = true;
            this.radQ1A1.Location = new System.Drawing.Point(7, 20);
            this.radQ1A1.Name = "radQ1A1";
            this.radQ1A1.Size = new System.Drawing.Size(63, 25);
            this.radQ1A1.TabIndex = 0;
            this.radQ1A1.Text = "Outis";
            this.radQ1A1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(98, 134);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblQ2Result
            // 
            this.lblQ2Result.AutoSize = true;
            this.lblQ2Result.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ2Result.Location = new System.Drawing.Point(310, 94);
            this.lblQ2Result.Name = "lblQ2Result";
            this.lblQ2Result.Size = new System.Drawing.Size(80, 21);
            this.lblQ2Result.TabIndex = 3;
            this.lblQ2Result.Text = "Question 2:";
            this.lblQ2Result.Visible = false;
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.Location = new System.Drawing.Point(62, 166);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(148, 21);
            this.lblInvalid.TabIndex = 4;
            this.lblInvalid.Text = "Please select an answer.";
            this.lblInvalid.Visible = false;
            // 
            // grpQ2
            // 
            this.grpQ2.Controls.Add(this.radQ2A5);
            this.grpQ2.Controls.Add(this.radQ2A4);
            this.grpQ2.Controls.Add(this.radQ2A3);
            this.grpQ2.Controls.Add(this.radQ2A2);
            this.grpQ2.Controls.Add(this.radQ2A1);
            this.grpQ2.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQ2.Location = new System.Drawing.Point(12, 12);
            this.grpQ2.Name = "grpQ2";
            this.grpQ2.Size = new System.Drawing.Size(292, 116);
            this.grpQ2.TabIndex = 3;
            this.grpQ2.TabStop = false;
            this.grpQ2.Text = "Question 2: What Finger is Ricardo from?";
            this.grpQ2.Visible = false;
            // 
            // radQ2A5
            // 
            this.radQ2A5.AutoSize = true;
            this.radQ2A5.Location = new System.Drawing.Point(91, 51);
            this.radQ2A5.Name = "radQ2A5";
            this.radQ2A5.Size = new System.Drawing.Size(60, 25);
            this.radQ2A5.TabIndex = 4;
            this.radQ2A5.Text = "Pinky";
            this.radQ2A5.UseVisualStyleBackColor = true;
            // 
            // radQ2A4
            // 
            this.radQ2A4.AutoSize = true;
            this.radQ2A4.Location = new System.Drawing.Point(91, 20);
            this.radQ2A4.Name = "radQ2A4";
            this.radQ2A4.Size = new System.Drawing.Size(55, 25);
            this.radQ2A4.TabIndex = 3;
            this.radQ2A4.Text = "Ring";
            this.radQ2A4.UseVisualStyleBackColor = true;
            // 
            // radQ2A3
            // 
            this.radQ2A3.AutoSize = true;
            this.radQ2A3.Location = new System.Drawing.Point(6, 82);
            this.radQ2A3.Name = "radQ2A3";
            this.radQ2A3.Size = new System.Drawing.Size(70, 25);
            this.radQ2A3.TabIndex = 2;
            this.radQ2A3.Text = "Middle";
            this.radQ2A3.UseVisualStyleBackColor = true;
            // 
            // radQ2A2
            // 
            this.radQ2A2.AutoSize = true;
            this.radQ2A2.Location = new System.Drawing.Point(7, 51);
            this.radQ2A2.Name = "radQ2A2";
            this.radQ2A2.Size = new System.Drawing.Size(59, 25);
            this.radQ2A2.TabIndex = 1;
            this.radQ2A2.Text = "Index";
            this.radQ2A2.UseVisualStyleBackColor = true;
            // 
            // radQ2A1
            // 
            this.radQ2A1.AutoSize = true;
            this.radQ2A1.Location = new System.Drawing.Point(7, 20);
            this.radQ2A1.Name = "radQ2A1";
            this.radQ2A1.Size = new System.Drawing.Size(71, 25);
            this.radQ2A1.TabIndex = 0;
            this.radQ2A1.Text = "Thumb";
            this.radQ2A1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 198);
            this.Controls.Add(this.grpQ2);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.lblQ2Result);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblQ1Result);
            this.Controls.Add(this.grpQ1);
            this.Name = "Form1";
            this.Text = "Two Whole Questions!!! Wowzas!!!";
            this.grpQ1.ResumeLayout(false);
            this.grpQ1.PerformLayout();
            this.grpQ2.ResumeLayout(false);
            this.grpQ2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ1Result;
        private System.Windows.Forms.GroupBox grpQ1;
        private System.Windows.Forms.RadioButton radQ1A1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton radQ1A3;
        private System.Windows.Forms.RadioButton radQ1A2;
        private System.Windows.Forms.Label lblQ2Result;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.GroupBox grpQ2;
        private System.Windows.Forms.RadioButton radQ2A3;
        private System.Windows.Forms.RadioButton radQ2A2;
        private System.Windows.Forms.RadioButton radQ2A1;
        private System.Windows.Forms.RadioButton radQ2A5;
        private System.Windows.Forms.RadioButton radQ2A4;
    }
}

