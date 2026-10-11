namespace Listboxfm
{
    partial class fmListBox
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
            lst_trai = new ListBox();
            lst_phai = new ListBox();
            btnChon = new Button();
            btnChonHet = new Button();
            btnBo = new Button();
            btnBoHet = new Button();
            btnchuyen = new Button();
            SuspendLayout();
            // 
            // lst_trai
            // 
            lst_trai.FormattingEnabled = true;
            lst_trai.Items.AddRange(new object[] { "Cóc", "Ổi", "Xoài", "Mận", "Me", "Bưởi", "Cam" });
            lst_trai.Location = new Point(10, 17);
            lst_trai.Name = "lst_trai";
            lst_trai.SelectionMode = SelectionMode.MultiExtended;
            lst_trai.Size = new Size(249, 404);
            lst_trai.TabIndex = 0;
            // 
            // lst_phai
            // 
            lst_phai.FormattingEnabled = true;
            lst_phai.Location = new Point(355, 17);
            lst_phai.Name = "lst_phai";
            lst_phai.SelectionMode = SelectionMode.MultiExtended;
            lst_phai.Size = new Size(249, 404);
            lst_phai.TabIndex = 0;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(279, 118);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(60, 33);
            btnChon.TabIndex = 1;
            btnChon.Text = ">";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnQuaPhai_Click;
            // 
            // btnChonHet
            // 
            btnChonHet.Location = new Point(279, 157);
            btnChonHet.Name = "btnChonHet";
            btnChonHet.Size = new Size(60, 33);
            btnChonHet.TabIndex = 1;
            btnChonHet.Text = ">>";
            btnChonHet.UseVisualStyleBackColor = true;
            btnChonHet.Click += btnQuaPhaiAll_Click;
            // 
            // btnBo
            // 
            btnBo.Location = new Point(279, 196);
            btnBo.Name = "btnBo";
            btnBo.Size = new Size(60, 33);
            btnBo.TabIndex = 1;
            btnBo.Text = "<";
            btnBo.UseVisualStyleBackColor = true;
            btnBo.Click += btnQuaTrai_Click;
            // 
            // btnBoHet
            // 
            btnBoHet.Location = new Point(279, 235);
            btnBoHet.Name = "btnBoHet";
            btnBoHet.Size = new Size(60, 33);
            btnBoHet.TabIndex = 1;
            btnBoHet.Text = "<<";
            btnBoHet.UseVisualStyleBackColor = true;
            btnBoHet.Click += btnQuaTraiAll_Click;
            // 
            // btnchuyen
            // 
            btnchuyen.Location = new Point(279, 274);
            btnchuyen.Name = "btnchuyen";
            btnchuyen.Size = new Size(60, 58);
            btnchuyen.TabIndex = 1;
            btnchuyen.Text = "chuyen tuy y";
            btnchuyen.UseVisualStyleBackColor = true;
            btnchuyen.Click += btnchuyen_Click;
            // 
            // fmListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(btnchuyen);
            Controls.Add(btnBoHet);
            Controls.Add(btnBo);
            Controls.Add(btnChonHet);
            Controls.Add(btnChon);
            Controls.Add(lst_phai);
            Controls.Add(lst_trai);
            Name = "fmListBox";
            Text = "Sử dụng listbox";
            FormClosing += fmListBox_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_trai;
        private ListBox lst_phai;
        private Button btnChon;
        private Button btnChonHet;
        private Button btnBo;
        private Button btnBoHet;
        private Button btnchuyen;
    }
}
