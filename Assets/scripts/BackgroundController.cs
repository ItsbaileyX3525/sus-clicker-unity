using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] GameObject Animated;
    [SerializeField] GameObject Colour;
    private string Enabled;
    public void on_click()
    {
        if(Animated.activeSelf)
        {
            Colour.SetActive(true);
            Animated.SetActive(false);
            PlayerPrefs.SetString("Background", "true");
        }else
        {
            Colour.SetActive(false);
            Animated.SetActive(true);
            PlayerPrefs.SetString("Background", "false");
        }
    }
    void Start()
    {
        Enabled = PlayerPrefs.GetString("Background");
        if(Enabled == "true")
        {
            Colour.SetActive(true);
            Animated.SetActive(false);
        }else
        {
            Colour.SetActive(false);
            Animated.SetActive(true);
        }
    }
}
