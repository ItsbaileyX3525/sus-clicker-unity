using UnityEngine;

public class Background_Music : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private AudioClip audioClip1;
    [SerializeField] private AudioClip audioClip2;
    [SerializeField] private AudioClip audioClip3;

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
        audioSource.Play();
    }
}
