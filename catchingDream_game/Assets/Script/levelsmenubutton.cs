using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelsmenubutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene (scenename);
    }

    public void backtomenu(string scenename)
    {
        SceneManager.LoadScene (scenename);
    }
}