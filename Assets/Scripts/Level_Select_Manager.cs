using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Select_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadExample()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(3);
    }

}
