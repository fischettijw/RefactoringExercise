namespace RefactoringExercise
{
    partial class FrmRefactoring
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
            this.TxtNum01 = new System.Windows.Forms.TextBox();
            this.TxtNum02 = new System.Windows.Forms.TextBox();
            this.TxtNum03 = new System.Windows.Forms.TextBox();
            this.TxtNum04 = new System.Windows.Forms.TextBox();
            this.Btn01 = new System.Windows.Forms.Button();
            this.Btn02 = new System.Windows.Forms.Button();
            this.Btn03 = new System.Windows.Forms.Button();
            this.Btn04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum01
            // 
            this.TxtNum01.Location = new System.Drawing.Point(52, 58);
            this.TxtNum01.Name = "TxtNum01";
            this.TxtNum01.Size = new System.Drawing.Size(100, 29);
            this.TxtNum01.TabIndex = 0;
            this.TxtNum01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNum02
            // 
            this.TxtNum02.Location = new System.Drawing.Point(206, 58);
            this.TxtNum02.Name = "TxtNum02";
            this.TxtNum02.Size = new System.Drawing.Size(100, 29);
            this.TxtNum02.TabIndex = 1;
            this.TxtNum02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNum03
            // 
            this.TxtNum03.Location = new System.Drawing.Point(360, 58);
            this.TxtNum03.Name = "TxtNum03";
            this.TxtNum03.Size = new System.Drawing.Size(100, 29);
            this.TxtNum03.TabIndex = 2;
            this.TxtNum03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNum04
            // 
            this.TxtNum04.Location = new System.Drawing.Point(514, 58);
            this.TxtNum04.Name = "TxtNum04";
            this.TxtNum04.Size = new System.Drawing.Size(100, 29);
            this.TxtNum04.TabIndex = 3;
            this.TxtNum04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn01
            // 
            this.Btn01.Location = new System.Drawing.Point(52, 114);
            this.Btn01.Name = "Btn01";
            this.Btn01.Size = new System.Drawing.Size(100, 29);
            this.Btn01.TabIndex = 4;
            this.Btn01.Text = "Click 1";
            this.Btn01.UseVisualStyleBackColor = true;
            // 
            // Btn02
            // 
            this.Btn02.Location = new System.Drawing.Point(206, 114);
            this.Btn02.Name = "Btn02";
            this.Btn02.Size = new System.Drawing.Size(100, 29);
            this.Btn02.TabIndex = 5;
            this.Btn02.Text = "Click 2";
            this.Btn02.UseVisualStyleBackColor = true;
            // 
            // Btn03
            // 
            this.Btn03.Location = new System.Drawing.Point(360, 114);
            this.Btn03.Name = "Btn03";
            this.Btn03.Size = new System.Drawing.Size(100, 29);
            this.Btn03.TabIndex = 6;
            this.Btn03.Text = "Click 3";
            this.Btn03.UseVisualStyleBackColor = true;
            // 
            // Btn04
            // 
            this.Btn04.Location = new System.Drawing.Point(514, 114);
            this.Btn04.Name = "Btn04";
            this.Btn04.Size = new System.Drawing.Size(100, 29);
            this.Btn04.TabIndex = 7;
            this.Btn04.Text = "Click 4";
            this.Btn04.UseVisualStyleBackColor = true;
            // 
            // FrmRefactoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 387);
            this.Controls.Add(this.Btn04);
            this.Controls.Add(this.Btn03);
            this.Controls.Add(this.Btn02);
            this.Controls.Add(this.Btn01);
            this.Controls.Add(this.TxtNum04);
            this.Controls.Add(this.TxtNum03);
            this.Controls.Add(this.TxtNum02);
            this.Controls.Add(this.TxtNum01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmRefactoring";
            this.Text = "Refactoring Code";
            this.Load += new System.EventHandler(this.FrmRefactoring_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum01;
        private System.Windows.Forms.TextBox TxtNum02;
        private System.Windows.Forms.TextBox TxtNum03;
        private System.Windows.Forms.TextBox TxtNum04;
        private System.Windows.Forms.Button Btn01;
        private System.Windows.Forms.Button Btn02;
        private System.Windows.Forms.Button Btn03;
        private System.Windows.Forms.Button Btn04;
    }
}

