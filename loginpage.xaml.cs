using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace Win32
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class loginpage : Page
    {
        public Autoriz autor;

        string connectionString;

        public loginpage(Autoriz _autor)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
            autor = _autor;
        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void regin_Click(object sender, RoutedEventArgs e)
        {
            autor.OpenPage(Autoriz.pages.reginpage);
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");
            connection.Open();
            {
                if (login.Text.Length > 0) // проверяем введён ли логин     
                {
                    if (password.Password.Length > 0) // проверяем введён ли пароль         
                    {             // ищем в базе данных пользователя с такими данными         

                        DataTable dt_user = Autoriz.Select("SELECT * FROM [dbo].[Users] WHERE [login] = '" + login.Text + "' AND [password] = '" + password.Password + "'");
                        if (dt_user.Rows.Count > 0) // если такая запись существует       
                        {
                            MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался  

                            GetRole();
                        }
                        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                    }
                    else MessageBox.Show("Введите пароль"); // выводим ошибку    
                }
                else MessageBox.Show("Введите логин"); // выводим ошибку


            }
        }


        public void GetRole()
        {

            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");
            connection.Open();
            AdminWindow a = new AdminWindow();
            Autoriz a1 = new Autoriz();
            MainWindow main = new MainWindow();

            DataTable dt_users = Autoriz.Select("SELECT * FROM Users WHERE role = 'Админ'");
            if (dt_users.Rows.Count > 0) // если такая запись существует       
            {
                a1.Close();
                a.Show();
                main.Close();


            }
       
            //DataTable dt_user1 = Autoriz.Select("SELECT * FROM Users WHERE role='Юзер'");
            //if (dt_user1.Rows.Count>0)
            //{
            //    a1.Close();
            //    main.Show();
            //    a.Close();
            //}
        }
    }
}





