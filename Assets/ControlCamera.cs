using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    // public Camera camera4; // Si vous avez une quatrième caméra
    private int startCamera = 1;

    void Start()
    {
        // Initialisation de la caméra de départ
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
        startCamera = 1;
    }

    void Update()
    {
        // Vérifier les touches de 1 à 3 pour changer de caméra
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            startCamera = 1;
            camera1.enabled = true;
            camera2.enabled = false;
            camera3.enabled = false;
            // camera4.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            startCamera = 2;
            camera1.enabled = false;
            camera2.enabled = true;
            camera3.enabled = false;
            // camera4.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            startCamera = 3;
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
            // camera4.enabled = false;
        }
    }
}
