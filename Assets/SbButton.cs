using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SbButton : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject sbButton;
    public Animator strawberryAnimation;

    // Use this for initialization
    void Start()
    {
        //vbBtnObj = GameObject.Find("VirtualButton");

        sbButton = GameObject.Find("rotateBtnSb");

        sbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        strawberryAnimation.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        strawberryAnimation.Play("rotateAroundAnimation");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        strawberryAnimation.Play("none");
        Debug.Log("Button released");
    }
}
