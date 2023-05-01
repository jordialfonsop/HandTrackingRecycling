using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.OpenXR;
using UnityEngine;
using UnityEngine.XR.OpenXR.Input;
using UnityEngine.XR.Management;
using UnityEngine.XR;

public class Boundaries : MonoBehaviour
{
    private List<Vector3> boundaries = new List<Vector3>();

    public List<Vector3> GetBoundaries()
    {
        return boundaries;
    }

    void Start()
    {
        var loader = XRGeneralSettings.Instance?.Manager?.activeLoader;
        if (loader == null)
        {
            Debug.LogWarning("Could not get active Loader.");
            return;
        }
        var inputSubsystem = loader.GetLoadedSubsystem<XRInputSubsystem>();
        inputSubsystem.boundaryChanged += InputSubsystem_boundaryChanged;
    }
    private void InputSubsystem_boundaryChanged(XRInputSubsystem inputSubsystem)
    {
        List<Vector3> boundaryPoints = new List<Vector3>();
        if (inputSubsystem.TryGetBoundaryPoints(boundaryPoints))
        {
            foreach (var point in boundaryPoints)
            {
                Debug.Log(point);
            }
            boundaries = boundaryPoints;
        }
        else
        {
            Debug.LogWarning($"Could not get Boundary Points for Loader");
        }
    }
}
