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
    public class LoaiAccDAO
    {
        ISqlDataAccessHelper _sqlDataAccessHelper;
        /// <summary>
        /// Creates a new <see cref="LoaiAccDAO"/> instance.
        /// </summary>	
        public LoaiAccDAO(ISqlDataAccessHelper sqlDataAccessHelper)
        {
            //Add your init for this class
            _sqlDataAccessHelper = sqlDataAccessHelper;
        }


        public System.Boolean insertLoaiAcc(Dto.LoaiAccDTO LoaiAccDto)
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

        public System.Boolean deleteLoaiAcc(System.Int32 IDLoaiAcc)
        {

            System.Boolean result = true;


            try
            {

                string sqlQuery = string.Empty;

                List<SqlParameter> sqlParams = new List<SqlParameter>();

                //Todo
                int n = _sqlDataAccessHelper.ExecuteNonQuery(sqlQuery, sqlParams);
                if(n ==  0)
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

        public System.Boolean updateLoaiAcc(Dto.LoaiAccDTO LoaiAccDto)
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

        public List<LoaiAccDTO> selectAllLoaiAcc()
        {

            List<LoaiAccDTO> result = null;


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

        public Dto.LoaiAccDTO selectLoaiAccByIDLoaiAcc(System.Int32 IDLoaiAcc)
        {

            Dto.LoaiAccDTO result = null;


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
