using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePauseManager : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject PanelPause;

   public void PauseControl()
    {
        if (Time.timeScale == 1){
            PanelPause.SetActive (true);
            Time.timeScale = 0 ;
        } else {
            Time.timeScale = 1;
            PanelPause.SetActive (false);
        }
    }

    // Update is called once per frame
    public void Restart()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene (scenename);
        Time.timeScale = 1;
    }

    //public void MainMenu()
    //{
        //SceneManager.LoadScene (0);
    //}
}
