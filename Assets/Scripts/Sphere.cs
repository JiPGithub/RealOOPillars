using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Figures
{
    private void Start()
    {
        FigureName = "Circle";
    }

    public void Talk()
    {
        Rotate45();
        description.text = "My fixed name (parent hidden property) is " + FigureName + ". ";
        description.text += "I inherit from Figures. I used my parent method to rotate. ";
        description.text += "I used my own method (overloaded) to calculate my perimeter, which is " + CalculatePerimeter(1.1f);
    }

    private float CalculatePerimeter(float Rayon)
    {
        return Mathf.Round((float)(3.14 * 2.0 * Rayon));
    }
}
