namespace PrivateAssemblies_Sanchez
{
    partial class FrmBasicCalculator
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
            this.tbOpperand1 = new System.Windows.Forms.TextBox();
            this.tbOpperand2 = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // tbOpperand1
            // 
            this.tbOpperand1.BackColor = System.Drawing.Color.Gainsboro;
            this.tbOpperand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpperand1.Location = new System.Drawing.Point(12, 50);
            this.tbOpperand1.Multiline = true;
            this.tbOpperand1.Name = "tbOpperand1";
            this.tbOpperand1.Size = new System.Drawing.Size(367, 57);
            this.tbOpperand1.TabIndex = 1;
            this.tbOpperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbOpperand2
            // 
            this.tbOpperand2.BackColor = System.Drawing.Color.Gainsboro;
            this.tbOpperand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpperand2.Location = new System.Drawing.Point(13, 197);
            this.tbOpperand2.Multiline = true;
            this.tbOpperand2.Name = "tbOpperand2";
            this.tbOpperand2.Size = new System.Drawing.Size(367, 57);
            this.tbOpperand2.TabIndex = 2;
            this.tbOpperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOperator
            // 
            this.cbOperator.BackColor = System.Drawing.Color.Gainsboro;
            this.cbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Location = new System.Drawing.Point(136, 135);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(121, 39);
            this.cbOperator.TabIndex = 3;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(121, 396);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(150, 42);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbTotal.Location = new System.Drawing.Point(13, 283);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(367, 96);
            this.tbTotal.TabIndex = 5;
            this.tbTotal.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(149, 316);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 31);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label2";
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.tbOpperand2);
            this.Controls.Add(this.tbOpperand1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOpperand1;
        private System.Windows.Forms.TextBox tbOpperand2;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

