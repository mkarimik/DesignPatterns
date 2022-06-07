namespace BridgeDesignPattern;

public class Employee : IPersonInStructure
{
    private readonly IRatingPackage _ratingPackage;

    private int _baseGrade, _absenceCount, _educationCount, _vacationCount, _level;

    public Employee(int baseGrade, int absenceCount, int educationCount, int vacationCount, int level, IRatingPackage ratingPackage)
    {
        _baseGrade = baseGrade;
        _absenceCount = absenceCount;
        _educationCount = educationCount;
        _vacationCount = vacationCount;
        _level = level;

        _ratingPackage = ratingPackage;
    }

    public double CheckAbsenceGrade()
    {
        return (_level * 0.1) * _baseGrade * _ratingPackage.CalculateRatioAbsence();
    }

    public double CheckEducationGrade()
    {
        return (_level * 0.1) * _baseGrade * _ratingPackage.CalculateRatioEducation();
    }

    public double CheckVacationGrade()
    {
        return (_level * 0.1) * _baseGrade * _ratingPackage.CalculateRatioVacation();
    }
}