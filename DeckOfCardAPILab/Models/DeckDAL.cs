using RestSharp;
using System;

namespace DeckOfCardAPILab.Models
{
    public class DeckDAL
    {
        public Deck GetDeck()
        {            
            var client = new RestClient($"https://deckofcardsapi.com/api/deck/new/shuffle");
            var request = new RestRequest();
            var response = client.GetAsync<Deck>(request);
            Deck d = response.Result;

            return d;
        }
        public NewCard Get5Cards(string deck_id)
        {
            var client = new RestClient($"https://deckofcardsapi.com/api/deck/{deck_id}/draw/?count=5");
            var request = new RestRequest();
            var response = client.GetAsync<NewCard>(request);
            NewCard nc = response.Result;

            return nc;
        }

    }
}
