using UnityEngine;
using TMPro;

public class Susdisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text susText;
    void Update()
    {
        susText.text = "Suses: " + GameEvents.clicks;
    }
}
