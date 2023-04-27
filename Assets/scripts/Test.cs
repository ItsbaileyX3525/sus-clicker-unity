using UnityEngine;
using UnityEngine.UI;

public class RandomNumberScript : MonoBehaviour
{
    public Text outputText;
    private int value = 123456789;

    void Start()
    {
        ;
        /*int randomNum = Random.Range(1, 1000000001);
        int newValue = value + randomNum;

        int billion = newValue / 1000000000;
        int million = (newValue % 1000000000) / 1000000;
        int thousand = (newValue % 1000000) / 1000;
        int unit = newValue % 1000;

        if (thousand >= 1000)
        {
            million += thousand / 1000;
            thousand %= 1000;
        }

        outputText.text = $"Initial value: {value}\n" +
                          $"Random number: {randomNum}\n" +
                          $"New value: {newValue}\n" +
                          $"Billion: {billion}\n" +
                          $"Million: {million}\n" +
                          $"Thousand: {thousand}\n" +
                          $"Unit: {unit}";*/
    }
}
