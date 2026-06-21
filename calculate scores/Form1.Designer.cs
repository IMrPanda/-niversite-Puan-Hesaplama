namespace calculate_scores
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
            visaLabel = new TextBox();
            avaragelabel = new TextBox();
            assignmentlabel = new TextBox();
            finallabel = new TextBox();
            resultlabel = new TextBox();
            visanumericUpDown = new NumericUpDown();
            assignmentnumericUpDown1 = new NumericUpDown();
            finalnumericUpDown = new NumericUpDown();
            resultresultlabel = new TextBox();
            avarageresultlabel = new TextBox();
            calculatebutton = new Button();
            exitbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)visanumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assignmentnumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finalnumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // visaLabel
            // 
            visaLabel.AcceptsReturn = true;
            visaLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            visaLabel.HideSelection = false;
            visaLabel.Location = new Point(34, 27);
            visaLabel.Name = "visaLabel";
            visaLabel.ReadOnly = true;
            visaLabel.Size = new Size(165, 35);
            visaLabel.TabIndex = 0;
            visaLabel.Text = "visa";
            // 
            // avaragelabel
            // 
            avaragelabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            avaragelabel.Location = new Point(34, 178);
            avaragelabel.Name = "avaragelabel";
            avaragelabel.ReadOnly = true;
            avaragelabel.Size = new Size(165, 35);
            avaragelabel.TabIndex = 1;
            avaragelabel.Text = "avarage";
            // 
            // assignmentlabel
            // 
            assignmentlabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignmentlabel.Location = new Point(34, 68);
            assignmentlabel.Name = "assignmentlabel";
            assignmentlabel.ReadOnly = true;
            assignmentlabel.Size = new Size(165, 35);
            assignmentlabel.TabIndex = 2;
            assignmentlabel.Text = "assignment";
            // 
            // finallabel
            // 
            finallabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finallabel.Location = new Point(34, 109);
            finallabel.Name = "finallabel";
            finallabel.ReadOnly = true;
            finallabel.Size = new Size(165, 35);
            finallabel.TabIndex = 3;
            finallabel.Text = "final";
            // 
            // resultlabel
            // 
            resultlabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultlabel.Location = new Point(34, 250);
            resultlabel.Name = "resultlabel";
            resultlabel.ReadOnly = true;
            resultlabel.Size = new Size(165, 35);
            resultlabel.TabIndex = 4;
            resultlabel.Text = "result";
            // 
            // visanumericUpDown
            // 
            visanumericUpDown.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            visanumericUpDown.Location = new Point(224, 27);
            visanumericUpDown.Name = "visanumericUpDown";
            visanumericUpDown.Size = new Size(120, 35);
            visanumericUpDown.TabIndex = 5;
            // 
            // assignmentnumericUpDown1
            // 
            assignmentnumericUpDown1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignmentnumericUpDown1.Location = new Point(224, 69);
            assignmentnumericUpDown1.Name = "assignmentnumericUpDown1";
            assignmentnumericUpDown1.Size = new Size(120, 35);
            assignmentnumericUpDown1.TabIndex = 6;
            // 
            // finalnumericUpDown
            // 
            finalnumericUpDown.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalnumericUpDown.Location = new Point(224, 110);
            finalnumericUpDown.Name = "finalnumericUpDown";
            finalnumericUpDown.Size = new Size(120, 35);
            finalnumericUpDown.TabIndex = 7;
            // 
            // resultresultlabel
            // 
            resultresultlabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultresultlabel.Location = new Point(224, 250);
            resultresultlabel.Name = "resultresultlabel";
            resultresultlabel.Size = new Size(120, 35);
            resultresultlabel.TabIndex = 8;
            // 
            // avarageresultlabel
            // 
            avarageresultlabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            avarageresultlabel.Location = new Point(224, 178);
            avarageresultlabel.Name = "avarageresultlabel";
            avarageresultlabel.Size = new Size(120, 35);
            avarageresultlabel.TabIndex = 9;
            // 
            // calculatebutton
            // 
            calculatebutton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculatebutton.Location = new Point(24, 369);
            calculatebutton.Name = "calculatebutton";
            calculatebutton.Size = new Size(155, 71);
            calculatebutton.TabIndex = 10;
            calculatebutton.Text = "calculate";
            calculatebutton.UseVisualStyleBackColor = true;
            calculatebutton.Click += calculatebutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(216, 369);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(155, 71);
            exitbutton.TabIndex = 11;
            exitbutton.Text = "exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 467);
            Controls.Add(exitbutton);
            Controls.Add(calculatebutton);
            Controls.Add(avarageresultlabel);
            Controls.Add(resultresultlabel);
            Controls.Add(finalnumericUpDown);
            Controls.Add(assignmentnumericUpDown1);
            Controls.Add(visanumericUpDown);
            Controls.Add(resultlabel);
            Controls.Add(finallabel);
            Controls.Add(assignmentlabel);
            Controls.Add(avaragelabel);
            Controls.Add(visaLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "calculate scores";
            ((System.ComponentModel.ISupportInitialize)visanumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)assignmentnumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)finalnumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox avaragelabel;
        private TextBox assignmentlabel;
        private TextBox finallabel;
        private TextBox resultlabel;
        private NumericUpDown visanumericUpDown;
        private NumericUpDown assignmentnumericUpDown1;
        private NumericUpDown finalnumericUpDown;
        private TextBox resultresultlabel;
        private TextBox avarageresultlabel;
        private Button calculatebutton;
        private Button exitbutton;
        private TextBox visaLabel;
    }
}
