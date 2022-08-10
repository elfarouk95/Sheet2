using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    static class Data
    {
        static List<Category> categories = new List<Category>()
        {
            new Category() { Name = "cat1" ,Id =1 },
            new Category() { Name = "cat2" ,Id =2 },
            null,
            null,
            new Category() { Name = "cat3" ,Id =3 },
            null,
            new Category() { Name = "cat4" ,Id =4 },
            new Category() { Name = "cat5" ,Id =5 },
            new Category() { Name = "cat6" ,Id =6 },
        };



        static List<Product> products = new List<Product>()
        {
            new Product(){Id =1 , Name = "prod1" , price = 15 , qty = 23 , catId =1},
            new Product(){Id =2 , Name = "prod2" , price = 20 , qty = 32 , catId =1},
            new Product(){Id =3 , Name = "prod3" , price = 26 , qty = 33 , catId =1},
            new Product(){Id =4 , Name = "prod4" , price = 29 , qty = 34 , catId =1},
            new Product(){Id =5 , Name = "prod5" , price = 27 , qty = 35 , catId =1},
            new Product(){Id =6 , Name = "prod6" , price = 20 , qty = 863 , catId =2},
            new Product(){Id =7 , Name = "prod7" , price = 26 , qty = 93 , catId =2},
            new Product(){Id =8 , Name = "prod8" , price = 20 , qty = 387, catId =2},
            new Product(){Id =9 , Name = "prod9" , price = 26 , qty = 38 , catId =2},
            new Product(){Id =10 , Name = "prod10" , price = 27 , qty = 13 , catId =3},
            new Product(){Id =11 , Name = "prod11" , price = 33 , qty = 31 , catId =4},
            new Product(){Id =12 , Name = "prod12" , price = 26 , qty = 13 , catId =5},
               null,
            new Product(){Id =13 , Name = "prod13" , price = 10 , qty = 13 , catId =2},
            new Product(){Id =14 , Name = "prod14" , price = 12 , qty = 31 , catId =2},
               null,
                  null,
            new Product(){Id =15 , Name = "prod15" , price = 11 , qty = 31 , catId =1},
            new Product(){Id =16 , Name = "prod16" , price = 17 , qty = 13 , catId =4},
            new Product(){Id =17 , Name = "prod17" , price = 78 , qty = 13 , catId =1},
            null,
            null,
            null,
            null,
            new Product(){Id =18 , Name = "prod18" , price = 79 , qty = 13 , catId =3},
            new Product(){Id =19 , Name = "prod19" , price = 23 , qty = 31, catId =6},
            new Product(){Id =20 , Name = "prod20" , price = 210 , qty = 13 , catId =1},
            new Product(){Id =21 , Name = "prod21" , price = 20 , qty = 13 , catId =4},
            new Product(){Id =22 , Name = "prod22" , price = 21 , qty = 31 , catId =3},
            new Product(){Id =23 , Name = "prod23" , price = 18 , qty = 13 , catId =2},
            new Product(){Id =24 , Name = "prod24" , price = 16 , qty = 13 , catId =5},
            new Product(){Id =25 , Name = "prod25" , price = 14 , qty = 131 , catId =3},
            new Product(){Id =26 , Name = "prod26" , price = 15 , qty = 31 , catId =2},
            new Product(){Id =27 , Name = "prod27" , price = 16 , qty = 13 , catId =5},
            new Product(){Id =28 , Name = "prod28" , price = 18 , qty = 13 , catId =1},
        };


        static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 1, Name = "customer1" , Age = 20},
            null,
            null,
            null,
            new Customer() {Id = 2, Name = "customer2" , Age = 15},
            new Customer() {Id = 3, Name = "customer3" , Age = 24},
            new Customer() {Id = 4, Name = "customer4" , Age = 54},
            null,
            null,
            new Customer() {Id = 5, Name = "customer5" , Age = 25},
            new Customer() {Id = 6, Name = "customer6" , Age = 43}
        };


        static List<Order> orders = new List<Order>()
        {
               new Order() {Id = 1 , CustomerId = 1, ProductId = 23 , TotalPrice = 36 , TotalQty = 2},
               new Order() {Id = 1 , CustomerId = 2, ProductId = 1 , TotalPrice = 60 , TotalQty = 4},
               new Order() {Id = 1 , CustomerId = 3, ProductId = 4 , TotalPrice = 29 , TotalQty = 1},
               new Order() {Id = 1 , CustomerId = 4, ProductId = 13 , TotalPrice = 50 , TotalQty = 5},
               null,
               null,
               new Order() {Id = 1 , CustomerId = 5, ProductId = 21 , TotalPrice = 147 , TotalQty = 7},
                 null,
               null,
               new Order() {Id = 1 , CustomerId = 2, ProductId = 25 , TotalPrice = 262 , TotalQty = 2},
               new Order() {Id = 1 , CustomerId = 6, ProductId = 14 , TotalPrice = 48 , TotalQty = 4},
               new Order() {Id = 1 , CustomerId = 3, ProductId = 13 , TotalPrice = 30 , TotalQty = 3},
               new Order() {Id = 1 , CustomerId = 4, ProductId = 1 , TotalPrice = 105 , TotalQty = 7},
               null,
               null,
               null,
               null,
               new Order() {Id = 1 , CustomerId = 2, ProductId = 23 , TotalPrice = 144 , TotalQty = 8},
               null,
               null,
               null,
               null,
               new Order() {Id = 1 , CustomerId = 3, ProductId = 9 , TotalPrice = 234 , TotalQty = 9},
               new Order() {Id = 1 , CustomerId = 1, ProductId = 6 , TotalPrice = 20 , TotalQty = 1},
               null,
               null,
               new Order() {Id = 1 , CustomerId = 1, ProductId = 1 , TotalPrice = 180 , TotalQty = 12},
        };



    }
}
