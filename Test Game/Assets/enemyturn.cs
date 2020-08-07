using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyturn : MonoBehaviour
{
    public GameObject Player;
    float radius = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        transform.Rotate(new Vector3(0, -90, 0));
    }
}
