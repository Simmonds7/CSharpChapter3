namespace ProjectedRaisesGUI
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
            this.txtInputSalary = new System.Windows.Forms.TextBox();
            this.btnRaise = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblHappy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Joe\'s current Salary";
            // 
            // txtInputSalary
            // 
            this.txtInputSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSalary.Location = new System.Drawing.Point(48, 205);
            this.txtInputSalary.Name = "txtInputSalary";
            this.txtInputSalary.Size = new System.Drawing.Size(247, 29);
            this.txtInputSalary.TabIndex = 1;
            // 
            // btnRaise
            // 
            this.btnRaise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaise.Location = new System.Drawing.Point(301, 187);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(142, 67);
            this.btnRaise.TabIndex = 2;
            this.btnRaise.Text = "Give him a Raise!";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(449, 205);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(265, 24);
            this.lblResult.TabIndex = 3;
            // 
            // lblHappy
            // 
            this.lblHappy.AutoSize = true;
            this.lblHappy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHappy.Location = new System.Drawing.Point(545, 241);
            this.lblHappy.Name = "lblHappy";
            this.lblHappy.Size = new System.Drawing.Size(121, 24);
            this.lblHappy.TabIndex = 4;
            this.lblHappy.Text = "Joe is happy!";
            this.lblHappy.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHappy);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.txtInputSalary);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee Raise Projecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputSalary;
        private System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblHappy;
    }
}

