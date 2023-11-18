using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorBall
{
    White,
    Red,
    Yellow,
    Green,
    Brown,
    Blue,
    Pink,
    Black
}

public class Ball : MonoBehaviour
{
    [SerializeField] 
    private int point;

    public int Point
    {
        get { return point; }
    }

    [SerializeField]
    private ColorBall ballColor;

    [SerializeField]
    private MeshRenderer rd;

    private void Awake()
    {
        rd = GetComponent<MeshRenderer>();
    }

    public void SetColorAndPoint(ColorBall col)
    {
        switch (col)
        {
            case ColorBall.White :
                point = 0;
                rd.material.color = Color.white;
                break;
            case ColorBall.Red :
                point = 1;
                rd.material.color = Color.red;
                break;
            case ColorBall.Green :
                point = 3;
                rd.material.color = Color.green;
                break;
            case  ColorBall.Yellow :
                point = 2;
                rd.material.color = Color.yellow;
                break;
            case ColorBall.Brown :
                point = 4;
                rd.material.color = new Color32(212, 53, 17, 255);
                break;
            case ColorBall.Blue : 
                point = 5;
                rd.material.color = Color.blue;
                break;
            case ColorBall.Pink :
                point = 6;
                rd.material.color = new Color32(255, 98, 193, 255);
                break;
            case ColorBall.Black :
                point = 7;
                rd.material.color = Color.black;
                break;
           
        }
    }
}