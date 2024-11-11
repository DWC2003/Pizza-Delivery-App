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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logIn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.AboutUs = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.LogInConfirmButton = new System.Windows.Forms.Button();
            this.LogInPassField = new System.Windows.Forms.TextBox();
            this.LogInEmailField = new System.Windows.Forms.TextBox();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.OrderMainPanel = new System.Windows.Forms.Panel();
            this.NewOrderLabel = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.PictureBox();
            this.FavLabel = new System.Windows.Forms.Label();
            this.FavoritesButton = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.FavoritesPanel = new System.Windows.Forms.Panel();
            this.ReorderButton = new System.Windows.Forms.Button();
            this.FavList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FavLabel2 = new System.Windows.Forms.Label();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTestDataSet = new Pizza_Delivery_App.OrdersTestDataSet();
            this.ordersTableAdapter = new Pizza_Delivery_App.OrdersTestDataSetTableAdapters.OrdersTableAdapter();
            this.ordersTestDataSet1 = new Pizza_Delivery_App.OrdersTestDataSet();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.LogInPanel.SuspendLayout();
            this.OrderMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewOrderButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavoritesButton)).BeginInit();
            this.FavoritesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTestDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SignUpPanel.SuspendLayout();
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
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(337, 390);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(75, 29);
            this.Info.TabIndex = 4;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.button1_Click_1);
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
            this.startPanel.Controls.Add(this.Info);
            this.startPanel.Controls.Add(this.pictureBox1);
            this.startPanel.Controls.Add(this.signUp);
            this.startPanel.Location = new System.Drawing.Point(111, 71);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(740, 446);
            this.startPanel.TabIndex = 6;
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
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.AboutUs);
            this.InfoPanel.Location = new System.Drawing.Point(40, 49);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(907, 883);
            this.InfoPanel.TabIndex = 7;
            this.InfoPanel.Visible = false;
            this.InfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoPanel_Paint);
            // 
            // AboutUs
            // 
            this.AboutUs.AutoSize = true;
            this.AboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AboutUs.Location = new System.Drawing.Point(332, 120);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(290, 406);
            this.AboutUs.TabIndex = 0;
            this.AboutUs.Text = resources.GetString("AboutUs.Text");
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LogInPanel
            // 
            this.LogInPanel.Controls.Add(this.LogInConfirmButton);
            this.LogInPanel.Controls.Add(this.LogInPassField);
            this.LogInPanel.Controls.Add(this.LogInEmailField);
            this.LogInPanel.Controls.Add(this.LogInLabel);
            this.LogInPanel.Location = new System.Drawing.Point(37, 52);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(907, 883);
            this.LogInPanel.TabIndex = 9;
            this.LogInPanel.Visible = false;
            // 
            // LogInConfirmButton
            // 
            this.LogInConfirmButton.Location = new System.Drawing.Point(401, 279);
            this.LogInConfirmButton.Name = "LogInConfirmButton";
            this.LogInConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.LogInConfirmButton.TabIndex = 3;
            this.LogInConfirmButton.Text = "Log In";
            this.LogInConfirmButton.UseVisualStyleBackColor = true;
            this.LogInConfirmButton.Click += new System.EventHandler(this.LogInConfirmButton_Click);
            // 
            // LogInPassField
            // 
            this.LogInPassField.Location = new System.Drawing.Point(317, 233);
            this.LogInPassField.Name = "LogInPassField";
            this.LogInPassField.PasswordChar = '*';
            this.LogInPassField.Size = new System.Drawing.Size(247, 26);
            this.LogInPassField.TabIndex = 2;
            // 
            // LogInEmailField
            // 
            this.LogInEmailField.Location = new System.Drawing.Point(317, 189);
            this.LogInEmailField.Name = "LogInEmailField";
            this.LogInEmailField.Size = new System.Drawing.Size(247, 26);
            this.LogInEmailField.TabIndex = 1;
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogInLabel.Location = new System.Drawing.Point(406, 117);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(85, 29);
            this.LogInLabel.TabIndex = 0;
            this.LogInLabel.Text = "Log In!";
            // 
            // OrderMainPanel
            // 
            this.OrderMainPanel.Controls.Add(this.NewOrderLabel);
            this.OrderMainPanel.Controls.Add(this.NewOrderButton);
            this.OrderMainPanel.Controls.Add(this.FavLabel);
            this.OrderMainPanel.Controls.Add(this.FavoritesButton);
            this.OrderMainPanel.Controls.Add(this.WelcomeLabel);
            this.OrderMainPanel.Location = new System.Drawing.Point(34, 41);
            this.OrderMainPanel.Name = "OrderMainPanel";
            this.OrderMainPanel.Size = new System.Drawing.Size(913, 880);
            this.OrderMainPanel.TabIndex = 10;
            this.OrderMainPanel.Visible = false;
            // 
            // NewOrderLabel
            // 
            this.NewOrderLabel.AutoSize = true;
            this.NewOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewOrderLabel.Location = new System.Drawing.Point(551, 350);
            this.NewOrderLabel.Name = "NewOrderLabel";
            this.NewOrderLabel.Size = new System.Drawing.Size(170, 25);
            this.NewOrderLabel.TabIndex = 4;
            this.NewOrderLabel.Text = "Create New Order";
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Image = global::Pizza_Delivery_App.Properties.Resources.pizza;
            this.NewOrderButton.Location = new System.Drawing.Point(524, 183);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(176, 145);
            this.NewOrderButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NewOrderButton.TabIndex = 3;
            this.NewOrderButton.TabStop = false;
            // 
            // FavLabel
            // 
            this.FavLabel.AutoSize = true;
            this.FavLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FavLabel.Location = new System.Drawing.Point(209, 350);
            this.FavLabel.Name = "FavLabel";
            this.FavLabel.Size = new System.Drawing.Size(202, 25);
            this.FavLabel.TabIndex = 2;
            this.FavLabel.Text = "Select From Favorites";
            this.FavLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavoritesButton.Image = global::Pizza_Delivery_App.Properties.Resources.star;
            this.FavoritesButton.Location = new System.Drawing.Point(193, 183);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(169, 145);
            this.FavoritesButton.TabIndex = 1;
            this.FavoritesButton.TabStop = false;
            this.FavoritesButton.Click += new System.EventHandler(this.FavoritesButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WelcomeLabel.Location = new System.Drawing.Point(348, 65);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(322, 29);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome! Begin Your Order!";
            // 
            // FavoritesPanel
            // 
            this.FavoritesPanel.Controls.Add(this.ReorderButton);
            this.FavoritesPanel.Controls.Add(this.FavList);
            this.FavoritesPanel.Controls.Add(this.FavLabel2);
            this.FavoritesPanel.Location = new System.Drawing.Point(24, 49);
            this.FavoritesPanel.Name = "FavoritesPanel";
            this.FavoritesPanel.Size = new System.Drawing.Size(907, 883);
            this.FavoritesPanel.TabIndex = 11;
            this.FavoritesPanel.Visible = false;
            // 
            // ReorderButton
            // 
            this.ReorderButton.Location = new System.Drawing.Point(412, 462);
            this.ReorderButton.Name = "ReorderButton";
            this.ReorderButton.Size = new System.Drawing.Size(75, 23);
            this.ReorderButton.TabIndex = 3;
            this.ReorderButton.Text = "Reorder";
            this.ReorderButton.UseVisualStyleBackColor = true;
            // 
            // FavList
            // 
            this.FavList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.FavList.CheckBoxes = true;
            this.FavList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.FavList.HideSelection = false;
            this.FavList.Location = new System.Drawing.Point(203, 118);
            this.FavList.Name = "FavList";
            this.FavList.Size = new System.Drawing.Size(495, 323);
            this.FavList.TabIndex = 2;
            this.FavList.UseCompatibleStateImageBehavior = false;
            this.FavList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OrderID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item 1";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item 2";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item 3";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item 4";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Item 5";
            this.columnHeader6.Width = 200;
            // 
            // FavLabel2
            // 
            this.FavLabel2.AutoSize = true;
            this.FavLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FavLabel2.Location = new System.Drawing.Point(362, 53);
            this.FavLabel2.Name = "FavLabel2";
            this.FavLabel2.Size = new System.Drawing.Size(255, 29);
            this.FavLabel2.TabIndex = 0;
            this.FavLabel2.Text = "Select From Favorites!";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.ordersTestDataSet;
            // 
            // ordersTestDataSet
            // 
            this.ordersTestDataSet.DataSetName = "OrdersTestDataSet";
            this.ordersTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTestDataSet1
            // 
            this.ordersTestDataSet1.DataSetName = "OrdersTestDataSet";
            this.ordersTestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.ordersTestDataSet1;
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.button1);
            this.SignUpPanel.Controls.Add(this.textBox2);
            this.SignUpPanel.Controls.Add(this.textBox1);
            this.SignUpPanel.Controls.Add(this.label2);
            this.SignUpPanel.Location = new System.Drawing.Point(14, 49);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(917, 880);
            this.SignUpPanel.TabIndex = 12;
            this.SignUpPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(447, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign Up!";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.OrderMainPanel);
            this.Controls.Add(this.LogInPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.FavoritesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Pizza Delivery App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            this.OrderMainPanel.ResumeLayout(false);
            this.OrderMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewOrderButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavoritesButton)).EndInit();
            this.FavoritesPanel.ResumeLayout(false);
            this.FavoritesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTestDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label AboutUs;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.TextBox LogInEmailField;
        private System.Windows.Forms.TextBox LogInPassField;
        private System.Windows.Forms.Button LogInConfirmButton;
        private System.Windows.Forms.Panel OrderMainPanel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox FavoritesButton;
        private System.Windows.Forms.Label FavLabel;
        private System.Windows.Forms.PictureBox NewOrderButton;
        private System.Windows.Forms.Label NewOrderLabel;
        private System.Windows.Forms.Panel FavoritesPanel;
        private System.Windows.Forms.Label FavLabel2;
        private OrdersTestDataSet ordersTestDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrdersTestDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private OrdersTestDataSet ordersTestDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.ListView FavList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button ReorderButton;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

