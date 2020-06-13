using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nav : MonoBehaviour
{
    private int nextSceneToLoad;

    public void btnW()
    {
        //nextSceneToLoad
        SceneManager.LoadScene(0);
    }
    public void btnG()
    {
        //nextSceneToLoad
        SceneManager.LoadScene(1);
    }
    public void btnE()
    {
        //nextSceneToLoad
        SceneManager.LoadScene(3);
    }
    public void btnH1()
    {
        //nextSceneToLoad
        SceneManager.LoadScene(2);
    }
    public void btnH2()
    {
        //nextSceneToLoad
        SceneManager.LoadScene(2);
    }
    public void btnH3()
    {
        //nextSceneToLoad
        SceneManager.LoadScene(2);
    }
}
