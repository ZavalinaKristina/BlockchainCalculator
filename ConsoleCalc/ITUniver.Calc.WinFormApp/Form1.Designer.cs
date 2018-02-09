namespace ITUniver.Calc.WinFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLuck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbInput = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbOperation);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(321, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор операции";
            // 
            // cbOperation
            // 
            this.cbOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(10, 23);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(301, 21);
            this.cbOperation.TabIndex = 0;
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Location = new System.Drawing.Point(196, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(115, 65);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLuck
            // 
            this.btnLuck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuck.Location = new System.Drawing.Point(10, 12);
            this.btnLuck.Name = "btnLuck";
            this.btnLuck.Size = new System.Drawing.Size(109, 64);
            this.btnLuck.TabIndex = 5;
            this.btnLuck.Text = "Мне повезет";
            this.btnLuck.UseVisualStyleBackColor = true;
            this.btnLuck.Click += new System.EventHandler(this.btnLuck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbInput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(321, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // tbInput
            // 
            this.tbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInput.Location = new System.Drawing.Point(10, 23);
            this.tbInput.Name = "tbInput";
            this.tbInput.PromptChar = ' ';
            this.tbInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInput.Size = new System.Drawing.Size(301, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbInput.Click += new System.EventHandler(this.tbInput_Click);
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            this.tbInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbHistory);
            this.groupBox3.Controls.Add(this.tbResult);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(321, 188);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // lbHistory
            // 
            this.lbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(10, 43);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(301, 135);
            this.lbHistory.TabIndex = 1;
            // 
            // tbResult
            // 
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResult.Location = new System.Drawing.Point(10, 23);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(301, 20);
            this.tbResult.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuck);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 89);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 296);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 335);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLuck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tbInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbHistory;
    }
}

