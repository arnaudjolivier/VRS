using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandButton : XRBaseInteractable
{
    private float yMin = 0.0f;
    private float yMax = 0.0f;

    private float previousHandHeight = 0.0f;
    private XRBaseInteractor hoverInterator = null;

    protected override void Awake()
    {
        base.Awake();
        onHoverEntered.AddListener(StartPress);
        onHoverExited.AddListener(EndPress);
    }

    private void OnDestroy()
    {
        onHoverEntered.RemoveListener(StartPress);
        onHoverExited.RemoveListener(EndPress);
    }

    private void StartPress(XRBaseInteractor obj)
    {
        Debug.Log("Start Press");
    }

    private void EndPress(XRBaseInteractor obj)
    {
        Debug.Log("End Press");
    }

    private void Start()
    {
        SetMinMax();
    }

    private void SetMinMax()
    {
        Collider collider = GetComponent<Collider>();
        yMin = transform.position.y - (collider.bounds.size.y * 0.5f);
        yMin = transform.position.y;
    }
}
