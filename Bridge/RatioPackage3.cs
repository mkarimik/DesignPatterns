namespace BridgeDesignPattern;

public class RatioPackage3 : IRatingPackage
{
    public double CalculateRatioAbsence()
    {
        return -0.5;
    }

    public double CalculateRatioEducation()
    {
        return 0.5;
    }

    public double CalculateRatioVacation()
    {
        return -0.1;
    }
}