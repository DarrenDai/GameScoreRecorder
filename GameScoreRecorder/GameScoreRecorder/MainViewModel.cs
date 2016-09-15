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
    public class MainViewModel : NotifyPropertyChangedObject
    {
        #region Private fields

        private GameInfo _gameInfo = new GameInfo() { StartTime = DateTime.Now };
        private ObservableCollection<GameInfo> _historyList = new ObservableCollection<GameInfo>();

        #endregion

        #region Constructor

        public MainViewModel()
        {
            Initialize();
        }

        #endregion

        #region Public properties

        public GameInfo GameInfo
        {
            get { return _gameInfo; }
            set
            {
                _gameInfo = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<GameInfo> HistoryList
        {
            get { return _historyList; }
            set { _historyList = value; }
        }

        #endregion

        #region Commands

        public ICommand NewCommand { get; set; }
        public ICommand DoubleCommand { get; set; }
        public ICommand DecreaseCommand { get; set; }
        public ICommand StartCommand { get; set; }
        public ICommand EndCommand { get; set; }

        #endregion

        #region Command handler


        #endregion

        #region Private methods

        private void Initialize()
        {
            InitialiseCommands();
            _gameInfo.UserA.IsBoss = true;
        }

        private void InitialiseCommands()
        {
            NewCommand = new DelegateCommand(() => { Initialize(); });
            DoubleCommand = new DelegateCommand(() =>
            {
                GameInfo.Times = GameInfo.Times * 2;
            });
            DecreaseCommand = new DelegateCommand(() =>
            {
                if (GameInfo.Times == 1)
                    return;

                GameInfo.Times = GameInfo.Times / 2;
            });
            StartCommand = new DelegateCommand(() =>
            {
                StartAGame();
            });
            EndCommand = new DelegateCommand<object>((obj) =>
            {
                GameInfo.EndTime = DateTime.Now;
                GameInfo.No = HistoryList.Count + 1;
                GameInfo.SetWinner(int.Parse(obj.ToString()));

                HistoryList.Add(GameInfo.Clone() as GameInfo);
                StartAGame();
            });
        }

        private void StartAGame()
        {
            GameInfo.StartTime = DateTime.Now;
        }

        #endregion
    }
}
