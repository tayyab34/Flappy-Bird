using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMnager : MonoBehaviour
{
    private int score=0;
    private int time = 0;
    public bool gameover=false;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI timetext;
    void Start()
    {
        StartCoroutine(Score());
        StartCoroutine(Timer());
        scoretext.text = "Score:" + score;
    }

    public void Score(int scoretoadd)
    {
        score += scoretoadd;
        scoretext.text = "Score:" + score;
    }
    //Timer
    IEnumerator Timer()
    {
        while (!gameover)
        {
            timetext.text = "Time:" + time;
            yield return new WaitForSeconds(1);
            time = time + 1;
            
        }
        
    }
    IEnumerator Score()
    {
        while (!gameover)
        {
            yield return new WaitForSeconds(3);
            Score(1);
        }     
    }
}
