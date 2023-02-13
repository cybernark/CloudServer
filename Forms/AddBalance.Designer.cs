namespace CloudServer.Forms
{
    partial class AddBalance
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBalance));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SummLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SummTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.CardNumberLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.CvvTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.DateLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.CvvLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.AddPoundBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.NumberTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.RubLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DateTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SummLabel
            // 
            this.SummLabel.AllowParentOverrides = false;
            this.SummLabel.AutoEllipsis = false;
            this.SummLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SummLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.SummLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.SummLabel.ForeColor = System.Drawing.Color.White;
            this.SummLabel.Location = new System.Drawing.Point(51, 54);
            this.SummLabel.Name = "SummLabel";
            this.SummLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SummLabel.Size = new System.Drawing.Size(227, 22);
            this.SummLabel.TabIndex = 10;
            this.SummLabel.Text = "Введите сумму пополнеия";
            this.SummLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SummLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SummTextBox
            // 
            this.SummTextBox.AcceptsReturn = false;
            this.SummTextBox.AcceptsTab = false;
            this.SummTextBox.AnimationSpeed = 200;
            this.SummTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SummTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SummTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SummTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SummTextBox.BackgroundImage")));
            this.SummTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SummTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SummTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SummTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.SummTextBox.BorderRadius = 15;
            this.SummTextBox.BorderThickness = 1;
            this.SummTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SummTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SummTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SummTextBox.DefaultText = "";
            this.SummTextBox.FillColor = System.Drawing.Color.White;
            this.SummTextBox.HideSelection = true;
            this.SummTextBox.IconLeft = null;
            this.SummTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SummTextBox.IconPadding = 10;
            this.SummTextBox.IconRight = null;
            this.SummTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SummTextBox.Lines = new string[0];
            this.SummTextBox.Location = new System.Drawing.Point(51, 82);
            this.SummTextBox.MaxLength = 12;
            this.SummTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SummTextBox.Modified = false;
            this.SummTextBox.Multiline = false;
            this.SummTextBox.Name = "SummTextBox";
            stateProperties13.BorderColor = System.Drawing.Color.LawnGreen;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SummTextBox.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SummTextBox.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SummTextBox.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SummTextBox.OnIdleState = stateProperties16;
            this.SummTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.SummTextBox.PasswordChar = '\0';
            this.SummTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.SummTextBox.PlaceholderText = "";
            this.SummTextBox.ReadOnly = false;
            this.SummTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SummTextBox.SelectedText = "";
            this.SummTextBox.SelectionLength = 0;
            this.SummTextBox.SelectionStart = 0;
            this.SummTextBox.ShortcutsEnabled = true;
            this.SummTextBox.Size = new System.Drawing.Size(136, 37);
            this.SummTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SummTextBox.TabIndex = 11;
            this.SummTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SummTextBox.TextMarginBottom = 0;
            this.SummTextBox.TextMarginLeft = 3;
            this.SummTextBox.TextMarginTop = 0;
            this.SummTextBox.TextPlaceholder = "";
            this.SummTextBox.UseSystemPasswordChar = false;
            this.SummTextBox.WordWrap = true;
            this.SummTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SummTextBox_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(301, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AllowParentOverrides = false;
            this.CardNumberLabel.AutoEllipsis = false;
            this.CardNumberLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CardNumberLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.CardNumberLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.CardNumberLabel.ForeColor = System.Drawing.Color.White;
            this.CardNumberLabel.Location = new System.Drawing.Point(51, 183);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardNumberLabel.Size = new System.Drawing.Size(187, 22);
            this.CardNumberLabel.TabIndex = 13;
            this.CardNumberLabel.Text = "Введите номер карты";
            this.CardNumberLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CardNumberLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CvvTextBox
            // 
            this.CvvTextBox.AcceptsReturn = false;
            this.CvvTextBox.AcceptsTab = false;
            this.CvvTextBox.AnimationSpeed = 200;
            this.CvvTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CvvTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CvvTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CvvTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CvvTextBox.BackgroundImage")));
            this.CvvTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CvvTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CvvTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CvvTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.CvvTextBox.BorderRadius = 15;
            this.CvvTextBox.BorderThickness = 1;
            this.CvvTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CvvTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CvvTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.CvvTextBox.DefaultText = "";
            this.CvvTextBox.FillColor = System.Drawing.Color.White;
            this.CvvTextBox.HideSelection = true;
            this.CvvTextBox.IconLeft = null;
            this.CvvTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CvvTextBox.IconPadding = 10;
            this.CvvTextBox.IconRight = null;
            this.CvvTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CvvTextBox.Lines = new string[0];
            this.CvvTextBox.Location = new System.Drawing.Point(189, 286);
            this.CvvTextBox.MaxLength = 3;
            this.CvvTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.CvvTextBox.Modified = false;
            this.CvvTextBox.Multiline = false;
            this.CvvTextBox.Name = "CvvTextBox";
            stateProperties9.BorderColor = System.Drawing.Color.LawnGreen;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CvvTextBox.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CvvTextBox.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CvvTextBox.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CvvTextBox.OnIdleState = stateProperties12;
            this.CvvTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.CvvTextBox.PasswordChar = '●';
            this.CvvTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CvvTextBox.PlaceholderText = "000";
            this.CvvTextBox.ReadOnly = false;
            this.CvvTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CvvTextBox.SelectedText = "";
            this.CvvTextBox.SelectionLength = 0;
            this.CvvTextBox.SelectionStart = 0;
            this.CvvTextBox.ShortcutsEnabled = true;
            this.CvvTextBox.Size = new System.Drawing.Size(89, 37);
            this.CvvTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CvvTextBox.TabIndex = 15;
            this.CvvTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CvvTextBox.TextMarginBottom = 0;
            this.CvvTextBox.TextMarginLeft = 3;
            this.CvvTextBox.TextMarginTop = 0;
            this.CvvTextBox.TextPlaceholder = "000";
            this.CvvTextBox.UseSystemPasswordChar = true;
            this.CvvTextBox.WordWrap = true;
            this.CvvTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CvvTextBox_KeyPress);
            // 
            // DateLabel
            // 
            this.DateLabel.AllowParentOverrides = false;
            this.DateLabel.AutoEllipsis = false;
            this.DateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.DateLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(51, 258);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateLabel.Size = new System.Drawing.Size(43, 22);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Срок";
            this.DateLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DateLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CvvLabel
            // 
            this.CvvLabel.AllowParentOverrides = false;
            this.CvvLabel.AutoEllipsis = false;
            this.CvvLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CvvLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.CvvLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.CvvLabel.ForeColor = System.Drawing.Color.White;
            this.CvvLabel.Location = new System.Drawing.Point(193, 258);
            this.CvvLabel.Name = "CvvLabel";
            this.CvvLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CvvLabel.Size = new System.Drawing.Size(78, 22);
            this.CvvLabel.TabIndex = 17;
            this.CvvLabel.Text = "CVV/CVC";
            this.CvvLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CvvLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AddPoundBtn
            // 
            this.AddPoundBtn.AllowAnimations = true;
            this.AddPoundBtn.AllowMouseEffects = true;
            this.AddPoundBtn.AllowToggling = false;
            this.AddPoundBtn.AnimationSpeed = 200;
            this.AddPoundBtn.AutoGenerateColors = false;
            this.AddPoundBtn.AutoRoundBorders = false;
            this.AddPoundBtn.AutoSizeLeftIcon = true;
            this.AddPoundBtn.AutoSizeRightIcon = true;
            this.AddPoundBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddPoundBtn.BackColor1 = System.Drawing.Color.White;
            this.AddPoundBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPoundBtn.BackgroundImage")));
            this.AddPoundBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundBtn.ButtonText = "Пополнить";
            this.AddPoundBtn.ButtonTextMarginLeft = 0;
            this.AddPoundBtn.ColorContrastOnClick = 45;
            this.AddPoundBtn.ColorContrastOnHover = 45;
            this.AddPoundBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.AddPoundBtn.CustomizableEdges = borderEdges1;
            this.AddPoundBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddPoundBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddPoundBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddPoundBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddPoundBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddPoundBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.AddPoundBtn.ForeColor = System.Drawing.Color.Black;
            this.AddPoundBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPoundBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddPoundBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddPoundBtn.IconMarginLeft = 11;
            this.AddPoundBtn.IconPadding = 10;
            this.AddPoundBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddPoundBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddPoundBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddPoundBtn.IconSize = 25;
            this.AddPoundBtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.AddPoundBtn.IdleBorderRadius = 20;
            this.AddPoundBtn.IdleBorderThickness = 1;
            this.AddPoundBtn.IdleFillColor = System.Drawing.Color.White;
            this.AddPoundBtn.IdleIconLeftImage = null;
            this.AddPoundBtn.IdleIconRightImage = null;
            this.AddPoundBtn.IndicateFocus = false;
            this.AddPoundBtn.Location = new System.Drawing.Point(100, 336);
            this.AddPoundBtn.Name = "AddPoundBtn";
            this.AddPoundBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddPoundBtn.OnDisabledState.BorderRadius = 20;
            this.AddPoundBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundBtn.OnDisabledState.BorderThickness = 1;
            this.AddPoundBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddPoundBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddPoundBtn.OnDisabledState.IconLeftImage = null;
            this.AddPoundBtn.OnDisabledState.IconRightImage = null;
            this.AddPoundBtn.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.AddPoundBtn.onHoverState.BorderRadius = 20;
            this.AddPoundBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundBtn.onHoverState.BorderThickness = 1;
            this.AddPoundBtn.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.AddPoundBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddPoundBtn.onHoverState.IconLeftImage = null;
            this.AddPoundBtn.onHoverState.IconRightImage = null;
            this.AddPoundBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.AddPoundBtn.OnIdleState.BorderRadius = 20;
            this.AddPoundBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundBtn.OnIdleState.BorderThickness = 1;
            this.AddPoundBtn.OnIdleState.FillColor = System.Drawing.Color.White;
            this.AddPoundBtn.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.AddPoundBtn.OnIdleState.IconLeftImage = null;
            this.AddPoundBtn.OnIdleState.IconRightImage = null;
            this.AddPoundBtn.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.AddPoundBtn.OnPressedState.BorderRadius = 20;
            this.AddPoundBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddPoundBtn.OnPressedState.BorderThickness = 1;
            this.AddPoundBtn.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.AddPoundBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddPoundBtn.OnPressedState.IconLeftImage = null;
            this.AddPoundBtn.OnPressedState.IconRightImage = null;
            this.AddPoundBtn.Size = new System.Drawing.Size(125, 40);
            this.AddPoundBtn.TabIndex = 18;
            this.AddPoundBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddPoundBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddPoundBtn.TextMarginLeft = 0;
            this.AddPoundBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddPoundBtn.UseDefaultRadiusAndThickness = true;
            this.AddPoundBtn.Click += new System.EventHandler(this.AddPoundBtn_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.AcceptsReturn = false;
            this.NumberTextBox.AcceptsTab = false;
            this.NumberTextBox.AnimationSpeed = 200;
            this.NumberTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NumberTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NumberTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NumberTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NumberTextBox.BackgroundImage")));
            this.NumberTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.NumberTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NumberTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.NumberTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.NumberTextBox.BorderRadius = 15;
            this.NumberTextBox.BorderThickness = 1;
            this.NumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.NumberTextBox.DefaultText = "";
            this.NumberTextBox.FillColor = System.Drawing.Color.White;
            this.NumberTextBox.HideSelection = true;
            this.NumberTextBox.IconLeft = null;
            this.NumberTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.IconPadding = 10;
            this.NumberTextBox.IconRight = null;
            this.NumberTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.Lines = new string[0];
            this.NumberTextBox.Location = new System.Drawing.Point(51, 211);
            this.NumberTextBox.MaxLength = 16;
            this.NumberTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.NumberTextBox.Modified = false;
            this.NumberTextBox.Multiline = false;
            this.NumberTextBox.Name = "NumberTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.LawnGreen;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.NumberTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnIdleState = stateProperties8;
            this.NumberTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.NumberTextBox.PasswordChar = '\0';
            this.NumberTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.NumberTextBox.PlaceholderText = "";
            this.NumberTextBox.ReadOnly = false;
            this.NumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NumberTextBox.SelectedText = "";
            this.NumberTextBox.SelectionLength = 0;
            this.NumberTextBox.SelectionStart = 0;
            this.NumberTextBox.ShortcutsEnabled = true;
            this.NumberTextBox.Size = new System.Drawing.Size(227, 37);
            this.NumberTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.NumberTextBox.TabIndex = 19;
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberTextBox.TextMarginBottom = 0;
            this.NumberTextBox.TextMarginLeft = 3;
            this.NumberTextBox.TextMarginTop = 0;
            this.NumberTextBox.TextPlaceholder = "";
            this.NumberTextBox.UseSystemPasswordChar = false;
            this.NumberTextBox.WordWrap = true;
            this.NumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // RubLabel
            // 
            this.RubLabel.AllowParentOverrides = false;
            this.RubLabel.AutoEllipsis = false;
            this.RubLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RubLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.RubLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.RubLabel.ForeColor = System.Drawing.Color.White;
            this.RubLabel.Location = new System.Drawing.Point(192, 89);
            this.RubLabel.Name = "RubLabel";
            this.RubLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RubLabel.Size = new System.Drawing.Size(37, 22);
            this.RubLabel.TabIndex = 20;
            this.RubLabel.Text = "RUB";
            this.RubLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RubLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DateTextBox
            // 
            this.DateTextBox.AcceptsReturn = false;
            this.DateTextBox.AcceptsTab = false;
            this.DateTextBox.AnimationSpeed = 200;
            this.DateTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.DateTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.DateTextBox.BackColor = System.Drawing.Color.Transparent;
            this.DateTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DateTextBox.BackgroundImage")));
            this.DateTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.DateTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DateTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DateTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.DateTextBox.BorderRadius = 15;
            this.DateTextBox.BorderThickness = 1;
            this.DateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DateTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.DateTextBox.DefaultText = "";
            this.DateTextBox.FillColor = System.Drawing.Color.White;
            this.DateTextBox.HideSelection = true;
            this.DateTextBox.IconLeft = null;
            this.DateTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.DateTextBox.IconPadding = 10;
            this.DateTextBox.IconRight = null;
            this.DateTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.DateTextBox.Lines = new string[0];
            this.DateTextBox.Location = new System.Drawing.Point(51, 286);
            this.DateTextBox.MaxLength = 5;
            this.DateTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.DateTextBox.Modified = false;
            this.DateTextBox.Multiline = false;
            this.DateTextBox.Name = "DateTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.LawnGreen;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.DateTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.DateTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.DateTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.DateTextBox.OnIdleState = stateProperties4;
            this.DateTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.DateTextBox.PasswordChar = '\0';
            this.DateTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.DateTextBox.PlaceholderText = "00/00";
            this.DateTextBox.ReadOnly = false;
            this.DateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DateTextBox.SelectedText = "";
            this.DateTextBox.SelectionLength = 0;
            this.DateTextBox.SelectionStart = 0;
            this.DateTextBox.ShortcutsEnabled = true;
            this.DateTextBox.Size = new System.Drawing.Size(89, 37);
            this.DateTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.DateTextBox.TabIndex = 21;
            this.DateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateTextBox.TextMarginBottom = 0;
            this.DateTextBox.TextMarginLeft = 3;
            this.DateTextBox.TextMarginTop = 0;
            this.DateTextBox.TextPlaceholder = "00/00";
            this.DateTextBox.UseSystemPasswordChar = false;
            this.DateTextBox.WordWrap = true;
            this.DateTextBox.TextChanged += new System.EventHandler(this.DateTextBox_TextChanged);
            // 
            // AddBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(335, 400);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.RubLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.AddPoundBtn);
            this.Controls.Add(this.CvvLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CvvTextBox);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.SummTextBox);
            this.Controls.Add(this.SummLabel);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AddBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBalance";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddBalance_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private FontAwesome.Sharp.IconButton btnClose;
        private Bunifu.UI.WinForms.BunifuTextBox SummTextBox;
        private Bunifu.UI.WinForms.BunifuLabel SummLabel;
        private Bunifu.UI.WinForms.BunifuLabel CvvLabel;
        private Bunifu.UI.WinForms.BunifuLabel DateLabel;
        private Bunifu.UI.WinForms.BunifuTextBox CvvTextBox;
        private Bunifu.UI.WinForms.BunifuLabel CardNumberLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddPoundBtn;
        private Bunifu.UI.WinForms.BunifuTextBox NumberTextBox;
        private Bunifu.UI.WinForms.BunifuLabel RubLabel;
        private Bunifu.UI.WinForms.BunifuTextBox DateTextBox;
    }
}