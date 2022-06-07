namespace BridgeDesignPattern;

public class RatioPackage1 : IRatingPackage
{
    public double CalculateRatioAbsence()
    {
        return -0.1;
    }

    public double CalculateRatioEducation()
    {
        return 0.3;
    }

    public double CalculateRatioVacation()
    {
        return -0.05;
    }
}