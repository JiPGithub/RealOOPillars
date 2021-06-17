using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Figures
{
    private void Start()
    {
        FigureName = "Square";
    }

    public void Talk()
    {
        Rotate45();
        description.text = "My fixed name (parent hidden property) is " + FigureName + ". ";
        description.text += "I inherit from Figures. I used my parent method to rotate. ";
        description.text += "I used my own method (overloaded) to calculate my perimeter, which is " + CalculatePerimeter(2);
    }

    private int CalculatePerimeter(int CoteA)
    {
        return CoteA * 4;
    }

}
