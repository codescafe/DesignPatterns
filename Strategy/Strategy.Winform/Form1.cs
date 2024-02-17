using Strategy.Common;

namespace Strategy.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0d;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "正常收费", "满300返100", "打8折" });
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cashSuper = new CashContext(comboBox1.SelectedItem.ToString());
            double totalPrices = cashSuper.GetResult(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
            total += totalPrices;
            listBox1.Items.Add("单价：" + textBox1.Text + " 数量：" + textBox2.Text + " " + comboBox1.SelectedItem + " 合计：" + totalPrices);
            label4.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total = 0d;
            listBox1.Items.Clear();
            label4.Text = total.ToString();
        }
    }
}
