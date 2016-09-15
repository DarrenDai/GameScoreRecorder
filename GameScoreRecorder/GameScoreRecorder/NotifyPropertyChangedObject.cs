using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GameScoreRecorder
{
    public class NotifyPropertyChangedObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChangedBase(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnPropertyChanged<T>(Expression<Func<T>> property)
        {
            var temp = (property as MemberExpression).Member as PropertyInfo;
            OnPropertyChangedBase(temp.Name);
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            OnPropertyChangedBase(propertyName);
        }
    }
}
