namespace CloudServer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Registerlabel = new System.Windows.Forms.LinkLabel();
            this.AutorizationLabel = new System.Windows.Forms.Label();
            this.Login = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CloseAPPbtn = new FontAwesome.Sharp.IconButton();
            this.LoginButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Password = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CheckPass = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.iconEye = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).BeginInit();
            this.SuspendLayout();
            // 
            // Registerlabel
            // 
            this.Registerlabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(234)))), ((int)(((byte)(126)))));
            this.Registerlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Registerlabel.AutoSize = true;
            this.Registerlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registerlabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Registerlabel.LinkColor = System.Drawing.Color.Black;
            this.Registerlabel.Location = new System.Drawing.Point(700, 455);
            this.Registerlabel.Name = "Registerlabel";
            this.Registerlabel.Size = new System.Drawing.Size(87, 17);
            this.Registerlabel.TabIndex = 21;
            this.Registerlabel.TabStop = true;
            this.Registerlabel.Text = "Register now";
            this.Registerlabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(234)))), ((int)(((byte)(126)))));
            this.Registerlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registerlabel_LinkClicked_1);
            // 
            // AutorizationLabel
            // 
            this.AutorizationLabel.AutoSize = true;
            this.AutorizationLabel.Font = new System.Drawing.Font("Syncopate Cyr", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorizationLabel.Location = new System.Drawing.Point(265, 80);
            this.AutorizationLabel.Name = "AutorizationLabel";
            this.AutorizationLabel.Size = new System.Drawing.Size(249, 26);
            this.AutorizationLabel.TabIndex = 16;
            this.AutorizationLabel.Text = "Autorization";
            // 
            // Login
            // 
            this.Login.AcceptsReturn = false;
            this.Login.AcceptsTab = false;
            this.Login.AnimationSpeed = 200;
            this.Login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Login.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Login.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Login.BorderColorIdle = System.Drawing.Color.Silver;
            this.Login.BorderRadius = 10;
            this.Login.BorderThickness = 1;
            this.Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Login.DefaultText = "";
            this.Login.FillColor = System.Drawing.Color.White;
            this.Login.HideSelection = true;
            this.Login.IconLeft = null;
            this.Login.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Login.IconPadding = 10;
            this.Login.IconRight = null;
            this.Login.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Login.Lines = new string[0];
            this.Login.Location = new System.Drawing.Point(303, 196);
            this.Login.MaxLength = 32767;
            this.Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.Login.Modified = false;
            this.Login.Multiline = false;
            this.Login.Name = "Login";
            stateProperties1.BorderColor = System.Drawing.Color.Black;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Login.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Login.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Black;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Login.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Login.OnIdleState = stateProperties4;
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.PasswordChar = '\0';
            this.Login.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Login.PlaceholderText = "Login";
            this.Login.ReadOnly = false;
            this.Login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Login.SelectedText = "";
            this.Login.SelectionLength = 0;
            this.Login.SelectionStart = 0;
            this.Login.ShortcutsEnabled = true;
            this.Login.Size = new System.Drawing.Size(208, 37);
            this.Login.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Login.TabIndex = 23;
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Login.TextMarginBottom = 0;
            this.Login.TextMarginLeft = 3;
            this.Login.TextMarginTop = 0;
            this.Login.TextPlaceholder = "Login";
            this.Login.UseSystemPasswordChar = false;
            this.Login.WordWrap = true;
            // 
            // CloseAPPbtn
            // 
            this.CloseAPPbtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseAPPbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAPPbtn.FlatAppearance.BorderSize = 0;
            this.CloseAPPbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAPPbtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.CloseAPPbtn.IconColor = System.Drawing.SystemColors.ControlText;
            this.CloseAPPbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.CloseAPPbtn.IconSize = 16;
            this.CloseAPPbtn.Location = new System.Drawing.Point(769, 12);
            this.CloseAPPbtn.Name = "CloseAPPbtn";
            this.CloseAPPbtn.Size = new System.Drawing.Size(19, 22);
            this.CloseAPPbtn.TabIndex = 22;
            this.CloseAPPbtn.UseVisualStyleBackColor = false;
            this.CloseAPPbtn.Click += new System.EventHandler(this.CloseAPPbtn_Click_1);
            // 
            // LoginButton
            // 
            this.LoginButton.AllowAnimations = true;
            this.LoginButton.AllowMouseEffects = true;
            this.LoginButton.AllowToggling = false;
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.AnimationSpeed = 200;
            this.LoginButton.AutoGenerateColors = false;
            this.LoginButton.AutoRoundBorders = false;
            this.LoginButton.AutoSizeLeftIcon = true;
            this.LoginButton.AutoSizeRightIcon = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BackColor1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.ButtonTextMarginLeft = 0;
            this.LoginButton.ColorContrastOnClick = 45;
            this.LoginButton.ColorContrastOnHover = 45;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.LoginButton.CustomizableEdges = borderEdges1;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LoginButton.Font = new System.Drawing.Font("Holder Light PERSONAL USE ONLY", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LoginButton.IconMarginLeft = 11;
            this.LoginButton.IconPadding = 10;
            this.LoginButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LoginButton.IconSize = 25;
            this.LoginButton.IdleBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.IdleBorderRadius = 10;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.IdleIconLeftImage = null;
            this.LoginButton.IdleIconRightImage = null;
            this.LoginButton.IndicateFocus = false;
            this.LoginButton.Location = new System.Drawing.Point(329, 330);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginButton.OnDisabledState.BorderRadius = 10;
            this.LoginButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.OnDisabledState.BorderThickness = 1;
            this.LoginButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginButton.OnDisabledState.IconLeftImage = null;
            this.LoginButton.OnDisabledState.IconRightImage = null;
            this.LoginButton.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.onHoverState.BorderRadius = 10;
            this.LoginButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.onHoverState.BorderThickness = 1;
            this.LoginButton.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.LoginButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LoginButton.onHoverState.IconLeftImage = null;
            this.LoginButton.onHoverState.IconRightImage = null;
            this.LoginButton.OnIdleState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.OnIdleState.BorderRadius = 10;
            this.LoginButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.OnIdleState.BorderThickness = 1;
            this.LoginButton.OnIdleState.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LoginButton.OnIdleState.IconLeftImage = null;
            this.LoginButton.OnIdleState.IconRightImage = null;
            this.LoginButton.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.OnPressedState.BorderRadius = 10;
            this.LoginButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.OnPressedState.BorderThickness = 1;
            this.LoginButton.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.LoginButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LoginButton.OnPressedState.IconLeftImage = null;
            this.LoginButton.OnPressedState.IconRightImage = null;
            this.LoginButton.Size = new System.Drawing.Size(129, 42);
            this.LoginButton.TabIndex = 20;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginButton.TextMarginLeft = 0;
            this.LoginButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoginButton.UseDefaultRadiusAndThickness = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Password
            // 
            this.Password.AcceptsReturn = false;
            this.Password.AcceptsTab = false;
            this.Password.AnimationSpeed = 200;
            this.Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Password.BackgroundImage")));
            this.Password.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Password.BorderColorIdle = System.Drawing.Color.Silver;
            this.Password.BorderRadius = 10;
            this.Password.BorderThickness = 1;
            this.Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Password.DefaultText = "";
            this.Password.FillColor = System.Drawing.Color.White;
            this.Password.HideSelection = true;
            this.Password.IconLeft = null;
            this.Password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.IconPadding = 10;
            this.Password.IconRight = null;
            this.Password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(303, 264);
            this.Password.MaxLength = 32767;
            this.Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.Password.Modified = false;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            stateProperties5.BorderColor = System.Drawing.Color.Black;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Password.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Password.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Black;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Password.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Password.OnIdleState = stateProperties8;
            this.Password.Padding = new System.Windows.Forms.Padding(3);
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Password.PlaceholderText = "Password";
            this.Password.ReadOnly = false;
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(208, 37);
            this.Password.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Password.TabIndex = 17;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.TextMarginBottom = 0;
            this.Password.TextMarginLeft = 3;
            this.Password.TextMarginTop = 0;
            this.Password.TextPlaceholder = "Password";
            this.Password.UseSystemPasswordChar = false;
            this.Password.WordWrap = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CheckPass
            // 
            this.CheckPass.AllowBindingControlAnimation = true;
            this.CheckPass.AllowBindingControlColorChanges = false;
            this.CheckPass.AllowBindingControlLocation = true;
            this.CheckPass.AllowCheckBoxAnimation = false;
            this.CheckPass.AllowCheckmarkAnimation = true;
            this.CheckPass.AllowOnHoverStates = true;
            this.CheckPass.AutoCheck = true;
            this.CheckPass.BackColor = System.Drawing.Color.Transparent;
            this.CheckPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckPass.BackgroundImage")));
            this.CheckPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckPass.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckPass.BorderRadius = 12;
            this.CheckPass.Checked = false;
            this.CheckPass.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.CheckPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckPass.CustomCheckmarkImage = null;
            this.CheckPass.Location = new System.Drawing.Point(516, 272);
            this.CheckPass.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckPass.Name = "CheckPass";
            this.CheckPass.OnCheck.BorderColor = System.Drawing.Color.Transparent;
            this.CheckPass.OnCheck.BorderRadius = 12;
            this.CheckPass.OnCheck.BorderThickness = 2;
            this.CheckPass.OnCheck.CheckBoxColor = System.Drawing.Color.Black;
            this.CheckPass.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckPass.OnCheck.CheckmarkThickness = 2;
            this.CheckPass.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckPass.OnDisable.BorderRadius = 12;
            this.CheckPass.OnDisable.BorderThickness = 2;
            this.CheckPass.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckPass.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckPass.OnDisable.CheckmarkThickness = 2;
            this.CheckPass.OnHoverChecked.BorderColor = System.Drawing.Color.Black;
            this.CheckPass.OnHoverChecked.BorderRadius = 12;
            this.CheckPass.OnHoverChecked.BorderThickness = 2;
            this.CheckPass.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Black;
            this.CheckPass.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckPass.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckPass.OnHoverUnchecked.BorderColor = System.Drawing.Color.Black;
            this.CheckPass.OnHoverUnchecked.BorderRadius = 12;
            this.CheckPass.OnHoverUnchecked.BorderThickness = 1;
            this.CheckPass.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.White;
            this.CheckPass.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckPass.OnUncheck.BorderRadius = 12;
            this.CheckPass.OnUncheck.BorderThickness = 1;
            this.CheckPass.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckPass.Size = new System.Drawing.Size(21, 21);
            this.CheckPass.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckPass.TabIndex = 24;
            this.CheckPass.ThreeState = false;
            this.CheckPass.ToolTipText = null;
            this.CheckPass.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckPass_CheckedChanged);
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.Transparent;
            this.iconUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 37;
            this.iconUser.Location = new System.Drawing.Point(260, 196);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(37, 37);
            this.iconUser.TabIndex = 26;
            this.iconUser.TabStop = false;
            // 
            // iconEye
            // 
            this.iconEye.BackColor = System.Drawing.Color.Transparent;
            this.iconEye.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconEye.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEye.IconSize = 37;
            this.iconEye.Location = new System.Drawing.Point(260, 264);
            this.iconEye.Name = "iconEye";
            this.iconEye.Size = new System.Drawing.Size(37, 37);
            this.iconEye.TabIndex = 27;
            this.iconEye.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.iconEye);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.CheckPass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.CloseAPPbtn);
            this.Controls.Add(this.Registerlabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.AutorizationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox Login;
        private FontAwesome.Sharp.IconButton CloseAPPbtn;
        private System.Windows.Forms.LinkLabel Registerlabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoginButton;
        private Bunifu.UI.WinForms.BunifuTextBox Password;
        private System.Windows.Forms.Label AutorizationLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuCheckBox CheckPass;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconEye;
    }
}