using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPackCreate : MonoBehaviour
{
    public GameObject EPackPrefab;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("CreatePack", 0, 40);
    }

    void CreatePack()
    {
        Debug.Log("ê∂ê¨");

        //EPackPreefabÇ©ÇÁEPackÇê∂ê¨
        GameObject EPack = Instantiate(EPackPrefab);

        EPack.transform.position = new Vector3(-9.221f, 6.029f, -0.21f);
    }
}
