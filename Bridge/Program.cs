using BridgeDesignPattern;

// BaseGrade is a grade that all ratio changes it
// And other Count variables are parameters that change the BaseGrade value based on the ratio package
int  BaseGrade = 50, AbsenceCount = 3, EducationCount = 2, VacationCount = 5, Level = 3;
double AbsenceGrade, EducationGrade, VacationGrade;

// student is a PersonInStructure with RatioPackage1 of RatingPackage
var student = new Student(
                BaseGrade, 
                AbsenceCount, 
                EducationCount, 
                VacationCount, 
                new RatioPackage1());

AbsenceGrade = student.CheckAbsenceGrade();
EducationGrade = student.CheckEducationGrade();
VacationGrade = student.CheckVacationGrade();

Console.WriteLine("\r\nstudent with RatioPackage1 : ");
Console.WriteLine($"AbsenceGrade = {AbsenceGrade}, EducationGrade = {EducationGrade}, VacationGrade = {VacationGrade}");
Console.WriteLine($"BaseGrade is {BaseGrade + AbsenceGrade + EducationGrade + VacationGrade}");

var employee1 = new Employee(
                BaseGrade, 
                AbsenceCount, 
                EducationCount, 
                VacationCount, 
                Level, 
                new RatioPackage2());

AbsenceGrade = employee1.CheckAbsenceGrade();
EducationGrade = employee1.CheckEducationGrade();
VacationGrade = employee1.CheckVacationGrade();

Console.WriteLine("\r\nemployee1  with RatioPackage2 : ");
Console.WriteLine($"AbsenceGrade = {AbsenceGrade}, EducationGrade = {EducationGrade}, VacationGrade = {VacationGrade}");
Console.WriteLine($"BaseGrade is {BaseGrade + AbsenceGrade + EducationGrade + VacationGrade}");

var employee2 = new Employee(
                BaseGrade, 
                AbsenceCount, 
                EducationCount, 
                VacationCount, 
                Level, 
                new RatioPackage3());

AbsenceGrade = employee2.CheckAbsenceGrade();
EducationGrade = employee2.CheckEducationGrade();
VacationGrade = employee2.CheckVacationGrade();

Console.WriteLine("\r\nemployee2  with RatioPackage3 : ");
Console.WriteLine($"AbsenceGrade = {AbsenceGrade}, EducationGrade = {EducationGrade}, VacationGrade = {VacationGrade}");
Console.WriteLine($"BaseGrade is {BaseGrade + AbsenceGrade + EducationGrade + VacationGrade}");
