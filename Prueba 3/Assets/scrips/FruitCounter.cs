using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitCounter : MonoBehaviour
{
    public int sceneTag;
    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            SceneManager.LoadScene(sceneTag);
        }
    }
}
