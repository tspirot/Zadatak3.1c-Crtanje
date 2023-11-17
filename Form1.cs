namespace Zadatak3._1c
{
    public partial class Form1 : Form
    {
        int px, py;
        Graphics gr;
        Pen olovka = new Pen(Color.Black, 1);
        public Form1()
        {
            //gr = pictureBox1.CreateGraphics();
            InitializeComponent();
            gr = pictureBox1.CreateGraphics();
        }

        private void pictureBoxBoja_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                olovka.Color = pictureBoxBoja.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                px = e.X;
                py = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int minX, minY, dx, dy;
            minX = Math.Min(px, e.X);
            minY = Math.Min(py, e.Y);
            dx = Math.Abs(px - e.X);
            dy = Math.Abs(py - e.Y);
            if (e.Button == MouseButtons.Left)
            {
                if (radioButtonLinija.Checked)
                    gr.DrawLine(olovka, px, py, e.X, e.Y);
                if (radioButtonPravougaonik.Checked)
                    gr.DrawRectangle(olovka, minX, minY, dx, dy);
                if (radioButtonElipsa.Checked)
                    gr.DrawEllipse(olovka, minX, minY, dx, dy);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                olovka.Width = 
                    int.Parse(listBox1.SelectedItem.ToString());
        }
    }
}
