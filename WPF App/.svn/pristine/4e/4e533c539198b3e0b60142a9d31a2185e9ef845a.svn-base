using Data;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4.Model
{
    public class DataService
    {
        ApiCatalyst ApiCatalyst = new ApiCatalyst();
        public void CatalystAddCard(string CardType, string CardNumber, int ExpMonth, int ExpYear, DateTime modifiedDate)
        {
            ApiCatalyst.CatalystAddCard(CardType, CardNumber, ExpMonth, ExpYear, modifiedDate);
        }

        public void CatalystDeleteCard(string CardNumber)
        {
            ApiCatalyst.CatalystDeleteCard(CardNumber);
        }

        public void UpdateCardExpDate(string CardNumber, int ExpMonth, int ExpYear)
        {
            ApiCatalyst.UpdateCardExpDate(CardNumber, ExpMonth, ExpYear);
        }

        public void UpdateCardType(string CardNumber, string CardType)
        {
            ApiCatalyst.UpdateCardType(CardNumber, CardType);
        }

        public object GetCard(string CardNumber)
        {
            return ApiCatalyst.GetCard(CardNumber);
        }
        public IEnumerable<CreditCard> GetAllCards()
        {
            return ApiCatalyst.GetAllCards();
        }

    }
}
