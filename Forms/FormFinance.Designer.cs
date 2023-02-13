namespace CloudServer.Forms
{
    partial class FormFinance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinance));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.FinanceLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnRefreshBalance = new FontAwesome.Sharp.IconButton();
            this.RUBLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.AddPoundsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BalanceValueLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.History_label = new System.Windows.Forms.LinkLabel();
            this.Balance_btn = new System.Windows.Forms.LinkLabel();
            this.bunifuPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinanceLabel
            // 
            this.FinanceLabel.AllowParentOverrides = false;
            this.FinanceLabel.AutoEllipsis = false;
            this.FinanceLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FinanceLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.FinanceLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.FinanceLabel.Location = new System.Drawing.Point(12, 12);
            this.FinanceLabel.Name = "FinanceLabel";
            this.FinanceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FinanceLabel.Size = new System.Drawing.Size(166, 46);
            this.FinanceLabel.TabIndex = 14;
            this.FinanceLabel.Text = "Финансы";
            this.FinanceLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.FinanceLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.tabPage1);
            this.bunifuPages1.Controls.Add(this.tabPage2);
            this.bunifuPages1.Location = new System.Drawing.Point(3, 102);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabPage2;
            this.bunifuPages1.PageIndex = 1;
            this.bunifuPages1.PageName = "tabPage2";
            this.bunifuPages1.PageTitle = "tabPage2";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(794, 341);
            this.bunifuPages1.TabIndex = 18;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.bunifuPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnRefreshBalance);
            this.bunifuPanel1.Controls.Add(this.RUBLabel);
            this.bunifuPanel1.Controls.Add(this.AddPoundsButton);
            this.bunifuPanel1.Controls.Add(this.BalanceValueLabel);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel6);
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 6);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(344, 168);
            this.bunifuPanel1.TabIndex = 17;
            // 
            // btnRefreshBalance
            // 
            this.btnRefreshBalance.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshBalance.FlatAppearance.BorderSize = 0;
            this.btnRefreshBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBalance.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshBalance.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.btnRefreshBalance.IconColor = System.Drawing.Color.Black;
            this.btnRefreshBalance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshBalance.IconSize = 20;
            this.btnRefreshBalance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefreshBalance.Location = new System.Drawing.Point(301, 5);
            this.btnRefreshBalance.Name = "btnRefreshBalance";
            this.btnRefreshBalance.Size = new System.Drawing.Size(40, 37);
            this.btnRefreshBalance.TabIndex = 19;
            this.btnRefreshBalance.UseVisualStyleBackColor = false;
            this.btnRefreshBalance.Click += new System.EventHandler(this.btnRefreshBalance_Click);
            // 
            // RUBLabel
            // 
            this.RUBLabel.AllowParentOverrides = false;
            this.RUBLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RUBLabel.AutoEllipsis = false;
            this.RUBLabel.CursorType = null;
            this.RUBLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.RUBLabel.ForeColor = System.Drawing.Color.Black;
            this.RUBLabel.Location = new System.Drawing.Point(53, 37);
            this.RUBLabel.Name = "RUBLabel";
            this.RUBLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RUBLabel.Size = new System.Drawing.Size(30, 55);
            this.RUBLabel.TabIndex = 18;
            this.RUBLabel.Text = " ₽";
            this.RUBLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RUBLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AddPoundsButton
            // 
            this.AddPoundsButton.AllowAnimations = true;
            this.AddPoundsButton.AllowMouseEffects = true;
            this.AddPoundsButton.AllowToggling = false;
            this.AddPoundsButton.AnimationSpeed = 200;
            this.AddPoundsButton.AutoGenerateColors = false;
            this.AddPoundsButton.AutoRoundBorders = false;
            this.AddPoundsButton.AutoSizeLeftIcon = true;
            this.AddPoundsButton.AutoSizeRightIcon = true;
            this.AddPoundsButton.BackColor = System.Drawing.Color.Transparent;
            this.AddPoundsButton.BackColor1 = System.Drawing.Color.Black;
            this.AddPoundsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPoundsButton.BackgroundImage")));
            this.AddPoundsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundsButton.ButtonText = "Пополнить баланс";
            this.AddPoundsButton.ButtonTextMarginLeft = 0;
            this.AddPoundsButton.ColorContrastOnClick = 45;
            this.AddPoundsButton.ColorContrastOnHover = 45;
            this.AddPoundsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.AddPoundsButton.CustomizableEdges = borderEdges1;
            this.AddPoundsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddPoundsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddPoundsButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddPoundsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddPoundsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddPoundsButton.Font = new System.Drawing.Font("Montserrat SemiBold", 9F);
            this.AddPoundsButton.ForeColor = System.Drawing.Color.White;
            this.AddPoundsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPoundsButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddPoundsButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddPoundsButton.IconMarginLeft = 11;
            this.AddPoundsButton.IconPadding = 10;
            this.AddPoundsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddPoundsButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddPoundsButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddPoundsButton.IconSize = 25;
            this.AddPoundsButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.AddPoundsButton.IdleBorderRadius = 35;
            this.AddPoundsButton.IdleBorderThickness = 1;
            this.AddPoundsButton.IdleFillColor = System.Drawing.Color.Black;
            this.AddPoundsButton.IdleIconLeftImage = null;
            this.AddPoundsButton.IdleIconRightImage = null;
            this.AddPoundsButton.IndicateFocus = false;
            this.AddPoundsButton.Location = new System.Drawing.Point(97, 102);
            this.AddPoundsButton.Name = "AddPoundsButton";
            this.AddPoundsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddPoundsButton.OnDisabledState.BorderRadius = 35;
            this.AddPoundsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundsButton.OnDisabledState.BorderThickness = 1;
            this.AddPoundsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddPoundsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddPoundsButton.OnDisabledState.IconLeftImage = null;
            this.AddPoundsButton.OnDisabledState.IconRightImage = null;
            this.AddPoundsButton.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.AddPoundsButton.onHoverState.BorderRadius = 35;
            this.AddPoundsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundsButton.onHoverState.BorderThickness = 1;
            this.AddPoundsButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.AddPoundsButton.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.AddPoundsButton.onHoverState.IconLeftImage = null;
            this.AddPoundsButton.onHoverState.IconRightImage = null;
            this.AddPoundsButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.AddPoundsButton.OnIdleState.BorderRadius = 35;
            this.AddPoundsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundsButton.OnIdleState.BorderThickness = 1;
            this.AddPoundsButton.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.AddPoundsButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddPoundsButton.OnIdleState.IconLeftImage = null;
            this.AddPoundsButton.OnIdleState.IconRightImage = null;
            this.AddPoundsButton.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.AddPoundsButton.OnPressedState.BorderRadius = 35;
            this.AddPoundsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundsButton.OnPressedState.BorderThickness = 1;
            this.AddPoundsButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.AddPoundsButton.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.AddPoundsButton.OnPressedState.IconLeftImage = null;
            this.AddPoundsButton.OnPressedState.IconRightImage = null;
            this.AddPoundsButton.Size = new System.Drawing.Size(138, 40);
            this.AddPoundsButton.TabIndex = 17;
            this.AddPoundsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddPoundsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddPoundsButton.TextMarginLeft = 0;
            this.AddPoundsButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddPoundsButton.UseDefaultRadiusAndThickness = true;
            this.AddPoundsButton.Click += new System.EventHandler(this.AddPoundsButton_Click);
            // 
            // BalanceValueLabel
            // 
            this.BalanceValueLabel.AllowParentOverrides = false;
            this.BalanceValueLabel.AutoEllipsis = false;
            this.BalanceValueLabel.CursorType = null;
            this.BalanceValueLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.BalanceValueLabel.ForeColor = System.Drawing.Color.Black;
            this.BalanceValueLabel.Location = new System.Drawing.Point(20, 37);
            this.BalanceValueLabel.Name = "BalanceValueLabel";
            this.BalanceValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BalanceValueLabel.Size = new System.Drawing.Size(27, 55);
            this.BalanceValueLabel.TabIndex = 16;
            this.BalanceValueLabel.Text = "0";
            this.BalanceValueLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.BalanceValueLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel6.Location = new System.Drawing.Point(20, 15);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(46, 16);
            this.bunifuLabel6.TabIndex = 15;
            this.bunifuLabel6.Text = "Баланс";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Gainsboro;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 84);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(756, 15);
            this.bunifuSeparator1.TabIndex = 21;
            // 
            // History_label
            // 
            this.History_label.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.History_label.AutoSize = true;
            this.History_label.BackColor = System.Drawing.Color.Transparent;
            this.History_label.DisabledLinkColor = System.Drawing.Color.Gainsboro;
            this.History_label.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.History_label.ForeColor = System.Drawing.Color.Black;
            this.History_label.LinkColor = System.Drawing.Color.Gainsboro;
            this.History_label.Location = new System.Drawing.Point(106, 73);
            this.History_label.Name = "History_label";
            this.History_label.Size = new System.Drawing.Size(164, 21);
            this.History_label.TabIndex = 23;
            this.History_label.TabStop = true;
            this.History_label.Text = "История операций";
            this.History_label.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.History_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.History_label_LinkClicked);
            // 
            // Balance_btn
            // 
            this.Balance_btn.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.Balance_btn.AutoSize = true;
            this.Balance_btn.BackColor = System.Drawing.Color.Transparent;
            this.Balance_btn.DisabledLinkColor = System.Drawing.Color.Gainsboro;
            this.Balance_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Balance_btn.LinkColor = System.Drawing.Color.Gainsboro;
            this.Balance_btn.Location = new System.Drawing.Point(20, 73);
            this.Balance_btn.Name = "Balance_btn";
            this.Balance_btn.Size = new System.Drawing.Size(68, 21);
            this.Balance_btn.TabIndex = 24;
            this.Balance_btn.TabStop = true;
            this.Balance_btn.Text = "Баланс";
            this.Balance_btn.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.Balance_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Balance_btn_LinkClicked);
            // 
            // FormFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Balance_btn);
            this.Controls.Add(this.History_label);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.FinanceLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormFinance";
            this.Text = "ФИНАНСЫ";
            this.Load += new System.EventHandler(this.FormFinance_Load);
            this.bunifuPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel FinanceLabel;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private FontAwesome.Sharp.IconButton btnRefreshBalance;
        private Bunifu.UI.WinForms.BunifuLabel RUBLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddPoundsButton;
        private Bunifu.UI.WinForms.BunifuLabel BalanceValueLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.LinkLabel History_label;
        private System.Windows.Forms.LinkLabel Balance_btn;
    }
}