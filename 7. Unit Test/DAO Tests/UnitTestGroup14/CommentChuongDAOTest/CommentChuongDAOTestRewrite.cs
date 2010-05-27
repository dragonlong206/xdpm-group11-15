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
    public class CommentChuongDAO
    {
        ISqlDataAccessHelper _sqlDataAccessHelper;
        /// <summary>
        /// Creates a new <see cref="CommentChuongDAO"/> instance.
        /// </summary>	
        public CommentChuongDAO(ISqlDataAccessHelper sqlDataAccessHelper)
        {
            //Add your init for this class
            _sqlDataAccessHelper = sqlDataAccessHelper;
        }


        public System.Boolean insertCommentChuong(Dto.CommentChuongDTO cmChuongDto)
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

        public System.Boolean deleteCommentChuong(System.Int32 IDComment)
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

        public System.Boolean updateCommentChuong(Dto.CommentChuongDTO cmChuongDto)
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

        public List<CommentChuongDTO> selectAllCommentChuong()
        {

            List<CommentChuongDTO> result = null;


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

        public Dto.CommentChuongDTO selectCommentChuongByIDComment(System.Int32 IDComment)
        {

            Dto.CommentChuongDTO result = null;


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

        public List<CommentChuongDTO> selectCommentChuongByIDChuong(System.Int32 IDChuong)
        {

            List<CommentChuongDTO> result = null;


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
