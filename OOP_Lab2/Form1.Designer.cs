namespace OOP_Lab2
{
    partial class Lab2Form
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
            this.FilterButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DeveloperBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PublisherBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxUserScoreNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinUserScoreNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MinOwnersNumeric = new System.Windows.Forms.NumericUpDown();
            this.FreeCheckbox = new System.Windows.Forms.CheckBox();
            this.MaxConcurrentUsersNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.methodSelector = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaxUserScoreNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUserScoreNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinOwnersNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxConcurrentUsersNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            //
            // FilterButton
            //
            this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterButton.Location = new System.Drawing.Point(159, 508);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(144, 41);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += FilterButton_Click;
            //
            // SaveButton
            //
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Location = new System.Drawing.Point(12, 508);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(144, 41);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += SaveButtonOnClick;
            //
            // ClearButton
            //
            this.ClearButton.Location = new System.Drawing.Point(88, 231);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(215, 27);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filters:";
            //
            // NameBox
            //
            this.NameBox.Location = new System.Drawing.Point(88, 31);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(215, 23);
            this.NameBox.TabIndex = 6;
            //
            // DeveloperBox
            //
            this.DeveloperBox.Location = new System.Drawing.Point(88, 60);
            this.DeveloperBox.Name = "DeveloperBox";
            this.DeveloperBox.Size = new System.Drawing.Size(215, 23);
            this.DeveloperBox.TabIndex = 7;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Developer:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publisher:";
            //
            // PublisherBox
            //
            this.PublisherBox.Location = new System.Drawing.Point(88, 89);
            this.PublisherBox.Name = "PublisherBox";
            this.PublisherBox.Size = new System.Drawing.Size(215, 23);
            this.PublisherBox.TabIndex = 11;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "User score:";
            //
            // MaxUserScoreNumeric
            //
            this.MaxUserScoreNumeric.Location = new System.Drawing.Point(220, 119);
            this.MaxUserScoreNumeric.Name = "MaxUserScoreNumeric";
            this.MaxUserScoreNumeric.Size = new System.Drawing.Size(83, 23);
            this.MaxUserScoreNumeric.TabIndex = 14;
            this.MaxUserScoreNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            //
            // MinUserScoreNumeric
            //
            this.MinUserScoreNumeric.Location = new System.Drawing.Point(88, 119);
            this.MinUserScoreNumeric.Name = "MinUserScoreNumeric";
            this.MinUserScoreNumeric.Size = new System.Drawing.Size(83, 23);
            this.MinUserScoreNumeric.TabIndex = 15;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "-";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Min owners:";
            //
            // MinOwnersNumeric
            //
            this.MinOwnersNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MinOwnersNumeric.Location = new System.Drawing.Point(88, 148);
            this.MinOwnersNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MinOwnersNumeric.Name = "MinOwnersNumeric";
            this.MinOwnersNumeric.Size = new System.Drawing.Size(215, 23);
            this.MinOwnersNumeric.TabIndex = 18;
            //
            // FreeCheckbox
            //
            this.FreeCheckbox.AutoSize = true;
            this.FreeCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FreeCheckbox.Location = new System.Drawing.Point(48, 177);
            this.FreeCheckbox.Name = "FreeCheckbox";
            this.FreeCheckbox.Size = new System.Drawing.Size(54, 19);
            this.FreeCheckbox.TabIndex = 19;
            this.FreeCheckbox.Text = "Free: ";
            this.FreeCheckbox.UseVisualStyleBackColor = true;
            //
            // MaxConcurrentUsersNumeric
            //
            this.MaxConcurrentUsersNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxConcurrentUsersNumeric.Location = new System.Drawing.Point(88, 202);
            this.MaxConcurrentUsersNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MaxConcurrentUsersNumeric.Name = "MaxConcurrentUsersNumeric";
            this.MaxConcurrentUsersNumeric.Size = new System.Drawing.Size(215, 23);
            this.MaxConcurrentUsersNumeric.TabIndex = 21;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Max CCU:";
            //
            // webView21
            //
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(309, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(676, 560);
            this.webView21.TabIndex = 22;
            this.webView21.ZoomFactor = 1D;
            //
            // methodSelector
            //
            this.methodSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom)))));
            this.methodSelector.FormattingEnabled = true;
            this.methodSelector.Location = new System.Drawing.Point(88, 479);
            this.methodSelector.Name = "methodSelector";
            this.methodSelector.Size = new System.Drawing.Size(215, 23);
            this.methodSelector.TabIndex = 23;
            this.methodSelector.SelectedIndexChanged += MethodSelectorOnSelectedIndexChanged;
            //
            // label9
            //
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom)))));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Method:";
            //
            // Lab2Form
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.methodSelector);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.MaxConcurrentUsersNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FreeCheckbox);
            this.Controls.Add(this.MinOwnersNumeric);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MinUserScoreNumeric);
            this.Controls.Add(this.MaxUserScoreNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PublisherBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeveloperBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FilterButton);
            this.Name = "Lab2Form";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.MaxUserScoreNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUserScoreNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinOwnersNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxConcurrentUsersNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DeveloperBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PublisherBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MaxUserScoreNumeric;
        private System.Windows.Forms.NumericUpDown MinUserScoreNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown MinOwnersNumeric;
        private System.Windows.Forms.CheckBox FreeCheckbox;
        private System.Windows.Forms.NumericUpDown MaxConcurrentUsersNumeric;
        private System.Windows.Forms.Label label7;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ComboBox methodSelector;
        private System.Windows.Forms.Label label9;
    }
}
