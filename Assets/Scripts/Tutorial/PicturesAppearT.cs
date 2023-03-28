using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicturesAppearT : MonoBehaviour
{
    public GameObject TutorialPiece1;
    public GameObject TutorialPiece2;
    public GameObject TutorialPiece3;

    void Start()
    {
        TutorialPiece1.SetActive(false);
        TutorialPiece2.SetActive(false);
        TutorialPiece3.SetActive(true);
    }

    
    void Update()
    {
        if (PlayerPrefs.GetInt("TutorialPuzzle1.1") == 1 && (PlayerPrefs.GetInt("TutorialPuzzle1.2") == 1))
        {
            TutorialPiece1.SetActive(true); 
        }

        if (PlayerPrefs.GetInt("TutorialPuzzle2.1") == 1 && (PlayerPrefs.GetInt("TutorialPuzzle2.2") == 1 && (PlayerPrefs.GetInt("TutorialPuzzle2.3") == 1)))
        {
            TutorialPiece2.SetActive(true);
        }

        if (PlayerPrefs.GetInt("TutorialPuzzlePiece1") == 1 && (PlayerPrefs.GetInt("TutorialPuzzlePiece2") == 1))
        {
            TutorialPiece3.SetActive(false);

        }
    }

}
