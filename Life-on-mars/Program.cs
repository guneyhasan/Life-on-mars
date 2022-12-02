using System.IO;
//LIFE ON MARS
class Program
{
    public static void Main(string[] args)
    {
        bool tester3 = true, tester4 = true, tester5 = true, tester2 = true, tester1 = true, tester = true,test = false;
        double choose;
        Console.WriteLine("0. Exit The Program");
        Console.WriteLine("1. Load a DNA sequence from a file");
        Console.WriteLine("2. Load a DNA sequence from a string");
        Console.WriteLine("3. Generate random DNA sequence of a BLOB");
        Console.WriteLine("4. Check DNA gene structure");
        Console.WriteLine("5. Check DNA of BLOB organism");
        Console.WriteLine("6. Produce complement of a DNA sequence");
        Console.WriteLine("7. Determine amino acids");
        Console.WriteLine("8. Delete codons (delete n codons, starting from mth codon) ");
        Console.WriteLine("9. Insert codons (insert a codon sequence, starting from mth codon)");
        Console.WriteLine("10. Find codons (find a codon sequence, starting from mth codon)");
        Console.WriteLine("11. Reverse codons (reverse n codons, starting from mth codon) ");
        Console.WriteLine("12. Find the number of genes in a DNA strand (BLOB or not)");
        Console.WriteLine("13. Find the shortest gene in a DNA strand");
        Console.WriteLine("14. Find the longest gene in a DNA strand");
        Console.WriteLine("15. Find the most repeated n-nucleotide sequence in a DNA strand (STR - Short Tandem Repeat)");
        Console.WriteLine("16. Hydrogen bond statistics for a DNA strand");
        Console.WriteLine("17. Simulate BLOB generations using DNA strand 1 and 2 (DNA strand 3 is for the newborn)");
        Console.WriteLine("Press any key to start program...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Welcome");
        Console.WriteLine("Please Choose The Operation");
        Console.WriteLine(" 1- Load File |---| 2- Enter Dna String |---| 3- Create a Random DNA ");
        choose = Convert.ToDouble(Console.ReadLine());
        string dnainput;
        string[] dna = new string[1000];
        int dnalngth = 0;
        string[] randomdna = new string[5];
        string gendername = " ";

//first choosing between 3 operations to initalize dna string
        switch (choose)
        {
            //read txt file
            case 1:
                Console.Clear();
                string filename;
                Console.WriteLine("Please enter the name of text file (The file must be located at C:):");
                filename = (Console.ReadLine());
                dnainput =  File.ReadAllText("c:\\" + filename) ;
                int modcontrol = dnainput.Length % 3;
                dna = new string[150];
                int x1 = 0;

                if (modcontrol == 0)
                {
                    for (int i = 0; i <= dnainput.Length - 3; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }
                }

                else if(modcontrol==2)
                {
                    for (int i = 0; i< dnainput.Length-4 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    dna[x1] = dnainput[dnainput.Length - 1].ToString() + dnainput[dnainput.Length - 2].ToString();

                    for (int i = 0; i < dna.Length; i++)
                    {
                        Console.Write(dna[i] + " ");

                    }
                }
                
                else if (modcontrol == 1)
                {
                    for (int i = 0; i< dnainput.Length-3 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    dna[x1] = dnainput[dnainput.Length - 1].ToString();
                }
                
                for (int i = 0; i < dna.Length; i++)
                {
                    Console.Write(dna[i] + " ");

                }
                break;
    
            //input dna 
            case 2:
                Console.Clear();
                Console.WriteLine("Please Enter the Dna String"); 
                dnainput = Console.ReadLine();
                int dnainputmod = dnainput.Length % 3;
                dnalngth = dna.Length;
                for (int i = 0; i < dna.Length; i++)
                {
                    dna[i] = null;
                }
                x1 = 0;
                if (dnainputmod == 0)
                {
                    for (int i = 0; i < dnainput.Length - 2; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }
                    Console.Write("DNA Strand: ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }

                    Console.WriteLine(" ");
                }
                else if(dnainputmod==2)
                {
                    for (int i = 0; i< dnainput.Length-4 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    dna[x1] = dnainput[dnainput.Length - 1].ToString() + dnainput[dnainput.Length - 2].ToString();
                    Console.Write("DNA Strand: ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }

                    Console.WriteLine(" ");
                }
                
                else if (dnainputmod == 1)
                {
                    for (int i = 0; i< dnainput.Length-3 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    dna[x1] = dnainput[dnainput.Length - 1].ToString();
                    
                    Console.Write("DNA Strand: ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }

                    Console.WriteLine(" ");
                }
                
                

                break;
    
            //random dna
            case 3: 
                Console.WriteLine("Please choose way of the random: ");
                Console.WriteLine("1-BLOB Random ");
                Console.WriteLine("2-Random without any rule ");
                int choosecase = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choosecase)
                {
                    case 1:Console.Clear();
                        Random rndmdna = new Random();
                        string[] words = { "A", "T", "G", "C" };
                        //dna random
                        int agen = rndmdna.Next(1, 7);
                        int acodon = rndmdna.Next(1, 7);
                        int blob = agen * acodon;
                        while (blob % 3 != 0)
                        {
                            agen = rndmdna.Next(1, 7);
                            acodon = rndmdna.Next(1, 7);
                            blob = agen * acodon;

                        }

                        randomdna = new string[ 3*blob ];
                        for (int i = 0; i < 3*blob; i++)
                        {
                            int b = rndmdna.Next(0, 4);
                            randomdna[i] = words[b];


                        }

                        string[] splitteddna = new string[blob];
                        int x = 0;

                        while (x <blob)
                        {
                            for (int i = 0; i <(3*blob)-2; i = i + 3)
                            {

                                splitteddna[x] = randomdna[i] + randomdna[i + 1] + randomdna[i + 2];
                                while (splitteddna[x] == "ATG" || splitteddna[x] == "TAG" || splitteddna[x] == "TAA" ||
                                       splitteddna[x] == "TGA")
                                {
                                    int bb = rndmdna.Next(0, 4);
                                    int cc = rndmdna.Next(0, 4);
                                    int d = rndmdna.Next(0, 4);
                                    randomdna[i] = words[bb];
                                    randomdna[i + 1] = words[cc];
                                    randomdna[i + 2] = words[d];
                                    splitteddna[x] = randomdna[i] + randomdna[i + 1] + randomdna[i + 2];
                                        

                                }
                                
                                x++;

                            }
                        }
                       
                        //gender random

                        string[] gender = new string[4];
                        int c = rndmdna.Next(0, 6);
                        switch (c)
                        {
                            case 0:
                                gender[0] = "ATG";
                                gender[1] = "AAA";
                                gender[2] = "TTT";
                                gender[3] = "TAG";
                                gendername = "XX";
                                break;
                            case 1:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "AAA";
                                gender[3] = "TAG";
                                gendername = "XX";
                                break;
                            case 2:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "TTT";
                                gender[3] = "TAG";
                                gendername = "XX";
                                break;
                            case 3:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "CCC";
                                gender[3] = "TAG";
                                gendername = "XY";
                                break;
                            case 4:
                                gender[0] = "ATG";
                                gender[1] = "GGG";
                                gender[2] = "AAA";
                                gender[3] = "TAG";
                                gendername = "YX";
                                break;
                            case 5:
                                gender[0] = "ATG";
                                gender[1] = "GGG";
                                gender[2] = "TTT";
                                gender[3] = "TAG";
                                gendername = "YX";
                                break;
                        }

                        Console.Write("Random DNA: "+" ");
                        dna = new String [1000];
                        //gender to main array
                        for (int qqq = 0; qqq <= 3; qqq++)
                        {
                            dna[qqq] = gender[qqq];
                            Console.Write(dna[qqq]+ " ");
                        }

                        

                        string[] stopcodon = new string[] { "TAA", "TGA", "TAG" };
                        int qq = 0;
                        
                        
                        //main array with start and stop codons
                        for (int q1 = 4; q1 <splitteddna.Length+4+(2*agen) ; q1++)
                        {
                            if ( q1 == 4 || q1 == 4 + acodon + 2 || q1 == 4 + 2 * acodon + 4 || q1 == 4 + 3 * acodon + 6 ||
                                 q1 == 4 + 4 * acodon + 8 || q1 == 4 + 5 * acodon + 10 )
                                {
                                    dna[q1] = "ATG";
                                    Console.Write(dna[q1] + " ");
                                    
                                }
                                
                            else if ( q1 == 4 + acodon +1 || q1 == 4 + 2 * acodon +3|| q1 == 4 + 3 * acodon + 5 ||
                                          q1 == 4 + 4 * acodon + 7 || q1 == 4 + 5 * acodon + 9 || q1 == 4 + 6 * acodon + 11 )
                            { 
                                    int cdnrndm = rndmdna.Next(0, 3);
                                    dna[q1] = stopcodon[cdnrndm];
                                    Console.Write(dna[q1] + " ");
                                    

                            }
                            else if (qq < splitteddna.Length)
                            {
                                dna[q1] = splitteddna[qq]; 
                                Console.Write(dna[q1] + " "); 
                                qq++;
                            }
                        }
                        Console.WriteLine(" ");
                        break;
                    case 2 :
                        rndmdna = new Random(); 
                    
                        //dna random
                        string[] dnatemp02=new string[100];
                        words = new string[]{ "A", "T", "G", "C" };
                        agen = rndmdna.Next(2, 8); 
                        acodon = rndmdna.Next(3, 9);
                        for (int i = 0; i < agen * acodon; i++)
                        {
                            int letterrandom = rndmdna.Next(0, 3);
                            dnatemp02[i] = words[letterrandom];
                        }

                        int ax = 0;
                        for (int i = 0; i < dnatemp02.Length - 2; i = i + 3)
                        {
                            dna[ax] = dnatemp02[i] + dnatemp02[i + 1] + dnatemp02[i + 2];
                            ax++;
                        }
                        Console.Write("Random Dna: ");
                        for (int i = 0; i < dna.Length; i++)
                        {
                            if (dna[i] != null)
                            {
                                Console.Write(dna[i]+" ");
                            }
                        }
                        Console.WriteLine(" ");
                        break;
                }
                break;
    
        }

        Console.WriteLine(""); 
        Console.WriteLine("Please Choose an Operation");
        Console.WriteLine("0 |---| 1 |---| 2 |---| 3 |---| 4 |---| 5");
        Console.WriteLine("6 |---| 7 |---| 8 |---| 9 |---| 10 |---| 11");
        Console.WriteLine("12 |---| 13 |---| 14 |---| 15 |---| 16 |---| 17 ");
        int choose1 = Convert.ToInt32(Console.ReadLine());

//other choosing part
        while (choose1 != 0)
        {
            switch (choose1)
            {
                 //read txt file
                 case 1:
                Console.Clear();
                string filename;
                Console.WriteLine("Please enter the name of text file (The file must be located at C:):");
                filename = (Console.ReadLine());
                dnainput =  File.ReadAllText("c:\\" + filename) ;
                int modcontrol = dnainput.Length % 3;
                dna = new string[150];
                int x1 = 0;

                if (modcontrol == 0)
                {
                    for (int i = 0; i <= dnainput.Length - 3; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }
                }

                else if(modcontrol==2)
                {
                    for (int i = 0; i< dnainput.Length-4 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    dna[x1] = dnainput[dnainput.Length - 1].ToString() + dnainput[dnainput.Length - 2].ToString();

                    for (int i = 0; i < dna.Length; i++)
                    {
                        Console.Write(dna[i] + " ");

                    }
                }
                
                else if (modcontrol == 1)
                {
                    for (int i = 0; i< dnainput.Length-3 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    dna[x1] = dnainput[dnainput.Length - 1].ToString();
                }
                
                for (int i = 0; i < dna.Length; i++)
                {
                    Console.Write(dna[i] + " ");

                }
                break;
                 
                 //input dna 
                case 2:
                Console.Clear();
                Console.WriteLine("Please Enter the Dna String"); 
                dnainput = Console.ReadLine();
                int dnainputmod = dnainput.Length % 3;
                dnalngth = dna.Length;
                for (int i = 0; i < dna.Length; i++)
                {
                    dna[i] = null;
                }
                x1 = 0;
                if (dnainputmod == 0)
                {
                    for (int i = 0; i < dnainput.Length - 2; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }
                    Console.Write("DNA Strand: ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }

                    Console.WriteLine(" ");
                }
                else if(dnainputmod==2)
                {
                    for (int i = 0; i< dnainput.Length-4 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    dna[x1] = dnainput[dnainput.Length - 1].ToString() + dnainput[dnainput.Length - 2].ToString();
                    Console.Write("DNA Strand: ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }

                    Console.WriteLine(" ");
                }
                
                else if (dnainputmod == 1)
                {
                    for (int i = 0; i< dnainput.Length-3 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    dna[x1] = dnainput[dnainput.Length - 1].ToString();
                    
                    Console.Write("DNA Strand: ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }

                    Console.WriteLine(" ");
                }
                
                

                break;
                
                //random dna
                case 3: 
                Console.WriteLine("Please choose way of the random: ");
                Console.WriteLine("1-BLOB Random ");
                Console.WriteLine("2-Random without any rule ");
                int choosecase = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choosecase)
                {
                    case 1:
                        Console.Clear();
                        Random rndmdna = new Random();
                        string[] words = { "A", "T", "G", "C" };
                        //dna random
                        int agen = rndmdna.Next(1, 7);
                        int acodon = rndmdna.Next(1, 7);
                        int blob = agen * acodon;
                        while (blob % 3 != 0)
                        {
                            agen = rndmdna.Next(1, 7);
                            acodon = rndmdna.Next(1, 7);
                            blob = agen * acodon;

                        }

                        randomdna = new string[ 3*blob ];
                        for (int i = 0; i < 3*blob; i++)
                        {
                            int b = rndmdna.Next(0, 4);
                            randomdna[i] = words[b];


                        }

                        string[] splitteddna = new string[blob];
                        int x = 0;

                        while (x <blob)
                        {
                            for (int i = 0; i <(3*blob)-2; i = i + 3)
                            {

                                splitteddna[x] = randomdna[i] + randomdna[i + 1] + randomdna[i + 2];
                                while (splitteddna[x] == "ATG" || splitteddna[x] == "TAG" || splitteddna[x] == "TAA" ||
                                       splitteddna[x] == "TGA")
                                {
                                    int bb = rndmdna.Next(0, 4);
                                    int cc = rndmdna.Next(0, 4);
                                    int d = rndmdna.Next(0, 4);
                                    randomdna[i] = words[bb];
                                    randomdna[i + 1] = words[cc];
                                    randomdna[i + 2] = words[d];
                                    splitteddna[x] = randomdna[i] + randomdna[i + 1] + randomdna[i + 2];
                                        

                                }
                                
                                x++;

                            }
                        }
                       
                        //gender random

                        string[] gender = new string[4];
                        int c = rndmdna.Next(0, 6);
                        switch (c)
                        {
                            case 0:
                                gender[0] = "ATG";
                                gender[1] = "AAA";
                                gender[2] = "TTT";
                                gender[3] = "TAG";
                                gendername = "XX";
                                break;
                            case 1:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "AAA";
                                gender[3] = "TAG";
                                gendername = "XX";
                                break;
                            case 2:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "TTT";
                                gender[3] = "TAG";
                                gendername = "XX";
                                break;
                            case 3:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "CCC";
                                gender[3] = "TAG";
                                gendername = "XY";
                                break;
                            case 4:
                                gender[0] = "ATG";
                                gender[1] = "GGG";
                                gender[2] = "AAA";
                                gender[3] = "TAG";
                                gendername = "YX";
                                break;
                            case 5:
                                gender[0] = "ATG";
                                gender[1] = "GGG";
                                gender[2] = "TTT";
                                gender[3] = "TAG";
                                gendername = "YX";
                                break;
                        }


                        dna = new String [1000];
                        Console.Write("Random DNA:"+" ");
                        //gender to main array
                        for (int qqq = 0; qqq <= 3; qqq++)
                        {
                            dna[qqq] = gender[qqq];
                            Console.Write(dna[qqq]+ " ");
                        }

                        

                        string[] stopcodon = new string[] { "TAA", "TGA", "TAG" };
                        int qq = 0;
                        

                        //main array with start and stop codons
                        for (int q1 = 4; q1 <splitteddna.Length+4+(2*agen) ; q1++)
                        {
                            if ( q1 == 4 || q1 == 4 + acodon + 2 || q1 == 4 + 2 * acodon + 4 || q1 == 4 + 3 * acodon + 6 ||
                                 q1 == 4 + 4 * acodon + 8 || q1 == 4 + 5 * acodon + 10 )
                                {
                                    dna[q1] = "ATG";
                                    Console.Write(dna[q1] + " ");
                                    
                                }
                                
                            else if ( q1 == 4 + acodon +1 || q1 == 4 + 2 * acodon +3|| q1 == 4 + 3 * acodon + 5 ||
                                          q1 == 4 + 4 * acodon + 7 || q1 == 4 + 5 * acodon + 9 || q1 == 4 + 6 * acodon + 11 )
                            { 
                                    int cdnrndm = rndmdna.Next(0, 3);
                                    dna[q1] = stopcodon[cdnrndm];
                                    Console.Write(dna[q1] + " ");
                                    

                            }
                            else if (qq < splitteddna.Length)
                            {
                                dna[q1] = splitteddna[qq]; 
                                Console.Write(dna[q1] + " "); 
                                qq++;
                            }
                        }
                        Console.WriteLine(" ");
                        break;
                    case 2 :
                        rndmdna = new Random(); 
                    
                        //dna random
                        string[] dnatemp02=new string[100];
                        words = new string[]{ "A", "T", "G", "C" };
                        agen = rndmdna.Next(2, 8); 
                        acodon = rndmdna.Next(3, 9);
                        for (int i = 0; i < agen * acodon; i++)
                        {
                            int letterrandom = rndmdna.Next(0, 3);
                            dnatemp02[i] = words[letterrandom];
                        }

                        int ax = 0;
                        for (int i = 0; i < dnatemp02.Length - 2; i = i + 3)
                        {
                            dna[ax] = dnatemp02[i] + dnatemp02[i + 1] + dnatemp02[i + 2];
                            ax++;
                        }
                        Console.Write("Random Dna: ");
                        for (int i = 0; i < dna.Length; i++)
                        {
                            if (dna[i] != null)
                            {
                                Console.Write(dna[i]+" ");
                            }
                        }
                        Console.WriteLine(" ");
                        break;
                }
                break;
        
                //check dna gene structure
                case 4:
                    Console.Clear();
                    string[] repcounter = new string[] { "" };
                    for (int i = 0; i < dna.Length; i++)
                    {
                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase4 = repcounter[0];

                    char a1, b1, c1;
                    int i11 = 0, i22 = 1, i33 = 2;

                    string[] DNA1 = new string[100];

                    float NumberOfCodons = (dnacase4.Length / 3);
                    int numberofcodons1 = Convert.ToInt32(NumberOfCodons);


                    for (int i = 0; i < numberofcodons1; i++)
                    {
                        a1 = dnacase4[i11];
                        b1 = dnacase4[i22];
                        c1 = dnacase4[i33];
                        DNA1[i] = a1 + "" + b1 + "" + c1 + ""; //We created an array which includes codons.
                        i11 += 3;
                        i22 += 3;
                        i33 += 3;
                    }

                    Console.Write("\nDNA sequence : ");
                    for (int i = 0; i < numberofcodons1; i++)
                    {
                        Console.Write(DNA1[i] + " ");
                    }

                    if (dnacase4.Length % 3 != 0)
                    {
                        Console.WriteLine("Incompleted codons won't be shown.");
                    }

                    int count;
                    count = 0;
                    for (int i = 0; i < numberofcodons1; i++)
                    {
                        if (DNA1[i] == "ATG")
                        {
                            if (DNA1[i + 1] == "TAG" || DNA1[i + 1] == "TGA" || DNA1[i + 1] == "TAA")
                            {
                                count++;
                            }
                        }
                    }



                    int length = (dnacase4.Length / 3) - 1;
                    if (dnacase4.Length % 3 != 0)
                    {
                        Console.WriteLine("Codon structure error!");
                        tester3 = false;
                        if (dnacase4.Length % 3 == 1)
                        {
                            Console.WriteLine("There is an extra nucleotide.");
                        }
                        else if (dnacase4.Length % 3 == 2)
                        {
                            Console.WriteLine("There are extra 2 nucleotides.");
                        }
                    }


                    if (DNA1[0] != "ATG" || DNA1[1] == "ATG" ||
                        DNA1[length] != "TGA" && DNA1[length] != "TAG" && DNA1[length] != "TAA")
                    {
                        Console.WriteLine("\nGene structure error!");
                        tester4 = false;
                    }
                  
                    for (int k = 0; k < numberofcodons1; k++)
                    {
                        if (k == numberofcodons1-1)
                        {
                            Console.WriteLine("");
                        }
                        else if ((DNA1[k] == "TGA" || DNA1[k] == "TAG" || DNA1[k] == "TAA") && DNA1[k + 1] != "ATG" && tester4 == true)
                        {
                            Console.WriteLine("\nGene structure error!");
                            tester4 = false;
                        }
                    }

                    for (int i = 0; i < numberofcodons1; i++)
                    {
                        if (DNA1[i] == "ATG" && tester3 == true && tester4 == true)
                        {
                            if ((DNA1[i + 1] == "TGA" || DNA1[i + 1] == "TAG" || DNA1[i + 1] == "TAA") && tester3 == true && tester4 == true )
                            {
                                
                                tester5 = false;
                            }
                        }
                    }

                    if (tester5 == false)
                    {
                        Console.WriteLine("Not BLOB,but OK!");
                    }


                    if (tester3 == true && tester4 == true && tester5 == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Gene Structure is OK!");
                    }


                    test = true;
                    break;
        
                // check dna of blob organism
                case 5:
                    Console.Clear();
                    repcounter = new string[] { "" };

                    for (int i = 0; i < dna.Length; i++)
                    {
                         
                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase5 = repcounter[0];

                    char d1, e1, f1;
                    int i4 = 0, i5 = 1, i6 = 2;

                    string[] DNA2 = new string[150];

                    float NumberofCodons = dnacase5.Length / 3;
                    int numberofcodonS = Convert.ToInt32(NumberofCodons);


                    for (int i = 0; i < numberofcodonS; i++)
                    {
                        d1 = dnacase5[i4];
                        e1 = dnacase5[i5];
                        f1 = dnacase5[i6];
                        DNA2[i] = d1 + "" + e1 + "" + f1 + ""; //We created an array which includes codons.
                        i4 += 3;
                        i5 += 3;
                        i6 += 3;
                    }

                    Console.Write("\nDNA sequence : ");
                    for (int i = 0; i < numberofcodonS; i++)
                    {
                        Console.Write(DNA2[i] + " ");
                    }
                    Console.WriteLine(" ");

                    if (dnacase5.Length % 3 != 0)
                    {
                        Console.WriteLine("Incompleted codons won't be shown.");
                    }


                    int count1 = 0, count2 = 0;
                    for (int i = 0; i < numberofcodonS; i++)
                    {
                        if (DNA2[i] == "ATG")
                        {
                            count1++;
                        }

                        if (DNA2[i] == "TAG" || DNA2[i] == "TGA" || DNA2[i] == "TAA")
                        {
                            count2++;
                        }

                    }



                    for (int i = 0; i < numberofcodonS; i++)
                    {
                        if (DNA2[i] == "ATG")
                        {
                            if (DNA2[i + 1] == "TAG" || DNA2[i + 1] == "TGA" || DNA2[i + 1] == "TAA")
                            {
                                
                                tester = false;
                            }

                        }
                    }


                    if (tester == false)
                    {
                        Console.WriteLine("Number of codons error!");
                    }



                    if (DNA2[0] == "ATG")
                    {
                        if (DNA2[1] != "AAA" && DNA2[1] != "TTT" && DNA2[1] != "CCC" && DNA2[1] != "GGG" && DNA2[2] != "AAA" &&
                            DNA2[2] != "TTT" && DNA2[2] != "CCC" && DNA2[2] != "GGG")
                        {
                            Console.WriteLine("Gender error!");
                            tester1 = false;
                        }
                        else if (DNA2[1] != "AAA" && DNA2[1] != "TTT" && DNA2[1] != "CCC" && DNA2[1] != "GGG")
                        {
                            Console.WriteLine("Gender error!");
                            tester1 = false;
                        }
                        else if (DNA2[2] != "AAA" && DNA2[2] != "TTT" && DNA2[2] != "CCC" && DNA2[2] != "GGG")
                        {
                            Console.WriteLine("Gender error!");
                            tester1 = false;
                        }

                    }

                    if (count1 < 2)
                    {

                        Console.WriteLine("Number of genes error!");
                        tester1 = false;

                    }
                    else if (count2 < 2)
                    {
                        Console.WriteLine("Number of genes error!");
                        tester1 = false;
                    }


                    if ((tester == true && tester1 == true && tester2 == true)&& (test == false))
                    {
                        Console.WriteLine("You didn't check the gene structure!");
                    }

                    else if ((tester == true&& tester1 == true && tester2 == true ) && (tester3 == false || tester4 == false || tester5 == false))
                    {
                        Console.WriteLine("Gene structure is not valid.");
                    }

                    else if (tester == true && tester1 == true && tester2 == true&& tester5 == true && tester4 == true && tester3 == true)
                    {
                        Console.WriteLine("BLOB is OK!");
                    }

                    break;
        
                //complement of a DNA sequence
                case 6:
                    Console.Clear();
                    repcounter = new string[] { "" };
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase6 = repcounter[0];
                    Console.WriteLine("The Original DNA:"+" ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }
                    
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    char[] dna2 = new char[dnacase6.Length];

                    for (int i = 0; i < dnacase6.Length; i++)
                    {
                        dna2[i] = dnacase6[i];
                    }

                    for (int j = 0; j < dna2.Length; j++)
                    {
                        if (dna2[j] == 'A')
                        {
                            dna2[j] = 'T';
                            continue;
                        }
                        else if (dna2[j] == 'T')
                        {
                            dna2[j] = 'A';
                            continue;
                        }
                        else if (dna2[j] == 'G')
                        {
                            dna2[j] = 'C';
                            continue;
                        }
                        else if (dna2[j] == 'C')
                        {
                            dna2[j] = 'G';
                            continue;
                        }
                        else
                        {
                            continue;
                        }



                    }

                    string[] DNA = new string[150];
                    char aaa, bbb, ccc;
                    int i1 = 0, i2 = 1, i3 = 2;
                    int numberofcodons = dna2.Length / 3;
                    for (int i = 0; i < numberofcodons; i++)
                    {
                        aaa = dna2[i1];
                        bbb = dna2[i2];
                        ccc = dna2[i3];
                        DNA[i] = aaa + "" + bbb + "" + ccc + "";
                        i1 += 3;
                        i2 += 3;
                        i3 += 3;
                    }
                    
                    Console.WriteLine("The Complement of DNA: "+" ");
                    for (int j = 0; j < numberofcodons; j++)
                    {
                        Console.Write(DNA[j] + " ");
                    }
                    Console.WriteLine(" ");

                    for (int i = 0; i < DNA.Length; i++)
                    {
                        dna[i] = DNA[i];
                    }

                    break;
        
                //determine amino-acids  
                case 7:
                    Console.Clear();
                    repcounter = new string[] { "" };
                    int ss = 0;
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase7 = repcounter[0];

                    char d123, e123, f123;
                    int i444 = 0, i555 = 1, i666 = 2;

                    string[] DNA123 = new string[450];

                    float NumberofCodons123 = dnacase7.Length / 3;
                    int numberofcodonS123 = Convert.ToInt32(NumberofCodons123);


                    string[] aa = new string[] {"GCT","GCC","GCA","GCG","CGT","CGC","CGA","CGG","AGA","AGG","AAT","AAC","GAT","GAC","TGT","TGC","CAA","CAG","GAA","GAG","GGT","GGC","GGA","GGG",
                        "CAT","CAC","ATT","ATC","ATA","CTT","CTC","CTA","CTG","TTA","TTG"
                        ,"AAG","AAA","ATG","TTT","TTC","CCT","CCC","CCA","CCG","TCT","TCC","TCA","TCG","AGT","AGC","ACT","ACC","ACA","ACG","TGG","TAT","TAC","GTT","GTC","GTA","GTG","TAA","TGA","TAG"};

                    string[] aa_names = new string[] {"Ala", "Ala", "Ala", "Ala","Arg", "Arg", "Arg", "Arg", "Arg", "Arg" ,"Asn","Asn","Asp","Asp","Cys","Cys","Gln","Gln","Glu","Glu" ,
                        "Gly","Gly","Gly","Gly","His","His","Ile","Ile","Ile","Leu","Leu","Leu","Leu","Leu","Leu","Lys","Lys","Met","Phe","Phe","Pro","Pro","Pro","Pro","Ser","Ser","Ser","Ser","Ser","Ser",
                        "Thr","Thr","Thr","Thr","Trp","Tyr","Tyr","Val","Val","Val","Val","S-C","S-C","S-C"};


                    for (int i = 0; i < numberofcodonS123; i++)
                    {
                        d123 = dnacase7[i444];
                        e123 = dnacase7[i555];
                        f123 = dnacase7[i666];
                        DNA123[i] = d123 + "" + e123 + "" + f123 + "";
                        i444 += 3;
                        i555 += 3;
                        i666 += 3;
                    }


                    for (int h = 0; h < dnacase7.Length; h++)
                    {
                        if (DNA123[h] == "")
                        {
                            break;
                        }
                        Console.Write(DNA123[h] + " ");                                                                  
                    }

                    Console.WriteLine();

                    for (int i = 0; i < numberofcodonS123; i++)
                    {
                        for (int j = 0; j < aa.Length; j++)
                        {
                            if (DNA123[i] == aa[j])
                            {
                                Console.Write(aa_names[j]+" ");
                            }
                        }

                    }

                    Console.WriteLine("\n\n(S-C means Stop Codon.)");

                    

                    break;
        
                //delete codons
                case 8:
                    Console.Clear();
                    //deleting codons
                    Console.Write("The Original DNA:"+ " ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if(dna[i]!=null)   Console.Write(dna[i]+ " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Please enter the number of codons you want to delete:");
                    int delcodon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the number of which codon do you want to start to delete: ");
                    int delcodonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.Write("The Edited DNA:"+ " ");
                    for (int i = 0; i < delcodonth-1; i++)
                    {
                      if(dna[i]!= null)  Console.Write(dna[i]+ " ");
                    }
                      
            
                    for (int d = delcodonth - 1; d < dna.Length; d++)
                    {
                
                        if (d + delcodon <= dna.Length - 1)
                        {
                            dna[d] = dna[d + delcodon];
                           if(dna[d]!=null) Console.Write(dna[d]+ " ");
                    
                        }
                        if (d == dna.Length-1)
                        {
                            Console.WriteLine(" ");
                        }

                    }
                    

                    break;
        
                //insert codons
                case 9:
                    Console.Clear();
                    //inserting codons
                    Console.Write("The original DNA:"+ " ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if(dna[i]!=null) Console.Write(dna[i]+ " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Please enter the codon sequence:");
                    string insertcodonFRST =Console.ReadLine();
                    string[] insertcodon = new string[insertcodonFRST.Length/3];
                    int i9 = 0;
                    for (int i = 0; i < insertcodonFRST.Length-2; i=i+3)
                    {
                        insertcodon[i9] = insertcodonFRST[i].ToString() + insertcodonFRST[i + 1].ToString() + insertcodonFRST[i + 2].ToString();
                        i9++;
                    }
            

                    Console.WriteLine("Please enter the number of which codon do you want to start to insert: ");
                    int inscodonth = Convert.ToInt32(Console.ReadLine());
            
                    
                    
            
                    string[] dnatemp = new string[dna.Length];

                    for (int i = 0; i < dna.Length; i++)
                    {
                        dnatemp[i] = dna[i];
                    }
                    int ic = 0;
                    
                    for (int i = inscodonth - 1; i < dna.Length; i++)
                    {
                            if (ic < insertcodon.Length)
                            {
                                dna[i] = insertcodon[ic];
                                ic++;
                            }
                    }
                    

                    for (int d = inscodonth+insertcodon.Length - 1; d <dna.Length-insertcodon.Length; d++)
                    {

                        dna[d] = dnatemp[d - insertcodon.Length];

                    }
                    Console.WriteLine(" ");
                    Console.Write("The Edited DNA: ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                     if(dna[i]!=null)   Console.Write(dna[i]+" ");
                    }

                    Console.WriteLine(" ");
            

                    break;
        
                //find codons
                case 10:
                    Console.Clear();
                    repcounter = new string[] { "" };
            
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase10 = repcounter[0];
                    string ayrik1 = "";
                    string ayrik2 = "";
            
                    string[] find1 = new string[250];
                    int step, q10;
                    bool check = false;

                    Console.Write("What codon sequence are you looking for:");
                    string ins = Console.ReadLine();

                    Console.Write("Which codon do you want to start from: ");
                    step = Convert.ToInt32(Console.ReadLine());
                    q10 = step;
                
                    for (int i = 0; i < dnacase10.Length; i++)
                    {
                        if (i % 3 == 0 && i>0)
                        {
                            ayrik1 += " " + dnacase10[i];
                            continue;
                        }
                        ayrik1 += dnacase10[i];

                    }
                
                    for (int i = 0; i < ins.Length; i++)
                    {
                    
                        if ((i % 3 == 0) && (i>0))
                        {
                            ayrik2 +=" " + ins[i];
                            continue;
                        }
                        ayrik2 += ins[i];
                    

                    }

                    for (int l = 0; l < ayrik1.Split().Length; l++)
                    {
                        find1[l] += ayrik1.Split()[l];
                    }

                    for (int p = step-1; p < ayrik1.Split().Length ; p++)
                    {
                    
                        if ((ayrik2 == find1[p])||
                            (ayrik2 == find1[p]+" "+find1[p+1])||
                            (ayrik2 == find1[p]+" "+find1[p+1]+" "+find1[p+2])||
                            (ayrik2 == find1[p]+" "+find1[p+1]+" "+find1[p+2]+" "+find1[p+3])||
                            (ayrik2 == find1[p]+" "+find1[p+1]+" "+find1[p+2]+" "+find1[p+3]+" "+find1[p+4])||
                            (ayrik2 == find1[p]+" "+find1[p+1]+" "+find1[p+2]+" "+find1[p+3]+" "+find1[p+4]+" "+find1[p+5]))
                        {
                            Console.WriteLine("DNA strand: "+ayrik1);
                            Console.WriteLine("Codon sequence: "+ayrik2);
                            Console.WriteLine("Starting from: "+q10);
                            Console.WriteLine("Result: "+(p+1));
                            check = true;
                            continue;
                        
                        }
                        step++;

                    }

                    if (check == false)
                    {
                        Console.WriteLine("DNA strand: "+ayrik1);
                        Console.WriteLine("Codon sequence: "+ayrik2);
                        Console.WriteLine("Starting from: "+q10);
                        Console.WriteLine("Result: "+-1+"(NOT FOUND!!)");
                    }
            
            
           
                    break;
        
                //reverse codons
                case 11:
                    Console.Clear();
                    repcounter = new string[] { "" };
            
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase11 = repcounter[0];
                    string[] find11 = new string[250];
                    ayrik1 = "";
                    ayrik2 = "";
                    string temp, ayrik3 = "";
                    int step11, q11;

                    Console.Write("How many codons do you want to reverse: ");
                    int ins11 = Convert.ToInt32(Console.ReadLine());
                    int t = ins11;

                    Console.Write("Which codon do you want to start from: ");
                    step = Convert.ToInt32(Console.ReadLine());
                    q11 = step;
                
                    for (int i = 0; i < dnacase11.Length; i++)
                    {
                        if (i % 3 == 0 && i>0)
                        {
                            ayrik1 += " " + dnacase11[i];
                            continue;
                        }
                        ayrik1 += dnacase11[i];
                    }
                
                    for (int l = 0; l < ayrik1.Split().Length; l++)
                    {
                        find11[l] += ayrik1.Split()[l];
                    }

                    if (ins11 % 2 == 0)
                    {
                        for (int p = step - 1; p < q11 + ins11 - 1; p++)
                        {
                            temp = find11[p];
                            find11[p] = find11[q11 + ins11 - 2];
                            find11[q11 + ins11 - 2] = temp;
                            q11--;
                        }
                    }
                    else
                    {
                        for (int p = step - 1; p < q11 + ins11 - 2; p++)
                        {
                            temp = find11[p];
                            find11[p] = find11[q11 + ins11 - 2];
                            find11[q11 + ins11 - 2] = temp;
                            q11--;
                        }
                    }
                
                    for (int i = 0; i < find11.Length; i++)
                    {
                        ayrik2+=find11[i];
                    }
                
                    for (int i = 0; i < ayrik2.Length; i++)
                    {
                        if (i % 3 == 0 && i>0)
                        {
                            ayrik3 += " " + ayrik2[i];
                            continue;
                        }
                        ayrik3 += ayrik2[i];
                    }
                
                    Console.WriteLine("DNA strand (stage 1): "+ayrik1);
                    Console.WriteLine("Reverse "+ins11+" codons starting from codon "+step);
                    Console.WriteLine("DNA strand (stage 2): "+ayrik3);
            
                    break;
        
                //Find the number of genes in DNA strand
                case 12:
                    Console.Clear();
                    repcounter = new string[] { "" };
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase12 = repcounter[0];
                    char d12, e12, f12;
                    int i42 = 0, i52 = 1, i62 = 2;

                    string[] DNA22 = new string[100];

                    float NumberofCodons12 = dnacase12.Length / 3;
                    int numberofcodonS12 = Convert.ToInt32(NumberofCodons12);


                    for (int i = 0; i < numberofcodonS12; i++)
                    {
                        d12 = dnacase12[i42];
                        e12 = dnacase12[i52];
                        f12 = dnacase12[i62];
                        DNA22[i] = d12 + "" + e12 + "" + f12 + "";
                        i42 += 3;
                        i52 += 3;
                        i62 += 3;
                    }
                    
                    Console.Write("DNA Strand:"+" ");
                    for (int i = 0; i < numberofcodonS12; i++)
                    {
                        Console.Write(DNA22[i] + " ");
                    }

                    int Counterr = 0;
                    for (int j = 0; j < numberofcodonS12; j++)
                    {

                        if (DNA22[j] == "ATG")
                        {
                            for (int k = j; k < numberofcodonS12; k++)
                            {
                                if (DNA22[k] == "TGA" || DNA22[k] == "TAG" || DNA22[k] == "TAA")
                                {
                                    Counterr++;
                                    break;
                
                                }
                            }
                        }

                    }

                    Console.WriteLine("\nNumber of genes : " + Counterr);
                    break;
        
                //Find the shortest gene in DNA
                case 13:
                    Console.Clear();
                    repcounter = new string[] { "" };
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase13 = repcounter[0];
                    Console.Write("The Original DNA Strand:"+" ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }
                    Console.WriteLine(" ");

                    char[] dna55=dnacase13.ToCharArray();
                    string[] DNA13 = new string[450];
                    char a13, b13, c13;
                    int i55 = 0, i56 = 1, i57 = 2;
                    int numberofcodons13 = dna55.Length / 3;
                    for (int i = 0; i < numberofcodons13; i++)
                    {
                        a13= dna55[i55];
                        b13 = dna55[i56];
                        c13= dna55[i57];
                        DNA13[i] = a13 + "" + b13 + "" + c13 + "";
                        i55 += 3;
                        i56 += 3;
                        i57 += 3;
                    }
                    int shortestgene = int.MaxValue;
                    string[] dna31 = new string[450];
                    int count13 = 0;
                    int pozitionofgene = 0;
                    for (int i = 0; i < numberofcodons13; i++)
                    {
                        if (DNA13[i]=="ATG")
                        {
                            for(int j =i; j <DNA13.Length-i ; j++)
                            {
                                if (DNA13[j] == "TAA" || DNA13[j] == "TGA" || DNA13[j]=="TAG")
                                {
                                    count13++;
                                    break;
                                }
                                else
                                {
                                    count13++;
                                }
                            }
                            if(count13>shortestgene)
                            {
                                continue;
                            }
                            else
                            {
                                shortestgene = count13;
                                pozitionofgene = i+1;
                            }
                            count13 = 0;
                        }
                    }
                    for(int k=0;k<shortestgene;k++)
                    {
                        dna31[k] = DNA13[k+pozitionofgene-1];
                    }
                    Console.Write("Shortest gene: ");
                    for(int d=0;d<dna31.Length;d++)
                    {
                        Console.Write(dna31[d]+" ");
                    }
                    Console.WriteLine("\nNumber of codons in gene: " + shortestgene);
                    Console.WriteLine("Pozition of gene: " + pozitionofgene);
                    break;
        
                //Find the longest gene in DNA
                 case 14:
                    Console.Clear();
                    repcounter = new string[] { "" };
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase14 = repcounter[0];
                    
                    string[] find14 = new string[250];
                    ayrik1 = "";
                    ayrik3 = "";
                    string temp14, dnaL = "", dnaL1 = "";
                    int maxnum = 0, count14 = 0, count15 = 0, c14 = 1, c15 = 0;

                
                    for (int i = 0; i < dnacase14.Length; i++)
                    {
                        if (i % 3 == 0 && i>0)
                        {
                            ayrik1 += " " + dnacase14[i];
                            continue;
                        }
                        ayrik1 += dnacase14[i];
                    }
                
                    for (int l = 0; l < ayrik1.Split().Length; l++)
                    {
                        find14[l] += ayrik1.Split()[l];
                    }

                    for (int t14 = 0; t14 < ayrik1.Split().Length; t14++)
                    {
                        count14++;
                    
                        if (find14[t14] == "ATG")
                        {
                            dnaL += find14[t14];
                            c14++;
                            
                            continue;
                        }
                        c14++;
                        dnaL += find14[t14];

                        if (find14[t14] == "TAA" || find14[t14] == "TGA" || find14[t14] == "TAG")
                        {
                            if (maxnum < count14)
                            {
                                dnaL1 = dnaL;
                                maxnum = count14;
                                c15 = c14;
                                count14 = 0;
                                dnaL = "";
                                continue;

                            }
                            dnaL += find14[t14];
                            count14 = 0;
                            dnaL = "";
                            continue;
                        }

                    
                    }
                
                    for (int i = 0; i < dnaL1.Length; i++)
                    {
                        if (i % 3 == 0 && i>0)
                        {
                            ayrik3 += " " + dnaL1[i];
                            continue;
                        }
                        ayrik3 += dnaL1[i];
                    }
                
                    Console.WriteLine("The Original DNA Strand:"+" "+ayrik1);
                    Console.WriteLine("Longest gene: "+ayrik3);
                    Console.WriteLine("Number of codons in the gene: "+maxnum);
                    Console.WriteLine("Position of the gene: "+(Math.Abs(c15-maxnum)));
            
                    break;
        
                //most repeated nucleotide sequences
                case 15:
                    Console.Clear();
                    Console.Clear();
                    repcounter = new string[] { "" };
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase15tochar = repcounter[0];
                    char[] dnacase15 = dnacase15tochar.ToCharArray();
                    string[] dnacase15control = new string[300];
                    Console.Write("DNA Strand: ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter the number of nucletide: ");
                    int nucletide = Convert.ToInt32(Console.ReadLine());
                    //dnachararray to string array for checking str
                    int x15 = 0;
                    
                        for (int j = 0; j <= dnacase15.Length - nucletide; j++)
                        {
                            if (x15 <= (dna.Length - 1) * 3)
                            {
                                for (int i = j; i < j + nucletide; i++)
                                {
                                    dnacase15control[x15] += dnacase15[i];
                                    
                                }

                                x15++;
                                
                            }

                            else break;
                        }

                    int temprep = 0;
                    string repeatstring = "";
                    int counter = -1;

                    for (int i = 0; i < dnacase15control.Length; i++)
                    {
                     if(dnacase15control[i]!=null)  Console.Write(dnacase15control[i]+" ");
                    }

                   
                    for (int i = 0; i < dnacase15control.Length - 1; i = i + 2)
                    {
                        if (dnacase15control[i] != null)
                        {
                            for (int j = 1; j < dnacase15control.Length; j++)
                            {
                                if (dnacase15control[i] == dnacase15control[j])
                                {

                                    temprep++;

                                }

                            }

                            if (counter < temprep)
                            {
                                if (i == 0)
                                {
                                    counter = temprep + 1;
                                }
                                else
                                {
                                    counter = temprep;
                                }
                                repeatstring = dnacase15control[i].ToString();
                            }

                            temprep = 0;
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Most Repeeated sequence: "+repeatstring);
                    Console.WriteLine("Frequency: "+counter);
                    
                    break;
        
                // hydrogen bond statistics
                case 16:
                    Console.Clear();
                    repcounter = new string[] { "" };
                    for (int i = 0; i < dna.Length; i++)
                    {

                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase16 = repcounter[0];
                    char harfa = 'A';
                    int countA = 0;

                    for (int i = 0; i < dnacase16.Length; i++)
                    {

                        if (dnacase16[i] == harfa)
                        {
                            countA++;
                        }
                    }

                    //
                    char harft = 'T';
                    int countT = 0;

                    for (int i = 0; i < dnacase16.Length; i++)
                    {
                        if (dnacase16[i] == harft)
                        {
                            countT++;
                        }
                    }

                    //

                    char harfg = 'G';
                    int countG = 0;

                    for (int i = 0; i < dnacase16.Length; i++)
                    {
                        if (dnacase16[i] == harfg)
                        {
                            countG++;

                        }
                    }

                    //

                    char harfc = 'C';
                    int countC = 0;

                    for (int i = 0; i < dnacase16.Length; i++)
                    {
                        if (dnacase16[i] == harfc)
                        {
                            countC++;

                        }
                    }


                    int hydrogena = 2 * countA;
                    int hydrogent = 2 * countT;
                    int hydrogeng = 3 * countG;
                    int hydrogenc = 3 * countC;

                    Console.Write("DNA Strand:"+" ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                        if (dna[i] != null)
                        {
                            Console.Write(dna[i] + " ");
                        }
                    }
                    Console.WriteLine(" ");
                    
                    Console.WriteLine("Number of pairing with 2-hydrogen bonds:" + (countA + countT));
                    Console.WriteLine("Number of pairing with 3-hydrogen bonds:" + (countG + countC));
                    Console.WriteLine("Number of hydrogen bonds:" + (hydrogena + hydrogent + hydrogenc + hydrogeng));
                    break;
                
                //new generations
                case 17:
                    Console.Clear();
                    repcounter = new string[] { "" };
                   
                    for (int i = 0; i < dna.Length; i++)
                    {
                        
                        repcounter[0] = repcounter[0] + dna[i];
                        if (repcounter.Length == dna.Length)
                        {
                            break;
                        }
                    }

                    string dnacase17 = repcounter[0];
                    
                    string gender1 = "";
                    string gender2 = "";
                    for (int ğ = 1; ğ < 11; ğ++)
                    {
                        
                        Console.WriteLine("Generation" +" "+ ğ);
                        if (ğ == 1)
                        {
                            Console.Write("Blob 1 "+gendername+": ");
                            for (int i = 0; i < dna.Length; i++)
                            {
                                if (dna[i] != null)
                                {
                                    Console.Write(dna[i] + " ");
                                }
                            }

                        }

                        else
                        {
                            Console.Write("Blob 1: ");
                            for (int i = 0; i < dnacase17.Length - 2; i = i + 3)
                            {
                                Console.Write(dnacase17[i].ToString()+dnacase17[i+1].ToString()+dnacase17[i+2].ToString()+" ");
                            }
                            
                        }
                        Console.WriteLine("");
                       
                        char[] dna17char = new char[dnacase17.Length];
                        for (int i = 0; i < dnacase17.Length; i++)
                        {
                            dna17char[i] = dnacase17[i];
                        }
                        string[] DNA17 = new string[390];
                        char a, b, c;
                        int i17 = 0, i27 = 1, i37 = 2;
                        int numberofcodons17 = dna17char.Length / 3;
                        for (int i = 0; i < numberofcodons17; i++)
                        {
                            a = dna17char[i17];
                            b = dna17char[i27];
                            c = dna17char[i37];
                            DNA17[i] = a + "" + b + "" + c + "";
                            i17 += 3;
                            i27 += 3;
                            i37 += 3;
                        }
                        
                        //blob 2 dna random
                        
                       
                        //choosing blob 2
                        Console.Clear();
                        Console.WriteLine("Generation" +" "+ ğ);
                        if (ğ == 1)
                        {
                            if (dna[1] == "GGG" || dna[1] == "CCC")
                            {
                                gender1 = "Y";
                            }
                            else if(dna[1]=="AAA"||dna[1]=="TTT")
                            {
                                gender1 = "X";
                            }
                            
                            if (dna[2] == "GGG" || dna[2] == "CCC")
                            {
                                gender2 = "Y";
                            }
                            else if(dna[2]=="AAA"||dna[2]=="TTT")
                            {
                                gender2 = "X";
                            }
                            Console.Write("Blob 1 "+gender1+gender2+": ");
                            for (int i = 0; i < dna.Length; i++)
                            {
                                if (dna[i] != null)
                                {
                                    Console.Write(dna[i] + " ");
                                }
                            }

                        }
                            
                        else
                        {
                            
                            if (DNA17[1] == "GGG" || DNA17[1] == "CCC")
                            {
                                gender1 = "Y";
                            }
                            else if(DNA17[1]=="AAA"||DNA17[1]=="TTT")
                            {
                                gender1 = "X";
                            }
                            
                            if (DNA17[2] == "GGG" || DNA17[2] == "CCC")
                            {
                                gender2 = "Y";
                            }
                            else if(DNA17[2]=="AAA"||DNA17[2]=="TTT")
                            {
                                gender2 = "X";
                            }
                            Console.Write("Blob 1 "+gender1+gender2+": ");
                            for (int i = 0; i < dnacase17.Length - 2; i = i + 3)
                            {
                                Console.Write(dnacase17[i].ToString()+dnacase17[i+1].ToString()+dnacase17[i+2].ToString()+" ");
                            }

                            
                        }
                        Console.WriteLine(" ");    
                        Console.WriteLine("Choose Blob 2:");
                        Console.WriteLine("1-Random");
                        Console.WriteLine("2-Input");
                        int chooseblob = Convert.ToInt16(Console.ReadLine());
                        string dna311 = "";
                        switch (chooseblob)
                        {
                            case 1:
                                Random rndmdna = new Random();
                                string[] words = { "A", "T", "G", "C" }; 
                                //dna random
                                int agen = rndmdna.Next(1, 7);
                                int acodon = rndmdna.Next(1, 7);
                                int blob = agen * acodon;
                                while (blob % 3 != 0)
                                {
                                    agen = rndmdna.Next(1, 7);
                                    acodon = rndmdna.Next(1, 7);
                                    blob = agen * acodon;

                                }

                                randomdna = new string[ 3*blob ];
                                for (int i = 0; i < 3*blob; i++)
                                {
                                    int b17 = rndmdna.Next(0, 4);
                                    randomdna[i] = words[b17];


                                }

                                string[] splitteddna = new string[blob];
                                int x = 0;

                                while (x <blob)
                                {
                                    for (int i = 0; i <(3*blob)-2; i = i + 3)
                                    {

                                        splitteddna[x] = randomdna[i] + randomdna[i + 1] + randomdna[i + 2];
                                        while (splitteddna[x] == "ATG" || splitteddna[x] == "TAG" || splitteddna[x] == "TAA" ||
                                               splitteddna[x] == "TGA")
                                        {
                                            int bb = rndmdna.Next(0, 4);
                                            int cc = rndmdna.Next(0, 4);
                                            int d17 = rndmdna.Next(0, 4);
                                            randomdna[i] = words[bb];
                                            randomdna[i + 1] = words[cc];
                                            randomdna[i + 2] = words[d17];
                                            splitteddna[x] = randomdna[i] + randomdna[i + 1] + randomdna[i + 2];
                                                

                                        }
                                        
                                        x++;

                                    }
                                }
                               
                                //gender random 
                                string gendername2 = "";
                                string[] gender = new string[4];
                                int c17 = rndmdna.Next(0, 6);
                                
                                    switch (c17)
                                    {
                                        case 0:
                                            gender[0] = "ATG";
                                            gender[1] = "AAA";
                                            gender[2] = "TTT";
                                            gender[3] = "TAG";
                                            gendername2 = "XX";
                                            break;
                                        case 1:
                                            gender[0] = "ATG";
                                            gender[1] = "TTT";
                                            gender[2] = "AAA";
                                            gender[3] = "TAG";
                                            gendername2 = "XX";
                                            break;
                                        case 2:
                                            gender[0] = "ATG";
                                            gender[1] = "TTT";
                                            gender[2] = "TTT";
                                            gender[3] = "TAG";
                                            gendername2 = "XX";
                                            break;
                                        case 3:
                                            gender[0] = "ATG";
                                            gender[1] = "TTT";
                                            gender[2] = "CCC";
                                            gender[3] = "TAG";
                                            gendername2 = "XY";
                                            break;
                                        case 4:
                                            gender[0] = "ATG";
                                            gender[1] = "GGG";
                                            gender[2] = "AAA";
                                            gender[3] = "TAG";
                                            gendername2 = "YX";
                                            break;
                                        case 5:
                                            gender[0] = "ATG";
                                            gender[1] = "GGG";
                                            gender[2] = "TTT";
                                            gender[3] = "TAG";
                                            gendername2 = "YX";

                                            break;
                                    }

                                do
                                {
                                    c17 = rndmdna.Next(0, 6);
                                
                                    switch (c17)
                                    {
                                        case 0:
                                            gender[0] = "ATG";
                                            gender[1] = "AAA";
                                            gender[2] = "TTT";
                                            gender[3] = "TAG";
                                            gendername2 = "XX";
                                            break;
                                        case 1:
                                            gender[0] = "ATG";
                                            gender[1] = "TTT";
                                            gender[2] = "AAA";
                                            gender[3] = "TAG";
                                            gendername2 = "XX";
                                            break;
                                        case 2:
                                            gender[0] = "ATG";
                                            gender[1] = "TTT";
                                            gender[2] = "TTT";
                                            gender[3] = "TAG";
                                            gendername2 = "XX";
                                            break;
                                        case 3:
                                            gender[0] = "ATG";
                                            gender[1] = "TTT";
                                            gender[2] = "CCC";
                                            gender[3] = "TAG";
                                            gendername2 = "XY";
                                            break;
                                        case 4:
                                            gender[0] = "ATG";
                                            gender[1] = "GGG";
                                            gender[2] = "AAA";
                                            gender[3] = "TAG";
                                            gendername2 = "YX";
                                            break;
                                        case 5:
                                            gender[0] = "ATG";
                                            gender[1] = "GGG";
                                            gender[2] = "TTT";
                                            gender[3] = "TAG";
                                            gendername2 = "YX";

                                            break;
                                    }

                                }while (gender1 + gender2 == gendername2 ||
                                        gender1 + gender2 == "XY" && gendername2 == "YX" ||
                                        gender1 + gender2 == "YX" && gendername2 == "XY") ;
                                



                                

                                string[] dna3 = new String [1000];
                                
                                //gender to main array
                                for (int qqq = 0; qqq <= 3; qqq++)
                                {
                                    dna3[qqq] = gender[qqq];
                                    
                                }

                                

                                string[] stopcodon = new string[] { "TAA", "TGA", "TAG" };
                                int qq = 0;
                                

                                //main array with start and stop codons
                                for (int q1 = 4; q1 <splitteddna.Length+4+(2*agen) ; q1++)
                                {
                                    if ( q1 == 4 || q1 == 4 + acodon + 2 || q1 == 4 + 2 * acodon + 4 || q1 == 4 + 3 * acodon + 6 ||
                                         q1 == 4 + 4 * acodon + 8 || q1 == 4 + 5 * acodon + 10 )
                                        {
                                            dna3[q1] = "ATG";
                                            
                                            
                                        }
                                        
                                    else if ( q1 == 4 + acodon +1 || q1 == 4 + 2 * acodon +3|| q1 == 4 + 3 * acodon + 5 ||
                                                  q1 == 4 + 4 * acodon + 7 || q1 == 4 + 5 * acodon + 9 || q1 == 4 + 6 * acodon + 11 )
                                    { 
                                            int cdnrndm = rndmdna.Next(0, 3);
                                            dna3[q1] = stopcodon[cdnrndm];
                                            
                                            

                                    }
                                    else if (qq < splitteddna.Length)
                                    {
                                        dna3[q1] = splitteddna[qq]; 
                                         
                                        qq++;
                                    }
                                }
                                Console.WriteLine(" ");
                                
                                string[] repcounter1 = new string[] { "" };
                                for (int i = 0; i < dna3.Length; i++)
                                {

                                    repcounter1[0] = repcounter1[0] + dna3[i];
                                    if (repcounter1.Length == dna3.Length)
                                    {
                                        break;
                                    }
                                }
                                
                                        Console.Write("Blob 2 "+gendername2+": ");
                                        for (int i = 0; i < dna3.Length; i++)
                                        {
                                            if (dna3[i] != null)
                                            {
                                                Console.Write(dna3[i] + " ");
                                            }
                                        }
                                        Console.WriteLine(" ");
                                        dna311 = repcounter1[0];
                                        break;
                            case 2:
                                
                                Console.Write("Please Enter The DNA Strand of Blob 2: ");
                                dna311 = Console.ReadLine();
                                Console.WriteLine(" ");
                                string[] dna311temp = new string[450];
                                string genderme1 = "";
                                string genderme2 = "";
                                int x2 = 0;
                                for (int i = 0; i < dna311.Length - 2; i=i+3)
                                {
                                    dna311temp[x2] = dna311[i].ToString() + dna311[i + 1].ToString() + dna311[i + 2];
                                    x2++;
                                }
                                if (dna311temp[1] == "GGG" || dna311temp[1] == "CCC")
                                {
                                    genderme1 = "Y";
                                }
                                else if(dna311temp[1]=="AAA"||dna311temp[1]=="TTT")
                                {
                                    genderme1 = "X";
                                }
                            
                                if (dna311temp[2] == "GGG" || dna311temp[2] == "CCC")
                                {
                                    genderme2 = "Y";
                                }
                                else if(dna311temp[2]=="AAA"||dna311temp[2]=="TTT")
                                {
                                    genderme2 = "X";
                                }
                                Console.Write("Blob 2 "+genderme1+genderme2+": ");
                               
                                for (int i = 0; i < dna311temp.Length; i++)
                                {
                                    if (dna311temp[i] != null)
                                    {
                                        Console.Write(dna311temp[i] + " ");
                                    }
                                }
                                break;
                        }
                                       
                        Console.WriteLine("");
                        char[] dna4 = new char[dna311.Length];
                        for (int i = 0; i < dna311.Length; i++)
                        {
                            dna4[i] = dna311[i];
                        }
                        string[] DNA27 = new string[100];
                        char d, e, f;
                        int j1 = 0, j2 = 1, j3 = 2;
                        int numberofcodons2 = dna4.Length / 3;
                        for (int k = 0; k < numberofcodons2; k++)
                        {
                            d = dna4[j1];
                            e = dna4[j2];
                            f = dna4[j3];
                            DNA27[k] = d + "" + e + "" + f + "";
                            j1 += 3;
                            j2 += 3;
                            j3 += 3;
                        }
                        string[] DNA3 = new string[100];
                        DNA3[0] = DNA27[0];
                        for (int y = 1; y < 4; y++)
                        {
                            if (y % 2 == 1)
                            {
                                DNA3[y] = DNA17[y];
                            }
                            else
                            {
                                DNA3[y] = DNA27[y];
                            }
                        }
                        string ee = "";
                        for (int l = 0; l < DNA3.Length; l++)
                        {
                            ee += DNA3[l];
                        }
                        DNA3[0] = ee;
                        string[] DNA1sgenes = new string[numberofcodons17];
                        int u = 0;
                        string tt = "";
                        int numberofgene = 0;
                        for (int g = 0; g < DNA17.Length; g++)
                        {
                            if (DNA17[g] == "ATG")
                            {
                                tt += Convert.ToString(DNA17[g]);
                            }
                            else if (DNA17[g] != "ATG" & DNA17[g] != "TAG" & DNA17[g] != "TGA" & DNA17[g] != "TAA")
                            {
                                tt += Convert.ToString(DNA17[g]);
                            }
                            else if (DNA17[g] == "TAG" || DNA17[g] == "TGA" || DNA17[g] == "TAA")
                            {
                                tt = tt + Convert.ToString(DNA17[g]);
                                DNA1sgenes[u] = tt;
                                u++;
                                tt = "";
                                numberofgene++;
                            }
                        }
                        string[] DNA2sgenes = new string[numberofcodons2];
                        int uu = 0;
                        string ttt = "";
                        int numberofgene2 = 0;
                        for (int g = 0; g < DNA27.Length; g++)
                        {
                            if (DNA27[g] == "ATG")
                            {
                                ttt += Convert.ToString(DNA27[g]);
                            }
                            else if (DNA27[g] != "ATG" & DNA27[g] != "TAG" & DNA27[g] != "TGA" & DNA27[g] != "TAA")
                            {
                                ttt += Convert.ToString(DNA27[g]);
                            }
                            else if (DNA27[g] == "TAG" || DNA27[g] == "TGA" || DNA27[g] == "TAA")
                            {
                                ttt = ttt + Convert.ToString(DNA27[g]);
                                DNA2sgenes[uu] = ttt;
                                uu++;
                                ttt = "";
                                numberofgene2++;
                            }
                        }
                        int p = 1;
                        if (numberofgene < numberofgene2)
                        {
                            for (int o = 1; o < numberofgene; o++)
                            {
                                if (o % 2 == 1)
                                {
                                    DNA3[p] = DNA1sgenes[o];
                                    p++;
                                }
                                else
                                {
                                    DNA3[p] = DNA2sgenes[o];
                                    p++;
                                }
                            }
                            for (int oo = numberofgene; oo < numberofgene2; oo++)
                            {
                                DNA3[p] = DNA2sgenes[oo];
                                p++;
                            }
                        }
                        else if (numberofgene > numberofgene2)
                        {
                            for (int o = 1; o < numberofgene2; o++)
                            {
                                if (o % 2 == 1)
                                {
                                    DNA3[p] = DNA1sgenes[o];
                                    p++;
                                }
                                else
                                {
                                    DNA3[p] = DNA2sgenes[o];
                                    p++;
                                }
                            }
                            for (int oo = numberofgene2; oo < numberofgene; oo++)
                            {
                                DNA3[p] = DNA1sgenes[oo];
                                p++;
                            }
                        }
                        else
                        {
                            for (int o = 1; o < numberofgene; o++)
                            {
                                if (o % 2 == 1)
                                {
                                    DNA3[p] = DNA1sgenes[o];
                                    p++;
                                }
                                else
                                {
                                    DNA3[p] = DNA2sgenes[o];
                                    p++;
                                }
                            }
                        }
                        string eee = "";
                        for (int h = 0; h < DNA3.Length; h++)
                        {
                            eee += DNA3[h];
                        }
                        char[] eeee = new char[300];
                        for (int i = 0; i < eee.Length; i++)
                        {
                            eeee[i] = eee[i];
                        }
                        string[] DNAnewborn = new string[100];
                        char z, n, m;
                        int k1 = 0, k2 = 1, k3 = 2;
                        int numberofcodons3 = eeee.Length / 3;
                        for (int i = 0; i < numberofcodons3; i++)
                        {
                            z = eeee[k1];
                            n = eeee[k2];
                            m = eeee[k3];
                            DNAnewborn[i] = z + "" + n + "" + m + "";
                            k1 += 3;
                            k2 += 3;
                            k3 += 3;
                        }
                        double count17 = 0;
                        int count27 = 0;
                        for (int i = 0; i < DNAnewborn.Length-2; i++)
                        {
                            if ((DNAnewborn[i] == "GCC" || DNAnewborn[i] == "GGC" || DNAnewborn[i] == "GCG" || DNAnewborn[i] == "CGG" || DNAnewborn[i] == "CGC" || DNAnewborn[i] == "CCG" || DNAnewborn[i] == "GGG" || DNAnewborn[i] == "CCC") & (DNAnewborn[i + 1] == "GCC" || DNAnewborn[i + 1] == "GGC" || DNAnewborn[i + 1] == "GCG" || DNAnewborn[i + 1] == "CGG" || DNAnewborn[i + 1] == "CGC" || DNAnewborn[i + 1] == "CCG" || DNAnewborn[i + 1] == "GGG" || DNAnewborn[i + 1] == "CCC") & (DNAnewborn[i + 2] == "GCC" || DNAnewborn[i + 2] == "GGC" || DNAnewborn[i + 2] == "GCG" || DNAnewborn[i + 2] == "CGG" || DNAnewborn[i + 2] == "CGC" || DNAnewborn[i + 2] == "CCG" || DNAnewborn[i + 2] == "GGG" || DNAnewborn[i + 2] == "CCC"))
                            {
                                count17 += 3;
                                count27 = 0;
                                for (int j = i + 3; j < DNAnewborn.Length; j++)
                                {
                                    if (DNAnewborn[j] == "GCC" || DNAnewborn[j] == "GGC" || DNAnewborn[j] == "GCG" || DNAnewborn[j] == "CGG" || DNAnewborn[j] == "CGC" || DNAnewborn[j] == "CCG" || DNAnewborn[j] == "GGG" || DNAnewborn[j] == "CCC")
                                    {
                                        count27++;
                                        count17++;
                                    }
                                    else
                                    {
                                        
                                        break;
                                    }
                                }
                                i = i + 3 + count27;
                            }
                        }
                        double count3=0;
                        string[] aa17 = new string[] {"GCT","GCC","GCA","GCG","CGT","CGC","CGA","CGG","AGA","AGG","AAT","AAC","GAT","GAC","TGT","TGC","CAA","CAG","GAA","GAG","GGT","GGC","GGA","GGG",
                         "CAT","CAC","ATT","ATC","ATA","CTT","CTC","CTA","CTG","TTA","TTG","AAG","AAA","ATG","TTT","TTC","CCT","CCC","CCA","CCG","TCT","TCC","TCA","TCG","AGT","AGC","ACT","ACC","ACA","ACG","TGG","TAT","TAC","GTT","GTC","GTA","GTG","TAA","TGA","TAG"};
                        for(int i= 0; i < DNAnewborn.Length; i++)
                        {
                            for(int j=0;j<aa17.Length;j++)
                            {
                                if (DNAnewborn[i] == aa17[j])
                                {
                                    count3++;
                                }
                            }
                        }
                        if (DNAnewborn[1] == "GGG" || DNAnewborn[1] == "CCC")
                        {
                            gender1 = "Y";
                        }
                        else if(DNAnewborn[1]=="AAA"||DNAnewborn[1]=="TTT")
                        {
                            gender1 = "X";
                        }
                            
                        if (DNAnewborn[2] == "GGG" || DNAnewborn[2] == "CCC")
                        {
                            gender2 = "Y";
                        }
                        else if(DNAnewborn[2]=="AAA"||DNAnewborn[2]=="TTT")
                        {
                            gender2 = "X";
                        }
                        Console.Write("Blob 3 "+gender1+gender2+": ");
                        for(int iotuz=0;iotuz<DNAnewborn.Length;iotuz++)
                        {

                            if (DNAnewborn[iotuz] != null)
                            {
                                Console.Write(DNAnewborn[iotuz] + " ");
                            }


                        }

                        int counterdnanewborn = 0;
                        for (int i = 0; i < DNAnewborn.Length; i++)
                        {
                            if (DNAnewborn[i] != null)
                            {
                                counterdnanewborn=i;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("");
                        Console.Write("BLOB3 faulty codons ratio = ");
                        Console.Write(count17+"/"+count3+" = %");
                        Console.Write((count17 /count3) * 100);
                        Console.WriteLine("");
                        
                        if (((count17 /count3) * 100) > 10)
                        {
                            Console.WriteLine("The newborn died.");
                            break;
                        }
                        else
                        {
                             DNA17 = new string[DNAnewborn.Length];
                            
                            for (int jj = 0; jj < DNAnewborn.Length; jj++)
                            {
                                DNA17[jj] = DNAnewborn[jj];
                            }
                            
                        }
                        string[] dnatemp17 = new string[1];
                        for (int ii = 0; ii < DNA17.Length; ii++)
                        {
                            dnatemp17[0] = dnatemp17[0] + DNA17[ii];
                        }
                        dnacase17 = dnatemp17[0];
                        Console.WriteLine("");
                        Console.ReadKey();
                    }
                    break;
        
            }
    
            Console.WriteLine(" ");
            Console.WriteLine("Please Choose an Operation");
            Console.WriteLine("0 |---| 1 |---| 2 |---| 3 |---| 4 |---| 5");
            Console.WriteLine("6 |---| 7 |---| 8 |---| 9 |---| 10 |---| 11");
            Console.WriteLine("12 |---| 13 |---| 14 |---| 15 |---| 16 |---| 17 ");
            choose1 = Convert.ToInt32(Console.ReadLine());
        }

        if (choose == 0)
        {
            Console.WriteLine("Press any key to close the program...");
            Environment.Exit(0);
        }

        Console.ReadKey();
    }
}






