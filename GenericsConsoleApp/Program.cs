using System;
using GenericsConsoleApp;

//Table<int> Table1 = new Table<int>("yellow", 5);
//Console.WriteLine(Table1.NumOfLegs);

//Chair Chair1 = new Chair(5, 8);
//Console.WriteLine(Chair1.legsNums);


//List<int> list1 = new List<int>();
//list1.Add(1);
//list1.Add(2);
//list1.Add(3);
//list1.Add(4);
//Console.WriteLine(list1[1]);

//List<string> list= new List<string>();
//list.Add("haim");
//list.Add("hjfkj");
//list.Add("hlghj");
//list.Add("jkgljh");
//Console.WriteLine(list[2]);

//List<double> floatNums= new List<double>();
//floatNums.Add(2.5);
//floatNums.Add(3.5);
//floatNums.Add(4.5);

//double[] array = new double[]{2.3, 3.3, 4.3, 5.3};

//floatNums.AddRange(array);
//    Console.WriteLine(floatNums[3]);
//for(int i = 0; i < floatNums.Count; i++)
//{
//    Console.WriteLine(floatNums[i]);
//}


Furniture<int> furniture1 = new Furniture<int>(5, 6, 7);


List <Furniture<int>> furnitures = new List<Furniture <int>>();
furnitures.Add(new Furniture<int>(3,4,5));
furnitures.Add(new Furniture<int>(4,4, 5));
furnitures.Add(new Furniture<int>(5, 4, 5));
furnitures.Add(new Furniture<int>(6, 4, 5));

for(int i = 0; i < furnitures.Count; i++)
{
    Console.WriteLine(furnitures[i].ChairsNums +""+ furnitures[i].TablesNums +""+ furnitures[i].closets);
}

Furniture<int> furniture = new Furniture<int>(5, 6, 7);
furniture.size = new List<int>();
furniture.size.Add(3);
furniture.size.Add(4);
furniture.size.Add(5);
furniture.size.Add(6);
foreach (int item in furniture.size) 
{
    Console.WriteLine(furniture.size[item]);
}







