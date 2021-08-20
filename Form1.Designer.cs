
namespace CarrierCommand2SaveEditor
{
    partial class SaveEditor
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
            this.openFileBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.listView3 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Q = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CollapseNodeBtn = new System.Windows.Forms.Button();
            this.expandNodeBtn = new System.Windows.Forms.Button();
            this.secondaryListView = new System.Windows.Forms.ListView();
            this.secondaryTbValue = new System.Windows.Forms.TextBox();
            this.secondaryTbName = new System.Windows.Forms.TextBox();
            this.primaryTbValue = new System.Windows.Forms.TextBox();
            this.primaryTbName = new System.Windows.Forms.TextBox();
            this.secondaryTreeView = new System.Windows.Forms.TreeView();
            this.primaryTreeView = new System.Windows.Forms.TreeView();
            this.primaryListView = new System.Windows.Forms.ListView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(12, 12);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.MouseCaptureChanged += new System.EventHandler(this.OpenBtn_MouseClick);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(93, 12);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(75, 23);
            this.saveFileBtn.TabIndex = 1;
            this.saveFileBtn.Text = "Save";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.SaveBtn_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 663);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.listView3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Team Editor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox3);
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Location = new System.Drawing.Point(275, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 448);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Blueprint Editor";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 397);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 120;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(366, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 171);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Toggle";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(160, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Islands Provide All Blueprints";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.Window;
            this.listView3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(6, 6);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(146, 171);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            this.listView3.ItemActivate += new System.EventHandler(this.TeamList_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(158, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 171);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TeamToggle";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Max Inventory";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Unlock All Blueprints";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(7, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 448);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventory Editor";
            // 
            // listView4
            // 
            this.listView4.AllowColumnReorder = true;
            this.listView4.BackColor = System.Drawing.SystemColors.Window;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Q});
            this.listView4.GridLines = true;
            this.listView4.HideSelection = false;
            this.listView4.LabelEdit = true;
            this.listView4.Location = new System.Drawing.Point(6, 45);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(250, 397);
            this.listView4.TabIndex = 4;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            this.listView4.ItemActivate += new System.EventHandler(this.InventoryList_MouseClick);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 164;
            // 
            // Q
            // 
            this.Q.Text = "Q";
            this.Q.Width = 82;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.InventoryValue_TextChange);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CollapseNodeBtn);
            this.tabPage2.Controls.Add(this.expandNodeBtn);
            this.tabPage2.Controls.Add(this.secondaryListView);
            this.tabPage2.Controls.Add(this.secondaryTbValue);
            this.tabPage2.Controls.Add(this.secondaryTbName);
            this.tabPage2.Controls.Add(this.primaryTbValue);
            this.tabPage2.Controls.Add(this.primaryTbName);
            this.tabPage2.Controls.Add(this.secondaryTreeView);
            this.tabPage2.Controls.Add(this.primaryTreeView);
            this.tabPage2.Controls.Add(this.primaryListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Node Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CollapseNodeBtn
            // 
            this.CollapseNodeBtn.Location = new System.Drawing.Point(7, 35);
            this.CollapseNodeBtn.Name = "CollapseNodeBtn";
            this.CollapseNodeBtn.Size = new System.Drawing.Size(75, 23);
            this.CollapseNodeBtn.TabIndex = 9;
            this.CollapseNodeBtn.Text = "Collapse";
            this.CollapseNodeBtn.UseVisualStyleBackColor = true;
            // 
            // expandNodeBtn
            // 
            this.expandNodeBtn.Location = new System.Drawing.Point(6, 6);
            this.expandNodeBtn.Name = "expandNodeBtn";
            this.expandNodeBtn.Size = new System.Drawing.Size(75, 23);
            this.expandNodeBtn.TabIndex = 8;
            this.expandNodeBtn.Text = "Expand";
            this.expandNodeBtn.UseVisualStyleBackColor = true;
            // 
            // secondaryListView
            // 
            this.secondaryListView.HideSelection = false;
            this.secondaryListView.Location = new System.Drawing.Point(363, 386);
            this.secondaryListView.Name = "secondaryListView";
            this.secondaryListView.Size = new System.Drawing.Size(270, 244);
            this.secondaryListView.TabIndex = 7;
            this.secondaryListView.UseCompatibleStateImageBehavior = false;
            this.secondaryListView.View = System.Windows.Forms.View.List;
            this.secondaryListView.ItemActivate += new System.EventHandler(this.SecondaryList_MouseClick);
            // 
            // secondaryTbValue
            // 
            this.secondaryTbValue.Location = new System.Drawing.Point(470, 360);
            this.secondaryTbValue.Name = "secondaryTbValue";
            this.secondaryTbValue.Size = new System.Drawing.Size(163, 20);
            this.secondaryTbValue.TabIndex = 5;
            this.secondaryTbValue.TextChanged += new System.EventHandler(this.SecondaryValue_TextChange);
            // 
            // secondaryTbName
            // 
            this.secondaryTbName.Location = new System.Drawing.Point(363, 360);
            this.secondaryTbName.Name = "secondaryTbName";
            this.secondaryTbName.ReadOnly = true;
            this.secondaryTbName.Size = new System.Drawing.Size(101, 20);
            this.secondaryTbName.TabIndex = 4;
            // 
            // primaryTbValue
            // 
            this.primaryTbValue.Location = new System.Drawing.Point(194, 360);
            this.primaryTbValue.Name = "primaryTbValue";
            this.primaryTbValue.Size = new System.Drawing.Size(163, 20);
            this.primaryTbValue.TabIndex = 3;
            this.primaryTbValue.TextChanged += new System.EventHandler(this.PrimaryValue_TextChange);
            // 
            // primaryTbName
            // 
            this.primaryTbName.Location = new System.Drawing.Point(87, 360);
            this.primaryTbName.Name = "primaryTbName";
            this.primaryTbName.ReadOnly = true;
            this.primaryTbName.Size = new System.Drawing.Size(101, 20);
            this.primaryTbName.TabIndex = 2;
            // 
            // secondaryTreeView
            // 
            this.secondaryTreeView.Location = new System.Drawing.Point(363, 6);
            this.secondaryTreeView.Name = "secondaryTreeView";
            this.secondaryTreeView.Size = new System.Drawing.Size(270, 348);
            this.secondaryTreeView.TabIndex = 1;
            this.secondaryTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SecondaryTree_NodeMouseClick);
            // 
            // primaryTreeView
            // 
            this.primaryTreeView.Location = new System.Drawing.Point(87, 6);
            this.primaryTreeView.Name = "primaryTreeView";
            this.primaryTreeView.Size = new System.Drawing.Size(270, 348);
            this.primaryTreeView.TabIndex = 0;
            this.primaryTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PrimaryTree_NodeMouseClick);
            // 
            // primaryListView
            // 
            this.primaryListView.HideSelection = false;
            this.primaryListView.Location = new System.Drawing.Point(87, 386);
            this.primaryListView.Name = "primaryListView";
            this.primaryListView.Size = new System.Drawing.Size(270, 244);
            this.primaryListView.TabIndex = 6;
            this.primaryListView.UseCompatibleStateImageBehavior = false;
            this.primaryListView.View = System.Windows.Forms.View.List;
            this.primaryListView.ItemActivate += new System.EventHandler(this.PrimaryList_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(190, 147);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Work In Progress";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 18);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(256, 147);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "Work In Progress";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(7, 45);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(244, 397);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "Work In Progress";
            // 
            // SaveEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(666, 716);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.openFileBtn);
            this.Name = "SaveEditor";
            this.Text = "CC2 Save Editor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CollapseNodeBtn;
        private System.Windows.Forms.Button expandNodeBtn;
        private System.Windows.Forms.ListView secondaryListView;
        private System.Windows.Forms.ListView primaryListView;
        private System.Windows.Forms.TextBox secondaryTbValue;
        private System.Windows.Forms.TextBox secondaryTbName;
        private System.Windows.Forms.TextBox primaryTbValue;
        private System.Windows.Forms.TextBox primaryTbName;
        private System.Windows.Forms.TreeView secondaryTreeView;
        private System.Windows.Forms.TreeView primaryTreeView;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Q;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

