﻿using System;
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
    public class ChuongDAO
    {
        public static Boolean insertChuong(ChuongDTO chuongDto)
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
                string SQLqurey = "insert into Chuong(IDChuong, TenChuong) values (@IDChuong, @TenChuong)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters.Add("@TenChuong", SqlDbType.NVarChar);


                cmd.Parameters["@IDChuong"].Value = chuongDto.IDChuong;
                cmd.Parameters["@TenChuong"].Value = chuongDto.TenChuong;


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

        public static Boolean deleteChuong(string IDChuong)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from Chuong Where IDChuong = @IDChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters["@IDAChuong"].Value = IDChuong;


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

        public static Boolean updateChuong(ChuongDTO chuongDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update Chuong Set TenChuong = @TenChuong Where IDChuong = @IDChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);


                cmd.Parameters.Add("@TenChuong", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDChuong", SqlDbType.Int); 

                cmd.Parameters["@TenChuong"].Value = chuongDto.TenChuong;
                cmd.Parameters["@IDChuong"].Value = chuongDto.IDChuong;

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

        public static ArrayList selectAllChuong()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from Chuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChuongDTO chuongDto = new ChuongDTO();

                    chuongDto.IDChuong = (int)dr["IDChuong"];
                    chuongDto.TenChuong = (string)dr["TenChuong"];


                    List.Add(chuongDto);
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

        //lay Chuong theo loai IDChuong
        public static ChuongDTO selectChuongByIDChuong(int IDChuong)
        {
            ChuongDTO chuongDtO = new ChuongDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from Chuong Where IDChuong = @IDChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters["@IDChuong"].Value = IDChuong;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    chuongDtO.IDChuong = (int)dr["IDChuong"];
                    chuongDtO.TenChuong = (string)dr["TenChuong"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return chuongDtO;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungChuong!=Null (ham tao) de kiem tra
        }




    }
}
