using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    public void PlayGame()

    {

        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }



}
