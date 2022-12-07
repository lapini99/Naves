using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Image manaBar;

    private void Awake()
    {
        //manaBar = transform.Find("ManaBar").GetComponent<CurrentMana>;
    }
}
