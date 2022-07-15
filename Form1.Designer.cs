namespace TestGroupedComboBoxDatasource
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
            this.cboComboBox = new GroupedComboBox();
            this.btnChangeDataSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboComboBox
            // 
            this.cboComboBox.DataSource = null;
            this.cboComboBox.DisplayMember = "ItemName";
            this.cboComboBox.FormattingEnabled = true;
            this.cboComboBox.GroupMember = "GroupName";
            this.cboComboBox.Location = new System.Drawing.Point(139, 82);
            this.cboComboBox.Name = "cboComboBox";
            this.cboComboBox.Size = new System.Drawing.Size(254, 21);
            this.cboComboBox.TabIndex = 0;
            this.cboComboBox.ValueMember = "ItemId";
            // 
            // btnChangeDataSource
            // 
            this.btnChangeDataSource.Location = new System.Drawing.Point(139, 120);
            this.btnChangeDataSource.Name = "btnChangeDataSource";
            this.btnChangeDataSource.Size = new System.Drawing.Size(254, 23);
            this.btnChangeDataSource.TabIndex = 1;
            this.btnChangeDataSource.Text = "Change DataSource";
            this.btnChangeDataSource.UseVisualStyleBackColor = true;
            this.btnChangeDataSource.Click += new System.EventHandler(this.btnChangeDataSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeDataSource);
            this.Controls.Add(this.cboComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupedComboBox cboComboBox;
        private System.Windows.Forms.Button btnChangeDataSource;
    }
}

