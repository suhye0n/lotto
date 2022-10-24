namespace Week07WinFormsLotto
{
    public partial class back : Form
    {
        public back()
        {
            InitializeComponent();
        }

        private void OnGenerate(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] num = new int[6];

            for (int i = 0; i < num.Length; i++)
                num[i] = r.Next(1, 46);

            Array.Sort(num);

            Num1.Text = $"{num[0]}";
            Num2.Text = $"{num[1]}";
            Num3.Text = $"{num[2]}";
            Num4.Text = $"{num[3]}";
            Num5.Text = $"{num[4]}";
            Num6.Text = $"{num[5]}";
        }
    }
}