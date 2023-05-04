namespace LAB4._2
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();

            model = new Model();
            model.observers += new System.EventHandler(this.updateFromModel);
        }

        private void updateFromModel(object sender, EventArgs e)
        {
            textBoxA.Text = model.getA().ToString();
            numericUpDownA.Value = model.getA();
            trackBarA.Value = model.getA();

            textBoxB.Text = model.getB().ToString();
            numericUpDownB.Value = model.getB();
            trackBarB.Value = model.getB();

            textBoxC.Text = model.getC().ToString();
            numericUpDownC.Value = model.getC();
            trackBarC.Value = model.getC();
        }



        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(trackBarA.Value));
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(trackBarB.Value));
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(trackBarC.Value));
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setA(Int32.Parse(textBoxA.Text));
            }
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setB(Int32.Parse(textBoxB.Text));
            }
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setC(Int32.Parse(textBoxC.Text));
            }
        }
    }

    public class Model
    {
        private int a;
        private int b;
        private int c;

        public System.EventHandler observers;

        public void setA(int a)
        {
            this.a = a;
            observers.Invoke(this, null);
        }

        public void setB(int b) 
        { 
            this.b = b;
            observers.Invoke(this, null);
        }

        public void setC(int c)
        {
            this.c = c;
            observers.Invoke(this, null);
        }

        public int getA()
        {
            return this.a;
        }

        public int getB()
        {
            return this.b;
        }

        public int getC()
        {
            return this.c;
        }
    }
}