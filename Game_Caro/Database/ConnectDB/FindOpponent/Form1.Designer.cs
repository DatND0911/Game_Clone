namespace FindOpponent
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
            this.lbInformation_Player = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNoParameter = new System.Windows.Forms.Button();
            this.btnPassParameter = new System.Windows.Forms.Button();
            this.txtWinMatch = new System.Windows.Forms.TextBox();
            this.lbWinMatch = new System.Windows.Forms.Label();
            this.txtLoseMatch = new System.Windows.Forms.TextBox();
            this.lbLoseMatch = new System.Windows.Forms.Label();
            this.lbDrawMatch = new System.Windows.Forms.Label();
            this.txtDrawMatch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbInformation_Player
            // 
            this.lbInformation_Player.AutoSize = true;
            this.lbInformation_Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lbInformation_Player.Location = new System.Drawing.Point(266, 78);
            this.lbInformation_Player.Name = "lbInformation_Player";
            this.lbInformation_Player.Size = new System.Drawing.Size(130, 20);
            this.lbInformation_Player.TabIndex = 0;
            this.lbInformation_Player.Text = "Find_Information";
            this.lbInformation_Player.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(160, 184);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(83, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Enter Name";
            this.lbName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(287, 181);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(165, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNoParameter
            // 
            this.btnNoParameter.Location = new System.Drawing.Point(394, 121);
            this.btnNoParameter.Name = "btnNoParameter";
            this.btnNoParameter.Size = new System.Drawing.Size(109, 23);
            this.btnNoParameter.TabIndex = 3;
            this.btnNoParameter.Text = "No Parameter";
            this.btnNoParameter.UseVisualStyleBackColor = true;
            this.btnNoParameter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPassParameter
            // 
            this.btnPassParameter.Location = new System.Drawing.Point(149, 121);
            this.btnPassParameter.Name = "btnPassParameter";
            this.btnPassParameter.Size = new System.Drawing.Size(117, 23);
            this.btnPassParameter.TabIndex = 4;
            this.btnPassParameter.Text = "Pass Parameter";
            this.btnPassParameter.UseVisualStyleBackColor = true;
            this.btnPassParameter.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtWinMatch
            // 
            this.txtWinMatch.Location = new System.Drawing.Point(287, 236);
            this.txtWinMatch.Name = "txtWinMatch";
            this.txtWinMatch.ReadOnly = true;
            this.txtWinMatch.Size = new System.Drawing.Size(165, 23);
            this.txtWinMatch.TabIndex = 6;
            this.txtWinMatch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbWinMatch
            // 
            this.lbWinMatch.AutoSize = true;
            this.lbWinMatch.ForeColor = System.Drawing.Color.Red;
            this.lbWinMatch.Location = new System.Drawing.Point(160, 236);
            this.lbWinMatch.Name = "lbWinMatch";
            this.lbWinMatch.Size = new System.Drawing.Size(74, 17);
            this.lbWinMatch.TabIndex = 5;
            this.lbWinMatch.Text = "Win Match";
            this.lbWinMatch.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLoseMatch
            // 
            this.txtLoseMatch.Location = new System.Drawing.Point(287, 298);
            this.txtLoseMatch.Name = "txtLoseMatch";
            this.txtLoseMatch.ReadOnly = true;
            this.txtLoseMatch.Size = new System.Drawing.Size(165, 23);
            this.txtLoseMatch.TabIndex = 8;
            this.txtLoseMatch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbLoseMatch
            // 
            this.lbLoseMatch.AutoSize = true;
            this.lbLoseMatch.ForeColor = System.Drawing.Color.Red;
            this.lbLoseMatch.Location = new System.Drawing.Point(160, 298);
            this.lbLoseMatch.Name = "lbLoseMatch";
            this.lbLoseMatch.Size = new System.Drawing.Size(81, 17);
            this.lbLoseMatch.TabIndex = 7;
            this.lbLoseMatch.Text = "Lose Match";
            this.lbLoseMatch.Click += new System.EventHandler(this.lbLoseMatch_Click);
            // 
            // lbDrawMatch
            // 
            this.lbDrawMatch.AutoSize = true;
            this.lbDrawMatch.ForeColor = System.Drawing.Color.Red;
            this.lbDrawMatch.Location = new System.Drawing.Point(160, 362);
            this.lbDrawMatch.Name = "lbDrawMatch";
            this.lbDrawMatch.Size = new System.Drawing.Size(82, 17);
            this.lbDrawMatch.TabIndex = 9;
            this.lbDrawMatch.Text = "Draw Match";
            this.lbDrawMatch.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDrawMatch
            // 
            this.txtDrawMatch.Location = new System.Drawing.Point(287, 356);
            this.txtDrawMatch.Name = "txtDrawMatch";
            this.txtDrawMatch.ReadOnly = true;
            this.txtDrawMatch.Size = new System.Drawing.Size(165, 23);
            this.txtDrawMatch.TabIndex = 10;
            this.txtDrawMatch.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 483);
            this.Controls.Add(this.txtDrawMatch);
            this.Controls.Add(this.lbDrawMatch);
            this.Controls.Add(this.txtLoseMatch);
            this.Controls.Add(this.lbLoseMatch);
            this.Controls.Add(this.txtWinMatch);
            this.Controls.Add(this.lbWinMatch);
            this.Controls.Add(this.btnPassParameter);
            this.Controls.Add(this.btnNoParameter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbInformation_Player);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInformation_Player;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnNoParameter;
        private System.Windows.Forms.Button btnPassParameter;
        private System.Windows.Forms.TextBox txtWinMatch;
        private System.Windows.Forms.Label lbWinMatch;
        private System.Windows.Forms.TextBox txtLoseMatch;
        private System.Windows.Forms.Label lbLoseMatch;
        private System.Windows.Forms.Label lbDrawMatch;
        private System.Windows.Forms.TextBox txtDrawMatch;
        private System.Windows.Forms.TextBox txtName;
    }
}

