using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class NextLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    string strSceneName;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            //int lvl = Int32.Parse(strSceneName.Substring(strSceneName.Length - 1));
            //lvl++;
            //SceneManager.LoadScene(strSceneName.Remove(strSceneName.Length - 1, 1) + lvl.ToString());
            SceneManager.LoadScene(strSceneName);
        }
    }
           
}
