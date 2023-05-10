using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class VersionChecker : MonoBehaviour
{
    private const string CURRENT_VER = "V2.5.2";
    public static bool correctVersion = true;
    [SerializeField] GameObject loadingScreen;

    private void Start()
    {
        StartCoroutine(CheckVersion());
    }

    private IEnumerator CheckVersion()
    {
        string latestVersionUrl = "https://raw.githubusercontent.com/ItsbaileyX3525/sus-clicker-unity/main/SusClickerVersion.txt";

        UnityWebRequest request = UnityWebRequest.Get(latestVersionUrl);

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("Failed to send latest version request: " + request.error);
        }
        else
        {
            string latestVersion = request.downloadHandler.text.Trim();

            if (CURRENT_VER != latestVersion)
            {
                Debug.Log("Wrong version");
                correctVersion = false;
                loadingScreen.SetActive(true);
            }
            else
            {
                Debug.Log("Right version");
                correctVersion = true;
                loadingScreen.SetActive(false);
            }Debug.Log(latestVersion);
        }
    }
    public void beanos()
    {
        Application.OpenURL("https://baileyswebsite.ddns.net/Download");
    }
}
