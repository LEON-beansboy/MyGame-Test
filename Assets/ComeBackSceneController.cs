using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComeBackSceneController : MonoBehaviour
{
    public void GoToTitle()
    {
        SceneManager.LoadScene("TiteleScene");
    }
}
