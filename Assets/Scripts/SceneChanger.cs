using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void OpenLink(string link)
    {
        Application.OpenURL(link);
    }

}
