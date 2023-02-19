using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panel : MonoBehaviour
{
    public void EnableGame()
    {
        SceneManager.LoadScene("Bopeyes");
    }
}
