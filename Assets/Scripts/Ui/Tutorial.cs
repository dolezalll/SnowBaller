using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : BaseUiController
{


    private bool tutOpen = false;

    private void Start()
    {

        

    }



    private void TutOpen()
    {
        Load();
        _GameManager.PauseGame();
        tutOpen = true;
        Debug.Log("OTEV�R� SE TUT");


    }

    public void TutClose()
    {

        Unload();
        _GameManager.UnpauseGame();
        tutOpen = false;
        Debug.Log("ZAV�R� SE TUT");
    }




    private void Update()
    {
       


        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!tutOpen)
            {
                TutOpen();
            }
            else
            {
                TutClose();
            }
        }
    }
}

