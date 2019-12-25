using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektnizadatak
{
    class Dvorci
    {

        private string info = "1. dan BEOGRAD\n"+
        "Polazak iz Beograda oko 20:00 sa dogovorenog mesta(proveriti 3 dana pre putovanja tačno vreme i mesto polaska autobusa)." +
            " Noćna vožnja kroz Hrvatsku, Sloveniju i Austriju prema Nemačkoj.\n" +

        "2. dan SALZBURG – MINHEN\n" +
        "Dolazak u jutarnjim časovima u poznati austrijski grad Salzburg. Po dolasku obilazak grada: Katedrala, Glokenšpil, " +
            "Nadbiskupska palata, Mocartova kuća, Getraidegase, Mirabel dvorac i vrt... Slobodno vreme. Nastavak putovanja prema Minhenu. " +
            "Smeštaj u hotel.Slobodno vreme za individualne aktivnosti.Noćenje.\n" +

        "3. dan Minhen\n" +
        "Doručak.Panoramski obilazak Minhena: dvorac Nimfenburg – letnja rezidencija dinastije Vitelsbah, kraljevska rezidencija, " +
            "Nacionalna opera i pozorište, galerija nove i stare Pinakoteke, glavni trg Marienplac sa starom i novom zgradom opštine i" +
            " čuvenim Glokenšpilom (zvona), pijaca Viktualienmarkt... Nakon obilaska slobodno vreme za šetnju i individualne aktivnosti " +
            "(preporuka: pinakoteke, muzej BMW, Olimpijsko selo...). Povratak u hotel.U večernjim časovima mogućnost organizovanja " +
            "fakultativnog odlaska na večeru u jednu od najpoznatijih pivnica.Noćenje.\n" +

        "4. dan Minhen – DVORAC NOJŠVANŠTAJN – DVORAC LINDERHOF – FISEN – MINHEN\n" +
        "Doručak. Odlazak do dvorca Nojšvanštajn, koji je podignut na nepristupačnoj litici u stilu staronemačkih viteških zamkova." +
            "Inspirisao je Volta Diznija na izradu prepoznatljive “špice” za brojne crtane filmove. Nastavak putovanja do gradića Fisen, " +
            "koji se nalazi na najvišoj tački u Bavarskoj (808m nadmorske visine). Nakon obilaska, nastavak putovanja do dvorca Linderhof, " +
            "palate bavarskog kralja Ludviga II(druga polovina XIX veka). Prvobitno je izgrađen za potrebe lova a za Ludvigovog oca Maksimilijana II, " +
            "kasnije ga je Ludvig II preuredio, u skladu sa svojim ukusom za ekscentričnost i pozlatio njegove odaje.Povratak u Minhen u večernjim časovima.Noćenje.\n" +

        "5. dan MINHEN - DVORAC HERENHIMZE\n"+
        "Doručak.Nakon doručka napuštanje hotela. Polazak prema najvećem bavarskom jezeru Himze. Po dolasku vožnja brodom do ostrva na kojem se nalazi " +
            "prelepi dvorac Herenhimze. Obilazak dvorca, koji je podignut poslednji, u rokoko stilu, po uzoru na Versaj. Nakon obilaska povratak brodom sa ostrva. " +
            "U poslepodnevnim časovima polazak za Beograd. Noćna vožnja kroz Austriju, Sloveniju i Hrvatsku prema Beogradu.\n"+

        "6. dan BEOGRAD\n"+
        "Dolazak u Beograd u ranim jutarnjim časovima. (Kraj usluga )";

        private string cena = " Datum polaska:	09.03.2018	18.05.2018	22.06.2018	20.07.2018	21.08.2018\n" +
        "Datum povratka:	14.03.2018	23.05.2018	27.06.2018	25.07.2018	26.08.2017\n" +
        "Hotel 3*	179 €	\n" +
        "159 €\n"+

        "159 €\n"+

        "159 €	169 €\n"+
        "CENA ARANŽMANA OBUHVATA:\n"+
        "prevoz autobusom turističke klase na relacijama navedenim u programu(visokopodni, sa klimom, TV-om i audio opremom)\n" +
        "smeštaj u Minhenu(3 noćenja sa doručkom – kontinentalni švedski sto) u hotelu sa 3* u 1/2 i 1/2+1 sobama\n" +
        "obilaske prema programu(Minhen, Salzburg)\n"+
        "troškove organizacije i vođenja aranžmana\n"+
        "usluge licenciranog pratioca grupe\n"+
        "CENA ARANŽMANA NE OBUHVATA:\n"+
        "međunarodno zdravstveno osiguranje za ceo period boravka(izdaje se u agenciji, osigurana suma je 30.000 €) – 7 € (osobe od 19 – 69 god.), 5 € (deca od 0 meseci – 18 god.),  " +
            "13 € (osobe od 70 – 84 god.) .)  – PREPORUKA AGENCIJE JE DA PUTNIK POSEDUJE OVU VRSTU OSIGURANJA\n" +
        "troškove rezervacija, ulaznica i prevoza za dvorce Linderhof, Nojšvanštajn i Herenhimze – 40 € (plaćanje na licu mesta)\n" +
        "vožnju brodom do zamka Herenhimze(povratna karta, plaća se na licu mesta) – 7 € odrasli / 4 € deca od 4 – 12 godina / besplatno deca od 0 – 4 godine\n" +
        "ulaznice i fakultativne izlete" ;

        private string napomena = "Važne napomene\n" +
        "Cene su date za standardni tip sobe.Sve doplate, odnosno rezervacija bilo koje druge kategorije sobe vrši se isključivo na upit.\n" +
        "Red leta kao i cena podložni su promeni.\n" +
        "Potvrda rezervacije hotela čeka se minimalno 24 sata od izvršene uplate avansa.\n" +
        "U vreme održavanja sajmova, kongresa i specijanih dogadjanja cene iz tabele ne važe.\n" +
        "Opšte napomene u vezi sa avio prevozom:\n" +
        "Vreme poletanja aviona određuje avio kompanija.Vremena poletanja i sletanja aviona su data po lokalnim vremenima. Postoji mogućnost jutarnjih ili večernjih letova " +
        "i da se u tom slučaju ne stigne na predviđeni obrok.To ne može biti predmet žalbe putnika, jer je činjenično stanje nastupilo usled objektivnih okolnosti na koje organizator " +
        "putovanja nije mogao da utiče. Postoji mogućnost da se dobije hladni obrok ili lanč paket (zavisi da li smeštajni objekat ima tu mogućnost).\n" +
        "Prilikom uplate rezervacije putnici su u obavezi da dostave kopiju prve strane važećeg pasoša.U suprotnom, agencija ne snosi odgovorost ako se avio karte odštampaju sa pogrešnim imenima, " +
        "dok putnici snose troškove štampanja novih karata.\n" +
        "Napomene za fakultativne izlete\n" +
        "Cena se uglavnom sastoji od troškova rezervacije, prevoza, vodiča, ulaznica, organizacije.\n" +
        "Termini fakultativnih izleta su promenljivi i zavise od slobodnih termina po lokalitetima, broja prijavljenih putnika i objektivnih okolnosti.\n" +
        "Fakultativni izleti nisu obavezni deo programa i zavise od broja prijavljenih putnika (minimum za realizaciju izleta je 15 punoplatežnih putnika). U slučaju manjeg broja prijavljenih " +
        "putnika cena izleta se povećava.\n" +
        "Fakultativni izleti su organizovani od strane lokalne agencije, ino-partnera Organizatora putovanja.Svu odgovornost prilikom izvođenja fakultativnih izleta snosi ino-partner.\n" +
        "Opšte napomene\n" +
        "Organizator putovanja zadržava pravo promene pojedinih sadržaja u programu.\n" +
        "Za sve informacije date usmenim putem, agencija ne snosi odgovornost.\n" +
        "Proveriti 2 dana pre putovanja tačno mesto sastanka i vreme poletanja aviona.\n" +
        "Potpisnik ugovora o putovanju ili predstavnici grupe putnika obavezni su da sve putnike upoznaju sa ugovorenim programom putovanja, uslovima plaćanja i viziranja i Opštim uslovima " +
        "putovanja organizatora putovanja.\n" +
        "Svi putnici dužni su da se sami upoznaju sa propisanim pravilima ponašanja, kao zdravstvenim, carinskim i graničnim formalnostima zemalja u koje putuju.\n" +
        "Organizator putovanja zadržava pravo promene programa putovanja usled nepredviđenih objektivnih okolnosti (npr.gužva na granicama, gužva u saobraćaju, zatvaranje nekog od lokaliteta " +
        "predviđenog za obilazak…)\n" +
        "Rok za prijavu uglavnom zavisi od popunjenosti.\n" +
        "Maloletni putnici, koji ne putuju u pratnji roditelja, prilikom putovanja moraju imati overenu saglasnost  oba roditelja.Ukoliko putuju u pratnji samo jednog roditelja, moraju imati " +
        "overenu saglasnost drugog roditelja.\n" +
        "Putnici koji poseduju inostrani pasoš dužni su sami da se informišu kod nadležnog konzulata o uslovima koji važe za odredišnu ili tranzitnu zemlju (vizni, carinski, zdravstveni i dr.) " +
        "i da sami blagovremeno i uredno obezbede potrebne uslove i isprave.\n" +
        "U slučaju nedovoljnog broja putnika za relizaciju aranžmana, krajnji rok za obaveštenje o otkazu aranžmana je 5 dana pre datuma polaska.\n" +
        "Organizator putovanja zadržava pravo korekcije ugovorene cene pre početka putovanja usled promene u kursu razmene valute ili promene u tarifama prevoznika i u zakonom predviđenim slučajevima.\n" +
        "Uz ovaj program važe Opšti uslovi putovanja organizatora putovanja.";

        private string smestaj = "Putnici će biti smešteni u navedenim ili sličnim hotelima na osnovu raspoloživosti. Neki od hotela sa kojima sarađujemo:\n" +

        "Mercure München Ost-Messe\n"+
        "ADDRESS:"+
        "KRONSTADTER STR. 12\n"+
        "Ovaj hotel sa 3 zvezdice nalazi se na 3 km od minhenskog izložbenog centra ICM i na 30 minuta vožnje javnim prevozom od centra Minhena.U ponudi su zvučno izolovane sobe i besplatan bežični internet.\n"+

        "Gasthof zur Post\n"+
        "ADDRESS:"+
        "BODENSEESTRASSE 4A, 81241 MÜNCHEN, GERMANY\n"+
        "Ovaj hotel sa 3 zvezdice nalazi se u okrugu Pazing u Minhenu, na 12 minuta vozom od centra Minhena.Gasthof Zur Post nudi sobe u seoskom stilu, 3 bavarska restorana i pivsku baštu.Svetle sobe hotela Gasthof Zur Post kompletno su renovirane 2011. godine.";

        public string Info { get => info; set => info = value; }
        public string Cena { get => cena; set => cena = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public string Smestaj { get => smestaj; set => smestaj = value; }

    }
}
