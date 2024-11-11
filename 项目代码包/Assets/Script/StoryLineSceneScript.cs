using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryLineSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject detail;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void backToMain()
    {
        SceneManager.LoadScene(0);
    }
    public void showDetail()
    {
        detail.SetActive(true);
    }
    public void unshowDetail()
    {
        detail.SetActive(false);
    }
}
