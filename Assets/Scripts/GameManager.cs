using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public int score = 0;

    public GameObject boss;
    public int instantiateBoss = 5;
    private bool isBossActive = false;

    private void Update()
    {
        Debug.Log(score);
    }

    //public void TotalScore(int value)
    //{

    //    if (score >= instantiateBoss && !isBossActive)
    //    {
    //        Instantiate(boss, boss.transform.position, boss.transform.rotation);
    //        isBossActive = true;
    //    }
    //}

    public void Score(int value)
    {
        scoreTxt.text = value.ToString();
    }
}
