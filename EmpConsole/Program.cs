// See https://aka.ms/new-console-template for more information
using emplib;

        Console.WriteLine("Hello, World!\n Check out Employee details\n");

        person John = new person();
        John.Name = "Joey Mathew";
        Console.WriteLine(John.eat());
        Console.WriteLine("\n");

        person Ritchel = new person();
        Ritchel.Name = "Ritchel Benn";
        Console.WriteLine(Ritchel.work());
        Console.WriteLine("\n");

        person lekha = new employee();
        lekha.Name = "Lekha ";
        Console.WriteLine(lekha.sleep());
        Console.WriteLine("\n");

        //format - base = new Derived();
        person rushab = new employee() { Designation = "Intern", DOJ = DateTime.Now.AddMonths(-1) };
        rushab.Name = "Rushab K";
        Console.WriteLine(rushab.work());
        Console.WriteLine($"EmpID for {rushab.Name}is{(employee)rushab}.EmpID}}");
        Console.WriteLine(((employee)rushab).Designation = "Analyst");
        Console.WriteLine(((employee)rushab).AttendTraining("C-2-C\n"));

        person ateeq = new employee() {  Designation = "full time", DOJ = DateTime.Now.AddMonths(-1) };
        ateeq.Name = "Ateeq";
        Console.WriteLine(ateeq.eat());
        Console.WriteLine(((employee)ateeq).Designation = "Tax Analyst");
        Console.WriteLine(((employee)ateeq).AttendTraining("C-2-C\n"));

//polymorphism

father sharmaisfather = new father();
Console.WriteLine($"Sharma ji's Father : {sharmaisfather.settle()}");
Console.WriteLine($"sharma ji's father getting married:{sharmaisfather.getmarried()}");
Console.WriteLine($"Fathers concept of drawing :{sharmaisfather.drawing()}");
Console.WriteLine("\n");

father sharmaji = new child();
Console.WriteLine($"Sharma ji:{sharmaji.settle()}");
Console.WriteLine($"sharma ji gets married  :{sharmaji.getmarried()}");
Console.WriteLine($"Fathers concept of drawing :{sharmaisfather.whatisdating()}");
Console.WriteLine("\n");

father sharmajiv2 = new child();
Console.WriteLine($"Sharma ji v2 gets married : {((child)sharmajiv2).getmarried()}");
Console.WriteLine("\n");

employee vidyasagar = new employee();
vidyasagar.Name = "Vidya Sagar";
vidyasagar.Designation = "security system Analyst";
Console.WriteLine(vidyasagar.work());
Console.WriteLine(vidyasagar.work("solving bugs"));
Console.WriteLine("\n");

employee srikar = new employee();
srikar.Name = "Shrikar K";
srikar.Designation = "Tax Analyst";
srikar.settaxinfo("I'm Eligible in the 20% tax payer category");
Console.WriteLine(srikar.gettaxinfo());
Console.WriteLine("\n");


//Test for calling one constructor from another
person ateeq1= new person("585137697437","+01-8105142491");
//this constructor should call the constructor that sets adhaar number
Console.WriteLine ($"Aadhaar : {ateeq1.Aadhaar} | phone : {ateeq1.Phone}");
Console.WriteLine("\n");

employee ritchel = new employee("837277361393", "+91 8348368933");
Console.WriteLine ($"Aadhaar : {ritchel.Aadhaar} | phone : {ritchel.Phone}");
Console.WriteLine($"Employee ID : {ritchel.EmpID}");
Console.WriteLine("\n");

Console.WriteLine($"Total Employee count: {emputils.empcount}");

//Adding employees to a temporary DB using static list <employee>emp
emputils.empdb.Add(ritchel);
emputils.empdb.Add(srikar);
emputils.empdb.Add(new employee("836573847382", "+91 8105142491") { Name = "nidha", Designation = "data analyst", salary = 800000 });Console.WriteLine("\n");
Console.WriteLine("\n");

var resultlist = emputils.empdb.Where((emp) => emp.Aadhaar != null && emp.Aadhaar.StartsWith("83"));
resultlist.ToList().ForEach((emp) => Console.WriteLine($"adhaar starts with 83 :{emp.Name}| {emp.Aadhaar} "));

Console.WriteLine("\n");
//get all employees with salary greater than 6L

var result2 = emputils.empdb.Where((emp) => emp.salary != null && emp.salary >= 500000);
result2.ToList().ForEach((emp)=> Console.WriteLine($"{emp.Name} has salary more than 5LPA"));

Console.WriteLine("\n");

