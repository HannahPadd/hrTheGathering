using System;
namespace hrTheGathering
{
    public class Player
    {
        public int Health { get; set; }
        public string PlayerName { get; set; }
        public Card[] Hand { get; set; }
        public Card[] DiscardPile { get; set; }
        public Card[] DrawPile { get; set; }

        public Player(int health, string playerName)
        {
            Health = health;
            PlayerName = playerName;
        }

        public void BuildDeck(DeckBuilder deckBuilder)
        {
            
        }

        public void DrawHand()
        {
            throw new NotImplementedException();
        }

        public void PlayCard(Card card)
        {
            throw new NotImplementedException();
        }

        public void DiscardCard(Card card)
        {
            throw new NotImplementedException();
        }

        public void DrawCard()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void DeclrareBlockers()
        {
            throw new NotImplementedException();
        }

        public void Block()
        {
            throw new NotImplementedException();
        }
    }
}