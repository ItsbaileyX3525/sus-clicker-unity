using System.Collections;
using System;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public static ulong gen1Cost = 50ul;
    public static uint Greens = 0u;
    public static ulong CallumCost = 150ul;
    public static uint Callums = 0u;
    public static ulong TaylorCost = 300ul;
    public static uint Taylors = 0u;
    public static ulong NathanielCost = 800ul;
    public static uint Nathaniels = 0u;
    public static ulong WilsonCost = 2000ul;
    public static uint Wilsons = 0u;
    public static ulong FloppaCost = 5000ul;
    public static uint Floppas = 0u;
    public static ulong BingusCost = 12000ul;
    public static uint Bingus = 0u;
    public static ulong SoggaCost = 30000ul;
    public static uint Soggas = 0u;
    public static ulong SaulCost = 80000ul;
    public static uint Sauls = 0u;
    public static ulong JesseCost = 200000ul;
    public static uint Jesses = 0u;
    public static ulong WalterCost = 500000ul;
    public static uint Walters = 0u;
    public static ulong MordecaiCost = 1200000ul;
    public static uint Mordecais = 0u;
    public static ulong RigbyCost = 3000000ul;
    public static uint Rigbys = 0u;
    public static ulong BensonCost = 7500000ul;
    public static uint Bensons = 0u;
    public static ulong MMCost = 19000000ul;
    public static uint MMs = 0u;

    void Start()
    {
        StartCoroutine(IncrementCountCoroutine());
    }
    void Update()
    {
        
        if (gen1Cost == 0ul || Greens == 0u) {
            gen1Cost = 50ul;
            Greens = 0u;
        }if (CallumCost == 0ul || Callums == 0u) {
            CallumCost = 150ul;
            Callums = 0u;
        }if (TaylorCost == 0ul || Taylors == 0u) {
            TaylorCost = 300ul;
            Taylors = 0u;
        }if (NathanielCost == 0ul || Nathaniels == 0u) {
            NathanielCost = 800ul;
            Nathaniels = 0u;
        }if (WilsonCost == 0ul || Wilsons == 0u) {
            WilsonCost = 2000ul;
            Wilsons = 0u;
        }if (FloppaCost == 0ul || Floppas == 0u) {
            FloppaCost = 5000ul;
            Floppas = 0u;
        }if (BingusCost == 0ul || Bingus == 0u) {
            BingusCost = 12000ul;
            Bingus = 0u;
        }if (SoggaCost == 0ul || Soggas == 0u) {
            SoggaCost = 30000ul;
            Soggas = 0u;
        }if (SaulCost == 0ul || Sauls == 0u) {
            SaulCost = 80000ul;
            Sauls = 0u;
        }if (JesseCost == 0ul || Jesses == 0u) {
            JesseCost = 200000ul;
            Jesses = 0u;
        }if (WalterCost == 0ul || Walters == 0u) {
            WalterCost = 500000ul;
            Walters = 0u;
        }if (MordecaiCost == 0ul || Mordecais == 0u) {
            MordecaiCost = 1200000ul;
            Mordecais = 0u;
        } if (BensonCost == 0ul || Bensons == 0u) {
            BensonCost = 7500000ul;
            Bensons = 0u;
        } if (MMCost == 0ul || MMs == 0u) {
            MMCost = 19000000ul;
            MMs = 0u;
        } if (RigbyCost == 0ul || Rigbys == 0u){
            RigbyCost = 3000000ul;
            Rigbys = 0u;
        }
        
    }
    public void onClickGreens()
    {
        if (GameEvents.clicks >= gen1Cost) {
            GameEvents.clicks -= (ulong)gen1Cost;
            gen1Cost = (ulong)Math.Round(gen1Cost * 1.1f);
            Greens++;
        }
    }
    public void onClickCallums()
    {
        if (GameEvents.clicks >= CallumCost) {
            GameEvents.clicks -= (ulong)CallumCost;
            CallumCost = (ulong)Math.Round(CallumCost * 1.1f);
            Callums++;
        }
    }
    public void onClickTaylors()
    {
        if (GameEvents.clicks >= TaylorCost) {
            GameEvents.clicks -= (ulong)TaylorCost;
            TaylorCost = (ulong)Math.Round(TaylorCost * 1.1f);
            Taylors++;
        }
    }
    public void onClickNathaniels()
    {
        if (GameEvents.clicks >= NathanielCost) {
            GameEvents.clicks -= (ulong)NathanielCost;
            NathanielCost = (ulong)Math.Round(NathanielCost * 1.1f);
            Nathaniels++;
        }
    }
    public void onClickWilsons()
    {
        if (GameEvents.clicks >= WilsonCost) {
            GameEvents.clicks -= (ulong)WilsonCost;
            WilsonCost =  (ulong)Math.Round(WilsonCost * 1.1f);
            Wilsons++;
        }
    }
    public void onClickFloppas()
    {
        if (GameEvents.clicks >= FloppaCost) {
            GameEvents.clicks -= (ulong)FloppaCost;
            FloppaCost = (ulong)Math.Round(FloppaCost * 1.1f);
            Floppas++;
        }
    }
    public void onClickBingus()
    {
        if (GameEvents.clicks >= BingusCost) {
            GameEvents.clicks -= (ulong)BingusCost;
            BingusCost = (ulong)Math.Round(BingusCost * 1.1f);
            Bingus++;
        }
    }
    public void onClickSogga()
    {
        if (GameEvents.clicks >= SoggaCost) {
            GameEvents.clicks -= (ulong)SoggaCost;
            SoggaCost = (ulong)Math.Round(SoggaCost * 1.1f);
            Soggas++;
        }
    }
    public void onClickSaul()
    {
        if (GameEvents.clicks >= SaulCost) {
            GameEvents.clicks -= (ulong)SaulCost;
            SaulCost = (ulong)Math.Round(SaulCost * 1.1f);
            Sauls++;
        }
    }
    public void onClickJesse()
    {
        if (GameEvents.clicks >= JesseCost) {
            GameEvents.clicks -= (ulong)JesseCost;
            JesseCost = (ulong)Math.Round(JesseCost * 1.1f);
            Jesses++;
        }
    }
    public void onClickWalter()
    {
        if (GameEvents.clicks >= WalterCost) {
            GameEvents.clicks -= (ulong)WalterCost;
            WalterCost = (ulong)Math.Round(WalterCost * 1.1f);
            Walters++;
        }
    }
    public void onClickMordecai()
    {
        if (GameEvents.clicks >= MordecaiCost) {
            GameEvents.clicks -= (ulong)MordecaiCost;
            MordecaiCost = (ulong)Math.Round(MordecaiCost * 1.1f);
            Mordecais++;
        }
    }
    public void onClickRigby()
    {
        if (GameEvents.clicks >= RigbyCost) {
            GameEvents.clicks -= (ulong)RigbyCost;
            RigbyCost = (ulong)Math.Round(RigbyCost * 1.1f);
            Rigbys++;
        }
    }
    public void onClickBenson()
    {
        if (GameEvents.clicks >= BensonCost) {
            GameEvents.clicks -= (ulong)BensonCost;
            BensonCost = (ulong)Math.Round(BensonCost * 1.1f);
            Bensons++;
        }
    }
    public void onClickMM()
    {
        if (GameEvents.clicks >= MMCost) {
            GameEvents.clicks -= (ulong)MMCost;
            MMCost = (ulong)Math.Round(MMCost * 1.1f);
            MMs++;
        }
    }
    public static IEnumerator IncrementCountCoroutine()
    {
        while (true)
        {
            ulong amount1 = Greens * 2;
            GameEvents.clicks += amount1 * GameMultiply.multiplier;
            ulong amount2 = Callums * 5;
            GameEvents.clicks += amount2 * GameMultiply.multiplier;
            ulong amount3 = Taylors * 12;
            GameEvents.clicks += amount3 * GameMultiply.multiplier;
            ulong amount4 = Nathaniels * 25;
            GameEvents.clicks += amount4 * GameMultiply.multiplier;
            ulong amount5 = Wilsons * 60;
            GameEvents.clicks += amount5 * GameMultiply.multiplier;
            ulong amount6 = Floppas * 130;
            GameEvents.clicks += amount6 * GameMultiply.multiplier;
            ulong amount7 = Bingus * 250;
            GameEvents.clicks += amount7 * GameMultiply.multiplier;
            ulong amount8 = Soggas * 520;
            GameEvents.clicks += amount8 * GameMultiply.multiplier;
            ulong amount9 = Sauls * 1050;
            GameEvents.clicks += amount9 * GameMultiply.multiplier;
            ulong amount10 = Jesses * 2200;
            GameEvents.clicks += amount10 * GameMultiply.multiplier;
            ulong amount11 = Walters * 4500;
            GameEvents.clicks += amount11 * GameMultiply.multiplier;
            ulong amount12 = Mordecais * 9200;
            GameEvents.clicks += amount12 * GameMultiply.multiplier;
            ulong amount13 = Rigbys * 18500;
            GameEvents.clicks += amount13 * GameMultiply.multiplier;
            ulong amount14 = Bensons * 37500;
            GameEvents.clicks += amount14 * GameMultiply.multiplier;
            ulong amount15 = MMs * 76000;
            GameEvents.clicks += amount15 * GameMultiply.multiplier;
            if (GameEvents.genFrezyActive){
                yield return new WaitForSeconds(0.5f);
            }else{
                yield return new WaitForSeconds(1);
            }
            
        }
    }
}
