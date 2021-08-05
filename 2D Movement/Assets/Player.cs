using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float lavaSpeed = 1f;
    public Boolean win = false;
    public Boolean surf = false;
    public GameObject Sieg;
    public GameObject restart;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (surf == true) { 


            GetComponent<BoxCollider2D>().isTrigger = true;
            GetComponent<CircleCollider2D>().isTrigger = true;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ziel")
        {
            StartCoroutine(waiter());
            print("win");
            win = true;
            Instantiate(Sieg, new Vector2(0, 0), Quaternion.identity);

            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (collision.gameObject.tag == "lava" && win == false)
        {

            Instantiate(restart, new Vector2(39, 79), Quaternion.identity);
            Destroy(player);


}
        if (collision.gameObject.tag == "lava" && win == true)
        {
            surf = true;

        }
       
        }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(4);
    }
    public void restartScript()
    {
        print("restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
