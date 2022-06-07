namespace BridgeDesignPattern;

public class Student : IPersonInStructure
{
    private readonly IRatingPackage _ratingPackage;

    private int _baseGrade, _absenceCount, _educationCount, _vacationCount;

    public Student(int baseGrade, int absenceCount, int educationCount, int vacationCount, IRatingPackage ratingPackage)
    {
        _baseGrade = baseGrade;
        _absenceCount = absenceCount;
        _educationCount = educationCount;
        _vacationCount = vacationCount;

        _ratingPackage = ratingPackage;
    }

    public double CheckAbsenceGrade()
    {
        return _baseGrade * _ratingPackage.CalculateRatioAbsence();
    }

    public double CheckEducationGrade()
    {
        return _baseGrade * _ratingPackage.CalculateRatioEducation();
    }

    public double CheckVacationGrade()
    {
        return _baseGrade * _ratingPackage.CalculateRatioVacation();
    }
}