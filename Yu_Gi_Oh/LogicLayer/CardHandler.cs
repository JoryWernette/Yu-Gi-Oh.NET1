using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayer;

namespace LogicLayer
{
    public class CardHandler
    {
        //
        //
        List<Card> _cardList;
        public CardHandler()
        {
            try
            {
                _cardList = CardDataAccessor.RetreiveCardList();
            }
            catch (Exception)
            {
                throw;
            }
        } // End CardHandler()
    
        public List<Card> CardList
        {
            get { return _cardList; }
        }

        public CardInfo getCardInfo(int cardIndex)
        {
            //
            try
            {
                return CardDataAccessor.RetreiveCardInfo(_cardList[cardIndex]);
            }
            catch (Exception)
            {
                throw new ApplicationException("Card Data Not Found.");
            }
        } // End of RetreiveCardInfo
        // getter of the card text 

        // EditCard

        // AddCard
    }
}
