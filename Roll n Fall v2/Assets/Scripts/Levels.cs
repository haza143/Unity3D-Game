 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Gamelvl1");

    }
    public void Level2()
    {
        SceneManager.LoadScene("Gamelvl2");

    }
    public void Level3()
    {
        SceneManager.LoadScene("Gamelvl3");

    }
}
