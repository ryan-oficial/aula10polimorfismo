namespace Aula10Polimorfismo
{
    public class Player
    {
        
        public virtual void Pular(){
            System.Console.WriteLine("Pulando normalmente");
        }
        public virtual void Correr(){
            System.Console.WriteLine("Correndo normalmente");
        }
        public virtual void Planar(){
            System.Console.WriteLine("Esta planando");
        }
        public virtual void Montar(){
            System.Console.WriteLine("Pode montar no Yoshi");
        }


        public virtual void AtirarBolaFogo(){
            System.Console.WriteLine("Atira bolas de fogo");
        }



    }
}