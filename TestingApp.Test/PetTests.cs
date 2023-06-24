using System;
using Xunit;
using Pets;

public class PetTests
{
    [Fact]
    public void PerroTalkToOwnerReturnsWoof()
    {
        string expected = "Woof!";
        string actual = new Perro().TalkToOwner();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GatoTalkToOwnerReturnsMeow()
    {
        string expected = "Meosw!";
        string actual = new Gato().TalkToOwner();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VacaTalkToOwnerReturnsMeow()
    {
        string expected = "Muu!";
        string actual = new Vaca().TalkToOwner();

        Assert.Equal(expected, actual);
    }
}