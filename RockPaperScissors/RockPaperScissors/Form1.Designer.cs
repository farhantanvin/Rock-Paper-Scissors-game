namespace RockPaperScissors
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
            this.playerl = new System.Windows.Forms.Label();
            this.computerl = new System.Windows.Forms.Label();
            this.vsl = new System.Windows.Forms.Label();
            this.rockb = new System.Windows.Forms.Button();
            this.paperb = new System.Windows.Forms.Button();
            this.scissorb = new System.Windows.Forms.Button();
            this.scorel = new System.Windows.Forms.Label();
            this.playerscorel = new System.Windows.Forms.Label();
            this.ComputerScorel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.closeb = new System.Windows.Forms.Button();
            this.matchResultl = new System.Windows.Forms.Label();
            this.computerscissor = new System.Windows.Forms.PictureBox();
            this.computerrock = new System.Windows.Forms.PictureBox();
            this.playerpaper = new System.Windows.Forms.PictureBox();
            this.playerrock = new System.Windows.Forms.PictureBox();
            this.computerpaper = new System.Windows.Forms.PictureBox();
            this.playerscissor = new System.Windows.Forms.PictureBox();
            this.resetb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choicel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerscissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerrock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerrock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerscissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerl
            // 
            this.playerl.AutoSize = true;
            this.playerl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerl.Location = new System.Drawing.Point(84, 98);
            this.playerl.Name = "playerl";
            this.playerl.Size = new System.Drawing.Size(94, 37);
            this.playerl.TabIndex = 0;
            this.playerl.Text = "Player";
            this.playerl.Click += new System.EventHandler(this.playerl_Click);
            // 
            // computerl
            // 
            this.computerl.AutoSize = true;
            this.computerl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerl.Location = new System.Drawing.Point(426, 98);
            this.computerl.Name = "computerl";
            this.computerl.Size = new System.Drawing.Size(141, 37);
            this.computerl.TabIndex = 1;
            this.computerl.Text = "Computer";
            // 
            // vsl
            // 
            this.vsl.AutoSize = true;
            this.vsl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsl.Location = new System.Drawing.Point(294, 256);
            this.vsl.Name = "vsl";
            this.vsl.Size = new System.Drawing.Size(38, 29);
            this.vsl.TabIndex = 4;
            this.vsl.Text = "VS";
            // 
            // rockb
            // 
            this.rockb.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockb.Location = new System.Drawing.Point(57, 533);
            this.rockb.Name = "rockb";
            this.rockb.Size = new System.Drawing.Size(95, 39);
            this.rockb.TabIndex = 5;
            this.rockb.Text = "Rock";
            this.rockb.UseVisualStyleBackColor = true;
            this.rockb.Click += new System.EventHandler(this.rockb_Click);
            // 
            // paperb
            // 
            this.paperb.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperb.Location = new System.Drawing.Point(57, 584);
            this.paperb.Name = "paperb";
            this.paperb.Size = new System.Drawing.Size(95, 46);
            this.paperb.TabIndex = 6;
            this.paperb.Text = "Paper";
            this.paperb.UseVisualStyleBackColor = true;
            this.paperb.Click += new System.EventHandler(this.paperb_Click);
            // 
            // scissorb
            // 
            this.scissorb.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorb.Location = new System.Drawing.Point(57, 642);
            this.scissorb.Name = "scissorb";
            this.scissorb.Size = new System.Drawing.Size(95, 41);
            this.scissorb.TabIndex = 7;
            this.scissorb.Text = "Scissor";
            this.scissorb.UseVisualStyleBackColor = true;
            this.scissorb.Click += new System.EventHandler(this.scissorb_Click);
            // 
            // scorel
            // 
            this.scorel.AutoSize = true;
            this.scorel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorel.Location = new System.Drawing.Point(820, 98);
            this.scorel.Name = "scorel";
            this.scorel.Size = new System.Drawing.Size(94, 37);
            this.scorel.TabIndex = 9;
            this.scorel.Text = "Score:";
            // 
            // playerscorel
            // 
            this.playerscorel.AutoSize = true;
            this.playerscorel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerscorel.Location = new System.Drawing.Point(636, 543);
            this.playerscorel.Name = "playerscorel";
            this.playerscorel.Size = new System.Drawing.Size(65, 23);
            this.playerscorel.TabIndex = 10;
            this.playerscorel.Text = "Player:";
            this.playerscorel.Click += new System.EventHandler(this.playerscorel_Click);
            // 
            // ComputerScorel
            // 
            this.ComputerScorel.AutoSize = true;
            this.ComputerScorel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScorel.Location = new System.Drawing.Point(778, 543);
            this.ComputerScorel.Name = "ComputerScorel";
            this.ComputerScorel.Size = new System.Drawing.Size(94, 23);
            this.ComputerScorel.TabIndex = 11;
            this.ComputerScorel.Text = "Computer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(640, 573);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(782, 573);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // closeb
            // 
            this.closeb.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeb.Location = new System.Drawing.Point(985, 633);
            this.closeb.Name = "closeb";
            this.closeb.Size = new System.Drawing.Size(96, 37);
            this.closeb.TabIndex = 14;
            this.closeb.Text = "Close";
            this.closeb.UseVisualStyleBackColor = true;
            this.closeb.Click += new System.EventHandler(this.closeb_Click);
            // 
            // matchResultl
            // 
            this.matchResultl.AutoSize = true;
            this.matchResultl.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchResultl.Location = new System.Drawing.Point(241, 553);
            this.matchResultl.Name = "matchResultl";
            this.matchResultl.Size = new System.Drawing.Size(141, 19);
            this.matchResultl.TabIndex = 15;
            this.matchResultl.Text = "Match result";
            this.matchResultl.Visible = false;
            this.matchResultl.Click += new System.EventHandler(this.matchResultl_Click);
            // 
            // computerscissor
            // 
            this.computerscissor.Image = global::RockPaperScissors.Properties.Resources.scissors;
            this.computerscissor.Location = new System.Drawing.Point(409, 153);
            this.computerscissor.Name = "computerscissor";
            this.computerscissor.Size = new System.Drawing.Size(168, 294);
            this.computerscissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerscissor.TabIndex = 19;
            this.computerscissor.TabStop = false;
            // 
            // computerrock
            // 
            this.computerrock.Image = global::RockPaperScissors.Properties.Resources.rock;
            this.computerrock.Location = new System.Drawing.Point(409, 153);
            this.computerrock.Name = "computerrock";
            this.computerrock.Size = new System.Drawing.Size(168, 294);
            this.computerrock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerrock.TabIndex = 18;
            this.computerrock.TabStop = false;
            this.computerrock.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // playerpaper
            // 
            this.playerpaper.Image = global::RockPaperScissors.Properties.Resources.paper;
            this.playerpaper.Location = new System.Drawing.Point(57, 145);
            this.playerpaper.Name = "playerpaper";
            this.playerpaper.Size = new System.Drawing.Size(164, 302);
            this.playerpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerpaper.TabIndex = 17;
            this.playerpaper.TabStop = false;
            this.playerpaper.Click += new System.EventHandler(this.playerpaper_Click);
            // 
            // playerrock
            // 
            this.playerrock.Image = global::RockPaperScissors.Properties.Resources.rock;
            this.playerrock.Location = new System.Drawing.Point(57, 145);
            this.playerrock.Name = "playerrock";
            this.playerrock.Size = new System.Drawing.Size(164, 302);
            this.playerrock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerrock.TabIndex = 16;
            this.playerrock.TabStop = false;
            // 
            // computerpaper
            // 
            this.computerpaper.ErrorImage = null;
            this.computerpaper.Image = global::RockPaperScissors.Properties.Resources.paper;
            this.computerpaper.InitialImage = null;
            this.computerpaper.Location = new System.Drawing.Point(409, 153);
            this.computerpaper.Name = "computerpaper";
            this.computerpaper.Size = new System.Drawing.Size(168, 294);
            this.computerpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerpaper.TabIndex = 3;
            this.computerpaper.TabStop = false;
            this.computerpaper.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // playerscissor
            // 
            this.playerscissor.ErrorImage = null;
            this.playerscissor.Image = global::RockPaperScissors.Properties.Resources.scissors;
            this.playerscissor.InitialImage = null;
            this.playerscissor.Location = new System.Drawing.Point(57, 145);
            this.playerscissor.Name = "playerscissor";
            this.playerscissor.Size = new System.Drawing.Size(164, 302);
            this.playerscissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerscissor.TabIndex = 2;
            this.playerscissor.TabStop = false;
            // 
            // resetb
            // 
            this.resetb.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetb.Location = new System.Drawing.Point(971, 549);
            this.resetb.Name = "resetb";
            this.resetb.Size = new System.Drawing.Size(110, 47);
            this.resetb.TabIndex = 20;
            this.resetb.Text = "Reset";
            this.resetb.UseVisualStyleBackColor = true;
            this.resetb.Click += new System.EventHandler(this.resetb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(640, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(459, 349);
            this.dataGridView1.TabIndex = 21;
            // 
            // choicel
            // 
            this.choicel.AutoSize = true;
            this.choicel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choicel.Location = new System.Drawing.Point(53, 496);
            this.choicel.Name = "choicel";
            this.choicel.Size = new System.Drawing.Size(187, 24);
            this.choicel.TabIndex = 22;
            this.choicel.Text = "Choose your option :";
            this.choicel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter you name and press \'Enter\' :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(380, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 32);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 703);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choicel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resetb);
            this.Controls.Add(this.computerscissor);
            this.Controls.Add(this.computerrock);
            this.Controls.Add(this.playerpaper);
            this.Controls.Add(this.playerrock);
            this.Controls.Add(this.matchResultl);
            this.Controls.Add(this.closeb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComputerScorel);
            this.Controls.Add(this.playerscorel);
            this.Controls.Add(this.scorel);
            this.Controls.Add(this.scissorb);
            this.Controls.Add(this.paperb);
            this.Controls.Add(this.rockb);
            this.Controls.Add(this.vsl);
            this.Controls.Add(this.computerpaper);
            this.Controls.Add(this.playerscissor);
            this.Controls.Add(this.computerl);
            this.Controls.Add(this.playerl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerscissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerrock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerrock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerscissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerl;
        private System.Windows.Forms.Label computerl;
        private System.Windows.Forms.PictureBox playerscissor;
        private System.Windows.Forms.PictureBox computerpaper;
        private System.Windows.Forms.Label vsl;
        private System.Windows.Forms.Button rockb;
        private System.Windows.Forms.Button paperb;
        private System.Windows.Forms.Button scissorb;
        private System.Windows.Forms.Label scorel;
        private System.Windows.Forms.Label playerscorel;
        private System.Windows.Forms.Label ComputerScorel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button closeb;
        private System.Windows.Forms.Label matchResultl;
        private System.Windows.Forms.PictureBox playerrock;
        private System.Windows.Forms.PictureBox playerpaper;
        private System.Windows.Forms.PictureBox computerrock;
        private System.Windows.Forms.PictureBox computerscissor;
        private System.Windows.Forms.Button resetb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label choicel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

