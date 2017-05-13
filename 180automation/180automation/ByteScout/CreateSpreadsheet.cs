﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bytescout.Spreadsheet;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace _180automation.ByteScout
{
    class CreateSpreadsheet
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // add new worksheet
            Worksheet Sheet = document.Workbook.Worksheets.Add("FormulaDemo");

            // headers to indicate purpose of the column
            Sheet.Cell("A1").Value = "Formula (as text)";
            // set A column width
            Sheet.Columns[0].Width = 250;

            Sheet.Cell("B1").Value = "Formula (calculated)";
            // set B column width
            Sheet.Columns[1].Width = 250;


            // write formula as text 
            Sheet.Cell("A2").Value = "7*3+2";
            // write formula as formula
            Sheet.Cell("B2").Value = "=7*3+2";

            // delete output file if exists already
            if (File.Exists("Output.xls"))
            {
                File.Delete("Output.xls");
            }

            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open generated XLS document in default program
            Process.Start("Output.xls");
        }
    }
}
