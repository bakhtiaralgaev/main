using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Sual97
{
    public partial class Form1 : Form
    {
        GMap.NET.WindowsForms.GMapControl gmap1;
        public Form1()
        {
            InitializeComponent();
            gmap1 = new GMap.NET.WindowsForms.GMapControl();
            gmap1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            gmap1.Dock = DockStyle.Fill;
            gmap1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap1.ShowCenter = false;
            gmap1.MinZoom = 1;
            gmap1.MaxZoom = 100;
            splitContainer1.Panel2.Controls.Add(gmap1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmap1.MapProvider = GMapProviders.GoogleMap;
            gmap1.MinZoom = 1;
            gmap1.MaxZoom = 100;
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            gmap1.MapProvider = GMapProviders.GoogleMap;
            gmap1.Position = new PointLatLng(40.4621702, 50.0476047);
            gmap1.MinZoom = 1;
            gmap1.MaxZoom = 100;
            gmap1.Zoom = 15;
        }
    }
}
