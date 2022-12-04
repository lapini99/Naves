using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
    public GameObject description;

    void Start()
    {
        description.SetActive(false);
    }

    private void OnMouseEnter()
    {
        description.SetActive(true);
    }
}
