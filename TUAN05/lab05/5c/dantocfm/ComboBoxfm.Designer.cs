namespace dantocfm
{
    partial class ComboBoxfm
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
            label1 = new Label();
            btnLoad = new Button();
            cbo_dt = new ComboBox();
            btnShow = new Button();
            lbKQ = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 95);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Dân tộc";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(479, 51);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load dữ liệu dân tộc";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cbo_dt
            // 
            cbo_dt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_dt.FormattingEnabled = true;
            cbo_dt.Location = new Point(114, 95);
            cbo_dt.Name = "cbo_dt";
            cbo_dt.Size = new Size(373, 28);
            cbo_dt.TabIndex = 2;
            cbo_dt.SelectedIndexChanged += cbo_dt_SelectedIndexChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(26, 150);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(143, 41);
            btnShow.TabIndex = 3;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lbKQ
            // 
            lbKQ.AutoSize = true;
            lbKQ.Location = new Point(198, 158);
            lbKQ.Name = "lbKQ";
            lbKQ.Size = new Size(0, 20);
            lbKQ.TabIndex = 4;
            // 
            // ComboBoxfm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 224);
            Controls.Add(lbKQ);
            Controls.Add(btnShow);
            Controls.Add(cbo_dt);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Name = "ComboBoxfm";
            Text = "Cbo_Dantoc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLoad;
        private ComboBox cbo_dt;
        private Button btnShow;
        private Label lbKQ;
    }
}
