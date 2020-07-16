using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameEngine
{
    public class PlayerCharacter 
    {
        private int _health = 100;
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Nickname { get; set; }
        public int Health
        {
            get => _health;
            set
            {
                _health = value; 
            }
        }
        public bool IsNoob { get; set; }
        public List<string> Weapons { get; set; }


        public PlayerCharacter()
        {
            FirstName = GenerateRandomFirstName();

            IsNoob = true;

            CreateStartingWeapons();
        }

        public void Sleep()
        {           
            var healthIncrease = CalculateHealthIncrease();            

            Health = Health + healthIncrease;

        }

        private int CalculateHealthIncrease()
        {
            var rnd = new Random();

            return rnd.Next(1, 101);
        }

        

        public void TakeDamage(int damage)
        {
            Health = Math.Max(1, Health = Health - damage);
        }

        private string GenerateRandomFirstName()
        {
            var possibleRandomStartingNames = new[]
            {
                "Danieth",
                "Derick",
                "Shalnorr",
                "G'Toth'lop",
                "Boldrakteethtop"
            };

            return possibleRandomStartingNames[
                new Random().Next(0, possibleRandomStartingNames.Length)];
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>
            {
                "Long Bow",
                "Short Bow",
                "Short Sword",
            };
        }


    }
}