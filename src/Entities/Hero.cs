
namespace DIO_M3_Desafio_de_projeto.Entities{
    public abstract class Hero{
        public string? Name { get; set; }
        public string? HeroType { get; set; }
        public int? Level { get; set; }
        
        public Hero( string Name, string HeroType, int Level) {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
        }

        public Hero(){}

        public virtual string Attack(){
            return this.Name+" Atacou com sua espada!";
        }

        public override string ToString(){
            return this.Name+" , "+this.HeroType+" , "+this.Level;
        }

    }
}