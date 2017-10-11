using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace MDRegTool
{
    public class ImportRegFromExcel
    {
        public ImportRegFromExcel(string _excelPath)
        {
            //this.strExcelPath = _excelPath;
            strExcelPath = _excelPath;
        }

        #region Params
        string strExcelPath = System.IO.Directory.GetCurrentDirectory();
        #endregion Params

        #region Funcs
        public DataSet ImportExcel()
        {
            try
            {
                DataTable dtExcel = new DataTable();
                //数据表
                DataSet ds = new DataSet();
                //获取文件扩展名
                string strExtension = System.IO.Path.GetExtension(strExcelPath);
                string strFileName = System.IO.Path.GetFileName(strExcelPath);
                //Excel的连接
                OleDbConnection objConn = null;
                switch (strExtension)
                {
                    case ".xls":
                        objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                            strExcelPath + ";" + "Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                        break;
                    case ".xlsx":
                        objConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            strExcelPath + ";" + "Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
                        break;
                    default:
                        objConn = null;
                        break;
                }

                if (objConn == null)
                {
                    return null;
                }
                objConn.Open();

                // Get all sheet name in the excel                
                ArrayList result = new ArrayList { };
                DataTable sheetNames = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                foreach (DataRow dr in sheetNames.Rows)
                {
                    result.Add(dr[2]);
                }

                // Get all datatable from each sheet and add to ds.
                ds.Clear();
                string strSql;
                foreach (string tName in result)
                {
                    strSql = "select * from [" + tName + "]";
                    OleDbCommand objCmd = new OleDbCommand(strSql, objConn);
                    OleDbDataAdapter myData = new OleDbDataAdapter(strSql, objConn);
                    myData.Fill(ds, tName);//填充数据
                }
                objConn.Close();

                return ds;
            }
            catch { return null; }
        }


        #endregion Funcs



    }
}
