﻿using System.ComponentModel.DataAnnotations;

namespace WebStoreElementLogic.Entities
{
    public class Product
    {
        public string? Name { get; set; }
        public string? Descr { get; set; }
        public int Id { get; set; }
        [Key]
        public string? URL { get; set; }
        public decimal Qty { get; set; }

        public Product(int number)
        {
            Name = "Product " + (1 + number);
        }

        public Product()
        {
            Name = "";
            Descr = "";
            Id = 0;
            URL = "";
        }



        public Product(string? name, string? descr, int id, string url, decimal qty)

        {
            Name = name;
            Descr = descr;
            Id = id;
            URL = url;
            Qty = qty;

        }

        public static List<Product> generateList(int size)
        {
            List<Product> infoList = new List<Product>();

            for (int j = 0; j < size; j++)
            {
                infoList.Add(new Product(j));
            }

            return infoList;
        }

        public object Clone()
        {

            return new Product(Name, Descr, Id, URL, Qty);

        }

        public static void Change(Product changed, Product changer)
        {
            changed.Name = changer.Name;
            changed.Descr = changer.Descr;
            changed.Id = changer.Id;
            changed.URL = changer.URL;
        }
    }
}
