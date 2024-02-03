using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [ContextMenu("Next")]
    public void Next()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        int next = current + 1;

        SceneManager.LoadScene(next, LoadSceneMode.Single);
    }

    [ContextMenu("Back")]
    public void Back()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        int back = current - 1;

        SceneManager.LoadScene(back, LoadSceneMode.Single);
    }
}
