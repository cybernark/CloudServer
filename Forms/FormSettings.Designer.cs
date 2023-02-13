namespace CloudServer.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DataProfileLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.EmailLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.LoginUserLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.NumberLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ChangeNumberLabel = new System.Windows.Forms.LinkLabel();
            this.DBemailLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DBloginLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DBphone_numberLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.ChangeProfilebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // DataProfileLabel
            // 
            this.DataProfileLabel.AllowParentOverrides = false;
            this.DataProfileLabel.AutoEllipsis = false;
            this.DataProfileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataProfileLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.DataProfileLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.DataProfileLabel.Location = new System.Drawing.Point(24, 12);
            this.DataProfileLabel.Name = "DataProfileLabel";
            this.DataProfileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataProfileLabel.Size = new System.Drawing.Size(392, 46);
            this.DataProfileLabel.TabIndex = 0;
            this.DataProfileLabel.Text = "Профиль и настройки";
            this.DataProfileLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DataProfileLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AllowParentOverrides = false;
            this.EmailLabel.AutoEllipsis = false;
            this.EmailLabel.CursorType = null;
            this.EmailLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailLabel.Location = new System.Drawing.Point(28, 124);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailLabel.Size = new System.Drawing.Size(54, 22);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "E-mail";
            this.EmailLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.EmailLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LoginUserLabel
            // 
            this.LoginUserLabel.AllowParentOverrides = false;
            this.LoginUserLabel.AutoEllipsis = false;
            this.LoginUserLabel.CursorType = null;
            this.LoginUserLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.LoginUserLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LoginUserLabel.Location = new System.Drawing.Point(28, 176);
            this.LoginUserLabel.Name = "LoginUserLabel";
            this.LoginUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginUserLabel.Size = new System.Drawing.Size(86, 22);
            this.LoginUserLabel.TabIndex = 3;
            this.LoginUserLabel.Text = "Владелец";
            this.LoginUserLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LoginUserLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AllowParentOverrides = false;
            this.NumberLabel.AutoEllipsis = false;
            this.NumberLabel.CursorType = null;
            this.NumberLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.NumberLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NumberLabel.Location = new System.Drawing.Point(28, 228);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberLabel.Size = new System.Drawing.Size(147, 22);
            this.NumberLabel.TabIndex = 4;
            this.NumberLabel.Text = "Номер телефона";
            this.NumberLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NumberLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ChangeNumberLabel
            // 
            this.ChangeNumberLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(234)))), ((int)(((byte)(126)))));
            this.ChangeNumberLabel.AutoSize = true;
            this.ChangeNumberLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeNumberLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ChangeNumberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChangeNumberLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ChangeNumberLabel.LinkColor = System.Drawing.SystemColors.ControlText;
            this.ChangeNumberLabel.Location = new System.Drawing.Point(254, 284);
            this.ChangeNumberLabel.MaximumSize = new System.Drawing.Size(146, 21);
            this.ChangeNumberLabel.MinimumSize = new System.Drawing.Size(146, 21);
            this.ChangeNumberLabel.Name = "ChangeNumberLabel";
            this.ChangeNumberLabel.Size = new System.Drawing.Size(146, 21);
            this.ChangeNumberLabel.TabIndex = 6;
            this.ChangeNumberLabel.TabStop = true;
            this.ChangeNumberLabel.Text = "Изменить номер";
            this.ChangeNumberLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(234)))), ((int)(((byte)(126)))));
            this.ChangeNumberLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeNumberLabel_LinkClicked);
            // 
            // DBemailLabel
            // 
            this.DBemailLabel.AllowParentOverrides = false;
            this.DBemailLabel.AutoEllipsis = false;
            this.DBemailLabel.CursorType = null;
            this.DBemailLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.DBemailLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DBemailLabel.Location = new System.Drawing.Point(262, 124);
            this.DBemailLabel.Name = "DBemailLabel";
            this.DBemailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBemailLabel.Size = new System.Drawing.Size(47, 22);
            this.DBemailLabel.TabIndex = 8;
            this.DBemailLabel.Text = "email";
            this.DBemailLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DBemailLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DBloginLabel
            // 
            this.DBloginLabel.AllowParentOverrides = false;
            this.DBloginLabel.AutoEllipsis = false;
            this.DBloginLabel.CursorType = null;
            this.DBloginLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.DBloginLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DBloginLabel.Location = new System.Drawing.Point(262, 176);
            this.DBloginLabel.Name = "DBloginLabel";
            this.DBloginLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBloginLabel.Size = new System.Drawing.Size(42, 22);
            this.DBloginLabel.TabIndex = 9;
            this.DBloginLabel.Text = "login";
            this.DBloginLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DBloginLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DBphone_numberLabel
            // 
            this.DBphone_numberLabel.AllowParentOverrides = false;
            this.DBphone_numberLabel.AutoEllipsis = false;
            this.DBphone_numberLabel.CursorType = null;
            this.DBphone_numberLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.DBphone_numberLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DBphone_numberLabel.Location = new System.Drawing.Point(262, 228);
            this.DBphone_numberLabel.Name = "DBphone_numberLabel";
            this.DBphone_numberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBphone_numberLabel.Size = new System.Drawing.Size(128, 22);
            this.DBphone_numberLabel.TabIndex = 10;
            this.DBphone_numberLabel.Text = "phone_number";
            this.DBphone_numberLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DBphone_numberLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(24, 81);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(148, 22);
            this.bunifuLabel1.TabIndex = 12;
            this.bunifuLabel1.Text = "Данные профиля";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 30;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(422, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(37, 35);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ChangeProfilebtn
            // 
            this.ChangeProfilebtn.AllowAnimations = true;
            this.ChangeProfilebtn.AllowMouseEffects = true;
            this.ChangeProfilebtn.AllowToggling = false;
            this.ChangeProfilebtn.AnimationSpeed = 200;
            this.ChangeProfilebtn.AutoGenerateColors = false;
            this.ChangeProfilebtn.AutoRoundBorders = false;
            this.ChangeProfilebtn.AutoSizeLeftIcon = true;
            this.ChangeProfilebtn.AutoSizeRightIcon = true;
            this.ChangeProfilebtn.BackColor = System.Drawing.Color.Transparent;
            this.ChangeProfilebtn.BackColor1 = System.Drawing.SystemColors.ControlText;
            this.ChangeProfilebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeProfilebtn.BackgroundImage")));
            this.ChangeProfilebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeProfilebtn.ButtonText = "Редактировать профиль";
            this.ChangeProfilebtn.ButtonTextMarginLeft = 0;
            this.ChangeProfilebtn.ColorContrastOnClick = 45;
            this.ChangeProfilebtn.ColorContrastOnHover = 45;
            this.ChangeProfilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.ChangeProfilebtn.CustomizableEdges = borderEdges3;
            this.ChangeProfilebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChangeProfilebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeProfilebtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ChangeProfilebtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ChangeProfilebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ChangeProfilebtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ChangeProfilebtn.ForeColor = System.Drawing.Color.White;
            this.ChangeProfilebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeProfilebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ChangeProfilebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ChangeProfilebtn.IconMarginLeft = 11;
            this.ChangeProfilebtn.IconPadding = 10;
            this.ChangeProfilebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeProfilebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ChangeProfilebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ChangeProfilebtn.IconSize = 25;
            this.ChangeProfilebtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.ChangeProfilebtn.IdleBorderRadius = 20;
            this.ChangeProfilebtn.IdleBorderThickness = 1;
            this.ChangeProfilebtn.IdleFillColor = System.Drawing.SystemColors.ControlText;
            this.ChangeProfilebtn.IdleIconLeftImage = null;
            this.ChangeProfilebtn.IdleIconRightImage = null;
            this.ChangeProfilebtn.IndicateFocus = false;
            this.ChangeProfilebtn.Location = new System.Drawing.Point(17, 275);
            this.ChangeProfilebtn.MaximumSize = new System.Drawing.Size(206, 39);
            this.ChangeProfilebtn.MinimumSize = new System.Drawing.Size(206, 39);
            this.ChangeProfilebtn.Name = "ChangeProfilebtn";
            this.ChangeProfilebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeProfilebtn.OnDisabledState.BorderRadius = 20;
            this.ChangeProfilebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeProfilebtn.OnDisabledState.BorderThickness = 1;
            this.ChangeProfilebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ChangeProfilebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ChangeProfilebtn.OnDisabledState.IconLeftImage = null;
            this.ChangeProfilebtn.OnDisabledState.IconRightImage = null;
            this.ChangeProfilebtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeProfilebtn.onHoverState.BorderRadius = 20;
            this.ChangeProfilebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeProfilebtn.onHoverState.BorderThickness = 1;
            this.ChangeProfilebtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeProfilebtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ChangeProfilebtn.onHoverState.IconLeftImage = null;
            this.ChangeProfilebtn.onHoverState.IconRightImage = null;
            this.ChangeProfilebtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.ChangeProfilebtn.OnIdleState.BorderRadius = 20;
            this.ChangeProfilebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeProfilebtn.OnIdleState.BorderThickness = 1;
            this.ChangeProfilebtn.OnIdleState.FillColor = System.Drawing.SystemColors.ControlText;
            this.ChangeProfilebtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ChangeProfilebtn.OnIdleState.IconLeftImage = null;
            this.ChangeProfilebtn.OnIdleState.IconRightImage = null;
            this.ChangeProfilebtn.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.ChangeProfilebtn.OnPressedState.BorderRadius = 20;
            this.ChangeProfilebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeProfilebtn.OnPressedState.BorderThickness = 1;
            this.ChangeProfilebtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeProfilebtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ChangeProfilebtn.OnPressedState.IconLeftImage = null;
            this.ChangeProfilebtn.OnPressedState.IconRightImage = null;
            this.ChangeProfilebtn.Size = new System.Drawing.Size(206, 39);
            this.ChangeProfilebtn.TabIndex = 5;
            this.ChangeProfilebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeProfilebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeProfilebtn.TextMarginLeft = 0;
            this.ChangeProfilebtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.ChangeProfilebtn.UseDefaultRadiusAndThickness = true;
            this.ChangeProfilebtn.Click += new System.EventHandler(this.ChangeProfilebtn_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.DBphone_numberLabel);
            this.Controls.Add(this.DBloginLabel);
            this.Controls.Add(this.DBemailLabel);
            this.Controls.Add(this.ChangeNumberLabel);
            this.Controls.Add(this.ChangeProfilebtn);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.LoginUserLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.DataProfileLabel);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Name = "FormSettings";
            this.Text = "НАСТРОЙКИ";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel DataProfileLabel;
        private Bunifu.UI.WinForms.BunifuLabel EmailLabel;
        private Bunifu.UI.WinForms.BunifuLabel LoginUserLabel;
        private Bunifu.UI.WinForms.BunifuLabel NumberLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ChangeProfilebtn;
        private System.Windows.Forms.LinkLabel ChangeNumberLabel;
        private Bunifu.UI.WinForms.BunifuLabel DBemailLabel;
        private Bunifu.UI.WinForms.BunifuLabel DBloginLabel;
        private Bunifu.UI.WinForms.BunifuLabel DBphone_numberLabel;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}