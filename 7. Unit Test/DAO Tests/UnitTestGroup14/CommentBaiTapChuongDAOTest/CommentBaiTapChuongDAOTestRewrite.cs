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
    public class CommentBaiTapChuongDAO
    {
        ISqlDataAccessHelper _sqlDataAccessHelper;
        /// <summary>
        /// Creates a new <see cref="CommentBaiTapChuongDAO"/> instance.
        /// </summary>	
        public CommentBaiTapChuongDAO(ISqlDataAccessHelper sqlDataAccessHelper)
        {
            //Add your init for this class
            _sqlDataAccessHelper = sqlDataAccessHelper;
        }


        public System.Boolean insertCommentBaiTapChuong(Dto.CommentBaiTapChuongDTO cmBTChuongDto)
        {

            System.Boolean result = true;


            try
            {

                string sqlQuery = string.Empty;

                List<SqlParameter> sqlParams = new List<SqlParameter>();

                //Todo
                int n = _sqlDataAccessHelper.ExecuteNonQuery(sqlQuery, sqlParams);
                if(n == 0)
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;

        }

        public System.Boolean deleteCommentBaiTapChuong(System.Int32 IDComment)
        {

            System.Boolean result = true;


            try
            {

                string sqlQuery = string.Empty;

                List<SqlParameter> sqlParams = new List<SqlParameter>();

                //Todo
                int n = _sqlDataAccessHelper.ExecuteNonQuery(sqlQuery, sqlParams);
                if(n == 0)
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;

        }

        public System.Boolean updateCommentBaiTapChuong(Dto.CommentBaiTapChuongDTO cmBTChuongDto)
        {

            System.Boolean result = true;


            try
            {

                string sqlQuery = string.Empty;

                List<SqlParameter> sqlParams = new List<SqlParameter>();

                //Todo
                int n = _sqlDataAccessHelper.ExecuteNonQuery(sqlQuery, sqlParams);
                if(n == 0)
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;

        }

        public List<CommentBaiTapChuongDTO> selectAllCommentBaiTapChuong()
        {

            List<CommentBaiTapChuongDTO> result = null;


            try
            {

                string sqlQuery = string.Empty;

                //Todo
                DataTable dt = _sqlDataAccessHelper.ExecuteQuery(sqlQuery);
                if(dt != null)
                {
                    //Todo
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;

        }

        public Dto.CommentBaiTapChuongDTO selectCommentBaiTapChuongByIDComment(System.Int32 IDComment)
        {

            Dto.CommentBaiTapChuongDTO result = null;


            try
            {

                string sqlQuery = string.Empty;

                List<SqlParameter> sqlParams = new List<SqlParameter>();

                //Todo
                DataTable dt = _sqlDataAccessHelper.ExecuteQuery(sqlQuery, sqlParams);
                if(dt != null)
                {
                    //Todo
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;

        }

        public List<CommentBaiTapChuongDTO> selectCommentBaiTapChuongByIDBTChuong(System.Int32 IDBTChuong)
        {

            List<CommentBaiTapChuongDTO> result = null;


            try
            {

                string sqlQuery = string.Empty;

                List<SqlParameter> sqlParams = new List<SqlParameter>();

                //Todo
                DataTable dt = _sqlDataAccessHelper.ExecuteQuery(sqlQuery, sqlParams);
                if(dt != null)
                {
                    //Todo
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;

        }

    }
}
