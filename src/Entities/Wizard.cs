using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO_M3_Desafio_de_projeto.Entities;

namespace DIO_M3_Desafio_de_projeto.Entities{

    public class Wizard: Hero{

        public Wizard( string Name, string HeroType, int Level) {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
        }

        public Wizard(){}

        public override string Attack(){
            return this.Name+" Atacou com magia!";
        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name+$" Lançou Magia SUPER efetiva com bonus de {Bonus}";
            }else{
                return this.Name+$" Lançou magia fraca com bonus de {Bonus}";
            }
        }

    }
}