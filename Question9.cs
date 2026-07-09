/*Create variables for five subject marks and calculate the average.*/
using System;
class Question9
{
    public void average ( double maths, double science, double nepali, double visualprogarming, double physics)
    {
        
        double marks = ( maths + science + nepali + visualprogarming + physics) / 5;
        Console.WriteLine ( " The average is:- " + marks );
    }
}
