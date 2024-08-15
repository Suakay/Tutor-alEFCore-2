using _01_DatabaseFirstCore.Models;
using System.Security.Cryptography.X509Certificates;

using _01_DatabaseFirstCore;


NorthwindContext db = new NorthwindContext();


//List<Product> ürünler = db.Products.Tolist();

//foreach (Product ürün in ürünler)
//{
//Console.WriteLine(ürün.ProductName)
//}


//Database üzerinden veri çektik:
//db.Products

//.Where(x => x.CategoryId ==2)
//.OrderBy(x => x.ProductName)
//.ToList()
//.ForEach(p => Console.WriteLine(p.ProductName));


Select();//Select metodunu çalıştırır.
//add();
//Update();
//Remove();
static void Select()
{
    using (NorthwindContext db = new NorthwindContext())
    {
        List<Employee> employees = db.Employees.ToList();  //Emplyee listesini çek ve listeye yaz

        foreach (var emp in employees) //Döngüyle herbirini yazdır.
        {
            Console.WriteLine($"Id: {emp.EmployeeId}\nName: {emp.FirstName}\nLast Name: {emp.LastName}");
        }
    }
}

//VERİ EKLEME:
//Context nesnesi oluşturuyoruz:
static void add()
{
    using (NorthwindContext db = new NorthwindContext())
    {

        //Veritabanına ekleyeceğimiz nesneyi oluşturuyoruz:
        Employee newEmployee = new Employee();

        //Nesne özelliklerini belirtiyoruz.
        newEmployee.FirstName = "İbrahim";
        newEmployee.LastName = "Deniz";

        //Contxt nesnesine veritabanına ekleyeceğimiz nesneyi ekliyoruz.
        db.Employees.Add(newEmployee);

        //Veritabanında gerçekleşmesini istediğimiz değişiklikleri kaydediyoruz.
        db.SaveChanges();//Değişiklikleri harddiske kaydet ve ekle!!!!!!

        //tekrardan ekrana veritabanındaki employee nesnelerini getirmek için kullanıldı.
        Select();
    }
}


//insert, update,delete işlemlerini buraya yazabilirsinizSavechanges ile tüm işlemler veritabanında gerçekleşir.


static void Update()
{
    using (var db = new NorthwindContext())
    {
        Employee emp = db.Employees.First(x => x.FirstName == "İbrahim" && x.LastName == "Deniz");
        //Employee emp = db.Employees.FirstOrDefault(x => x.FirstName == "İbrahim" && x.LastName == "Deniz"); //First
        if (emp is not null)
        {
            emp.LastName = "DENİZ";
            emp.TitleOfCourtesy = "Mr.";
            emp.Title = "Sales Manager";

            db.SaveChanges();

        }
        else
            Console.WriteLine("Değer Null olamaz!");

        Select();
    }
}


static void Remove()
{
    using (NorthwindContext db = new NorthwindContext())
    {
        Employee removeEmployee = db.Employees.First(x => x.FirstName == "İbrahim" && x.LastName == "Deniz");
        db.Employees.Remove(removeEmployee);
        db.SaveChanges();
        Select();

    }
}



/*
 * Northwind db yi DBFirst ile çekin.Model gelsin
 * Category Ekleme sayfasını tasarlayın.Listboxta sıralayın.
 * Ekleme yapın
 * Güncelleme yapın
 * Silme yapın
 * Listeleyin, ListView
 */


