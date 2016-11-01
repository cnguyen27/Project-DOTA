using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    public LoadSceneButton()
    {
        SceneManager.LoadScene("test");
    }
}