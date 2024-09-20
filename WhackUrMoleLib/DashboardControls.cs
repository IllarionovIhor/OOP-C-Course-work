using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WhackUrMoleLib
{
    public class DashboardControls
    {
        public List<User> users = new List<User>();
        public DataGridView table;
        public string RecordPath = Application.StartupPath + "\\Records.txt";

        public static string CryptingStoryKey = "gE2V10LrDNoFwTPPwas9Gtac4LrjC9EBgcwHr6IK5bUYF8AlElEQxKno5mXkLAfv";
        public static byte[] Crypt(byte[] fileBytes, string key)
        {
            var keyBytes = Encoding.UTF8.GetBytes(key);
            var result = new byte[fileBytes.Length];
            for (var i = 0; i < fileBytes.Length; i += 1)
                result[i] = (byte)(fileBytes[i] ^ keyBytes[i % keyBytes.Length]);
            return result;
        }

        public List<string> readCrypted()
        {
            var decrypted = Crypt(File.ReadAllBytes(RecordPath), CryptingStoryKey);
            string text = Encoding.UTF8.GetString(decrypted);
            //MessageBox.Show(text);
            string[] splitText = text.Split('|');
            var result = splitText.ToList();
            // the text.split leaves an empty list item, 
            // so we remove it here
            result.RemoveAt(result.Count-1);
            return result;
        }

        public void writeCrypted(List<string> lines)
        {
            string text = String.Join("|", lines.ToArray());
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] cryptedBytes = Crypt(bytes, CryptingStoryKey);
            File.WriteAllBytes(RecordPath, cryptedBytes);

        }
        




        public void AddRecord(User user)
        {
            //StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Records\\Records.txt");
            //sw.WriteLine("");
            if (!File.Exists(RecordPath))
            {
                string[] safetyMeasure = { user.ToString() };
                writeCrypted(safetyMeasure.ToList());
            }
            else
            {
                List<string> lines = readCrypted();

                lines.Add(user.ToString());

                writeCrypted(lines);
            }


        }

        public void showTableRecords(DataGridView table) {
            //List<string> lines = File.ReadAllLines(RecordPath).ToList();
            List<string> lines = readCrypted();
            foreach (string line in lines)
            {
                line.Trim();
                string username = line.Split(',')[0];
                string score = line.Split(',')[1];
                string difficulty = line.Split(',')[2];
                User dude = new User(username, score, difficulty);
                users.Add(dude);
            }
            List<User> SortedUsers = users.OrderByDescending(o => Int32.Parse(o.score)).ToList();

            foreach (User user in SortedUsers)
            {
                table.Rows.Add(user.username, user.score, user.difficulty);
            }

        }
    }


}
