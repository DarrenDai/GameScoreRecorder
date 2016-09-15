using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreRecorder
{
    public class Person : NotifyPropertyChangedObject, ICloneable
    {
        private string _name;
        private int _score = 0;
        private bool _isBoss = false;
        private bool _isWiner = false;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public bool IsBoss
        {
            get { return _isBoss; }
            set
            {
                _isBoss = value;
                OnPropertyChanged();
            }
        }

        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                OnPropertyChanged();
            }
        }

        public bool IsWiner
        {
            get { return _isWiner; }
            set
            {
                _isWiner = value;
                OnPropertyChanged();
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
