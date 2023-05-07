namespace MyScriptParser
{
    partial class Form1
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
            MyScriptInput = new RichTextBox();
            RTBResult = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // MyScriptInput
            // 
            MyScriptInput.BackColor = SystemColors.Window;
            MyScriptInput.BorderStyle = BorderStyle.None;
            MyScriptInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MyScriptInput.Location = new Point(12, 12);
            MyScriptInput.Name = "MyScriptInput";
            MyScriptInput.Size = new Size(279, 426);
            MyScriptInput.TabIndex = 0;
            MyScriptInput.Text = "";
            // 
            // RTBResult
            // 
            RTBResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RTBResult.Location = new Point(323, 12);
            RTBResult.Name = "RTBResult";
            RTBResult.ReadOnly = true;
            RTBResult.Size = new Size(279, 426);
            RTBResult.TabIndex = 1;
            RTBResult.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(270, 454);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Parse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(614, 489);
            Controls.Add(button1);
            Controls.Add(RTBResult);
            Controls.Add(MyScriptInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox MyScriptInput;
        private RichTextBox RTBResult;
        private Button button1;
    }
}