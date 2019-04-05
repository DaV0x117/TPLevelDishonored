using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;

public class DarkVision : MonoBehaviour
{
    //A mettre sur le composent MainCamera du RigibodyFPSController
    public Camera cameraVision;
    public Camera cameraPlayer;
    public bool usingDarkVision = false;
    public float visionTime = 2.0f;

    private void Start()
    {
        cameraVision.enabled = false;
        cameraPlayer.enabled = true;
    }

    private void Update()
    {
        if (usingDarkVision == false && Input.GetKeyDown(KeyCode.Keypad2))
        {
            StartCoroutine(timer());

        }
    }

    IEnumerator timer()
    {
        //avant
        cameraVision.enabled = true;
        cameraPlayer.enabled = false;
        usingDarkVision = true;
        yield return new WaitForSeconds(visionTime);
        cameraPlayer.enabled = true;
        cameraVision.enabled = false;
        usingDarkVision = false;
        // après
    }
}
