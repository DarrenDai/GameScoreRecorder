using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreRecorder
{
    public class GameInfo : NotifyPropertyChangedObject, ICloneable
    {
        #region Private fields

        private int _basicScore = 1;
        private int _times = 1;
        private DateTime _startTime;
        private DateTime _endTime;
        private int _no;
        private Person _userA = new Person() { Name = "A:孙悟空" };
        private Person _userB = new Person() { Name = "B:猪八戒" };
        private Person _userC = new Person() { Name = "C:唐曾" };

        #endregion

        #region Constructor

        public GameInfo()
        {

        }

        #endregion

        #region Public Properties

        public int No
        {
            get { return _no; }
            set
            {
                _no = value;
                OnPropertyChanged();
            }
        }

        public int BasicScore
        {
            get { return _basicScore; }
            set
            {
                _basicScore = value;
                OnPropertyChanged();
            }
        }

        public int Times
        {
            get { return _times; }
            set
            {
                _times = value;
                OnPropertyChanged();
            }
        }

        public DateTime StartTime
        {
            get { return _startTime; }
            set
            {
                _startTime = value;
                OnPropertyChanged();
            }
        }

        public Person UserA
        {
            get { return _userA; }
            set
            {
                _userA = value;
                OnPropertyChanged();
            }
        }

        public Person UserB
        {
            get { return _userB; }
            set
            {
                _userB = value;
                OnPropertyChanged();
            }
        }

        public Person UserC
        {
            get { return _userC; }
            set
            {
                _userC = value;
                OnPropertyChanged();
            }
        }

        public string BossName
        {
            get
            {
                if (UserA.IsBoss)
                    return UserA.Name;

                if (UserB.IsBoss)
                    return UserB.Name;

                if (UserC.IsBoss)
                    return UserC.Name;

                return "";
            }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set
            {
                _endTime = value;
                OnPropertyChanged();
            }
        }

        public int TimeSpent
        {
            get { return (EndTime - StartTime).Minutes; }
        }

        #endregion

        #region Public methods

        public void SetWinner(int winner)
        {
            //Score cal
            int farmerScore = BasicScore * Times;
            int masterScore = farmerScore * 2;

            //master win
            if (winner == 1)
            {
                if (_userA.IsBoss)
                {
                    _userA.Score += masterScore;
                    _userB.Score -= farmerScore;
                    _userC.Score -= farmerScore;
                }
                else if (_userB.IsBoss)
                {
                    _userB.Score += masterScore;
                    _userA.Score -= farmerScore;
                    _userC.Score -= farmerScore;
                }
                else if (_userC.IsBoss)
                {
                    _userC.Score += masterScore;
                    _userA.Score -= farmerScore;
                    _userB.Score -= farmerScore;
                }
            }
            else if (winner == 0)
            {
                if (_userA.IsBoss)
                {
                    _userA.Score -= masterScore;
                    _userB.Score += farmerScore;
                    _userC.Score += farmerScore;
                }
                else if (_userB.IsBoss)
                {
                    _userB.Score -= masterScore;
                    _userA.Score += farmerScore;
                    _userC.Score += farmerScore;
                }
                else if (_userC.IsBoss)
                {
                    _userC.Score -= masterScore;
                    _userA.Score += farmerScore;
                    _userB.Score += farmerScore;
                }
            }
        }

        #endregion

        public object Clone()
        {
            var temp = this.MemberwiseClone() as GameInfo;
            temp.UserA = UserA.Clone() as Person;
            temp.UserB = UserB.Clone() as Person;
            temp.UserC = UserC.Clone() as Person;

            return temp;
        }
    }
}
