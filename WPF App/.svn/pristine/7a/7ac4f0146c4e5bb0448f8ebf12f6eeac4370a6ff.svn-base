using Data;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Zadanie_4.Model;

namespace Zadanie_4.ViewModel
{
    public class AddCardViewM : INotifyPropertyChanged, IDataErrorInfo
    {
        public AddCardViewM()
        {
            AddCommand = new UniversalCardModel(pars=>Add());
        }

        public ICommand AddCommand { get; set; }
        private DataService data = new DataService();
        public event PropertyChangedEventHandler PropertyChanged = null;

        private string cardType = "for example Platinum";
        private string cardNumber = "K001";
        private int expMonth = 1;
        private int expYear = 2021;
        private DateTime dt = DateTime.Now;

        public string CardType
        { get { return this.cardType; } set { this.cardType = value; OnPropertyChanged("CardType"); } }

        public string CardNumber
        { get { return this.cardNumber; } set { this.cardNumber = value; OnPropertyChanged("CardNumber"); } }

        public int ExpMonth
        { get { return this.expMonth; } set { this.expMonth = value; OnPropertyChanged("ExpMonth"); } }

        public int ExpYear
        { get { return this.expYear; } set { this.expYear = value; OnPropertyChanged("ExpYear"); } }

        public DateTime Dt
        { get { return this.dt; } set { this.dt = value; OnPropertyChanged("Dt"); } }



        private void Add()
        {
            if(validationChecker==true)
            data.CatalystAddCard(cardType, cardNumber, expMonth, expYear, dt);
        }
        virtual protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        /*---------------------IDataErrorInfo + Validation------------------------------*/
        private static readonly int properLenght = 4;
        private static readonly string emptyCell = "Okno nie może być puste";
        private static readonly string chainLenght = "Nie podano wystarczającej ilości znaków";
        private static readonly string monthNotValid = "Błedy numer miesiąca";
        //private static readonly string objectIsNotNumber = "Podaj cyfrę,nie znak";

        string IDataErrorInfo.Error => null;
        string IDataErrorInfo.this[string propName] => Validate(propName);

        private string Validate(string propName)
        {
            if (propName == nameof(CardType))
            {
                if (string.IsNullOrEmpty(CardNumber))
                    return propName + emptyCell;
            }

            if (propName == nameof(CardNumber))
            {
                if (string.IsNullOrEmpty(CardNumber))
                    return propName + emptyCell;
                if (CardNumber.Length != properLenght)
                    return propName + chainLenght + properLenght;
                
            }

            if (propName == nameof(ExpMonth))
            {
                if (string.IsNullOrEmpty(ExpMonth.ToString()))
                    return propName + emptyCell;
                if (ExpMonth>12 || ExpMonth<1)
                    return propName + monthNotValid;

            }

            if (propName == nameof(ExpYear))
            {
                if (string.IsNullOrEmpty(ExpYear.ToString()))
                    return propName + emptyCell;
                if (ExpYear > 3000 || ExpYear < 1990)
                    return propName + monthNotValid;

            }
            return null;
        }

        private static readonly string[] ValidatorParameters =
       {
            nameof(CardType),
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
