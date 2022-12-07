using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float s_limitH = 5; //limites
    public float s_limitV = 5;
    public float zPos;
    Vector3 m_pointScreen; // A donde se movera mientras esta en posicion de ataque
    public static float m_step = 0.1f; // A que velocidad se movera en posicion de combate

    void Start()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
        SetRandomScreenPoint(); //Inicializamos la primera posicióm
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == m_pointScreen)
        { // Si ya ha llegado a la posicion indicada
            SetRandomScreenPoint(); // le indicamos una nueva posicion
        }
        else
        { // De lo contraria se sigue moviendo hacia la posicion indicada
            transform.position = Vector3.MoveTowards(transform.position, m_pointScreen, m_step);
        }
    }
    void SetRandomScreenPoint()
    {
        m_pointScreen = new Vector3(
        Random.Range(-s_limitH, s_limitH),
        Random.Range(-s_limitV, s_limitV),
        zPos);
    }
}
