using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHandler : MonoBehaviour
{

    public GameObject pauseCanvas;
    public bool isPaused = false;

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }

    void Update() {

        if (Input.GetKeyUp("escape"))
        {
            pauseCanvas.SetActive(!isPaused);
                isPaused = !isPaused;
        }
    }
}
