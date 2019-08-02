using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStarted
{
    public class BookInfoRepository:INotifyPropertyChanged
    {
        #region Fields
        private ObservableCollection<BookInfo> newBookInfo;
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        public Command<object> IndicatorCommand { get; set; }
        public ObservableCollection<BookInfo> NewBookInfo
        {
            get { return newBookInfo; }
            set { this.newBookInfo = value; }
        }
        
        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        #region Constructor

        public BookInfoRepository()
        {
            GenerateNewBookInfo();
            IndicatorCommand = new Command<object>(OnLoadingItems);
        }

        #endregion

        #region Methods

        private async void OnLoadingItems(object obj)
        {
            var model = obj as BookInfo;
            model.IsIndicatorVisible = true;
            model.IsButtonVisible = false;
            await Task.Delay(2000);
            model.IsDescriptionVisible = true;
            model.IsIndicatorVisible = false;

        }
        private void GenerateNewBookInfo()
        {
            NewBookInfo = new ObservableCollection<BookInfo>();
            NewBookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You’ll learn several different approaches to applying machine learning", IsIndicatorVisible = false, IsButtonVisible = true, IsDescriptionVisible=false });
            NewBookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is the de facto programming paradigm", IsIndicatorVisible = false, IsButtonVisible = true, IsDescriptionVisible = false });
            NewBookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions", IsIndicatorVisible = false, IsButtonVisible = true, IsDescriptionVisible = false });
        }

        #endregion
        
    }
}
