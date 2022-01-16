using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames_Team9
{
    class LoadData
    {
        //Properties
        public List<int> scores = new List<int>();      //Lưu điểm
        public List<double> times = new List<double>(); //Lưu thời gian tương ứng với điểm
        //Method
        //Hàm load điểm
        public void LoadScore(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string value = "";
            do
            {
                value = sr.ReadLine();
                if (value != null)
                {
                    string[] arrList = value.Split('-');
                    scores.Add(Convert.ToInt32(arrList[0]));
                    times.Add(Convert.ToDouble(arrList[1]));
                }
            } while (value != null);
            DoSort();
            sr.Close();
        }
        //Hàm sắp xếp điểm và thời gian
        private void DoSort()
        {
            for (int i = 0; i < scores.Count - 1; i++)
                for (int j = i + 1; j < scores.Count; j++)
                {
                    if (scores[i] > scores[j])
                    {
                        int temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                        double temp2 = times[i];
                        times[i] = times[j];
                        times[j] = temp2;
                    }
                }
        }
        //Hàm save điểm
        private void SaveScore(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            for (int i = 0; i < scores.Count; i++)
            {
                sw.WriteLine(scores[i] + "-" + times[i]);
            }
            sw.Close();
        }
        //Hàm kiểm tra xem điểm của người chơi có nằm trong top 4 không, có thì lưu lại
        public void UpdateScore(int score, double clock)
        {
            if (score > scores[0] || (score == scores[0] && times[0] < clock))
            {
                scores[0] = score;
                times[0] = clock;
            }
            DoSort();
            SaveScore("input.txt");
        }
    }
}
