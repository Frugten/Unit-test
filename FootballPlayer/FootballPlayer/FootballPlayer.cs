using System;

namespace FootballPlayer
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private int _price;
        private int _shirtNumber;

        public FootballPlayer(int id, string name, int price, int shirtNumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;

        }

        public int Id { get => _id; 
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("id", "Id have to bigger than 0");
                _id = value;
            }
        }

        public string Name {
            get => _name;
            set
            {
                if (value == null) throw new ArgumentNullException("name", "Name cannot be null");
                if (value.Length < 4) throw new ArgumentOutOfRangeException("Name have to bigger than 4");
                _name = value;
            }
        }
        public int Price {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("price","Price have to bigger than 0");
                _price = value;
            }
        }
        public int ShirtNumber {
            get => _shirtNumber;
            set
            {
                if (value >= 1 && value <= 100) _shirtNumber = value;
                else throw new ArgumentOutOfRangeException("shirtnumber", value, "Name cannot be null");
                _shirtNumber = value;
            }
        }
    }
}
