
namespace WindowsFormsApp1
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
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.mssvTextBox = new System.Windows.Forms.TextBox();
            this.tenLabel = new System.Windows.Forms.Label();
            this.mssvLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mssvCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toanCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoaCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpaCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.toanLabel = new System.Windows.Forms.Label();
            this.lyLabel = new System.Windows.Forms.Label();
            this.hoaLabel = new System.Windows.Forms.Label();
            this.toanTextBox = new System.Windows.Forms.TextBox();
            this.lyTextBox = new System.Windows.Forms.TextBox();
            this.hoaTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tenTextBox
            // 
            this.tenTextBox.Location = new System.Drawing.Point(139, 24);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(153, 22);
            this.tenTextBox.TabIndex = 1;
            this.tenTextBox.TextChanged += new System.EventHandler(this.tenTextBox_TextChanged);
            // 
            // mssvTextBox
            // 
            this.mssvTextBox.Location = new System.Drawing.Point(139, 67);
            this.mssvTextBox.Name = "mssvTextBox";
            this.mssvTextBox.Size = new System.Drawing.Size(153, 22);
            this.mssvTextBox.TabIndex = 2;
            this.mssvTextBox.TextChanged += new System.EventHandler(this.mssvTextBox_TextChanged);
            // 
            // tenLabel
            // 
            this.tenLabel.AutoSize = true;
            this.tenLabel.Location = new System.Drawing.Point(64, 21);
            this.tenLabel.Name = "tenLabel";
            this.tenLabel.Size = new System.Drawing.Size(45, 17);
            this.tenLabel.TabIndex = 3;
            this.tenLabel.Text = "Name";
            this.tenLabel.Click += new System.EventHandler(this.tenLabel_Click);
            // 
            // mssvLabel
            // 
            this.mssvLabel.AutoSize = true;
            this.mssvLabel.Location = new System.Drawing.Point(64, 67);
            this.mssvLabel.Name = "mssvLabel";
            this.mssvLabel.Size = new System.Drawing.Size(50, 17);
            this.mssvLabel.TabIndex = 4;
            this.mssvLabel.Text = "Stu_ID";
            this.mssvLabel.Click += new System.EventHandler(this.mssvLabel_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(372, 304);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 35);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mssvCol,
            this.tenCol,
            this.toanCol,
            this.lyCol,
            this.hoaCol,
            this.gpaCol});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(320, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 249);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // mssvCol
            // 
            this.mssvCol.Text = "Stu_ID";
            this.mssvCol.Width = 98;
            // 
            // tenCol
            // 
            this.tenCol.Text = "Name";
            this.tenCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tenCol.Width = 138;
            // 
            // toanCol
            // 
            this.toanCol.Text = "Math";
            this.toanCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toanCol.Width = 78;
            // 
            // lyCol
            // 
            this.lyCol.Text = "Physic";
            this.lyCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lyCol.Width = 74;
            // 
            // hoaCol
            // 
            this.hoaCol.Text = "Chemistry";
            this.hoaCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoaCol.Width = 75;
            // 
            // gpaCol
            // 
            this.gpaCol.Text = "GPA";
            this.gpaCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gpaCol.Width = 70;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(536, 304);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 35);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // toanLabel
            // 
            this.toanLabel.AutoSize = true;
            this.toanLabel.Location = new System.Drawing.Point(64, 116);
            this.toanLabel.Name = "toanLabel";
            this.toanLabel.Size = new System.Drawing.Size(39, 17);
            this.toanLabel.TabIndex = 11;
            this.toanLabel.Text = "Math";
            this.toanLabel.Click += new System.EventHandler(this.toanLabel_Click);
            // 
            // lyLabel
            // 
            this.lyLabel.AutoSize = true;
            this.lyLabel.Location = new System.Drawing.Point(64, 165);
            this.lyLabel.Name = "lyLabel";
            this.lyLabel.Size = new System.Drawing.Size(49, 17);
            this.lyLabel.TabIndex = 12;
            this.lyLabel.Text = "Physic";
            this.lyLabel.Click += new System.EventHandler(this.lyLabel_Click);
            // 
            // hoaLabel
            // 
            this.hoaLabel.AutoSize = true;
            this.hoaLabel.Location = new System.Drawing.Point(63, 211);
            this.hoaLabel.Name = "hoaLabel";
            this.hoaLabel.Size = new System.Drawing.Size(70, 17);
            this.hoaLabel.TabIndex = 13;
            this.hoaLabel.Text = "Chemistry";
            this.hoaLabel.Click += new System.EventHandler(this.hoaLabel_Click);
            // 
            // toanTextBox
            // 
            this.toanTextBox.Location = new System.Drawing.Point(139, 116);
            this.toanTextBox.Name = "toanTextBox";
            this.toanTextBox.Size = new System.Drawing.Size(100, 22);
            this.toanTextBox.TabIndex = 14;
            this.toanTextBox.TextChanged += new System.EventHandler(this.toanTextBox_TextChanged);
            // 
            // lyTextBox
            // 
            this.lyTextBox.Location = new System.Drawing.Point(139, 165);
            this.lyTextBox.Name = "lyTextBox";
            this.lyTextBox.Size = new System.Drawing.Size(100, 22);
            this.lyTextBox.TabIndex = 15;
            this.lyTextBox.TextChanged += new System.EventHandler(this.lyTextBox_TextChanged);
            // 
            // hoaTextBox
            // 
            this.hoaTextBox.Location = new System.Drawing.Point(139, 211);
            this.hoaTextBox.Name = "hoaTextBox";
            this.hoaTextBox.Size = new System.Drawing.Size(100, 22);
            this.hoaTextBox.TabIndex = 16;
            this.hoaTextBox.TextChanged += new System.EventHandler(this.hoaTextBox_TextChanged);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(690, 304);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(92, 35);
            this.FindButton.TabIndex = 17;
            this.FindButton.Text = "Clear All";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 382);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.hoaTextBox);
            this.Controls.Add(this.lyTextBox);
            this.Controls.Add(this.toanTextBox);
            this.Controls.Add(this.hoaLabel);
            this.Controls.Add(this.lyLabel);
            this.Controls.Add(this.toanLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.mssvLabel);
            this.Controls.Add(this.tenLabel);
            this.Controls.Add(this.mssvTextBox);
            this.Controls.Add(this.tenTextBox);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox mssvTextBox;
        private System.Windows.Forms.Label tenLabel;
        private System.Windows.Forms.Label mssvLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader mssvCol;
        private System.Windows.Forms.ColumnHeader tenCol;
        private System.Windows.Forms.ColumnHeader gpaCol;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label toanLabel;
        private System.Windows.Forms.Label lyLabel;
        private System.Windows.Forms.Label hoaLabel;
        private System.Windows.Forms.TextBox toanTextBox;
        private System.Windows.Forms.TextBox lyTextBox;
        private System.Windows.Forms.TextBox hoaTextBox;
        private System.Windows.Forms.ColumnHeader toanCol;
        private System.Windows.Forms.ColumnHeader lyCol;
        private System.Windows.Forms.ColumnHeader hoaCol;
        private System.Windows.Forms.Button FindButton;
    }
}

