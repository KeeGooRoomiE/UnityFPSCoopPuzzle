using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CoopTrigger : MonoBehaviour
{
    public int ActivePlayer;
    public int ActiveCamera;
    public int ActiveMovement;

    public Sprite Player1Cross;
    public Sprite Player2Cross;

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
        ActiveCamera = 1;
        ActiveMovement = 1;
    }

    // Update is called once per frame
    void Update()
    {

        //Triggers change between players
        if (Input.GetKeyUp(KeyCode.Tab)) {
            if (ActivePlayer == 1) {
                ActivePlayer = 2;
                ActiveMovement = 2;
                ActiveCamera = 2;
            } 
            else {
                ActivePlayer = 1;
                ActiveCamera = 1;
                ActiveMovement = 1;
            }
        }

        //Pressing Q triggers camera change
        if (Input.GetKeyUp(KeyCode.Q)) {
            if (ActiveCamera == 1) {
                ActiveCamera = 2;
            } 
            else {
                ActiveCamera = 1;
            }
        }

        //Pressing E triggers movement change
        if (Input.GetKeyUp(KeyCode.E)) {
            if (ActiveMovement == 1) {
                ActiveMovement = 2;
            } 
            else {
                ActiveMovement = 1;
            }
        }

        /*
        //If Camera and Movement belongs to one setup
        if (ActiveMovement == 1)  (ActiveCamera == 1) {
            ActivePlayer = 1;
        }

        //If Camera and Movement belongs to one setup
        if (ActiveMovement == 2) and (ActiveCamera == 2) {
            ActivePlayer = 2;
        }
        */

        //Changes values between player units
        if (ActivePlayer == 1) {

            //Player2Camera.gameObject.SetActive(true);
            //Player1Camera.enabled = false;
            //Player2Camera.enabled = true;

            Player1Controller.useHeadbob = true;
            Player2Controller.useHeadbob = true;

            Player1Controller.enableCameraMovement = false;
            Player2Controller.enableCameraMovement = true;

            Player1Controller.autoCrosshair = false;
            Player2Controller.autoCrosshair = true;
            Player1Controller.Crosshair = Player1Cross;
            Player2Controller.Crosshair = null;//Player1Cross;
            
            Player1Controller.playerCanMove = true;
            Player2Controller.playerCanMove = true;//false;
        } else {

            //Player1Camera.gameObject.SetActive(true);
            //Player1Camera.enabled = true;
            //Player2Camera.enabled = false;

            //Player2Controller.playerCamera = Player1Camera;
            //Player2Camera.gameObject.SetActive(false);

            Player2Controller.useHeadbob = true;
            Player1Controller.useHeadbob = true;

            Player1Controller.enableCameraMovement = true;
            Player2Controller.enableCameraMovement = false;

            Player1Controller.autoCrosshair = true;
            Player2Controller.autoCrosshair = false;
            Player1Controller.Crosshair = null;//Player2Cross;
            Player2Controller.Crosshair = Player2Cross;

            Player1Controller.playerCanMove = true;//false;
            Player2Controller.playerCanMove = true;
        }

        if (ActiveCamera == 1) {

            //Player1Camera.enabled = false;
            //Player2Camera.enabled = true;

            Player1Controller.enableCameraMovement = true;//false;
            Player2Controller.enableCameraMovement = true;
        } else {
            //Player1Camera.enabled = true;
            //Player2Camera.enabled = false;

            Player1Controller.enableCameraMovement = true;
            Player2Controller.enableCameraMovement = true;//false;
        }

        if (ActiveMovement == 1) {

            Player1Controller.playerCanMove = true;
            Player2Controller.playerCanMove = true;//false;
        } else {
            Player1Controller.playerCanMove = true;//false;
            Player2Controller.playerCanMove = true;
        }
    }
}
