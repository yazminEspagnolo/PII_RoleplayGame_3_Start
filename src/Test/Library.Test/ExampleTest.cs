using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void TestEncuentro()
        {
            Encounter Encuentro1= new Encounter();   
            Elfo elfo = new Elfo("Claus");
            Encuentro1.AddHeroe(elfo);
            Esqueleto esqueleto= new Esqueleto("Huesos");
            Encuentro1.AddEnemigo(esqueleto);
            Encuentro1.DoEncounter();
            Assert.IsTrue(elfo.Vida>0);
            Assert.IsTrue(esqueleto.Vida<=0);
            Assert.IsTrue(elfo.VP == esqueleto.VP);
        }
    }
}