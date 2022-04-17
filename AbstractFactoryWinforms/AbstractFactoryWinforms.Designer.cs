
namespace AbstractFactoryWinforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModern = new System.Windows.Forms.Button();
            this.chbDesk = new System.Windows.Forms.CheckBox();
            this.chbChair = new System.Windows.Forms.CheckBox();
            this.chbBed = new System.Windows.Forms.CheckBox();
            this.btnTraditional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModern
            // 
            this.btnModern.Location = new System.Drawing.Point(272, 496);
            this.btnModern.Name = "btnModern";
            this.btnModern.Size = new System.Drawing.Size(75, 23);
            this.btnModern.TabIndex = 0;
            this.btnModern.Text = "Modern";
            this.btnModern.UseVisualStyleBackColor = true;
            this.btnModern.Click += new System.EventHandler(this.btnModern_Click);
            // 
            // chbDesk
            // 
            this.chbDesk.AutoSize = true;
            this.chbDesk.Location = new System.Drawing.Point(272, 471);
            this.chbDesk.Name = "chbDesk";
            this.chbDesk.Size = new System.Drawing.Size(51, 19);
            this.chbDesk.TabIndex = 2;
            this.chbDesk.Text = "Desk";
            this.chbDesk.UseVisualStyleBackColor = true;
            // 
            // chbChair
            // 
            this.chbChair.AutoSize = true;
            this.chbChair.Location = new System.Drawing.Point(375, 470);
            this.chbChair.Name = "chbChair";
            this.chbChair.Size = new System.Drawing.Size(54, 19);
            this.chbChair.TabIndex = 3;
            this.chbChair.Text = "Chair";
            this.chbChair.UseVisualStyleBackColor = true;
            // 
            // chbBed
            // 
            this.chbBed.AutoSize = true;
            this.chbBed.Location = new System.Drawing.Point(480, 471);
            this.chbBed.Name = "chbBed";
            this.chbBed.Size = new System.Drawing.Size(46, 19);
            this.chbBed.TabIndex = 4;
            this.chbBed.Text = "Bed";
            this.chbBed.UseVisualStyleBackColor = true;
            // 
            // btnTraditional
            // 
            this.btnTraditional.Location = new System.Drawing.Point(451, 496);
            this.btnTraditional.Name = "btnTraditional";
            this.btnTraditional.Size = new System.Drawing.Size(75, 23);
            this.btnTraditional.TabIndex = 5;
            this.btnTraditional.Text = "Traditional";
            this.btnTraditional.UseVisualStyleBackColor = true;
            this.btnTraditional.Click += new System.EventHandler(this.btnTraditional_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 541);
            this.Controls.Add(this.btnTraditional);
            this.Controls.Add(this.chbBed);
            this.Controls.Add(this.chbChair);
            this.Controls.Add(this.chbDesk);
            this.Controls.Add(this.btnModern);
            this.Name = "Form1";
            this.Text = "AbstractFactory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModern;
        private System.Windows.Forms.CheckBox chbDesk;
        private System.Windows.Forms.CheckBox chbChair;
        private System.Windows.Forms.CheckBox chbBed;
        private System.Windows.Forms.Button btnTraditional;
    }
}

