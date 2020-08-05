using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooterscript : MonoBehaviour

{
public GameObject Bullet;
public bool canShoot;
    public float timeBetweenShots = .5f;
private float timeUntilNextShot;
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-3* Input.GetAxis("Mouse Y") , 0, 0);
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            Instantiate(Bullet, this.transform.position, this.transform.rotation);
            canShoot = false;
            timeUntilNextShot = Time.time + timeBetweenShots;
        }
        if (Time.time >= timeUntilNextShot)
        {
            canShoot = true;
        }

    }
}
