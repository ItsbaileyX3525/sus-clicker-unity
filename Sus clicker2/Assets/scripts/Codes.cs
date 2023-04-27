using UnityEngine;
public class Codes : MonoBehaviour
{
    private string Input;
    private string Redeemed5;
    private string Redeemed6;
    private string Redeemed7;
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
        }else if (Input == "BigUpdateBoys" && Redeemed5 != "True")
        {
            GameEvents.clicks += 3500000;
            Generate.FloppaCost -= 10000000.0f;
            SaveVariables();
        }else if (Input == "SorryForBugs")
        {
            GameEvents.clicks += 5000000;
            Generate.SoggaCost /= 2;
            SaveVariables();
        }else if (Input == "AnotherUpdate")
        {
            GameEvents.clicks += 500000000;
            SaveVariables();
        }
    }
    void Start()
    {
        LoadVariables();
    }
    public void SaveVariables()
    {
        PlayerPrefs.SetString("RedeemedCodeFive", Redeemed5);
        PlayerPrefs.SetString("RedeemedCodeSix", Redeemed6);
        PlayerPrefs.SetString("RedeemedCodeSeven", Redeemed7);
    }
    void LoadVariables()
    {
        PlayerPrefs.DeleteKey("RedeemedCodeThree");
        string CodeFive = PlayerPrefs.GetString("RedeemedCodeFive");
        string CodeSix = PlayerPrefs.GetString("RedeemedCodeSix");
        string CodeSeven = PlayerPrefs.GetString("RedeemedCodeSeven");
        Redeemed5 = CodeFive;
        Redeemed6 = CodeSix;
        Redeemed7 = CodeSeven;
    }
}
