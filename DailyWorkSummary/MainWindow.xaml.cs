using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DailyWorkSummary.Utils;
using DailyWorkSummaryEngine.ViewModels;
using DailyWorkSummaryEngine.Utils;
using System.IO;

namespace DailyWorkSummary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DwsSession _dwsSession;

        public MainWindow()
        {
            _dwsSession = new DwsSession();

            InitializeComponent();
            InitializeClickEvents();
        }

        private void InitializeClickEvents()
        {
            // 保存文件按钮
            save_btn.Click += (s, e) =>
            {
                Dictionary<string, string> texts = new Dictionary<string, string>();
                texts.Add("summary", Summary.getContentAsString());
                texts.Add("plan", Planning.getContentAsString());
                texts.Add("note", Notes.getContentAsString());
                _dwsSession.SaveText(texts);
            };

            // 读取文件按钮
            load_btn.Click += (s, e) =>
            {
            };

            // 退出程序按钮
            close_btn.Click += (s, e) =>
            {
                Application.Current.Shutdown();
            };
        }

        // 判断是否需要覆盖文件
        private void overwriteDialog(string fileName)
        {
            MessageBoxResult result = MessageBox.Show(
                        $"File {fileName} already exists, are you sure you want to overwrite it?\n" +
                        $"文件 {fileName} 已经存在，是否覆盖文档？",
                        "File Already Exists 文件已存在",
                        MessageBoxButton.OKCancel,
                        MessageBoxImage.Exclamation
                    );
            if (result == MessageBoxResult.Cancel)
            {
                return;
            }
        }
    }
}
