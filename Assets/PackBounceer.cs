using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackBounceer : MonoBehaviour
{
    public float speed = 6;

    private Vector3 pos;

    bool One;

    // Start is called before the first frame update
    void Start()
    {
        One = true;

        var force = (transform.forward + transform.right) * 3.5f;

        GetComponent<Rigidbody>().AddForce(force, ForceMode.VelocityChange);

        One = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (One)
        {
            if (Input.GetKey("w"))
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                transform.position -= transform.forward * speed * Time.deltaTime;
            }
            Clamp();
        }

        void Clamp()
        {
            pos = transform.position;

            pos.z = Mathf.Clamp(pos.z, -4, 4);

            transform.position = pos;
        }
    }
}