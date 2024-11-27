namespace Advance_Calculator1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonMC, buttonMR, buttonMPlus, buttonMMinus, buttonMS, buttonMRecall,
            buttonPercent, buttonCE, buttonC, buttonBack, buttonInverse, buttonSquare, buttonSqrt, buttonDivide,
            button7, button8, button9, buttonMultiply, button4, button5, button6, buttonMinus,
            button1, button2, button3, buttonPlus, buttonPlusMinus, button0, buttonDecimal, buttonEquals;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();

            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Navy;
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(320, 40); // Further reduced height
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 40); // Adjusted for new display height
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(240, 280); // Reduced overall width
            this.tableLayoutPanel.TabIndex = 1;

            // 
            // Initialize Buttons
            // 
            InitializeButtons();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322); // Adjusted form size
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void InitializeButtons()
        {
            string[] buttonLabels = { "MC", "MR", "M+", "M-", "%", "CE", "C", "⌫", "1/x", "x²", "√x", "÷", "7", "8",
                                       "9", "×", "4", "5", "6", "-", "1", "2", "3", "+", "±", "0", ".", "=" };

            var buttonControls = new System.Windows.Forms.Button[]
            {
                buttonMC = new System.Windows.Forms.Button(), buttonMR = new System.Windows.Forms.Button(), buttonMPlus = new System.Windows.Forms.Button(),
                buttonMMinus = new System.Windows.Forms.Button(), buttonMS = new System.Windows.Forms.Button(), buttonMRecall = new System.Windows.Forms.Button(),
                buttonPercent = new System.Windows.Forms.Button(), buttonCE = new System.Windows.Forms.Button(), buttonC = new System.Windows.Forms.Button(),
                buttonBack = new System.Windows.Forms.Button(), buttonInverse = new System.Windows.Forms.Button(), buttonSquare = new System.Windows.Forms.Button(),
                buttonSqrt = new System.Windows.Forms.Button(), buttonDivide = new System.Windows.Forms.Button(), button7 = new System.Windows.Forms.Button(),
                button8 = new System.Windows.Forms.Button(), button9 = new System.Windows.Forms.Button(), buttonMultiply = new System.Windows.Forms.Button(),
                button4 = new System.Windows.Forms.Button(), button5 = new System.Windows.Forms.Button(), button6 = new System.Windows.Forms.Button(),
                buttonMinus = new System.Windows.Forms.Button(), button1 = new System.Windows.Forms.Button(), button2 = new System.Windows.Forms.Button(),
                button3 = new System.Windows.Forms.Button(), buttonPlus = new System.Windows.Forms.Button(), buttonPlusMinus = new System.Windows.Forms.Button(),
                button0 = new System.Windows.Forms.Button(), buttonDecimal = new System.Windows.Forms.Button(), buttonEquals = new System.Windows.Forms.Button()
            };

            for (int i = 0; i < buttonLabels.Length; i++)
            {
                buttonControls[i].Text = buttonLabels[i];
                buttonControls[i].BackColor = System.Drawing.Color.White;
                buttonControls[i].ForeColor = System.Drawing.Color.Black;
                buttonControls[i].Dock = System.Windows.Forms.DockStyle.Fill;
                buttonControls[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttonControls[i].Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Increased font size
                buttonControls[i].Click += new System.EventHandler(this.button_Click);
                buttonControls[i].Margin = new System.Windows.Forms.Padding(1); // Reduced margins
                this.tableLayoutPanel.Controls.Add(buttonControls[i], i % 4, i / 4);
            }
        }

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
    }
}
