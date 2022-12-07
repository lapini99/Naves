using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform barrelEnd;
    private  AudioSource shootSFX;

    private void Start()
    {
        shootSFX = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            shootSFX.Play();
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet, barrelEnd.position, bullet.transform.rotation) as Rigidbody;
            bulletInstance.AddForce(barrelEnd.forward * 5000);
        }
    }

}
