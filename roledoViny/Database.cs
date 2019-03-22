﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace roledoViny
{
    class Database
    {

        private MySqlConnection conn;
        private string server;
        private string database;
        private string username;
        private string password;

        public Database()
        {

            Initialize();
            
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException)
            {

            }
        return false;
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }


        private void Initialize()
        {
            server = "localhost";
            database = "tupperviny";
            username = "root";
            password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connectionString);
        }

        public bool newProduct(string produto, string detalhe, string codigo, int qtd, decimal valor)
        {

            OpenConnection();
            string sql = string.Format("INSERT INTO products(CodProd,Prod_name,Prod_Detail,Prod_val,Prod_qtd) VALUES('{0}','{1}','{2}',{3},{4});",codigo,produto,detalhe,valor,qtd);

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();

                return true;
            }catch(MySqlException me){
                CloseConnection();
                return false;
            }

        }

        //public bool newClient(string cliente, bool deve)
        //{

        //}
        
        public string newClient(string cliente,bool deve)
        {
            

            try
            {
                OpenConnection();

                string sql = string.Format("INSERT INTO clients(Client_name,deve) VALUES('{0}',{1});", cliente, deve);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();

                return "foi";
            }
            catch (Exception me)
            {
                CloseConnection();
                return me.ToString();
            }
        
    }





    }
}
