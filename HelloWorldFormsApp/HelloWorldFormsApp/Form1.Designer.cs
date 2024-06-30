namespace HelloWorldFormsApp
{
    partial class HelloWorldApp
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
            this.btnHelloButtonTest = new System.Windows.Forms.Button();
            this.lblHelloWorldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHelloButtonTest
            // 
            this.btnHelloButtonTest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelloButtonTest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHelloButtonTest.Location = new System.Drawing.Point(76, 54);
            this.btnHelloButtonTest.Name = "btnHelloButtonTest";
            this.btnHelloButtonTest.Size = new System.Drawing.Size(123, 42);
            this.btnHelloButtonTest.TabIndex = 0;
            this.btnHelloButtonTest.Text = "Click Here";
            this.btnHelloButtonTest.UseVisualStyleBackColor = true;
            this.btnHelloButtonTest.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // lblHelloWorldLabel
            // 
            this.lblHelloWorldLabel.AutoSize = true;
            this.lblHelloWorldLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHelloWorldLabel.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldLabel.Location = new System.Drawing.Point(363, 216);
            this.lblHelloWorldLabel.Name = "lblHelloWorldLabel";
            this.lblHelloWorldLabel.Size = new System.Drawing.Size(85, 39);
            this.lblHelloWorldLabel.TabIndex = 1;
            this.lblHelloWorldLabel.Text = "label";
            // 
            // HelloWorldApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHelloWorldLabel);
            this.Controls.Add(this.btnHelloButtonTest);
            this.Name = "HelloWorldApp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelloButtonTest;
        private System.Windows.Forms.Label lblHelloWorldLabel;
    }
}

