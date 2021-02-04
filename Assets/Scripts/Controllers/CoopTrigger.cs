using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CoopTrigger : MonoBehaviour
{
    public int ActivePlayer;

    public FirstPersonAIO Player1Controller;
    public FirstPersonAIO Player2Controller;

    public Camera Player1Camera;
    public Camera Player2Camera;
    
    //public GameObject Player1Head;
    //public GameObject Player2Head;

    // Start is called before the first frame update
    void Start()
    {
         ActivePlayer = 1;
    }

    // Update is called once per frame
    void Update()
    {

        //Triggers change between players
        if (Input.GetKeyUp(KeyCode.Tab)) {
            if (ActivePlayer == 1) {
                ActivePlayer = 2;
            } 
            else {
                ActivePlayer = 1;
            }
        }

        //Changes values between player units
        if (ActivePlayer == 1) {

            //Player2Camera.gameObject.SetActive(true);
            Player1Camera.enabled = false;
            Player2Camera.enabled = true;

            //Player1Controller.playerCamera = Player2Camera;
            //Player1Camera.gameObject.SetActive(false);

            Player1Controller.useHeadbob = true;
            Player2Controller.useHeadbob = false;

            Player1Controller.enableCameraMovement = false;
            Player2Controller.enableCameraMovement = true;
            
            Player1Controller.playerCanMove = true;
            Player2Controller.playerCanMove = false;
        } else {

            //Player1Camera.gameObject.SetActive(true);
            Player1Camera.enabled = true;
            Player2Camera.enabled = false;

            //Player2Controller.playerCamera = Player1Camera;
            //Player2Camera.gameObject.SetActive(false);

            Player2Controller.useHeadbob = false;
            Player1Controller.useHeadbob = true;

            Player1Controller.enableCameraMovement = true;
            Player2Controller.enableCameraMovement = false;

            Player1Controller.playerCanMove = false;
            Player2Controller.playerCanMove = true;
        }
    }

    void FixedUpdate()
    {
        


    }
}
