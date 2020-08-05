using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrols : MonoBehaviour
{
    public int speed = 20;
    public GameObject cameraY;
    // Start is called before the first frame update
    void Start()
    {
        cameraY = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Mouse X") * 3, 0);
        cameraY.transform.Rotate(-3* Input.GetAxis("Mouse Y") , 0, 0);
    }


}
