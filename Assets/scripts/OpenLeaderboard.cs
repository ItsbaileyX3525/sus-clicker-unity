using UnityEngine;

public class OpenLeaderboard : MonoBehaviour
{
    public GameObject Leaderboard;

    public void OpenShop()
    {
        if(Leaderboard.activeSelf)
        {
            Leaderboard.SetActive(false);
            Shop.inShop = false;
        }else
        {
            Leaderboard.SetActive(true);
            Shop.inShop = true;
        }
    }
}
