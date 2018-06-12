using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zadanie_4.Model;
using Data;
using System.IO;

namespace Zadanie_4.ViewModel
{
    public class ShowAllCardsViewM : INotifyPropertyChanged
    {
        public ShowAllCardsViewM()
        {
            Refresh = new UniversalCardModel(pars => Show());
            AddButton = new UniversalCardModel(o => ButtonAdd());
            DelButton= new UniversalCardModel(o => ButtonDel());
            ExpButton = new UniversalCardModel(o => ButtonExp());
            TypeButton = new UniversalCardModel(o => ButtonType());
            ShowAllButton = new UniversalCardModel(o => ButtonShowAll());
            MasterLoader = new UniversalCardModel(o => seting());
        }
       
        public ICommand Refresh { get; set; }
        public ICommand AddButton { get; set; }
        public ICommand DelButton { get; set; }
        public ICommand ExpButton { get; set; }
        public ICommand TypeButton { get; set; }
        public ICommand ShowAllButton { get; set; }
        public ICommand MasterLoader { get; set; }



        private DataService data = new DataService();
        public event PropertyChangedEventHandler PropertyChanged = null;

        private IEnumerable<CreditCard> cards;
        public IEnumerable<CreditCard> Cards
        { get{return this.cards;} set { this.cards = value; this.OnPropertyChanged("Cards");}}

        private CreditCard selectedItem { get; set; }
        public CreditCard SelectedItem { get { return selectedItem; } set { selectedItem = value; seting(); } }

        private String type { get; set; } = "";
        public String Type { get { return type; } set { type = value; this.OnPropertyChanged("Type"); ; } }
        private String number { get; set; } = "";
        public String Number { get { return number; } set { number = value; this.OnPropertyChanged("Number"); ; } }

        private byte month { get; set; } = 0;
        public byte Month { get { return month; } set { month = value; this.OnPropertyChanged("Month"); ; } }
        public short year { get; set; } = 0;
        public short Year { get { return year; } set { year = value; this.OnPropertyChanged("Year"); ; } }
        public DateTime modDate { get; set; } 
        public DateTime ModDate { get { return modDate; } set { modDate = value; this.OnPropertyChanged("ModDate"); ; } }

        private void Show()
        {
            Cards = data.GetAllCards();
            
        }

        private void seting()
        {
            if (SelectedItem != null)
            {
                number = SelectedItem.CardNumber;
                Number = SelectedItem.CardNumber;
                Type = SelectedItem.CardType;
                Month = SelectedItem.ExpMonth;
                Year = SelectedItem.ExpYear;
                ModDate = SelectedItem.ModifiedDate;
            }
        }
        private void ButtonAdd()
        {
            AddWindow adw = new AddWindow();
            adw.Show();
        }

        private void ButtonDel()
        {
            DeleteWindow dlw = new DeleteWindow();
            dlw.Show();
        }

        private void ButtonExp()
        {
            ExpUpdateWindow euw = new ExpUpdateWindow();
            euw.Show();
        }

        private void ButtonType()
        {
            TypeCardUpdateWindow tcuw = new TypeCardUpdateWindow();
            tcuw.Show();
        }

        private void ButtonShowAll()
        {
            ShowAllWindow saw = new ShowAllWindow();
            saw.Show();
        }

        virtual protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
