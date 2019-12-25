using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektnizadatak
{
    class Put_Oko_Sveta
    {

        private string info = "1. dan (10.04.2018.) BEOGRAD – DOHA - SINGAPUR\n"+
             "Sastanak putnika na aerodromu Nikola Tesla sa vodičem Ponte Travel-a ispred šaltera agencije u10:25h. Poletanje za Dohu u 12:25h (let QR 232). Let traje 5 sati. Obrok i pića u avionu. " +
            "Sletanje u 18:25h. Poletanje za Singapur u 20:35 (let QR 942). Obroci i pića u toku leta. Let traje 7 sati i 40 minuta.\n"+

             "2. dan(11.04.2018.) SINGAPUR\n"+
             "Sletanje u Singapur u 09:15h.Transfer do hotela.Smeštaj.Slobodno vreme za odmor.Orijentaciona šetnja Singapurom sa vodičem. Noćenje.\n"+

            "3. dan (12.04.2018.) SINGAPUR\n"+
            "Doručak(švedski sto). Transfer na poludnevno razgledanje grada.Panoramsko poludnevno razgledanje grada obuhvata zgrade Vrhovnog suda, Parlamenta i gradske Skupštine.Odlazak do gradske luke " +
            "gde se može videti čuvena skulptura mitološkog bića, polu riba - polu lav Merlion, koja na neki način simbolizuje grad.Poseta tajlandskom Hok Keng hramu, jednom od najstarijih budističkih hramova " +
            "u Singapuru, zatim kineskoj i indijskoj četvrti, gde se mogu kupiti mirisni začini. Obilazak bašte orhideja koja je u sklopu singapurske botaničke bašte ... Povratak u hotel.Uveče odlazak na obližnje " +
            "tropsko ostrvo Sentosa.Vožnja žičarom na ostrvo uz predivan pogled na grad.Ovo ostrvo je nekada bila engleska vojna baza, a sada odlična atrakcija koju posećuju milioni turista godišnje.Sentosa ima " +
            "predivno prirodno okruženje i obilje zabavno-rekreativnih sadržaja (podvodni svet, laguna delfina, park leptira i insekata, vrtovi, plaže, večernje laserske predstave…). Sa ostrva se može uživati i u " +
            "magičnom prizoru zalaska sunca.Povratak u hotel.Noćenje.\n"+

            "4. dan(13.04.2018.) SINGAPUR - SIDNEJ\n"+
            "Doručak(švedski sto). Slobodno vreme za individualna razgledanja i kupovinu suvenira.Popodnevni transfer na aerodrom.Poletanje za Sidnej\n"+
            "u 19:25h (let BA 015). Let traje 7 sati i 45 minuta.Obroci tokom leta.\n"+

            "5. dan(14.04.2018.) SIDNEJ\n"+
            "Sletanje u Sidnej u 05:10. Transfer do hotela.Doručak.\n"+
            "Slobodno vreme za odmor.\n"+
            "Polazak u poludnevno razgledanje grada. Sidnej je najstariji, najveći i najlepši od svih australijskih gradova, koji leži usred prelepog preplitanja kopna i mora. Duž najlepše prirodne svetlucave luke " +
                "vide se bela jedra Opere kao i elegantan Sidnejski lučki most... Poznate atrakcije grada su i luka Darling, trg Roks, kula, zgrada britanske kraljice Viktorije, Kings Kros distrikt i još mnogo toga." +
                "Povratak u hotel.Noćenje.\n"+

            "6. - 7. dan (15.-16.04.2018.) SIDNEJ\n"+
            "Doručak.Slobodni dani za individualna razgledanja. Mogućnost organizovanja nekih od fakultativnih izleta u organizaciji našeg vodiča na licu mesta.Noćenja.\n"+

            "8. dan (17.04.2018.) SIDNEJ(KRSTARENJE)\n"+
            "Plovidba i uživanje u raznovrsnim sadržajima broda.Brod poseduje 3 bazena, 3 đakuzija, fitnes centar, restorane, barove, kazino, pozorište sa predstavama poput onih na Brodveju, sportske sadržaje(zid za planinarenje," +
                " teren za košarku, mini-golf...), deo sa video igricama, barove sa živom muzikom i još mnogo toga za zabavu i uživanje..Noćenja.\n"+

            "9. - 10. dan(18.-19.04.2018.) KRSTARENJE\n"+
            "Plovidba i uživanje u raznovrsnim sadržajima broda.Brod poseduje 3 bazena, 3 đakuzija, fitnes centar, restorane, barove, kazino, pozorište sa predstavama poput onih na Brodveju, sportske sadržaje (zid za planinarenje," +
            " teren za košarku, mini-golf...), deo sa video igricama, barove sa živom muzikom i još mnogo toga za zabavu i uživanje..Noćenja.\n"+

            "11. dan(20.04.2018.) PIKTON(NOVI ZELAND)\n"+
            "Uplovljavanje u luku gradića Pikton u 12:00h.To je za mnoge i najlepše mesto na obali Južnog ostrva koji povezuje dva glavna novozelandska ostrva(južni i severni). Deo je najpoznatije vinarske regije Malboro(Malborough) " +
            "koja je čuvena i po svojim prirodnim lepotama.U samom mestu nalazi se akvarijum, plutajući pomorski muzej kao i dosta restorana, barova i raznovrsnih galerija. Ipak, najpoznatija lokalna atrakcija je 70 km duga " +
            "staza ``Kraljica Šarlota`` koja vodi kroz prelepe kontraste pejzaža, istorijskih znamenitosti i bajkovitih predela.Može se delom proći peške ili iznajmiti bicikl.. U blizini se nalazi najpoznatiji vinarski grad u " +
            "zemlji Blenhajm (kratka vožnja). Povratak na brod.Isplovljavanje u 21:00h.Noćenje na brodu.\n"+

            "12. dan (21.04.2018.) ELINGTON(NOVI ZELAND)\n"+
            "Uplovljavanje u luku Velington u 08:00h.Velington je glavni grad Novog Zelanda.Nalazi se na krajnjem jugu Severnog ostrva. Proglašen je od strane Lonely Planeta kao „najopuštenija mala prestonica na svetu”. Planina " +
            "Victoria je najpopularnija planina u blizini Velingtona jer pruža jedan od najneverovatnijih panoramskih pogleda na grad.Victoria se tako i našla u čuvenom filmu Pitera Džeksona, Gospodar prstenova. Uspinjača je " +
            "takođe jedan od simbola grada i prevozi putnike od centra, Lambton Quaya, sve do živopisnog predgrađa Kelburna.Posetiocima se nudi mogućnost da posete i Cable Car muzej, kao i da se odvezu do botaničke bašte Velingtona." +
            "Svakako za turiste su interesantni i tvrđava Wrights Hill, dolina Hutt, rezervat karori i još mnogo toga. Posebnu pažnju turisti posvećuju šopingu jer se Velington smatra i jednim od najjeftinijih gradova na svetu ! " +
            "Povratak na brod.Isplovljavanje u 17:00h.Noćenje na brodu.\n"+

            "13. dan (22.04.2018.) KRSTARENJE PACIFIKOM\n"+
            "Krstarenje Pacifikom i prelaženje međunarodne datumske linije na samom središtu okeana gde se mogu videti i neke teritorije kao i grupacije ostrva.Meridijan koji se nalazi nasuprot Griničkom na 180° je upotrebljen za " +
            "datumskugranicu, jer najvećim delom prolazi preko okeana. Datumska granica većim delom prati ovaj meridijan osim u naseljenim područjima, gde je ona pomerena iz praktičnih razloga.Prilikom prelaska preko datumske " +
            "granice datum se pomera, pa tako ko pređe sa istoka na zapad pomera kalendar za jedan dan unazad što je slučaj i sa ovim prelaskom.\n"+

            "14 - 16. dan (23. - 25. 04.2018.) KRSTARENJE\n"+
            "Plovidba i uživanje u raznovrsnim sadržajima broda.\n"+
            "Uplovljavanje u luku Papete na Tahitiju u 08:00 sati ujutro. Francuska Polinezija, arhipelag nestvarne lepote u čijem sastavu su najglamuroznija ostrva na svetu, omiljena su destinacija bogatih i slavnih, naravno sa " +
            "pravim razlogom…. Ovde se nalazi pravi raj koji se ne zaboravlja.Tahiti je poznat po svojim prelepim plažama, ali ostrvo je i dom velikom broju muzeja, koji imaju slobodan ulaz. Muzej bisera je jedino mesto na svetu " +
            "gde kroz različite aspekte, možete naučiti sve o ovom predivnom dragulju.Čuveni francuski slikar, Pol Gogen, proveo je poslednjih 12 godina svog života na Tahitiju.Ostrvo poseduje muzej posvećen njegovom životu i radu…. " +
            "Povratak na brod.Isplovljavanje iz luke Papete u 23:00 sata.\n"+

            "17. dan (26.04.2018.) PAPETE, TAHITI(FRANCUSKA POLINEZIJA)\n"+
            "Uplovljavanje u luku Papete na Tahitiju u 08:00 sati ujutro.Francuska Polinezija, arhipelag nestvarne lepote u čijem sastavu su najglamuroznija ostrva na svetu, omiljena su destinacija bogatih i slavnih, naravno sa " +
            "pravim razlogom…. Ovde se nalazi pravi raj koji se ne zaboravlja.Tahiti je poznat po svojim prelepim plažama, ali ostrvo je i dom velikom broju muzeja, koji imaju slobodan ulaz. Muzej bisera je jedino mesto na svetu " +
            "gde kroz različite aspekte, možete naučiti sve o ovom predivnom dragulju.Čuveni francuski slikar, Pol Gogen, proveo je poslednjih 12 godina svog života na Tahitiju.Ostrvo poseduje muzej posvećen njegovom životu i radu…. " +
            "Povratak na brod.Isplovljavanje iz luke Papete u 23:00 sata.\n"+

            "18. dan (27.04.2018.) BORA BORA(FRANCUSKA POLINEZIJA)\n"+
            "Uplovljavanje u luku Bora Bora u 08:00 sati ujutro.\n"+
            "Bora Bora je najromantičnije i najekskluzivnije ostrvo na planeti. Bora Bora u prevodu znači “prvorođenje”. Plaže od puderasto belog peska, tirkizno plave lagune, nestvarno lepe boje prirode pružaju posetiocima osećaj " +
            "da se nalaze u ovozemaljskom raju...Posle uživanja na ovom divnom ostrvu povratak na brod.Isplovljavanje u 18:00h.\n"+

            "19.- 23. dan (28.04.- 02.05.2018.) KRSTARENJE\n"+
            "Plovidba i uživanje u raznovrsnim sadržajima broda.\n"+

            "24. dan (03.05.2018.) HONOLULU(HAVAJI)\n"+
            "Uplovljavanje u luku u 06:00 sati ujutro.Popodnevni transfer u hotel na čuvenoj plaži Vaikiki.Smeštaj.Havaji su destinacija iz snova, ostrva rajske prirode, lepih ljudi i strastvenog ritma.Nalaze se u Tihom okeanu i " +
            "pripadaju grupi Polinežanskih ostrva, teritorijalno pripadaju SAD.Dom su nekim od najaktivnijih vulkana na svetu (Mauna Loa, Mauna Kea). U celom arhipelagu postoji osam najvećih ostrva: Havaji ostrvo, Maui, Oahu, " +
            "Niihau, Kauai, Molokai, Lana‘i, Kaholave.Havaji su najsrećnija zemlja za život, otkriva studija američkog istraživačkog centra Gallup.Povoljna klima, kilometarske plaže, surfovanje, ekološka hrana, vulkanska ostrva " +
            "i prirodne lepote...Noćenje.\n"+

            "25. dan (04.05.2018.) HONOLULU(HAVAJI)\n"+
            "Doručak.Polazak u razgledanje grada.\n"+
            "Razgledanje glavnog grada Honolulua, Dijamantske glave, vulkanske kupe, Hanauma zaliva, prirodnog rezervata, i uvale Halona...Povratak u hotel.Slobodno vreme. Noćenje.\n"+

            "26. dan (05.05.2018.) HONOLULU(HAVAJI)\n"+
            "Doručak.Slobodno vreme za sunčanje i kupanje.Mogućnost organizovanja fakultativnih izleta sa vodičem na licu mesta. Noćenje.\n"+

            "27. dan (06.05.2018.) HONOLULU - LOS ANĐELES\n"+
            "Rani jutarnji transfer na aerodrom.Poletanje za Los Anđeles u 07:10h(let AA 108). Let traje 5 i po sati.Hrana i piće na letu American Airlines-a se naplaćuju u avionu.Sletanje u 15:41h.Transfer do hotela.Slobodno vreme." +
            "Noćenje.\n"+

            "28. dan (07.05.2018.) LOS ANĐELES\n"+
            "Polazak u panoramsko razgledanje grada u pratnji vodiča.Los Anđeles je grad koji je sinonim za ostvarenje ’’Američkog sna’’ ponajviše zbog čuvenog Holivuda koji je stecište studija filmske industrije, mesto gde se odvija " +
            "najveća filmska manifestacija na svetu, dodela Oskara i gde se takođe, nalaze i kuće poznatih glumačkih zvezda. Osnovali su ga Meksikanci davne 1781. godine i sve do 1846. godine je bio u sastavu Meksika. " +
            "Tako je i dobio naziv koji u prevodu znači Grad anđela.Razgledanje obuhvata čuvene delove grada kao što su Beverli Hils, Bel Er, Rodeo Drajv, Bulevar sumraka, Holivud sa čuvenim Kineskim pozorištem na kome su otisci " +
            "stopala i dlanova poznatih glumaca... Po završetku razgledanja transfer do hotela.Smeštaj.Slobodno posle podne.Noćenje.\n"+

            "29. dan (08.05.2018.) LOS ANĐELES - LIMA\n"+
            "Slobodno vreme.Transfer do aerodroma.Poletanje za Limu u 14:00h(let LA 2477). Let traje 8 sati i 45 minuta.Ručak u avionu.\n"+

            "30. dan(09.05.2018.) LIMA\n"+
            "Sletanje u 00:45. Transfer do hotela.Noćenje.Doručak.Obilazak kolonijalnog i modernog dela grada.Razgledanje započinje posetom Trga oružja sa kolonijalnim zgradama kao što su palata Vlade, opština, Katedrala…." +
            "Poseta manastiru San Francisko sa lavirint tunelima i katakombama koje su služile kao masovna grobnica.Posle posete istorijskom centrom grada, obilazak modernih četvrti San Isidro i Miraflores.U San Isidru se nalazi " +
            "Park maslina, gde se stara stabla maslina nalaze pored modernog tržnog centra. U Mirafloresu je Park ljubavi gde se pruža pogled na litice i Tihi okean. Obilazak završava posetom fascinantnom muzeju Larko Herera." +
            "Sa više od 45,000 objekata pre Kolumbovske keramike, tekstila, zlatnih i srebrnih komada, čini jednu od najimpresivnijih kolekcija.Takođe je poznat i po izložbi erotske keramike Močika kulture. Povratak u hotel." +
            "Slobodno vreme. Noćenje.\n"+
            "Lima: Peruanska prestonica je osnovana 1535.godine od strane španskog konkvistadora Franciska Pizara.Ovde ćete videti bogatstvo kolonijalnog perioda i orijentalni bazar.Grad ima melanholične zime kada dominira magla „garua“  " +
            "i topla i vlažna leta.Ima velikih kvartova gde živi siromašno stanovništvo, ali i bogatih četvrti sa starim kućama i mirisom jasmina.\n"+

            "31. dan (10.05.2018.) LIMA - KUSKO\n"+
            "Rani jutarnji transfer do aerodroma.Poletanje za Kusko u 09:00h(LA 2123). Let traje sat i po.Užina i piće u avionu.Sletanje u 10:35h.Transfer do hotela.Smeštaj.Odmor.Obilazak grada, koji se sastoji od posete njegovim " +
            "najznačajnijim znamenitostima iz doba Inka i kolonijalnog vremena.Poseta Korikanči, hramu Sunca koji je bio najvažnije svetilište Inka.Katolički manastir Santo Domingo je sagrađen na mestu hrama.Odlazak do katedrale, " +
            "koja se smatra najboljim primerom kolonijalne umetnosti Kusko škole.Sagrađena je nad palatom Inka Virakoča, koja je bila verski i politički centar Kuska tokom vladavine Inka.Nakon toga obilazak spoljašnjih delova grada " +
            "gde se nalaze ruševine Inka carstva.Između njih je najvažniji arheološki park Saksajaman, gde je masovno kamenje složeno u cik-cak obliku. Kusko: „Pupak zemlje“ je drugi naziv za Kusko, jer tokom uspona Inka svaki put " +
            "je vodio u prestonicu carstva.Ovde ne samo da ćete videti Inka zidove i hramove, već i kolonijalne palate i katoličke crkve.\n"+

            "32. dan (11.05.2018.) KUSKO\n"+
            "Doručak(švedski sto) u hotelu.Vožnja do pijace Pisak. Ovo je dobro poznata pijaca među stanovništvom i turistima.Nije izgubila svoj prvobitni šarm uprkos velikom broju posetilaca.Postoje dva dela: lokalni deo, gde " +
            "stanovništvo prodaje i kupuje voće i povrće dok je drugi deo mesto gde se nalaze mnoge zanatske tezge sa keramikom, alpaka odećom i nakitom. Cenkanje je dobrodošlo! Ručak u lokalnom restoranu.U popodnevnim satima, " +
            "odlazak do Oljantajtamba, mesta koje je bilo glavno uporište Inka.Ovo je jedno od mesta gde su Španci izgubili bitku protiv Inka. Povratak u hotel.Noćenje.\n"+

            "33. dan (12.05.2018.) KUSKO – MAČU PIKČU - KUSKO\n"+
            "Doručak(švedski sto). Prema voznom redu vožnje, transfer od hotela do železničke stanice u Oljantajtambu.Polazak vozom do gradića Akva Kalijentes (oko 3,5 sati vožnje) duž reke Urubamba.Po dolasku, vožnja šatl busom do" +
            " više nego impresivnog Maču Pikčua(30 min). Izgubljeni grad Inka nije samo jedno od sedam novih svetskih čuda, nego i najveće blago Peruanske prošlosti i carstva Inka. Neotkriven od strane Španaca i zaboravljen tokom " +
            "vekova bio je do 1911. godine, kada ga je američki naučnik Hajram Bingam slučajno pronašao. Grad je podeljen na gornji i donji deo koje razdvajaju otvoreni prostori ili trgovi. Gornji deo su činili hramovi, fontane, " +
            "trgovi… U donjem delu grada su bile skromne kuće. \n"+
            "“Hram sunca”, “Hram sa tri prozora” i “Glavni hram”, smešteni su u gornjem delu grada.Grad je imao kompleksan sistem vodovoda koji se snabdevao iz prirodnih izvora, trgove, ulice i građevine različitog kvaliteta gradnje." +
            "Smatra se da je Maču Pikču imao oko 1000 stanovnika.\n"+
            "Pored 200 stambenih kuća, lokalitet ima i priličan broj jedinstvenih građevina za koje se smatra da su imale ritualnu funkciju....Ručak u lokalnom restoranu.U popodnevnim satima povratak mini busom i vozom do Kuska i hotela." +
            ".oćenje.\n"+

            "34. dan (13.05.2018.) KUSKO – LIMA - SAO PAULO\n"+
            "Rani jutarnji transfer na aerodrom.Poletanje za Limu u 05:35h(let LA 2002). Let traje 1 sat i 23 minuta.Sletanje u 06:58h.Poletanje za Sao Paulo u 09:05h(let LA 2377). Let traje 5 sati.Doručak u avionu.Sletanje u 16:05h." +
            "Polazak u panoramsko razgledanje Sao Paula.To je najvažniji finansijski, kulturni, sportski centar Brazila kao i kosmopolitski centar Južne Amerike ali i najveći grad na južnoj hemisferi. Razgledanje uključuje obilazak " +
            "rezidencionalnog i univerzitetskog dela grada, Iberapuera parka, trgova ’’Republika’’ i ’’Ruzvelt’’, avenije Paulista.... Povratak na aerodrom u kasnim večernjim satima.\n"+

            "35. dan (14.05.2018.) SAO PAULO - DOHA\n"+
            "Poletanje za Dohu u 03:15h(let QR 774). Let traje 13 sati i 25 minuta.Obroci i pića tokom leta.Sletanje u Dohu u 22:40. Transfer do hotela(Smeštaj i transferi u organizaciji Qatar Airways-a). Noćenje.\n"+

            "36. dan(15.05.2018.) DOHA - BEOGRAD\n"+
            "Rani jutarnji transfer na aerodrom.Poletanje za Beograd u 07:00h (let QR 231). Let traje 5 sati i 25 minuta.Obrok i pića tokom leta.Sletanje u 11:25h.";

        private string cena = " DATUM POLASKA	 USLUGA	 CENA\n"+
        "10. APRIL 2018.	 PREMA PROGRAMU	 6.780 €\n" +
        "Za prvih 10 prijavljenih putnika dobija se vaučer na 100 USD za upotrebu tokom krstarenja\n" +


        "U cenu putovanja je uračunato:\n" +
        "prevoz avionom na navedenim relacijama,\n"+
        "smeštaj u dvokrevetnim standard sobama u hotelima 4* (lokalna kategorija) osim u Sidneju 3* superior,\n"+
        "usluga ishrane prema programu putovanja,\n"+
        "sva razgledanja itransferi prema programu visokokvalitetnim klimatizovanim vozilima turističke kategorije,\n"+
        "krstarenje po programu,\n"+
        "smeštaj u unutrašnjim kabinama,\n"+
        "proširen puni pansion tokom krstarenja(doručak, ručak, večera, ponoćna užina i kapetanova gala večera), odabrana bezalkoholna pića za doručak i ručak, večernji zabavni program u salama i barovima uz živu muziku, predstave, animacije, ulaz u kazino i diskoteku, sportske aktivnosti,\n"+
        "besplatna upotreba fitnesa, saune, bazena i peškira(na brodu),\n"+
        "lokalni vodiči tokom ture,\n"+
        "troškovi organizovanja putovanja,\n"+
        "boravišne takse i sve druge takse vezane za smeštaj,\n"+
        "kao i profesionalni licencirani turistički vodič na srpskom jeziku koji sa grupom polazi iz Beograda.\n"+

        "U cenu putovanja nije uračunato:\n"+
        "avio-takse 457 Eur po osobi (cena avio taksi je u trenutku pravljenja ponude i podložna je promeni jer zavisi isključivo od avio kompanije, konačna cena se obračunava i naplaćuje u trenutku štampanja karata što je oko 30 dana pre početka putovanja – u slučaju ranijeg popunjavanja grupe karte će se štampati dosta ranije),\n"+
        "sve lučke i brodske takse koje iznose 186 Eur,\n"+
        "napojnice na brodu koje iznose 200 Eur(napojnice i takse se plaćaju u agenciji),\n"+
        "međunarodno zdravstveno osiguranje i osiguranje od otkaza putovanja(osiguranje od otkaza putovanja se preporučuje i agencija posreduje u svim neophodnim informacijama i kontaktima za ovaj tip osiguranja),\n"+
        "troškovi viziranja pasoša,\n"+
        "bakšiš za lokalne vodiče i vozače koji je uvom delu sveta obavezan, svi izleti u programu putovanja označeni kao fakultativni.\n"+
        "Na brodu alkoholna i sva druga pića koja naručite u kafiću ili restoranu,\n"+
        "minibar u sobi,\n"+
        "pranje odeće,\n"+
        "zdravstvene tretmane i tretmane ulepšavanja,\n"+
        "usluge frizerskog salona,\n"+
        "telefonski pozivi,\n"+
        "Wi-Fi,\n"+
        "fakultativni izleti, koje nudi brodar biće vođeni na jednom od svetskih jezika(engleski, nemački, italijanski,…).\n"+
        "Dok se brod nalazi u luci po Vašoj želji možete da uđete ili izađete iz njega i da iskoristite svu brodsku ponudu koja Vam stoji na raspolaganju u tom vremenskom periodu(restorani, barovi, animacije, ulepšavanje i usluge masaže, bazeni…).";

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

        private string smestaj = "Putnici će biti smešteni u navedenim ili sličnim hotelima na osnovu raspoloživosti. ";
            
        public string Info { get => info; set => info = value; }
        public string Cena { get => cena; set => cena = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public string Smestaj { get => smestaj; set => smestaj = value; }


    }
}
