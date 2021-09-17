
namespace EF_DotNetCore
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdDeleteEmployee = new System.Windows.Forms.Button();
            this.cmdUpdateEmployee = new System.Windows.Forms.Button();
            this.cmdCreateEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdDeleteEmployee);
            this.groupBox1.Controls.Add(this.cmdUpdateEmployee);
            this.groupBox1.Controls.Add(this.cmdCreateEmployee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboDepartment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtEmployee);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(667, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(373, 87);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 28);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdDeleteEmployee
            // 
            this.cmdDeleteEmployee.Location = new System.Drawing.Point(481, 53);
            this.cmdDeleteEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDeleteEmployee.Name = "cmdDeleteEmployee";
            this.cmdDeleteEmployee.Size = new System.Drawing.Size(100, 28);
            this.cmdDeleteEmployee.TabIndex = 8;
            this.cmdDeleteEmployee.Text = "Delete";
            this.cmdDeleteEmployee.UseVisualStyleBackColor = true;
            this.cmdDeleteEmployee.Click += new System.EventHandler(this.cmdDeleteEmployee_Click);
            // 
            // cmdUpdateEmployee
            // 
            this.cmdUpdateEmployee.Location = new System.Drawing.Point(373, 53);
            this.cmdUpdateEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdUpdateEmployee.Name = "cmdUpdateEmployee";
            this.cmdUpdateEmployee.Size = new System.Drawing.Size(100, 28);
            this.cmdUpdateEmployee.TabIndex = 7;
            this.cmdUpdateEmployee.Text = "Update";
            this.cmdUpdateEmployee.UseVisualStyleBackColor = true;
            this.cmdUpdateEmployee.Click += new System.EventHandler(this.cmdUpdateEmployee_Click);
            // 
            // cmdCreateEmployee
            // 
            this.cmdCreateEmployee.Location = new System.Drawing.Point(265, 53);
            this.cmdCreateEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCreateEmployee.Name = "cmdCreateEmployee";
            this.cmdCreateEmployee.Size = new System.Drawing.Size(100, 28);
            this.cmdCreateEmployee.TabIndex = 6;
            this.cmdCreateEmployee.Text = "Create";
            this.cmdCreateEmployee.UseVisualStyleBackColor = true;
            this.cmdCreateEmployee.Click += new System.EventHandler(this.cmdCreateEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department:";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(102, 55);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(154, 24);
            this.cboDepartment.TabIndex = 4;
            this.cboDepartment.Text = "Please Select...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Due Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(493, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(102, 23);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(286, 22);
            this.txtEmployee.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(667, 247);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(714, 445);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Master";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdDeleteEmployee;
        private System.Windows.Forms.Button cmdUpdateEmployee;
        private System.Windows.Forms.Button cmdCreateEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}