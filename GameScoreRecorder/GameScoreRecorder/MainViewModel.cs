using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace GameScoreRecorder
{
    class MainViewModel : NotifyPropertyChangedObject
    {
        #region 私有字段

        #endregion

        #region 构造函数

        public MainViewModel()
        {
            Initialize();
            NewCommand = new DelegateCommand(() => { Initialize(); });
            ClickedCommand = new DelegateCommand(OnItemClicked);
        }

        #endregion

        #region 公开属性


        #endregion

        #region 命令

        public ICommand NewCommand { get; set; }

        public ICommand ClickedCommand { get; set; }

        #endregion

        #region 命令处理方法

        private void OnItemClicked()
        {
        }

        #endregion

        #region 私有方法

        private void Initialize()
        {
        }

        #endregion
    }
}
