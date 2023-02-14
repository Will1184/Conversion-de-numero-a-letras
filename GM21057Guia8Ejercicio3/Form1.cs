namespace GM21057Guia8Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Numero n=new Numero();
            Numero numero=new Numero(textBoxIngreseNum.Text);
            n.LetrasNum(numero,textMostrarNum);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textMostrarNum.Clear();
            textBoxIngreseNum.Clear();
        }
    }
}