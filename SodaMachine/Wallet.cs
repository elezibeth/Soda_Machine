using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public List<Coin> walletCoins;
        //Constructor (Spawner)
        public Wallet()
        {
            walletCoins = new List<Coin>();
            FillRegister();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillRegister()
        {
            for (int i = 10; i > 0; i--)
            {
                Quarter quarter = new Quarter();
                walletCoins.Add(quarter);
            }
            for (int i = 10; i > 0; i--)
            {
                Dime dime = new Dime();
                walletCoins.Add(dime);
            }
            for (int i = 20; i > 0; i--)
            {
                Nickel nickel = new Nickel();
                walletCoins.Add(nickel);
            }
            for (int i = 50; i > 0; i--)
            {
                Penny penny = new Penny();
                walletCoins.Add(penny);
            }

        }
        public Coin getPenny()
        {
            bool coinExists = false;

            foreach (Coin coin in walletCoins)
            {
                if (coin.Name == "Penny")
                {

                    coinExists = true;
                }


            }
            if (coinExists == true)
            {
                int coin = walletCoins.FindLastIndex(q => q.Name == "Penny");
                walletCoins.RemoveAt(coin);
                Penny penny = new Penny();
                return penny;


            }
            else
            {
                return null;
            }

        }
        public Coin getNickel()
        {
            bool coinExists = false;

            foreach (Coin coin in walletCoins)
            {
                if (coin.Name == "Nickel")
                {

                    coinExists = true;
                }


            }
            if (coinExists == true)
            {
                int coin = walletCoins.FindLastIndex(q => q.Name == "Nickel");
                walletCoins.RemoveAt(coin);
                Nickel nickel = new Nickel();
                return nickel;


            }
            else
            {
                return null;
            }

        }
        public Coin getQuarter()
        {
            bool coinExists = false;
       
            foreach(Coin coin in walletCoins)
            {
                if(coin.Name == "Quarter")
                {
                   
                    coinExists = true;
                }

                    
            }
          if(coinExists == true)
            {
                int coin = walletCoins.FindLastIndex(q => q.Name == "Quarter");
                walletCoins.RemoveAt(coin);
                Quarter quarter = new Quarter();
                return quarter;


            }
            else
            {
                return null;
            }
            
        
        }
        public Coin getDime()
        {
            bool coinExists = false;

            foreach (Coin coin in walletCoins)
            {
                if (coin.Name == "Dime")
                {

                    coinExists = true;
                }


            }
            if (coinExists == true)
            {
                int coin = walletCoins.FindLastIndex(q => q.Name == "Dime");
                walletCoins.RemoveAt(coin);
                Dime dime = new Dime();
                return dime;


            }
            else
            {
                return null;
            }

        }
    }
}
