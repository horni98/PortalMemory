using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tips : MonoBehaviour
{

    public GameObject Tips;
    public void PlayGame()

    
    {

       Tips = (GameObject) Instantiate(Tips, new Vector3(743,693,-98),Quaternion.identity);
        Destroy(Tips, 2);
    }


    public void QuitGame()

    {
        print("Quit");
        Application.Quit();
    }



}
