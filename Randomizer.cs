//Nume: Rosca Stefan
//Grupa: 3131a
//Tema laborator 3

using OpenTK;
using System;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Management.Instrumentation;

namespace ConsoleApp4
{
    class Randomizer
    {
        private Random r;
        private const int MIN_VAL = -25;
        private const int MAX_VAL = 25;
        string NumeFisier { get; set; }
        public Randomizer()
        {
            r = new Random();
        }

        public Color GenerateColor()
        {
            int genR = r.Next(0, 256);
            int genG = r.Next(0, 256);
            int genB = r.Next(0, 256);

            Color col = Color.FromArgb(genR, genG, genB);

            return col;
        }

        public Vector3 Generate3DPoint()
        {
            int a = r.Next(MIN_VAL, MAX_VAL);
            int b = r.Next(MIN_VAL, MAX_VAL);
            int c = r.Next(MIN_VAL, MAX_VAL);

            Vector3 vec = new Vector3(a, b, c);

            return vec;
        }

        public Vector3 Generate3DPoint(int spec)
        {
            int a = r.Next(-1 * spec, spec);
            int b = r.Next(-1 * spec, spec);
            int c = r.Next(-1 * spec, spec);

            Vector3 vec = new Vector3(a, b, c);

            return vec;
        }

        public int GeneratePositiveInt(int limit)
        {
            int a = r.Next(0, limit);

            return a;
        }

        /// Laborator 03

        public Vector3 citestefisier()
        {
            int i = 0;
            int []v= new int[6];
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Stefan/Desktop/ConsoleApp4/Date_triunghi.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {    
                        var split = line.Split(',');
                        v[i]= Convert.ToInt32(split[0]);
                        v[++i]= Convert.ToInt32(split[1]);  
                       
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            int x = r.Next(v[0], v[1]);
            int y = r.Next(v[2], v[3]);
            int z = r.Next(v[4], v[5]);

            Console.WriteLine("x y z {0} {1} {2}", x, y, z);
            Vector3 vec = new Vector3(x, y, z);

            return vec;
        }

    }
}
