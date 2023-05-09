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
        int update1 = PlayerPrefs.GetInt("update4");
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
        sussyPerSecond =  Generate.Taylors*8*GameMultiply.multiplier+Generate.Callums*4*GameMultiply.multiplier+Generate.Greens*2*GameMultiply.multiplier+Generate.Nathaniels*18*GameMultiply.multiplier+Generate.Floppas*1000*GameMultiply.multiplier+Generate.Bingus*5000*GameMultiply.multiplier+Generate.Sauls*20000*GameMultiply.multiplier+Generate.Jesses*30000*GameMultiply.multiplier+Generate.Walters*50000*GameMultiply.multiplier;
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
            uint before = Generate.Greens + Generate.Callums + Generate.Taylors + Generate.Nathaniels + Generate.Floppas + Generate.Bingus;
            clicks += 1 + before * 2 * GameMultiply.multiplier;
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
        Generate.JesseCost,Generate.Jesses,Generate.WalterCost,Generate.Walters, Generate.MordecaiCost,Generate.Mordecais);

        // Convert the instance to JSON and save to file
        string json = JsonUtility.ToJson(data);
        string filePath = Application.persistentDataPath + "/data1.json";
        File.WriteAllText(filePath, json);
    }

    private async void LoadData()
    {
        // Show the loading screen
        loadingScreen.SetActive(true);

        // Load data from file
        string filePath = Application.persistentDataPath + "/data1.json";
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
            Generate.gen1CostPre = data.GreenCost;
            Generate.CallumCostPre = data.CallumCost;
            Generate.TaylorCostPre = data.TaylorCost;
            Generate.NathanielCost = data.NathanielCost;
            Generate.NathanielCostPre = data.NathanielCost;
            Generate.Nathaniels = data.Nathaniels;
            Generate.WilsonCost = data.WilsonCost;
            Generate.WilsonCostPre = data.WilsonCost;
            Generate.Wilsons = data.Wilsons;
            Generate.FloppaCost = data.FloppaCost;
            Generate.FloppaCostPre = data.FloppaCost;
            Generate.Floppas = data.Floppas;
            Generate.BingusCost = data.BingusCost;
            Generate.BingusCostPre = data.BingusCost;
            Generate.Bingus = data.Bingus;
            Generate.SoggaCost = data.SoggaCost;
            Generate.SoggaCostPre = data.SoggaCost;
            Generate.Soggas = data.Soggas;
            Generate.SaulCost = data.SaulCost;
            Generate.SaulCostPre = data.SaulCost;
            Generate.Sauls = data.Sauls;
            Generate.JesseCost = data.JesseCost;
            Generate.JesseCostPre = data.JesseCost;
            Generate.Jesses = data.Jesses;
            Generate.WalterCost = data.WalterCost;
            Generate.WalterCostPre = data.WalterCost;
            Generate.Walters = data.Walters;
            Generate.MordecaiCost = data.MordecaiCost;
            Generate.MordecaiCostPre = data.MordecaiCost;
            Generate.Mordecais = data.Mordecais;
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
        PlayerPrefs.SetInt("update4", update1);
        PlayerPrefs.DeleteKey("updated3");
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