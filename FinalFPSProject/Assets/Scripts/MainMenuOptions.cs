using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {

    public void Start()
    {
        if(Cursor.visible == false)
        {
            Cursor.visible = true;
        }
        Debug.Log(Cursor.visible);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(0);
       
    }

    public void CreditScene()
    {
        SceneManager.LoadScene(2);
    }
}
