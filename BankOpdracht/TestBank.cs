using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOpdracht
{
    //public class TestBank
    //{
    //    [Test]
    //    public void TestConstructorAndProperty()
    //    {
    //        string bankNaam = "TestBank";
    //        Bank bank = new Bank(bankNaam);
    //        Assert.AreEqual(bankNaam, bank.Naam);
    //    }

    //    [Test]
    //    public void OpenRekeningen()
    //    {
    //        string bankNaam = "TestBank";
    //        Bank bank = new Bank(bankNaam);
    //        int rekeningNr0 = bank.OpenRekening("voornaam", "achternaam", "6a", "8944WW");
    //        Assert.AreEqual(0, rekeningNr0);
    //        int rekeningNr1 = bank.OpenRekening("voornaam", "achternaam", "6a", "8944WW", 500);
    //        Assert.AreEqual(1, rekeningNr1);
    //        int rekeningNr2 = bank.OpenRekening("voornaam", "achternaam", "6a", "8944WW", 500, 1000);
    //        Assert.AreEqual(2, rekeningNr2);

    //        int rekeningNr3 = bank.OpenRekening("voornaam", "achternaam", "6a", "8944WW", -500);
    //        Assert.AreEqual(-1, rekeningNr3);
    //        int rekeningNr4 = bank.OpenRekening("voornaam", "achternaam", "6a", "8944WW", -1000);
    //        Assert.AreEqual(-1, rekeningNr4);
    //    }

    //    [Test]
    //    public void ZoekRekening()
    //    {
    //        string bankNaam = "TestBank";
    //        Bank bank = new Bank(bankNaam);
    //        int rekeningNr0 = bank.OpenRekening("voornaam1", "achternaam1", "6a", "8944WW");
    //        int rekeningNr1 = bank.OpenRekening("voornaam2", "achternaam2", "6a", "8944WW");

    //        Assert.AreEqual(rekeningNr0, bank.ZoekRekening(rekeningNr0).Nr);
    //        Assert.AreEqual(rekeningNr1, bank.ZoekRekening(rekeningNr1).Nr);
    //    }

    //    [Test]
    //    public void GeldStorten()
    //    {
    //        string bankNaam = "TestBank";
    //        Bank bank = new Bank(bankNaam);
    //        int rekeningNr0 = bank.OpenRekening("voornaam", "achternaam", "6a", "8944WW");

    //        Rekening r = bank.ZoekRekening(rekeningNr0);
    //        Assert.AreEqual(true, r.GeldStorten(100));
    //        Assert.AreEqual(false, r.GeldStorten(-100));
    //        Assert.AreEqual(false, r.GeldStorten(0));
    //    }

    //    [Test]
    //    public void GeldOpnemen()
    //    {
    //        string bankNaam = "TestBank";
    //        Bank bank = new Bank(bankNaam);
    //        int rekeningNr0 = bank.OpenRekening("voornaam1", "achternaam2", "6a", "8944WW", startSaldo: 1000, salaris: 500);
    //        //kan 250 Euro rood staan (500/2)

    //        Rekening r0 = bank.ZoekRekening(rekeningNr0);
    //        Assert.AreEqual(true, r0.GeldOpnemen(500));
    //        Assert.AreEqual(500, r0.Saldo);
    //        Assert.AreEqual(false, r0.GeldOpnemen(-500));
    //        Assert.AreEqual(500, r0.Saldo);
    //        Assert.AreEqual(false, r0.GeldOpnemen(0));
    //        Assert.AreEqual(500, r0.Saldo);
    //        Assert.AreEqual(true, r0.GeldOpnemen(500));
    //        Assert.AreEqual(0, r0.Saldo);

    //        //rood staan
    //        Assert.AreEqual(true, r0.GeldOpnemen(125));
    //        Assert.AreEqual(-125, r0.Saldo);
    //        Assert.AreEqual(true, r0.GeldOpnemen(125));
    //        Assert.AreEqual(-250, r0.Saldo);

    //        //te veel rood staan
    //        Assert.AreEqual(false, r0.GeldOpnemen(10));
    //        Assert.AreEqual(-250, r0.Saldo);


    //        int rekeningNr1 = bank.OpenRekening("voornaam2", "achternaam2", "6a", "8944WW", startSaldo: 1000);
    //        Rekening r1 = bank.ZoekRekening(rekeningNr1);
    //        //kan niet rood staan
    //        Assert.AreEqual(true, r1.GeldOpnemen(500));
    //        Assert.AreEqual(500, r1.Saldo);
    //        Assert.AreEqual(true, r1.GeldOpnemen(500));
    //        Assert.AreEqual(0, r1.Saldo);
    //        //proberen rood te staan
    //        Assert.AreEqual(false, r1.GeldOpnemen(10));
    //        Assert.AreEqual(0, r1.Saldo);
    //    }

    //    [Test]
    //    public void TestOvermaken()
    //    {
    //        Bank bank = new Bank("ing");
    //        int rekeningNrJoris = bank.OpenRekening("Joris", "lops", "6a", "8944AM");
    //        int rekeningNrDick = bank.OpenRekening("Dick", "bruin", "20", "2334WW", 1000, 500);

    //        Rekening joris = bank.ZoekRekening(rekeningNrJoris);
    //        Rekening dick = bank.ZoekRekening(rekeningNrDick);

    //        Assert.AreEqual(false, joris.GeldOvermaken(dick, 100)); //joris heeft geen geld dus kan niet overmaken
    //        Assert.AreEqual(true, dick.GeldOvermaken(joris, 1000));
    //        Assert.AreEqual(0, dick.Saldo);
    //        Assert.AreEqual(true, dick.GeldOvermaken(joris, 250));
    //        Assert.AreEqual(-250, dick.Saldo);
    //        Assert.AreEqual(false, dick.GeldOvermaken(joris, 10));
    //        Assert.AreEqual(-250, dick.Saldo);            
    //    }

    //    [Test]
    //    public void AccountVerwijderen()
    //    {
    //        Bank bank = new Bank("ing");
    //        int rekeningNrJoris = bank.OpenRekening("Joris", "lops", "6a", "8944AM");
    //        int rekeningNrDick = bank.OpenRekening("Dick", "bruin", "20", "2334WW", 1000, 500);

    //        Assert.AreEqual(rekeningNrJoris, bank.VerwijderRekening(rekeningNrJoris).Nr);
    //        Assert.AreEqual(null, bank.ZoekRekening(rekeningNrJoris));
    //    }

    //    [Test]
    //    public void RenteUitkeren()
    //    {
    //        Bank bank = new Bank("ing");
    //        int rekeningNrJoris = bank.OpenRekening("Joris", "lops", "6a", "8944AM");
    //        int rekeningNrDick = bank.OpenRekening("Dick", "bruin", "20", "2334WW", 1000, 500);
    //        int rekeningNrJorisNegatief = bank.OpenRekening("Joris", "Lops", "20", "2334WW", 0, 1000);

    //        Rekening joris = bank.ZoekRekening(rekeningNrJoris);
    //        Rekening dick = bank.ZoekRekening(rekeningNrDick);
    //        Rekening jorisNegatief = bank.ZoekRekening(rekeningNrJorisNegatief);
    //        jorisNegatief.GeldOpnemen(500);
    //        Assert.AreEqual(-500, jorisNegatief.Saldo);

    //        decimal totaaluitgekeerd = bank.RenteUitkeren(5);
    //        Assert.AreEqual(50, totaaluitgekeerd);

    //        Assert.AreEqual(0, joris.Saldo);
    //        Assert.AreEqual(1050, dick.Saldo);
    //        Assert.AreEqual(-500, jorisNegatief.Saldo); //sociale bank
    //    }
    //}
}
