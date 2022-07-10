using System;

namespace Bunifu_Browser
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuImageButton5 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtSearchOrUrl = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnHome = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.Controls.Add(this.bunifuImageButton5);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton6);
            this.bunifuCards1.Controls.Add(this.txtSearchOrUrl);
            this.bunifuCards1.Controls.Add(this.btnRefresh);
            this.bunifuCards1.Controls.Add(this.btnHome);
            this.bunifuCards1.Controls.Add(this.btnForward);
            this.bunifuCards1.Controls.Add(this.btnBack);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(809, 52);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.ActiveImage = null;
            this.bunifuImageButton5.AllowAnimations = true;
            this.bunifuImageButton5.AllowBuffering = false;
            this.bunifuImageButton5.AllowToggling = false;
            this.bunifuImageButton5.AllowZooming = true;
            this.bunifuImageButton5.AllowZoomingOnFocus = false;
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.ErrorImage")));
            this.bunifuImageButton5.FadeWhenInactive = false;
            this.bunifuImageButton5.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.ImageLocation = null;
            this.bunifuImageButton5.ImageMargin = 20;
            this.bunifuImageButton5.ImageSize = new System.Drawing.Size(18, 16);
            this.bunifuImageButton5.ImageZoomSize = new System.Drawing.Size(38, 36);
            this.bunifuImageButton5.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.InitialImage")));
            this.bunifuImageButton5.Location = new System.Drawing.Point(750, 7);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Rotation = 0;
            this.bunifuImageButton5.ShowActiveImage = true;
            this.bunifuImageButton5.ShowCursorChanges = true;
            this.bunifuImageButton5.ShowImageBorders = true;
            this.bunifuImageButton5.ShowSizeMarkers = false;
            this.bunifuImageButton5.Size = new System.Drawing.Size(38, 36);
            this.bunifuImageButton5.TabIndex = 7;
            this.bunifuImageButton5.ToolTipText = "configuration";
            this.bunifuImageButton5.WaitOnLoad = false;
            this.bunifuImageButton5.Zoom = 20;
            this.bunifuImageButton5.ZoomSpeed = 10;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.ActiveImage = null;
            this.bunifuImageButton6.AllowAnimations = true;
            this.bunifuImageButton6.AllowBuffering = false;
            this.bunifuImageButton6.AllowToggling = false;
            this.bunifuImageButton6.AllowZooming = true;
            this.bunifuImageButton6.AllowZoomingOnFocus = false;
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.ErrorImage")));
            this.bunifuImageButton6.FadeWhenInactive = false;
            this.bunifuImageButton6.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.ImageLocation = null;
            this.bunifuImageButton6.ImageMargin = 20;
            this.bunifuImageButton6.ImageSize = new System.Drawing.Size(18, 16);
            this.bunifuImageButton6.ImageZoomSize = new System.Drawing.Size(38, 36);
            this.bunifuImageButton6.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.InitialImage")));
            this.bunifuImageButton6.Location = new System.Drawing.Point(706, 7);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Rotation = 0;
            this.bunifuImageButton6.ShowActiveImage = true;
            this.bunifuImageButton6.ShowCursorChanges = true;
            this.bunifuImageButton6.ShowImageBorders = true;
            this.bunifuImageButton6.ShowSizeMarkers = false;
            this.bunifuImageButton6.Size = new System.Drawing.Size(38, 36);
            this.bunifuImageButton6.TabIndex = 6;
            this.bunifuImageButton6.ToolTipText = "downloads";
            this.bunifuImageButton6.WaitOnLoad = false;
            this.bunifuImageButton6.Zoom = 20;
            this.bunifuImageButton6.ZoomSpeed = 10;
            // 
            // txtSearchOrUrl
            // 
            this.txtSearchOrUrl.AcceptsReturn = false;
            this.txtSearchOrUrl.AcceptsTab = false;
            this.txtSearchOrUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchOrUrl.AnimationSpeed = 200;
            this.txtSearchOrUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchOrUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchOrUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchOrUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchOrUrl.BackgroundImage")));
            this.txtSearchOrUrl.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearchOrUrl.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearchOrUrl.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearchOrUrl.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearchOrUrl.BorderRadius = 30;
            this.txtSearchOrUrl.BorderThickness = 2;
            this.txtSearchOrUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchOrUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchOrUrl.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearchOrUrl.DefaultText = "";
            this.txtSearchOrUrl.FillColor = System.Drawing.Color.White;
            this.txtSearchOrUrl.HideSelection = true;
            this.txtSearchOrUrl.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchOrUrl.IconLeft")));
            this.txtSearchOrUrl.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchOrUrl.IconPadding = 10;
            this.txtSearchOrUrl.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchOrUrl.IconRight")));
            this.txtSearchOrUrl.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchOrUrl.Lines = new string[0];
            this.txtSearchOrUrl.Location = new System.Drawing.Point(179, 9);
            this.txtSearchOrUrl.MaxLength = 32767;
            this.txtSearchOrUrl.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchOrUrl.Modified = false;
            this.txtSearchOrUrl.Multiline = false;
            this.txtSearchOrUrl.Name = "txtSearchOrUrl";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchOrUrl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchOrUrl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchOrUrl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchOrUrl.OnIdleState = stateProperties4;
            this.txtSearchOrUrl.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearchOrUrl.PasswordChar = '\0';
            this.txtSearchOrUrl.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchOrUrl.PlaceholderText = "Enter URL";
            this.txtSearchOrUrl.ReadOnly = false;
            this.txtSearchOrUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchOrUrl.SelectedText = "";
            this.txtSearchOrUrl.SelectionLength = 0;
            this.txtSearchOrUrl.SelectionStart = 0;
            this.txtSearchOrUrl.ShortcutsEnabled = true;
            this.txtSearchOrUrl.Size = new System.Drawing.Size(521, 31);
            this.txtSearchOrUrl.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearchOrUrl.TabIndex = 5;
            this.txtSearchOrUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchOrUrl.TextMarginBottom = 0;
            this.txtSearchOrUrl.TextMarginLeft = 10;
            this.txtSearchOrUrl.TextMarginTop = 0;
            this.txtSearchOrUrl.TextPlaceholder = "Enter URL";
            this.txtSearchOrUrl.UseSystemPasswordChar = false;
            this.txtSearchOrUrl.WordWrap = true;
            this.txtSearchOrUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchOrUrl_KeyUp);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveImage = null;
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowBuffering = false;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.AllowZooming = true;
            this.btnRefresh.AllowZoomingOnFocus = false;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ErrorImage")));
            this.btnRefresh.FadeWhenInactive = false;
            this.btnRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.ImageLocation = null;
            this.btnRefresh.ImageMargin = 20;
            this.btnRefresh.ImageSize = new System.Drawing.Size(18, 16);
            this.btnRefresh.ImageZoomSize = new System.Drawing.Size(38, 36);
            this.btnRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.InitialImage")));
            this.btnRefresh.Location = new System.Drawing.Point(135, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Rotation = 0;
            this.btnRefresh.ShowActiveImage = true;
            this.btnRefresh.ShowCursorChanges = true;
            this.btnRefresh.ShowImageBorders = true;
            this.btnRefresh.ShowSizeMarkers = false;
            this.btnRefresh.Size = new System.Drawing.Size(38, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.ToolTipText = "refresh";
            this.btnRefresh.WaitOnLoad = false;
            this.btnRefresh.Zoom = 20;
            this.btnRefresh.ZoomSpeed = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.ActiveImage = null;
            this.btnHome.AllowAnimations = true;
            this.btnHome.AllowBuffering = false;
            this.btnHome.AllowToggling = false;
            this.btnHome.AllowZooming = true;
            this.btnHome.AllowZoomingOnFocus = false;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHome.ErrorImage")));
            this.btnHome.FadeWhenInactive = false;
            this.btnHome.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageActive = null;
            this.btnHome.ImageLocation = null;
            this.btnHome.ImageMargin = 20;
            this.btnHome.ImageSize = new System.Drawing.Size(18, 16);
            this.btnHome.ImageZoomSize = new System.Drawing.Size(38, 36);
            this.btnHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnHome.InitialImage")));
            this.btnHome.Location = new System.Drawing.Point(91, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Rotation = 0;
            this.btnHome.ShowActiveImage = true;
            this.btnHome.ShowCursorChanges = true;
            this.btnHome.ShowImageBorders = true;
            this.btnHome.ShowSizeMarkers = false;
            this.btnHome.Size = new System.Drawing.Size(38, 36);
            this.btnHome.TabIndex = 3;
            this.btnHome.ToolTipText = "home";
            this.btnHome.WaitOnLoad = false;
            this.btnHome.Zoom = 20;
            this.btnHome.ZoomSpeed = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.ActiveImage = null;
            this.btnForward.AllowAnimations = true;
            this.btnForward.AllowBuffering = false;
            this.btnForward.AllowToggling = false;
            this.btnForward.AllowZooming = true;
            this.btnForward.AllowZoomingOnFocus = false;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnForward.ErrorImage")));
            this.btnForward.FadeWhenInactive = false;
            this.btnForward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageActive = null;
            this.btnForward.ImageLocation = null;
            this.btnForward.ImageMargin = 20;
            this.btnForward.ImageSize = new System.Drawing.Size(18, 16);
            this.btnForward.ImageZoomSize = new System.Drawing.Size(38, 36);
            this.btnForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnForward.InitialImage")));
            this.btnForward.Location = new System.Drawing.Point(47, 7);
            this.btnForward.Name = "btnForward";
            this.btnForward.Rotation = 0;
            this.btnForward.ShowActiveImage = true;
            this.btnForward.ShowCursorChanges = true;
            this.btnForward.ShowImageBorders = true;
            this.btnForward.ShowSizeMarkers = false;
            this.btnForward.Size = new System.Drawing.Size(38, 36);
            this.btnForward.TabIndex = 2;
            this.btnForward.ToolTipText = "forward";
            this.btnForward.WaitOnLoad = false;
            this.btnForward.Zoom = 20;
            this.btnForward.ZoomSpeed = 10;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 20;
            this.btnBack.ImageSize = new System.Drawing.Size(18, 16);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(38, 36);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(3, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(38, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.ToolTipText = "back";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 20;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(2, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(796, 396);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "frmBrowser";
            this.Text = "frmBrowser";
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuImageButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton btnHome;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchOrUrl;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton5;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private EventHandler txtSearchOrUrl_TextChanged;
    }
}