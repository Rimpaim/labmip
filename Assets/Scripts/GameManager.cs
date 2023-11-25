using System;
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

    [SerializeField]
    private GameObject cueBall;

    [SerializeField] 
    private GameObject ballLine;

    [SerializeField]
    private float xInput;
    
    public static GameManager Instance;
 
    void Start()
    {
        Instance = this;
        SetBall(ColorBall.Red,    1);
        SetBall(ColorBall.Yellow, 2);
        SetBall(ColorBall.Green,  3);
        SetBall(ColorBall.Brown,  4);
        SetBall(ColorBall.Blue,   5);
        SetBall(ColorBall.Pink,   6);
        SetBall(ColorBall.Black,  7);
    }

    private void Update()
    {
       RotateBall();

       if (Input.GetKeyDown(KeyCode.Space))
           ShootBall();
    }

    private void SetBall(ColorBall col, int i)
    {
        GameObject obj = Instantiate(ballPrefab,
                         ballPositions[i].transform.position,
                         Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    }

    private void RotateBall()
    {
        xInput = Input.GetAxis("Horizontal");
        cueBall.transform.Rotate(new Vector3(0f, xInput/20, 0f));
    }

    private void ShootBall()
    {
        Rigidbody rb = cueBall.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * 50, ForceMode.Impulse);
        
        ballLine.SetActive(false);
    }
    
}
