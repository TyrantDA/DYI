using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space");
            SceneManager.LoadScene("Top Down Movement");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
