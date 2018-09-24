namespace BMI_Calculator
{
    partial class frmBMICalc
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
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.lblFeet = new System.Windows.Forms.Label();
            this.lblInches = new System.Windows.Forms.Label();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblPunds = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.bxGender = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtBMIDes = new System.Windows.Forms.TextBox();
            this.bxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(107, 28);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(100, 20);
            this.txtFeet.TabIndex = 0;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(39, 31);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 16);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height:";
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(107, 55);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(100, 20);
            this.txtInches.TabIndex = 2;
            // 
            // lblFeet
            // 
            this.lblFeet.AutoSize = true;
            this.lblFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeet.Location = new System.Drawing.Point(213, 31);
            this.lblFeet.Name = "lblFeet";
            this.lblFeet.Size = new System.Drawing.Size(29, 13);
            this.lblFeet.TabIndex = 3;
            this.lblFeet.Text = "feet";
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInches.Location = new System.Drawing.Point(213, 58);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(44, 13);
            this.lblInches.TabIndex = 4;
            this.lblInches.Text = "inches";
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(107, 102);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(100, 20);
            this.txtPounds.TabIndex = 5;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(39, 105);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(60, 16);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Weight:";
            // 
            // lblPunds
            // 
            this.lblPunds.AutoSize = true;
            this.lblPunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunds.Location = new System.Drawing.Point(213, 105);
            this.lblPunds.Name = "lblPunds";
            this.lblPunds.Size = new System.Drawing.Size(48, 13);
            this.lblPunds.TabIndex = 7;
            this.lblPunds.Text = "pounds";
            // 
            // txtBMI
            // 
            this.txtBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.Location = new System.Drawing.Point(107, 178);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(74, 21);
            this.txtBMI.TabIndex = 8;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(39, 181);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(38, 16);
            this.lblBMI.TabIndex = 9;
            this.lblBMI.Text = "BMI:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(61, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 25);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(226, 238);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 25);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "&Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bxGender
            // 
            this.bxGender.Controls.Add(this.rbtnMale);
            this.bxGender.Controls.Add(this.rbtnFemale);
            this.bxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxGender.Location = new System.Drawing.Point(280, 28);
            this.bxGender.Name = "bxGender";
            this.bxGender.Size = new System.Drawing.Size(93, 94);
            this.bxGender.TabIndex = 12;
            this.bxGender.TabStop = false;
            this.bxGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(15, 53);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(57, 19);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Checked = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(15, 26);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(73, 19);
            this.rbtnFemale.TabIndex = 0;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtBMIDes
            // 
            this.txtBMIDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMIDes.Location = new System.Drawing.Point(216, 178);
            this.txtBMIDes.Name = "txtBMIDes";
            this.txtBMIDes.ReadOnly = true;
            this.txtBMIDes.Size = new System.Drawing.Size(157, 21);
            this.txtBMIDes.TabIndex = 13;
            // 
            // frmBMICalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(411, 294);
            this.Controls.Add(this.txtBMIDes);
            this.Controls.Add(this.bxGender);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.lblPunds);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtPounds);
            this.Controls.Add(this.lblInches);
            this.Controls.Add(this.lblFeet);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtFeet);
            this.Name = "frmBMICalc";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.frmBMICalc_Load);
            this.bxGender.ResumeLayout(false);
            this.bxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.Label lblFeet;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblPunds;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox bxGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.TextBox txtBMIDes;
    }
}

