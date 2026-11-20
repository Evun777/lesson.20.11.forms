namespace lesson._20._11.forms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            //спеціальне вікно де можна обрати файл
            OpenFileDialog myDialog = new OpenFileDialog();
            //для відображення вікна використовується метод
            //ShowDialog() ш умовний оператор if
            //DialogResult.OK - це якщо користувач обрав файл на ПК
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = myDialog.FileName;
                //шлях до файлу вписуємо у текстове поле
                txtFilePath.Text = FilePath;
                //MessageBox.Show("Ви обрали файл: " + filePath)
            }
        }
    }
}
