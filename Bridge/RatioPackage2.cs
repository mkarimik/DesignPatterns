namespace BridgeDesignPattern;

public class RatioPackage2 : IRatingPackage
{
    public double CalculateRatioAbsence()
    {
        return -0.3;
    }

    public double CalculateRatioEducation()
    {
        return 0.4;
    }

    public double CalculateRatioVacation()
    {
        return -0.07;
    }
}