namespace AddresList
{
    partial class LinkForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.munuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.linkmanAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.linkmanUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.linkmanDel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munuManage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // munuManage
            // 
            this.munuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkmanAdd,
            this.linkmanUpdate,
            this.linkmanDel});
            this.munuManage.Name = "munuManage";
            this.munuManage.Size = new System.Drawing.Size(98, 26);
            this.munuManage.Text = "通讯录管理";
            // 
            // linkmanAdd
            // 
            this.linkmanAdd.Name = "linkmanAdd";
            this.linkmanAdd.Size = new System.Drawing.Size(224, 26);
            this.linkmanAdd.Text = "新增联系人";
            this.linkmanAdd.Click += new System.EventHandler(this.linkmanAdd_Click);
            // 
            // linkmanUpdate
            // 
            this.linkmanUpdate.Name = "linkmanUpdate";
            this.linkmanUpdate.Size = new System.Drawing.Size(224, 26);
            this.linkmanUpdate.Text = "修改联系人";
            // 
            // linkmanDel
            // 
            this.linkmanDel.Name = "linkmanDel";
            this.linkmanDel.Size = new System.Drawing.Size(224, 26);
            this.linkmanDel.Text = "删除联系人";
            // 
            // LinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LinkForm";
            this.Text = "通讯录";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem munuManage;
        private System.Windows.Forms.ToolStripMenuItem linkmanAdd;
        private System.Windows.Forms.ToolStripMenuItem linkmanUpdate;
        private System.Windows.Forms.ToolStripMenuItem linkmanDel;
    }
}