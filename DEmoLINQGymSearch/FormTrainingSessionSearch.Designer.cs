namespace DEmoLINQGymSearch
{
    partial class FormTrainingSessionSearch
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
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonSearch = new Button();
            listBoxResult = new ListBox();
            comboBoxSelection = new ComboBox();
            textBoxSearchCondition = new TextBox();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(12, 88);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(278, 88);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(558, 88);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.Location = new Point(12, 140);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(516, 204);
            listBoxResult.TabIndex = 4;
            listBoxResult.SelectedIndexChanged += listBoxResult_SelectedIndexChanged;
            // 
            // comboBoxSelection
            // 
            comboBoxSelection.FormattingEnabled = true;
            comboBoxSelection.Location = new Point(12, 41);
            comboBoxSelection.Name = "comboBoxSelection";
            comboBoxSelection.Size = new Size(151, 28);
            comboBoxSelection.TabIndex = 5;
            // 
            // textBoxSearchCondition
            // 
            textBoxSearchCondition.Location = new Point(185, 41);
            textBoxSearchCondition.Name = "textBoxSearchCondition";
            textBoxSearchCondition.Size = new Size(343, 27);
            textBoxSearchCondition.TabIndex = 6;
            // 
            // FormTrainingSessionSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 407);
            Controls.Add(textBoxSearchCondition);
            Controls.Add(comboBoxSelection);
            Controls.Add(listBoxResult);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "FormTrainingSessionSearch";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonSearch;
        private ListBox listBoxResult;
        private ComboBox comboBoxSelection;
        private TextBox textBoxSearchCondition;
    }
}
