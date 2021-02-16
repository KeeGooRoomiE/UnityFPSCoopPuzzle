using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    public bool isArrowControls;// = false;
    //public Camera playerCam;
    public Transform head;
    public GameObject playerBody;
    public FirstPersonAIO PlayerController;
    public float xScale;
    public float yScale;
    public float tiltAroundY = 0;
    public float tiltAroundX = 0;
    // Start is called before the first frame update
    void Start()
    {
        //xScale = 10.0f;
        //yScale = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isArrowControls) {

            PlayerController.enableCameraMovement = false;
            // Smoothly tilts a transform towards a target rotation.
            tiltAroundY += Input.GetAxis("HorizontalLook") * xScale;
            tiltAroundX = (-Input.GetAxis("VerticalLook")) * yScale;

            // Rotate the cube by converting the angles into a quaternion.
            Quaternion target = Quaternion.Euler(0, tiltAroundY, 0);

            // Dampen towards the target rotation
            playerBody.transform.localRotation = Quaternion.Slerp(playerBody.transform.localRotation, target,  Time.deltaTime * 5.0f);

            Quaternion target2 = Quaternion.Euler(tiltAroundX, 0, 0);

            // Dampen towards the target rotation
            head.localRotation = Quaternion.Slerp(head.localRotation, target2,  Time.deltaTime * 5.0f);
        } else {
            PlayerController.enableCameraMovement = true;
        }
    }
}
