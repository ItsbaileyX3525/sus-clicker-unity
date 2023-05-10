using UnityEngine;
public class Codes : MonoBehaviour
{
    private string Input;
    private string Redeemed8;
    private string Redeemed9;
    private string Redeemed10;
    public void InputText(string s)
    {
        Input = s;
        if (Input == "Reset")
        {
            GameEvents.clicks = 0ul;
            GameMultiply.multiplier = 1u;
            GameMultiply.cost = 250ul;
            Generate.gen1Cost = 50ul;
            Generate.Greens = 0u;
            Generate.Taylors = 0u;
            Generate.TaylorCost = 600ul;
            Generate.CallumCost = 200ul;
            Generate.Callums = 0u;
            Generate.NathanielCost = 1500ul;
            Generate.Nathaniels = 0u;
            Generate.FloppaCost = 1000000ul;
            Generate.Floppas = 0u;
            Generate.BingusCost = 100000000ul;
            Generate.Bingus = 0u;
            Generate.SoggaCost = 500000000ul;
            Generate.Soggas = 0u;
            Generate.SaulCost = 2000000000ul;
            Generate.Sauls = 0u;
        }
        if (Input == "BigHugeUpdate" && Redeemed10 != "True")
        {
            GameEvents.clicks += 1000000;
            Redeemed10 = "True";
            SaveVariables();
        }
    }
    void Start()
    {
        LoadVariables();
    }
    public void SaveVariables()
    {
        PlayerPrefs.SetString("RedeemedCodeTen", Redeemed10);
    }
    void LoadVariables()
    {
        PlayerPrefs.DeleteKey("RedeemedCodeSeven");
        PlayerPrefs.DeleteKey("RedeemedCodeEight");
        PlayerPrefs.DeleteKey("RedeemedCodeNine");
        string CodeTen = PlayerPrefs.GetString("RedeemedCodeTen");
        Redeemed10 = CodeTen;
    }
}
