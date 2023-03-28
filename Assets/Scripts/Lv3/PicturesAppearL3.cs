using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicturesAppearL3 : MonoBehaviour
{
    public GameObject L3Piece1;
    public GameObject L3Piece2;
    public GameObject L3Piece3;
    public GameObject L3Piece4;
    public GameObject L3Piece5;

    void Start()
    {
        L3Piece1.SetActive(false);
        L3Piece2.SetActive(false);
        L3Piece3.SetActive(false);
        L3Piece4.SetActive(false);
        L3Piece5.SetActive(true);
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("L3Puzzle1") == 1)
        {
            L3Piece1.SetActive(true);
        }

        if (PlayerPrefs.GetInt("L3Puzzle2") == 1)
        {
            L3Piece2.SetActive(true);
        }

        if (PlayerPrefs.GetInt("L3Puzzle3") == 1)
        {
            L3Piece3.SetActive(true);

        }

        if (PlayerPrefs.GetInt("L3Puzzle4") == 1)
        {
            L3Piece4.SetActive(true);

        }

        if (PlayerPrefs.GetInt("L3PuzzlePiece1") == 1 && (PlayerPrefs.GetInt("L3PuzzlePiece2") == 1 && (PlayerPrefs.GetInt("L3PuzzlePiece3") == 1 && (PlayerPrefs.GetInt("L3PuzzlePiece4") == 1))))
        {
            L3Piece5.SetActive(false);
        }
    }
}
