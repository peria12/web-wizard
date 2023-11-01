using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Franklin_Templeton_DAL.Helpers
{
    internal static class UiHelper
    {
        /// <summary>
        /// Generate a dialog box for getting user conformation for deleting an entity
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Will be true if the user answer is Yes</returns>
        public static bool GetDeleteConformation(string name = "")
        {
            var dialogResult = MessageBox.Show($"Are you sure you want to delete this {name}?", "Confirm", MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }

        /// <summary>
        /// Provides an input that allows a user select values from Excel. Will skip null and empty values
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static List<object> GetCellRange(string title)
        {
            try
            {
                var inputResult = Globals.ThisAddIn.Application.InputBox(title, Title: "Range Selector", Type: 8);
                
                if (typeof(bool) == inputResult.GetType() && inputResult == false)
                {
                    return null;
                }

                var result = new List<object>();
                var cellvalues = (Array)((Range)inputResult).Cells.Value;
                foreach (var cellVal in cellvalues)
                {
                    if (cellVal != null)
                    {
                        result.Add(cellVal);
                    }
                }
                return result;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
