using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;

    [SerializeField]
    private Transform firePos;

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
