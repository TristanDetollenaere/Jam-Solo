using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public string SceneName;
    public GameObject FadeOut;

    public void Onclick()
    {
        StartCoroutine(fade());
    }

    IEnumerator fade()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneName);
    }
}
