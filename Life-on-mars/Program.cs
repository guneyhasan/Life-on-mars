using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        double choose;

        Console.WriteLine("Welcome");
        Console.WriteLine("Please Choose The Operation");
        Console.WriteLine("1-Load File **** 2-Enter Dna String **** 3-Create a Random Dna");
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
                Console.WriteLine("Please enter the name of text file:");
                filename = (Console.ReadLine());
                dnainput =  File.ReadAllText("/Users/hasanfurkanguney/Desktop/" + filename) ;
                int modcontrol = dnainput.Length % 3;
                dna = new string[150];
                int x1 = 0;
        
        
                for (int i = 0; i <= dnainput.Length -3 ; i = i + 3)
                {

                    dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                    x1++;
                    

                }

                for (int i = 0; i < dna.Length; i++)
                {
                    Console.Write(dna[i]+" ");
            
                }

                break;
    
            //input dna 
            case 2:
                Console.Clear();
                Console.WriteLine("Please Enter the Dna String"); 
                dnainput = Console.ReadLine();
                int dnainputmod = dnainput.Length % 3;
                dnalngth = dna.Length;
                x1 = 0;
                if (dnainputmod == 0)
                {
                    for (int i = 0; i < dnainput.Length - 2; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;


                    }

                    for (int i = 0; i < dna.Length; i++)
                    {
                        Console.Write(dna[i] + " ");

                    }
                }
                else if(dnainputmod==2)
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
                
                else if (dnainputmod == 1)
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

                        randomdna = new string[blob + 1];
                        for (int i = 0; i <= blob; i++)
                        {
                            int b = rndmdna.Next(0, 4);
                            randomdna[i] = words[b];


                        }

                        string[] splitteddna = new string[(blob / 3)];
                        int x = 0;

                        while (x < (blob / 3))
                        {
                            for (int i = 0; i <= blob - 3; i = i + 3)
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
                                gendername = "Female";
                                break;
                            case 1:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "AAA";
                                gender[3] = "TAG";
                                gendername = "Female";
                                break;
                            case 2:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "TTT";
                                gender[3] = "TAG";
                                gendername = "Female";
                                break;
                            case 3:
                                gender[0] = "ATG";
                                gender[1] = "TTT";
                                gender[2] = "CCC";
                                gender[3] = "TAG";
                                gendername = "Male";
                                break;
                            case 4:
                                gender[0] = "ATG";
                                gender[1] = "GGG";
                                gender[2] = "AAA";
                                gender[3] = "TAG";
                                gendername = "Male";
                                break;
                            case 5:
                                gender[0] = "ATG";
                                gender[1] = "GGG";
                                gender[2] = "TTT";
                                gender[3] = "TAG";
                                gendername = "Male";
                                break;
                        }


                        dna = new String [1000];
                        //gender to main array
                        for (int qqq = 0; qqq <= 3; qqq++)
                        {
                            dna[qqq] = gender[qqq];
                            Console.Write(dna[qqq]+ " ");
                        }

                        Console.WriteLine(gendername);

                        string[] stopcodon = new string[] { "TAA", "TGA", "TAG" };
                        int qq = 0;


                        //main array with start and stop codons
                        for (int q1 = 4; q1 <splitteddna.Length+4+(2*agen) ; q1++)
                        {
            
            

                            if (q1 == 4 || q1 == 4 + acodon + 1 || q1 == 4 + 2 * acodon + 2 || q1 == 4 + 3 * acodon + 3 ||
                                q1 == 4 + 4 * acodon + 4 || q1 == 4 + 5 * acodon + 5 || q1 == 4 + 6 * acodon + 6 )
                            {
                                dna[q1] = "ATG";
                                Console.Write(dna[q1]+ " ");
                            }

                            else if (q1 == 4 + acodon || q1 == 4 + 2 * acodon + 1 || q1 == 4 + 3 * acodon + 2 ||
                                     q1 == 4 + 4 * acodon + 3 || q1 == 4 + 5 * acodon + 4 || q1 == 4 + 6 * acodon + 5 ||
                                     q1 == 4 + 7 * acodon + 6)
                            {
                                int cdnrndm = rndmdna.Next(0, 3);
                                dna[q1] = stopcodon[cdnrndm];
                                Console.Write(dna[q1]+" ");

                            }
                            else if (qq < splitteddna.Length)
                            {

                                if (splitteddna[qq] != " ")
                                {
                                    dna[q1] = splitteddna[qq];
                                    Console.Write(dna[q1] + " ");
                                    qq++;
                                }

                            }



               
            

                        }

                        break;
                    case 2 :
                        rndmdna = new Random(); 
                    
                        //dna random
                    
                        words = new string[]{ "A", "T", "G", "C" };
                        agen = rndmdna.Next(2, 8); 
                        acodon = rndmdna.Next(3, 9);
                        for (int i = 0; i < agen * acodon; i++)
                        {
                            int letterrandom = rndmdna.Next(0, 3);
                            dna[i] = words[letterrandom];
                        }
                        break;
                }
                break;
    
        }

        Console.WriteLine(""); 
        Console.WriteLine("Please Choose an Operation"); 
        Console.WriteLine("0 **** 1 **** 2 **** 3 **** 4 **** 5"); 
        Console.WriteLine("6 **** 7 **** 8 **** 9 **** 10 **** 11"); 
        Console.WriteLine("12 **** 13 **** 14 **** 15 **** 16 **** 17 "); 
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
                    Console.WriteLine("Please enter the name of text file:");
                    filename = (Console.ReadLine());
                    dnainput =  File.ReadAllText("/Users/hasanfurkanguney/Desktop/" + filename) ;
                    int modcontrol = dnainput.Length % 3;
                    dna = new string[150];
                    int x1 = 0;
        
        
                    for (int i = 0; i <= dnainput.Length -3 ; i = i + 3)
                    {

                        dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                        x1++;
                    

                    }

                    for (int i = 0; i < dna.Length; i++)
                    {
                        Console.Write(dna[i]+" ");
            
                    }

                    break;
        
                //input dna
                case 2:
                    Console.Clear();
                    Console.WriteLine("Please Enter the Dna String"); 
                    dnainput = Console.ReadLine();
                    int dnainputmod = dnainput.Length % 3;
                    dnalngth = dna.Length;
                    x1 = 0;
                    if (dnainputmod == 0)
                    {
                        for (int i = 0; i <= dnainput.Length - 3; i = i + 3)
                        {

                            dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                            x1++;


                        }

                        for (int i = 0; i < dna.Length; i++)
                        {
                            Console.Write(dna[i] + " ");

                        }
                    }
                    else if(dnainputmod==2)
                    {
                        for (int i = 0; i< dnainput.Length-3 ; i = i + 3)
                        {

                            dna[x1] = dnainput[i].ToString() + dnainput[i + 1].ToString() + dnainput[i + 2].ToString();
                            x1++;


                        }

                        for (int i = 0; i < dna.Length; i++)
                        {
                            Console.Write(dna[i] + " ");

                        }
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

                            randomdna = new string[blob + 1];
                            for (int i = 0; i <= blob; i++)
                            {
                                int b = rndmdna.Next(0, 4);
                                randomdna[i] = words[b];


                            }

                            string[] splitteddna = new string[(blob / 3)];
                            int x = 0;

                            while (x < (blob / 3))
                            {
                                for (int i = 0; i <= blob - 3; i = i + 3)
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
                                    gendername = "Female";
                                    break;
                                case 1:
                                    gender[0] = "ATG";
                                    gender[1] = "TTT";
                                    gender[2] = "AAA";
                                    gender[3] = "TAG";
                                    gendername = "Female";
                                    break;
                                case 2:
                                    gender[0] = "ATG";
                                    gender[1] = "TTT";
                                    gender[2] = "TTT";
                                    gender[3] = "TAG";
                                    gendername = "Female";
                                    break;
                                case 3:
                                    gender[0] = "ATG";
                                    gender[1] = "TTT";
                                    gender[2] = "CCC";
                                    gender[3] = "TAG";
                                    gendername = "Male";
                                    break;
                                case 4:
                                    gender[0] = "ATG";
                                    gender[1] = "GGG";
                                    gender[2] = "AAA";
                                    gender[3] = "TAG";
                                    gendername = "Male";
                                    break;
                                case 5:
                                    gender[0] = "ATG";
                                    gender[1] = "GGG";
                                    gender[2] = "TTT";
                                    gender[3] = "TAG";
                                    gendername = "Male";
                                    break;
                            }


                            dna = new String [1000];
                            //gender to main array
                            for (int qqq = 0; qqq <= 3; qqq++)
                            {
                                dna[qqq] = gender[qqq];
                                Console.WriteLine(dna[qqq]);
                            }

                            Console.WriteLine(gendername);

                            string[] stopcodon = new string[] { "TAA", "TGA", "TAG" };
                            int qq = 0;


                            //main array with start and stop codons
                            for (int q1 = 5; q1 <= splitteddna.Length+5+(2*agen) ; q1++)
                            {
            
                                {
                

                                    if (q1 == 5 || q1 == 5 + acodon + 1 || q1 == 5 + 2 * acodon + 2 || q1 == 5 + 3 * acodon + 3 ||
                                        q1 == 5 + 4 * acodon + 4 || q1 == 5 + 5 * acodon + 5 || q1 == 5 + 6 * acodon + 6 )
                                    {
                                        dna[q1] = "ATG";



                                    }

                                    else if (q1 == 5 + acodon || q1 == 5 + 2 * acodon + 1 || q1 == 5 + 3 * acodon + 2 ||
                                             q1 == 5 + 4 * acodon + 3 || q1 == 5 + 5 * acodon + 4 || q1 == 5 + 6 * acodon + 5 ||
                                             q1 == 5 + 7 * acodon + 6)
                                    {
                                        int cdnrndm = rndmdna.Next(0, 3);
                                        dna[q1] = stopcodon[cdnrndm];

                                    }
                                    else if (qq <= splitteddna.Length-1)
                                    {
                    
                    
                                        dna[q1] = splitteddna[qq];
                                        qq++;
                 
                                    }



                                    /*for (int i = 0; i < dna.Length; i++)
                {
                    Console.Write(dna[i] + " ");
                }*/
                                }

                            }

                            break;
                        case 2 :
                            rndmdna = new Random(); 
                    
                            //dna random
                    
                            words = new string[]{ "A", "T", "G", "C" };
                            agen = rndmdna.Next(2, 8); 
                            acodon = rndmdna.Next(3, 9);
                            for (int i = 0; i < agen * acodon; i++)
                            {
                                int letterrandom = rndmdna.Next(0, 3);
                                dna[i] = words[letterrandom];
                            }
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
                        Console.Write("Incompleted codons won't be shown.");
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


                    bool tester3 = true, tester4 = true, tester5 = true;
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
                        Console.WriteLine("Gene structure error!");
                        tester4 = false;
                    }

                    for (int i = 0; i < numberofcodons1; i++)
                    {
                        if (DNA1[i] == "ATG" && tester3 == true && tester4 == true)
                        {
                            if (DNA1[i + 1] == "TGA" || DNA1[i + 1] == "TAG" || DNA1[i + 1] == "TAA")
                            {
                                Console.WriteLine("NOT BLOB,but OK!");
                                tester5 = false;
                            }
                        }
                    }


                    if (tester3 == true && tester4 == true && tester5 == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Gene Structure is OK!");
                    }

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

                    string[] DNA2 = new string[100];

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

                    if (dnacase5.Length % 3 != 0)
                    {
                        Console.WriteLine("Incompleted codons won't be shown.");
                    }

                    bool tester = true;
                    bool tester1 = true;
                    bool tester2 = true;
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
                                Console.WriteLine("Number of codons error.");
                                tester = false;
                            }

                        }
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

                    if (tester == true && tester1 == true && tester2 == true)
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
                    Console.WriteLine(dnacase6);

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

                    for (int j = 0; j < numberofcodons; j++)
                    {
                        Console.Write(DNA[j] + " ");
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
                    char[] dna3 = new char[dnacase7.Length];

                    for (int i = 0; i < dnacase7.Length; i++)
                    {
                        dna3[i] = dnacase7[i];
                    }

                    string[] DNA5 = new string[110];
                    char a2, b2, c2;
                    int i111 = 0, i222 = 1, i333 = 2;
                    int numberofcodons11 = dna3.Length / 3;
                    for (int i = 0; i < numberofcodons11; i++)
                    {
                        a2 = dna3[i111];
                        b2 = dna3[i222];
                        c2 = dna3[i333];
                        DNA5[i] = a2 + "" + b2 + "" + c2 + "";
                        i111 += 3;
                        i222 += 3;
                        i333 += 3;
                    }

                    Console.WriteLine(dnacase7);
                    for (int j = 0; j < numberofcodons11; j++)
                    {
                        string k = DNA5[j];
                        if (k == "GCT" || k == "GCC" || k == "GCA" || k == "GCG")
                        {
                            Console.Write("Ala ");
                        }
                        else if (k == "CGT" || k == "CGC" || k == "CGA" || k == "CGG" || k == "AGA" || k == "AGG")
                        {
                            Console.Write("Arg ");
                        }
                        else if (k == "AAT" || k == "AAC")
                        {
                            Console.Write("Asn ");
                        }
                        else if (k == "GAT" || k == "GAC")
                        {
                            Console.Write("Asp ");
                        }
                        else if (k == "TGT" || k == "TGC")
                        {
                            Console.Write("Cys ");
                        }
                        else if (k == "CAA" || k == "CAG")
                        {
                            Console.Write("Gln ");
                        }
                        else if (k == "GAA" || k == "GAG")
                        {
                            Console.Write("Glu ");
                        }
                        else if (k == "GGT" || k == "GGC" || k == "GGA" || k == "GGG")
                        {
                            Console.Write("Gly ");
                        }
                        else if (k == "CAT" || k == "CAC")
                        {
                            Console.Write("His ");
                        }
                        else if (k == "ATT" || k == "ATC" || k == "ATA")
                        {
                            Console.Write("Ile ");
                        }
                        else if (k == "CTT" || k == "CTC" || k == "CTA" || k == "CTG" || k == "TTA" || k == "TTG")
                        {
                            Console.Write("Leu ");
                        }
                        else if (k == "AAA" || k == "AAG")
                        {
                            Console.Write("Lys ");
                        }
                        else if (k == "ATG")
                        {
                            Console.Write("Met ");
                        }
                        else if (k == "TTT" || k == "TTC")
                        {
                            Console.Write("Phe ");
                        }
                        else if (k == "CCT" || k == "CCC" || k == "CCA" || k == "CCG")
                        {
                            Console.Write("Pro ");
                        }
                        else if (k == "TCT" || k == "TCC" | k == "TCA" || k == "TCG" || k == "AGT" || k == "AGC")
                        {
                            Console.Write("Ser ");
                        }
                        else if (k == "ACT" || k == "ACC" || k == "ACA" || k == "ACG")
                        {
                            Console.Write("Thr ");
                        }
                        else if (k == "TGG")
                        {
                            Console.Write("Trp ");
                        }
                        else if (k == "TAT" || k == "TAC")
                        {
                            Console.Write("Tyr ");
                        }
                        else if (k == "GTT" || k == "GTC" || k == "GTA" || k == "GTG")
                        {
                            Console.Write("Val ");
                        }
                        else if (k == "TAA" || k == "TGA" || k == "TAG")
                        {
                            Console.Write("End ");
                        }
                    }

                    break;
        
                //delete codons
                case 8:
                    Console.Clear();
                    //deleting codons
                    Console.WriteLine("Please enter the number of codons you want to delete:");
                    int delcodon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the number of which codon do you want to start to delete: ");
                    int delcodonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.Write("The Original DNA:"+ " ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                      if(dna[i]!=null)   Console.Write(dna[i]+ " ");
                    }
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
            
                    Console.Write("The original DNA:"+ " ");
                    for (int i = 0; i < dna.Length; i++)
                    {
                       if(dna[i]!=null) Console.Write(dna[i]+ " ");
                    }
                    Console.SetCursorPosition(0,6);
            
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
                    char[] dna55=dnacase13.ToCharArray();
                    string[] DNA13 = new string[20];
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
                    string[] dna31 = new string[20];
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
                            c15 = c14;
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
                
                    Console.WriteLine("The original DNA Strand:"+" "+ayrik1);
                    Console.WriteLine("Longest gene: "+ayrik3);
                    Console.WriteLine("Number of codons in the gene: "+maxnum);
                    Console.WriteLine("Position of the gene: "+(c15-1));
            
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

                    for (int i = 0; i < dnacase15control.Length; i++)
                    {
                     if(dnacase15control[i]!=null)  Console.Write(dnacase15control[i]+" ");
                    }

                    int counter = 0;
                    for (int i = 0; i < dnacase15control.Length - 1; i = i + 2)
                    {
                        if (dnacase15control[i] != null&&dnacase15control[i+1]!=null)
                        {
                            if (dnacase15control[i] == dnacase15control[i + 1])
                            {
                                counter++;
                            }
                        }
                    }
                    Console.WriteLine(counter);


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

                    Console.WriteLine(dnacase16);
                    Console.WriteLine("Number of pairing with 2-hydrogen bonds:" + (countA + countT));
                    Console.WriteLine("Number of pairing with 3-hydrogen bonds:" + (countG + countC));
                    Console.WriteLine("Number of hydrogen bonds:" + (hydrogena + hydrogent + hydrogenc + hydrogeng));




                    break;
        
            }
    
            Console.WriteLine(" ");
            Console.WriteLine("Please Choose an Operation");
            Console.WriteLine("0 **** 1 **** 2 **** 3 **** 4 **** 5");
            Console.WriteLine("6 **** 7 **** 8 **** 9 **** 10 **** 11");
            Console.WriteLine("12 **** 13 **** 14 **** 15 **** 16 **** 17 ");
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







