using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip Ok;

    public GameObject ResetScreen;

    public void ResetTheGame()
    {
        print("Game has been reset");

        PlayerPrefs.SetInt("PTPuzzle", 0);
        PlayerPrefs.SetInt("PTPuzzlePiece", 0);

        //Tutorial
        PlayerPrefs.SetInt("TutorialPuzzle1.1", 0);
        PlayerPrefs.SetInt("TutorialPuzzle1.2", 0);
        PlayerPrefs.SetInt("TutorialPuzzle2.1", 0);
        PlayerPrefs.SetInt("TutorialPuzzle2.2", 0);
        PlayerPrefs.SetInt("TutorialPuzzle2.3", 0);
        PlayerPrefs.SetInt("TutorialPuzzlePiece1", 0);
        PlayerPrefs.SetInt("TutorialPuzzlePiece2", 0);
        PlayerPrefs.SetInt("TutorialFinish", 0);

        //Lvl 2
        PlayerPrefs.SetInt("L2Puzzle1", 0);
        PlayerPrefs.SetInt("L2Puzzle2", 0);
        PlayerPrefs.SetInt("L2Puzzle3", 0);
        PlayerPrefs.SetInt("L2PuzzlePiece1", 0);
        PlayerPrefs.SetInt("L2PuzzlePiece2", 0);
        PlayerPrefs.SetInt("L2PuzzlePiece3", 0);
        PlayerPrefs.SetInt("Level2Finish", 0);

        //Lvl 3
        PlayerPrefs.SetInt("L3Puzzle1", 0);
        PlayerPrefs.SetInt("L3Puzzle2", 0);
        PlayerPrefs.SetInt("L3Puzzle3", 0);
        PlayerPrefs.SetInt("L3Puzzle4", 0);
        PlayerPrefs.SetInt("L3PuzzlePiece1", 0);
        PlayerPrefs.SetInt("L3PuzzlePiece2", 0);
        PlayerPrefs.SetInt("L3PuzzlePiece3", 0);
        PlayerPrefs.SetInt("L3PuzzlePiece4", 0);

        ResetScreen.SetActive(false);

        SFX.clip = Ok;
        SFX.Play();
    }

}
