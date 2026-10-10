namespace E_order_application_proj
{
    partial class E_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_order));
            lbTitle = new Label();
            picLogo = new PictureBox();
            Menu = new GroupBox();
            btnPepsi = new Button();
            btnLipton = new Button();
            btnCam = new Button();
            btnCafe = new Button();
            btn7up = new Button();
            btnCoca = new Button();
            btnKhoai = new Button();
            btnMy = new Button();
            btnGaran = new Button();
            btnGaCola = new Button();
            btnTomCola = new Button();
            btnBurgerCa = new Button();
            btnBurgerGa = new Button();
            btnBurgerTom = new Button();
            btnBurgerBo = new Button();
            label1 = new Label();
            cboBan = new ComboBox();
            btnXoa = new Button();
            btnOrder = new Button();
            dgvOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Blue;
            lbTitle.Location = new Point(242, 56);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(261, 46);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Fastfood Order";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(67, 36);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(77, 89);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // Menu
            // 
            Menu.Controls.Add(btnPepsi);
            Menu.Controls.Add(btnLipton);
            Menu.Controls.Add(btnCam);
            Menu.Controls.Add(btnCafe);
            Menu.Controls.Add(btn7up);
            Menu.Controls.Add(btnCoca);
            Menu.Controls.Add(btnKhoai);
            Menu.Controls.Add(btnMy);
            Menu.Controls.Add(btnGaran);
            Menu.Controls.Add(btnGaCola);
            Menu.Controls.Add(btnTomCola);
            Menu.Controls.Add(btnBurgerCa);
            Menu.Controls.Add(btnBurgerGa);
            Menu.Controls.Add(btnBurgerTom);
            Menu.Controls.Add(btnBurgerBo);
            Menu.Location = new Point(12, 131);
            Menu.Name = "Menu";
            Menu.Size = new Size(510, 187);
            Menu.TabIndex = 2;
            Menu.TabStop = false;
            Menu.Text = "Danh mục món ăn";
            // 
            // btnPepsi
            // 
            btnPepsi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPepsi.ForeColor = Color.Red;
            btnPepsi.Location = new Point(409, 44);
            btnPepsi.Name = "btnPepsi";
            btnPepsi.Size = new Size(94, 29);
            btnPepsi.TabIndex = 2;
            btnPepsi.Text = "Pepsi ";
            btnPepsi.UseVisualStyleBackColor = true;
            btnPepsi.Click += FoodButton_Click;
            // 
            // btnLipton
            // 
            btnLipton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLipton.ForeColor = Color.Red;
            btnLipton.Location = new Point(409, 79);
            btnLipton.Name = "btnLipton";
            btnLipton.Size = new Size(94, 29);
            btnLipton.TabIndex = 2;
            btnLipton.Text = "Lipton";
            btnLipton.UseVisualStyleBackColor = true;
            btnLipton.Click += FoodButton_Click;
            // 
            // btnCam
            // 
            btnCam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCam.ForeColor = Color.Red;
            btnCam.Location = new Point(409, 114);
            btnCam.Name = "btnCam";
            btnCam.Size = new Size(94, 29);
            btnCam.TabIndex = 2;
            btnCam.Text = "Cam";
            btnCam.UseVisualStyleBackColor = true;
            btnCam.Click += FoodButton_Click;
            // 
            // btnCafe
            // 
            btnCafe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCafe.ForeColor = Color.Red;
            btnCafe.Location = new Point(309, 114);
            btnCafe.Name = "btnCafe";
            btnCafe.Size = new Size(94, 29);
            btnCafe.TabIndex = 2;
            btnCafe.Text = "Cafe";
            btnCafe.UseVisualStyleBackColor = true;
            btnCafe.Click += FoodButton_Click;
            // 
            // btn7up
            // 
            btn7up.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7up.ForeColor = Color.Red;
            btn7up.Location = new Point(309, 79);
            btn7up.Name = "btn7up";
            btn7up.Size = new Size(94, 29);
            btn7up.TabIndex = 2;
            btn7up.Text = "7up";
            btn7up.UseVisualStyleBackColor = true;
            btn7up.Click += FoodButton_Click;
            // 
            // btnCoca
            // 
            btnCoca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCoca.ForeColor = Color.Red;
            btnCoca.Location = new Point(309, 44);
            btnCoca.Name = "btnCoca";
            btnCoca.Size = new Size(94, 29);
            btnCoca.TabIndex = 2;
            btnCoca.Text = "Coca";
            btnCoca.UseVisualStyleBackColor = true;
            btnCoca.Click += FoodButton_Click;
            // 
            // btnKhoai
            // 
            btnKhoai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhoai.ForeColor = Color.DarkGreen;
            btnKhoai.Location = new Point(309, 149);
            btnKhoai.Name = "btnKhoai";
            btnKhoai.Size = new Size(194, 29);
            btnKhoai.TabIndex = 1;
            btnKhoai.Text = "Khoai tây chiên";
            btnKhoai.UseVisualStyleBackColor = true;
            btnKhoai.Click += FoodButton_Click;
            // 
            // btnMy
            // 
            btnMy.ForeColor = Color.Blue;
            btnMy.Location = new Point(186, 149);
            btnMy.Name = "btnMy";
            btnMy.Size = new Size(117, 29);
            btnMy.TabIndex = 1;
            btnMy.Text = "Mỳ spaghetti";
            btnMy.UseVisualStyleBackColor = true;
            btnMy.Click += FoodButton_Click;
            // 
            // btnGaran
            // 
            btnGaran.ForeColor = Color.Blue;
            btnGaran.Location = new Point(186, 114);
            btnGaran.Name = "btnGaran";
            btnGaran.Size = new Size(117, 29);
            btnGaran.TabIndex = 1;
            btnGaran.Text = "Gà rán phần";
            btnGaran.UseVisualStyleBackColor = true;
            btnGaran.Click += FoodButton_Click;
            // 
            // btnGaCola
            // 
            btnGaCola.ForeColor = Color.Blue;
            btnGaCola.Location = new Point(186, 79);
            btnGaCola.Name = "btnGaCola";
            btnGaCola.Size = new Size(117, 29);
            btnGaCola.TabIndex = 1;
            btnGaCola.Text = "Gà viên Cola";
            btnGaCola.UseVisualStyleBackColor = true;
            btnGaCola.Click += FoodButton_Click;
            // 
            // btnTomCola
            // 
            btnTomCola.ForeColor = Color.Blue;
            btnTomCola.Location = new Point(186, 44);
            btnTomCola.Name = "btnTomCola";
            btnTomCola.Size = new Size(117, 29);
            btnTomCola.TabIndex = 1;
            btnTomCola.Text = "Tôm viên Cola";
            btnTomCola.UseVisualStyleBackColor = true;
            btnTomCola.Click += FoodButton_Click;
            // 
            // btnBurgerCa
            // 
            btnBurgerCa.ForeColor = Color.Red;
            btnBurgerCa.Location = new Point(23, 149);
            btnBurgerCa.Name = "btnBurgerCa";
            btnBurgerCa.Size = new Size(157, 29);
            btnBurgerCa.TabIndex = 0;
            btnBurgerCa.Text = "Buger phô mai cá";
            btnBurgerCa.UseVisualStyleBackColor = true;
            btnBurgerCa.Click += FoodButton_Click;
            // 
            // btnBurgerGa
            // 
            btnBurgerGa.ForeColor = Color.Red;
            btnBurgerGa.Location = new Point(23, 114);
            btnBurgerGa.Name = "btnBurgerGa";
            btnBurgerGa.Size = new Size(157, 29);
            btnBurgerGa.TabIndex = 0;
            btnBurgerGa.Text = "Buger phô mai gà";
            btnBurgerGa.UseVisualStyleBackColor = true;
            btnBurgerGa.Click += FoodButton_Click;
            // 
            // btnBurgerTom
            // 
            btnBurgerTom.ForeColor = Color.Red;
            btnBurgerTom.Location = new Point(23, 79);
            btnBurgerTom.Name = "btnBurgerTom";
            btnBurgerTom.Size = new Size(157, 29);
            btnBurgerTom.TabIndex = 0;
            btnBurgerTom.Text = "Buger phô mai tôm";
            btnBurgerTom.UseVisualStyleBackColor = true;
            btnBurgerTom.Click += FoodButton_Click;
            // 
            // btnBurgerBo
            // 
            btnBurgerBo.ForeColor = Color.Red;
            btnBurgerBo.Location = new Point(23, 44);
            btnBurgerBo.Name = "btnBurgerBo";
            btnBurgerBo.Size = new Size(157, 29);
            btnBurgerBo.TabIndex = 0;
            btnBurgerBo.Text = "Buger phô mai bò";
            btnBurgerBo.UseVisualStyleBackColor = true;
            btnBurgerBo.Click += FoodButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 338);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên bàn";
            // 
            // cboBan
            // 
            cboBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBan.FormattingEnabled = true;
            cboBan.Location = new Point(198, 330);
            cboBan.Name = "cboBan";
            cboBan.Size = new Size(151, 28);
            cboBan.TabIndex = 4;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(31, 329);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.BottomCenter;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(428, 329);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(30, 375);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(482, 214);
            dgvOrder.TabIndex = 6;
            // 
            // E_order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 603);
            Controls.Add(dgvOrder);
            Controls.Add(btnOrder);
            Controls.Add(btnXoa);
            Controls.Add(cboBan);
            Controls.Add(label1);
            Controls.Add(Menu);
            Controls.Add(picLogo);
            Controls.Add(lbTitle);
            Name = "E_order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-order Application";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private PictureBox picLogo;
        private GroupBox Menu;
        private Button btnBurgerBo;
        private Button btnBurgerCa;
        private Button btnBurgerGa;
        private Button btnBurgerTom;
        private Button btnTomCola;
        private Button btnMy;
        private Button btnGaran;
        private Button btnGaCola;
        private Button button2;
        private Button btnCoca;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnKhoai;
        private Button btnPepsi;
        private Button btnLipton;
        private Button btnCam;
        private Button btnCafe;
        private Button btn7up;
        private Label label1;
        private ComboBox cboBan;
        private Button btnXoa;
        private Button btnOrder;
        private DataGridView dgvOrder;
    }
}