using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Win32
{
    /// <summary>
    /// Логика взаимодействия для Autoriz.xaml
    /// </summary>
    public partial class Autoriz : Window
    {
        public Autoriz()
        {
            InitializeComponent();
            OpenPage(pages.loginpage);
        }
        public enum pages
        {
            loginpage,
            reginpage,
            rolepage,
            PadesBut
        }
        internal void OpenPage(pages pages)
        {
            if (pages == pages.loginpage)
            {
                frames.Navigate(new loginpage(this));
            }
            else if (pages == pages.reginpage)
                frames.Navigate(new reginpage(this));
        }

        static public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-NDOBE5PK; Trusted_Connection=Yes; DataBase=Win32Project;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        private void frames_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
