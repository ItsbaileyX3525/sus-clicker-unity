using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public static bool inShop;
    [SerializeField] GameObject shopSelection;
    [SerializeField] TMP_Text ShopText;
    [SerializeField] GameObject susShop;
    [SerializeField] GameObject AdShop;
    [SerializeField] GameObject Leaderboard_button;
    [SerializeField] GameObject memeShop;
    [SerializeField] GameObject breakingBadShop;
    void Start()
    {
        shopSelection.SetActive(false);
        memeShop.SetActive(false);
        breakingBadShop.SetActive(false);
    }

    public void OpenShop()
    {
        if(shopSelection.activeSelf)
        {
            shopSelection.SetActive(false);
            inShop = false;
            AdShop.SetActive(true);
            Leaderboard_button.SetActive(true);
        }else
        {
            shopSelection.SetActive(true);
            inShop = true;
            AdShop.SetActive(false);
            Leaderboard_button.SetActive(false);
        }
    }
    public void OpenSusShop()
    {
        if(susShop.activeSelf)
        {
            shopSelection.SetActive(true);
            susShop.SetActive(false);
        }else
        {
            susShop.SetActive(true);
            shopSelection.SetActive(false);
        }
    }
    public void OpenMemeShop()
    {
        if(memeShop.activeSelf)
        {
            shopSelection.SetActive(true);
            memeShop.SetActive(false);
        }else
        {
            memeShop.SetActive(true);
            shopSelection.SetActive(false);
        }
    }
    public void OpenBreakingBadShop()
    {
        if(breakingBadShop.activeSelf)
        {
            breakingBadShop.SetActive(false);
            shopSelection.SetActive(true);
        }else
        {
            breakingBadShop.SetActive(true);
            shopSelection.SetActive(false);
        }
    }
}
