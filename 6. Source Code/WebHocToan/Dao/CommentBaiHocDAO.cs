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
    public class CommentBaiHocDAO
    {
        public static Boolean insertCommentBaiHoc(CommentBaiHocDTO cmBaiHocDto)
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
                string SQLqurey = "insert into CommentBaiHoc(IDCommen, IDAcc, IDBaiHoc, NoiDung, NgayGio) values (@IDComment, @IDAcc, @IDBaiHoc, @NoiDung, @NgayGio)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters.Add("@IDAcc", SqlDbType.VarChar);
                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime);

                cmd.Parameters["@IDComment"].Value = cmBaiHocDto.IDComment;
                cmd.Parameters["@IDAcc"].Value = cmBaiHocDto.IDAcc;
                cmd.Parameters["@IDBaiHoc"].Value = cmBaiHocDto.IDBaiHoc;
                cmd.Parameters["@NoiDung"].Value = cmBaiHocDto.NoiDung;
                cmd.Parameters["NgayGio"].Value = cmBaiHocDto.NgayGio;

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

        public static Boolean deleteCommentBaiHoc(int IDComment)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from CommentBaiHoc Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters["@IDComment"].Value = IDComment;


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

        public static Boolean updateCommentBaiHoc(CommentBaiHocDTO cmBaiHocDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update CommentBaiHoc Set IDAcc = @IDAcc, IDBaiHoc = @IDBaiHoc, IDNoiDung = @NoiDung, NgayGioi = @NgayGio Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);




              
                cmd.Parameters.Add("@IDAcc", SqlDbType.VarChar);
                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime);
                cmd.Parameters.Add("@IDComment", SqlDbType.Int);

                
                cmd.Parameters["@IDAcc"].Value = cmBaiHocDto.IDAcc;
                cmd.Parameters["@IDBaiHoc"].Value = cmBaiHocDto.IDBaiHoc;
                cmd.Parameters["@NoiDung"].Value = cmBaiHocDto.NoiDung;
                cmd.Parameters["NgayGio"].Value = cmBaiHocDto.NgayGio;
                cmd.Parameters["@IDComment"].Value = cmBaiHocDto.IDComment;


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

        public static ArrayList selectAllCommentBaiHoc()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommentBaiHocDTO cmBaiHocDto = new CommentBaiHocDTO();

                    cmBaiHocDto.IDComment = (int)dr["IDCommnet"];
                    cmBaiHocDto.IDAcc = (string)dr["IDAcc"];
                    cmBaiHocDto.IDBaiHoc = (int)dr["IDBaiHoc"];
                    cmBaiHocDto.NoiDung = (string)dr["NoiDung"];
                    cmBaiHocDto.NgayGio = (DateTime)dr["NgayGio"];

                    List.Add(cmBaiHocDto);
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

        //lay Comment theo loai IDComment
        public static CommentBaiHocDTO selectCommentBaiHocByIDComment(int IDComment)
        {
            CommentBaiHocDTO cmBaiHocDto = new CommentBaiHocDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiHoc Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters["@IDComment"].Value = IDComment;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    cmBaiHocDto.IDComment = (int)dr["IDCommnet"];
                    cmBaiHocDto.IDAcc = (string)dr["IDAcc"];
                    cmBaiHocDto.IDBaiHoc = (int)dr["IDBaiHoc"];
                    cmBaiHocDto.NoiDung = (string)dr["NoiDung"];
                    cmBaiHocDto.NgayGio = (DateTime)dr["NgayGio"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return cmBaiHocDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiHoc!=Null (ham tao) de kiem tra
        }

        //lay danh sach cau hoi BaiHoc theo IDBaiHoc
        public static ArrayList selectCommentBaiHocByIDBaiHoc(int IDBaiHoc)
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiHoc where IDBaiHoc = @IDBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBaiHoc", SqlDbType.Int);
                cmd.Parameters["@IDBaiHoc"].Value = IDBaiHoc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommentBaiHocDTO cmBaiHocDto = new CommentBaiHocDTO();

                    cmBaiHocDto.IDComment = (int)dr["IDCommnet"];
                    cmBaiHocDto.IDAcc = (string)dr["IDAcc"];
                    cmBaiHocDto.IDBaiHoc = (int)dr["IDBaiHoc"];
                    cmBaiHocDto.NoiDung = (string)dr["NoiDung"];
                    cmBaiHocDto.NgayGio = (DateTime)dr["NgayGio"];


                    List.Add(cmBaiHocDto);
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
