using GoogleUrlAndQrCodeGeneratorLib;
using System;
using System.Security.Policy;

namespace GoogleMapUrlQrCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DefaultValueSetUp();
        }

        private void GenereateQRCode(string content)
        {
            var bitmap = QrCodeGenerator.CreateQRCode(content, 275, 275, 0);
            var file = QrCodeGenerator.ConvertToBytesArray(bitmap);
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(file));
            this.pictureBoxQrCode.Image = x;
        }

        private void DefaultValueSetUp()
        {
            this.textBoxOrigin.Text = "24.581693,90.396002";
            this.textBoxDestination.Text = "24.844479,90.259587";
            List<string> list = new List<string>()
            {
                "24.738634,90.382406",
                "24.762486,90.403878",
            };
            this.richTextBoxWayPoints.Text = string.Join(Environment.NewLine, list);
        }

        private string GenerateUrl(string travelMode)
        {

            string url = "";
            if (!string.IsNullOrWhiteSpace(this.textBoxOrigin.Text)
                && !string.IsNullOrWhiteSpace(this.textBoxDestination.Text)
                && !string.IsNullOrWhiteSpace(this.richTextBoxWayPoints.Text))
            {
                string orginlatlong = this.textBoxOrigin.Text ?? string.Empty;
                string destinationlatlong = this.textBoxDestination.Text ?? string.Empty;
                var waypoints = this.richTextBoxWayPoints.Text.Split("\n").ToList();
                string waypointsLatlong = string.Join("|", waypoints);

                url = $@"{GoogleMapsUrlConstants.GoogleMapBaseUrl}{GoogleMapsUrlConstants.OriginText}{orginlatlong}{GoogleMapsUrlConstants.DestinationText}{destinationlatlong}{travelMode}{GoogleMapsUrlConstants.WayPointsText}{waypointsLatlong}";
            }
            else if (!string.IsNullOrWhiteSpace(this.textBoxOrigin.Text)
                     && !string.IsNullOrWhiteSpace(this.textBoxDestination.Text)
                     && string.IsNullOrWhiteSpace(this.richTextBoxWayPoints.Text))
            {
                string orginlatlong = this.textBoxOrigin.Text ?? string.Empty;
                string destinationlatlong = this.textBoxDestination.Text ?? string.Empty;

                url = $@"{GoogleMapsUrlConstants.GoogleMapBaseUrl}{GoogleMapsUrlConstants.OriginText}{orginlatlong}{GoogleMapsUrlConstants.DestinationText}{destinationlatlong}{travelMode}";
            }
            else if (!string.IsNullOrWhiteSpace(this.textBoxOrigin.Text)
                    && string.IsNullOrWhiteSpace(this.textBoxDestination.Text)
                    && string.IsNullOrWhiteSpace(this.richTextBoxWayPoints.Text))
            {
                string orginlatlong = this.textBoxOrigin.Text ?? string.Empty;
                string destinationlatlong = this.textBoxOrigin.Text ?? string.Empty;

                url = $@"{GoogleMapsUrlConstants.GoogleMapBaseUrl}{GoogleMapsUrlConstants.OriginText}{orginlatlong}{GoogleMapsUrlConstants.DestinationText}{destinationlatlong}{travelMode}";
            }

            //You can add your conditions

            return url;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string url = GenerateUrl(GoogleMapsUrlConstants.TravelModeDriving);
                this.textBoxFinalUrl.Text = url;
                GenereateQRCode(url);
                webView21.Source = new Uri(url);
                webView21.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
