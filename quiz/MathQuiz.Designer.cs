
namespace quiz
{
    partial class MathQuiz
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
            this.TimeLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeft = new System.Windows.Forms.Label();
            this.multiLeft = new System.Windows.Forms.Label();
            this.minLeft = new System.Windows.Forms.Label();
            this.divLeft = new System.Windows.Forms.Label();
            this.minRight = new System.Windows.Forms.Label();
            this.plusRight = new System.Windows.Forms.Label();
            this.multiRight = new System.Windows.Forms.Label();
            this.divRight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.mult = new System.Windows.Forms.NumericUpDown();
            this.div = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLab
            // 
            this.TimeLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLab.Location = new System.Drawing.Point(166, 22);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(200, 30);
            this.TimeLab.TabIndex = 0;
            this.TimeLab.Text = " ";
            this.TimeLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusLeft
            // 
            this.plusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeft.Location = new System.Drawing.Point(68, 94);
            this.plusLeft.Name = "plusLeft";
            this.plusLeft.Size = new System.Drawing.Size(60, 50);
            this.plusLeft.TabIndex = 2;
            this.plusLeft.Text = "?";
            this.plusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiLeft
            // 
            this.multiLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiLeft.Location = new System.Drawing.Point(68, 194);
            this.multiLeft.Name = "multiLeft";
            this.multiLeft.Size = new System.Drawing.Size(60, 50);
            this.multiLeft.TabIndex = 3;
            this.multiLeft.Text = "?";
            this.multiLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLeft
            // 
            this.minLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLeft.Location = new System.Drawing.Point(68, 144);
            this.minLeft.Name = "minLeft";
            this.minLeft.Size = new System.Drawing.Size(60, 50);
            this.minLeft.TabIndex = 4;
            this.minLeft.Text = "?";
            this.minLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeft
            // 
            this.divLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeft.Location = new System.Drawing.Point(68, 244);
            this.divLeft.Name = "divLeft";
            this.divLeft.Size = new System.Drawing.Size(60, 50);
            this.divLeft.TabIndex = 5;
            this.divLeft.Text = "?";
            this.divLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minRight
            // 
            this.minRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minRight.Location = new System.Drawing.Point(191, 144);
            this.minRight.Name = "minRight";
            this.minRight.Size = new System.Drawing.Size(60, 50);
            this.minRight.TabIndex = 6;
            this.minRight.Text = "?";
            this.minRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRight
            // 
            this.plusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRight.Location = new System.Drawing.Point(191, 94);
            this.plusRight.Name = "plusRight";
            this.plusRight.Size = new System.Drawing.Size(60, 50);
            this.plusRight.TabIndex = 7;
            this.plusRight.Text = "?";
            this.plusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiRight
            // 
            this.multiRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiRight.Location = new System.Drawing.Point(191, 194);
            this.multiRight.Name = "multiRight";
            this.multiRight.Size = new System.Drawing.Size(60, 50);
            this.multiRight.TabIndex = 8;
            this.multiRight.Text = "?";
            this.multiRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRight
            // 
            this.divRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRight.Location = new System.Drawing.Point(191, 244);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(60, 50);
            this.divRight.TabIndex = 9;
            this.divRight.Text = "?";
            this.divRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(148, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "+";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(148, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(148, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(257, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(257, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(257, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(257, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "=";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(287, 108);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 20);
            this.sum.TabIndex = 2;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(287, 165);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(100, 20);
            this.min.TabIndex = 3;
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(287, 213);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(100, 20);
            this.mult.TabIndex = 4;
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(287, 263);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(100, 20);
            this.div.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(130, 340);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(170, 39);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start the quiz!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 391);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.min);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.multiRight);
            this.Controls.Add(this.plusRight);
            this.Controls.Add(this.minRight);
            this.Controls.Add(this.divLeft);
            this.Controls.Add(this.minLeft);
            this.Controls.Add(this.multiLeft);
            this.Controls.Add(this.plusLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLab);
            this.Name = "Form1";
            this.Text = "math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeft;
        private System.Windows.Forms.Label multiLeft;
        private System.Windows.Forms.Label minLeft;
        private System.Windows.Forms.Label divLeft;
        private System.Windows.Forms.Label minRight;
        private System.Windows.Forms.Label plusRight;
        private System.Windows.Forms.Label multiRight;
        private System.Windows.Forms.Label divRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.NumericUpDown mult;
        private System.Windows.Forms.NumericUpDown div;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
    }
}

