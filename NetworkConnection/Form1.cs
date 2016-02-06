using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;

namespace NetworkConnection
{
    public partial class Form1 : Form
    {
        protected NetworkInterface[] nics = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
        protected List<String> names;
        protected List<long> values;
        protected int num = 0;
        protected int index = 0;

        protected PointPairList list = new PointPairList();
       
        public Form1()
        {
            InitializeComponent();
            names = new List<string>();
            values = new List<long>();

            foreach(NetworkInterface n in nics){
                comboBox1.Items.Add(n.Name);
            }

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmTime.Enabled = false;
            tmTime.Stop();

            ComboBox cb = (ComboBox)sender;
            index = cb.SelectedIndex;
            num = 0;
            list.Clear();

            tmTime.Enabled = true;
            tmTime.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmTime.Start();
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {

            // Get a reference to the GraphPane instance in the ZedGraphControl
            GraphPane myPane = zg1.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "Graph of connections speed";
            myPane.XAxis.Title.Text = "Seconds [S]";
            myPane.YAxis.Title.Text = "Speed Bytes [B]";
            myPane.Legend.IsVisible = false;

            // Add gridlines to the plot, and make them gray
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.Color = Color.LightGray;
            myPane.YAxis.MajorGrid.Color = Color.LightGray;

            if(tmTime.Enabled){
                
                //lblPisi.Text = nics[0].Name + "[ " + nics[0].GetIPv4Statistics().BytesReceived + " ]";

                num++;

                double x = (double)num;
                double y = (double)nics[0].GetIPv4Statistics().BytesReceived;
                
                list.Add(x,y);

            }
            
            // Generate a red curve with diamond symbols, and "Alpha" in the legend
            LineItem myCurve = myPane.AddCurve(comboBox1.SelectedText, list, Color.Red, SymbolType.Circle);
            
            // Fill the symbols with white
            myCurve.Symbol.Fill = new Fill(Color.White);

            //fill the area
            myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);

            // Fill the axis background with a gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            myPane.YAxis.MajorGrid.IsZeroLine = false;
            // Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside;

            // Enable scrollbars if needed
            zg1.IsShowHScrollBar = true;
            zg1.IsShowVScrollBar = true;
            zg1.IsAutoScrollRange = true;
            zg1.IsScrollY2 = true;

            zg1.AxisChange();
            // Make sure the Graph gets redrawn
            zg1.Invalidate();
            
        }
    }
}
