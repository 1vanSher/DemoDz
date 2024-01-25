namespace DemoDz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graf1();
        }

        private void Graf1()
        {
            double a = -5, b = 5, h = 1, x, y, x2, y2;
            chart1.Series[0].Points.Clear();
            x = a;
            x2 = a;
            while (x2 <= b)
            {
                y = Math.Round(Math.Sin(x), 3);
                y2 = Math.Round(Math.Pow(x2, 2), 3);

                chart1.Series[0].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x2, y2);

                if (x == x2 && y == y2)
                {
                    label1.Text += $"Точка пересечения: {x }, {y } {Environment.NewLine}";
                }

                x += h;
                x2 += h;
                
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
