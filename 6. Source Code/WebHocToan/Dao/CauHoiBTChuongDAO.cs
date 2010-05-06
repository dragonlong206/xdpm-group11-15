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
    public class CauHoiBTChuongDAO
    {
        public static Boolean insertCauHoiBTChuong(CauHoiBTChuongDTO chbtChuongDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();

                // B3: Tao chuoi strSQL thao tac CSDL
                //Tam thoi lam the nay, le ra phai dung Store procedure va IDChuong auto increament
                //Cai nay se update sau
                //string SQLqurey = "insert into CauHoiBTChuong(IDCauHoi, CauHoiA, CauHoiB, CauHoiC, CauHoiD, CauTraLoi, IDBaiTap) values (@IDCauHoi, @CauHoiA, @CauHoiB, @CauHoiC, @CauHoiD, @IDBaiTap)";
                //SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.CommandText = "insertCauHoiBTChuong";


                //cmd.Parameters.Add("@IDCauHoi", SqlDbType.Int);
                //cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters.Add("@CauHoiA", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiB", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiC", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiD", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauTraLoi", SqlDbType.NChar);
                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);

               // cmd.Parameters["@IDCauHoi"].Value = chbtChuongDto.IDCauHoi;
                cmd.Parameters["@CauHoiA"].Value = chbtChuongDto.CauHoiA;
                cmd.Parameters["@CauHoiB"].Value = chbtChuongDto.CauHoiB;
                cmd.Parameters["@CauHoiC"].Value = chbtChuongDto.CauHoiC;
                cmd.Parameters["@CauHoiD"].Value = chbtChuongDto.CauHoiD;
                cmd.Parameters["@CauTraLoi"].Value = chbtChuongDto.CauTraLoi;
                cmd.Parameters["@IDBaiTap"].Value = chbtChuongDto.IDBaiTap;


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

        public static Boolean deleteCauHoiBTChuong(string IDCauHoi)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from CauHoiBTChuong Where IDCauHoi = @IDCauHoi";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDCauHoi", SqlDbType.Int);
                cmd.Parameters["@IDCauHoi"].Value = IDCauHoi;


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

        public static Boolean updateCauHoiBTChuong(CauHoiBTChuongDTO chbtChuongDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update Chuong Set CauHoiA = @CauHoiA, CauHoiB = @CauHoiB, CauHoiC = @CauHoiC, CauHoiD = @CauHoiD, CauTraLoi = @CauTraLoi, IDBaiTap = @IDBaiTap Where IDCauHoi = @IDCauHoi";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);


               
                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters.Add("@CauHoiA", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiB", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiC", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiD", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauTraLoi", SqlDbType.NChar);
                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters.Add("@IDCauHoi", SqlDbType.Int);

                
                cmd.Parameters["@CauHoiA"].Value = chbtChuongDto.CauHoiA;
                cmd.Parameters["@CauHoiB"].Value = chbtChuongDto.CauHoiB;
                cmd.Parameters["@CauHoiC"].Value = chbtChuongDto.CauHoiC;
                cmd.Parameters["@CauHoiD"].Value = chbtChuongDto.CauHoiD;
                cmd.Parameters["@CauTraLoi"].Value = chbtChuongDto.CauTraLoi;
                cmd.Parameters["@IDBaiTap"].Value = chbtChuongDto.IDBaiTap;
                cmd.Parameters["@IDCauHoi"].Value = chbtChuongDto.IDCauHoi;


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

        public static ArrayList selectAllCauHoiBTChuong()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CauHoiBTChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoiBTChuongDTO chbtChuongDto = new CauHoiBTChuongDTO();

                    chbtChuongDto.IDCauHoi = (int)dr["IDCauHoi"];
                    chbtChuongDto.CauHoiA = (string)dr["CauHoiA"];
                    chbtChuongDto.CauHoiB = (string)dr["CauHoiB"];
                    chbtChuongDto.CauHoiC = (string)dr["CauHoiC"];
                    chbtChuongDto.CauHoiD = (string)dr["CauHoiD"];
                    chbtChuongDto.CauTraLoi = (char)dr["CauTraLoi"];
                    chbtChuongDto.IDBaiTap = (int)dr["IDBaiTap"];


                    List.Add(chbtChuongDto);
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

        //lay Cau Hoi BT Chuong theo loai IDCauHoi
        public static CauHoiBTChuongDTO selectCauHoiBTChuongByIDCauHoi(int IDCauHoi)
        {
            CauHoiBTChuongDTO chbtChuongDto= new CauHoiBTChuongDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CauHoiBTChuong Where IDCauHoi = @IDCauHoi";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDCauHoi", SqlDbType.Int);
                cmd.Parameters["@IDCauHoi"].Value = IDCauHoi;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    chbtChuongDto.IDCauHoi = (int)dr["IDCauHoi"];
                    chbtChuongDto.CauHoiA = (string)dr["CauHoiA"];
                    chbtChuongDto.CauHoiB = (string)dr["CauHoiB"];
                    chbtChuongDto.CauHoiC = (string)dr["CauHoiC"];
                    chbtChuongDto.CauHoiD = (string)dr["CauHoiD"];
                    chbtChuongDto.CauTraLoi = (char)dr["CauTraLoi"];
                    chbtChuongDto.IDBaiTap = (int)dr["IDBaiTap"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return chbtChuongDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungChuong!=Null (ham tao) de kiem tra
        }

        //lay danh sach cau hoi chuong theo IDChuong
        public static ArrayList selectCauHoiBTChuongByIDChuong(int IDChuong)
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CauHoiBTChuong where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters["@IDBaiTap"].Value = IDChuong;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoiBTChuongDTO chbtChuongDto = new CauHoiBTChuongDTO();

                    chbtChuongDto.IDCauHoi = (int)dr["IDCauHoi"];
                    chbtChuongDto.CauHoiA = (string)dr["CauHoiA"];
                    chbtChuongDto.CauHoiB = (string)dr["CauHoiB"];
                    chbtChuongDto.CauHoiC = (string)dr["CauHoiC"];
                    chbtChuongDto.CauHoiD = (string)dr["CauHoiD"];
                    chbtChuongDto.CauTraLoi = (char)dr["CauTraLoi"];
                    chbtChuongDto.IDBaiTap = (int)dr["IDBaiTap"];


                    List.Add(chbtChuongDto);
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
