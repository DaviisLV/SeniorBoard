using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerButtonPress : MonoBehaviour {
    public BoardPlacment bp;
    private const Valve.VR.EVRButtonId menu = Valve.VR.EVRButtonId.k_EButton_ApplicationMenu;

    private SteamVR_TrackedObject _trackedObj;
    private SteamVR_Controller.Device Controller { get { return SteamVR_Controller.Input((int)_trackedObj.index); } }

    private void Start()
    {
        _trackedObj = GetComponent<SteamVR_TrackedObject>();

    }

    private void Update()
    {
        if (Controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        if (Controller.GetPressDown(menu))
        {
            Debug.Log("pressed tachpad");
            bp.GetHeadPosition();

        }


    }



}
