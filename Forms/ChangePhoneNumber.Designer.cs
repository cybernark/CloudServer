namespace CloudServer.Forms
{
    partial class ChangePhoneNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePhoneNumber));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ChangePhoneLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnChange = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.NumberTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ChangePhoneLabel
            // 
            this.ChangePhoneLabel.AllowParentOverrides = false;
            this.ChangePhoneLabel.AutoEllipsis = false;
            this.ChangePhoneLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChangePhoneLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.ChangePhoneLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.ChangePhoneLabel.ForeColor = System.Drawing.Color.White;
            this.ChangePhoneLabel.Location = new System.Drawing.Point(45, 37);
            this.ChangePhoneLabel.Name = "ChangePhoneLabel";
            this.ChangePhoneLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangePhoneLabel.Size = new System.Drawing.Size(280, 22);
            this.ChangePhoneLabel.TabIndex = 9;
            this.ChangePhoneLabel.Text = "Введите новый номер телефона:";
            this.ChangePhoneLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ChangePhoneLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnChange
            // 
            this.btnChange.AllowAnimations = true;
            this.btnChange.AllowMouseEffects = true;
            this.btnChange.AllowToggling = false;
            this.btnChange.AnimationSpeed = 200;
            this.btnChange.AutoGenerateColors = false;
            this.btnChange.AutoRoundBorders = false;
            this.btnChange.AutoSizeLeftIcon = true;
            this.btnChange.AutoSizeRightIcon = true;
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.BackColor1 = System.Drawing.Color.White;
            this.btnChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChange.BackgroundImage")));
            this.btnChange.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChange.ButtonText = "Изменить";
            this.btnChange.ButtonTextMarginLeft = 0;
            this.btnChange.ColorContrastOnClick = 45;
            this.btnChange.ColorContrastOnHover = 45;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnChange.CustomizableEdges = borderEdges1;
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChange.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChange.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChange.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChange.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnChange.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.Color.Black;
            this.btnChange.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnChange.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnChange.IconMarginLeft = 11;
            this.btnChange.IconPadding = 10;
            this.btnChange.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChange.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnChange.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnChange.IconSize = 25;
            this.btnChange.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnChange.IdleBorderRadius = 20;
            this.btnChange.IdleBorderThickness = 1;
            this.btnChange.IdleFillColor = System.Drawing.Color.White;
            this.btnChange.IdleIconLeftImage = null;
            this.btnChange.IdleIconRightImage = null;
            this.btnChange.IndicateFocus = false;
            this.btnChange.Location = new System.Drawing.Point(123, 135);
            this.btnChange.Name = "btnChange";
            this.btnChange.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChange.OnDisabledState.BorderRadius = 20;
            this.btnChange.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChange.OnDisabledState.BorderThickness = 1;
            this.btnChange.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChange.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChange.OnDisabledState.IconLeftImage = null;
            this.btnChange.OnDisabledState.IconRightImage = null;
            this.btnChange.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnChange.onHoverState.BorderRadius = 20;
            this.btnChange.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChange.onHoverState.BorderThickness = 1;
            this.btnChange.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnChange.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnChange.onHoverState.IconLeftImage = null;
            this.btnChange.onHoverState.IconRightImage = null;
            this.btnChange.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnChange.OnIdleState.BorderRadius = 20;
            this.btnChange.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChange.OnIdleState.BorderThickness = 1;
            this.btnChange.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnChange.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnChange.OnIdleState.IconLeftImage = null;
            this.btnChange.OnIdleState.IconRightImage = null;
            this.btnChange.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnChange.OnPressedState.BorderRadius = 20;
            this.btnChange.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChange.OnPressedState.BorderThickness = 1;
            this.btnChange.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.btnChange.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnChange.OnPressedState.IconLeftImage = null;
            this.btnChange.OnPressedState.IconRightImage = null;
            this.btnChange.Size = new System.Drawing.Size(125, 40);
            this.btnChange.TabIndex = 8;
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChange.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChange.TextMarginLeft = 0;
            this.btnChange.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnChange.UseDefaultRadiusAndThickness = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.btnClose.Location = new System.Drawing.Point(339, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.NumberTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberTextBox.DefaultText = "";
            this.NumberTextBox.FillColor = System.Drawing.Color.White;
            this.NumberTextBox.HideSelection = true;
            this.NumberTextBox.IconLeft = null;
            this.NumberTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.IconPadding = 10;
            this.NumberTextBox.IconRight = null;
            this.NumberTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.Lines = new string[0];
            this.NumberTextBox.Location = new System.Drawing.Point(45, 75);
            this.NumberTextBox.MaxLength = 32767;
            this.NumberTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.NumberTextBox.Modified = false;
            this.NumberTextBox.Multiline = false;
            this.NumberTextBox.Name = "NumberTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.NumberTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnIdleState = stateProperties4;
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
            this.NumberTextBox.Size = new System.Drawing.Size(280, 33);
            this.NumberTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.NumberTextBox.TabIndex = 0;
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumberTextBox.TextMarginBottom = 0;
            this.NumberTextBox.TextMarginLeft = 3;
            this.NumberTextBox.TextMarginTop = 0;
            this.NumberTextBox.TextPlaceholder = "";
            this.NumberTextBox.UseSystemPasswordChar = false;
            this.NumberTextBox.WordWrap = true;
            this.NumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberTextBox_KeyDown);
            // 
            // ChangePhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(370, 215);
            this.Controls.Add(this.ChangePhoneLabel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.NumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePhoneNumber";
            this.Text = "ChangePhoneNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox NumberTextBox;
        private FontAwesome.Sharp.IconButton btnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel ChangePhoneLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChange;
    }
}