using System;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak(){
            Console.WriteLine("Bitkiler Fotosentez yapar.");
        } 
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu Bitkiler tohumla çoğalır.");
        } 
    }

     public class TohumsuzBitkiler:Bitkiler
    {
         public TohumsuzBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz Bitkiler Sporla çoğalır.");
        } 
    }
}