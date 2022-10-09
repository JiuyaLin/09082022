using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class scr_loadScene : MonoBehaviour
{
    public string toLoad;

    public void ChangeScene()
    {
        SceneManager.LoadScene(toLoad);
    }
}
