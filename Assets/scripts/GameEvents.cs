using System.Threading.Tasks;
using System.IO;
using System.Collections;
using UnityEngine;
using TMPro;

public class GameEvents : MonoBehaviour
{
    public static ulong clicks = 0ul;
    [SerializeField] GameObject loadingScreen;
    [SerializeField] TMP_Text susText;
    [SerializeField] TMP_Text SPS;
    [SerializeField] AudioSource ClickSound;
    private ulong sussyPerSecond;
    [SerializeField] GameObject closeUpdateLog;
    [SerializeField] AudioClip audioClip;
    public static bool genFrezyActive = false;
    public static bool genFrezyActiveF = false;
    private int update1 = 0;
    void Start()
    {
        ClickSound = GetComponent<AudioSource>();
        LoadData();
        susText.text = "Suses: " + clicks;
        int update1 = PlayerPrefs.GetInt("update5");
        if (update1 != 1)
        {
            OpenLog();
        }
    }

    // Update is called once per frame
    void Update()
    {
        string clicksFormatted = GameMultiply.FormatNumberWithAbbreviation(clicks);
        susText.text = "Suses: " + clicksFormatted;
        sussyPerSecond =  Generate.Greens * 2 + Generate.Callums * 5 + Generate.Taylors * 12 + Generate.Nathaniels * 25 + Generate.Wilsons * 60 + Generate.Floppas * 130 + Generate.Bingus * 250 + Generate.Soggas * 520 + Generate.Sauls * 1050 + Generate.Jesses * 2200 + Generate.Walters * 4500 + Generate.Mordecais * 9200;
        sussyPerSecond *= GameMultiply.multiplier;
        string FormattedSps = GameMultiply.FormatNumberWithAbbreviation(sussyPerSecond);
        SPS.text = "Suses p/s: " + FormattedSps;
        SaveData();
        if (genFrezyActiveF && genFrezyActive)
        {
            StartCoroutine(DoSomethingAfterDelay());
            genFrezyActiveF = false;
        }
    }
    private IEnumerator DoSomethingAfterDelay()
    {
        yield return new WaitForSeconds(30);
        genFrezyActive = false;
    }
    public void onClick()
    {
        if(!Shop.inShop && !AdShops.inAdShop)
        {
            uint before = Generate.Greens + Generate.Callums + Generate.Taylors + Generate.Nathaniels + Generate.Wilsons + Generate.Floppas + Generate.Bingus + Generate.Soggas + Generate.Sauls + Generate.Jesses + Generate.Walters + Generate.Mordecais + Generate.Rigbys + Generate.Bensons + Generate.MMs;
            clicks += 1 + before * GameMultiply.multiplier;
            audioClip = ClickSound.clip;
            ClickSound.PlayOneShot(audioClip);
        }
    }

    private void SaveData()
    {
        // Create an instance of DataSave and assign the values of clicks and closedUpdateLog
        DataSave data = new DataSave(clicks, GameMultiply.multiplier, GameMultiply.cost,
        Generate.Greens, Generate.Callums, Generate.Taylors, Generate.gen1Cost, Generate.CallumCost, Generate.TaylorCost,
        Generate.Nathaniels, Generate.NathanielCost, Generate.Wilsons, Generate.WilsonCost, 
        Generate.FloppaCost,Generate.Floppas, Generate.BingusCost,Generate.Bingus,
        Generate.SoggaCost,Generate.Soggas,Generate.SaulCost,Generate.Sauls,
        Generate.JesseCost,Generate.Jesses,Generate.WalterCost,Generate.Walters, Generate.MordecaiCost,Generate.Mordecais,
        Generate.RigbyCost,Generate.Rigbys,Generate.BensonCost,Generate.Bensons,Generate.MMCost,Generate.MMs);

        // Convert the instance to JSON and save to file
        string json = JsonUtility.ToJson(data);
        string filePath = Application.persistentDataPath + "/data2.json";
        File.WriteAllText(filePath, json);
    }

    private async void LoadData()
    {
        // Show the loading screen
        loadingScreen.SetActive(true);

        // Load data from file
        string filePath = Application.persistentDataPath + "/data2.json";
        if (File.Exists(filePath))
        {
            string json = await Task.Run(() => File.ReadAllText(filePath));

            // Convert the JSON to an instance of DataSave and assign the values of clicks and closedUpdateLog
            DataSave data = JsonUtility.FromJson<DataSave>(json);
            clicks = data.suses;
            GameMultiply.multiplier = data.multiplier;
            GameMultiply.cost = data.multiplierCost;
            Generate.Greens = data.Greens;
            Generate.Callums = data.Callums;
            Generate.Taylors = data.Taylors;
            Generate.gen1Cost = data.GreenCost;
            Generate.CallumCost = data.CallumCost;
            Generate.TaylorCost = data.TaylorCost;
            Generate.NathanielCost = data.NathanielCost;
            Generate.Nathaniels = data.Nathaniels;
            Generate.WilsonCost = data.WilsonCost;
            Generate.Wilsons = data.Wilsons;
            Generate.FloppaCost = data.FloppaCost;
            Generate.Floppas = data.Floppas;
            Generate.BingusCost = data.BingusCost;
            Generate.Bingus = data.Bingus;
            Generate.SoggaCost = data.SoggaCost;
            Generate.Soggas = data.Soggas;
            Generate.SaulCost = data.SaulCost;
            Generate.Sauls = data.Sauls;
            Generate.JesseCost = data.JesseCost;
            Generate.Jesses = data.Jesses;
            Generate.WalterCost = data.WalterCost;
            Generate.Walters = data.Walters;
            Generate.MordecaiCost = data.MordecaiCost;
            Generate.Mordecais = data.Mordecais;
            Generate.RigbyCost = data.RigbyCost;
            Generate.Rigbys = data.Rigbys;
            Generate.BensonCost = data.BensonCost;
            Generate.Bensons = data.Bensons;
            Generate.MMCost = data.MMCost;
            Generate.MMs = data.MMs;
        }
        if (VersionChecker.correctVersion)
        {
        loadingScreen.SetActive(false);
        }else
        {
            ;
        }
    }
    public void CloseLog()
    {
        closeUpdateLog.SetActive(false);
        update1=1;
        PlayerPrefs.SetInt("update5", update1);
        PlayerPrefs.DeleteKey("updated4");
    }
    public void OpenLog()
    {
        closeUpdateLog.SetActive(true);
    }
    public void SkipLoading()
    {
        loadingScreen.SetActive(false);
    }
}
// delete a playerPref with PlayerPrefs.DeleteKey("myKey");do this every update.