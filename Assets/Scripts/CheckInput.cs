using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckInput : MonoBehaviour
{
    public TMP_Text inputName;
    public TMP_Text inputPassword;

    private string nameSlice;
    private string passSlice;
    public GameObject FadeOut;
    public GameObject FadeIn;

    private void Start()
    {
        StartCoroutine(waiting());
    }

    private void Update()
    {
        nameSlice = inputName.text;
        passSlice = inputPassword.text;
    }

    public void CheckEmptyInput()
    {
        int nameCount = 0;
        int passCount = 0;

        foreach (var node in nameSlice)
        {
            if (Char.IsLetter(node))
            {
                nameCount++;
            }
        }

        foreach (var node in passSlice)
        {
            if (Char.IsLetter(node))
            {
                passCount++;
            }
        }

        if (nameCount != 0 && passCount != 0)
        {
            StartCoroutine(fade());
        }
        else
        {
            Debug.Log("Problème, il y a pas de nom de compte ou de mot de passe !");
        }
    }


    IEnumerator waiting()
    {
        yield return new WaitForSeconds(2);
        FadeIn.SetActive(false);
    }
    IEnumerator fade()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}