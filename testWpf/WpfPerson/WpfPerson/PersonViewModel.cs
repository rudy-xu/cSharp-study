using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfPerson
{
    class PersonViewModel : INotifyPropertyChanged
    {
        #region Fields
        private string _searchText;
        private ObservableCollection<Person> _resultList;
        #endregion //Fields

        #region Properties
        public ObservableCollection<Person> PersonList { get; private set; }

        //search key words
        public string SearchText
        {
            get
            {
                return _searchText;
            }

            set
            {
                _searchText = value;

                //active event
                RaisePropertyChanged("SearchText");
            }
        }

        //search results
        public ObservableCollection<Person> ResultList
        {
            get
            {
                return _resultList;
            }

            set
            {
                _resultList = value;

                //active event
                RaisePropertyChanged("ResultList");
            }
        }

        //ICommand
        public ICommand RelayCommand
        {
            get
            {
                return new RelayCommand(Searching, CanSearching);
            }
        }
        #endregion //Properties

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion  //INotifyPropertyChanged Members

        #region methods
        private void RaisePropertyChanged(string propertyName)
        {
            //take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion  //methods

        #region Constructor
        public PersonViewModel()
        {
            PersonList = PersonDataHelper.GetPersons();
            _resultList = PersonList;
        }
        #endregion  //Constructor

        #region Command Handler
        public void Searching()
        {
            ObservableCollection<Person> personList = null;
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                ResultList = PersonList;
            }
            else
            {
                personList = new ObservableCollection<Person>();
                foreach (Person p in PersonList)
                {
                    if (p.Name.Contains(SearchText))
                    {
                        personList.Add(p);
                    }
                }

                if (personList != null)
                {
                    ResultList = personList;
                }
            }
        }

        public bool CanSearching()
        {
            return true;
        }
        #endregion  //Command Handler

    }
}
