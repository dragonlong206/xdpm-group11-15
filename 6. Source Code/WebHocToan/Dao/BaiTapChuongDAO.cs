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
    public class BaiTapChuongDAO
    {
        public static Boolean insertBaiTapChuong(BaiTapChuongDTO btChuongDto)
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
                //string SQLqurey = "insert into BaiTapChuong(IDBaiTap, TenBaiTap, NoiDungBaiTap, IDChuong) values (@IDBaiTap, @TenBaiTap, @NoiDungBaiTap, @IDChuong)";
                //SqlCommand cmd = new SqlCommand(SQLqurey, connection);


                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.CommandText = "insertBaiTapChuong";

                //cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters.Add("@TenBaiTap", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDungBaiTap", SqlDbType.NText);
                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);

                //cmd.Parameters["@IDBaiTap"].Value = btChuongDto.IDBaiTap;
                cmd.Parameters["@TenBaiTap"].Value = btChuongDto.TenBaiTap;
                cmd.Parameters["@NoiDungBaiTap"].Value = btChuongDto.NoiDungBaiTap;
                cmd.Parameters["@IDChuong"].Value = btChuongDto.IDChuong;


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

        public static Boolean deleteBaiTapChuong(int IDBaiTap)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from BaiTapChuong Where IDBaiTap = @IDBaiTap";
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

        public static Boolean updateBaiTapChuong(BaiTapChuongDTO btChuongDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update BaiTapChuong Set TenBaiTap = @TenBaiTap, NoiDungBaiTap = @NoiDungBaiTap, IDChuong = @IDChuong Where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);


                cmd.Parameters.Add("@TenBaiTap", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDungBaiTap", SqlDbType.NText);
                cmd.Parameters.Add("@Chuong", SqlDbType.Int);
                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);


                cmd.Parameters["@IDBaiTap"].Value = btChuongDto.IDBaiTap;
                cmd.Parameters["@IDChuong"].Value = btChuongDto.IDChuong;
                cmd.Parameters["@NoiDungBaiTap"].Value = btChuongDto.NoiDungBaiTap;
                cmd.Parameters["@TenBaiTap"].Value = btChuongDto.TenBaiTap;

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

        public static ArrayList selectAllBaiTapChuong()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTapChuongDTO btChuongDto = new BaiTapChuongDTO();

                    btChuongDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btChuongDto.TenBaiTap = (string)dr["TenBaiTap"];
                    btChuongDto.NoiDungBaiTap = (string)dr["NoiDungBaiTap"];
                    btChuongDto.IDChuong = (int)dr["IDChuong"];


                    List.Add(btChuongDto);
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
        //select bai tap chuong by ID Chuong
        public static ArrayList selectBaiTapChuongByIDChuong(int ID)
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapChuong where IDChuong = @IDChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters["@IDChuong"].Value = ID;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTapChuongDTO btChuongDto = new BaiTapChuongDTO();

                    btChuongDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btChuongDto.TenBaiTap = (string)dr["TenBaiTap"];
                    btChuongDto.NoiDungBaiTap = (string)dr["NoiDungBaiTap"];
                    btChuongDto.IDChuong = (int)dr["IDChuong"];


                    List.Add(btChuongDto);
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
        //lay BaiTapChuong theo loai IDBaiTapChuong
        public static BaiTapChuongDTO selectBaiTapChuongByID(int IDBaiTap)
        {
            BaiTapChuongDTO btChuongDto = new BaiTapChuongDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiTapChuong Where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters["@IDBaiTap"].Value = IDBaiTap;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    btChuongDto.IDBaiTap = (int)dr["IDBaiTap"];
                    btChuongDto.TenBaiTap = (string)dr["TenBaiTap"];
                    btChuongDto.NoiDungBaiTap = (string)dr["NoiDungBaiTap"];
                    btChuongDto.IDChuong = (int)dr["IDChuong"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return btChuongDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiTap!=Null (ham tao) de kiem tra
        }




    }
}
