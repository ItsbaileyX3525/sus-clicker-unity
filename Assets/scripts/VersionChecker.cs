using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class VersionChecker : MonoBehaviour
{
    private const string CURRENT_VER = "V2.5";
    public static bool correctVersion = true;
    [SerializeField] GameObject loadingScreen;

    private void Start()
    {
        StartCoroutine(CheckVersion());
    }

    private IEnumerator CheckVersion()
    {
        string latestVersionUrl = "https://raw.githubusercontent.com/ItsbaileyX3525/Bailey.github.io/main/SusClickerVersion.txt";

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
                Debug.Log(latestVersion);
                correctVersion = false;
                loadingScreen.SetActive(true);
            }
            else
            {
                Debug.Log("Right version");
                Debug.Log(latestVersion);
                correctVersion = true;
                loadingScreen.SetActive(false);
            }
        }
    }
    public void beanos()
    {
        Application.OpenURL("https://github.com/ItsbaileyX3525/Bailey.github.io/blob/main/sus%20clicker.apk");
    }
}
