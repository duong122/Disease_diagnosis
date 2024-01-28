using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanDoanBenh
{
    internal class BackWardChaining
    {
        KetNoi ketNoi = new KetNoi();
        // Danh sách các triệu chứng của bệnh nhân
        private List<int> symptoms = new List<int>();

        // Gán danh sach triệu chứng xuất hiện ở người bệnh ở ListView Phải vào List symptoms
        public BackWardChaining(List<int> symptom_list)
        {
            symptoms = symptom_list;
        }

        // ham dung de kiem tra lieu co lay duoc cac trieu chung tu listViewRight khong
        public void PrintSymptoms()
        {
            foreach (int symptom in symptoms)
            {
                Debug.WriteLine(symptom);
            }
        }

        // ham dung de kiem tra xem lieu mot chi so cua mot trieu chung co ton tai trong danh sach cac trieu chung duoc truyen hay khong
        public bool checkExist(List<int> symptom_index, int number_need_to_check)
        {
            foreach (int index in symptom_index)
            {
                if (index == number_need_to_check) return true;
            }
            return false;
        }

        // ham dung de chuyen doi mot mang cac string sang mot list<int>
        public List<int> Converter(string[] words)
        {
            List<int> temp = new List<int>();
            foreach (string word in words)
            {
                int interger_number = int.Parse(word);
                temp.Add(interger_number);
            }
            /*
            Debug.WriteLine("Gia tri sau khi lay duoc tu antecedent_list ra la");
            foreach(int value in temp)
            {
                Debug.WriteLine(value);
            }
            */
            return temp;
        }

        public string MainProcess()
        {
            BackWard_Knowledge_base kb = new BackWard_Knowledge_base();
            kb.CreateKnowledgeBase();
            DataTable dt = kb.GetDataTable();
            int result = 0;
            int rule_number = 1;
            char[] delimter = { ',' };

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // ban dau ta gan result bang 1 de bieu thi rang day la mot luat dung cho den khi ta chung minh no sai
                result = 1;

                // lay ra chi so cua luat de xu ly
                rule_number = Convert.ToInt32(dt.Rows[i]["rule_id"]);

                // lay ra cac trieu chung tham gia vao luat do trong truong antecedent va chuyen doi tu string thanh mot list<int>
                string symptom_antecedent = (dt.Rows[i]["antecedent"]).ToString();
                string[] words = symptom_antecedent.Split(delimter, StringSplitOptions.RemoveEmptyEntries);
                List<int> symptom_antecedent_list = Converter(words);

                /*
                  Ta chung minh luat do sai bang cach kiem tra xem lieu co su thieu vang  trieu chung nao cua
                    symptom_antecedent_list trong symptoms list hay khong (du lieu lay duoc tu lsvRight)
                    - neu co tuc la luat do khong hop le va ta se chuyen qua luat tiep theo
                    - neu luat do hop le tuc la cac trieu chung deu co du thi ta dung luon ca vong lap lap va di den ket luan
                      benh tuong ung voi luat do
                */

                foreach (int value in symptom_antecedent_list)
                {
                    if (!checkExist(symptoms, value))
                    {
                        result = 0;
                        break;
                    }
                }

                if (result == 1)
                {
                    break;
                }
            }

            /*
              Tai day ta co hai truong hop thoat vong for lon mot la ta da tim duoc benh tuong ung voi cac trieu chung
                hai la chung ta da duyet het luat ma khong tim ra duoc benh duoc bieu dien bang gia tri cua bien result
                - result = 1 thi ta tim duoc benh
                - result = 0 da duyet het luat nhung khong tim ra benh
             */

            if (result == 1 & (rule_number <= dt.Rows.Count))
            {
                string query = "select Disease.name from Disease, InferenceRule where Disease.disease_id = InferenceRule.disease_id and rule_id = " + rule_number.ToString();
                DataSet ds = ketNoi.LayDuLieu(query);
                return ds.Tables[0].Rows[0]["name"].ToString();
            }

            return "Diagnosis is not possible at this time. Please Try again";
        }
    }
}