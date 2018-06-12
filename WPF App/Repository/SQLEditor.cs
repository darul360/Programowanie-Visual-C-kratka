using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Repository
{
    class SQLEditor 
    {
        public void AddCard(string CardType, string CardNumber, int ExpMonth, int ExpYear, DateTime modifiedDate)
        {
            byte value = Convert.ToByte(ExpMonth);
            short shortExpYear = Convert.ToInt16(ExpYear);

            using (SQLDataContext data = new SQLDataContext())
            {
                CreditCard creditCard = new CreditCard();

                creditCard.CardType = CardType;
                creditCard.CardNumber = CardNumber;
                creditCard.ExpMonth = value;
                creditCard.ExpYear = shortExpYear;
                creditCard.ModifiedDate = modifiedDate;
                data.CreditCard.InsertOnSubmit(creditCard);
                data.SubmitChanges();
            }

        }

        public void DeleteCard(String CardNumber)
        {
            using (SQLDataContext data = new SQLDataContext())
            {
                CreditCard creCard = data.CreditCard.SingleOrDefault(i => i.CardNumber == CardNumber);

                if (creCard != null)
                {
                    data.CreditCard.DeleteOnSubmit(creCard);
                    data.SubmitChanges();
                }

            }
        }

        public IEnumerable<CreditCard> GetAllCards()
        {
            using (SQLDataContext data = new SQLDataContext())
            {
                List<CreditCard> list = (from i in data.CreditCard select i).ToList();
                return list;
            }
        }

        public object GetCard(string CardNumber)
        {
            using (SQLDataContext data = new SQLDataContext())
            {
                Object card = (from i in data.CreditCard
                               where i.CardNumber == CardNumber
                               select i).FirstOrDefault();
                return card;
            }
        }

        public void UpdateCardExpDate(string CardNumber, int ExpMonth, int ExpYear)
        {
            byte value = Convert.ToByte(ExpMonth);
            short shortExpYear = Convert.ToInt16(ExpYear);
            using (SQLDataContext data = new SQLDataContext())
            {
                var old = data.CreditCard.SingleOrDefault(i => i.CardNumber == CardNumber);
                old.ExpMonth = value;
                old.ExpYear = shortExpYear;
                data.SubmitChanges();
            }
        }

        public void UpdateCardType(string CardNumber, string CardType)
        {
            using (SQLDataContext data = new SQLDataContext())
            {
                CreditCard old = data.CreditCard.SingleOrDefault(i => i.CardNumber == CardNumber);
                old.CardType = CardType;
                data.SubmitChanges();
            }
        }
    }
}
