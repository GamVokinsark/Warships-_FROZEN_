namespace WarShips
{
    partial class options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(options));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bckSndVol = new System.Windows.Forms.TrackBar();
            this.escapeBut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sndVol = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.markSelect = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bckSndVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sndVol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.CloseBut);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(2, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(126, 28);
            this.title.TabIndex = 3;
            this.title.Text = "Warships 6.0";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // CloseBut
            // 
            this.CloseBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBut.BackgroundImage")));
            this.CloseBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBut.FlatAppearance.BorderSize = 0;
            this.CloseBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBut.Location = new System.Drawing.Point(760, 0);
            this.CloseBut.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(40, 40);
            this.CloseBut.TabIndex = 2;
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 560);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.Location = new System.Drawing.Point(308, 63);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(182, 43);
            this.Label.TabIndex = 4;
            this.Label.Text = "Настройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 130);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 1, 3);
            this.label1.Size = new System.Drawing.Size(282, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Громкость музыки";
            // 
            // bckSndVol
            // 
            this.bckSndVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bckSndVol.LargeChange = 100;
            this.bckSndVol.Location = new System.Drawing.Point(489, 130);
            this.bckSndVol.Maximum = 0;
            this.bckSndVol.Minimum = -5000;
            this.bckSndVol.Name = "bckSndVol";
            this.bckSndVol.Size = new System.Drawing.Size(204, 45);
            this.bckSndVol.SmallChange = 100;
            this.bckSndVol.TabIndex = 100;
            this.bckSndVol.TabStop = false;
            this.bckSndVol.TickFrequency = 500;
            this.bckSndVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.bckSndVol.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // escapeBut
            // 
            this.escapeBut.AutoSize = true;
            this.escapeBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.escapeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escapeBut.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escapeBut.ForeColor = System.Drawing.Color.Black;
            this.escapeBut.Location = new System.Drawing.Point(63, 507);
            this.escapeBut.Name = "escapeBut";
            this.escapeBut.Padding = new System.Windows.Forms.Padding(5);
            this.escapeBut.Size = new System.Drawing.Size(124, 53);
            this.escapeBut.TabIndex = 4;
            this.escapeBut.Text = "Назад";
            this.escapeBut.Click += new System.EventHandler(this.escapeBut_Click);
            this.escapeBut.MouseEnter += new System.EventHandler(this.label_mouse_enter);
            this.escapeBut.MouseLeave += new System.EventHandler(this.label_mouse_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 197);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 3, 11, 3);
            this.label2.Size = new System.Drawing.Size(282, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Громкость звуков";
            // 
            // sndVol
            // 
            this.sndVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.sndVol.LargeChange = 100;
            this.sndVol.Location = new System.Drawing.Point(489, 197);
            this.sndVol.Maximum = 0;
            this.sndVol.Minimum = -5000;
            this.sndVol.Name = "sndVol";
            this.sndVol.Size = new System.Drawing.Size(204, 45);
            this.sndVol.SmallChange = 100;
            this.sndVol.TabIndex = 100;
            this.sndVol.TabStop = false;
            this.sndVol.TickFrequency = 500;
            this.sndVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sndVol.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 268);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(9, 0, 12, 0);
            this.label3.Size = new System.Drawing.Size(282, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Маркировка поля";
            // 
            // markSelect
            // 
            this.markSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.markSelect.DisplayMember = "РЕСПУБЛИКА";
            this.markSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markSelect.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markSelect.FormattingEnabled = true;
            this.markSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.markSelect.IntegralHeight = false;
            this.markSelect.ItemHeight = 32;
            this.markSelect.Items.AddRange(new object[] {
            "АБВГДЕЖЗИК",
            "АГРОТЕХНИК",
            "БЛАЖЕНСТВО",
            "ГИПОТЕНУЗА",
            "ДЕМОКРАТИЯ",
            "МУРАВЕЙНИК",
            "ПРАВОСУДИЕ",
            "РЕСПУБЛИКА",
            "СНЕГУРОЧКА",
            "СПРАВОЧНИК",
            "ТРУДОЛЮБИЕ",
            "ЦЕНТРИФУГА",
            "ЭКСПЕРТИЗА"});
            this.markSelect.Location = new System.Drawing.Point(489, 268);
            this.markSelect.Name = "markSelect";
            this.markSelect.Size = new System.Drawing.Size(204, 40);
            this.markSelect.TabIndex = 1;
            this.markSelect.TabStop = false;
            this.markSelect.DropDownClosed += new System.EventHandler(this.comboBox1_GotFocus);
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.markSelect);
            this.Controls.Add(this.sndVol);
            this.Controls.Add(this.bckSndVol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.escapeBut);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "options";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bckSndVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sndVol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar bckSndVol;
        private System.Windows.Forms.Label escapeBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sndVol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox markSelect;

    }
}