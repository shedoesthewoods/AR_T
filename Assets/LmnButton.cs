using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class LmnButton : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject lemons;
    public Animator lemonsAnimation;

    // Use this for initialization
    void Start()
    {
        //vbBtnObj = GameObject.Find("VirtualButton");

        lemons = GameObject.Find("rotateBtnLm");

        lemons.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        lemonsAnimation = lemonsAnimation.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        lemonsAnimation.Play("lmsAnimation");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        lemonsAnimation.Play("dont");
        Debug.Log("Button released");
    }
}
