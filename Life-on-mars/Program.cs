using System.IO;

double choose;

Console.WriteLine("Welcome");
Console.WriteLine("Please Choose The Operation");
Console.WriteLine("1-Load File **** 2-Enter Dna String **** 3.1-Create Random Perfect Dna **** 3.2-Create Random Dna");
choose = Convert.ToDouble(Console.ReadLine());
string[] dnainput;
string[] dna = new string[1000];
int dnalngth = 0;
string[] randomdna = new string[5];
string gendername = " ";

switch (choose)
{
    case 1:
        Console.Clear();
        string filename;
        Console.WriteLine("Please enter the name of text file:");
        filename = (Console.ReadLine());
        dnainput = new string[]{ File.ReadAllText("/Users/hasanfurkanguney/Desktop/" + filename)} ;
        /*int modcontrol = dnainput.Length % 3;
       
            dna = new string[(dnainput.Length / 3)];
            int x1 = 0;

            while (x1 < (dnainput.Length / 3))
            {
                for (int i = 0; i <= dnainput.Length - 3; i = i + 3)
                {

                    dna[x1] = dnainput[i] + dnainput[i + 1] + dnainput[i + 2];
                    x1++;
                    Console.WriteLine(dna);

                }
            }
        */
        
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Please Enter the Dna String"); 
        dna = new string[]{Console.ReadLine()};
        Console.WriteLine(dna); 
        
        dnalngth = dna.Length;
        break;
    
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
} 

        Console.WriteLine("");
        Console.WriteLine("Please Choose a operation");
        Console.WriteLine("0 **** 1 **** 2 **** 3 **** 4 **** 5");
        Console.WriteLine("6 **** 7 **** 8 **** 9 **** 10 **** 11");
        Console.WriteLine("12 **** 13 **** 14 **** 15 **** 16 **** 17 ");
        int choose1 = Convert.ToInt32(Console.ReadLine());


