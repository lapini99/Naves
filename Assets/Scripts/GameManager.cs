using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text score;

    public void Score(int value)
    {
        score.text = value.ToString();
    }
}
