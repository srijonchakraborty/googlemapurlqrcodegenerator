namespace GoogleMapUrlQrCodeGenerator
{
    partial class Form1
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
            pictureBoxQrCode = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBoxOrigin = new TextBox();
            textBoxDestination = new TextBox();
            richTextBoxWayPoints = new RichTextBox();
            textBoxFinalUrl = new TextBox();
            OrginLatLong = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGenerate = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQrCode
            // 
            pictureBoxQrCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxQrCode.Location = new Point(11, 431);
            pictureBoxQrCode.Name = "pictureBoxQrCode";
            pictureBoxQrCode.Size = new Size(275, 275);
            pictureBoxQrCode.TabIndex = 0;
            pictureBoxQrCode.TabStop = false;
            // 
            // textBoxOrigin
            // 
            textBoxOrigin.Location = new Point(8, 25);
            textBoxOrigin.Name = "textBoxOrigin";
            textBoxOrigin.Size = new Size(278, 23);
            textBoxOrigin.TabIndex = 1;
            // 
            // textBoxDestination
            // 
            textBoxDestination.Location = new Point(8, 79);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(278, 23);
            textBoxDestination.TabIndex = 2;
            // 
            // richTextBoxWayPoints
            // 
            richTextBoxWayPoints.Location = new Point(10, 127);
            richTextBoxWayPoints.Name = "richTextBoxWayPoints";
            richTextBoxWayPoints.Size = new Size(275, 298);
            richTextBoxWayPoints.TabIndex = 3;
            richTextBoxWayPoints.Text = "";
            // 
            // textBoxFinalUrl
            // 
            textBoxFinalUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFinalUrl.Location = new Point(313, 50);
            textBoxFinalUrl.Name = "textBoxFinalUrl";
            textBoxFinalUrl.Size = new Size(1057, 23);
            textBoxFinalUrl.TabIndex = 4;
            // 
            // OrginLatLong
            // 
            OrginLatLong.AutoSize = true;
            OrginLatLong.Location = new Point(9, 4);
            OrginLatLong.Name = "OrginLatLong";
            OrginLatLong.Size = new Size(86, 15);
            OrginLatLong.TabIndex = 5;
            OrginLatLong.Text = "Orgin Lat Long";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 58);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 6;
            label1.Text = "Destination Lat Long";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "Way Points";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 29);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Final Url";
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.Location = new Point(1163, 12);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(207, 23);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(313, 87);
            webView21.Name = "webView21";
            webView21.Size = new Size(1057, 615);
            webView21.TabIndex = 10;
            webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 714);
            Controls.Add(webView21);
            Controls.Add(btnGenerate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OrginLatLong);
            Controls.Add(textBoxFinalUrl);
            Controls.Add(richTextBoxWayPoints);
            Controls.Add(textBoxDestination);
            Controls.Add(textBoxOrigin);
            Controls.Add(pictureBoxQrCode);
            MaximizeBox = false;
            Name = "Form1";
            Text = "GoogleMapUrl";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxQrCode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxOrigin;
        private TextBox textBoxDestination;
        private RichTextBox richTextBoxWayPoints;
        private TextBox textBoxFinalUrl;
        private Label OrginLatLong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGenerate;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
