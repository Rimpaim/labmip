using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playScore;
    public int PlayScore 
    { 
        get { return playScore; } 
        set { playScore = value; }
    }
 
    [SerializeField]
    private GameObject ballPrefab;
 
    [SerializeField]
    private GameObject[] ballPositions;
 
    public static GameManager Instance;
 
    void Start()
    {
        Instance = this;
        SetBall(ColorBall.White,  0);
        SetBall(ColorBall.Red,    1);
        SetBall(ColorBall.Yellow, 2);
        SetBall(ColorBall.Green,  3);
        SetBall(ColorBall.Brown,  4);
        SetBall(ColorBall.Blue,   5);
        SetBall(ColorBall.Pink,   6);
        SetBall(ColorBall.Black,  7);
    }
 
    private void SetBall(ColorBall col, int i)
    {
        GameObject obj = Instantiate(ballPrefab,
                         ballPositions[i].transform.position,
                         Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    }
}
