using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace ChuanDoanBenh
{
    internal class BackWard_Knowledge_base
    {
        // lay du lieu tu bang inference_rue trong co so du lieu de xu ly
        private KetNoi ketNoi = new KetNoi();
        private DataSet ds = new DataSet();
        private DataTable dataTable = new DataTable();
        public void CreateKnowledgeBase()
        {
            string query = "select rule_id, antecedent, disease_id from InferenceRule";
            ds = ketNoi.LayDuLieu(query);
            dataTable = ds.Tables[0];

        }

        public DataTable GetDataTable() { return dataTable; }

    }
}
