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
    public class MonHocDAO
    {
        ISqlDataAccessHelper _sqlDataAccessHelper;
        /// <summary>
        /// Creates a new <see cref="MonHocDAO"/> instance.
        /// </summary>	
        public MonHocDAO(ISqlDataAccessHelper sqlDataAccessHelper)
        {
            //Add your init for this class
            _sqlDataAccessHelper = sqlDataAccessHelper;
        }


        public System.Boolean insertMonHoc(Dto.MonHocDTO MonHocDto)
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

        public System.Boolean deleteMonHoc(System.Int32 IDMonHoc)
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

        public System.Boolean updateMonHoc(Dto.MonHocDTO MonHocDto)
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

        public List<MonHocDTO> selectAllMonHoc()
        {

            List<MonHocDTO> result = null;


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

        public Dto.MonHocDTO selectMonHocByIDMonHoc(System.Int32 IDMonHoc)
        {

            Dto.MonHocDTO result = null;


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
