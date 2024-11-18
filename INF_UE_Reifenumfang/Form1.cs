namespace INF_UE_Reifenumfang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 75; i >= 35; i-=5)
            {
                cbThick.Items.Add(i);
            }

            for (int i = 11; i <= 20; i++)
            {
                cbSize.Items.Add(i);
            }


        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            double width = Convert.ToInt32(tbWidth.Text);
            width = width / 10;    

            double thick = Convert.ToInt32(cbThick.Text);
            thick = thick / 100; 

            double size = Convert.ToDouble(cbSize.Text) * 2.54;


            //2*r*pi 
            double height = width * thick*2;
            height += size;
            height = Math.Round(height * Math.PI, 4); 
            

            lblResult.Text = height.ToString(); 


        }
    }
}
