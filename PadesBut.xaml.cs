using System.Collections.Generic;
using System.Data.SqlClient;
using System.Management;
using System.Windows;
using System.Windows.Controls;

namespace Win32
{
    /// <summary>
    /// Логика взаимодействия для PadesBut.xaml
    /// </summary>
    public partial class PadesBut : UserControl
    {
        public PadesBut()
        {
            InitializeComponent();


        }


        private void NetworkBut_Click(object sender, RoutedEventArgs e)
        {
            NetworkInfo();
        }

        private void ProccesorBut_Click(object sender, RoutedEventArgs e)
        {

            ProcessorInfo();


        }

        private void MemoryBut_Click(object sender, RoutedEventArgs e)
        {
            MemoryInfo();
        }

        private void KeybBut_Click(object sender, RoutedEventArgs e)
        {
            KeyboardInfo();
        }

        private void MotherBut_Click(object sender, RoutedEventArgs e)
        {
            MotherboardInfo();
        }

        private void MonitorBut_Click(object sender, RoutedEventArgs e)
        {
            MonitorInfo();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            InfoList.Items.Clear();
        }



        private void ProcessorInfo()
        {
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-NDOBE5PK; Trusted_Connection=Yes; DataBase=Win32Project;");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            Dictionary<object, object> myPropertyResults = new Dictionary<object, object>();
            ManagementClass myManagementClass = new ManagementClass("Win32_Processor");
            ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
            PropertyDataCollection myProperties = myManagementClass.Properties;
            foreach (var obj in myManagementCollection)
            {
                foreach (var myProperty in myProperties)
                {
                    bool keyExists = myPropertyResults.ContainsKey(myProperty.Name);
                    if (keyExists == false)
                    {
                        myPropertyResults.Add(myProperty.Name,
                       obj.Properties[myProperty.Name].Value);
                    }

                    else
                    {
                        myPropertyResults[Name] = obj.Properties[myProperty.Name].Value;
                    }

                }

                foreach (var myPropertyResult in myPropertyResults)
                {

                    InfoList.Items.Add(myPropertyResult.Key + ":" + myPropertyResult.Value);

                    string cmdText = "INSERT * INTO ProccesorTab VALUES (myPropertyResults)";

                    SqlCommand cmd = new SqlCommand(cmdText, sqlConnection);

                    cmd.Parameters.AddWithValue("myProperty.Name", myPropertyResults);

                }
            }



        }
        private void NetworkInfo()
        {
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-NDOBE5PK; Trusted_Connection=Yes; DataBase=Win32Project;");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            Dictionary<object, object> myPropertyResults = new Dictionary<object, object>();
            ManagementClass myManagementClass = new ManagementClass("Win32_NetworkAdapter");
            ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
            PropertyDataCollection myProperties = myManagementClass.Properties;
            foreach (var obj in myManagementCollection)
            {
                foreach (var myProperty in myProperties)
                {
                    bool keyExists = myPropertyResults.ContainsKey(myProperty.Name);
                    if (keyExists == false)
                    {
                        myPropertyResults.Add(myProperty.Name,
                       obj.Properties[myProperty.Name].Value);
                    }
                    else
                    {
                        myPropertyResults[Name] = obj.Properties[myProperty.Name].Value;
                    }
                }

                //string insertSql = "INSERT INTO NetworkTab VALUES (@myPropertyResults)";
                //var types = new[] { 1, 2, 3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40 };
                //using (SqlCommand command = new SqlCommand(insertSql, sqlConnection))
                //{
                //    foreach (var myPropertyResult in types)
                //    {
                //        command.Parameters.AddWithValue("@myPropertyResults", myPropertyResults);
                //        command.ExecuteNonQuery();
                //    }

            }

            foreach (var myPropertyResult in myPropertyResults)
            {

                InfoList.Items.Add(myPropertyResult.Key + ":" + myPropertyResult.Value);



            }




        }
    


