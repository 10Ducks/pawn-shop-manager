namespace PawnShopManager.GUI
{
   partial class LoginForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
         this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.labelX1 = new DevComponents.DotNetBar.LabelX();
         this.labelX2 = new DevComponents.DotNetBar.LabelX();
         this.labelX3 = new DevComponents.DotNetBar.LabelX();
         this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
         this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
         this.SuspendLayout();
         // 
         // txtID
         // 
         this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtID.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.txtID.Border.Class = "TextBoxBorder";
         this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.txtID.ButtonCustom.Checked = true;
         this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtID.ForeColor = System.Drawing.Color.Black;
         this.txtID.Location = new System.Drawing.Point(137, 95);
         this.txtID.Margin = new System.Windows.Forms.Padding(0);
         this.txtID.Name = "txtID";
         this.txtID.Size = new System.Drawing.Size(331, 26);
         this.txtID.TabIndex = 0;
         // 
         // labelX1
         // 
         this.labelX1.BackColor = System.Drawing.Color.Transparent;
         // 
         // 
         // 
         this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX1.ForeColor = System.Drawing.Color.Black;
         this.labelX1.Location = new System.Drawing.Point(16, 13);
         this.labelX1.Margin = new System.Windows.Forms.Padding(4);
         this.labelX1.Name = "labelX1";
         this.labelX1.Size = new System.Drawing.Size(445, 53);
         this.labelX1.TabIndex = 1;
         this.labelX1.Text = "Đăng nhập để bắt đầu sử dụng";
         this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
         this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
         // 
         // labelX2
         // 
         this.labelX2.BackColor = System.Drawing.Color.Transparent;
         // 
         // 
         // 
         this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX2.ForeColor = System.Drawing.Color.Black;
         this.labelX2.Location = new System.Drawing.Point(16, 85);
         this.labelX2.Margin = new System.Windows.Forms.Padding(4);
         this.labelX2.Name = "labelX2";
         this.labelX2.Size = new System.Drawing.Size(117, 48);
         this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.labelX2.TabIndex = 2;
         this.labelX2.Text = "Tài khoản:";
         // 
         // labelX3
         // 
         this.labelX3.BackColor = System.Drawing.Color.Transparent;
         // 
         // 
         // 
         this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX3.ForeColor = System.Drawing.Color.Black;
         this.labelX3.Location = new System.Drawing.Point(16, 129);
         this.labelX3.Margin = new System.Windows.Forms.Padding(4);
         this.labelX3.Name = "labelX3";
         this.labelX3.Size = new System.Drawing.Size(117, 48);
         this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.labelX3.TabIndex = 4;
         this.labelX3.Text = "Mật khẩu:";
         // 
         // txtPass
         // 
         this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtPass.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.txtPass.Border.Class = "TextBoxBorder";
         this.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.txtPass.ButtonCustom.Checked = true;
         this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPass.ForeColor = System.Drawing.Color.Black;
         this.txtPass.Location = new System.Drawing.Point(137, 139);
         this.txtPass.Margin = new System.Windows.Forms.Padding(0);
         this.txtPass.Name = "txtPass";
         this.txtPass.Size = new System.Drawing.Size(331, 26);
         this.txtPass.TabIndex = 3;
         // 
         // buttonX2
         // 
         this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
         this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
         this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
         this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonX2.HoverImage = global::PawnShopManager.Properties.Resources.Logout_48_hover;
         this.buttonX2.Image = global::PawnShopManager.Properties.Resources.Logout_48;
         this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
         this.buttonX2.Location = new System.Drawing.Point(388, 189);
         this.buttonX2.Margin = new System.Windows.Forms.Padding(4);
         this.buttonX2.Name = "buttonX2";
         this.buttonX2.Size = new System.Drawing.Size(80, 74);
         this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.buttonX2.TabIndex = 6;
         this.buttonX2.Text = "Thoát";
         this.buttonX2.TextColor = System.Drawing.Color.Black;
         this.buttonX2.Tooltip = "Thoát";
         this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
         // 
         // buttonX1
         // 
         this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
         this.buttonX1.BackColor = System.Drawing.Color.Transparent;
         this.buttonX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
         this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
         this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonX1.HoverImage = global::PawnShopManager.Properties.Resources.Login_Arrow_48_hover;
         this.buttonX1.Image = global::PawnShopManager.Properties.Resources.Login_Arrow_48;
         this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
         this.buttonX1.Location = new System.Drawing.Point(287, 189);
         this.buttonX1.Margin = new System.Windows.Forms.Padding(4);
         this.buttonX1.Name = "buttonX1";
         this.buttonX1.Size = new System.Drawing.Size(80, 74);
         this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.buttonX1.TabIndex = 5;
         this.buttonX1.Text = "Đăng Nhập";
         this.buttonX1.TextColor = System.Drawing.Color.Black;
         this.buttonX1.Tooltip = "Đăng nhập";
         this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
         // 
         // LoginForm
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.BackColor = System.Drawing.Color.White;
         this.BottomLeftCornerSize = 3;
         this.BottomRightCornerSize = 3;
         this.ClientSize = new System.Drawing.Size(495, 334);
         this.ControlBox = false;
         this.Controls.Add(this.buttonX2);
         this.Controls.Add(this.buttonX1);
         this.Controls.Add(this.labelX3);
         this.Controls.Add(this.txtPass);
         this.Controls.Add(this.labelX2);
         this.Controls.Add(this.labelX1);
         this.Controls.Add(this.txtID);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.MinimumSize = new System.Drawing.Size(495, 350);
         this.Name = "LoginForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Đăng nhập";
         this.ResumeLayout(false);

      }

      #endregion

      private DevComponents.DotNetBar.Controls.TextBoxX txtID;
      private DevComponents.DotNetBar.LabelX labelX1;
      private DevComponents.DotNetBar.LabelX labelX2;
      private DevComponents.DotNetBar.LabelX labelX3;
      private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
      private DevComponents.DotNetBar.ButtonX buttonX1;
      private DevComponents.DotNetBar.ButtonX buttonX2;
   }
}