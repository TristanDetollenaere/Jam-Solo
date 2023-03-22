using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class GenerateBackground : MonoBehaviour
{
    public List<Sprite> Backgrounds;
    [SerializeField] private Image _image;

    private void Start()
    {
        Random rnd = new Random();
        int nb = rnd.Next(0, Backgrounds.Count);
        _image.sprite = Backgrounds[nb];
    }
}