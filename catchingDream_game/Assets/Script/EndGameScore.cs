using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour
{
    private Text endScore;
    public int endScoreValue;
    // Start is called before the first frame update
    void Start()
    {
        endScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        endScoreValue = FindObjectOfType<scoreManager>().getScore();
        endScore.text = endScoreValue.ToString("f0");
    }
}
