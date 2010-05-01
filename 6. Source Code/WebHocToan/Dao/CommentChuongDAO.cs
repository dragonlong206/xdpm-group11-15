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
    public class CommentChuongDAO
    {
        public static Boolean insertCommentChuong(CommentChuongDTO cmChuongDto)
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
                string SQLqurey = "insert into CommentChuong(IDCommen, IDAcc, IDChuong, NoiDung, NgayGio) values (@IDComment, @IDAcc, @IDChuong, @NoiDung, @NgayGio)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters.Add("@IDAcc", SqlDbType.VarChar);
                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime);

                cmd.Parameters["@IDComment"].Value = cmChuongDto.IDComment;
                cmd.Parameters["@IDAcc"].Value = cmChuongDto.IDAcc;
                cmd.Parameters["@IDChuong"].Value = cmChuongDto.IDChuong;
                cmd.Parameters["@NoiDung"].Value = cmChuongDto.NoiDung;
                cmd.Parameters["NgayGio"].Value = cmChuongDto.NgayGio;

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

        public static Boolean deleteCommentChuong(int IDComment)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from CommentChuong Where IDComment = @IDComment";
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

        public static Boolean updateCommentChuong(CommentChuongDTO cmChuongDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update CommentChuong Set IDAcc = @IDAcc, IDChuong = @IDChuong, IDNoiDung = @NoiDung, NgayGioi = @NgayGio Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);





                cmd.Parameters.Add("@IDAcc", SqlDbType.VarChar);
                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime);
                cmd.Parameters.Add("@IDComment", SqlDbType.Int);


                cmd.Parameters["@IDAcc"].Value = cmChuongDto.IDAcc;
                cmd.Parameters["@IDChuong"].Value = cmChuongDto.IDChuong;
                cmd.Parameters["@NoiDung"].Value = cmChuongDto.NoiDung;
                cmd.Parameters["NgayGio"].Value = cmChuongDto.NgayGio;
                cmd.Parameters["@IDComment"].Value = cmChuongDto.IDComment;


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

        public static ArrayList selectAllCommentChuong()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommentChuongDTO cmChuongDto = new CommentChuongDTO();

                    cmChuongDto.IDComment = (int)dr["IDCommnet"];
                    cmChuongDto.IDAcc = (string)dr["IDAcc"];
                    cmChuongDto.IDChuong = (int)dr["IDChuong"];
                    cmChuongDto.NoiDung = (string)dr["NoiDung"];
                    cmChuongDto.NgayGio = (DateTime)dr["NgayGio"];

                    List.Add(cmChuongDto);
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
        public static CommentChuongDTO selectCommentChuongByIDComment(int IDComment)
        {
            CommentChuongDTO cmChuongDto = new CommentChuongDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentChuong Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters["@IDComment"].Value = IDComment;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    cmChuongDto.IDComment = (int)dr["IDCommnet"];
                    cmChuongDto.IDAcc = (string)dr["IDAcc"];
                    cmChuongDto.IDChuong = (int)dr["IDChuong"];
                    cmChuongDto.NoiDung = (string)dr["NoiDung"];
                    cmChuongDto.NgayGio = (DateTime)dr["NgayGio"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return cmChuongDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungChuong!=Null (ham tao) de kiem tra
        }

        //lay danh sach cau hoi Chuong theo IDChuong
        public static ArrayList selectCommentChuongByIDChuong(int IDChuong)
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentChuong where IDChuong = @IDChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDChuong", SqlDbType.Int);
                cmd.Parameters["@IDChuong"].Value = IDChuong;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommentChuongDTO cmChuongDto = new CommentChuongDTO();

                    cmChuongDto.IDComment = (int)dr["IDCommnet"];
                    cmChuongDto.IDAcc = (string)dr["IDAcc"];
                    cmChuongDto.IDChuong = (int)dr["IDChuong"];
                    cmChuongDto.NoiDung = (string)dr["NoiDung"];
                    cmChuongDto.NgayGio = (DateTime)dr["NgayGio"];


                    List.Add(cmChuongDto);
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
