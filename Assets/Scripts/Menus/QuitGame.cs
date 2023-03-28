using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitGameNow()
    {
        Application.Quit();
        print("Quit");

        PlayerPrefs.SetInt("Intro", 0);

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

        print("Game has been reset");
    }
}
