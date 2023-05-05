using UnityEngine;
public class Codes : MonoBehaviour
{
    private string Input;
    private string Redeemed7;
    private string Redeemed8;
    private string Redeemed9;
    public void InputText(string s)
    {
        Input = s;
        if (Input == "Reset")
        {
            GameEvents.clicks = 0ul;
            GameMultiply.multiplier = 1u;
            GameMultiply.cost = 250ul;
            Generate.gen1Cost = 50.0f;
            Generate.Greens = 0u;
            Generate.gen1CostPre = 50.0f;
            Generate.Taylors = 0u;
            Generate.TaylorCost = 600.0f;
            Generate.TaylorCostPre = 600.0f;            
            Generate.CallumCost = 200.0f;
            Generate.Callums = 0u;
            Generate.CallumCostPre = 200.0f;
            Generate.NathanielCost = 1500.0f;
            Generate.Nathaniels = 0u;
            Generate.NathanielCostPre = 1500.0f;
            Generate.FloppaCost = 1000000.0f;
            Generate.FloppaCostPre = 1000000.0f;
            Generate.Floppas = 0u;
            Generate.BingusCost = 100000000.0f;
            Generate.BingusCostPre = 100000000.0f;
            Generate.Bingus = 0u;
            Generate.SoggaCost = 500000000.0f;
            Generate.SoggaCostPre = 500000000.0f;
            Generate.Soggas = 0u;
            Generate.SaulCost = 2000000000.0f;
            Generate.SaulCostPre = 2000000000.0f;
            Generate.Sauls = 0u;
        }
        if (Input == "BuckleMyShoe" && Redeemed9 != "True")
        {
            GameEvents.clicks += 800000000;
            Generate.WalterCost /= 2;
            Redeemed9 = "true";
            SaveVariables();
        }else if (Input == "AnotherUpdate" && Redeemed7 != "True")
        {
            GameEvents.clicks += 500000000;
            Redeemed7 = "true";
            SaveVariables();
        }else if (Input == "WilsonUpdate" && Redeemed8 != "True")
        {
            GameEvents.clicks += 500000000;
            Redeemed8 = "true";
            SaveVariables();
        }
    }
    void Start()
    {
        LoadVariables();
    }
    public void SaveVariables()
    {
        PlayerPrefs.SetString("RedeemedCodeSix", Redeemed6);
        PlayerPrefs.SetString("RedeemedCodeSeven", Redeemed7);
        PlayerPrefs.SetString("RedeemedCodeEight", Redeemed8);
    }
    void LoadVariables()
    {
        PlayerPrefs.DeleteKey("RedeemedCodeSix");
        string CodeSeven = PlayerPrefs.GetString("RedeemedCodeSeven");
        string CodeEight = PlayerPrefs.GetString("RedeemedCodeEight");
        string CodeNine = PlayerPrefs.GetString("RedeemedCodeNine");
        Redeemed7 = CodeSeven;
        Redeemed8 = CodeEight;
        Redeemed9 = CodeNine;
    }
}
