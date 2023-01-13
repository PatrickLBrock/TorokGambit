using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private int boardSize = 8;//size of 2D array

    private GameObject[,] chessBoard;

    [SerializeField]
    private GameObject boardSquare;

    [SerializeField]
    private GameObject chessPiece;

    [SerializeField]
    private Camera camera;

    private GameObject storedPiece;

    // Start is called before the first frame update
    void Start()
    {
        chessBoard = new GameObject[boardSize,boardSize];

        Debug.Log(transform.position);

        BuildBoard();

        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {

        if (Physics.Raycast(ray, out hit)) 
        {
            Debug.Log(hit.transform.gameObject.name);
            if(hit.transform.tag == "Chess Piece")
            {
                storedPiece = hit.transform.gameObject;
            }
            if(hit.transform.tag == "Chess Board" && storedPiece)
            {
                storedPiece.transform.position = hit.transform.position + new Vector3(0,1,0);

            }
        }
        }

    }

    private void BuildBoard()
    {
        for(int i=0;i<boardSize;i++)
        {
            for(int j=0;j<boardSize;j++)
            {
                GameObject instance = Instantiate(boardSquare,(transform.position + new Vector3(i,0,j)), Quaternion.identity);
                instance.gameObject.name = i + "_" + j; 
            }
        }

            GameObject pieceInstance = Instantiate(chessPiece,(transform.position + new Vector3(0,1,3)), Quaternion.identity);
            pieceInstance.gameObject.name = "chessPiece"; 

        
    }
}
