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
    class UpdateTypeCardViewM : INotifyPropertyChanged, IDataErrorInfo
    {
        public UpdateTypeCardViewM()
        {
            UpdateTypeCommand = new UniversalCardModel(pars => Update());
        }

        public ICommand UpdateTypeCommand { get; set; }
        private DataService data = new DataService();
        public event PropertyChangedEventHandler PropertyChanged = null;

        private string cardNumber = "K001";
        private string cardType = "for example Platinum";

        public string CardNumber
        { get { return this.cardNumber; } set { this.cardNumber = value; OnPropertyChanged("CardNumber"); } }
        public string CardType
        { get { return this.cardType; } set { this.cardType = value; OnPropertyChanged("ExpMonth"); } }
 
        private void Update()
        {
            if(validationChecker==true)
            data.UpdateCardType(cardNumber, cardType);
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

            if (propertyName == nameof(CardType))
            {
                if (string.IsNullOrEmpty(CardType))
                    return propertyName + warningEmpty;
            }

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
            nameof(CardType),
            nameof(CardNumber),
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
