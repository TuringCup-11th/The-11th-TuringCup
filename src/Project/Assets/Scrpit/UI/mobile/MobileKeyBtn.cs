﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileKeyBtn : MonoBehaviour
{
    public string KeyName;
    private VirtualKeyManager.VirtualKey virtualKey;

    void OnEnable()
    {
        virtualKey = VirtualKeyManager.Register(KeyName);
    }

    void OnDisable()
    {
        virtualKey.Remove();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetKeyDown()
    {
        virtualKey.Press();
    }

    public void SetKeyUp()
    {
        virtualKey.Release();
    }
}