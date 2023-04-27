using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public uint inputScore = GameMultiply.multiplier;
    [SerializeField] private TMP_InputField inputName;
    public UnityEvent<string, int> submitScoreEvent;
    public void SubmitScore()
    {
        submitScoreEvent.Invoke(inputName.text, (int)inputScore);
    }
    void Update()
    {
        inputScore = GameMultiply.multiplier;
    }
}
