using HomeWork10.Second_Task;
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
var goods1 = new Goods("beer", 4, new DateTime(2024, 04, 10), 90);
var goods2 = new Goods("potato", 0.15, new DateTime(2024, 02, 10), 300);

var batch = new Batch(goods, 4);
var batch1 = new Batch(goods1, 7);
var batch2 = new Batch(goods2, 1000);


List<Product> prods = new List<Product> { goods, goods1, goods2, batch, batch1, batch2 };

WorkerWithProducts.FirstTask(prods);

