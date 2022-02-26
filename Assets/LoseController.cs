using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EPack")
        {
            SceneManager.LoadScene("LoseScene");

            Debug.Log("GameOver");
        }
    }
}