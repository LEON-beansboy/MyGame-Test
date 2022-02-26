using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanderCreate : MonoBehaviour
{
    public AudioClip sound1;

    public AudioClip sound2;

    AudioSource myaudio;

    AudioSource maudio;

    public static SanderCreate instance;

    Vector3 hitPos;

    public int score;

    float lazerDistance = 10f;
    float lazerStartPointDistance = 0.15f;
    float lineWidth = 0.01f;

    public GameObject targetObject; // 注視したいオブジェクトを事前にInspectorから入れておく

    public GameObject lineRenderer;

    public GameObject Sander;

    public int charge = 0;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        this.Sander = GameObject.Find("Sander");

        myaudio = GetComponent<AudioSource>();

        maudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(targetObject.transform);

        GameObject EPack = GameObject.Find("EPack");

        

        if (charge >= 3)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("放電！");

                myaudio.PlayOneShot(sound2);

                float lazerDistance = 10f;
                Vector3 direction = transform.forward * lazerDistance;
                Vector3 rayStartPosition = transform.forward * lazerStartPointDistance;
                Vector3 pos = transform.position;

                RaycastHit hit;

                Ray R = new Ray(transform.position, transform.forward);

                GameObject Sunder = Instantiate(Sander, pos + rayStartPosition, Quaternion.identity) as GameObject;

                LineRenderer line = Sunder.GetComponent<LineRenderer>();

                line.SetPosition(0, pos + rayStartPosition);

                if (Physics.Raycast(R, out hit, lazerDistance))
                {
                    hitPos = hit.point;

                    line.SetPosition(1, hitPos);
                }

                foreach (RaycastHit hit1 in Physics.RaycastAll(R))
                {
                    if (Physics.Raycast(R, out hit))
                    {
                        if (hit.collider.CompareTag("EPack"))
                        {
                            myaudio.PlayOneShot(sound1);

                            Destroy(hit.collider.gameObject);

                            score++;
                        }
                    }
                }

                Invoke("charge0",2);

                Destroy(Sunder,2.0f);
            }
        }
    }

    public void charge0()
    {
        charge = 0;
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Smasher")
        {
            charge++;

            Debug.Log("チャージ " + charge);
        }
    }
}
