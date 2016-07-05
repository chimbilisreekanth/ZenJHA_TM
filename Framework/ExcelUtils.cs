using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
   public class ExcelUtils
    {
       //Parsing data from xlsx file
       public DataTable ExcelToDataTable(string fileName)
       {
           //open file and returns as Stream
           FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
           //Createopenxmlreader via ExcelReaderFactory
           IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx  ---CreateBinaryReader for .xlx file
           //Set the First Row as Column Name
           excelReader.IsFirstRowAsColumnNames = true;
           //Return as DataSet
           DataSet result = excelReader.AsDataSet();
           //Get all the Tables
           DataTableCollection table = result.Tables;
           //Store it in DataTable
           DataTable resultTable = table["Sheet1"];

           //return
           return resultTable;
       }
    }
}
