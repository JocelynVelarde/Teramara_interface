using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace LogIn
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        protected override void OnMenuStart(EventArgs e)
        {
            //METODO QUE REVISA SI EL ARCHIVO DE LA BASE DE DATOS EXISTE Y SI NO EXISTE SE CREA TODO EL SCHEMA
            DatabaseFacade facade = new DatabaseFacade(new UserDataContext());
            facade.EnsureCreated();

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BtonLogin_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

       

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.White;
           
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.LightGray;
            textBox1.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = System.Drawing.Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.LightGray;
            textBox1.ForeColor = System.Drawing.Color.Black;
        }
    }
}