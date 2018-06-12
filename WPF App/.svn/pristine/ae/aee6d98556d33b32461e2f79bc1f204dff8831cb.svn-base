using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zadanie_4.Model;

namespace Zadanie_4.ViewModel
{
        public class UpdateExpCardViewM : INotifyPropertyChanged, IDataErrorInfo
    {
            public UpdateExpCardViewM()
            {
                UpdateCommand = new UniversalCardModel(pars => Update());
            }

            public ICommand UpdateCommand { get; set; }
            private DataService data = new DataService();
            public event PropertyChangedEventHandler PropertyChanged = null;

            private string cardNumber = "K001";
            private int expMonth = 1;
            private int expYear = 2021;

        public string CardNumber
            { get { return this.cardNumber; } set { this.cardNumber = value; OnPropertyChanged("CardNumber"); } }
        public int ExpMonth
        { get { return this.expMonth; } set { this.expMonth = value; OnPropertyChanged("ExpMonth"); } }
        public int ExpYear
        { get { return this.expYear; } set { this.expYear = value; OnPropertyChanged("ExpYear"); } }

        private void Update()
            {
                 if(validationChecker==true)
                 data.UpdateCardExpDate(cardNumber, expMonth, expYear);
            }

            virtual protected void OnPropertyChanged(string propName)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }

        private static readonly int properLenght = 4;
        private static readonly int YearNow = DateTime.Now.Year;
        private static readonly string warningEmpty = "Okno nie może być puste";
        private static readonly string warningNotEqual = "Nie podano wystarczającej ilości znaków";
        private static readonly string warningMonth = "Błedy numer miesiąca";
        private static readonly string warningYear = "Rok za duży lub mniejszy od aktualnego";

        string IDataErrorInfo.Error => null;
        string IDataErrorInfo.this[string propertyName] => Validate(propertyName);

        private string Validate(string propertyName)
        {
            if (propertyName == nameof(CardNumber))
            {
                if (string.IsNullOrEmpty(CardNumber))
                    return propertyName + warningEmpty;
                if (CardNumber.Length != properLenght)
                    return propertyName + warningNotEqual + properLenght;
            }

            if (propertyName == nameof(ExpMonth))
            {
                if (string.IsNullOrEmpty(CardNumber))
                    return propertyName + warningEmpty;
                if (ExpMonth > 12 || ExpMonth < 1)
                    return propertyName + warningMonth;
            }

            if (propertyName == nameof(ExpYear))
            {
                if (string.IsNullOrEmpty(CardNumber))
                    return propertyName + warningEmpty;
                if (ExpYear > 3000 || ExpYear < YearNow)
                    return propertyName + warningYear;
            }
            return null;
        }

        private static readonly string[] ValidatorParameters =
       {
            nameof(CardNumber),
            nameof(ExpMonth),
            nameof(ExpYear)
        };
        public bool validationChecker
        {
            get
            {
                foreach (var propertyName in ValidatorParameters)
                    if (Validate(propertyName) != null)
                        return false;
                return true;
            }
        }
    }
}
