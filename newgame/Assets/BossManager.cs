using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossManager : MonoBehaviour
{
	
	public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        dead=false;
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
