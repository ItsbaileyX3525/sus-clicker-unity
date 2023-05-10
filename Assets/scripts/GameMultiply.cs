using UnityEngine;
using TMPro;

public class GameMultiply : MonoBehaviour
{
    [SerializeField] TMP_Text Gen1;
    [SerializeField] TMP_Text susMultiply;
    [SerializeField] TMP_Text multiplierText;
    [SerializeField] TMP_Text Gen2;
    [SerializeField] TMP_Text Gen3;
    [SerializeField] TMP_Text Gen4;
    [SerializeField] TMP_Text Gen5;
    [SerializeField] TMP_Text GenFloppa;
    [SerializeField] TMP_Text GenBingus;
    [SerializeField] TMP_Text GenSogga;
    [SerializeField] TMP_Text GenSaul;
    [SerializeField] TMP_Text GenJesse;
    [SerializeField] TMP_Text GenWalter;
    [SerializeField] TMP_Text GenMordecai;
    [SerializeField] TMP_Text GenRigby;
    [SerializeField] TMP_Text GenBenson;
    [SerializeField] TMP_Text GenMM;
    public static uint multiplier;
    public static bool Prestiging = false;
    public static ulong cost = 250ul;

    public void onClick()
    {
        if(!Shop.inShop && !AdShops.inAdShop && GameEvents.clicks >= cost)
        {

            GameEvents.clicks = 0;
            multiplier++;
            cost *= 2;
        }
    }
public static string FormatNumberWithAbbreviation(double number)
{
    string abbreviation = "";
    double formattedNumber = number;

    if (number >= 1000000000000000000UL) // more than or equal to 1 quintillion
    {
        formattedNumber = number / 1000000000000000000d;
        abbreviation = "E";
    }
    else if (number >= 1000000000000000UL) // more than or equal to 1 quadrillion
    {
        formattedNumber = number / 1000000000000000d;
        abbreviation = "P";
    }
    else if (number >= 1000000000000UL) // more than or equal to 1 trillion
    {
        formattedNumber = number / 1000000000000d;
        abbreviation = "T";
    }
    else if (number >= 1000000000UL) // more than or equal to 1 billion
    {
        formattedNumber = number / 1000000000d;
        abbreviation = "B";
    }
    else if (number >= 1000000UL) // more than or equal to 1 million
    {
        formattedNumber = number / 1000000d;
        abbreviation = "M";
    }
    else if (number >= 1000UL) // more than or equal to 1 thousand
    {
        formattedNumber = number / 1000d;
        abbreviation = "K";
    }

    return string.Format("{0:#.#}{1}", formattedNumber, abbreviation);
}

    void Update()
    {
        string formattedGen1Cost = FormatNumberWithAbbreviation(Generate.gen1Cost);
        string formattedCallumCost = FormatNumberWithAbbreviation(Generate.CallumCost);
        string formattedTaylorCost = FormatNumberWithAbbreviation(Generate.TaylorCost);
        string formattedNathanielCost = FormatNumberWithAbbreviation(Generate.NathanielCost);
        string formattedWilsonCost = FormatNumberWithAbbreviation(Generate.WilsonCost);
        string formattedFloppaCost = FormatNumberWithAbbreviation(Generate.FloppaCost);
        string formattedBingusCost = FormatNumberWithAbbreviation(Generate.BingusCost);
        string fromattedSoggaCost = FormatNumberWithAbbreviation(Generate.SoggaCost);
        string fromattedSaulCost = FormatNumberWithAbbreviation(Generate.SaulCost);
        string fromattedJesseCost = FormatNumberWithAbbreviation(Generate.JesseCost);
        string fromattedWalterCost = FormatNumberWithAbbreviation(Generate.WalterCost);
        string fromattedMordecaiCost = FormatNumberWithAbbreviation(Generate.MordecaiCost);
        string fromattedRigbyCost = FormatNumberWithAbbreviation(Generate.RigbyCost);
        string fromattedBensonCost = FormatNumberWithAbbreviation(Generate.BensonCost);
        string fromattedMMCost = FormatNumberWithAbbreviation(Generate.MMCost);
        string formattedPrestigeCost = FormatNumberWithAbbreviation(cost);

        susMultiply.text = "Prestige cost: " + formattedPrestigeCost;
        multiplierText.text = "Multiplier: " + multiplier+"x";
        Gen1.text = "Cost: " + formattedGen1Cost;
        Gen2.text = "Cost: " + formattedCallumCost;
        Gen3.text = "Cost: " + formattedTaylorCost;
        Gen4.text = "Cost: " + formattedNathanielCost;
        Gen5.text = "Cost: " + formattedWilsonCost;
        GenFloppa.text = "Cost: " + formattedFloppaCost;
        GenBingus.text = "Cost: " + formattedBingusCost;
        GenSogga.text = "Cost: " + fromattedSoggaCost;
        GenSaul.text = "Cost: " + fromattedSaulCost;
        GenJesse.text = "Cost: " + fromattedJesseCost;
        GenWalter.text = "Cost: " + fromattedWalterCost;
        GenMordecai.text = "Cost: " + fromattedMordecaiCost;
        GenRigby.text = "Cost: " + fromattedRigbyCost;
        GenBenson.text = "Cost: " + fromattedBensonCost;
        GenMM.text = "Cost: " + fromattedMMCost;
        if (cost == 0)
        {
            cost = 250;
        }
        if (multiplier == 0)
        {
            multiplier = 1;
        }
    }
    
}
