using System;
using System.IO;

namespace Solid.Practice.Utilities
{
    public abstract class Utils
    {
        public string ShowMoney(double money) => $"RD{money.ToString("c")}";
        public string FormatDate(DateTime date) => date.ToShortDateString();
        public void SaveToFile(string directoryPath, string fileName, string content)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), content);
        }
    }
}