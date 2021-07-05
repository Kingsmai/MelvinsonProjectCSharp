using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyWorkSummaryEngine.Utils;

namespace DailyWorkSummaryEngine.Models
{
    public class SaveData
    {
        public DateTimeOffset Date { get; set; }

        public string Summary { get; set; }
        public string Plan { get; set; }
        public string Note { get; set; }

        #region 模板文字
        private readonly string _logHeader;
        private readonly string _logFooter;
        private readonly string _planningHeader;
        private readonly string _noteHeader;
        #endregion

        #region 用户信息
        public string Username { get; set; }
        public string Signature { get; set; }
        #endregion

        public SaveData()
        {
            DateTime now = DateTime.Now;
            _logHeader += Username;
            _logHeader += now.ToString("yyyy年MM月dd日学习记录\n");
            _logHeader += "---------------------\n";

            _logFooter += "\n\n\t\tXiaomai\n";
            _logFooter += $"\t\t{Utils.Utils.GetTodayDate()}\n";

            _planningHeader += "\n=====================\n";
            _planningHeader += "计划中：\n";
            _planningHeader += "---------------------\n";

            _noteHeader += "\n=====================\n";
            _noteHeader += "笔记：\n";
            _noteHeader += "---------------------\n";
        }

        /// <summary>
        /// 共享信息文本
        /// </summary>
        public string PublicTextLog
        {
            get
            {
                string log = _logHeader;
                log += Summary + "\n";

                if (!string.IsNullOrWhiteSpace(Plan))
                {
                    log += _planningHeader;
                    log += Plan + "\n";
                }

                log += _logFooter;

                return log;
            }
        }

        /// <summary>
        /// 私有信息文本
        /// </summary>
        public string PrivateTextLog
        {
            get
            {
                string log = _logHeader;
                log += Summary + "\n";

                if (!string.IsNullOrWhiteSpace(Plan))
                {
                    log += _planningHeader;
                    log += Plan + "\n";
                }

                if (!string.IsNullOrWhiteSpace(Note))
                {
                    log += _noteHeader;
                    log += Note + "\n";
                }

                log += _logFooter;

                return log;
            }
        }
    }
}
