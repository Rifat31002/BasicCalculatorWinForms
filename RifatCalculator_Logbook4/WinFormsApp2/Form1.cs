namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Double result = 0;      // the result will update here 
        String operation = " ";     // button variable for operator . 
        bool isOpPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)  // assigning all number buttons in one name 
        {
            if ((textBox1.Text == "0") || (isOpPerformed))  // the text box will be clear if there is 0 and no operation is taking place 
                textBox1.Clear();
            isOpPerformed = false ;
            Button btn = (Button) sender;   
            if (btn.Text == ".")  // if there is already a dot in the textbox 
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + btn.Text;           
            }else
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";        // if the cE button is pressed the textbox will place 0
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // assigning the button value to current property 
            operation = btn.Text;
            result = Double.Parse(textBox1.Text); // redult parsing to double type into textbox 
            isOpPerformed = true;      // operator event is true 
        }

        private void c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0; // clears the display if cutton C is clicked
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch(operation)
                {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();   // addition operation 
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();  // subtruction operation
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();  // mulitiplicaiton operation
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString(); // divition operation 
                    break;
                default:
                    break;
                 }


            }
        }
}