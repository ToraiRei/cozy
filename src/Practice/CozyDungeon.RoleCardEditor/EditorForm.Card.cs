﻿using CozyDungeon.Game.Component.Card.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozyDungeon.RoleCardEditor
{
    public partial class EditorForm
    {
        private void CreateCard()
        {
            var form = new CozyForm.CreateCardForm(CardLevels);
            form.CardCreateEventHandler += (s, msg) =>
            {
                AddCard(msg.Card, msg.CardImage);
                CardTabControl.SelectedIndex = (int)msg.Card.Level;
            };
            form.ShowDialog();
        }

        private void AddCard(RoleCard card, CozyCardImage cardImage)
        {
            IsModified = true;

            CardImageDictionary[card.Id] = cardImage;
            ListOfRoleCardList[(int)card.Level].Add(card);
        }

        private void RemoveCard()
        {
            if(SelectedItem != null)
            {
                IsModified  = true;
                var card    = SelectedItem;

                if(CardImageDictionary.ContainsKey(card.Id))
                {
                    CardImageDictionary.Remove(card.Id);
                }
                ListOfRoleCardList[(int)card.Level].Remove(card);
                ResetInput();
            }
        }
    }
}
