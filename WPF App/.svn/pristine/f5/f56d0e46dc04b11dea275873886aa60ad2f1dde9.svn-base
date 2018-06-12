using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ApiCatalyst
    {
        SQLEditor sQLEditor = new SQLEditor();
        public void CatalystAddCard(string CardType, string CardNumber, int ExpMonth, int ExpYear, DateTime modifiedDate)
        {
            sQLEditor.AddCard(CardType, CardNumber, ExpMonth, ExpYear, modifiedDate);
        }

        public void CatalystDeleteCard(string CardNumber)
        {
            sQLEditor.DeleteCard(CardNumber);
        }

        public void UpdateCardExpDate(string CardNumber, int ExpMonth, int ExpYear)
        {
            sQLEditor.UpdateCardExpDate(CardNumber, ExpMonth, ExpYear);
        }

        public void UpdateCardType(string CardNumber, string CardType)
        {
            sQLEditor.UpdateCardType(CardNumber, CardType);
        }

        public object GetCard(string CardNumber)
        {
            return sQLEditor.GetCard(CardNumber);
        }
        public IEnumerable<CreditCard> GetAllCards()
        {
            return sQLEditor.GetAllCards();
        }


    }
}
