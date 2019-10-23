using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Functions
    {
        static List<String[]> listoftransactions = new List<String[]>();
        static Dictionary<String, int> dicofproducts = new Dictionary<String, int>();
        static int prag;

        static void ReadFile(string filename)
        {
            string line;
            StreamReader reader = new StreamReader(filename);
            line = reader.ReadLine();
            PopulateDict(line.Split(','));
            while ((line = reader.ReadLine()) != null)
            {
                PopulateList(line.Split(','));
            }
        }

        static void PopulateList(String[] line)
        {
            String[] finaltransaction = line.Skip(1).ToArray();
            listoftransactions.Add(finaltransaction);
        }

        static void ParseList()
        {
            listoftransactions.RemoveAll(x => (GetNumberOfErrors(x) / GetNumberOfProducts(x)) * 100 > 30);
            var lista = new List<string[]>();
            listoftransactions.ForEach(x => lista.Add(x.ToList().Where(y => y != "?" && y != "-").ToArray()));
            listoftransactions = lista;
        }
        static int GetNumberOfProducts(String[] transaction)
        {
            return transaction.Count(x => x != "?" && x != "-");
        }

        static void PopulateDict(String[] line)
        {
            String[] finaltransaction = line.Skip(1).ToArray();
            foreach (var product in finaltransaction)
            {
                dicofproducts.Add(product, 0);
            }
        }

        static void ParseDict()
        {
            listoftransactions.ForEach(x => DictAddValues(x));
            String a = "";
        }
        static void DictAddValues(String[] transaction)
        {
            foreach (var product in transaction)
            {
                dicofproducts[product] += 1;
            }
        }
        static int GetNumberOfErrors(String[] transaction)
        {
            int eroros = transaction.Count(x => x == "?");
            if (eroros == 0)
            {
                return 1;
            }
            return eroros;
        }
        static void FirstIteration()
        {
            dicofproducts.Where(x => x > prag);
            
        }
        public void Start(string filename,string prag) 
        {
            try
            {
                prag = Int32.Parse(prag);
                ReadFile(filename);
                ParseList();
                ParseDict();

            }
            catch (FormatException)
            {
                Console.WriteLine("Esti un bou");
            }
        }
    }
}
