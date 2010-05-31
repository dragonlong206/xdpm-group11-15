using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using Dto;
using System.Collections;
using Util;



namespace Dao
{


    public class BaiTapTuLuanDAO
    {

        public static Boolean insertBaiTapTuLuan(BaiTapTuLuanDTO btcbhDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();

                // B3: Tao chuoi strSQL thao tac CSDL
                //Tam thoi lam the nay, le ra phai dung Store procedure va IDBaiTap auto increament
                //Cai nay se update sau
                //string SQLqurey = "insert into BaiTapTuLuan(IDBaiTap, TenBaiTap, NoiDungBaiTap, IDBaiHoc) values (@IDBaiTap, @TenBaiTap, @NoiDungBaiTap, @IDBaiHoc)";
                //SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.CommandText = "insertBaiTapTuLuan";


                cmd.Parameters.Add("@TenBaiTap", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDungBaiTap", SqlDbType.NText);
                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);


                cmd.Parameters["@TenBaiTap"].Value = btcbhDto.TenBaiTap;
                cmd.Parameters["@NoiDungBaiTap"].Value = btcbhDto.NoiDungBaiTap;
                cmd.Parameters["@IDBaiHoc"].Value = btcbhDto.IDBaiHoc;
                int n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    result = false;
                }

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        public static Boolean deleteBaiTapTuLuan(int IDBaiTap)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from BaiTapTuLuan Where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters["@IDBaiTap"].Value = IDBaiTap;


                int n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    result = false;
                }

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        public static Boolean updateBaiTapTuLuan(BaiTapTuLuanDTO btcbhDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update BaiTapTuLuan Set TenBaiTap = @TenBaiTap, NoiDungBaiTap = @NoiDungBaiTap Where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);


                cmd.Parameters.Add("@TenBaiTap", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDungBaiTap", SqlDbType.NText);
                //cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);


                cmd.Parameters["@IDBaiTap"].Value = btcbhDto.IDBaiTap;
                //cmd.Parameters["@IDBaiHoc"].Value = btcbhDto.IDBaiHoc;
                cmd.Parameters["@NoiDungBaiTap"].Value = btcbhDto.NoiDungBaiTap;
                cmd.Parameters["@TenBaiTap"].Value = btcbhDto.TenBaiTap;

                int n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    result = false;
                }

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }
            return result;

        }

        public static ArrayList selectAllBaiTapTuLuan()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapTuLuan";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTapTuLuanDTO btcbhDto = new BaiTapTuLuanDTO();

                    btcbhDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btcbhDto.TenBaiTap = (string)dr["TenBaiTap"];
                    btcbhDto.NoiDungBaiTap = (string)dr["NoiDungBaiTap"];
                    btcbhDto.IDBaiHoc = (int)dr["IDBaiHoc"];


                    List.Add(btcbhDto);
                }
                // B5: Dong ket noi CSDL
                dr.Close();



                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return List;
        }

        //lay BaiTapTuLuan theo loai IDBaiTapTuLuan
        public static BaiTapTuLuanDTO selectBaiTapTuLuanByID(int IDBaiTap)
        {
            BaiTapTuLuanDTO btcbhDto = new BaiTapTuLuanDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapTuLuan Where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters["@IDBaiTap"].Value = IDBaiTap;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    btcbhDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btcbhDto.TenBaiTap = (string)dr["TenBaiTap"];
                    btcbhDto.NoiDungBaiTap = (string)dr["NoiDungBaiTap"];
                    btcbhDto.IDBaiHoc = (int)dr["IDBaiHoc"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return btcbhDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiTap!=Null (ham tao) de kiem tra
        }

        //lay BaiTapTuLuan theo loai IDBaiTapTuLuan
        public static ArrayList selectBaiTapTuLuanByIDBaiHoc(int IDBaiHoc)
        {
            ArrayList List = new ArrayList();


            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapTuLuan Where IDBaiHoc = @IDBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters["@IDBaiHoc"].Value = IDBaiHoc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTapTuLuanDTO btcbhDto = new BaiTapTuLuanDTO();
                    btcbhDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btcbhDto.TenBaiTap = (string)dr["TenBaiTap"];
                    btcbhDto.NoiDungBaiTap = (string)dr["NoiDungBaiTap"];
                    btcbhDto.IDBaiHoc = (int)dr["IDBaiHoc"];

                    List.Add(btcbhDto);
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return List;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiTap!=Null (ham tao) de kiem tra
        }
        //lay BaiTapTuLuan theo loai IDBaiTapTuLuan
        public static ArrayList selectBaiTapByIDBaiHoc(int IDBaiHoc)
        {
            ArrayList List = new ArrayList();


            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapTuLuan Where IDBaiHoc = @IDBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters["@IDBaiHoc"].Value = IDBaiHoc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTapTuLuanDTO btcbhDto = new BaiTapTuLuanDTO();
                    btcbhDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btcbhDto.TenBaiTap = (string)dr["TenBaiTap"];
                    btcbhDto.NoiDungBaiTap = (string)dr["NoiDungBaiTap"];
                    btcbhDto.IDBaiHoc = (int)dr["IDBaiHoc"];

                    List.Add(btcbhDto);
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return List;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiTap!=Null (ham tao) de kiem tra
        }
    }
}
