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
    public class MonHocDAO
    {
        public static Boolean insertMonHoc(MonHocDTO MonHocDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();

                // B3: Tao chuoi strSQL thao tac CSDL
                //Tam thoi lam the nay, le ra phai dung Store procedure va IDMonHoc auto increament
                //Cai nay se update sau
                string SQLqurey = "insert into MonHoc(IDMonHoc, TenMonHoc) values (@IDMonHoc, @TenMonHoc)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDMonHoc", SqlDbType.Int);
                cmd.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar);


                cmd.Parameters["@IDMonHoc"].Value = MonHocDto.IDMonHoc;
                cmd.Parameters["@TenMonHoc"].Value = MonHocDto.TenMonHoc;


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

        public static Boolean deleteMonHoc(string IDMonHoc)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from MonHoc Where IDMonHoc = @IDMonHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDMonHoc", SqlDbType.Int);
                cmd.Parameters["@IDAMonHoc"].Value = IDMonHoc;


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

        public static Boolean updateMonHoc(MonHocDTO MonHocDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update MonHoc Set TenMonHoc = @TenMonHoc Where IDMonHoc = @IDMonHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);


                cmd.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDMonHoc", SqlDbType.Int);

                cmd.Parameters["@TenMonHoc"].Value = MonHocDto.TenMonHoc;
                cmd.Parameters["@IDMonHoc"].Value = MonHocDto.IDMonHoc;

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

        public static ArrayList selectAllMonHoc()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from MonHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MonHocDTO MonHocDto = new MonHocDTO();

                    MonHocDto.IDMonHoc = (int)dr["IDMonHoc"];
                    MonHocDto.TenMonHoc = (string)dr["TenMonHoc"];


                    List.Add(MonHocDto);
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

        //lay MonHoc theo loai IDMonHoc
        public static MonHocDTO selectMonHocByIDMonHoc(int IDMonHoc)
        {
            MonHocDTO MonHocDtO = new MonHocDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from MonHoc Where IDMonHoc = @IDMonHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDMonHoc", SqlDbType.Int);
                cmd.Parameters["@IDMonHoc"].Value = IDMonHoc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MonHocDtO.IDMonHoc = (int)dr["IDMonHoc"];
                    MonHocDtO.TenMonHoc = (string)dr["TenMonHoc"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return MonHocDtO;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungMonHoc!=Null (ham tao) de kiem tra
        }




    }
}
