using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeController : MonoBehaviour
{
    private GameObject chargeText;

    // Start is called before the first frame update
    void Start()
    {
        this.chargeText = GameObject.Find("ChargeText");
    }

    // Update is called once per frame
    void Update()
    {
        if (SanderCreate.instance.charge == 0)
        {
            this.chargeText.GetComponent<Text>().text = "charge:□　□　□";
        }
        if (SanderCreate.instance.charge == 1)
        {
            this.chargeText.GetComponent<Text>().text = "charge:■　□　□";
        }
        if (SanderCreate.instance.charge == 2)
        {
            this.chargeText.GetComponent<Text>().text = "charge:■　■　□";
        }
        if (SanderCreate.instance.charge >= 3)
        {
            this.chargeText.GetComponent<Text>().text = "charge:■　■　■";
        }

    }
}
