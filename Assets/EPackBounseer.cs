using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPackBounseer : MonoBehaviour
{
    public float speed = 6;

    private Vector3 pos;

    bool One;

    // Start is called before the first frame update
    void Start()
    {
        One = true;

        if (One)
        {
            var force = (transform.forward + transform.right) * 3.5f;

            GetComponent<Rigidbody>().AddForce(force, ForceMode.VelocityChange);

            One = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
