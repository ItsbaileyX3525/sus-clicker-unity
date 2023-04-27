using UnityEngine;
using TMPro;

public class LeaderBoardSus : MonoBehaviour
{
    public TMP_Text amount;
    // Update is called once per frame
    void Update()
    {
        amount.text = GameMultiply.multiplier.ToString();
    }
}
