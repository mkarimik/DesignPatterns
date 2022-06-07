using BridgeDesignPattern;

int  BaseGrade = 50, AbsenceCount = 3, EducationCount = 2, VacationCount = 5, Level = 3;
double AbsenceGrade, EducationGrade, VacationGrade;

var student = new Student(BaseGrade, AbsenceCount, EducationCount, VacationCount, new RatioPackage1());


AbsenceGrade = student.CheckAbsenceGrade();
EducationGrade = student.CheckEducationGrade();
VacationGrade = student.CheckVacationGrade();

Console.WriteLine($"AbsenceGrade = {AbsenceGrade}, EducationGrade = {EducationGrade}, VacationGrade = {VacationGrade}");
Console.WriteLine($"BaseGrade is {BaseGrade + AbsenceGrade + EducationGrade + VacationGrade}");

var employee = new Employee(BaseGrade, AbsenceCount, EducationCount, VacationCount, Level, new RatioPackage3());

AbsenceGrade = employee.CheckAbsenceGrade();
EducationGrade = employee.CheckEducationGrade();
VacationGrade = employee.CheckVacationGrade();

Console.WriteLine($"AbsenceGrade = {AbsenceGrade}, EducationGrade = {EducationGrade}, VacationGrade = {VacationGrade}");
Console.WriteLine($"BaseGrade is {BaseGrade + AbsenceGrade + EducationGrade + VacationGrade}");
