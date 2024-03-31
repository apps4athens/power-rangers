using Domain;

namespace GUI
{
    public partial class Form1 : Form
    {
        private readonly BinCollection _binCollection;
        public Form1(BinCollection binCollection)
        {
            _binCollection = binCollection;
            InitializeComponent();
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            txtWeightA.Text = _binCollection.BinList[0].Weight.ToString();
            txtvolumeA.Text = _binCollection.BinList[0].Volume.ToString();
            txtweightB.Text = _binCollection.BinList[1].Weight.ToString();
            txtvolumeB.Text = _binCollection.BinList[1].Volume.ToString();
            txtweightC.Text = _binCollection.BinList[2].Weight.ToString();
            txtvolumeC.Text = _binCollection.BinList[2].Volume.ToString();
            txtweightD.Text = _binCollection.BinList[3].Weight.ToString();
            txtvolumeD.Text = _binCollection.BinList[3].Volume.ToString();
            txtweightE.Text = _binCollection.BinList[4].Weight.ToString();
            txtvolumeE.Text = _binCollection.BinList[4].Volume.ToString();
            txtweightF.Text = _binCollection.BinList[5].Weight.ToString();
            txtvolumeF.Text = _binCollection.BinList[5].Volume.ToString();
        }

        private void txtWeightA_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtWeightA.Text, out int newValue))
            {
                _binCollection.BinList[0].Weight = newValue;
            }
        }

        private void txtweightB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtweightB.Text, out int newValue))
            {
                _binCollection.BinList[1].Weight = newValue;
            }
        }

        private void txtweightC_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtweightC.Text, out int newValue))
            {
                _binCollection.BinList[2].Weight = newValue;
            }
        }

        private void txtweightD_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtweightD.Text, out int newValue))
            {
                _binCollection.BinList[3].Weight = newValue;
            }
        }



        private void Start_Click(object sender, EventArgs e)
        {
            var binsToPickup = _binCollection.GetBinsToPickUp();
            var collectorsNum = (int)numericUpDown1.Value;
            txtresult.Text = "";
            var perCollector = binsToPickup.Count / collectorsNum;
            for (int i = 0; i < collectorsNum; i++)
            {
                var values = (i == collectorsNum - 1) ?
                    binsToPickup.Skip(i * perCollector) : binsToPickup.Skip(i * perCollector).Take(perCollector);

                txtresult.Text += $"Bins that need pickup for vehicle {i + 1} => {string.Join(", ", values.Select(b => b.Id))}";
                txtresult.Text += Environment.NewLine;
            }

            txtresult.Visible = true;
            txtHint.Visible = true;
            pictureBox1.Visible = true;
            var web = new WebBrowser();
            web.Navigate(new Uri("http://www.google.com"));
        }


        private void txtweightE_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtweightE.Text, out int newValue))
            {
                _binCollection.BinList[4].Weight = newValue;
            }
        }

        private void txtweightF_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtweightF.Text, out int newValue))
            {
                _binCollection.BinList[5].Weight = newValue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtvolumeE_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtvolumeE.Text, out int newValue))
            {
                _binCollection.BinList[4].Volume = newValue;
            }
        }

        private void txtvolumeA_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtvolumeA.Text, out int newValue))
            {
                _binCollection.BinList[0].Volume = newValue;
            }
        }

        private void txtvolumeB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtvolumeB.Text, out int newValue))
            {
                _binCollection.BinList[1].Volume = newValue;
            }
        }

        private void txtvolumeC_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtvolumeC.Text, out int newValue))
            {
                _binCollection.BinList[2].Volume = newValue;
            }
        }

        private void txtvolumeF_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtvolumeF.Text, out int newValue))
            {
                _binCollection.BinList[5].Volume = newValue;
            }
        }

        private void txtvolumeD_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtvolumeD.Text, out int newValue))
            {
                _binCollection.BinList[3].Volume = newValue;
            }
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

