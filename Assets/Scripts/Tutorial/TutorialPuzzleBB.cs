using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPuzzleBB : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip PieceInPlace;

    public int PieceInPlaceT4;

    public GameObject CorrectForm;
    private bool Moving;
    private bool Finish;

    private float StartPosX;
    private float StartPosY;

    private Vector2 ResetPos;

    void Start()
    {
        ResetPos = this.transform.position;
    }


    void Update()
    {
        if (Finish == false)
        {
            if (Moving)
            {
                Vector3 MousePos;
                MousePos = Input.mousePosition;
                MousePos = Camera.main.ScreenToWorldPoint(MousePos);

                this.gameObject.transform.position = new Vector2(MousePos.x - StartPosX, MousePos.y - StartPosY);
            }
        }

        if (PieceInPlaceT4 == 1)
        {
            PlayerPrefs.SetInt("TutorialPuzzle2.2", 1);
        }

        if (PlayerPrefs.GetInt("TutorialPuzzle2.2") == 1)
        {
            this.transform.position = new Vector2(CorrectForm.transform.position.x, CorrectForm.transform.position.y);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 MousePos;
            MousePos = Input.mousePosition;
            MousePos = Camera.main.ScreenToWorldPoint(MousePos);

            StartPosX = MousePos.x - this.transform.position.x;
            StartPosY = MousePos.y - this.transform.position.y;

            Moving = true;
        }
    }

    private void OnMouseUp()
    {
        Moving = false;

        if (Mathf.Abs(this.transform.position.x - CorrectForm.transform.position.x) <= 50f &&
            Mathf.Abs(this.transform.position.y - CorrectForm.transform.position.y) <= 50f)
        {
            print("Piece in Place");
            SFX.clip = PieceInPlace;
            SFX.Play();

            Finish = true;
            PieceInPlaceT4 = PieceInPlaceT4 + 1;

            this.transform.position = new Vector2(CorrectForm.transform.position.x, CorrectForm.transform.position.y);

        }
    }
}
