using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange
        var adm = new Veiculo();

        //Act
        adm.Id = 1;
        adm.Nome = "Fusca";
        adm.Marca = "Volks";
        adm.Ano = 1995;


        //Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("Fusca", adm.Nome);
        Assert.AreEqual("Volks", adm.Marca);
        Assert.AreEqual(1995, adm.Ano);

    }
}
