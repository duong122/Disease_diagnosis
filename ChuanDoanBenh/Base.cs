using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanDoanBenh
{
    internal class Base
    {
        public void DefineDataGridViewColumns(DataGridView dgv, string[] headers, string[] dataProperties, int[] columnWidths)
        {
            if (headers.Length != dataProperties.Length || headers.Length != columnWidths.Length) return;
            dgv.Columns.Clear();
            for (int i = 0; i < headers.Length; i++)
            {
                string headerText = headers[i];
                string dataPropertyName = dataProperties[i];
                int width = columnWidths[i];
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    HeaderText = headerText,
                    DataPropertyName = dataPropertyName,
                    Width = width,
                };
                dgv.Columns.Add(column);
            }
        }
    }
}
