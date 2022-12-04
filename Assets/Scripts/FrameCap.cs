using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameCap : MonoBehaviour
{

    public int frameRate = 20;
    void Update()
    {
        Application.targetFrameRate = frameRate;
    }
}
