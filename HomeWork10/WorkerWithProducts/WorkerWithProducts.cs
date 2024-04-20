using HomeWork8.SecondTask;
using System.Xml.Linq;
using System;

namespace HomeWork10.Second_Task
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