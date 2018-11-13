namespace EggsInteractiveGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChik1 = new System.Windows.Forms.TextBox();
            this.txtChik2 = new System.Windows.Forms.TextBox();
            this.txtChik4 = new System.Windows.Forms.TextBox();
            this.txtChik3 = new System.Windows.Forms.TextBox();
            this.txtChik5 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the amount of eggs produced by every one of the five chickens.";
            // 
            // txtChik1
            // 
            this.txtChik1.Location = new System.Drawing.Point(279, 79);
            this.txtChik1.Name = "txtChik1";
            this.txtChik1.Size = new System.Drawing.Size(35, 20);
            this.txtChik1.TabIndex = 1;
            // 
            // txtChik2
            // 
            this.txtChik2.Location = new System.Drawing.Point(415, 79);
            this.txtChik2.Name = "txtChik2";
            this.txtChik2.Size = new System.Drawing.Size(35, 20);
            this.txtChik2.TabIndex = 2;
            // 
            // txtChik4
            // 
            this.txtChik4.Location = new System.Drawing.Point(348, 127);
            this.txtChik4.Name = "txtChik4";
            this.txtChik4.Size = new System.Drawing.Size(35, 20);
            this.txtChik4.TabIndex = 4;
            // 
            // txtChik3
            // 
            this.txtChik3.Location = new System.Drawing.Point(212, 127);
            this.txtChik3.Name = "txtChik3";
            this.txtChik3.Size = new System.Drawing.Size(35, 20);
            this.txtChik3.TabIndex = 3;
            // 
            // txtChik5
            // 
            this.txtChik5.Location = new System.Drawing.Point(484, 127);
            this.txtChik5.Name = "txtChik5";
            this.txtChik5.Size = new System.Drawing.Size(35, 20);
            this.txtChik5.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(314, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 50);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(175, 247);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtChik5);
            this.Controls.Add(this.txtChik4);
            this.Controls.Add(this.txtChik3);
            this.Controls.Add(this.txtChik2);
            this.Controls.Add(this.txtChik1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Egg Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChik1;
        private System.Windows.Forms.TextBox txtChik2;
        private System.Windows.Forms.TextBox txtChik4;
        private System.Windows.Forms.TextBox txtChik3;
        private System.Windows.Forms.TextBox txtChik5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotal;
    }
}

