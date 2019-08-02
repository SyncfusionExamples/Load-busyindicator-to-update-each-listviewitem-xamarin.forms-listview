using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    public class BookInfo : INotifyPropertyChanged
    {
        #region Fields

        private string bookName;
        private string bookDescription;

        #endregion

        #region Constructor

        public BookInfo()
        {
        }

        #endregion

        #region Properties

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }
        public bool isDescriptionVisible;

            public bool IsDescriptionVisible
        {
            get { return isDescriptionVisible; }
            set
            {
                isDescriptionVisible = value;
                OnPropertyChanged("IsDescriptionVisible");
            }
        }
        public string BookDescription
        {
            get { return bookDescription; }
            set
            {
                bookDescription = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public bool isButtonVisible;
        public bool IsButtonVisible
        {
            get { return isButtonVisible; }
            set
            {
                isButtonVisible = value;
                OnPropertyChanged("IsButtonVisible");
            }
        }

        public bool isIndicatorVisible;
        public bool IsIndicatorVisible
        {
            get { return isIndicatorVisible; }
            set
            {
                isIndicatorVisible = value;
                OnPropertyChanged("IsIndicatorVisible");
            }
        }

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
