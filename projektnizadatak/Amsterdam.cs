using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektnizadatak
{
    class Amsterdam
    {

        private string info = "1.Dan Beograd-Amsterdam\n"+
        "Dolazak na aerodrom “Nikola Tesla” dva sata pre poletanja aviona.Čekiranje na let low cost avio kompanijom Transavia.Po sletanju na aerodrom ’’Schiphol’’, individualan transfer do hotela.Smeštaj i slobodno vreme. Amsterdam je najveći i glavni grad Holandije.Osnovan je u 12.Veku kao malo ribarsko mesto na reci Amstel, " +
        "a danas je značajan finansijski i kulturni centar Holandije.Staro jezgro grada predstavlja svojevrstan muzej na otvorenom i veoma je atraktivan posetiocima.Znamenitosti poput Rijks muzeja, Rembrantove kuće i muzeja Vinsenta Van Goga najbolje oslikavaju zlatno doba Holandskog slikarstva.Najlepši način da vidite grad je " +
        "definitivno vožnja brodom kroz mnogobrojne kanale ovog grada odakle ćete imati priliku da vidite prepoznatljivu holandsku arhitekturu, mnogobrojne mostove i najpoznatije tornjeve ovog grada.\n" +

        "2.Dan Amsterdam\n" +
        "Doručak.Slobodno vreme za individualne aktivnosti i samostalna razgledanja. Noćenje.\n"+
        "Predlažemo da razgledanja započnete od glavnog gradskog trga Dam odakle će vam sve znamenitosti biti lako dostupne.Da ovom trgu nalazi se Kraljevska palata, Nova crkva i muzej voštanih figura Madam Tiso. U neposrednoj blizini nalazi se i kuća Ane Frank koja priča svoju priču iz Drugog svetskog rata gde su se Ana i " +
        "njena porodica u potkrovlju kuće dve godine sakrivali i tajno snadbevali dnevnim potrepštinama.Nažalost 04.Avgusta 1944 tajna je razotkrivena i Ana i članovi njene porodice odvedeni su u koncentracione logore, a jedino je njen otac Oto Frank preživeo. U popodnevnim satima predlažemo da posetite čuveni Vondel park" +
        " koji se nalazi u južnom delu grada na samo nekoliko minuta hoda od muzejske četvrti.\n" +

        "3.Dan Amsterdam\n" +
        "Doručak.Slobodno vreme za individualne aktivnosti i samostalna razgledanja. Noćenje.\n"+
        "Amsterdam je grad sa velikim brojem muzeja, a jedan od najzanimljivijih je svakako i muzej pomorstva u kojem se nalazi i nedavno obnovljen brod iz doba osvajanja Indije usidren odmah uz obalu muzeja. Jedan od najboljih načina da obiđete grad je definitivno biciklom koji je ovde glavno prevozno sredstvo.  " +
        "Čitavim gradskim jezgrom uz kanale dominiraju kuće iz 17. Veka pa verujemo da će vam razgledanje grada na ovim putem naročito ostati u lepom sećanju. Obavezno probajte pomfrit! Teško ćete pronaći restoran ili kisok brze hrane koji ne služe “Vlaamse frites” odnosno flamanski pomfrit.Iako je osnovna asocijacija " +
        "na holandsku kuhinju riba, grašak, krompir i čuveni holandski sirevi, pomfrit sa majonezom je najpopularniji.\n" +

        "4.Dan Amsterdam-Beograd\n" +
        "Doručak. Napuštanje hotela. Individualan transfer na aerodrom ’’Schiphol’’. Čekiranje na let low cost avio kompanijom Transavia. Polazak za Beograd.Kraj usluga.";
       
        private string cena = "Datum polaska:	28.12.	04.01.	11.01.	18.01.	25.01.\n"+
        "Datum povratka:	31.12.	07.01.	14.01.	21.01.	28.01.\n"+
        "Polasci u januaru Od 579	Od 499	Od 369	Od 299	od 299\n"+

        "Datum polaska:	01.02.	04.01.	15.02.	20.02.	22.02.	01.03.\n" +
        "Datum povratka:	04.02.	11.02.	18.02.	23.02.	25.02.	04.03.\n" +
        "Polasci u februaru Od 299	Od 339	Od 299	Od 299	od 299	od 299\n" +

        "Cene su izražene u eurima po osobi\n" +

        "CENA ARANŽMANA UKLJUČUJE:\n" +
        "povratnu avio kartu sa svim taksama na relaciji Beograd-Amsterdam-Beograd low cost avio kompanijom Transavia\n" +
        "ručni prtljag dimenzija 55cm x 40cm x 20cm, maksimalne težine 10kg\n" +
        "boravak u hotelu 3* na bazi 3 noćenja sa doručkom\n"+
        "organizaciju putovanja\n"+
        "CENA ARANŽMANA NE UKLJUČUJE:\n"+
        "individualan transfer aerodrom-hotel-aerodrom\n"+
        "individualno zdravstveno osiguranje\n"+
        "čekirani prtljag\n"+
        "obrok i piće na letu, moguće uz doplatu tokom leta\n" +
        "NAČINI PLAĆANJA:\n" +
        "Plaćanje se vrši u dinarskoj protivvrednosti po prodajnom kursu UniCredit Banke za efektivu na dan uplate.\n" +
        "Uplata akontacije 30% prilikom rezervacije, ostatak 70 % najkasnije 15 dana pre polaska gotovinom, karticama, uplatom na račun ili čekovima na 6 mesečnih rata.\n" +
        "Uplatom celokupnog iznosa karticama banke Intesa na 12 jednakih mesečnih rata.\n" +
        "DOPLATE:\n"+
        "za 1/1 sobu na upit\n"+
        "čekirani prtljag 15kg 19 eur po pravcu, 20 kg 24 eur po pravcu (plaća se prilikom rezervacije)";

        private string napomena = "Važne napomene\n" +
        "Otkaz od strane putnika:\n" +
        "U slučaju odustajanja od putovanja korisnik je dužan da organizatoru putovanja nadoknadi realne troškove avio karte i smeštaja prema pravilima koje postavi avio kompanija " +
        "odnosno smeštajni objekat.\n" +
        "Za program putovanja pod posebnim uslovima, a vezano za prodaju promotivnih tarifa avio karata kod avio kompanije, primenjuju se posebni uslovi otkazivanja, odnosno kupljena " +
        "karta ne može se zameniti niti refundirati, kao ni iznos aerodromski taksi, te ne podlezu uslovima otkaza i odredbama o naknadi iz čl.12. ovim Opštih uslova jer predstavlja STVARNO PRIČINJEN TROŠAK.\n" +
        "Takodje, stvarno učinjeni trošak predstavlja trošak rezervacije smeštaja kroz rezervacione hotelske sisteme koji uslovljavaju nemogućnost promene i refundacije.\n" +
        "Prijem pisanih  reklamacija na adresu Knez MihaIlova 30/II i na mail zalbe @flyflytravel.com.Rok za ulaganje reklamacija je 8 dana od zavrsetka putovanja, a rok za resavanje o " +
        "reklamaciji je 8 dana od njenog prijema.U hitnim slucajevima, putnik moze kontaktirati Organizatora na telefon 011/2185-616.\n" +
        "IZJAVLJUJEM DA SU MI URUCENI OUP  I DA SAM UPOZNAT SA PROGRAMOM PUTOVANJA, USLUGAMA I OPSTIM USLOVIMA PUTOVANJA ORGANIZATORA PUTOVANJA I DA IH U POTPUNOSTI PRIHVATAM.\n" +
        "Napomene u vezi avio prevoza\n" +
        "Vreme poletanja aviona određuje avio kompanija.Postoji mogućnost jutarnjih ili večernjih letova i da se u tom slučaju ne stigne na predviđeni obrok.To ne može biti predmet žalbe putnika, jer je činjenično " +
        "stanje nastupilo usled objektivnih okolnosti na koje organizator putovanja nije mogao da utiče. Postoji mogućnost da se dobije hladni obrok ili lanč paket (zavisi da li smeštajni objekat ima tu mogućnost)." +
        " Prilikom uplate rezervacije putnici su u obavezi da dostave kopiju prve strane važećeg pasoša.U suprotnom, agencija ne snosi odgovorost ako se avio karte odštampaju sa pogrešnim imenima, dok putnici snose " +
        "troškove štampanja novih karata.\n" +
        "** Rok za izdavanje karte je 01h od trenutka pravljenja rezervacije! Kako su u pitanju promotivne karte avio kompanije, kupljena karta ne može se zameniti niti refundirati, kao ni iznos aerodromskih taksi." +
        "U slucaju otkaza aranzmana avio karta ne podleze refundaciji.\n" +
        "IZJAVLJUJEM DA SU MI URUCENI OUP  I DA SAM UPOZNAT SA PROGRAMOM PUTOVANJA, USLUGAMA I OPSTIM USLOVIMA PUTOVANJA ORGANIZATORA PUTOVANJA I DA IH U POTPUNOSTI PRIHVATAM.\n" +

        "Opšte napomene\n" +
        "Organizator putovanja zadržava pravo promene pojedinih sadržaja u programu.\n" +
        "Za sve informacije date usmenim putem, agencija ne snosi odgovornost.\n" +
        "Proveriti 2 dana pre putovanja tačno mesto sastanka i vreme poletanja aviona.\n" +
        "Potpisnik ugovora o putovanju ili predstavnici grupe putnika obavezni su da sve putnike upoznaju sa ugovorenim programom putovanja, uslovima plaćanja i viziranja i Opštim uslovima putovanja organizatora putovanja.\n" +
        "Svi putnici dužni su da se sami upoznaju sa propisanim pravilima ponašanja, kao zdravstvenim, carinskim i graničnim formalnostima zemalja u koje putuju.\n" +
        "Organizator putovanja zadržava pravo promene programa putovanja usled nepredviđenih objektivnih okolnosti (npr.gužva na granicama, gužva u saobraćaju, zatvaranje nekog od lokaliteta predviđenog za obilazak…)\n" +
        "Rok za prijavu uglavnom zavisi od popunjenosti.\n" +
        "Maloletni putnici, koji ne putuju u pratnji roditelja, prilikom putovanja moraju imati overenu saglasnost  oba roditelja.Ukoliko putuju u pratnji samo jednog roditelja, moraju imati overenu saglasnost drugog roditelja.\n" +
        "Putnici koji poseduju inostrani pasoš dužni su sami da se informišu kod nadležnog konzulata o uslovima koji važe za odredišnu ili tranzitnu zemlju (vizni, carinski, zdravstveni i dr.) i da sami blagovremeno i " +
        "uredno obezbede potrebne uslove i isprave.\n" +
        "U slučaju nedovoljnog broja putnika za relizaciju aranžmana, krajnji rok za obaveštenje o otkazu aranžmana je 5 dana pre datuma polaska.\n" +
        "Organizator putovanja zadržava pravo korekcije ugovorene cene pre početka putovanja usled promene u kursu razmene valute ili promene u tarifama prevoznika i u zakonom predviđenim slučajevima.\n" +
        "Uz ovaj program važe Opšti uslovi putovanja organizatora putovanja.\n" +
        "Aranžman je rađen na bazi od minimum 2 putnika.";

        private string smestaj = "Putnici će biti smešteni u navedenim ili sličnim hotelima na osnovu raspoloživosti. Neki od hotela sa kojima sarađujemo:\n" +

        "Prinsen\n" +
        "ADDRESS:" +
        "VONDELSTRAAT 36-38 1054 GE AMSTERDAM\n" +
        "Jedan od naših najboljih izbora u Amsterdamu.Istorijski Prinsen hotel je sagradio poznati arhitekta P.J.H.Cuipers.Sve sobe imaju TV sa ravnim ekranom i besplatan Wi-Fi.Najveće sobe su četvorokrevetne, " +
        "od kojih svaka ima sopstveno kupatilo.\n" +

        "Cornelisz\n" +
        "ADDRESS:" +
        "PIETER CORNELISZ. HOOFTSTRAAT 24 1071 BX AMSTERDAM\n" +
        "Hotel Cornelisz se nalazi u ulici P.C.Hoftstrat, koja je jedna od najekskluzivnijih trgovačkih ulica u Amsterdamu.Nudi sobe sa besplatnim bežičnim internetom i flat-screen TV-om.Trg Lejdse je udaljen 5 minuta hoda. \n" +

        "Central Park\n" +
        "ADDRESS:" +
        "WALDECK PYRMONTLAAN 9 1075 BT AMSTERDAM\n" +
        "Hotel Central Park se nalazi u tihoj rezidencijalnoj oblasti u četvrti Aud Zejd (Oud Zuid), na samo 100 metara od Parka Vondel. U hotelu se besplatno može koristiti bežični internet.\n" +

        "Hampshire - Theatre District\n" +
        "ADDRESS:" +
        "NASSAUKADE 387-390 - 1054 AE - AMSTERDAM, NEDERLAND\n" +
        "Hotel Eden Theatre District se nalazi na idealnom položaju u Amsterdamu, preko puta živahnog trga Leidseplein.Svaka soba ima TV sa ravnim ekranom i sistemom filmova na zahtev. Hotel nudi savremene sobe sa modernim sadržajima.";


        public string Info { get => info; set => info = value; }
        public string Cena { get => cena; set => cena = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public string Smestaj { get => smestaj; set => smestaj = value; }
    }
}
