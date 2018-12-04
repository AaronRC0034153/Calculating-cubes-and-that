namespace Calculating_cubes_and_that
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
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.work = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box4 = new System.Windows.Forms.TextBox();
            this.box3 = new System.Windows.Forms.TextBox();
            this.box5 = new System.Windows.Forms.TextBox();
            this.work2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(128, 155);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(100, 20);
            this.box1.TabIndex = 0;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(340, 155);
            this.box2.Name = "box2";
            this.box2.ReadOnly = true;
            this.box2.Size = new System.Drawing.Size(100, 20);
            this.box2.TabIndex = 2;
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(242, 200);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(75, 23);
            this.work.TabIndex = 3;
            this.work.Text = "Calculate";
            this.work.UseVisualStyleBackColor = true;
            this.work.Click += new System.EventHandler(this.work_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pick a number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cube rooted answer";
            // 
            // box4
            // 
            this.box4.Location = new System.Drawing.Point(295, 327);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(100, 20);
            this.box4.TabIndex = 6;
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(84, 327);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(100, 20);
            this.box3.TabIndex = 7;
            // 
            // box5
            // 
            this.box5.Location = new System.Drawing.Point(506, 327);
            this.box5.Name = "box5";
            this.box5.ReadOnly = true;
            this.box5.Size = new System.Drawing.Size(100, 20);
            this.box5.TabIndex = 8;
            // 
            // work2
            // 
            this.work2.Location = new System.Drawing.Point(308, 393);
            this.work2.Name = "work2";
            this.work2.Size = new System.Drawing.Size(75, 23);
            this.work2.TabIndex = 9;
            this.work2.Text = "Calculate";
            this.work2.UseVisualStyleBackColor = true;
            this.work2.Click += new System.EventHandler(this.work2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pick a number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rooted by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.work2);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.work);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Button work;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box4;
        private System.Windows.Forms.TextBox box3;
        private System.Windows.Forms.TextBox box5;
        private System.Windows.Forms.Button work2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

