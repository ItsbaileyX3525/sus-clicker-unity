using UnityEngine;

public class ClickSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip audioClip1;
    [SerializeField] AudioClip audioClip2;
    [SerializeField] AudioClip audioClip3;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            audioSource.clip = audioClip1;
        }
        else if (val == 1)
        {
            audioSource.clip = audioClip2;
        }
        else if (val == 2)
        {
            audioSource.clip = audioClip3;
        }
    }
    private void SaveInputData()
    {
        //
    }
    private void LoadInputData()
    {
        //
    }
}
