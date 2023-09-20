using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace Win32
{
    /// <summary>
    /// Логика взаимодействия для Tables.xaml
    /// </summary>
    public partial class Tables : UserControl
    {
        private DataTable dt;

        public Tables()
        {
            InitializeComponent();
        }



        private void UsersT()
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");

            connection.Open();
            string cmd = "SELECT * FROM Users"; // Из какой таблицы нужен вывод 
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Users"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            InfoGrid.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();

        }
        private void ProccesorT()
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");

            connection.Open();
            string cmd = "SELECT * FROM ProccesorTab"; // Из какой таблицы нужен вывод 
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("ProccesorTab"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            InfoGrid.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();

        }
        private void MemoryT()
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");

            connection.Open();
            string cmd = "SELECT * FROM MemoryTab"; // Из какой таблицы нужен вывод 
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("MemoryTab"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            InfoGrid.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();

        }
        private void KeyboardT()
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");

            connection.Open();
            string cmd = "SELECT * FROM KeyboardTab"; // Из какой таблицы нужен вывод 
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("KeyboardTab"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            InfoGrid.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();

        }
        private void MotherboardT()
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");

            connection.Open();
            string cmd = "SELECT * FROM MotherdTab"; // Из какой таблицы нужен вывод 
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("MotherTab"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            InfoGrid.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();

        }
        private void NetworkT()
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");

            connection.Open();
            string cmd = "SELECT * FROM NetworkTab"; // Из какой таблицы нужен вывод 
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("NetworkTab"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            InfoGrid.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();

        }
        private void MonitorT()
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");

            connection.Open();
            string cmd = "SELECT * FROM MonitorTab"; // Из какой таблицы нужен вывод 
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("MonitorTab"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            InfoGrid.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();

        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            UsersT();
        }

        private void Proccesor_Click(object sender, RoutedEventArgs e)
        {
            ProccesorT();
        }

        private void Keyboard_Click(object sender, RoutedEventArgs e)
        {
            KeyboardT();
        }

        private void Monitor_Click(object sender, RoutedEventArgs e)
        {
            MonitorT();
        }

        private void Memory_Click(object sender, RoutedEventArgs e)
        {
            MemoryT();
        }

        private void Network_Click(object sender, RoutedEventArgs e)
        {
            NetworkT();
        }

        private void Motherboard_Click(object sender, RoutedEventArgs e)
        {
            MotherboardT();
        }

        private void upd_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");
            string table = Users.Content.ToString().ToLower();
            dt = new DataTable(table);
            connection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {Users}", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Update(dt);

            InfoGrid.ItemsSource = dt.DefaultView;
        }

        private void InfoGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackTo_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow w = new AdminWindow();
            w.Close();
            MainWindow w1 = new MainWindow();
            w1.Show();

        }

        //    private async System.Threading.Tasks.Task delet_ClickAsync(object sender, RoutedEventArgs e)
        //    {
        //        SqlConnection connection = new SqlConnection("server = LAPTOP-NDOBE5PK; Trusted_Connection = Yes; DataBase = Win32Project;");
        //        connection.Open();

        //        if (us == null)
        //            return;
        //        try
        //        {
        //            using (var cmd = connection.CreateCommand())
        //            {
        //                cmd.CommandText = "DELETE FROM Users WHERE UserID = @UserId";

        //                await connection.OpenAsync();
        //                var deleted = await cmd.ExecuteNonQueryAsync();
        //                Trace.WriteLine($"Удалено {deleted}");
        //            }
        //            us.Remove(us);
        //        }
        //        catch (Exception ex)
        //        {
        //            Trace.WriteLine(ex.Message);
        //        }
        //    }
    }
}
