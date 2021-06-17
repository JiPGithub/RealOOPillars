using UnityEngine;
using UnityEngine.UI;

public class Figures : MonoBehaviour
{
    protected string FigureName;
    public Text description;

    private void Awake()
    {
        FigureName = "parent";
        description = GameObject.FindGameObjectWithTag("description").GetComponent<Text>();
    }

    protected void Rotate45 ()
    {
        transform.Rotate(0,45,0);
    }

    protected int CalculatePerimeter()
    {
        return -1;
    }

}
