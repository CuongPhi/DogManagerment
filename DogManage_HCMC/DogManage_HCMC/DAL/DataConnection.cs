﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
    public class DataConnection
    {
        private string stringConnection = "";

        private static DataConnection inst;
        private DataConnection() { }
        public static DataConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new DataConnection();
                return inst;
            }
        }
        private SqlConnection openConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                conn.Open();
            return conn;
        }
        void SplitParaString(string query, SqlCommand command, object[] parameter)
        {
            string[] listPara = query.Split(' ');
            int i = 0;
            foreach (string item in listPara)
            {
                if (item.Contains('@'))
                {
                    command.Parameters.AddWithValue(item, parameter[i]);
                    i++;
                }
            }


        }
        public DataTable ExcuteQuery(string stringQuery, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(stringQuery, openConnection(conn));
                if (parameter != null)
                    SplitParaString(stringQuery, command, parameter);
                SqlDataAdapter adaper = new SqlDataAdapter(command);
                adaper.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int ExcuteNoneQuery(string stringQuery, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(stringQuery, openConnection(conn));
                if (parameter != null)
                    SplitParaString(stringQuery, command, parameter);
                data = command.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
        public object ExcuteScalar(string stringQuery, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(stringQuery, openConnection(conn));
                if (parameter != null)
                    SplitParaString(stringQuery, command, parameter);
                data = command.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
