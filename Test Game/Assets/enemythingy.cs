using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemythingy : MonoBehaviour
{
    public GameObject Player;
    float speed = 4;
    float radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        if (Vector3.Distance(transform.position, Player.transform.position) <= radius)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
