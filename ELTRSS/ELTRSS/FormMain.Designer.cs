namespace ELTRSS
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.m_button_test_sqlite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_button_test_sqlite
            // 
            this.m_button_test_sqlite.Location = new System.Drawing.Point(60, 60);
            this.m_button_test_sqlite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_button_test_sqlite.Name = "m_button_test_sqlite";
            this.m_button_test_sqlite.Size = new System.Drawing.Size(175, 52);
            this.m_button_test_sqlite.TabIndex = 1;
            this.m_button_test_sqlite.Text = "Test SQLite";
            this.m_button_test_sqlite.UseVisualStyleBackColor = true;
            this.m_button_test_sqlite.Click += new System.EventHandler(this.m_button_test_sqlite_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 603);
            this.Controls.Add(this.m_button_test_sqlite);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormMain";
            this.Text = "Elite_Rack_Shuttle_System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_button_test_sqlite;
    }
}

