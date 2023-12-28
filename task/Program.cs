
Shop shop = new Shop();
Phone phone1 = new Phone
{ 
    Name = "iPhone", Price = 1000, Model = "12"
};
Phone phone2 = new Phone 
{ 
Name = "Samsung", Price = 800, Model = "Galaxy S20" 
};
Car car1 = new Car 
{ 
Name = "Toyota", Price = 20000, Brand = "Camry" 
};
Car car2 = new Car 
{ 
Name = "BMW", Price = 40000, Brand = "X6" 
};
shop.AddProduct(phone1);
shop.AddProduct(phone2);
shop.AddProduct(car1);
shop.AddProduct(car2);
shop.PrintProductList();
shop.RemoveProduct(phone2);
System.Console.WriteLine("------------------------------ \n ***************************");
shop.PrintProductList();






