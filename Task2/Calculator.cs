
public class Calculator
{
    private double num1;
    private double num2;

    public Calculator(double _num1, double _num2)
    {
        num1 = _num1;
        num2 = _num2;
    }

    public double Sum()
    {
        return num1 + num2;
    }

    public double Subtract()
    {
        return num1 - num2;
    }

    public double Multiplication()
    {
        return num1 * num2;
    }

    public double Division()
    {

        return num1 / num2;

    }


}

