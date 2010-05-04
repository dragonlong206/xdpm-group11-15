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
    public class BaiHocDAO
    {
        public static Boolean insertBaiHoc(BaiHocDTO bh)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
               
                // B3: Tao chuoi strSQL thao tac CSDL
                //Tam thoi lam the nay, le ra phai dung Store procedure va IDBaiHoc auto increament
                //Cai nay se update sau
                string SQLqurey = "insert into BaiHoc(IDBaiHoc, TenBaiHoc, NoiDungBaiHoc, IDChuong) values (@IDBaiHoc, @TenBaiHoc, @NoiDungBaiHoc, @IDChuong)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters.Add("@TenBaiHoc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDungBaiHoc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);

                cmd.Parameters["@IDBaiHoc"].Value = bh.IDBaiHoc;
                cmd.Parameters["@TenBaiHoc"].Value = bh.TenBaiHoc;
                cmd.Parameters["@NoiDungBaiHoc"].Value = bh.NoiDung;
                cmd.Parameters["@IDChuong"].Value = bh.IDChuong;

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

        public static Boolean insertBaiHocAutoIncrease(BaiHocDTO bh)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();

                // B3: Tao chuoi strSQL thao tac CSDL
                //Tam thoi lam the nay, le ra phai dung Store procedure va IDBaiHoc auto increament
                //Cai nay se update sau
                //string SQLqurey = "insert into BaiHoc(IDBaiHoc, TenBaiHoc, NoiDungBaiHoc, IDChuong) values (@IDBaiHoc, @TenBaiHoc, @NoiDungBaiHoc, @IDChuong)";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.CommandText = "insertBaiHoc";

                //cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters.Add("@TenBaiHoc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDungBaiHoc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);

                //cmd.Parameters["@IDBaiHoc"].Value = bh.IDBaiHoc;
                cmd.Parameters["@TenBaiHoc"].Value = bh.TenBaiHoc;
                cmd.Parameters["@NoiDungBaiHoc"].Value = bh.NoiDung;
                cmd.Parameters["@IDChuong"].Value = bh.IDChuong;

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

        public static Boolean deleteBaiHoc(string IDBaiHoc)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLquery = "delete from BaiHoc Where IDBaiHoc = @IDBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLquery, connection);

                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters["@IDBaiHoc"].Value = Int32.Parse(IDBaiHoc);


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

        public static Boolean updateBaiHoc(BaiHocDTO bh)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "update BaiHoc Set TenBaiHoc = @TenBaiHoc, NoiDungBaiHoc = @NoiDungBaiHoc, IDChuong = @Chuong Where IDBaiHoc = @IDBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);
                
                cmd.Parameters.Add("@TenBaiHoc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDungBaiHoc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);

                cmd.Parameters["@TenBaiHoc"].Value = bh.TenBaiHoc;
                cmd.Parameters["@NoiDungBaiHoc"].Value = bh.NoiDung;
                cmd.Parameters["@IDChuong"].Value = bh.IDChuong;
                cmd.Parameters["@IDBaiHoc"].Value = bh.IDBaiHoc;

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

        public static ArrayList selectAllBaiHoc()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiHocDTO bhDTO = new BaiHocDTO();

                    bhDTO.IDBaiHoc = (int)dr["IDBaiHoc"];
                    bhDTO.TenBaiHoc = (string)dr["TenBaiHoc"];
                    bhDTO.NoiDung = (string)dr["NoiDungBaiHoc"];
                    bhDTO.IDChuong = (int)dr["IDChuong"];


                    List.Add(bhDTO);
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

        //lay BaiHoc theo loai IDBaiHoc
        public static BaiHocDTO selectBaiHocByIDBaiHoc (int IDBaiHoc)
        {
            BaiHocDTO bhDTO = new BaiHocDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiHoc Where IDBaiHoc = @IDBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters["@IDBaiHoc"].Value = IDBaiHoc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {                    
                    bhDTO.IDBaiHoc = (int)dr["IDBaiHoc"];
                    bhDTO.TenBaiHoc = (string)dr["TenBaiHoc"];
                    bhDTO.NoiDung = (string)dr["NoiDungBaiHoc"];
                    bhDTO.IDChuong = (int)dr["IDChuong"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {
               
            }

            return bhDTO;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiHoc!=Null (ham tao) de kiem tra
        }

        //lay BaiHoc theo loai IDChuong
        public static ArrayList selectBaiHocByIDChuong(int IDChuong)
        {
            ArrayList List = new ArrayList();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from BaiHoc Where IDChuong = @IDChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters["@IDChuong"].Value = IDChuong;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiHocDTO bhDTO = new BaiHocDTO();

                    bhDTO.IDBaiHoc = (int)dr["IDBaiHoc"];
                    bhDTO.TenBaiHoc = (string)dr["TenBaiHoc"];
                    bhDTO.NoiDung = (string)dr["NoiDungBaiHoc"];
                    bhDTO.IDChuong = (int)dr["IDChuong"];

                    List.Add(bhDTO);
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


    }
}
