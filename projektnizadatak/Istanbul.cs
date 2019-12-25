using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektnizadatak
{
    class Istanbul
    {

        private string info = "1. Dan Beograd-Istanbul\n" +
            "Dolazak na aerodrom “Nikola Tesla” dva sata pre poletanja aviona.Čekiranje na let avio kompanijom Atlas.Po sletanju na aerodrom ’’Ataturk’’, " +
            "organizovan transfer do izabranog hotela. Smeštaj i slobodno vreme. Noćenje.\n" +

            "2. Dan Istanbul\n" +
            "Doručak.Slobodno vreme za individualne aktivnosti i razgledanja.Čuveni Carigrad svojom burnom istorijom i mirisom orijenta ostavlja neponovljiv "+
            "utisak na svakog putnika.  Aja Sofija, nekada najveća hrišćanska crkva na svetu i Plava Džamija sa svojih 6 minareta, dominantne su građevine na " +
            "trgu Sultanahmet. Iznad njih na uzvišenju nalazi se raskošna palata sultana Topkapi. Hipodrom iz doba Konstantinove vladavine, Bazilika cisterne, " +
            "duh orijenta, džamije, opojni mirisi, Kapali čaršija, Ordu Džadesi.  Slobodno vreme za uživanje- preporučujemo riblje specijalitete na Kumkapiju, " +
            "najlepši pogled sa Sulejmanije, tradicionalnu kafu kod Ejupove džamije, šoping na Egipatskoj pijaci ili u Istiklal ulici. Noćenje.\n" +

            "3. Dan Istanbul\n" +
            "Doručak.Slobodno vreme za individualne aktivnosti i razgledanja.Preporučujemo krstarenje Bosforom - momenat kada sa jedne strane vidite kopno Azije, " +
            "a sa druge evropsko kopno.U povratku možete prošetati preko Galata mosta, obići Galata kulu, taverne i poslastičarnice u novom evropskom delu.Noćenje.\n" +

            "4. Dan Istanbul-Beograd\n" +
            "Doručak. Napuštanje hotela, opraštaj od starog Konstantinopolja i i organizovan transfer do aerodroma ’’Ataturk’’.  Čekiranje za let za Beograd kompanijom Atlas (Kraj usluga).";

            private string cena = "Januar\n" +
            "Datum polaska:	05.01.	10.01.	17.01.	24.01.	31.01\n" +
            "Datum povratka:	08.01.	13.01.	20.01.	27.01.	03.02\n" +
            "Hotel Hotel 3*	od 209 eur od 169 eur od 189 eur od 189 eur od 189 eur\n" +
            "Hotel 4*	od 229 eur od 189 eur od 209 eur od 209 eur od 209 eur\n" +
            "Februar\n" +
            "Datum polaska:	07.02.	14.02.	21.02.	28.02.\n" +
            "Datum povratka:	10.02.	17.02.	24.02.	03.03.\n" +
            "Hotel Hotel 3*	od 199 eur od 199 eur od 209 eur od 209 eur\n" +
            "Hotel 4*	od 219 eur od 219 eur od 229 eur od 229 eur\n" +
            "Mart\n" +
            "Datum polaska:	07.03.	14.03.	21.03.	28.03.\n" +
            "Datum povratka:	10.03.	17.03.	24.03.	31.03.\n" +
            "Hotel Hotel 3*	od 169 eur od 199 eur od 209 eur od 199 eur\n" +
            "Hotel 4*	od 189 eur od 219 eur od 229 eur od 219 eur\n" +
            "April\n" +
            "Datum polaska:	06.04.	13.04.	20.04.	27.04.\n" +
            "Datum povratka:	09.04	16.04.	23.04.	30.04.\n" +
            "Hotel Hotel 3*	od 189 eur od 189 eur od 169 eur od 199 eur\n" +
            "Hotel 4*	od 209 eur od 209 eur od 189 eur od 219 eur\n" +
            "Maj\n" +
            "Datum polaska:	04.05.	11.05.	18.05.	25.05.\n" +
            "Datum povratka:	07.05.	14.05.	21.05.	28.05.\n" +
            "Hotel Hotel 3*	od 189 eur od 199 eur od 189 eur od 169 eur\n" +
            "Hotel 4*	od 209 eur od 219 eur od 209 eur od 189 eur\n" +
            "CENA ARANŽMANA UKLJUČUJE:\n" +
            "povratnu avio kartu na relaciji Beograd-Istanbul-Beograd avio kompanijom Atlas\n" +
            "ručni prtljag od 7kg(20x40x55) i čekirani prtljag od 30kg\n" +
            "boravak u izabranom hotelu na bazi 3 noćenja sa doručkom(švedski sto)\n" +
            "privatni transfer aerodrom-hotel-aerodrom\n" +
            "organizaciju putovanja\n" +
            "CENA ARANŽMANA NE UKLJUČUJE:\n" +
            "aerodromske takse u iznosu od 35,05 EUR(plaćaju se u agenciji i podložne su promeni sve do polaska na put)\n" +
            "međunarodno zdravstveno osiguranje\n" +
            "obrok i piće na letu, moguće uz doplatu tokom leta\n" +
            "individualne troškove u hotelima i za vreme putovanja\n" +
            "obilasci, izleti i razgledanja\n" +
            "DOPLATE:\n" +
            "za 1/1 sobu iznosi 79 EUR u hotelu 3* ili 89 EUR u hotelu 4*\n" +
            "umanjenje za individualni transfer na relaciji aerodrom-hotel-aerodrom iznosi 40 eur\n" +
            "NAČINI PLAĆANJA:\n" +
            "plaćanje se vrši u dinarskoj protivvrednosti po prodajnom kursu UniCredit Banke za efektivu na dan uplate.\n" +
            "uplata akontacije 30% prilikom rezervacije, ostatak 70 % najkasnije 15 dana pre polaska gotovinom, karticama, uplatom na račun ili čekovima na 6 mesečnih rata.\n" +
            "uplatom celokupnog iznosa karticama banke Intesa na 12 jednakih mesečnih rata.";

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
            "** Rok za izdavanje karte je 01h od trenutka pravljenja rezervacije! Kako su u pitanju promotivne karte avio kompanije, kupljena karta ne može se zameniti niti refundirati, kao ni iznos aerodromskih taksi."+
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
            "Putnici koji poseduju inostrani pasoš dužni su sami da se informišu kod nadležnog konzulata o uslovima koji važe za odredišnu ili tranzitnu zemlju (vizni, carinski, zdravstveni i dr.) i da sami blagovremeno i "+
            "uredno obezbede potrebne uslove i isprave.\n" +
            "U slučaju nedovoljnog broja putnika za relizaciju aranžmana, krajnji rok za obaveštenje o otkazu aranžmana je 5 dana pre datuma polaska.\n" +
            "Organizator putovanja zadržava pravo korekcije ugovorene cene pre početka putovanja usled promene u kursu razmene valute ili promene u tarifama prevoznika i u zakonom predviđenim slučajevima.\n" +
            "Uz ovaj program važe Opšti uslovi putovanja organizatora putovanja.\n" +
            "Aranžman je rađen na bazi od minimum 2 putnika.";

            private string smestaj = "Putnici će biti smešteni u navedenim ili sličnim hotelima na osnovu raspoloživosti. Neki od hotela sa kojima sarađujemo:\n" +

            "Barin\n" +
            "ADDRESS:"+
            "SEHZADEBASI FEVZIYE CD.NO:7, FATIH\n"+
            "Smešten u starom jezgru Istanbula, hotel Barin predstavlja odlično polazište za istraživanje brojnih gradskih spomenika i znamenitosti.Ovaj prijatni hotel nudi 65 udobnih soba.\n"+

            "Grand ANT\n" +
            "ADDRESS:" +
            "KUCUKLANGA CAD. NO:9 AKSARAY FATIH, FATIH\n" +
            "Grand Ant Hotel se nalazi 200 metara od železničke stanice Yenikapi i 20 minuta hoda od Kapali čaršije.Sobe u hotelu Grand Ant imaju besplatan bežični internet, opremljene su kablovskom televizijom, " +
            "sefom i sopstvenim kupatilom sa fenom.\n" +

            "Black Bird Hotel\n" +
            "ADDRESS:"+
            "GENÇTÜRK ST.NO.51/53 SEHZADEBASI, FATIH\n" +
            "Smešten u istanbulskoj četvrti Laleli, ovaj hotel sa 4 zvezdice udaljen je manje od 2 km od Plave džamije. Sobe u hotelu Black Bird imaju moderan nameštaj i prozore od poda do plafona sa pogledom na grad.\n" +

            "Antik Hotel\n" +
            "ADDRESS:"+
            "ORDU CAD, DARPHANE(SEKBANBASI) SOK. 10 BEYAZIT SULTANAHMET, FATIH\n" +
            "Hotel Antik se nalazi u centru Istanbula, na 500 metara od Kapali čaršije i na samo 3 minuta hoda od tramvajske stanice Bejazit. Gosti se mogu opustiti uz piće na krovnoj terasi.";

            public string Info { get => info; set => info = value; }
            public string Cena { get => cena; set => cena = value; }
            public string Napomena { get => napomena; set => napomena = value; }
            public string Smestaj { get => smestaj; set => smestaj = value; }
    }
    }



