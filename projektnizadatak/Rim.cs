using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektnizadatak
{
    class Rim
    {

        private string info = "1.dan BEOGRAD-RIM\n" +

        "Sastanak grupe na aerodromu “Nikola Tesla” u Beogradu ispred šaltera poslovnice Fly Fly Travel-a dva sata pre poletanja. Direktan let za Rim avio kompanijom Air Sebia. Sledi panoramsko razgledanje grada autobusom sa vodičem na srpskom jeziku: Terme Karakala, Bazilika Svetog Jovana Lateranskog, Bazilika velike Svete Marije, Termini, trg Republike, ulica Nacionale, trg Barberini, ulica Veneto, villa Borgeze, zamak Svetog Anđela, bazilika Svetog Petra u Vatikanu, Trastevere, Pijaca Porta Portese, Usta istine, Kampidoljo, trg Venecija, Koloseum.Po završetku obilaska transfer do hotela.Smeštaj.Slobodno vreme za individulane aktivnosti. Noćenje.\n" +

        "2.dan RIM\n" +

        "Doručak.Slobodno vreme za individualne aktivnosti.Mogućnost odlaska na poludnevni fakulativni izlet u prepodnevnim satima, šetnja baroknim trgovima: Pešačka tura počinje sa trga Venecija, nastavlja dalje prema Fontani Di Trevi, koja je dobila ime po tri ulice koje su se nekad tamo spajale.Sledi šetnja do Španskog trga sa fontanom koju su Italijani nazvali “Barcaccia” zbog svog oblika čamca, a tu su i Španske stepenice.Razgledanje se nastavlja posetom Panteonu, antičkom rimskom hramu koji je sagradio car Hadrijan u drugom veku.Sledi trg Navona sa svoje tri fontane, a tu je i crkva Svete Agnese arhitektonsko delo čuvenog Borominija.Trg Navona je napravljen na antičkom stadionu sagrađenom za vreme cara Domicijana. Po završetku šetnje, slobodno vreme za individulane aktivnosti.Noćenje.\n"
        +
        "Cena izleta šetnja baroknim trgovima sa vodičem na srpskom jeziku 20 EUR po osobi.\n" +

        "3.dan RIM\n" +

        "Doručak.Slobodno vreme za individulane aktivnosti ili mogućnost poludnevne fakultativne posete vatikanskim muzejima, Sikstinskoj kapeli i crkvi Svetog Petra.Muzeji Vatikana sadrže fenomenalna remek - dela u palatama koje su originalno sagrađene za pape iz zlatnog doba renesanse kao što su Julius II, Innocent VIII i Sixtus IV.Većina kasnijih postavki datira iz 18.tog veka.Posebno se ističe Sikstinska kapela sa delima Mikelanđela, Rafaela, Peruđina, Botičelija i drugih svetski poznatih slikara.U unutrašnjosti najveće crkve na svetu, crkve Svetog Petra, nalazi se čuvena „Pjeta“, delo renesansnog" +
        "umetnika Mikelanđela. Obilazak se završava na veličanstvenom trgu ispred same crkve, koji je uredio Bernini predstavnik italijanskog baroka.Slobodno poslepodne. Noćenje.\n" +

        "Cena izleta poseta vatikanskim muzejima, Sikstinskoj kapeli i crkvi Svetog Petra 45 EUR po osobi.U cenu izleta uračunat je vodič na srpskom jeziku i sve ulaznice. U cenu izleta nije uključen transfer do Vatikana.\n" +


        "4.dan RIM - BEOGRAD\nDoručak.Odjava iz hotela i ostavljanje prtljaga u prostoriji namenjenoj za to.Slobodno vreme do polaska transfera na aerodrom.Direktan let za Beograd avio kompanijom Air Serbia. Kraj usluga.";

        private string cena = "Datum polaska:	16. Februar	\n" +
        "Datum povratka: 19.Februar \n" +
        "Hotel 3 * centar grada\n" +

        "Cena 269 eur\n" +

        "* Dan zaljubljenih\n" +

        "Cena 269 eur\n" +
        "Cene su izražene u eur po osobi u dvokrevetnoj sobi'n" +

        "CENA PAKET Aranžmana UKLJUČUJE:\n" +
        "Kompletnu organizaciju puta,\n" +
        "Avio kartu na relaciji Beograd - Lisabon - Beograd avio kompanijom Air Serbia,\n" +
        "Čekirani prtljag do 23 kg i ručni do 10 kg dimenzija 55x40x20cm," +
        "Transfer aerodrom-hotel - aerodrom u Rimu,\n" +
         "Panoramsko razgledanje grada u dolasku,\n" +
        "3 noćenja sa doručkom u 1 / 2 sobama u hotelu sa 3 * .\n" +
        "CENA ARANŽMANA NE OBUHVATA:\n" +
        "Aerodromske takse u iznosu od 64,78 EUR(podložne su promenama sve do dana polaska na put i plaćaju se prilikom prijave),\n" +
        "Gradska taksa u Rimu za hotele 3 * u iznosu od 4 eur po osobi i po danu, plaća se na recepciji hotela,\n" +
        "Međunarodno putno zdravstveno osiguranje,\n" +
        "Fakultativne obilaske i ulaznice za kulturno-istorijske spomenike,\n" +
        "Individualne troškove u hotelima i za vreme putovanja.\n" +
        "DOPLATE:\n" +
         "           Doplata za 1 / 1 sobu iznosi +174 eur za polaske septembar i oktobar\n" +
         "           Doplata za 1 / 1 sobu iznosi +126 eur za polaske februar i mart\n" +
        "POPUSTI:\n" +
         "           Treća odrasla osoba u 1 / 2 + 1 sobi ima popust od 10 eur\n" +
         "          Deca od 2 - 12 godina imaju popust od 15 eur u pratnji dve punoplatežne osobe\n" +
        "NAČINI PLAĆANJA :\n" +
        "Plaćanje se vrši u dinarskoj protivvrednosti po prodajnom kursu UniCredit Banke za efektivu na dan uplate.\n" +
        "Uplata akontacije od najmanje 40 % od ukupne cene aranžmana prilikom prijave ostatak najkasnije 15 dana pre polaska gotovinom, uplatom na račun, platnim karticama ili čekovima građana na 4 mesečne rate.";

        private string napomena = "Važne napomene\n" +
        "Cene su date za standardni tip sobe.Sve doplate, odnosno rezervacija bilo koje druge kategorije sobe vrši se isključivo na upit.Red leta kao i cena podložni su promeni. Potvrda rezervacije hotela čeka se minimalno 24 sata od izvršene uplate avansa.U vreme održavanja sajmova, kongresa i specijanih dogadjanja cene iz tabele ne važe.\n" +

        "OPŠTE NAPOMENE U VEZI SA AVIO PREVOZOM:\n" +
                   " Vreme poletanja aviona određuje avio kompanija. Vremena poletanja i sletanja aviona su data po lokalnim vremenima. Postoji mogućnost jutarnjih ili večernjih letova i da se u tom slučaju ne stigne na predviđeni obrok.To ne može biti predmet žalbe putnika, jer je činjenično stanje nastupilo usled objektivnih okolnosti na koje organizator putovanja nije mogao da utiče. Postoji mogućnost da se dobije hladni obrok ili lanč paket(zavisi da li smeštajni objekat ima tu mogućnost). Prilikom uplate rezervacije putnici su u obavezi da dostave kopiju prve strane važećeg pasoša. U suprotnom, agencija ne snosi odgovorost ako se avio karte odštampaju sa pogrešnim imenima, dok putnici snose troškove štampanja novih karata.\n" +

        "Opšte napomene\n" +
        "Organizator putovanja zadržava pravo promene pojedinih sadržaja u programu.\n" +
        "Za sve informacije date usmenim putem, agencija ne snosi odgovornost.\n" +
        "Proveriti 2 dana pre putovanja tačno mesto sastanka i vreme poletanja aviona.\n" +
        "Potpisnik ugovora o putovanju ili predstavnici grupe putnika obavezni su da sve putnike upoznaju sa ugovorenim programom putovanja, uslovima plaćanja i viziranja i Opštim uslovima putovanja organizatora putovanja.\n" +
        "Svi putnici dužni su da se sami upoznaju sa propisanim pravilima ponašanja, kao zdravstvenim, carinskim i graničnim formalnostima zemalja u koje putuju.\n" +
        "Organizator putovanja zadržava pravo promene programa putovanja usled nepredviđenih objektivnih okolnosti(npr.gužva na granicama, gužva u saobraćaju, zatvaranje nekog od lokaliteta predviđenog za obilazak…)\n" +
        "Rok za prijavu uglavnom zavisi od popunjenosti.\n" +
        "Maloletni putnici, koji ne putuju u pratnji roditelja, prilikom putovanja moraju imati overenu saglasnost  oba roditelja. Ukoliko putuju u pratnji samo jednog roditelja, moraju imati overenu saglasnost drugog roditelja.\n" +
        "Putnici koji poseduju inostrani pasoš dužni su sami da se informišu kod nadležnog konzulata o uslovima koji važe za odredišnu ili tranzitnu zemlju(vizni, carinski, zdravstveni i dr.) i da sami blagovremeno i uredno obezbede potrebne uslove i isprave.\n" +
        "U slučaju nedovoljnog broja putnika za relizaciju aranžmana, krajnji rok za obaveštenje o otkazu aranžmana je 5 dana pre datuma polaska.\n" +
        "Organizator putovanja zadržava pravo korekcije ugovorene cene pre početka putovanja usled promene u kursu razmene valute ili promene u tarifama prevoznika i u zakonom predviđenim slučajevima.\n" +
        "Uz ovaj program važe Opšti uslovi putovanja organizatora putovanja.";

        private string smestaj = "Putnici će biti smešteni u navedenim ili sličnim hotelima na osnovu raspoloživosti. Neki od hotela sa kojima sarađujemo:\n" +

        "Hotel Zara\n" +
        "Adresa:\n" +
                   " VIA QUATTRO FONTANE 37 - ROME 00184\n" +
        "Ovaj šarmantni hotel izgrađen 90 - tih, okružen velikim brojem radnji koje se nalaze u neposrednoj blizini. Mnoge od turističkih atrakcija su takođe u neposrednoj blizini.Lokalni javni prevoz se nalazi neposredno ispred hotela.\n" +

        "Hotel Paris\n" +
        "Adresa:\n" +
                    "VIA FIRENZE 57, 00184 ROME\n" +
        "Hotel Paris nalazi se u širem centru grada, u mirnoj ulici, jednoj od bočnih ulica u odnosu na ulicu Via Nacionale.Lociran je na samo 10 minuta hoda od Fontane di Trevi. U neposrednoj je blizini Trga Repulike gde je i istoimena metro stanica.";

        public string Info { get => info; set => info = value; }
        public string Cena { get => cena; set => cena = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public string Smestaj { get => smestaj; set => smestaj = value; }
    }
}
