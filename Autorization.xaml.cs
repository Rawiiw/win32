using System.Windows;
using System.Windows.Controls;
using System.Data.Sql;
using System.Data.SqlClient;
using System;

namespace Win32
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string connString = @"Data Source = LAPTOP-NDOBE5PK; Initial Catalog = Win32Project; Integrated Security = True;";
        private bool LoginButtonIsWorking = true;
        private int LoginAttempts = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            return sqlConnection;
        }
        

        
       
    }
}

