using System.Collections.Generic;
using System.Windows.Forms;

namespace CurrencyExchangerDesktop
{
    class ComboItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }

    partial class CurrencyExchangerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyExchangerForm));
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(128, 35);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(120, 21);
            this.currencyComboBox.TabIndex = 0;
            this.currencyComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleControlKeyDownEvent);
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(128, 68);
            this.datePicker.MaxDate = System.DateTime.Now.Date;
            this.datePicker.MinDate = new System.DateTime(1996, 9, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleControlKeyDownEvent);
            this.datePicker.Value = System.DateTime.Now.Date;
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(13, 38);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(99, 13);
            this.currencyLabel.TabIndex = 2;
            this.currencyLabel.Text = "Выберите валюту:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 74);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(85, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Выберите дату:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(60, 120);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 25);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Получить курс валюты";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressLabel.ForeColor = System.Drawing.Color.Red;
            this.progressLabel.Location = new System.Drawing.Point(46, 98);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(177, 13);
            this.progressLabel.TabIndex = 5;
            this.progressLabel.Text = "Выполняется запрос на сервер...";
            this.progressLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Курс валют по НБУ";
            // 
            // CurrencyExchangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.currencyComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CurrencyExchangerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private Label currencyLabel;
        private Label dateLabel;
        private Button calculateButton;
        private Label progressLabel;
        private Label label1;
    }
}

