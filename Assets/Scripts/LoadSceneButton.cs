using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneButton : MonoBehaviour
{
    void Start()
    {
        Button btn = GetComponent<Button>();
        Button btnNew = GameObject.Find("Button (1)").GetComponent<Button>();
        Button btnExit = GameObject.Find("Button (2)").GetComponent<Button>();
        btn.onClick.AddListener(ContinueGame);
        btnExit.onClick.AddListener(ExitGame);
        btnNew.onClick.AddListener(NewGame);
    }
    void ContinueGame()
    {
        SceneManager.LoadScene("test");
    }
    void ExitGame()
    {
        Application.Quit();
    }
    void NewGame()
    {
        SceneManager.LoadScene("test");
    }
}