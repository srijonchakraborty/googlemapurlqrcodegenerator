using System;

namespace GoogleUrlAndQrCodeGeneratorLib
{
    public static class GoogleMapsUrlConstants
    {
        public const string GoogleMapBaseUrl = "https://www.google.com/maps/dir/?api=1";
        public const string OriginText = "&origin=";
        public const string DestinationText = "&destination=";
        public const string WayPointsText = "&waypoints=";

        public const string TravelModeDriving = "&travelmode=driving";
        public const string TravelModeWalking = "&travelmode=walking";
        public const string TravelModeBicycling = "&travelmode=bicycling";
        public const string TravelModeTransit = "&travelmode=transit";
    }
}
