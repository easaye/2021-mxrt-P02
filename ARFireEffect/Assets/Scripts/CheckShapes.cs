using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckShapes : MonoBehaviour
{
    public GameObject correct;
    public GameObject wrong;
    public GameObject []shapes;

    private bool circleIsShown = false;
    private bool triangleIsShown = false;
    private bool squareIsShown = false;
    private bool circleInDrawing = false;
    private bool triangleInDrawing = false;
    private bool squareInDrawing = false;
    //private bool wrongShape = false;
    //private bool correctShape = false;
    private int shapeShown = 0;
    // Start is called before the first frame update
    void Start()
    {
        shapeNeed();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < shapes.Length; i++)
        {
            if (shapes[0].active == true)
            {
                circleInDrawing = true;
                if (circleIsShown == true)
                {
                    shapes[0].SetActive(false);
                    correct.SetActive(true);
                    wrong.SetActive(false);
                }
                else
                {
                    wrong.SetActive(true);
                    correct.SetActive(false);
                    shapeNeed();
                }
            }
            if (shapes[1].active == true)
            {
                triangleInDrawing = true;
                if (triangleIsShown == true)
                {
                    shapes[1].SetActive(false);
                    correct.SetActive(true);
                    wrong.SetActive(false);
                }
                else
                {
                    wrong.SetActive(true);
                    correct.SetActive(false);
                    shapeNeed();
                }
            }
            if (shapes[2].active == true)
            {
                squareInDrawing = true;
                if (squareIsShown == true)
                {
                    shapes[2].SetActive(false);
                    correct.SetActive(true);
                    wrong.SetActive(false);
                }
                else
                {
                    wrong.SetActive(true);
                    correct.SetActive(false);
                    shapeNeed();
                }
            }
            i = 0;
        }
        
    }

    private void shapeNeed()
    {
        shapeShown = Random.Range(0, shapes.Length);
        shapes[shapeShown].SetActive(true);
    }

    public void circle()
    {
        circleIsShown = true;
    }

    public void noCircle()
    {
        circleIsShown = false;
    }

    public void triangle()
    {
        triangleIsShown = true;
    }

    public void noTriangle()
    {
        triangleIsShown = false;
    }

    public void square()
    {
        squareIsShown = true;
    }

    public void noSquare()
    {
        squareIsShown = false;
    }
}
