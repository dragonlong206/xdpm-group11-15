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
    public class BaiTapCuaBaiHocDAO
    {
        public static Boolean insertBaiTapCuaBaiHoc(BaiTapCuaBaiHocDTO btcbhDto)
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
                string SQLqurey = "insert into BaiTapCuaBaiHoc(IDBaiTap, TenBaiTap, IDBaiHoc) values (@IDBaiTap, @TenBaiTap, @IDBaiHoc)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters.Add("@TenBaiTap", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);

                cmd.Parameters["@IDBaiTap"].Value = btcbhDto.IDBaiTap;
                cmd.Parameters["@TenBaiTap"].Value = btcbhDto.TenBaiTap;
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

        public static Boolean deleteBaiTapCuaBaiHoc(string IDBaiTap)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from BaiTapCuaBaiHoc Where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters["@IDABaiTap"].Value = IDBaiTap;


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

        public static Boolean updateBaiTapCuaBaiHoc(BaiTapCuaBaiHocDTO btcbhDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update BaiTapCuaBaiHoc Set TenBaiTap = @TenBaiTap, IDBaiHoc = @IDBaiHoc Where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);


                cmd.Parameters.Add("@TenBaiTap", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Chuong", SqlDbType.Int);
                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);


                cmd.Parameters["@IDBaiTap"].Value = btcbhDto.IDBaiTap;
                cmd.Parameters["@IDBaiHoc"].Value = btcbhDto.IDBaiHoc;
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

        public static ArrayList selectAllBaiTapCuaBaiHoc()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapCuaBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTapCuaBaiHocDTO btcbhDto = new BaiTapCuaBaiHocDTO();

                    btcbhDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btcbhDto.TenBaiTap = (string)dr["TenBaiTap"];
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

        //lay BaiTapCuaBaiHoc theo loai IDBaiTapCuaBaiHoc
        public static BaiTapCuaBaiHocDTO selectBaiTapCuaBaiHocByID(int IDBaiTap)
        {
            BaiTapCuaBaiHocDTO btcbhDto = new BaiTapCuaBaiHocDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapCuaBaiHoc Where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters["@IDBaiTap"].Value = IDBaiTap;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    btcbhDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btcbhDto.TenBaiTap = (string)dr["TenBaiTap"];
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




    }
}
