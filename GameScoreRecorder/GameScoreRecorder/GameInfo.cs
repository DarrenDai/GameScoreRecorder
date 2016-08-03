using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreRecorder
{
    class GameInfo
    {
        private int _basicScore;

        public int BasicScore
        {
            get { return _basicScore; }
            set { _basicScore = value; }
        }

        private int _times;

        public int Times
        {
            get { return _times; }
            set { _times = value; }
        }

        private DateTime _startTime;

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        private DateTime _endTime;

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

    }
}
