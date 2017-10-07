namespace Homework_WF_3
{
    partial class DayOfTheWeekForm
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.dayOfTheWeekLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calendar.Location = new System.Drawing.Point(27, 24);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // dayOfTheWeekLabel
            // 
            this.dayOfTheWeekLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayOfTheWeekLabel.AutoSize = true;
            this.dayOfTheWeekLabel.Location = new System.Drawing.Point(24, 195);
            this.dayOfTheWeekLabel.Name = "dayOfTheWeekLabel";
            this.dayOfTheWeekLabel.Size = new System.Drawing.Size(82, 13);
            this.dayOfTheWeekLabel.TabIndex = 1;
            this.dayOfTheWeekLabel.Text = "Выберите дату";
            // 
            // DayOfTheWeekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dayOfTheWeekLabel);
            this.Controls.Add(this.calendar);
            this.Name = "DayOfTheWeekForm";
            this.Text = "Day of the week";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label dayOfTheWeekLabel;
    }
}

