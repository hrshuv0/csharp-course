using Classes;

Teacher teacher1 = new Teacher();
teacher1.age = 30;
teacher1.name = "Tareq";
teacher1.GenerateNewId();
Console.WriteLine("Count in Teacher 1: " + Teacher.count);

Teacher teacher2 = new Teacher();
teacher2.age = 40;
teacher2.name = "Jalaluddin";
teacher2.photoUrl = "http://image.jpg";
teacher2.GenerateNewId();
teacher2.GenerateNewId("2000");
teacher2.FirstName = "Tareq";
teacher2.LastName = "Ahmed";
string teacher2FullName = teacher2.FullName;
Console.WriteLine("Count in Teacher 2: " + Teacher.count);

Console.WriteLine(teacher1.age + teacher2.age);

Console.WriteLine(teacher1.Id);
Console.WriteLine(teacher2.Id);

teacher1.Id = "T-04028403240";
teacher1.DateOfBirth = new DateTime(1990, 2, 4);

Console.WriteLine(teacher1.Id);

Teacher teacher3 = new Teacher(30, "Name", "T-1000");
teacher3.FirstName = "Jalal";
teacher3.LastName = "Uddin";
string fullName = teacher3.FullName;
Console.WriteLine("Count in Teacher 3: " + Teacher.count);




