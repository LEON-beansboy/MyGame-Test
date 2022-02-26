using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmasherControrler : MonoBehaviour
{
    public float speed = 6.0f;
    private Vector3 pos;
    bool start;

    // Start is called before the first frame update
    private void Start()
    {
        start = false;
    }

    // Update is called once per frame
    //スマッシャーの移動処理
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            start = true;
        }
        if (start)
        {
            if (Input.GetKey("d"))
            {
                transform.position += transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                transform.position -= transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey("w"))
                {
                    transform.position += transform.forward * 9f * Time.deltaTime;
                }
                if (Input.GetKey("s"))
                {
                    transform.position -= transform.forward * 9f * Time.deltaTime;
                }
                if (Input.GetKey("d"))
                {
                    transform.position += transform.right * 9f * Time.deltaTime;
                }
                if (Input.GetKey("a"))
                {
                    transform.position -= transform.right * 9f * Time.deltaTime;
                }
            }
        }
        Clamp();
    }

    void Clamp()
    {
        // プレーヤーの位置情報を「pos」という箱の中に入れる。
        pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -9.0f, 7.0f);
        pos.z = Mathf.Clamp(pos.z, -4.5f, 4.5f);

        transform.position = pos;
    }
}
