namespace CST___150_Activity_1
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
            this.lblEarth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMars = new System.Windows.Forms.Label();
            this.lblMarsWeight = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEarth
            // 
            this.lblEarth.AutoSize = true;
            this.lblEarth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarth.Location = new System.Drawing.Point(122, 93);
            this.lblEarth.Name = "lblEarth";
            this.lblEarth.Size = new System.Drawing.Size(201, 20);
            this.lblEarth.TabIndex = 0;
            this.lblEarth.Text = "Enter your weight on Earth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "lbs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMars
            // 
            this.lblMars.AutoSize = true;
            this.lblMars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMars.Location = new System.Drawing.Point(165, 144);
            this.lblMars.Name = "lblMars";
            this.lblMars.Size = new System.Drawing.Size(158, 20);
            this.lblMars.TabIndex = 3;
            this.lblMars.Text = "Your weight on Mars:";
            this.lblMars.Click += new System.EventHandler(this.lblMars_Click);
            // 
            // lblMarsWeight
            // 
            this.lblMarsWeight.AutoSize = true;
            this.lblMarsWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarsWeight.Location = new System.Drawing.Point(344, 144);
            this.lblMarsWeight.Name = "lblMarsWeight";
            this.lblMarsWeight.Size = new System.Drawing.Size(51, 20);
            this.lblMarsWeight.TabIndex = 4;
            this.lblMarsWeight.Text = "label2";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(348, 201);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(90, 44);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.ConvertButtonClickEvent);
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEarthWeight.Location = new System.Drawing.Point(348, 87);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(100, 26);
            this.txtEarthWeight.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblMarsWeight);
            this.Controls.Add(this.lblMars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEarth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEarth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMars;
        private System.Windows.Forms.Label lblMarsWeight;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtEarthWeight;
    }
}