        private void MemoryInfo()
        {
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-NDOBE5PK; Trusted_Connection=Yes; DataBase=Win32Project;");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            Dictionary<object, object> myPropertyResults = new Dictionary<object, object>();
            ManagementClass myManagementClass = new ManagementClass("Win32_MemoryArray");
            ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
            PropertyDataCollection myProperties = myManagementClass.Properties;
            foreach (var obj in myManagementCollection)
            {
                foreach (var myProperty in myProperties)
                {
                    bool keyExists = myPropertyResults.ContainsKey(myProperty.Name);
                    if (keyExists == false)
                    {
                        myPropertyResults.Add(myProperty.Name,
                       obj.Properties[myProperty.Name].Value);
                    }
                    else
                    {
                        myPropertyResults[Name] = obj.Properties[myProperty.Name].Value;
                    }
                }

                foreach (var myPropertyResult in myPropertyResults)
                {

                    InfoList.Items.Add(myPropertyResult.Key + ":" + myPropertyResult.Value);

                    for (int i = 0; i < myProperties.Count; i++)
                    {
                        string cmdText = "INSERT * INTO [MemoryTab] VALUES (myPropertyResults)";

                        SqlCommand cmd = new SqlCommand(cmdText, sqlConnection);

                        cmd.Parameters.AddWithValue("myPropertyResult.Key", myPropertyResults);
                    }

                }
            }

        }
        private void MonitorInfo()
        {
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-NDOBE5PK; Trusted_Connection=Yes; DataBase=Win32Project;");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            Dictionary<object, object> myPropertyResults = new Dictionary<object, object>();
            ManagementClass myManagementClass = new ManagementClass("Win32_VideoController");
            ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
            PropertyDataCollection myProperties = myManagementClass.Properties;
            foreach (var obj in myManagementCollection)
            {
                foreach (var myProperty in myProperties)
                {
                    bool keyExists = myPropertyResults.ContainsKey(myProperty.Name);
                    if (keyExists == false)
                    {
                        myPropertyResults.Add(myProperty.Name,
                       obj.Properties[myProperty.Name].Value);
                    }
                    else
                    {
                        myPropertyResults[Name] = obj.Properties[myProperty.Name].Value;
                    }
                }

                foreach (var myPropertyResult in myPropertyResults)
                {
                    for (int i = 0; i < myProperties.Count; i++)
                    {
                        string cmdText = "INSERT * INTO [MonitorTab] VALUES (myPropertyResults)";

                        SqlCommand cmd = new SqlCommand(cmdText, sqlConnection);

                        cmd.Parameters.AddWithValue("myPropertyResult.Key", myPropertyResults);
                    }
                    InfoList.Items.Add(myPropertyResult.Key + ":" + myPropertyResult.Value);

                }
            }

        }
        private void MotherboardInfo()
        {
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-NDOBE5PK; Trusted_Connection=Yes; DataBase=Win32Project;");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            Dictionary<object, object> myPropertyResults = new Dictionary<object, object>();
            ManagementClass myManagementClass = new ManagementClass("Win32_MotherboardDevice");
            ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
            PropertyDataCollection myProperties = myManagementClass.Properties;
            foreach (var obj in myManagementCollection)
            {
                foreach (var myProperty in myProperties)
                {
                    bool keyExists = myPropertyResults.ContainsKey(myProperty.Name);
                    if (keyExists == false)
                    {
                        myPropertyResults.Add(myProperty.Name,
                       obj.Properties[myProperty.Name].Value);
                    }
                    else
                    {
                        myPropertyResults[Name] = obj.Properties[myProperty.Name].Value;
                    }
                }

                foreach (var myPropertyResult in myPropertyResults)
                {
                    for (int i = 0; i < myProperties.Count; i++)
                    {
                        string cmdText = "INSERT * INTO [MotherTab] VALUES (myPropertyResults)";

                        SqlCommand cmd = new SqlCommand(cmdText, sqlConnection);

                        cmd.Parameters.AddWithValue("myPropertyResult.Key", myPropertyResults);
                    }

                    InfoList.Items.Add(myPropertyResult.Key + ":" + myPropertyResult.Value);

                }
            }

        }
        private void KeyboardInfo()
        {
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-NDOBE5PK; Trusted_Connection=Yes; DataBase=Win32Project;");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            Dictionary<object, object> myPropertyResults = new Dictionary<object, object>();
            ManagementClass myManagementClass = new ManagementClass("Win32_Keyboard");
            ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
            PropertyDataCollection myProperties = myManagementClass.Properties;
            foreach (var obj in myManagementCollection)
            {
                foreach (var myProperty in myProperties)
                {
                    bool keyExists = myPropertyResults.ContainsKey(myProperty.Name);
                    if (keyExists == false)
                    {
                        myPropertyResults.Add(myProperty.Name,
                       obj.Properties[myProperty.Name].Value);
                    }
                    else
                    {
                        myPropertyResults[Name] = obj.Properties[myProperty.Name].Value;
                    }
                }

                foreach (var myPropertyResult in myPropertyResults)
                {
                    for (int i = 0; i < myProperties.Count; i++)
                    {
                        string cmdText = "INSERT * INTO [KeyboardTab] VALUES (myPropertyResults)";

                        SqlCommand cmd = new SqlCommand(cmdText, sqlConnection);


                        cmd.Parameters.AddWithValue("myPropertyResult.Key", myPropertyResults);
                    }
                    InfoList.Items.Add(myPropertyResult.Key + ":" + myPropertyResult.Value);

                }
            }

        }

        internal void InfoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}






