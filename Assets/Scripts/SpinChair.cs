using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpinChair : MonoBehaviour
{
    public GameObject ObjectToSpin;
    public float speed;

    private UnityEngine.XR.InputDevice leftController;
    private UnityEngine.XR.InputDevice rightController;

    // Start is called before the first frame update
    void Start()
    {
        GetControllers();
    }

    // Update is called once per frame
    void Update()
    {
        SpinGameObject();
    }

    // Get the left and right controller
    void GetControllers()
    {
        var gameContorllers = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(UnityEngine.XR.InputDeviceCharacteristics.Controller, gameContorllers);

        if (gameContorllers.Count > 0)
        {
            leftController = gameContorllers[0];
            rightController = gameContorllers[1];
        }
    }

    void SpinGameObject()
    {
        float gripValue;
        // Get controller grip value
        rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.grip, out gripValue);
        Debug.Log("Grip Value: " + gripValue);

        // Rotate Chair with grip value
        //ObjectToSpin.transform.rotation = Quaternion.Euler(0, gripValue * 360, 0);
        ObjectToSpin.transform.Rotate(0, (float)(gripValue * speed * Time.deltaTime), 0);
    }
}
