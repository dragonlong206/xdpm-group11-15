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
    public class CauHoiBTBaiHocDAO
    {
        public static Boolean insertCauHoiBTBaiHoc(CauHoiBTBaiHocDTO chbtBaiHocDto)
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
                //string SQLqurey = "insert into CauHoiBTBaiHoc(IDCauHoi, CauHoiA, CauHoiB, CauHoiC, CauHoiD, CauTraLoi, IDBaiTap) values (@IDCauHoi, @CauHoiA, @CauHoiB, @CauHoiC, @CauHoiD, @IDBaiTap)";
                //sqlCommand cmd = new SqlCommand(SQLqurey, connection);


                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.CommandText = "insertCauHoiBTBaiHoc";



                //cmd.Parameters.Add("@IDCauHoi", SqlDbType.Int);
                //cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters.Add("@CauHoiA", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiB", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiC", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiD", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauTraLoi", SqlDbType.NChar);
                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);

                //cmd.Parameters["@IDCauHoi"].Value = chbtBaiHocDto.IDCauHoi;
                cmd.Parameters["@CauHoiA"].Value = chbtBaiHocDto.CauHoiA;
                cmd.Parameters["@CauHoiB"].Value = chbtBaiHocDto.CauHoiB;
                cmd.Parameters["@CauHoiC"].Value = chbtBaiHocDto.CauHoiC;
                cmd.Parameters["@CauHoiD"].Value = chbtBaiHocDto.CauHoiD;
                cmd.Parameters["@CauTraLoi"].Value = chbtBaiHocDto.CauTraLoi;
                cmd.Parameters["@IDBaiTap"].Value = chbtBaiHocDto.IDBaiTap;


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

        public static Boolean deleteCauHoiBTBaiHoc(int IDCauHoi)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from CauHoiBTBaiHoc Where IDCauHoi = @IDCauHoi";
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
        public static Boolean deleteCauHoiBTBaiHocByIDBaiTap(int IDBaiTap)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from CauHoiBTBaiHoc Where IDBaiTap = @IDBaiTap";
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
        public static Boolean updateCauHoiBTBaiHoc(CauHoiBTBaiHocDTO chbtBaiHocDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update BaiHoc Set CauHoiA = @CauHoiA, CauHoiB = @CauHoiB, CauHoiC = @CauHoiC, CauHoiD = @CauHoiD, CauTraLoi = @CauTraLoi, IDBaiTap = @IDBaiTap Where IDCauHoi = @IDCauHoi";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);



                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters.Add("@CauHoiA", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiB", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiC", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauHoiD", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CauTraLoi", SqlDbType.NChar);
                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters.Add("@IDCauHoi", SqlDbType.Int);


                cmd.Parameters["@CauHoiA"].Value = chbtBaiHocDto.CauHoiA;
                cmd.Parameters["@CauHoiB"].Value = chbtBaiHocDto.CauHoiB;
                cmd.Parameters["@CauHoiC"].Value = chbtBaiHocDto.CauHoiC;
                cmd.Parameters["@CauHoiD"].Value = chbtBaiHocDto.CauHoiD;
                cmd.Parameters["@CauTraLoi"].Value = chbtBaiHocDto.CauTraLoi;
                cmd.Parameters["@IDBaiTap"].Value = chbtBaiHocDto.IDBaiTap;
                cmd.Parameters["@IDCauHoi"].Value = chbtBaiHocDto.IDCauHoi;


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

        public static ArrayList selectAllCauHoiBTBaiHoc()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CauHoiBTBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoiBTBaiHocDTO chbtBaiHocDto = new CauHoiBTBaiHocDTO();

                    chbtBaiHocDto.IDCauHoi = (int)dr["IDCauHoi"];
                    chbtBaiHocDto.CauHoiA = (string)dr["CauHoiA"];
                    chbtBaiHocDto.CauHoiB = (string)dr["CauHoiB"];
                    chbtBaiHocDto.CauHoiC = (string)dr["CauHoiC"];
                    chbtBaiHocDto.CauHoiD = (string)dr["CauHoiD"];
                    chbtBaiHocDto.CauTraLoi = (char)dr["CauTraLoi"];
                    chbtBaiHocDto.IDBaiTap = (int)dr["IDBaiTap"];


                    List.Add(chbtBaiHocDto);
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

        //lay Cau Hoi BT BaiHoc theo loai IDCauHoi
        public static CauHoiBTBaiHocDTO selectCauHoiBTBaiHocByIDCauHoi(int IDCauHoi)
        {
            CauHoiBTBaiHocDTO chbtBaiHocDto = new CauHoiBTBaiHocDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CauHoiBTBaiHoc Where IDCauHoi = @IDCauHoi";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDCauHoi", SqlDbType.Int);
                cmd.Parameters["@IDCauHoi"].Value = IDCauHoi;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    chbtBaiHocDto.IDCauHoi = (int)dr["IDCauHoi"];
                    chbtBaiHocDto.CauHoiA = (string)dr["CauHoiA"];
                    chbtBaiHocDto.CauHoiB = (string)dr["CauHoiB"];
                    chbtBaiHocDto.CauHoiC = (string)dr["CauHoiC"];
                    chbtBaiHocDto.CauHoiD = (string)dr["CauHoiD"];
                    chbtBaiHocDto.CauTraLoi = (char)dr["CauTraLoi"];
                    chbtBaiHocDto.IDBaiTap = (int)dr["IDBaiTap"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return chbtBaiHocDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiHoc!=Null (ham tao) de kiem tra
        }

        //lay danh sach cau hoi BaiHoc theo IDBaiHoc
        public static ArrayList selectCauHoiBTBaiHocByIDBaiHoc(int IDBaiHoc)
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CauHoiBTBaiHoc where IDBaiTap = @IDBaiTap";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiTap", SqlDbType.Int);
                cmd.Parameters["@IDBaiTap"].Value = IDBaiHoc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoiBTBaiHocDTO chbtBaiHocDto = new CauHoiBTBaiHocDTO();

                    chbtBaiHocDto.IDCauHoi = (int)dr["IDCauHoi"];
                    chbtBaiHocDto.CauHoiA = (string)dr["CauHoiA"];
                    chbtBaiHocDto.CauHoiB = (string)dr["CauHoiB"];
                    chbtBaiHocDto.CauHoiC = (string)dr["CauHoiC"];
                    chbtBaiHocDto.CauHoiD = (string)dr["CauHoiD"];
                    chbtBaiHocDto.CauTraLoi = (char)dr["CauTraLoi"];
                    chbtBaiHocDto.IDBaiTap = (int)dr["IDBaiTap"];


                    List.Add(chbtBaiHocDto);
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
