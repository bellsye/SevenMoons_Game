using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScavengeScript : MonoBehaviour
{
    public float nextSceneTime = 5;
    int clicks = 0;

    public GameObject winUI;
    //public GameObject loseUI;

    // Start is called before the first frame update
    void Start()
    {
        winUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (clicks >= 1)
        {
            GameOver();
            Debug.Log("clicked");
        }
    }

    void OnMouseDown()
    {
        clicks++;
    }

    private void GameOver()
    {
        winUI.gameObject.SetActive(true);
        nextSceneTime -= Time.deltaTime;
        //Debug.Log(score); //display score in UI!

        if (nextSceneTime < 0) //could use a button to load next scene instead
        {
            //Debug.Log("Load Next Scene");
            SceneManager.LoadScene("Campsite");
        }
    }
}