while (choose1 != 0)
{
    switch (choose1)
    {
        case 1:
        Console.Clear();
        string filename;
        Console.WriteLine("Please enter the name of text file:");
        filename = (Console.ReadLine());
        dnainput = new string[]{ File.ReadAllText("/Users/hasanfurkanguney/Desktop/" + filename)} ;
        /*int modcontrol = dnainput.Length % 3;
       
            dna = new string[(dnainput.Length / 3)];
            int x1 = 0;

            while (x1 < (dnainput.Length / 3))
            {
                for (int i = 0; i <= dnainput.Length - 3; i = i + 3)
                {

                    dna[x1] = dnainput[i] + dnainput[i + 1] + dnainput[i + 2];
                    x1++;
                    Console.WriteLine(dna);

                }
            }
        */
        
        break;

        case 2:
             Console.Clear();
        Console.WriteLine("Please Enter the Dna String"); 
        dna = new string[]{Console.ReadLine()};
        Console.WriteLine(dna); 
        
        dnalngth = dna.Length;
        break;

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
                Console.WriteLine("BLOB is OK!");
            }

            break;
        
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
                Console.Write("Incompleted codons won't be shown.");
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

            string[] DNA = new string[20];
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
        
        case 8:
            Console.Clear();
            //deleting codons
            Console.WriteLine("Please enter the number of codons you want to delete:");
            int delcodon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of which codon do you want to start to delete: ");
            int delcodonth = Convert.ToInt32(Console.ReadLine());

            for (int d = delcodonth - 1; d < dna.Length; d++)
            {
                if (d + delcodon <= dna.Length - 1)
                {
                    dna[d] = dna[d + delcodon];
                    Console.WriteLine(dna[d]);
                }


            }

            break;
        
        case 9:
            Console.Clear();
            //inserting codons
            Console.WriteLine("Please enter the number of codons you want to insert:");
            int inscodon = Convert.ToInt32(Console.ReadLine());
            string[] insertcodon = new string[inscodon];
            for (int s = 0; s <= inscodon - 1; s++)
            {
                Console.WriteLine("Please enter one of the codons: ");
                insertcodon[s] = Console.ReadLine();
            }

            Console.WriteLine("Please enter the number of which codon do you want to start to insert: ");
            int inscodonth = Convert.ToInt32(Console.ReadLine());
            int ic = 0;
            while (ic <= inscodon)
            {
                for (int d = inscodonth - 1; d < dna.Length + inscodon; d++)
                {
                    if (d + inscodon <= dna.Length + inscodon)
                    {
                        dna[d + inscodon] = dna[d];
                        dna[d] = insertcodon[ic];
                    }

                    Console.Write(dna[d]);
                    ic++;
                }


            }

            break;
        
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
            string[] find1 = new string[dnacase10.Length/3];
                int step, qq1;
		    string ayrik1 = "", ayrik2="";

                Console.Write("What codon sequence are you looking for:");
                string ins = Console.ReadLine();

                Console.Write("Which codon do you want to start from: ");
                step = Convert.ToInt32(Console.ReadLine());
                qq1 = step;
                
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

                for (int p = 0; p < find1.Length; p++)
                {
                    find1 = ayrik1.Split();
                    
                    if ((ayrik2 == find1[p]))
                    {
                        Console.WriteLine("DNA strand: "+ayrik1);
                        Console.WriteLine("Codon sequence: "+ayrik2);
                        Console.WriteLine("Starting from: "+qq1);
                        Console.WriteLine("Result: "+(p+1));
                        break;
                    }
                    else if ((ayrik2 == find1[p]+" "+find1[p+1]) )
                    {
                        Console.WriteLine("DNA strand: "+ayrik1);
                        Console.WriteLine("Codon sequence: "+ayrik2);
                        Console.WriteLine("Starting from: "+qq1);
                        Console.WriteLine("Result: "+(p+1));
                        break;
                    }
                    else if ((ayrik2 == find1[p]+" "+find1[p+1]+" "+find1[p+2]) )
                    {
                        Console.WriteLine("DNA strand: "+ayrik1);
                        Console.WriteLine("Codon sequence: "+ayrik2);
                        Console.WriteLine("Starting from: "+qq1);
                        Console.WriteLine("Result: "+(p+1));
                        break;
                    }
                    else if ((ayrik2 == find1[p]+" "+find1[p+1]+" "+find1[p+2]+" "+find1[p+3]))
                    {
                        Console.WriteLine("DNA strand: "+ayrik1);
                        Console.WriteLine("Codon sequence: "+ayrik2);
                        Console.WriteLine("Starting from: "+qq1);
                        Console.WriteLine("Result: "+(step+1));
                        break;
                    }
                    else if ((ayrik2 == find1[p]+" "+find1[p+1]+" "+find1[p+2]+" "+find1[p+3]+" "+find1[p+4]) && (p==2))
                    {
                        Console.WriteLine("DNA strand: "+ayrik1);
                        Console.WriteLine("Codon sequence: "+ayrik2);
                        Console.WriteLine("Starting from: "+qq1);
                        Console.WriteLine("Result: "+(step+1));
                        break;
                    }
                    else if((ayrik2 == find1[p]+" "+find1[p+1]+" "+find1[p+2]+" "+find1[p+3]+" "+find1[p+4]+" "+find1[p+5])&& (p==1))
                    {
                        Console.WriteLine("DNA strand: "+ayrik1);
                        Console.WriteLine("Codon sequence: "+ayrik2);
                        Console.WriteLine("Starting from: "+qq1);
                        Console.WriteLine("Result: "+(step+1));
                        break;
                    }
                }
            break;

        case 15:
            Console.Clear();
            Console.WriteLine("Enter the number of nucletide: ");
            int nucletide = Convert.ToInt32(Console.ReadLine());
            repcounter = new string[] { "" };
            ss = 0;
            for (int i = 0; i < dna.Length; i++)
            {

                repcounter[0] = repcounter[0] + dna[i];
                Console.WriteLine(repcounter[0]);
                if (repcounter.Length == dna.Length)
                {
                    break;
                }
            }

            string repeatedletter = repcounter[0];
            string[] repeatedletterwithfrequencyarray = new string[repeatedletter.Length];
            char[] letterchararray = repeatedletter.ToCharArray();
            int
                q = 0;
            for (int i = 0; i < letterchararray.Length - 2; i++)
            {
                repeatedletterwithfrequencyarray[q] =
                    (letterchararray[i] + letterchararray[i + 1] + letterchararray[i + 2]).ToString();
                Console.WriteLine(repeatedletterwithfrequencyarray[q]);
                q++;
            }

            for (int i = 0; i < repeatedletterwithfrequencyarray.Length - 1; i++)
            {
                if (repeatedletterwithfrequencyarray[i] == repeatedletterwithfrequencyarray[i + 1])
                {

                }


            }


            break;
        
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
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("Please Choose a operation");
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







