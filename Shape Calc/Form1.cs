namespace Shape_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Shape2d shape = null;
            double length = -1, width = -1, depth = -1;

            if (!double.TryParse(txt_length.Text, out length) || !double.TryParse(txt_width.Text, out width))
            {
                lbl_result.Text = "Result: Error";
                return;
            }

            if(cmb_Shape.SelectedIndex >= 3 && !double.TryParse(txt_depth.Text, out depth))
            {
                lbl_result.Text = "Result: Error";
                return;
            }

            switch (cmb_Shape.SelectedIndex)
            {
                case 0:
                    shape = new Rectangle(length, width);
                    break;
                case 1:
                    shape = new Triangle(length, width);
                    break;
                case 2:
                    shape = new Ellipse(length, width);
                    break;
                case 3:
                    shape = new Cuboid(length, width, depth);
                    break;
                case 4:
                    shape = new Triangular_Prism(length, width, depth);
                    break;
                case 5:
                    shape = new Ellipsoid(length, width, depth);
                    break;
                default:
                    lbl_result.Text = "Result: Error";
                    return;
            }

            IHasArea hasArea = shape as IHasArea;
            IHasVolume hasVolume = shape as IHasVolume;
            if (hasArea != null)
            {
                lbl_result.Text = "Result: Area = " + hasArea.Area();
            }
            if (hasVolume != null)
            {
                lbl_result.Text = "Result: Volume = " + hasVolume.Volume();
            }

        }

        private void cmb_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_length.Clear();
            txt_width.Clear();
            txt_depth.Clear();
            txt_depth.Enabled = cmb_Shape.SelectedIndex >= 3;

        }
    }
}