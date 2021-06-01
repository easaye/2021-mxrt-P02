﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckShapes : MonoBehaviour
{
    public GameObject correct;
    public GameObject wrong;
    public GameObject circle;
    public GameObject triangle;
    public GameObject square;

    private RandomDrawing randomDrawing;

    private bool circleIsShown = false;
    private bool triangleIsShown = false;
    private bool squareIsShown = false;
    private bool circleInDrawing = false;
    private bool triangleInDrawing = false;
    private bool squareInDrawing = false;
    void Start()
    {
        randomDrawing = GetComponent<RandomDrawing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (circle.activeInHierarchy == true)
        {
            circleInDrawing = true;
            if (circleIsShown == true)
            {
                circle.SetActive(false);
                circleIsShown = false;
                correctShape();
            }
            else if(triangleIsShown == true)
            {
                wrongShape();
                triangleIsShown = false;
            }
            else if(squareIsShown == true)
            {
                wrongShape();
                squareIsShown = false;
            }
        }
        if (triangle.activeInHierarchy == true)
        {
            triangleInDrawing = true;
            if (triangleIsShown == true)
            {
                triangle.SetActive(false);
                /*correct.SetActive(true);
                wrong.SetActive(false);*/
                triangleIsShown = false;
                /*randomDrawing.displayDrawing();*/
                correctShape();
            }
            else if(circleIsShown == true)
            {
                /*wrong.SetActive(true);*/
                wrongShape();
                circleIsShown = false;
            }
            else if(squareIsShown == true)
            {
                /*wrong.SetActive(true);*/
                wrongShape();
                squareIsShown = false;
            }
        }
        if (square.activeInHierarchy == true)
        {
            squareInDrawing = true;
            if (squareIsShown == true)
            {
                square.SetActive(false);
                /*correct.SetActive(true);
                wrong.SetActive(false);*/
                squareIsShown = false;
                /*randomDrawing.displayDrawing();*/
                correctShape();
            }
            else if (circleIsShown == true)
            {
                /*wrong.SetActive(true);*/
                wrongShape();
                circleIsShown = false;
            }
            else if (triangleIsShown == true)
            {
                /*wrong.SetActive(true);*/
                wrongShape();
                triangleIsShown = false;
            }
        }

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        correct.SetActive(false);
        wrong.SetActive(false);

    }

    public void wrongShape()
    {
        wrong.SetActive(true);
        StartCoroutine(Wait());
    }

    public void correctShape()
    {
        correct.SetActive(true);
        randomDrawing.displayDrawing();
        StartCoroutine(Wait());
    }

    public void circleShown()
    {
        circleIsShown = true;
    }

    public void noCircle()
    {
        circleIsShown = false;
    }

    public void triangleShown()
    {
        triangleIsShown = true;
    }

    public void noTriangle()
    {
        triangleIsShown = false;
    }

    public void squareShown()
    {
        squareIsShown = true;
    }

    public void noSquare()
    {
        squareIsShown = false;
    }
}
