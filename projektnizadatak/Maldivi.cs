using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektnizadatak
{
    class Maldivi
    {

        private string info = "Maldivi su arhipelag sačinjen od 1190 ostrva, od koji je svega dve stotine njih, naseljeno. Devet stotina preostalih ostrva je nenaseljeno i netaknute prirode, što vam daje mogućnost da sa svojim partnerom imate svo vreme sveta samo za sebe, " +
        "na najlepšem mestu za to. Voda Indijskog Okeana je na arhipelagu toliko prozirna, da je moguće besprekorno roniti i na vrlo velikim dubinama u bistroj vodi, okruženi prelepim koralima i neverovatno šarenolikim jatima riba.\n"+
        "Kupovina ili konzumiranje alkohola u javnosti je zabranjeno. Naravno, o ovoj zabrani vodite puno računa kada ste van svog odmarališta.U samim hotelima, u koktel i vinskim barovima, konzumiranje alkohola za turiste je dozvoljeno.";

        private string cena = " Cene su izrazene u evrima po osobi po nocenju\n"+

        "Holiday Island Resort&Spa 4*\n"+
         "Polupansion od 83€\n"+
        "Sun Island Resort&Spa 4*\n"+
         "Polupansion od 88€\n"+
        "Bandos Island Resort&Spa\n"+
         "Polupansion od 124€\n"+
        "Royal Island Resort&Spa\n"+
         "Polupansion od 123€\n"+
        "Filitheyo Island Resort 4*\n"+
         "Polupansion od 139€\n"+
        "Ranvelli Vilage 3*\n"+
         "Polupansion od 154€\n"+
        "Kuredu Island Resort&Spa\n"+
         "Polupansion od 173€\n"+
        "Resort Fihalhohi 3*\n"+
         "Polupansion od 138€\n"+
        "Meeru Island Resort 4 Lux*\n"+
         "Polupansion od 119€\n"+
        "Centara Ras Fushi Resort & Spa 4*\n"+
         "All inclusive  od 259€\n"+
        "Lili Beach Resort 5*\n"+
         "All inclusive  od 378€\n"+
        "Banyan tree vabbinfaru resort 5*\n"+
         "Pun pansion    od 498€\n"+
        "Centara Grand Island Resort Maldivi 5*\n"+
         "All inclusive  od 429€\n"+
        "Conrad Maldives Rangali Island 5*\n"+
         "Noćenje sa doručkom od 516€\n"+
        "The Barefoot Eco Hotel 4*\n"+
         "Noćenje sa doručkom od 78€\n"+
        "Gangehi Island Resort 4*\n"+
         "Noćenje sa doručkom od 96€";

        private string napomena = "Avio prevoz nije uključen u cenu.\n"+

        "Ponuda obuhvata samo usluge smeštaja i navedene ishrane.\n"+

        "Do svakog ostrva se stiže na različit način(brodom, hidroavionom ili unutrašnjim letom).";

        private string smestaj = "Putnici će biti smešteni u navedenim ili sličnim hotelima na osnovu raspoloživosti. Neki od hotela sa kojima sarađujemo:\n" +

        "Holiday Island Resort & Spa\n" +
        "ADDRESS:"+
        "DHIFFUSHI, SOUTH ARI ATOLL, P.O BOX\n"+
        "Odmaralište Holiday Island nalazi se na ostrvu Difuši u okviru atola Alifu Dalu, na 30 minuta vožnje avionom od Međunarodnog aerodroma Male.Ponuda obuhvata smeštaj kraj plaže, raznovrsne sportove na vodi i izlete brodom.Bungalovi u odmaralištu Holiday\n" +

        "Sun Island Resort & Spa\n" +
        "ADDRESS:"+
        "NALAGURAIDHOO, 00220 MAAMIGILI\n"+
        "Sun Island Resort & Spa – je dragulj među maldivskim porodičnim hotelima koji predstavlja jedinstvenu verziju raja na zemlji.On nudi krstarenja po fantastičnim safir lagunama od džet- skijanja, kanua, vindsurfinga ili do korišćenja katamarana.\n" +

        "Bandos Island Resort & Spa\n" +
        "ADDRESS:"+
        "BANDOS ISLAND, 08480 GRAD MALE  \n"+
        "Bandos ostrvo ima tirkiznu lagunu I bujno zelenilo sa peskovitim belim plažama, azurno plavim nebom stvara osećaj mira I spokoja. Odmaralište se nalazi 7 km od International Airport Male, sa ukupno 215 soba.\n" +

        "Royal Island Resort & Spa\n" +
        "ADDRESS:"+
        "HORUBADHOO, 06160 DHARAVANDHOO\n"+
        "Royal Island Resort and Spa se nalazi na ostrvu poznatom I kao Horubadhoo, na koralnom ostrvu Baa 118 km severozapadno od Malea. Pruža smećtaj u luksuznim vilama I apartmanima sa fantastičnim pogledom na Indijski okean.\n" +

        "Filitheyo Island Resort\n" +
        "ADDRESS:"+
        "FILITHEYO, 12060 FILITHEYO\n"+
        "Filiteyo Resort se nalazi na Faafu koralnom ostrvu, jednom od najstarijih ostrva Maldiva, koje obiluje šarenolikim podvodnim svetom i mnogobrojnim koralima. Ovde vam se nudi tirkizna laguna gde možete da uživate u sasvim intimnim večerima I relaksaciji";

        public string Info { get => info; set => info = value; }
        public string Cena { get => cena; set => cena = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public string Smestaj { get => smestaj; set => smestaj = value; }
    }
}
