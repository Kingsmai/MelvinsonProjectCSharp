using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DailyWorkSummaryEngine.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DailyWorkSummaryEngine.Utils
{
    /// <summary>
    /// 用于处理程序文件的操作。如：创建存档文件等。
    /// </summary>
    public static class SaveFileManager
    {
        // 存档路径
        private static readonly string DirectoryPath = ".\\Data";
        private static readonly string FileName = Utils.GetTodayDate();
        private static readonly string JsonFilePath = $"{DirectoryPath}\\{FileName}.json";
        private static readonly string PublicFilePath = $"{DirectoryPath}\\{FileName}.txt";
        private static readonly string PrivateFilePath = $"{DirectoryPath}\\{FileName}-private.txt";

        /// <summary>
        /// 保存数据
        /// </summary>
        public static void Save(SaveData data)
        {
            // 创建文件夹
            if (!Directory.Exists(DirectoryPath))
            {
                _ = Directory.CreateDirectory(DirectoryPath);
            }

            // 保存JSON文件
            string jsonString = JsonSerializer.Serialize(data);
            CreateFileAndWrite(JsonFilePath, jsonString);

            // 保存共享文件
            CreateFileAndWrite(PublicFilePath, data.PublicTextLog);

            // 保存私享文件
            if (!string.IsNullOrWhiteSpace(data.Note))
            {
                CreateFileAndWrite(PrivateFilePath, data.PrivateTextLog);
            }
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        private static void CreateFileAndWrite(string filePath, string content)
        {
            if (!File.Exists(filePath))
            {
                new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite).Close();
            }
            else
            {
                // TODO: 弹窗表示文件已存在。
                // TODO: 如果不要覆盖，则直接退出此函数
                
            }
            File.WriteAllText(filePath, content);
        }
    }
}
