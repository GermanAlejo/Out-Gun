﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Options;
    // Use this for initialization
    void Start()
    {
        MainMenu.SetActive(true);
        Options.SetActive(false);
    }
}
