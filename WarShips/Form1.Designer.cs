using System.Drawing;

namespace WarShips
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CloseBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startBut = new System.Windows.Forms.Label();
            this.optionBut = new System.Windows.Forms.Label();
            this.profileBut = new System.Windows.Forms.Label();
            this.statisticBut = new System.Windows.Forms.Label();
            this.historyBut = new System.Windows.Forms.Label();
            this.exitBut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.CloseBut.TabIndex = 0;
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.CloseBut);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 560);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // startBut
            // 
            this.startBut.AutoSize = true;
            this.startBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.startBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBut.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.ForeColor = System.Drawing.Color.Black;
            this.startBut.Location = new System.Drawing.Point(64, 84);
            this.startBut.Name = "startBut";
            this.startBut.Padding = new System.Windows.Forms.Padding(5);
            this.startBut.Size = new System.Drawing.Size(172, 46);
            this.startBut.TabIndex = 3;
            this.startBut.Text = "Начать игру";
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            this.startBut.MouseEnter += new System.EventHandler(this.label_mouse_enter);
            this.startBut.MouseLeave += new System.EventHandler(this.label_mouse_leave);
            // 
            // optionBut
            // 
            this.optionBut.AutoSize = true;
            this.optionBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.optionBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionBut.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionBut.ForeColor = System.Drawing.Color.Black;
            this.optionBut.Location = new System.Drawing.Point(64, 171);
            this.optionBut.Name = "optionBut";
            this.optionBut.Padding = new System.Windows.Forms.Padding(5);
            this.optionBut.Size = new System.Drawing.Size(159, 46);
            this.optionBut.TabIndex = 3;
            this.optionBut.Text = "Настройки";
            this.optionBut.Click += new System.EventHandler(this.optionBut_Click);
            this.optionBut.MouseEnter += new System.EventHandler(this.label_mouse_enter);
            this.optionBut.MouseLeave += new System.EventHandler(this.label_mouse_leave);
            // 
            // profileBut
            // 
            this.profileBut.AutoSize = true;
            this.profileBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.profileBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBut.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileBut.ForeColor = System.Drawing.Color.Black;
            this.profileBut.Location = new System.Drawing.Point(64, 345);
            this.profileBut.Name = "profileBut";
            this.profileBut.Padding = new System.Windows.Forms.Padding(5);
            this.profileBut.Size = new System.Drawing.Size(225, 46);
            this.profileBut.TabIndex = 3;
            this.profileBut.Text = "Смена профиля";
            this.profileBut.MouseEnter += new System.EventHandler(this.label_mouse_enter);
            this.profileBut.MouseLeave += new System.EventHandler(this.label_mouse_leave);
            // 
            // statisticBut
            // 
            this.statisticBut.AutoSize = true;
            this.statisticBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.statisticBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticBut.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticBut.ForeColor = System.Drawing.Color.Black;
            this.statisticBut.Location = new System.Drawing.Point(64, 258);
            this.statisticBut.Name = "statisticBut";
            this.statisticBut.Padding = new System.Windows.Forms.Padding(5);
            this.statisticBut.Size = new System.Drawing.Size(168, 46);
            this.statisticBut.TabIndex = 3;
            this.statisticBut.Text = "Статистика";
            this.statisticBut.MouseEnter += new System.EventHandler(this.label_mouse_enter);
            this.statisticBut.MouseLeave += new System.EventHandler(this.label_mouse_leave);
            // 
            // historyBut
            // 
            this.historyBut.AutoSize = true;
            this.historyBut.BackColor = System.Drawing.Color.Gainsboro;
            this.historyBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBut.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyBut.ForeColor = System.Drawing.Color.Black;
            this.historyBut.Location = new System.Drawing.Point(64, 432);
            this.historyBut.Name = "historyBut";
            this.historyBut.Padding = new System.Windows.Forms.Padding(5);
            this.historyBut.Size = new System.Drawing.Size(193, 46);
            this.historyBut.TabIndex = 3;
            this.historyBut.Text = "История боев";
            this.historyBut.MouseEnter += new System.EventHandler(this.label_mouse_enter);
            this.historyBut.MouseLeave += new System.EventHandler(this.label_mouse_leave);
            // 
            // exitBut
            // 
            this.exitBut.AutoSize = true;
            this.exitBut.BackColor = System.Drawing.Color.Gainsboro;
            this.exitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBut.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBut.ForeColor = System.Drawing.Color.Black;
            this.exitBut.Location = new System.Drawing.Point(64, 519);
            this.exitBut.Name = "exitBut";
            this.exitBut.Padding = new System.Windows.Forms.Padding(5);
            this.exitBut.Size = new System.Drawing.Size(109, 46);
            this.exitBut.TabIndex = 3;
            this.exitBut.Text = "Выход";
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            this.exitBut.MouseEnter += new System.EventHandler(this.label_mouse_enter);
            this.exitBut.MouseLeave += new System.EventHandler(this.label_mouse_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(553, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 79);
            this.label2.TabIndex = 4;
            this.label2.Text = "Warships";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.historyBut);
            this.Controls.Add(this.statisticBut);
            this.Controls.Add(this.profileBut);
            this.Controls.Add(this.optionBut);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label startBut;
        private System.Windows.Forms.Label optionBut;
        private System.Windows.Forms.Label profileBut;
        private System.Windows.Forms.Label statisticBut;
        private System.Windows.Forms.Label historyBut;
        private System.Windows.Forms.Label exitBut;
        private System.Windows.Forms.Label label2;
    }
}

