using System;

namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar Adaptan Kurabilir.");
        } 
    }

    public class Sürüngenler:Hayvanlar
    {
         public Sürüngenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SürünerekHareketEderler(){
            Console.WriteLine("Sürüngenler Sürünerek Haraket Eder.");
        } 
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar.");
        } 
    }        
}