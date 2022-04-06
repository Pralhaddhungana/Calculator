
namespace Calculator
{
    partial class Calculator
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.ACBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.PlusMinusBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.ModuleBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.Equalbtn = new System.Windows.Forms.Button();
            this.Dotbtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox.Location = new System.Drawing.Point(12, 12);
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(230, 43);
            this.txtBox.TabIndex = 0;
            this.txtBox.Text = "0";
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ACBtn
            // 
            this.ACBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ACBtn.Location = new System.Drawing.Point(12, 75);
            this.ACBtn.Name = "ACBtn";
            this.ACBtn.Size = new System.Drawing.Size(53, 47);
            this.ACBtn.TabIndex = 1;
            this.ACBtn.Text = "AC";
            this.ACBtn.UseVisualStyleBackColor = true;
            this.ACBtn.Click += new System.EventHandler(this.ACBtn_Click);
            // 
            // SevenBtn
            // 
            this.SevenBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SevenBtn.Location = new System.Drawing.Point(12, 128);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(53, 47);
            this.SevenBtn.TabIndex = 2;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = true;
            this.SevenBtn.Click += new System.EventHandler(this.SevenBtn_Click);
            // 
            // FourBtn
            // 
            this.FourBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FourBtn.Location = new System.Drawing.Point(12, 181);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(53, 47);
            this.FourBtn.TabIndex = 3;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click);
            // 
            // OneBtn
            // 
            this.OneBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OneBtn.Location = new System.Drawing.Point(12, 234);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(53, 47);
            this.OneBtn.TabIndex = 4;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TwoBtn.Location = new System.Drawing.Point(71, 234);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(53, 47);
            this.TwoBtn.TabIndex = 8;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FiveBtn.Location = new System.Drawing.Point(71, 181);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(53, 47);
            this.FiveBtn.TabIndex = 7;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click);
            // 
            // EightBtn
            // 
            this.EightBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EightBtn.Location = new System.Drawing.Point(71, 128);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(53, 47);
            this.EightBtn.TabIndex = 6;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = true;
            this.EightBtn.Click += new System.EventHandler(this.EightBtn_Click);
            // 
            // PlusMinusBtn
            // 
            this.PlusMinusBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlusMinusBtn.Location = new System.Drawing.Point(71, 75);
            this.PlusMinusBtn.Name = "PlusMinusBtn";
            this.PlusMinusBtn.Size = new System.Drawing.Size(53, 47);
            this.PlusMinusBtn.TabIndex = 5;
            this.PlusMinusBtn.Text = "+/-";
            this.PlusMinusBtn.UseVisualStyleBackColor = true;
            this.PlusMinusBtn.Click += new System.EventHandler(this.PlusMinusBtn_Click);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThreeBtn.Location = new System.Drawing.Point(130, 234);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(53, 47);
            this.ThreeBtn.TabIndex = 12;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click);
            // 
            // SixBtn
            // 
            this.SixBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SixBtn.Location = new System.Drawing.Point(130, 181);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(53, 47);
            this.SixBtn.TabIndex = 11;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = true;
            this.SixBtn.Click += new System.EventHandler(this.SixBtn_Click);
            // 
            // NineBtn
            // 
            this.NineBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NineBtn.Location = new System.Drawing.Point(130, 128);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(53, 47);
            this.NineBtn.TabIndex = 10;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = true;
            this.NineBtn.Click += new System.EventHandler(this.NineBtn_Click);
            // 
            // ModuleBtn
            // 
            this.ModuleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModuleBtn.Location = new System.Drawing.Point(130, 75);
            this.ModuleBtn.Name = "ModuleBtn";
            this.ModuleBtn.Size = new System.Drawing.Size(53, 47);
            this.ModuleBtn.TabIndex = 9;
            this.ModuleBtn.Text = "%";
            this.ModuleBtn.UseVisualStyleBackColor = true;
            this.ModuleBtn.Click += new System.EventHandler(this.ModuleBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlusBtn.Location = new System.Drawing.Point(189, 234);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(53, 47);
            this.PlusBtn.TabIndex = 16;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinusBtn.Location = new System.Drawing.Point(189, 181);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(53, 47);
            this.MinusBtn.TabIndex = 15;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiplyBtn.Location = new System.Drawing.Point(189, 128);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(53, 47);
            this.MultiplyBtn.TabIndex = 14;
            this.MultiplyBtn.Text = "×";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.button15_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivideBtn.Location = new System.Drawing.Point(189, 75);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(53, 47);
            this.DivideBtn.TabIndex = 9;
            this.DivideBtn.Text = "÷";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.button19_Click);
            // 
            // Equalbtn
            // 
            this.Equalbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equalbtn.Location = new System.Drawing.Point(189, 287);
            this.Equalbtn.Name = "Equalbtn";
            this.Equalbtn.Size = new System.Drawing.Size(53, 47);
            this.Equalbtn.TabIndex = 24;
            this.Equalbtn.Text = "=";
            this.Equalbtn.UseVisualStyleBackColor = true;
            this.Equalbtn.Click += new System.EventHandler(this.Equalbtn_Click);
            // 
            // Dotbtn
            // 
            this.Dotbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dotbtn.Location = new System.Drawing.Point(130, 287);
            this.Dotbtn.Name = "Dotbtn";
            this.Dotbtn.Size = new System.Drawing.Size(53, 47);
            this.Dotbtn.TabIndex = 23;
            this.Dotbtn.Text = ".";
            this.Dotbtn.UseVisualStyleBackColor = true;
            this.Dotbtn.Click += new System.EventHandler(this.Dotbtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZeroBtn.Location = new System.Drawing.Point(12, 287);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(112, 47);
            this.ZeroBtn.TabIndex = 21;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 341);
            this.Controls.Add(this.Equalbtn);
            this.Controls.Add(this.Dotbtn);
            this.Controls.Add(this.ZeroBtn);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.ThreeBtn);
            this.Controls.Add(this.SixBtn);
            this.Controls.Add(this.NineBtn);
            this.Controls.Add(this.ModuleBtn);
            this.Controls.Add(this.TwoBtn);
            this.Controls.Add(this.FiveBtn);
            this.Controls.Add(this.EightBtn);
            this.Controls.Add(this.PlusMinusBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.FourBtn);
            this.Controls.Add(this.SevenBtn);
            this.Controls.Add(this.ACBtn);
            this.Controls.Add(this.txtBox);
            this.Name = "Calculator";
            this.Text = "Calculator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button ACBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button PlusMinusBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button ModuleBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button Equalbtn;
        private System.Windows.Forms.Button Dotbtn;
        private System.Windows.Forms.Button ZeroBtn;
    }
}

