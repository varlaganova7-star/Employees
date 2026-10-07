namespace Employees.View
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
            dataGridViewEmployees = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPosition = new TextBox();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelPosition = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(43, 25);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 82;
            dataGridViewEmployees.Size = new Size(1126, 376);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(56, 723);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 46);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(288, 723);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 46);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(1019, 728);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.RightToLeft = RightToLeft.No;
            buttonRefresh.Size = new Size(150, 46);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(244, 444);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 39);
            textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(244, 510);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 39);
            textBoxLastName.TabIndex = 5;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(244, 576);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(200, 39);
            textBoxPosition.TabIndex = 6;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(60, 445);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(57, 32);
            labelFirstName.TabIndex = 7;
            labelFirstName.Text = "имя";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(58, 510);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(112, 32);
            labelLastName.TabIndex = 8;
            labelLastName.Text = "фамилия";
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(59, 577);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(133, 32);
            labelPosition.TabIndex = 9;
            labelPosition.Text = "должность";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 843);
            Controls.Add(labelPosition);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewEmployees);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonRefresh;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPosition;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelPosition;
    }
}
