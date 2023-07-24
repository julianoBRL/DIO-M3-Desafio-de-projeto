

namespace DIO_M3_Desafio_de_projeto.Entities
{
    public class Knight: Hero{
        public Knight( string Name, string HeroType, int Level) {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
        }

        public Knight(){}
    }
}