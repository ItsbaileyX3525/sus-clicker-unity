using UnityEngine;
using UnityEngine.UI;

public class AdShops : MonoBehaviour
{
    public static bool inAdShop;
    public GameObject Adshop;
    public Image Ad1;
    public Image Ad2;
    public Image Ad3;
    public GameObject SettingsButton;
    public GameObject Leaderboard_Button;
    void Start()
    {
        Adshop.SetActive(false);
        Ad1.transform.position = new Vector3(-1518, 400, 0);
        Ad2.transform.position = new Vector3(-1518, 400, 0);
        Ad3.transform.position = new Vector3(-1518, 400, 0);
    }

    public void OpenShop()
    {
        if(Adshop.activeSelf)
        {
            Adshop.SetActive(false);
            inAdShop = false;
            SettingsButton.SetActive(true);
            Leaderboard_Button.SetActive(true);
            Ad1.transform.position = new Vector3(-1518, 400, 0);
            Ad2.transform.position = new Vector3(-1518, 400, 0);
            Ad3.transform.position = new Vector3(-1518, 400, 0);
        }else
        {
            Adshop.SetActive(true);
            inAdShop = true;
            Leaderboard_Button.SetActive(false);
            SettingsButton.SetActive(false);
            Ad1.transform.position = new Vector3(250, 800, 0);
            Ad2.transform.position = new Vector3(250, 350, 0);
            Ad3.transform.position = new Vector3(800, 800, 0);
        }
    }
}
