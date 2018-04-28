using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerButtonPress : MonoBehaviour {

    private const Valve.VR.EVRButtonId Pad = Valve.VR.EVRButtonId.k_EButton_DPad_Down;

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

        if (Controller.GetPressDown(Pad))
        {
            Debug.Log("pressed tachpad");
            BoardPlacment bp = new BoardPlacment();
            bp.GetHeadPosition();

        }


    }



}
