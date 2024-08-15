
using _12_EducationDB.Context;
using _12_EducationDB.Entities;
EducationDbContext context = new EducationDbContext();
using (context=new EducationDbContext())
{
    //1.addım student oluşur.
    Student student = new Student();    
    context.Students.Add(student);


    //Student Update
    context.Students.Where(student => student.Name == "Bilge");
    Student? updateStudent = context.Students.FirstOrDefault(student => student.Name == "Bige");
    updateStudent.Name = "Adam";


    //School Create
    School school = new School();
    context.Schools.Add(school);

    //Departmant Create
    Department department = new Department() { Name = "Eğitim" };
    context.Departments.Add(department);
    //Losson Create
    Lesson lesson = new Lesson() {  Name ="EF Code firs",Department = department };
    context.Lessons.Add(lesson);

    updateStudent.Lessons.Add(lesson);  
    updateStudent.School = school;  


  int success=  context.SaveChanges();

    Console.WriteLine(success > 0 ? "İşlem başarılı" : "İşlem başarısız");
}
