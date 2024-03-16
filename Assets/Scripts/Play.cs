using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public void startPlay()
    {
        Debug.Log("started new level");
        SceneManager.LoadScene("Level01");
    }

}
