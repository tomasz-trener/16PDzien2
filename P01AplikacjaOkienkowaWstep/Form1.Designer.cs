namespace P01AplikacjaOkienkowaWstep
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
            this.btnPowitanie = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPoliczBMI = new System.Windows.Forms.Button();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPowitanie
            // 
            this.btnPowitanie.Location = new System.Drawing.Point(38, 39);
            this.btnPowitanie.Name = "btnPowitanie";
            this.btnPowitanie.Size = new System.Drawing.Size(120, 66);
            this.btnPowitanie.TabIndex = 0;
            this.btnPowitanie.Text = "Powitanie";
            this.btnPowitanie.UseVisualStyleBackColor = true;
            this.btnPowitanie.Click += new System.EventHandler(this.btnPowitanie_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(189, 39);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(115, 66);
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.Text = "button1";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wzrost";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(38, 139);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(120, 20);
            this.txtWzrost.TabIndex = 3;
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(38, 185);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(120, 20);
            this.txtWaga.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waga";
            // 
            // btnPoliczBMI
            // 
            this.btnPoliczBMI.Location = new System.Drawing.Point(175, 139);
            this.btnPoliczBMI.Name = "btnPoliczBMI";
            this.btnPoliczBMI.Size = new System.Drawing.Size(129, 66);
            this.btnPoliczBMI.TabIndex = 6;
            this.btnPoliczBMI.Text = "Policz BMI";
            this.btnPoliczBMI.UseVisualStyleBackColor = true;
            this.btnPoliczBMI.Click += new System.EventHandler(this.btnPoliczBMI_Click);
            // 
            // txtWynik
            // 
            this.txtWynik.Location = new System.Drawing.Point(38, 237);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.ReadOnly = true;
            this.txtWynik.Size = new System.Drawing.Size(120, 20);
            this.txtWynik.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.btnPoliczBMI);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnPowitanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPowitanie;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPoliczBMI;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Label label3;
    }
}

