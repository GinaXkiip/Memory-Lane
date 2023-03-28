using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicturesAppearL2 : MonoBehaviour
{
    public GameObject L2Piece1;
    public GameObject L2Piece2;
    public GameObject L2Piece3;
    public GameObject L2Piece4;

    void Start()
    {
        L2Piece1.SetActive(false);
        L2Piece2.SetActive(false);
        L2Piece3.SetActive(false);
        L2Piece4.SetActive(true);
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("L2Puzzle1") == 1)
        {
            L2Piece1.SetActive(true);
        }

        if (PlayerPrefs.GetInt("L2Puzzle2") == 1)
        {
            L2Piece2.SetActive(true);
        }

        if (PlayerPrefs.GetInt("L2Puzzle3") == 1)
        {
            L2Piece3.SetActive(true);
        }

        if (PlayerPrefs.GetInt("L2PuzzlePiece1") == 1 && (PlayerPrefs.GetInt("L2PuzzlePiece2") == 1 && (PlayerPrefs.GetInt("L2PuzzlePiece3") == 1)))
        {
            L2Piece4.SetActive(false);

        }
    }
}
