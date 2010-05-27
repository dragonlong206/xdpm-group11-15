using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using Dto;
using System.Collections;


namespace UnitTestGroup14
{
    public class CommentBaiHocDAO
    {
        private ISqlDataAccessHelper _sqlDataAccessHelper;

        public CommentBaiHocDAO(ISqlDataAccessHelper sqlDataAccessHelper)
        {
            _sqlDataAccessHelper = sqlDataAccessHelper;
        }

        public Boolean insertCommentBaiHoc(CommentBaiHocDTO cmBaiHocDto)
        {
            Boolean result = true;
            try
            {
                string SQLqurey = "insert into CommentBaiHoc(IDCommen, IDAcc, IDBaiHoc, NoiDung, NgayGio) values (@IDComment, @IDAcc, @IDBaiHoc, @NoiDung, @NgayGio)";

                List<SqlParameter> sqlParams = new List<SqlParameter>();
                //Add paramter here

                int n = _sqlDataAccessHelper.ExecuteNonQuery(SQLqurey, sqlParams);
                if (n == 0)
                {
                    result = false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return result;
        }

        public  Boolean deleteCommentBaiHoc(int IDComment)
        {
            Boolean result = true;
            try
            {
                string SQLqurey = "delete from CommentBaiHoc Where IDComment = @IDComment";
                List<SqlParameter> sqlParams = new List<SqlParameter>();

                int n = _sqlDataAccessHelper.ExecuteNonQuery(SQLqurey,sqlParams);
                if (n == 0)
                {
                    result = false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return result;
        }

        public  Boolean updateCommentBaiHoc(CommentBaiHocDTO cmBaiHocDto)
        {
            Boolean result = true;
            try
            {
                string SQLqurey = "update CommentBaiHoc Set IDAcc = @IDAcc, IDBaiHoc = @IDBaiHoc, IDNoiDung = @NoiDung, NgayGioi = @NgayGio Where IDComment = @IDComment";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                int n = _sqlDataAccessHelper.ExecuteNonQuery(SQLqurey, sqlParams);
                if (n == 0)
                {
                    result = false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return result;

        }

        public List<CommentBaiHocDTO> selectAllCommentBaiHoc()
        {
            List<CommentBaiHocDTO> List = null;
            try
            {
                string SQLqurey = "Select * from CommentBaiHoc";
                DataTable dt = _sqlDataAccessHelper.ExecuteQuery(SQLqurey);
                if(dt != null)
                {
                    //Todo
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return List;
        }

        //lay Comment theo loai IDComment
        public  CommentBaiHocDTO selectCommentBaiHocByIDComment(int IDComment)
        {
            CommentBaiHocDTO cmBaiHocDto = null;

            try
            {
                // B3: Tao chuoi strSQL thao tac CSDL
                string SQLqurey = "Select * from CommentBaiHoc Where IDComment = @IDComment";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                DataTable dt = _sqlDataAccessHelper.ExecuteQuery(SQLqurey, sqlParams);
                if(dt != null)
                {
                    //Todo
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return cmBaiHocDto;
            //Khi lap trinh chung ta kiem tra co duoc thay du lieu hay khong bang cach 
            // So sanh neu ID != 0 hay NoiDungBaiHoc!=Null (ham tao) de kiem tra
        }

        //lay danh sach cau hoi BaiHoc theo IDBaiHoc
        public  List<CommentBaiHocDTO> selectCommentBaiHocByIDBaiHoc(int IDBaiHoc)
        {
            List<CommentBaiHocDTO> List = null;
            try
            {
                string SQLqurey = "Select * from CommentBaiHoc where IDBaiHoc = @IDBaiHoc";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                DataTable dt = _sqlDataAccessHelper.ExecuteQuery(SQLqurey, sqlParams);
                if(dt != null)
                {
                    //Todo
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return List;
        }

    }
}
