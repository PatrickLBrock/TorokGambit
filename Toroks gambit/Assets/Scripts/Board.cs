using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private int boardSize = 8;//size of 2D array

    private GameObject[,] chessBoard;

    // Start is called before the first frame update
    void Start()
    {
        chessBoard = new GameObject[boardSize,boardSize];

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BuildBoard()
    {
        
    }
}
