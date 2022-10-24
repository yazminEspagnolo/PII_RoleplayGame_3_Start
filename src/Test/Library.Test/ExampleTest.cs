using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void dummyTest()
        {
            Hacha hacha = new Hacha();
            Assert.AreEqual(25, hacha.Ataque);

            Casco casco = new Casco();
            Assert.AreEqual(18, casco.Defensa);

            Escudo escudo = new Escudo();
            Assert.AreEqual(14, escudo.Defensa);

            Anillo anillo = new Anillo();
            Assert.AreEqual(25, anillo.Defensa);

            Arco arco = new Arco();
            Assert.AreEqual(18, arco.Ataque);

            BastonMagico bastonMagico = new BastonMagico();
            Assert.AreEqual(100, bastonMagico.Ataque);

            Capa capa = new Capa();
            Assert.AreEqual(18, capa.Defensa);

            Hechizo hechizo = new Hechizo();
            Assert.AreEqual(70, hechizo.Ataque);
            Assert.AreEqual(70, hechizo.Defensa);


            
        }
    }
}