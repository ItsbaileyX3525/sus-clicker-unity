using System.Collections;
using System;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public static float gen1Cost = 50.0f;
    public static uint Greens = 0u;
    public static float gen1CostPre = 50.0f;
    public static float CallumCost = 200.0f;
    public static uint Callums = 0u;
    public static float CallumCostPre = 200.0f;
    public static float TaylorCost = 600.0f;
    public static uint Taylors = 0u;
    public static float TaylorCostPre = 600.0f;
    public static float NathanielCost = 1500.0f;
    public static uint Nathaniels = 0u;
    public static float NathanielCostPre = 1500.0f;
    public static float WilsonCost = 5000.0f;
    public static uint Wilsons = 0u;
    public static float WilsonCostPre = 5000.0f;
    public static float FloppaCost = 1000000.0f;
    public static uint Floppas = 0u;
    public static float FloppaCostPre = 1000000.0f;
    public static float BingusCost = 100000000.0f;
    public static uint Bingus = 0u;
    public static float BingusCostPre = 100000000.0f;
    public static float SoggaCost = 500000000.0f;
    public static uint Soggas = 0u;
    public static float SoggaCostPre = 500000000.0f;
    public static float SaulCost = 2000000000.0f;
    public static uint Sauls = 0u;
    public static float SaulCostPre = 2000000000.0f;
    public static float JesseCost = 5000000000.0f;
    public static uint Jesses = 0u;
    public static float JesseCostPre = 5000000000.0f;
    public static float WalterCost = 10000000000.0f;
    public static uint Walters = 0u;
    public static float WalterCostPre = 10000000000.0f;

    void Start()
    {
        StartCoroutine(IncrementCountCoroutine());
    }
    void Update()
    {
        if (gen1Cost == 0.0f || Greens == 0)
        {
            gen1Cost = 50.0f;
            Greens = 0u;
            gen1CostPre = 50.0f;
        }
        if (CallumCost == 0.0f || Callums == 0)
        {
            CallumCost = 200.0f;
            Callums = 0u;
            CallumCostPre = 200.0f;
        }
        if (TaylorCost == 0.0f || Taylors == 0)
        {
            TaylorCost = 600.0f;
            Taylors = 0u;
            TaylorCostPre = 600.0f;
        }
        if (NathanielCost == 0.0f || Nathaniels == 0)
        {
            NathanielCost = 1500.0f;
            Nathaniels = 0u;
            NathanielCostPre = 1500.0f;
        }
        if (WilsonCost == 0.0f || Wilsons == 0)
        {
            WilsonCost = 1500.0f;
            Wilsons = 0u;
            WilsonCostPre = 1500.0f;
        }
        if (FloppaCost == 0.0f || Floppas == 0)
        {
            FloppaCost = 1000000.0f;
            Floppas = 0u;
            FloppaCostPre = 1000000.0f;
        }
        if (BingusCost == 0.0f || Bingus == 0)
        {
            BingusCost = 100000000.0f;
            Bingus = 0u;
            BingusCostPre = 100000000.0f;
        }
        if (SoggaCost == 0.0f || Soggas == 0)
        {
            SoggaCost = 500000000.0f;
            Soggas = 0u;
            SoggaCostPre = 500000000.0f;
        }
        if (SaulCost == 0.0f || Sauls == 0)
        {
            SaulCost = 2000000000.0f;
            Sauls = 0u;
            SaulCostPre = 2000000000.0f;
        }
        if (JesseCost == 0.0f || Jesses == 0)
        {
            JesseCost = 5000000000.0f;
            Jesses = 0u;
            JesseCostPre = 5000000000.0f;
        }
        if (WalterCost == 0.0f || Walters == 0)
        {
            WalterCost = 10000000000.0f;
            Walters = 0u;
            WalterCostPre = 10000000000.0f;
        }
    }
    public void onClickGreens()
    {
        if (GameEvents.clicks >= gen1Cost)
        {
            GameEvents.clicks -= (ulong)gen1Cost;
            gen1CostPre *= 1.1f;
            gen1Cost = (ulong)Math.Round(gen1CostPre);
            Greens++;
        }
    }
    public void onClickCallums()
    {
        if (GameEvents.clicks >= CallumCost)
        {
            GameEvents.clicks -= (ulong)CallumCost;
            CallumCostPre *= 1.1f;
            CallumCost = (ulong)Math.Round(CallumCostPre);
            Callums++;
        }
    }
    public void onClickTaylors()
    {
        if (GameEvents.clicks >= TaylorCost)
        {
            GameEvents.clicks -= (ulong)TaylorCost;
            TaylorCostPre *= 1.1f;
            TaylorCost = (ulong)Math.Round(TaylorCostPre);
            Taylors++;
        }
    }
    public void onClickNathaniels()
    {
        if (GameEvents.clicks >= NathanielCost)
        {
            GameEvents.clicks -= (ulong)NathanielCost;
            NathanielCostPre *= 1.1f;
            NathanielCost = (ulong)Math.Round(NathanielCostPre);
            Nathaniels++;
        }
    }
    public void onClickWilsons()
    {
        if (GameEvents.clicks >= WilsonCost)
        {
            GameEvents.clicks -= (ulong)WilsonCost;
            WilsonCostPre *= 1.1f;
            WilsonCost = (ulong)Math.Round(WilsonCostPre);
            Wilsons++;
        }
    }
    public void onClickFloppas()
    {
        if (GameEvents.clicks >= FloppaCost)
        {
            GameEvents.clicks -= (ulong)FloppaCost;
            FloppaCostPre *= 1.1f;
            FloppaCost = (ulong)Math.Round(FloppaCostPre);
            Floppas++;
        }
    }
    public void onClickBingus()
    {
        if (GameEvents.clicks >= BingusCost)
        {
            GameEvents.clicks -= (ulong)BingusCost;
            BingusCostPre *= 1.1f;
            BingusCost = (ulong)Math.Round(BingusCostPre);
            Bingus++;
        }
    }
    public void onClickSogga()
    {
        if (GameEvents.clicks >= SoggaCost)
        {
            GameEvents.clicks -= (ulong)SoggaCost;
            SoggaCostPre *= 1.1f;
            SoggaCost = (ulong)Math.Round(SoggaCostPre);
            Soggas++;
        }
    }
    public void onClickSaul()
    {
        if (GameEvents.clicks >= SaulCost)
        {
            GameEvents.clicks -= (ulong)SaulCost;
            SaulCostPre *= 1.1f;
            SaulCost = (ulong)Math.Round(SaulCostPre);
            Sauls++;
        }
    }
    public void onClickJesse()
    {
        if (GameEvents.clicks >= JesseCost)
        {
            GameEvents.clicks -= (ulong)JesseCost;
            JesseCostPre *= 1.1f;
            JesseCost = (ulong)Math.Round(JesseCostPre);
            Jesses++;
        }
    }
    public void onClickWalter()
    {
        if (GameEvents.clicks >= WalterCost)
        {
            GameEvents.clicks -= (ulong)WalterCost;
            WalterCostPre *= 1.1f;
            WalterCost = (ulong)Math.Round(WalterCostPre);
            Walters++;
        }
    }
    public static IEnumerator IncrementCountCoroutine()
    {
        while (true)
        {
            ulong amount1 = Greens * 2;
            GameEvents.clicks += amount1 * GameMultiply.multiplier;
            ulong amount2 = Callums * 4;
            GameEvents.clicks += amount2 * GameMultiply.multiplier;
            ulong amount3 = Taylors * 8;
            GameEvents.clicks += amount3 * GameMultiply.multiplier;
            ulong amount4 = Nathaniels * 18;
            GameEvents.clicks += amount4 * GameMultiply.multiplier;
            ulong amount5 = Wilsons * 45;
            GameEvents.clicks += amount5 * GameMultiply.multiplier;
            ulong amount6 = Floppas * 1000;
            GameEvents.clicks += amount6 * GameMultiply.multiplier;
            ulong amount7 = Bingus * 5000;
            GameEvents.clicks += amount7 * GameMultiply.multiplier;
            ulong amount8 = Soggas * 12000;
            GameEvents.clicks += amount8 * GameMultiply.multiplier;
            ulong amount9 = Sauls * 20000;
            GameEvents.clicks += amount9 * GameMultiply.multiplier;
            ulong amount10 = Jesses * 30000;
            GameEvents.clicks += amount10 * GameMultiply.multiplier;
            ulong amount11 = Walters * 50000;
            GameEvents.clicks += amount11 * GameMultiply.multiplier;
            if (GameEvents.genFrezyActive){
                yield return new WaitForSeconds(0.5f);
            }else{
                yield return new WaitForSeconds(1);
            }
            
        }
    }
}
