﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_YearAndMonth_InCome
{
    public class DataProvider
    {
        //Chuổi kết nối với sql
        private string connectionString = @"Data Source=.\Sqlexpress;Initial Catalog=QLBV;Integrated Security=True";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        private DataProvider()
        {

        }

        /// <summary>
        /// Phương thức này có vai trò lấy dữ liệu là các bảng trong SQL
        /// </summary>
        /// <param name="query">Chuỗi truy vấn được đưa xuống SQL</param>
        /// <param name="sqlparameters"> mảng SqlParameter được thêm vào command(có thể không có)</param>
        /// <returns>Phương thức trả về kiểu dũ liệu DataTable</returns>
        public DataTable ExcuteQuery(string query, SqlParameter[] sqlparameters = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                if (sqlparameters != null)
                    command.Parameters.AddRange(sqlparameters);

                SqlDataAdapter adapter = new SqlDataAdapter(command);



                adapter.Fill(table);

                con.Close();
            }


            return table;
        }

        /// <summary>
        /// Phương thức thực hiện truy vấn xuống SQL và trả về số dòng thành công
        /// </summary>
        /// <param name="query">Chuỗi truy vấn được đưa xuống SQL</param>
        /// <returns>Số dòng thành công</returns>
        public int ExcuteNonQuery(string query, SqlParameter[] sqlparameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                if (sqlparameters != null)
                    command.Parameters.AddRange(sqlparameters);


                int temp = command.ExecuteNonQuery();

                return temp;
            }

        }

        
    }
}