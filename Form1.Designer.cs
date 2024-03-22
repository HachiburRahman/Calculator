namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.AccessibleName = "txtNumber1";
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.Location = new System.Drawing.Point(107, 62);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber1.Multiline = true;
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(221, 46);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNumber2
            // 
            this.txtNumber2.AccessibleName = "txtNumber2";
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.Location = new System.Drawing.Point(388, 62);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber2.Multiline = true;
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(221, 46);
            this.txtNumber2.TabIndex = 3;
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumber2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.AccessibleName = "btnPlus";
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(138, 149);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(82, 74);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 268);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(16, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.AccessibleName = "btnMinus";
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(241, 149);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(82, 74);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.AccessibleName = "btnDivision";
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(492, 149);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(82, 74);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.AccessibleName = "btnMultiplication";
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.Location = new System.Drawing.Point(368, 149);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(82, 74);
            this.btnMultiplication.TabIndex = 9;
            this.btnMultiplication.Text = " *";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "Form1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 562);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
    }
}

