using UnityEngine;

public class SettingsS : MonoBehaviour
{

    public GameObject Setting;
    void Start()
    {
        Setting.SetActive(false);
    }

    public void OpenSettings()
    {
        if(Setting.activeSelf)
        {
            Setting.SetActive(false);
            Shop.inShop = false;
        }else
        {
            Setting.SetActive(true);
            Shop.inShop = true;
        }
    }
}
