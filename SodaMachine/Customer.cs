using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //Member Variables (Has A)
        public Wallet Wallet;
        public Backpack Backpack;

        //Constructor (Spawner)
        public Customer()
        {
            Wallet = new Wallet();
            Backpack = new Backpack();
        }
        //Member Methods (Can Do)

        //This method will be the main logic for a customer to retrieve coins form their wallet.
        //Takes in the selected can for price reference
        //Will need to get user input for coins they would like to add.
        //When all is said and done this method will return a list of coin objects that the customer will use a payment for their soda.
        public List<Coin> GatherCoinsFromWallet(Can selectedCan)
        {
            List<Coin> gatheredCoins = new List<Coin>();
            double price = selectedCan.Price;
            while(price >= .25)
            {
                gatheredCoins.Add(GetCoinFromWallet("Quarter"));
                price -= .25;
            }
            while(price >= .1)
            {
                gatheredCoins.Add(GetCoinFromWallet("Dime"));
                price -= .1;
            }
            while(price >= .05)
            {
                gatheredCoins.Add(GetCoinFromWallet("Nickel"));
                price -= .05;
            }
            while(price >= .01)
            {
                gatheredCoins.Add(GetCoinFromWallet("Penny"));
                price -= .01;
            }
            return gatheredCoins;


          
        }
        //Returns a coin object from the wallet based on the name passed into it.
        //Returns null if no coin can be found
        public Coin GetCoinFromWallet(string coinName)
        {
            switch (coinName)
            {
                case "Penny":
                   Coin penny =  Wallet.getPenny();
                   return penny;
                case "Nickel":
                    Coin nickel = Wallet.getNickel();
                    return nickel;
                case "Dime":
                    Coin dime = Wallet.getDime();
                    return dime;
                case "Quarter":
                    Coin quarter = Wallet.getQuarter();
                    return quarter;
                default:
                    Console.WriteLine("your coin was not retrieved from the customer's wallet.");
                    return null;

            };
                 
         
            
        }
        //Takes in a list of coin objects to add into the customers wallet.
        public void AddCoinsIntoWallet(List<Coin> coinsToAdd)
        {
            foreach(Coin coin in coinsToAdd)
            {
                Wallet.walletCoins.Add(coin);
            }
            
        }
        //Takes in a can object to add to the customers backpack.
        public void AddCanToBackpack(Can purchasedCan)
        {
            Backpack.cans.Add(purchasedCan);
            Console.WriteLine($"{purchasedCan.name} in backpack");
            Console.ReadLine();
            
        }
    }
}
