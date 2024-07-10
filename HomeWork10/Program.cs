using HomeWork10.WorkerWithProducts;
using HomeWork10.ZeroTask;
using HomeWork8.SecondTask;
/*
//Zero Task 1
try
{
    ZeroTask.PointOne();
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.GetType());
}

//Zero Task 2
ZeroTask.PointTwo();

//Zero Task 3
ZeroTask.PointThree();
*/


//First Task

var goods = new Goods("bread", 2, new DateTime(2024, 04, 10), 3);
var goods1 = new Goods("beer", 500, new DateTime(2024, 04, 10), 90);
var goods2 = new Goods("aa", 1000, new DateTime(2024, 02, 10), 300);
var goods3 = new Goods("ss", 1000, new DateTime(2024, 02, 10), 300);
var goods4 = new Goods("dd", 222, new DateTime(2024, 02, 10), 300);
var goods5 = new Goods("gg", 500, new DateTime(2024, 02, 10), 300);
var goods6 = new Goods("pd", 0.15, new DateTime(2024, 02, 10), 300);
var goods7 = new Goods("bb", 0.15, new DateTime(2024, 02, 10), 300);

var batch = new Batch(goods, 1);
var batch1 = new Batch(goods1, 56);
var batch2 = new Batch(goods2, 4);
var batch3 = new Batch(goods3, 1);
var batch4 = new Batch(goods4, 45);
var batch5 = new Batch(goods5, 6);
var batch6 = new Batch(goods6, 71);
var batch7 = new Batch(goods7, 1);


List<Product> prods = new List<Product> {batch, batch1, batch2, batch3, batch4, batch5, batch6, batch7 };

//First Task
//WorkerWithProducts.GetListOfProducts(prods);

//Second Task 

/*try
{
    foreach (var product in prods)
    {
        product.GetInfo();
    }

    Console.WriteLine();

    WorkerWithProducts.SortedSet(prods);

    foreach (var product in prods)
    {
        product.GetInfo();
    }
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}*/

//Third task

//WorkerWithProducts.FindsExpensive(prods);

//Fourts task
try
{
    Dictionary<string, Product> products =  WorkerWithProducts.Print1(prods);
    WorkerWithProducts.Print2(products);
    WorkerWithProducts.Print3(products);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);  
}


