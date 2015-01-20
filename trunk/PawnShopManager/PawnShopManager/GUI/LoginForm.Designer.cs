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
         this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.labelX1 = new DevComponents.DotNetBar.LabelX();
         this.labelX2 = new DevComponents.DotNetBar.LabelX();
         this.labelX3 = new DevComponents.DotNetBar.LabelX();
         this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
         this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
         this.SuspendLayout();
         // 
         // textBoxX1
         // 
         this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxX1.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.textBoxX1.Border.Class = "TextBoxBorder";
         this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.textBoxX1.ButtonCustom.Checked = true;
         this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxX1.ForeColor = System.Drawing.Color.Black;
         this.textBoxX1.Location = new System.Drawing.Point(103, 130);
         this.textBoxX1.Margin = new System.Windows.Forms.Padding(0);
         this.textBoxX1.Name = "textBoxX1";
         this.textBoxX1.Size = new System.Drawing.Size(243, 26);
         this.textBoxX1.TabIndex = 0;
         // 
         // labelX1
         // 
         // 
         // 
         // 
         this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX1.Location = new System.Drawing.Point(12, 12);
         this.labelX1.Name = "labelX1";
         this.labelX1.Size = new System.Drawing.Size(334, 86);
         this.labelX1.TabIndex = 1;
         this.labelX1.Text = "Đăng nhập vào tài khoản của bạn!";
         // 
         // labelX2
         // 
         // 
         // 
         // 
         this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX2.Location = new System.Drawing.Point(12, 122);
         this.labelX2.Name = "labelX2";
         this.labelX2.Size = new System.Drawing.Size(88, 39);
         this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.labelX2.TabIndex = 2;
         this.labelX2.Text = "Tài khoản:";
         // 
         // labelX3
         // 
         // 
         // 
         // 
         this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX3.Location = new System.Drawing.Point(12, 158);
         this.labelX3.Name = "labelX3";
         this.labelX3.Size = new System.Drawing.Size(88, 39);
         this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.labelX3.TabIndex = 4;
         this.labelX3.Text = "Mật khẩu:";
         // 
         // textBoxX2
         // 
         this.textBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxX2.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.textBoxX2.Border.Class = "TextBoxBorder";
         this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.textBoxX2.ButtonCustom.Checked = true;
         this.textBoxX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxX2.ForeColor = System.Drawing.Color.Black;
         this.textBoxX2.Location = new System.Drawing.Point(103, 166);
         this.textBoxX2.Margin = new System.Windows.Forms.Padding(0);
         this.textBoxX2.Name = "textBoxX2";
         this.textBoxX2.Size = new System.Drawing.Size(243, 26);
         this.textBoxX2.TabIndex = 3;
         // 
         // buttonX2
         // 
         this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
         this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
         this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
         this.buttonX2.HoverImage = global::PawnShopManager.Properties.Resources.Logout_48_hover;
         this.buttonX2.Image = global::PawnShopManager.Properties.Resources.Logout_48;
         this.buttonX2.Location = new System.Drawing.Point(271, 204);
         this.buttonX2.Name = "buttonX2";
         this.buttonX2.Size = new System.Drawing.Size(60, 60);
         this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.buttonX2.TabIndex = 6;
         this.buttonX2.Tooltip = "Thoát";
         this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
         // 
         // buttonX1
         // 
         this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
         this.buttonX1.BackColor = System.Drawing.Color.White;
         this.buttonX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
         this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
         this.buttonX1.HoverImage = global::PawnShopManager.Properties.Resources.Login_Arrow_48_hover;
         this.buttonX1.Image = global::PawnShopManager.Properties.Resources.Login_Arrow_48;
         this.buttonX1.Location = new System.Drawing.Point(193, 204);
         this.buttonX1.Name = "buttonX1";
         this.buttonX1.Size = new System.Drawing.Size(60, 60);
         this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.buttonX1.TabIndex = 5;
         this.buttonX1.Tooltip = "Đăng nhập";
         this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
         // 
         // LoginForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(355, 291);
         this.ControlBox = false;
         this.Controls.Add(this.buttonX2);
         this.Controls.Add(this.buttonX1);
         this.Controls.Add(this.labelX3);
         this.Controls.Add(this.textBoxX2);
         this.Controls.Add(this.labelX2);
         this.Controls.Add(this.labelX1);
         this.Controls.Add(this.textBoxX1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximumSize = new System.Drawing.Size(371, 329);
         this.MinimumSize = new System.Drawing.Size(371, 329);
         this.Name = "LoginForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Đăng nhập";
         this.ResumeLayout(false);

      }

      #endregion

      private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
      private DevComponents.DotNetBar.LabelX labelX1;
      private DevComponents.DotNetBar.LabelX labelX2;
      private DevComponents.DotNetBar.LabelX labelX3;
      private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
      private DevComponents.DotNetBar.ButtonX buttonX1;
      private DevComponents.DotNetBar.ButtonX buttonX2;
   }
}