using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp1
{
    public partial class AktienForm : Form
    {
        public AktienForm()
        {
            InitializeComponent();
            AktieSelec.Items.AddRange(Firma);
        }


        List<Aktie> Aktiendaten;
        private static string[] Firma = new string[] { "AAPL", "MSFT", "GOOGL" };

        private void Form1_Load(object sender, EventArgs e)
        {
            Aktiendaten = new List<Aktie>();
            foreach (string firma in Firma)
                Aktiendaten.Add(new Aktie(firma));

        }

        private void AktieSelec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            SortedDictionary<DateOnly, decimal> AktienWerte = Aktiendaten[AktieSelec.SelectedIndex].data;
            Aktienchart.Series.Clear();
            Aktienchart.Series.Add("Aktienkurs");
            Series Reihe = Aktienchart.Series["Aktienkurs"];
            Reihe.ChartType = SeriesChartType.Line;
            foreach (KeyValuePair<DateOnly, decimal> point in AktienWerte)
                Reihe.Points.AddXY(i -= 1, point.Value);
        }
    }
}