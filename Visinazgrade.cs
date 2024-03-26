namespace Visina_Zgrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            // kreiramo objekt
            Neboder neboder = new Neboder();
            // upisane vrijednosti u textBox-u 1 pretvaramo u int
            neboder.BrojKatova = Convert.ToInt32(textBox1.Text);
            // pozivamo "funkciju" IzracunajVisinu i upisujemo ju u TextBox2
            textBox2.Text = neboder.IzracunajVisinu(neboder.BrojKatova).ToString();

        }
    }
}
