﻿namespace ConnectDB
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.Game_Caro = new System.Windows.Forms.Label();
            this.Access_Data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(163, 192);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(105, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "ConnectDB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(163, 244);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(105, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "DisconnectDB";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // Game_Caro
            // 
            this.Game_Caro.AutoSize = true;
            this.Game_Caro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Caro.Location = new System.Drawing.Point(313, 139);
            this.Game_Caro.Name = "Game_Caro";
            this.Game_Caro.Size = new System.Drawing.Size(161, 31);
            this.Game_Caro.TabIndex = 2;
            this.Game_Caro.Text = "Game_Caro";
            this.Game_Caro.Click += new System.EventHandler(this.label1_Click);
            // 
            // Access_Data
            // 
            this.Access_Data.Location = new System.Drawing.Point(163, 285);
            this.Access_Data.Name = "Access_Data";
            this.Access_Data.Size = new System.Drawing.Size(105, 23);
            this.Access_Data.TabIndex = 3;
            this.Access_Data.Text = "Access Data";
            this.Access_Data.UseVisualStyleBackColor = true;
            this.Access_Data.Click += new System.EventHandler(this.Access_Data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Access_Data);
            this.Controls.Add(this.Game_Caro);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label Game_Caro;
        private System.Windows.Forms.Button Access_Data;
    }
}

