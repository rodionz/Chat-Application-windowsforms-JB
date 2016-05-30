﻿namespace ServerInterface
{
    partial class ServerRegistration
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
            this.label3 = new System.Windows.Forms.Label();
            this.IPmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.portTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clearIP = new System.Windows.Forms.Button();
            this.Clearportbutton = new System.Windows.Forms.Button();
            this.ConfirmIP = new System.Windows.Forms.Button();
            this.PortConfirmationButtom = new System.Windows.Forms.Button();
            this.CreateServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter IP Adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enter you port:";
            // 
            // IPmaskedTextBox
            // 
            this.IPmaskedTextBox.Location = new System.Drawing.Point(239, 42);
            this.IPmaskedTextBox.Mask = " ###.###.###.###";
            this.IPmaskedTextBox.Name = "IPmaskedTextBox";
            this.IPmaskedTextBox.Size = new System.Drawing.Size(108, 20);
            this.IPmaskedTextBox.TabIndex = 18;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(239, 118);
            this.portTextBox.Mask = "00000";
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(108, 20);
            this.portTextBox.TabIndex = 20;
            this.portTextBox.ValidatingType = typeof(int);
            this.portTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.portTextBox_MaskInputRejected);
            // 
            // clearIP
            // 
            this.clearIP.BackColor = System.Drawing.Color.Red;
            this.clearIP.Location = new System.Drawing.Point(397, 36);
            this.clearIP.Name = "clearIP";
            this.clearIP.Size = new System.Drawing.Size(66, 23);
            this.clearIP.TabIndex = 21;
            this.clearIP.Text = "Clear";
            this.clearIP.UseVisualStyleBackColor = false;
            // 
            // Clearportbutton
            // 
            this.Clearportbutton.BackColor = System.Drawing.Color.Red;
            this.Clearportbutton.Location = new System.Drawing.Point(397, 112);
            this.Clearportbutton.Name = "Clearportbutton";
            this.Clearportbutton.Size = new System.Drawing.Size(66, 23);
            this.Clearportbutton.TabIndex = 23;
            this.Clearportbutton.Text = "Clear";
            this.Clearportbutton.UseVisualStyleBackColor = false;
            // 
            // ConfirmIP
            // 
            this.ConfirmIP.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ConfirmIP.Location = new System.Drawing.Point(502, 36);
            this.ConfirmIP.Name = "ConfirmIP";
            this.ConfirmIP.Size = new System.Drawing.Size(86, 26);
            this.ConfirmIP.TabIndex = 24;
            this.ConfirmIP.Text = "ConfirmIP";
            this.ConfirmIP.UseVisualStyleBackColor = true;
            // 
            // PortConfirmationButtom
            // 
            this.PortConfirmationButtom.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PortConfirmationButtom.Location = new System.Drawing.Point(502, 112);
            this.PortConfirmationButtom.Name = "PortConfirmationButtom";
            this.PortConfirmationButtom.Size = new System.Drawing.Size(97, 23);
            this.PortConfirmationButtom.TabIndex = 26;
            this.PortConfirmationButtom.Text = "Confirm port";
            this.PortConfirmationButtom.UseVisualStyleBackColor = true;
            // 
            // CreateServerButton
            // 
            this.CreateServerButton.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateServerButton.Location = new System.Drawing.Point(312, 191);
            this.CreateServerButton.Name = "CreateServerButton";
            this.CreateServerButton.Size = new System.Drawing.Size(151, 32);
            this.CreateServerButton.TabIndex = 27;
            this.CreateServerButton.Text = "Create Server";
            this.CreateServerButton.UseVisualStyleBackColor = true;
            // 
            // ServerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(737, 262);
            this.Controls.Add(this.CreateServerButton);
            this.Controls.Add(this.PortConfirmationButtom);
            this.Controls.Add(this.ConfirmIP);
            this.Controls.Add(this.Clearportbutton);
            this.Controls.Add(this.clearIP);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.IPmaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ServerRegistration";
            this.Text = "ServerRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox IPmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox portTextBox;
        private System.Windows.Forms.Button clearIP;
        private System.Windows.Forms.Button Clearportbutton;
        public System.Windows.Forms.Button ConfirmIP;
        private System.Windows.Forms.Button PortConfirmationButtom;
        public System.Windows.Forms.Button CreateServerButton;
    }
}