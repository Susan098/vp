/*Swap two variables without using a third variable.*/
using System;

class Question6
{
    public void swap( double a, double b)
    {
        double temp = a;
        a = b;
        b = temp;

        Console.WriteLine( "After Swap:-" + "a=" + a + " b=" + b );
    }
}