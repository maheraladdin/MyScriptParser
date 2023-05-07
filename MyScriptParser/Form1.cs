using com.calitha.goldparser;

namespace MyScriptParser
{
    public partial class Form1 : Form
    {

        MyParser Parser;

        public Form1()
        {
            InitializeComponent();
            Parser = new MyParser("myScript.cgt", RTBResult);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RTBResult.Text = "";
            Parser.Parse(MyScriptInput.Text);
        }
    }
}