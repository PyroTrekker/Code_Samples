namespace IntegerCalculator
{
    partial class frmCalculator
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
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.lblEqualTo = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(12, 12);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(59, 20);
            this.txtLeft.TabIndex = 0;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cmbOperator.Location = new System.Drawing.Point(77, 12);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(59, 21);
            this.cmbOperator.TabIndex = 1;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(142, 12);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(59, 20);
            this.txtRight.TabIndex = 0;
            this.txtRight.TextChanged += new System.EventHandler(this.txtRight_TextChanged);
            // 
            // lblEqualTo
            // 
            this.lblEqualTo.AutoSize = true;
            this.lblEqualTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualTo.Location = new System.Drawing.Point(221, 13);
            this.lblEqualTo.Name = "lblEqualTo";
            this.lblEqualTo.Size = new System.Drawing.Size(21, 24);
            this.lblEqualTo.TabIndex = 2;
            this.lblEqualTo.Text = "=";
            this.lblEqualTo.Click += new System.EventHandler(this.lblEqualTo_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(259, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(59, 20);
            this.txtResult.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(77, 57);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(59, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 134);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblEqualTo);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Name = "frmCalculator";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Label lblEqualTo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}

