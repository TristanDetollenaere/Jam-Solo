using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNoFade : MonoBehaviour
{
    public string SceneName;

    public void Onclick()
    {
        SceneManager.LoadScene(SceneName);
    }
}
