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
    public class AccountDAO
    {
        public static Boolean insertAccount(AccountDTO acc)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "insert into Account(IDAcc, Pass, IDLoaiAcc, TrangThai) values (@IDAcc, @Pass, @IDLoaiAcc, @TrangThai)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDAcc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDLoaiAcc", SqlDbType.Int);
                cmd.Parameters.Add("@TrangThai", SqlDbType.Bit);

                cmd.Parameters["@IDAcc"].Value = acc.IDAcc;
                cmd.Parameters["@Pass"].Value = acc.Pass;
                cmd.Parameters["@IDLoaiAcc"].Value = acc.IDLoaiAcc;
                cmd.Parameters["@TrangThai"].Value = acc.TrangThai;

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

        public static Boolean deleteAccount(string IDAcc)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from Account Where IDAcc = @IDAcc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDAcc", SqlDbType.NVarChar);
                cmd.Parameters["@IDAcc"].Value = IDAcc;


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

        public static Boolean updateAccount(AccountDTO acc)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "update Account Set Pass = @Pass, IDLoaiAcc = @IDLoaiAcc, TrangThai = @TrangThai Where IDAcc = @IDAcc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar);
                cmd.Parameters.Add("@IDLoaiAcc", SqlDbType.Int);
                cmd.Parameters.Add("@TrangThai", SqlDbType.Bit);
                cmd.Parameters.Add("@IDAcc", SqlDbType.NVarChar);

                cmd.Parameters["@Pass"].Value = acc.Pass;
                cmd.Parameters["@IDLoaiAcc"].Value = acc.IDLoaiAcc;
                cmd.Parameters["@TrangThai"].Value = acc.TrangThai;
                cmd.Parameters["@IDAcc"].Value = acc.IDAcc;

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

        public static ArrayList selectAllAccount()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from Account";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AccountDTO accDTO = new AccountDTO();
                    accDTO.IDAcc = (string)dr["IDAcc"];
                    accDTO.Pass = (string)dr["Pass"];
                    accDTO.IDLoaiAcc = (int)dr["IDLoaiAcc"];
                    accDTO.TrangThai = (Boolean)dr["TrangThai"];

                    List.Add(accDTO);
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

        //lay account theo loai account
        public static ArrayList selectAccountByLAC(int IDLoaiAcc)
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from Account Where IDLoaiAcc = @IDLoaiAcc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDLoaiAcc", SqlDbType.Int);
                cmd.Parameters["@IDLoaiAcc"].Value = IDLoaiAcc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AccountDTO accDTO = new AccountDTO();
                    accDTO.IDAcc = (string)dr["IDAcc"];
                    accDTO.Pass = (string)dr["Pass"];
                    accDTO.IDLoaiAcc = (int)dr["IDLoaiAcc"];
                    accDTO.TrangThai = (Boolean)dr["TrangThai"];

                    List.Add(accDTO);
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

        //lay account theo ID account
        public static AccountDTO selectAccountByIDAC(string IDAcc)
        {
            AccountDTO accDTO = new AccountDTO();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from Account Where IDAcc = @IDAcc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDAcc", SqlDbType.NVarChar);
                cmd.Parameters["@IDAcc"].Value = IDAcc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    accDTO.IDAcc = (string)dr["IDAcc"];
                    accDTO.Pass = (string)dr["Pass"];
                    accDTO.IDLoaiAcc = (int)dr["IDLoaiAcc"];
                    accDTO.TrangThai = (Boolean)dr["TrangThai"];                
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return accDTO;
        }
    }
}
