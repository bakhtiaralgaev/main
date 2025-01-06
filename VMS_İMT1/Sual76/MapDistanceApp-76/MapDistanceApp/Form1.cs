using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MapDistanceApp
{
    public partial class Form1 : Form
    {
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        PointLatLng? point1 = null;
        PointLatLng? point2 = null;
        public Form1()
        {
            InitializeComponent();
            InitializeMap();
        }
        private void InitializeMap()
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(40.4093, 49.8671); // Bakı koordinatları
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 10;
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;

            // Maus klik hadisəsini əlavə edirik
            gMapControl1.MouseClick += new MouseEventHandler(Map_MouseClick);
        }
        // Maus klik hadisəsi
        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                if (point1 == null)
                {
                    point1 = point;
                    lblInfo.Text = $"Nöqtə 1: {point.Lat:F5}, {point.Lng:F5}";
                    AddMarker(point1.Value, GMarkerGoogleType.red_dot);
                }
                else if (point2 == null)
                {
                    point2 = point;
                    lblInfo.Text += $"\nNöqtə 2: {point.Lat:F5}, {point.Lng:F5}";
                    AddMarker(point2.Value, GMarkerGoogleType.green_dot);
                }
                else
                {
                    // İki nöqtə seçiləndən sonra sıfırlayırıq
                    point1 = point;
                    point2 = null;
                    markersOverlay.Markers.Clear();
                    lblInfo.Text = $"Nöqtə 1: {point.Lat:F5}, {point.Lng:F5}";
                    AddMarker(point1.Value, GMarkerGoogleType.red_dot);
                }
            }
        }
        private double CalculateDistance(PointLatLng point1, PointLatLng point2)
        {
            const double R = 6371; // Yerin radiusu (km)
            double lat1 = point1.Lat * (Math.PI / 180);
            double lat2 = point2.Lat * (Math.PI / 180);
            double deltaLat = (point2.Lat - point1.Lat) * (Math.PI / 180);
            double deltaLon = (point2.Lng - point1.Lng) * (Math.PI / 180);

            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c; // Mesafe km olaraq qaytarılır
        }
        // Marker əlavə edən funksiya
        private void AddMarker(PointLatLng point, GMarkerGoogleType markerType)
        {
            GMarkerGoogle marker = new GMarkerGoogle(point, markerType);
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Clear();
            gMapControl1.Overlays.Add(markersOverlay);
        }
        // Məsafəni hesablamaq
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (point1 != null && point2 != null)
            {
                double distance = CalculateDistance(point1.Value, point2.Value);
                lblDistance.Text = $"Məsafə: {distance:F2} km";
            }
            else
            {
                MessageBox.Show("İki nöqtə seçilməlidir!");
            }
        }
        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}