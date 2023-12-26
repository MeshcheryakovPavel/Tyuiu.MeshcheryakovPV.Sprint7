using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;


namespace Tyuiu.MescheryakovPV.Sprint7.V6.Lib
{
    static public class DataService
    {
        static int countRow = 0;
        static public string path = $@"\\Mac\Home\Desktop\Tyuiu.KasenovAE.Sprint7\Tyuiu.KasenovAE.Sprint7.Project.V6\DATA.csv";

        static public DataTable GetData()
        {
            using (DataTable dt = new DataTable())
            {
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                string[] names = lines[0].Split(';');

                if (lines.Length == 1)
                {
                    countRow = 0;
                }

                foreach (string columnName in names)
                {
                    DataColumn col = new DataColumn();
                    col.ColumnName = columnName;

                    dt.Columns.Add(col);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    DataRow row;

                    object[] arr = lines[i].Split(';');

                    row = dt.NewRow();
                    row.ItemArray = arr;
                    dt.Rows.Add(row);
                    countRow = Convert.ToInt32(arr[0]);
                }

                return dt;
            }
        }

        static public bool AddData(string[] arr)
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            foreach (string line in lines)
            {
                bool j = (line.Split(';')[1] == arr[1]) && (line.Split(';')[2] == arr[2]) && (line.Split(';')[3] == arr[3]);

                if (string.IsNullOrEmpty(arr[7]))
                {
                    break;
                }

                if (line.Split(';')[7] == arr[7] || j)
                {
                    return false;
                }
            }

            arr[0] = Convert.ToString(countRow + 1);
            string newLine = $"{arr[0]};{arr[1]};{arr[2]};{arr[3]};{arr[4]};{arr[5]};{arr[6]};{arr[7]}";
            newLine += Environment.NewLine;
            File.AppendAllText(path, newLine, Encoding.UTF8);

            return true;
        }

        static public void DeleteData(string id)
        {

            string[] lines = File.ReadAllLines(path);
            string cstr = "";
            foreach (string line in lines)
            {
                string[] words = line.Split(';');
                if (words[0] == id)
                {
                    cstr = line;
                    break;
                }
            }
            File.WriteAllLines(path, lines.Where(val => val != cstr));
        }

        static public bool DataIsValid(string newPth)
        {
            string[] lines = File.ReadAllLines(newPth, Encoding.UTF8);
            if (lines[0] == "id;Имя;Фамилия;Отчество;Возраст;Диагноз;Лечащий врач;Номер телефона")
                return true;
            return false;
        }

        static public void ChangeData(string id, string[] content)
        {
            DataTable dt = GetData();
            string[] names = { "Имя", "Фамилия", "Отчество", "Возраст", "Диагноз", "Лечащий врач", "Номер телефона" };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].ItemArray[0].ToString() == id)
                {
                    for (int j = 0; j < content.Length; j++)
                    {
                        if (String.IsNullOrEmpty(content[j]))
                            continue;
                        dt.Rows[i][names[j]] = content[j];
                    }
                    SaveData(dt);
                    break;
                }
            }
        }

        static public void SaveData(DataTable dt)
        {
            string b = "";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                b += dt.Columns[i].ColumnName;
                if (i != dt.Columns.Count - 1)
                    b += ';';
            }
            b += Environment.NewLine;

            File.WriteAllText(path, b, Encoding.UTF8);

            foreach (DataRow row in dt.Rows)
            {
                string ln = "";
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    ln += row.ItemArray[i];
                    if (i != row.ItemArray.Length - 1)
                        ln += ';';
                }
                ln += Environment.NewLine;
                File.AppendAllText(path, ln, Encoding.UTF8);
            }
        }

        static public int StatFrequencyWord(string word, string columnName)
        {
            DataTable dt = GetData();
            int c = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToString(row[columnName]) == word)
                    c++;
            }

            return c;
        }

        static public List<string> UniqueWords(string columnName)
        {
            List<string> words = new List<string>();

            DataTable dt = GetData();
            foreach (DataRow row in dt.Rows)
            {
                if (!words.Contains(Convert.ToString(row[columnName])))
                    words.Add(Convert.ToString(row[columnName]));
            }

            return words;
        }
    }
}
