using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreRecorder
{
    class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private bool _isBoss;

        public bool IsBoss
        {
            get { return _isBoss; }
            set { _isBoss = value; }
        }

        private int _score;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
    }
}
