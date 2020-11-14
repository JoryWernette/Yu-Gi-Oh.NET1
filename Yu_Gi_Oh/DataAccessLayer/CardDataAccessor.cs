using DataObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
   public class CardDataAccessor
    {
        public static List<Card> RetreiveCardList()
        {
            List<Card> cardList = new List<Card>();
            char[] separator = { ',' };
            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + @"\" + AppData.CardListFileName);
                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts;
                    if (line.Length > 0)
                    {
                        parts = line.Split(separator);
                        if (parts.Count() == 13)
                        {
                            Card newCard = new Card();
                            newCard.Name = parts[0];
                            newCard.Card_category = parts[1];
                            newCard.Card_type = parts[2];
                            newCard.Monster_type = parts[3];
                            newCard.Sub_type = parts[4];
                            newCard.Attribute = parts[5];
                            newCard.Level_rank = parts[6];
                            newCard.Attack = parts[7];
                            newCard.Defense = parts[8];
                            newCard.Banlist = parts[9];
                            newCard.Card_text = parts[10];
                            newCard.Card_Image_File = parts[11];
                            newCard.Card_Info_File = parts[12];
                            cardList.Add(newCard);
                        }
                    }
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return cardList;
        } // End of RetreiveCardList()

        public static CardInfo RetreiveCardInfo(Card card)
        {
            CardInfo newCardInfo = new CardInfo();

            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + @"\" + card.Card_Info_File);
                newCardInfo.Name = fileReader.ReadLine();
                newCardInfo.Card_category = fileReader.ReadLine();
                newCardInfo.Card_type = fileReader.ReadLine();
                newCardInfo.Monster_type = fileReader.ReadLine();
                newCardInfo.Sub_type = fileReader.ReadLine();
                newCardInfo.Attribute = fileReader.ReadLine();
                newCardInfo.Level_rank = fileReader.ReadLine();
                newCardInfo.Attack = fileReader.ReadLine();
                newCardInfo.Defense = fileReader.ReadLine();
                newCardInfo.Card_text = fileReader.ReadLine();
                newCardInfo.Banlist = fileReader.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
            return newCardInfo;
        } // End of RetreiveCardInfo
    } // End CardDataAccessor
} // End DataAccessLayer
