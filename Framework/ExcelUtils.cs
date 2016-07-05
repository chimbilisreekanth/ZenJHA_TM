using Excel;
using NUnit.Framework;
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
       public DataTable ExcelToDataTable(string fileName,string sheetName)
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
           DataTable resultTable = table[sheetName];

           //return
           return resultTable;
       }

       // Data storing from Excel to Collections
       List<Datacollection> dataCol = new List<Datacollection>();

       public void PopulateInCollection(string fileName,string sheetName)
       {
           DataTable table = ExcelToDataTable(fileName,sheetName);

           //Iterate through the rows and columns of the Table
           for (int row = 0; row < table.Rows.Count; row++)
           {
               for (int col = 0; col < table.Columns.Count; col++)
               {
                   Datacollection dtTable = new Datacollection()
                   {
                       rowNumber = row,
                       colName = table.Columns[col].ColumnName,
                       colValue = table.Rows[row][col].ToString()
                   };
                   //Add all the details for each row
                   dataCol.Add(dtTable);
               }
           }
       }

       //Read the data from collection
       public string ReadData(int rowNumber, string columnName)
       {
           try
           {
               //Retriving Data using LINQ to reduce much of iterations
               string data = (from colData in dataCol
                              where colData.colName == columnName && colData.rowNumber == rowNumber
                              select colData.colValue).SingleOrDefault();

               //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
               return data.ToString();
           }
           catch (Exception e)
           {
               return null;
           }
       }
    }
    // Custom calss
   public class Datacollection
   {
       public int rowNumber { get; set; }
       public string colName { get; set; }
       public string colValue { get; set; }
   }








}
