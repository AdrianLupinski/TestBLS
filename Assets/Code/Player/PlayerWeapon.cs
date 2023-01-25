using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;

    [SerializeField]
    private Transform firePos;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }
    
    private void Shoot()
    {
        Instantiate(Bullet, firePos.position, firePos.rotation);
    }
}
