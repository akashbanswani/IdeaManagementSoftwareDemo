namespace IdeaManagement
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescribtion = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.dislike = new System.Windows.Forms.Button();
            this.like = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.zoneStartupsDataSet = new IdeaManagement.ZoneStartupsDataSet();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new IdeaManagement.ZoneStartupsDataSetTableAdapters.PostTableAdapter();
            this.signupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signupTableAdapter = new IdeaManagement.ZoneStartupsDataSetTableAdapters.signupTableAdapter();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.discribtionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dislikecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zoneStartupsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idea Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "What\'s on your mind ?";
            // 
            // txtdescribtion
            // 
            this.txtdescribtion.Location = new System.Drawing.Point(104, 206);
            this.txtdescribtion.Multiline = true;
            this.txtdescribtion.Name = "txtdescribtion";
            this.txtdescribtion.Size = new System.Drawing.Size(296, 80);
            this.txtdescribtion.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Location = new System.Drawing.Point(306, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Post";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txttitle
            // 
            this.txttitle.ForeColor = System.Drawing.Color.Black;
            this.txttitle.Location = new System.Drawing.Point(104, 137);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(259, 22);
            this.txttitle.TabIndex = 11;
            // 
            // dateTime1
            // 
            this.dateTime1.Location = new System.Drawing.Point(104, 170);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(151, 22);
            this.dateTime1.TabIndex = 12;
            // 
            // dislike
            // 
            this.dislike.BackColor = System.Drawing.Color.Transparent;
            this.dislike.BackgroundImage = global::IdeaManagement.Properties.Resources.dislike;
            this.dislike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dislike.FlatAppearance.BorderSize = 0;
            this.dislike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dislike.Location = new System.Drawing.Point(149, 202);
            this.dislike.Name = "dislike";
            this.dislike.Size = new System.Drawing.Size(41, 34);
            this.dislike.TabIndex = 10;
            this.dislike.UseVisualStyleBackColor = false;
            // 
            // like
            // 
            this.like.BackgroundImage = global::IdeaManagement.Properties.Resources.like;
            this.like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.like.FlatAppearance.BorderSize = 0;
            this.like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.like.Location = new System.Drawing.Point(85, 202);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(41, 34);
            this.like.TabIndex = 9;
            this.like.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // zoneStartupsDataSet
            // 
            this.zoneStartupsDataSet.DataSetName = "ZoneStartupsDataSet";
            this.zoneStartupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.zoneStartupsDataSet;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // signupBindingSource
            // 
            this.signupBindingSource.DataMember = "signup";
            this.signupBindingSource.DataSource = this.zoneStartupsDataSet;
            // 
            // signupTableAdapter
            // 
            this.signupTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "ChangePassword",
            "ChangeUserName",
            "ChangeMobile"});
            this.comboBox.Location = new System.Drawing.Point(743, 20);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(149, 24);
            this.comboBox.TabIndex = 13;
            this.comboBox.Text = "Navigate From Here";
            this.comboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Title";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dislike);
            this.panel1.Controls.Add(this.like);
            this.panel1.Location = new System.Drawing.Point(19, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 249);
            this.panel1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.discribtionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.likecountDataGridViewTextBoxColumn,
            this.dislikecountDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 231);
            this.dataGridView1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(-1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 60);
            this.panel2.TabIndex = 19;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // discribtionDataGridViewTextBoxColumn
            // 
            this.discribtionDataGridViewTextBoxColumn.DataPropertyName = "Discribtion";
            this.discribtionDataGridViewTextBoxColumn.HeaderText = "Discribtion";
            this.discribtionDataGridViewTextBoxColumn.Name = "discribtionDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // likecountDataGridViewTextBoxColumn
            // 
            this.likecountDataGridViewTextBoxColumn.DataPropertyName = "Likecount";
            this.likecountDataGridViewTextBoxColumn.HeaderText = "Likecount";
            this.likecountDataGridViewTextBoxColumn.Name = "likecountDataGridViewTextBoxColumn";
            // 
            // dislikecountDataGridViewTextBoxColumn
            // 
            this.dislikecountDataGridViewTextBoxColumn.DataPropertyName = "Dislikecount";
            this.dislikecountDataGridViewTextBoxColumn.HeaderText = "Dislikecount";
            this.dislikecountDataGridViewTextBoxColumn.Name = "dislikecountDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "Userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "Userid";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(917, 593);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtdescribtion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.ShowIcon = false;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoneStartupsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescribtion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button like;
        private System.Windows.Forms.Button dislike;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ZoneStartupsDataSet zoneStartupsDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private ZoneStartupsDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.BindingSource signupBindingSource;
        private ZoneStartupsDataSetTableAdapters.signupTableAdapter signupTableAdapter;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discribtionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn likecountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dislikecountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
    }
}