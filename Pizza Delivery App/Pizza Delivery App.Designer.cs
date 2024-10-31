namespace Pizza_Delivery_App
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
            this.logIn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.logInPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(227, 337);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(81, 32);
            this.logIn.TabIndex = 0;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(448, 337);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(79, 32);
            this.signUp.TabIndex = 1;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_Delivery_App.Properties.Resources.pizzaicon;
            this.pictureBox1.Location = new System.Drawing.Point(266, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(137, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mom\'s and Pop\'s Pizza Ordering!";
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.label1);
            this.startPanel.Controls.Add(this.logIn);
            this.startPanel.Controls.Add(this.button1);
            this.startPanel.Controls.Add(this.pictureBox1);
            this.startPanel.Controls.Add(this.signUp);
            this.startPanel.Location = new System.Drawing.Point(111, 71);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(740, 446);
            this.startPanel.TabIndex = 6;
            // 
            // logInPanel
            // 
            this.logInPanel.Location = new System.Drawing.Point(191, 57);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(619, 486);
            this.logInPanel.TabIndex = 7;
            this.logInPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.logInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Pizza Delivery App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel logInPanel;
    }
}

