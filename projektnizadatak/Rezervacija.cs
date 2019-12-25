using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektnizadatak
{
    class Rezervacija
    {

        private int maxMesta = 9;
        private int trenutanBrojMesta = GetLastChar();

        public int MaxMesta { get => maxMesta; set => maxMesta = value; }
        public int TrenutanBrojMesta { get => trenutanBrojMesta; set => trenutanBrojMesta = value; }

        static private int GetLastChar()
        {
            string lokacija = @"C:\rezervacije\" + Destinacija.ImeDestinacije + ".txt";
            string putanjaDirektorijuma = @"c:\rezervacije";
            string imeFajla = Destinacija.ImeDestinacije;
            string putanjaFajla = putanjaDirektorijuma + "\\" + imeFajla + ".txt";
            Char lastChar;

            if (File.Exists(lokacija))
            {
                string s = File.ReadAllText(@"C:\rezervacije\" + Destinacija.ImeDestinacije + ".txt");
                string[] split = s.Split(s[s.Length - 1]);

                string lastLine = File.ReadLines(@"C:\rezervacije\" + Destinacija.ImeDestinacije + ".txt").Last();
                lastChar = '\0';
                if (lastLine != null) lastChar = lastLine.LastOrDefault();

                return int.Parse(lastChar.ToString());
            }
            else
            {
                var privremeni = Directory.CreateDirectory(putanjaDirektorijuma);
                var fajlRezer = File.Create(putanjaFajla);
                fajlRezer.Close();
                File.AppendAllText(putanjaFajla, "0" + Environment.NewLine);
                fajlRezer.Close();

                string s = File.ReadAllText(@"C:\rezervacije\" + Destinacija.ImeDestinacije + ".txt");
                string[] split = s.Split(s[s.Length - 1]);

                string lastLine = File.ReadLines(@"C:\rezervacije\" + Destinacija.ImeDestinacije + ".txt").Last();
                lastChar = '\0';
                if (lastLine != null) lastChar = lastLine.LastOrDefault();

                return int.Parse(lastChar.ToString());
            }
        }
    }
}
    


