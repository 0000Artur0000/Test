﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JJBa
{
    class Connect
    {
        private static SqlConnectionStringBuilder connS = new SqlConnectionStringBuilder()
        {
            // DataSource = "303-2\\SQLEXPRESS",
            DataSource = "DESKTOP-U5HC5KL",
            InitialCatalog = "Ver4",
            IntegratedSecurity = true
        };
        public static string connect(string log, string pass)
        {
            using (SqlConnection conn = new SqlConnection(connS.ConnectionString))
            {
                string b = "";
                conn.Open();
                string d = $"SELECT * FROM dbo.IspolDB WHERE '{log}' = Логин_исполнителя AND '{pass}' = Пароль_исполнителя";
                string d1 = $"SELECT * FROM dbo.MenejDB WHERE '{log}' = Логин_менеджера AND '{pass}' = Пароль_менеджера";
                SqlCommand cmd = new SqlCommand(d, conn);
                SqlDataReader sql = cmd.ExecuteReader();
                if (sql.HasRows)
                {
                    sql.Read();
                    b = "0:" + sql[4].ToString();
                }
                else
                {
                    sql.Close();
                    cmd = new SqlCommand(d1, conn);
                    sql = cmd.ExecuteReader();
                    if (sql.HasRows)
                    {
                        sql.Read();
                        b = "1:" + sql[3];
                    }
                }
                sql.Close();
                conn.Close();
                if (!String.IsNullOrEmpty(b)) return b;
                return "";
            }
        }
        public static DataTable read(string name)
        {
            using (SqlConnection conn = new SqlConnection(connS.ConnectionString))
            {
                DataTable dt = new DataTable();
                bool b = false;
                conn.Open();
                string d = $"Select * From {name}";
                SqlCommand cmd = new SqlCommand(d, conn);
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    dt.Clear();
                    ada.Fill(dt);

                }

                conn.Close();
                return dt;
            }
        }
        public static void load(DataRow name)
        {
            using (SqlConnection conn = new SqlConnection(connS.ConnectionString))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                DataTable dt = new DataTable();
                bool b = false;
                conn.Open();
                string d = $"UPDATE dbo.RabDB Set [Junior_мин_ЗП] = '{name[1]}', [Middle_мин_ЗП] = '{name[2]}', [Senior_мин_ЗП] = '{name[3]}', [Коэффициент_для_Анализ_и_проектирование]= '{name[4]}', [Коэффициент_для_Установка_оборудования] = '{name[5]}', [Коэффициент_для_Техническое_обслуживание_и_сопровождение] = '{name[6]}', [Коэффициент_времени] = '{name[7]}', [Коэффициент_сложности] = '{name[8]}', [Коэффициент_для_перевода_в_денежный_эквивалент] = '{name[9]}' WHERE Id_d = '{name[0]}'";
                SqlCommand cmd = new SqlCommand(d, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                conn.Close();

            }
        }
    }
}
