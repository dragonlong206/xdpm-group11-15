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
    public class LoaiAccDAO
    {
        public static Boolean insertLoaiAcc(LoaiAccDTO LoaiAccDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();

                // B3: Tao chuoi strSQL thao tac CSDL
                //Tam thoi lam the nay, le ra phai dung Store procedure va IDLoaiAcc auto increament
                //Cai nay se update sau
                string SQLqurey = "insert into LoaiAcc(IDLoaiAcc, TenLoaiAcc) values (@IDLoaiAcc, @TenLoaiAcc)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDLoaiAcc", SqlDbType.Int);
                cmd.Parameters.Add("@TenLoaiAcc", SqlDbType.NVarChar);


                cmd.Parameters["@IDLoaiAcc"].Value = LoaiAccDto.IDLoaiAcc;
                cmd.Parameters["@TenLoaiAcc"].Value = LoaiAccDto.TenLoaiAcc;


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

        public static Boolean deleteLoaiAcc(string IDLoaiAcc)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from LoaiAcc Where IDLoaiAcc = @IDLoaiAcc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDLoaiAcc", SqlDbType.Int);
                cmd.Parameters["@IDALoaiAcc"].Value = IDLoaiAcc;


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

        public static Boolean updateLoaiAcc(LoaiAccDTO LoaiAccDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update LoaiAcc Set TenLoaiAcc = @TenLoaiAcc Where IDLoaiAcc = @IDLoaiAcc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);


                cmd.Parameters.Add("@TenLoaiAcc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDLoaiAcc", SqlDbType.Int);

                cmd.Parameters["@TenLoaiAcc"].Value = LoaiAccDto.TenLoaiAcc;
                cmd.Parameters["@IDLoaiAcc"].Value = LoaiAccDto.IDLoaiAcc;

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

        public static ArrayList selectAllLoaiAcc()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from LoaiAcc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiAccDTO LoaiAccDto = new LoaiAccDTO();

                    LoaiAccDto.IDLoaiAcc = (int)dr["IDLoaiAcc"];
                    LoaiAccDto.TenLoaiAcc = (string)dr["TenLoaiAcc"];


                    List.Add(LoaiAccDto);
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

        //lay LoaiAcc theo loai IDLoaiAcc
        public static LoaiAccDTO selectLoaiAccByIDLoaiAcc(int IDLoaiAcc)
        {
            LoaiAccDTO LoaiAccDtO = new LoaiAccDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from LoaiAcc Where IDLoaiAcc = @IDLoaiAcc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDLoaiAcc", SqlDbType.Int);
                cmd.Parameters["@IDLoaiAcc"].Value = IDLoaiAcc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    LoaiAccDtO.IDLoaiAcc = (int)dr["IDLoaiAcc"];
                    LoaiAccDtO.TenLoaiAcc = (string)dr["TenLoaiAcc"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return LoaiAccDtO;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungLoaiAcc!=Null (ham tao) de kiem tra
        }




    }
}
