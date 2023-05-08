using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Home()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        SceneManager.LoadScene(5);
    }

    public void Battle()
    {
        SceneManager.LoadScene(4);
    }

    public void Next()
    {
        SceneManager.LoadScene(6);
    }

    public void Next1()
    {
        SceneManager.LoadScene(8);
    }
}
