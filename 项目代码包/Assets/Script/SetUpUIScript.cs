using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class SetUpUIScript : MonoBehaviour
{
    public bool musicStatus;
    public bool soundStatus;
    public GameObject SetUpInterface;
    public GameObject soundSet;
    public GameObject musicSet;
    public GameObject makeSure; 
    // Start is called before the first frame update
    void Start()
    {
        //SetUpInterface = GameObject.Find("SetUoInterface");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void openSet()
    {
        Time.timeScale = 0;
        SetUpInterface.SetActive(true);
        this.GetComponent<UnityEngine.UI.Button>().enabled = false;
        soundSet = GameObject.Find("soundSet");
        musicSet = GameObject.Find("musicSet");
        makeSure = GameObject.Find("makeSure");

    }

    public void closeSet()
    {
        this.GetComponent<UnityEngine.UI.Button>().enabled = true;
        Time.timeScale = 1;
        SetUpInterface.SetActive(false);
    }

    public void changeSound()
    {
        soundStatus = !soundStatus;
    } 

    public void changeMusic()
    {
        musicStatus = !musicStatus;
    }

    public void returnMain()
    {

    }
}
