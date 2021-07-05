using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyWorkSummaryEngine.Models;
using DailyWorkSummaryEngine.Utils;

namespace DailyWorkSummaryEngine.ViewModels
{

    public class DwsSession
    {

        private SaveData _data;

        public DwsSession()
        {
            _data = new SaveData();
            _data.Username = "群主";
        }

        public void SaveText(Dictionary<string, string> text)
        {
            _data.Summary = text["summary"];
            _data.Plan = text["plan"];
            _data.Note = text["note"];

            SaveFileManager.Save(_data);
        }
    }
}
