﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene (scenename);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
