using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Lab04_Bessonova483_DB
{
    public partial class FormMain : Form
    {
        SqlConnection connection = new SqlConnection();
        public FormMain()
        {
            InitializeComponent();
        }
        struct ElementInfo
        {
            public int Num;
            public string name;
        }
        struct Spectraline
        {
            public float wlen;
            public float intens;

        }

        List<ElementInfo> elements = new List<ElementInfo>();
        List<Spectraline> spectralines = new List<Spectraline>();

        Pen pen = new Pen(Color.White);
        private void FormMain_Load(object sender, EventArgs e)
        {
            //проверить связь с БД

            connection.ConnectionString = ClassDB.connectionString;
            try
            {
                connection.Open();
                MessageBox.Show("Связь с сервером установлена.");

                string sqlselfromelem = "SELECT Atomic_number, Full_name FROM Elements;";
                SqlCommand selcom = new SqlCommand(sqlselfromelem, connection);

                SqlDataReader rdr = selcom.ExecuteReader();

                int col_atnum = rdr.GetOrdinal("Atomic_number");
                int col_name = rdr.GetOrdinal("Full_name");

                while(rdr.Read() == true)
                {
                    ElementInfo element;
                    element.Num = rdr.GetInt32(col_atnum);
                    element.name = rdr.GetString(col_name);

                    elements.Add(element);
                    comboBoxElement.Items.Add(element.name);
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка подключения" + ex.Message); return;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            importHydrogen();
            importHelium();
            importlithium();
            importCarbon();
            importNitrogen();
            importOxygen();
            importsodium();
            importNeon();
            importmagnesium();
            importaluminum();
            importsilicon();
            importsulfur();
            importXenon();
            importiron();
            importkrypton();
            importmercury();
            importpotassium();
            importstrontium();
            importbarium();
            importcalcium();
            importargon();
        }

        private void importOxygen()
        {

            string el_name = "Oxygen";
            int num_el = 8;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();


            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }



        private void importXenon()
        {

            string el_name = "Xenon";
            int num_el = 54;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }

        private void importHydrogen()
        {


            string el_name = "hydrogen";
            int num_el = 1;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }

        private void importHelium()
        {

            string el_name = "helium";
            int num_el = 2;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importlithium()
        {

            string el_name = "lithium";
            int num_el = 3;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importCarbon()
        {

            string el_name = "carbon";
            int num_el = 6;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQueryAsync();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQueryAsync();
        }
        private void importNeon()
        {
            string el_name = "neon";
            int num_el = 10;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importNitrogen()
        {

            string el_name = "nitrogen";
            int num_el = 7;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importmagnesium()
        {

            string el_name = "magnesium";
            int num_el = 12;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importaluminum()
        {

            string el_name = "aluminum";
            int num_el = 13;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }

        private void importsilicon()
        {

            string el_name = "silicon";
            int num_el = 14;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importsulfur()
        {

            string el_name = "sulfur";
            int num_el = 16;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importsodium()
        {
            string el_name = "sodium";
            int num_el = 11;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importiron()
        {

            string el_name = "iron";
            int num_el = 26;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importkrypton()
        {
            string el_name = "krypton";
            int num_el = 36;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importmercury()
        {
            string el_name = "mercury";
            int num_el = 80;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importpotassium()
        {

            string el_name = "potassium";
            int num_el = 19;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importstrontium()
        {

            string el_name = "strontium";
            int num_el = 38;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importbarium()
        {

            string el_name = "barium";
            int num_el = 56;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importcalcium()
        {

            string el_name = "calcium";
            int num_el = 20;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
        private void importargon()
        {

            string el_name = "argon";
            int num_el = 18;
            string sql = "insert into Elements (Atomic_number, Full_name) values (" + num_el + ", " + el_name + ");";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "Create table" + el_name + "(Wavelength FLOAT, Rel_intensity FLOAT);";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            string path = @"F:\мои данные\vs\Lab03_lab04-Bessonova483-DataBase\Lab03_lab04-Bessonova483-DataBase\bin\Debug\" + el_name + ".txt";
            string[] row = File.ReadAllLines(path);
            sql = "INSERT INTO" + el_name + "(Wavelength, Rel_intensity) values ";
            char[] sep = new char[] { ' ', '\t' };
            for (int i = 0; i < row.Length; i++)
            {
                string[] col = row[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                sql += "(" + col[0] + ", " + col[1] + ")";
                if (i < row.Length - 1) sql += ", ";
                sql += ";";
            }
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();

            sql = "INSERT INTO Spectral_lines ";
            sql += "(Atomic_number, Wavelength, Rel_intensity) ";
            sql += "SELECT " + num_el.ToString() + "::INTEGER AS Atomic_number, ";
            sql += "(Wavelength * 0.1) AS Wavelength, Rel_intensity ";
            sql += "FROM " + el_name + ";";
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }

        private void pictureBoxScal_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);

            int w = pictureBoxScal.Width - 1;
            int h = pictureBoxScal.Height - 1;

            float[] c = new float[3];
            for (int i = 0; i < spectralines.Count; i++)
            {
                float x = Interp.map(spectralines[i].wlen, 380.0f, 780.0f, 0, w);
                WavelengthColors.nm2rgb(spectralines[i].wlen, c);
                pen.Color = Color.FromArgb((int)(c[0] * 255.0f), (int)(c[1] * 255.0f), (int)(c[2] * 255.0f));
                e.Graphics.DrawLine(pen, x, 0, x, h);

            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int idx = comboBoxElement.SelectedIndex;
            if (idx < 0) return;
            if (idx >= 0)
            {
                int atomic = elements[idx].Num;
                string name = elements[idx].name;
                textBoxNameEl.Text = name;
                textBoxnumEl.Text = atomic.ToString();
                string sqlselspecline = "SELECT Wavelength, Rel_intensity FROM Spectral_lines ";
                sqlselspecline += "WHERE Atomic_number = " + atomic.ToString() + ";";
                SqlCommand sqlCommandsel = new SqlCommand(sqlselspecline, connection);

                SqlDataReader rdr1 = sqlCommandsel.ExecuteReader();

                int col_Wlen = rdr1.GetOrdinal("Wavelength");
                int col_Reli = rdr1.GetOrdinal("Rel_intensity");
                spectralines.Clear();
                while (rdr1.Read() == true)
                {
                    Spectraline sp;
                    sp.wlen = (float)rdr1.GetDouble(col_Wlen);
                    sp.intens = (float)rdr1.GetDouble(col_Reli);

                    spectralines.Add(sp);
                    listBoxWave.Items.Add(rdr1["Wavelength"].ToString());
                    listBoxIntes.Items.Add(rdr1["Rel_intensity"].ToString());
                }
                rdr1.Close();

                pictureBoxScal.Invalidate();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxnumEl.Clear();
            textBoxNameEl.Clear();
            listBoxWave.Items.Clear();
            listBoxIntes.Items.Clear();
        }
    }
}

