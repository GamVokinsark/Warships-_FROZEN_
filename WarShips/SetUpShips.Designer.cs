namespace WarShips
{
    partial class SetUpShips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpShips));
            this.title = new System.Windows.Forms.Label();
            this.movingPanel = new System.Windows.Forms.Panel();
            this.closeBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.escapeBut = new System.Windows.Forms.Label();
            this.fieldPanel = new System.Windows.Forms.Panel();
            this.lettersHandler = new System.Windows.Forms.Panel();
            this.LtMrk1 = new System.Windows.Forms.Label();
            this.LtMrk2 = new System.Windows.Forms.Label();
            this.LtMrk3 = new System.Windows.Forms.Label();
            this.LtMrk4 = new System.Windows.Forms.Label();
            this.LtMrk5 = new System.Windows.Forms.Label();
            this.LtMrk6 = new System.Windows.Forms.Label();
            this.LtMrk7 = new System.Windows.Forms.Label();
            this.LtMrk8 = new System.Windows.Forms.Label();
            this.LtMrk9 = new System.Windows.Forms.Label();
            this.LtMrk10 = new System.Windows.Forms.Label();
            this.numberHandler = new System.Windows.Forms.Panel();
            this.NmMrk1 = new System.Windows.Forms.Label();
            this.NmMrk2 = new System.Windows.Forms.Label();
            this.NmMrk3 = new System.Windows.Forms.Label();
            this.NmMrk4 = new System.Windows.Forms.Label();
            this.NmMrk5 = new System.Windows.Forms.Label();
            this.NmMrk6 = new System.Windows.Forms.Label();
            this.NmMrk7 = new System.Windows.Forms.Label();
            this.NmMrk8 = new System.Windows.Forms.Label();
            this.NmMrk9 = new System.Windows.Forms.Label();
            this.NmMrk10 = new System.Windows.Forms.Label();
            this.movingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fieldPanel.SuspendLayout();
            this.lettersHandler.SuspendLayout();
            this.numberHandler.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(3, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(126, 28);
            this.title.TabIndex = 1;
            this.title.Text = "Warships 6.0";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.LightGray;
            this.movingPanel.Controls.Add(this.title);
            this.movingPanel.Controls.Add(this.closeBut);
            this.movingPanel.Location = new System.Drawing.Point(0, 0);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(800, 40);
            this.movingPanel.TabIndex = 2;
            this.movingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.movingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.movingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // closeBut
            // 
            this.closeBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBut.BackgroundImage")));
            this.closeBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBut.FlatAppearance.BorderSize = 0;
            this.closeBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Location = new System.Drawing.Point(760, 0);
            this.closeBut.Margin = new System.Windows.Forms.Padding(0);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(40, 40);
            this.closeBut.TabIndex = 0;
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 560);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // escapeBut
            // 
            this.escapeBut.AutoSize = true;
            this.escapeBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.escapeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escapeBut.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escapeBut.ForeColor = System.Drawing.Color.Black;
            this.escapeBut.Location = new System.Drawing.Point(12, 555);
            this.escapeBut.Name = "escapeBut";
            this.escapeBut.Size = new System.Drawing.Size(94, 36);
            this.escapeBut.TabIndex = 5;
            this.escapeBut.Text = "Назад";
            this.escapeBut.Click += new System.EventHandler(this.escapeBut_Click);
            this.escapeBut.MouseEnter += new System.EventHandler(this.label_mouse_enter);
            this.escapeBut.MouseLeave += new System.EventHandler(this.label_mouse_leave);
            // 
            // fieldPanel
            // 
            this.fieldPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fieldPanel.Controls.Add(this.numberHandler);
            this.fieldPanel.Controls.Add(this.lettersHandler);
            this.fieldPanel.Location = new System.Drawing.Point(95, 103);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(334, 334);
            this.fieldPanel.TabIndex = 1;
            // 
            // lettersHandler
            // 
            this.lettersHandler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lettersHandler.Controls.Add(this.LtMrk10);
            this.lettersHandler.Controls.Add(this.LtMrk9);
            this.lettersHandler.Controls.Add(this.LtMrk8);
            this.lettersHandler.Controls.Add(this.LtMrk7);
            this.lettersHandler.Controls.Add(this.LtMrk6);
            this.lettersHandler.Controls.Add(this.LtMrk5);
            this.lettersHandler.Controls.Add(this.LtMrk4);
            this.lettersHandler.Controls.Add(this.LtMrk3);
            this.lettersHandler.Controls.Add(this.LtMrk2);
            this.lettersHandler.Controls.Add(this.LtMrk1);
            this.lettersHandler.Location = new System.Drawing.Point(2, 2);
            this.lettersHandler.Name = "lettersHandler";
            this.lettersHandler.Size = new System.Drawing.Size(330, 30);
            this.lettersHandler.TabIndex = 0;
            // 
            // LtMrk1
            // 
            this.LtMrk1.AutoSize = true;
            this.LtMrk1.BackColor = System.Drawing.Color.Transparent;
            this.LtMrk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk1.Location = new System.Drawing.Point(30, 0);
            this.LtMrk1.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk1.Name = "LtMrk1";
            this.LtMrk1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk1.Size = new System.Drawing.Size(30, 30);
            this.LtMrk1.TabIndex = 0;
            this.LtMrk1.Text = "Р";
            // 
            // LtMrk2
            // 
            this.LtMrk2.AutoSize = true;
            this.LtMrk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk2.Location = new System.Drawing.Point(60, 0);
            this.LtMrk2.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk2.Name = "LtMrk2";
            this.LtMrk2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk2.Size = new System.Drawing.Size(30, 30);
            this.LtMrk2.TabIndex = 0;
            this.LtMrk2.Text = "Е";
            // 
            // LtMrk3
            // 
            this.LtMrk3.AutoSize = true;
            this.LtMrk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk3.Location = new System.Drawing.Point(90, 0);
            this.LtMrk3.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk3.Name = "LtMrk3";
            this.LtMrk3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk3.Size = new System.Drawing.Size(30, 30);
            this.LtMrk3.TabIndex = 0;
            this.LtMrk3.Text = "С";
            // 
            // LtMrk4
            // 
            this.LtMrk4.AutoSize = true;
            this.LtMrk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk4.Location = new System.Drawing.Point(120, 0);
            this.LtMrk4.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk4.Name = "LtMrk4";
            this.LtMrk4.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk4.Size = new System.Drawing.Size(30, 30);
            this.LtMrk4.TabIndex = 0;
            this.LtMrk4.Text = "П";
            // 
            // LtMrk5
            // 
            this.LtMrk5.AutoSize = true;
            this.LtMrk5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk5.Location = new System.Drawing.Point(150, 0);
            this.LtMrk5.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk5.Name = "LtMrk5";
            this.LtMrk5.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk5.Size = new System.Drawing.Size(30, 30);
            this.LtMrk5.TabIndex = 0;
            this.LtMrk5.Text = "У";
            // 
            // LtMrk6
            // 
            this.LtMrk6.AutoSize = true;
            this.LtMrk6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk6.Location = new System.Drawing.Point(180, 0);
            this.LtMrk6.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk6.Name = "LtMrk6";
            this.LtMrk6.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk6.Size = new System.Drawing.Size(30, 30);
            this.LtMrk6.TabIndex = 0;
            this.LtMrk6.Text = "Б";
            // 
            // LtMrk7
            // 
            this.LtMrk7.AutoSize = true;
            this.LtMrk7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk7.Location = new System.Drawing.Point(210, 0);
            this.LtMrk7.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk7.Name = "LtMrk7";
            this.LtMrk7.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk7.Size = new System.Drawing.Size(30, 30);
            this.LtMrk7.TabIndex = 0;
            this.LtMrk7.Text = "Л";
            // 
            // LtMrk8
            // 
            this.LtMrk8.AutoSize = true;
            this.LtMrk8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk8.Location = new System.Drawing.Point(240, 0);
            this.LtMrk8.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk8.Name = "LtMrk8";
            this.LtMrk8.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk8.Size = new System.Drawing.Size(30, 30);
            this.LtMrk8.TabIndex = 0;
            this.LtMrk8.Text = "И";
            // 
            // LtMrk9
            // 
            this.LtMrk9.AutoSize = true;
            this.LtMrk9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk9.Location = new System.Drawing.Point(270, 0);
            this.LtMrk9.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk9.Name = "LtMrk9";
            this.LtMrk9.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk9.Size = new System.Drawing.Size(30, 30);
            this.LtMrk9.TabIndex = 0;
            this.LtMrk9.Text = "К";
            // 
            // LtMrk10
            // 
            this.LtMrk10.AutoSize = true;
            this.LtMrk10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtMrk10.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LtMrk10.Location = new System.Drawing.Point(300, 0);
            this.LtMrk10.Margin = new System.Windows.Forms.Padding(0);
            this.LtMrk10.Name = "LtMrk10";
            this.LtMrk10.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.LtMrk10.Size = new System.Drawing.Size(30, 30);
            this.LtMrk10.TabIndex = 0;
            this.LtMrk10.Text = "А";
            // 
            // numberHandler
            // 
            this.numberHandler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.numberHandler.Controls.Add(this.NmMrk10);
            this.numberHandler.Controls.Add(this.NmMrk9);
            this.numberHandler.Controls.Add(this.NmMrk8);
            this.numberHandler.Controls.Add(this.NmMrk7);
            this.numberHandler.Controls.Add(this.NmMrk6);
            this.numberHandler.Controls.Add(this.NmMrk5);
            this.numberHandler.Controls.Add(this.NmMrk4);
            this.numberHandler.Controls.Add(this.NmMrk3);
            this.numberHandler.Controls.Add(this.NmMrk2);
            this.numberHandler.Controls.Add(this.NmMrk1);
            this.numberHandler.Location = new System.Drawing.Point(2, 32);
            this.numberHandler.Name = "numberHandler";
            this.numberHandler.Size = new System.Drawing.Size(30, 300);
            this.numberHandler.TabIndex = 1;
            // 
            // NmMrk1
            // 
            this.NmMrk1.AutoSize = true;
            this.NmMrk1.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk1.Location = new System.Drawing.Point(0, 0);
            this.NmMrk1.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk1.Name = "NmMrk1";
            this.NmMrk1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk1.Size = new System.Drawing.Size(30, 30);
            this.NmMrk1.TabIndex = 0;
            this.NmMrk1.Text = "1";
            // 
            // NmMrk2
            // 
            this.NmMrk2.AutoSize = true;
            this.NmMrk2.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk2.Location = new System.Drawing.Point(0, 30);
            this.NmMrk2.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk2.Name = "NmMrk2";
            this.NmMrk2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk2.Size = new System.Drawing.Size(30, 30);
            this.NmMrk2.TabIndex = 0;
            this.NmMrk2.Text = "2";
            // 
            // NmMrk3
            // 
            this.NmMrk3.AutoSize = true;
            this.NmMrk3.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk3.Location = new System.Drawing.Point(0, 60);
            this.NmMrk3.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk3.Name = "NmMrk3";
            this.NmMrk3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk3.Size = new System.Drawing.Size(30, 30);
            this.NmMrk3.TabIndex = 0;
            this.NmMrk3.Text = "3";
            // 
            // NmMrk4
            // 
            this.NmMrk4.AutoSize = true;
            this.NmMrk4.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk4.Location = new System.Drawing.Point(0, 90);
            this.NmMrk4.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk4.Name = "NmMrk4";
            this.NmMrk4.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk4.Size = new System.Drawing.Size(30, 30);
            this.NmMrk4.TabIndex = 0;
            this.NmMrk4.Text = "4";
            // 
            // NmMrk5
            // 
            this.NmMrk5.AutoSize = true;
            this.NmMrk5.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk5.Location = new System.Drawing.Point(0, 120);
            this.NmMrk5.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk5.Name = "NmMrk5";
            this.NmMrk5.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk5.Size = new System.Drawing.Size(30, 30);
            this.NmMrk5.TabIndex = 0;
            this.NmMrk5.Text = "5";
            // 
            // NmMrk6
            // 
            this.NmMrk6.AutoSize = true;
            this.NmMrk6.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk6.Location = new System.Drawing.Point(0, 150);
            this.NmMrk6.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk6.Name = "NmMrk6";
            this.NmMrk6.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk6.Size = new System.Drawing.Size(30, 30);
            this.NmMrk6.TabIndex = 0;
            this.NmMrk6.Text = "6";
            // 
            // NmMrk7
            // 
            this.NmMrk7.AutoSize = true;
            this.NmMrk7.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk7.Location = new System.Drawing.Point(0, 180);
            this.NmMrk7.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk7.Name = "NmMrk7";
            this.NmMrk7.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk7.Size = new System.Drawing.Size(30, 30);
            this.NmMrk7.TabIndex = 0;
            this.NmMrk7.Text = "7";
            // 
            // NmMrk8
            // 
            this.NmMrk8.AutoSize = true;
            this.NmMrk8.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk8.Location = new System.Drawing.Point(0, 210);
            this.NmMrk8.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk8.Name = "NmMrk8";
            this.NmMrk8.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk8.Size = new System.Drawing.Size(30, 30);
            this.NmMrk8.TabIndex = 0;
            this.NmMrk8.Text = "8";
            // 
            // NmMrk9
            // 
            this.NmMrk9.AutoSize = true;
            this.NmMrk9.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk9.Location = new System.Drawing.Point(0, 240);
            this.NmMrk9.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk9.Name = "NmMrk9";
            this.NmMrk9.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.NmMrk9.Size = new System.Drawing.Size(30, 30);
            this.NmMrk9.TabIndex = 0;
            this.NmMrk9.Text = "9";
            // 
            // NmMrk10
            // 
            this.NmMrk10.AutoSize = true;
            this.NmMrk10.BackColor = System.Drawing.Color.Transparent;
            this.NmMrk10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NmMrk10.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NmMrk10.Location = new System.Drawing.Point(-4, 270);
            this.NmMrk10.Margin = new System.Windows.Forms.Padding(0);
            this.NmMrk10.Name = "NmMrk10";
            this.NmMrk10.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.NmMrk10.Size = new System.Drawing.Size(42, 30);
            this.NmMrk10.TabIndex = 0;
            this.NmMrk10.Text = "10";
            // 
            // SetUpShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.fieldPanel);
            this.Controls.Add(this.escapeBut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.movingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetUpShips";
            this.Text = "SetUpShips";
            this.movingPanel.ResumeLayout(false);
            this.movingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fieldPanel.ResumeLayout(false);
            this.lettersHandler.ResumeLayout(false);
            this.lettersHandler.PerformLayout();
            this.numberHandler.ResumeLayout(false);
            this.numberHandler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel movingPanel;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label escapeBut;
        private System.Windows.Forms.Panel fieldPanel;
        private System.Windows.Forms.Panel lettersHandler;
        private System.Windows.Forms.Label LtMrk10;
        private System.Windows.Forms.Label LtMrk9;
        private System.Windows.Forms.Label LtMrk8;
        private System.Windows.Forms.Label LtMrk7;
        private System.Windows.Forms.Label LtMrk6;
        private System.Windows.Forms.Label LtMrk5;
        private System.Windows.Forms.Label LtMrk4;
        private System.Windows.Forms.Label LtMrk3;
        private System.Windows.Forms.Label LtMrk2;
        private System.Windows.Forms.Label LtMrk1;
        private System.Windows.Forms.Panel numberHandler;
        private System.Windows.Forms.Label NmMrk10;
        private System.Windows.Forms.Label NmMrk9;
        private System.Windows.Forms.Label NmMrk8;
        private System.Windows.Forms.Label NmMrk7;
        private System.Windows.Forms.Label NmMrk6;
        private System.Windows.Forms.Label NmMrk5;
        private System.Windows.Forms.Label NmMrk4;
        private System.Windows.Forms.Label NmMrk3;
        private System.Windows.Forms.Label NmMrk2;
        private System.Windows.Forms.Label NmMrk1;
    }
}