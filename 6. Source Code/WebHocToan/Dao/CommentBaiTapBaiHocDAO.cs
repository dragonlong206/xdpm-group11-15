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
    public class CommentBaiTapBaiHocDAO
    {
        public static Boolean insertCommentBaiTapBaiHoc(CommentBaiTapBaiHocDTO cmBTBaiHocDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();

                // B3: Tao chuoi strSQL thao tac CSDL
                //Tam thoi lam the nay, le ra phai dung Store procedure va IDBTBaiHoc auto increament
                //Cai nay se update sau
                string SQLqurey = "insert into CommentBaiTapBaiHoc(IDCommen, IDAcc, IDBTBaiHoc, NoiDung, NgayGio) values (@IDComment, @IDAcc, @IDBTBaiHoc, @NoiDung, @NgayGio)";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters.Add("@IDAcc", SqlDbType.VarChar);
                cmd.Parameters.Add("@IDBTBaiHoc", SqlDbType.Int);
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime);

                cmd.Parameters["@IDComment"].Value = cmBTBaiHocDto.IDComment;
                cmd.Parameters["@IDAcc"].Value = cmBTBaiHocDto.IDAcc;
                cmd.Parameters["@IDBTBaiHoc"].Value = cmBTBaiHocDto.IDBTBaiHoc;
                cmd.Parameters["@NoiDung"].Value = cmBTBaiHocDto.NoiDung;
                cmd.Parameters["NgayGio"].Value = cmBTBaiHocDto.NgayGio;

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

        public static Boolean deleteCommentBaiTapBaiHoc(int IDComment)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "delete from CommentBaiTapBaiHoc Where IDComment = @IDComment";
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

        public static Boolean updateCommentBaiTapBaiHoc(CommentBaiTapBaiHocDTO cmBTBaiHocDto)
        {
            Boolean result = true;
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL

                string SQLqurey = "update CommentBaiTapBaiHoc Set IDAcc = @IDAcc, IDBTBaiHoc = @IDBTBaiHoc, IDNoiDung = @NoiDung, NgayGioi = @NgayGio Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);





                cmd.Parameters.Add("@IDAcc", SqlDbType.VarChar);
                cmd.Parameters.Add("@IDBTBaiHoc", SqlDbType.Int);
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime);
                cmd.Parameters.Add("@IDComment", SqlDbType.Int);


                cmd.Parameters["@IDAcc"].Value = cmBTBaiHocDto.IDAcc;
                cmd.Parameters["@IDBTBaiHoc"].Value = cmBTBaiHocDto.IDBTBaiHoc;
                cmd.Parameters["@NoiDung"].Value = cmBTBaiHocDto.NoiDung;
                cmd.Parameters["NgayGio"].Value = cmBTBaiHocDto.NgayGio;
                cmd.Parameters["@IDComment"].Value = cmBTBaiHocDto.IDComment;


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

        public static ArrayList selectAllCommentBaiTapBaiHoc()
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiTapBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommentBaiTapBaiHocDTO cmBTBaiHocDto = new CommentBaiTapBaiHocDTO();

                    cmBTBaiHocDto.IDComment = (int)dr["IDCommnet"];
                    cmBTBaiHocDto.IDAcc = (string)dr["IDAcc"];
                    cmBTBaiHocDto.IDBTBaiHoc = (int)dr["IDBTBaiHoc"];
                    cmBTBaiHocDto.NoiDung = (string)dr["NoiDung"];
                    cmBTBaiHocDto.NgayGio = (DateTime)dr["NgayGio"];

                    List.Add(cmBTBaiHocDto);
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
        public static CommentBaiTapBaiHocDTO selectCommentBaiTapBaiHocByIDComment(int IDComment)
        {
            CommentBaiTapBaiHocDTO cmBTBaiHocDto = new CommentBaiTapBaiHocDTO();

            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiTapBaiHoc Where IDComment = @IDComment";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDComment", SqlDbType.Int);
                cmd.Parameters["@IDComment"].Value = IDComment;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    cmBTBaiHocDto.IDComment = (int)dr["IDCommnet"];
                    cmBTBaiHocDto.IDAcc = (string)dr["IDAcc"];
                    cmBTBaiHocDto.IDBTBaiHoc = (int)dr["IDBTBaiHoc"];
                    cmBTBaiHocDto.NoiDung = (string)dr["NoiDung"];
                    cmBTBaiHocDto.NgayGio = (DateTime)dr["NgayGio"];
                }
                // B5: Dong ket noi CSDL
                dr.Close();

                // B5: Dong ket noi CSDL
                connection.Close();
            }
            catch (SqlException ex)
            {

            }

            return cmBTBaiHocDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiHoc!=Null (ham tao) de kiem tra
        }

        //lay danh sach cau hoi BaiHoc theo IDBTBaiHoc
        public static ArrayList selectCommentBaiTapBaiHocByIDBTBaiHoc(int IDBTBaiHoc)
        {
            ArrayList List = new ArrayList();
            try
            {
                SqlConnection connection;
                // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
                connection = SqlDataAccessHelper.getConnection();
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiTapBaiHoc where IDBTBaiHoc = @IDBTBaiHoc";
                SqlCommand cmd = new SqlCommand(SQLqurey, connection);

                cmd.Parameters.Add("@IDBTBaiHoc", SqlDbType.Int);
                cmd.Parameters["@IDBTBaiHoc"].Value = IDBTBaiHoc;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommentBaiTapBaiHocDTO cmBTBaiHocDto = new CommentBaiTapBaiHocDTO();

                    cmBTBaiHocDto.IDComment = (int)dr["IDCommnet"];
                    cmBTBaiHocDto.IDAcc = (string)dr["IDAcc"];
                    cmBTBaiHocDto.IDBTBaiHoc = (int)dr["IDBTBaiHoc"];
                    cmBTBaiHocDto.NoiDung = (string)dr["NoiDung"];
                    cmBTBaiHocDto.NgayGio = (DateTime)dr["NgayGio"];


                    List.Add(cmBTBaiHocDto);
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
