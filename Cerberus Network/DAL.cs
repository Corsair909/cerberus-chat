using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;

namespace Cerberus_Network
{
    class DAL
    {
        // Подключаемся к БД
        SqlConnection Connect = new SqlConnection(@"Data Source=10.10.10.34;Initial Catalog=01n;Persist Security Info=True;User ID=hat_un;Password=AboveReproach1;");

        // Выводим список брокеров
        public ArrayList GetAllBrokers()
        {
            ArrayList allBrokers = new ArrayList();

            SqlCommand com = new SqlCommand("SELECT * FROM Посредники ORDER BY имя", Connect);
            try
            {
                Connect.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)                             // Осли объект содержит одну или несколько строк
                    foreach (DbDataRecord result in dr)     //если привязаны данные
                        allBrokers.Add(result);             // добавление данных в таблицу
            }
            catch
            { }
            Connect.Close();

            return allBrokers;
        }

        internal object GetAllDateTimeForBrokers(string datetime)
        {
            ArrayList allDateTime = new ArrayList();

            string query = String.Format("SELECT * FROM Дата_операции Where код_посредника='{0}' Order By Дата", datetime);
            SqlCommand com = new SqlCommand(query, Connect);
            try
            {
                Connect.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)                             //Если объект содержит одну или несколько строк
                    foreach (DbDataRecord result in dr)     //если привязаны данные
                        allDateTime.Add(result);            //добавление данных в таблицу
            }
            catch{ }
            Connect.Close();

            return allDateTime;
        }

        internal ArrayList GetAllOperationForDateTime(string datetimeID)
        {
            ArrayList allOperation = new ArrayList();


            string query = String.Format("SELECT * FROM Операции Where код_даты = '{0}' ", datetimeID);
            SqlCommand com = new SqlCommand(query, Connect);
            try
            {
                Connect.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)                             //если объект содержит одну или несколько строк
                    foreach (DbDataRecord result in dr)     //если привязаны данные
                        allOperation.Add(result);             //добавление данных в таблицу
            }
            catch { }
            Connect.Close();

            return allOperation;
        }

        // Добовляем клиента в базу
        public bool SaveNewBroker(string BrokerID, string Name, string AuctionID, string Address, string Phone)
        {
            bool flagResult = false;
            string query = string.Format("INSERT INTO Посредники " +
                 "([код_посредника], [имя], [код_биржи], [адрес], [телефон])" +
                 " VALUES ('{0}''{1}''{2}''{3}''{4}')",
                 BrokerID, Name, AuctionID, Address, (Phone != string.Empty) ? Phone : null);

            Connect.Open();
            SqlCommand com = new SqlCommand(query, Connect);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    flagResult = true;
                }
            }
            catch { }
            Connect.Close();
            return flagResult;
        }
    }
}
