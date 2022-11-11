using System.IO;

int choose;

Console.WriteLine("Welcome");
Console.WriteLine("Please Choose The Operation");
Console.WriteLine("1-Load File **** 2-Enter Dna String **** 3-Create Random Dna");
choose = Convert.ToInt32(Console.ReadLine());
string dna = "ATGACTGATGAGAGATATTGA";
string dnalngth = " ";

Console.WriteLine(dna.Length);



switch (choose)
{
    case 1: 
        string filename;
        Console.WriteLine("Please enter the name of text file:");
        filename = (Console.ReadLine());     
        dna = File.ReadAllText("/Users/hasanfurkanguney/Desktop/"+ filename);
        Console.WriteLine(dna.Length);


        dnalngth = dna;
        break;

    case 2:
        Console.WriteLine("Please Enter the Dna String");
        string inputdna = Console.ReadLine();
        Console.WriteLine(inputdna);
        dna = inputdna;
        dnalngth = dna;
        break;

    case 3:

        Random rndmdna = new Random();
        string[] words = { "A", "T", "G", "C" };
        
        List<string> randomdna = new List<string>();


        for (int i = 0; i <= 21; i++)
        {
            int rndm = rndmdna.Next(0, 4);
            randomdna.Add(words[rndm]);
        } ;

        foreach(string randomdnaprint in randomdna)
        {
            dna = randomdnaprint;
            Console.Write(randomdnaprint);
        }

        

        break;

}

double dnalenght = dnalngth.Length ;
for(int i=1; i <= 2 * dnalenght;)
{
    dna = dna.Insert(i, " ");
    i = i + 2;
}

Console.WriteLine(dna);

Console.WriteLine("");
Console.WriteLine("Please Choose a operation");
Console.WriteLine("1 **** 2 **** 16");
int choose1 = Convert.ToInt32(Console.ReadLine());


switch (choose1)
{
    case 16:
        char harfa = 'A';
        int countA = 0;

        for (int i=0; i<dna.Length; i++)
        {
            if (dna[i] == harfa)
            {
                countA++;

            }
        }

        //

        char harft = 'T';
        int countT = 0;

        for (int i = 0; i <= dnalngth.Length; i++)
        {
            if (dna[i] == harft)
            {
                countT++;

            }
        }

        //

        char harfg = 'G';
        int countG = 0;

        for (int i = 0; i <= dnalngth.Length; i++)
        {
            if (dna[i] == harfg)
            {
                countG++;

            }
        }

        //

        char harfc = 'C';
        int countC = 0;

        for (int i = 0; i <= dnalngth.Length; i++)
        {
            if (dna[i] == harfc)
            {
                countC++;

            }
        }


        int hydrogena = 2 * countA;
        int hydrogent = 2 * countT;
        int hydrogeng = 3 * countG;
        int hydrogenc = 3 * countC;

        Console.WriteLine("Number of pairing with 2-hydrogen bonds:" + (countA + countT));
        Console.WriteLine("Number of pairing with 3-hydrogen bonds:" + (countG + countC));
        Console.WriteLine("Number of hydrogen bonds:" + (hydrogena + hydrogent + hydrogenc + hydrogeng));




        break;

        Console.ReadKey();
}
    


