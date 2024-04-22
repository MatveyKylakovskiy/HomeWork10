using HomeWork8.SecondTask;

namespace HomeWork10.WorkerWithProducts
{
    public static class WorkerWithProducts
    {
        //First Task
        public static void GetListOfProducts(List<Product> products)
        {

            foreach (Product product in products)
            {
                product.GetInfo();
            }

            products[0].Price = 100;

            products.RemoveAt(products.Count - 1);

            Product[] productsArray1 = products.ToArray();
            Product[] productsArray2 = new Product[products.Count];
            Product[] productsArray3 = new Product[products.Count];

            for (int i = 0; i < products.Count; i++)
            {
                productsArray2[i] = products[i];
            }

            products.CopyTo(productsArray3);

            products.Clear();
        }

        //Second task
        public static void SortedSet(List<Product> products)
        {
            products.Sort();
        }

        //Third task
        public static void FindsExpensive(List<Product> products)
        {
            List<Product> expensiveList = new List<Product>();

            foreach (Product product in products)
            {
                if (product.Price > 300)
                {
                    expensiveList.Add(product);
                }
                product.GetInfo();
            }

            Console.WriteLine();

            foreach (Product product in expensiveList)
            {
                product.GetInfo();
            }

            Console.WriteLine("Min value");

            Product minValue = expensiveList[0];

            for (int i = 1; i < expensiveList.Count; i++)
            {
                if (minValue.Price > expensiveList[i].Price)
                {
                    minValue = expensiveList[i];
                }
            }
            minValue.GetInfo();

        }

        //Four task
        public static Dictionary<string, Product> Print1(List<Product> products)
        {
            Dictionary<string, Product> _products = new Dictionary<string, Product>();
            
            foreach (Product product in products)
            {
                _products.Add(product.Name, product);
            }

            foreach (var product in _products)
            {
                Console.WriteLine($"Name = {product.Key}, Price = {product.Value.Price}, Count = {product.Value.Quantity}");
            }
            return _products;
        }

        public static void Print2(Dictionary<string, Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name = {product.Key}");
            }

        }

        public static void Print3(Dictionary<string, Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Count = {product.Value.Quantity}");
            }

        }

        //Fifts task
        public static Dictionary<string, Product> ListToDictionary(List<Product> products)
        {
            Dictionary<string, Product> _products = new Dictionary<string, Product>();

            foreach (Product product in products)
            {
                _products.Add(product.Name, product);
            }

            return _products;
        }

        public static List<Product> DictionaryToKist(Dictionary<string, Product> products)
        {
            List<Product> _products = new List<Product>();
            foreach(var product in products)
            {
                _products.Add(product.Value);
            }
            return _products;
        }
    }
}



/*Задание 1:
а) Создать динамический массив, содержащий объекты класса Product
б) Распечатать его содержимое используя for each.
в) Изменить цену одного продукта на 100.
г) Удалить последний продукт.
е) Получить массив содержащий продукты из коллекции тремя способами и вывести на
консоль.
ж) Удалить все продукты.*/


/*
Задание 2:
Создать SortedSet содержащий объекты Product. Содержимое данной коллекции
распечатать с помощью for each.
*/

/*
Задание 3:
Создать коллекцию, содержащую объекты Product. Написать метод, который перебирает
элементы коллекции и проверяет цену продуктов. Если цена продукта больше 300
рублей, продукт перемещается в другую коллекцию.*/

/*Задание 4:
Создайте Dictionary, содержащий пары значений - имя продукта и количестов единиц
продукта (класс Product).
Перебрать и распечатать пары значений в формате "Name = abc, Price = 15, Count = 5"
Перебрать и распечатать набор из имен продуктов
Перебрать и распечатать значения количества единиц продуктов.
Для каждого перебора создать свой метод.*/

/*Задание 5:
На основе задания 4 необходимо написать преобразование Dictionary в List.
На основе задания 3 необходимо написать преобразование List в Dictionary.*/