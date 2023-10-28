using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenuButton : MonoBehaviour
{
    public void SceneOptions()
    {
        SceneManager.LoadScene(3);
    }

    public void SceneMain()
    {
        SceneManager.LoadScene(0);
    }

    public void SceneGameMenu()
    {
        SceneManager.LoadScene(5);
    }

    public void SceneLevelsMenu()
    {
        SceneManager.LoadScene(4);
    }

    public void SceneShop()
    {
        SceneManager.LoadScene(6);
    }
}
