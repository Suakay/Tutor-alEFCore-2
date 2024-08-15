// See https://aka.ms/new-console-template for more information
using _11_DataAnnotionFluentAPI.Context;
using _11_DataAnnotionFluentAPI.Model;

Console.WriteLine("Hello, World!");

using(AppDbContext context = new AppDbContext())
{
    Contact contact = new Contact();
    contact.FirstName = "Ali";
    contact.LastName = "Veli";
    contact.Email = "SDKFF";
    contact.LastAccesed= DateTime.Now;  
    contact.Created= DateTime.Now;
    context.Contacts.Add(contact);
    context.SaveChanges();

}