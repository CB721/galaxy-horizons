﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonOptions : MonoBehaviour
{
    public void playGame () {
        SceneManager.LoadScene(2);
    }
    public void mainMenu () {
        SceneManager.LoadScene(0);
    }
    public void openCamera () {
        SceneManager.LoadScene(1);
    }
}
