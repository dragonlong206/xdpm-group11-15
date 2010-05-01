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
    public class CommentBaiTapChuongDAO
    {
        public static Boolean insertCommentBaiTapChuong(CommentBaiTapChuongDTO cmBTChuongDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();

                // B3: Tao chuoi strSQL thao tac CSDL
                //Tam thoi lam the nay, le ra phai dung Store procedure va IDBTChuong auto increament
                //Cai nay se update sau
                string SQLqurey = "insert into CommentBaiTapChuong(IDCommen, IDAcc, IDBTChuong, NoiDung, NgayGio) values (@IDComment, @IDAcc, @IDBTChuong, @NoiDung, @NgayGio)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters.Add("@IDAcc", SqlDbType.VarChar);
                cmd.Parameters.Add("@IDBTChuong", SqlDbType.Int);
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime);

                cmd.Parameters["@IDComment"].Value = cmBTChuongDto.IDComment;
                cmd.Parameters["@IDAcc"].Value = cmBTChuongDto.IDAcc;
                cmd.Parameters["@IDBTChuong"].Value = cmBTChuongDto.IDBTChuong;
                cmd.Parameters["@NoiDung"].Value = cmBTChuongDto.NoiDung;
                cmd.Parameters["NgayGio"].Value = cmBTChuongDto.NgayGio;

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

        public static Boolean deleteCommentBaiTapChuong(int IDComment)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from CommentBaiTapChuong Where IDComment = @IDComment";
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

        public static Boolean updateCommentBaiTapChuong(CommentBaiTapChuongDTO cmBTChuongDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update CommentBaiTapChuong Set IDAcc = @IDAcc, IDBTChuong = @IDBTChuong, IDNoiDung = @NoiDung, NgayGioi = @NgayGio Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);





                cmd.Parameters.Add("@IDAcc", SqlDbType.VarChar);
                cmd.Parameters.Add("@IDBTChuong", SqlDbType.Int);
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime);
                cmd.Parameters.Add("@IDComment", SqlDbType.Int);


                cmd.Parameters["@IDAcc"].Value = cmBTChuongDto.IDAcc;
                cmd.Parameters["@IDBTChuong"].Value = cmBTChuongDto.IDBTChuong;
                cmd.Parameters["@NoiDung"].Value = cmBTChuongDto.NoiDung;
                cmd.Parameters["NgayGio"].Value = cmBTChuongDto.NgayGio;
                cmd.Parameters["@IDComment"].Value = cmBTChuongDto.IDComment;


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

        public static ArrayList selectAllCommentBaiTapChuong()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiTapChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommentBaiTapChuongDTO cmBTChuongDto = new CommentBaiTapChuongDTO();

                    cmBTChuongDto.IDComment = (int)dr["IDCommnet"];
                    cmBTChuongDto.IDAcc = (string)dr["IDAcc"];
                    cmBTChuongDto.IDBTChuong = (int)dr["IDBTChuong"];
                    cmBTChuongDto.NoiDung = (string)dr["NoiDung"];
                    cmBTChuongDto.NgayGio = (DateTime)dr["NgayGio"];

                    List.Add(cmBTChuongDto);
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
        public static CommentBaiTapChuongDTO selectCommentBaiTapChuongByIDComment(int IDComment)
        {
            CommentBaiTapChuongDTO cmBTChuongDto = new CommentBaiTapChuongDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiTapChuong Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters["@IDComment"].Value = IDComment;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    cmBTChuongDto.IDComment = (int)dr["IDCommnet"];
                    cmBTChuongDto.IDAcc = (string)dr["IDAcc"];
                    cmBTChuongDto.IDBTChuong = (int)dr["IDBTChuong"];
                    cmBTChuongDto.NoiDung = (string)dr["NoiDung"];
                    cmBTChuongDto.NgayGio = (DateTime)dr["NgayGio"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return cmBTChuongDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungChuong!=Null (ham tao) de kiem tra
        }

        //lay danh sach cau hoi Chuong theo IDBTChuong
        public static ArrayList selectCommentBaiTapChuongByIDBTChuong(int IDBTChuong)
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiTapChuong where IDBTChuong = @IDBTChuong";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBTChuong", SqlDbType.Int);
                cmd.Parameters["@IDBTChuong"].Value = IDBTChuong;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommentBaiTapChuongDTO cmBTChuongDto = new CommentBaiTapChuongDTO();

                    cmBTChuongDto.IDComment = (int)dr["IDCommnet"];
                    cmBTChuongDto.IDAcc = (string)dr["IDAcc"];
                    cmBTChuongDto.IDBTChuong = (int)dr["IDBTChuong"];
                    cmBTChuongDto.NoiDung = (string)dr["NoiDung"];
                    cmBTChuongDto.NgayGio = (DateTime)dr["NgayGio"];


                    List.Add(cmBTChuongDto);
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
