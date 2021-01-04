using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    public GameObject PanelCongrats;
    public bool isPanelOpen = false;

    private void Start()
    {
        if (isPanelOpen == true)
        {
            closePanel();
            //Debug.Log("Panel ditutup!");
        }
    }
   
    public void openPanel()
    {
        isPanelOpen = true;
        Time.timeScale = 0;
        PanelCongrats.SetActive(true);
        Debug.Log("Game finished!");
    }
    public void closePanel()
    {
        isPanelOpen = false;
        PanelCongrats.SetActive(false);
        Time.timeScale = 1;
    }
    
	
    public void loadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            closePanel();
            SceneManager.LoadScene("Levels");
        }

        else
        {
            closePanel();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
