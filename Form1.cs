namespace Rummikub_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = " " + TrackBarWaarde();
            TrackBarChanged();
            UpdateTrackBarWaarde();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        public int TrackBarWaarde()
        {
            int aantalTrackbar = trackBar1.Value;

            return aantalTrackbar;
        }

        


        private void UpdateTrackBarWaarde()
        {
            int aantalTrackbar = trackBar1.Value;
        }

        private void TrackBarChanged()
        {
            if (trackBar1.Value < trackBar1.Maximum)
            {
                trackBar1.Value++;
            }
            if (trackBar1.Value > trackBar1.Minimum)
            {
                trackBar1.Value--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.ResetText();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }
    }
}