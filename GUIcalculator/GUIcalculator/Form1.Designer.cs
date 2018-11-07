namespace GUIcalculator
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.lblSub = new System.Windows.Forms.Label();
            this.btnMulti = new System.Windows.Forms.Button();
            this.lblMulti = new System.Windows.Forms.Label();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblDiv = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblMod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter another number";
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.Location = new System.Drawing.Point(265, 9);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 29);
            this.txtInput1.TabIndex = 2;
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.Location = new System.Drawing.Point(265, 93);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 29);
            this.txtInput2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.Location = new System.Drawing.Point(16, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(265, 172);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 5;
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSub.Location = new System.Drawing.Point(16, 230);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(109, 34);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // lblSub
            // 
            this.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSub.Location = new System.Drawing.Point(265, 241);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(100, 23);
            this.lblSub.TabIndex = 7;
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMulti.Location = new System.Drawing.Point(16, 301);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(109, 34);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "Multiply";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // lblMulti
            // 
            this.lblMulti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMulti.Location = new System.Drawing.Point(265, 312);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(100, 23);
            this.lblMulti.TabIndex = 9;
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDiv.Location = new System.Drawing.Point(438, 229);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(109, 34);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lblDiv
            // 
            this.lblDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiv.Location = new System.Drawing.Point(585, 240);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(100, 23);
            this.lblDiv.TabIndex = 11;
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMod.Location = new System.Drawing.Point(438, 300);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(109, 34);
            this.btnMod.TabIndex = 12;
            this.btnMod.Text = "Modulus";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblMod
            // 
            this.lblMod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMod.Location = new System.Drawing.Point(585, 312);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(100, 23);
            this.lblMod.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblMod;
    }
}

