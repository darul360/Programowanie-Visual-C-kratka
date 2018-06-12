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
    public class DeleteCardViewM : INotifyPropertyChanged, IDataErrorInfo
    {
        public DeleteCardViewM()
        {
            DeleteCommand = new UniversalCardModel(pars => Delete());
        }

        public ICommand DeleteCommand { get; set; }
        private DataService data = new DataService();
        public event PropertyChangedEventHandler PropertyChanged = null;

        private string cardNumber = "K001";

        public string CardNumber
        { get { return this.cardNumber; } set { this.cardNumber = value; OnPropertyChanged("CardNumber"); } }

        private void Delete()
        {
            if(validationChecker==true)
            data.CatalystDeleteCard(cardNumber);
        }

        virtual protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private static readonly int properLenght = 4;
        private static readonly string warningEmpty = "Okno nie może być puste";
        private static readonly string warningNotEqual = "Nie podano wystarczającej ilości znaków";

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
            return null;
        }

        private static readonly string[] ValidatorParameters =
       {
            nameof(CardNumber)
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
