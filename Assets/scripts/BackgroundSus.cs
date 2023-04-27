using UnityEngine;

public class BackgroundSus : MonoBehaviour {

    private uint clickValue;
    float lastActiveHours = 0f;
    float lastBonusTime;

    void Start()
    {
        lastBonusTime = Time.realtimeSinceStartup;
    }
    void Update()
    {
        uint before = Generate.Greens * 2 + Generate.Callums * 4 + Generate.Taylors * 8 + Generate.Nathaniels * 18 + Generate.Floppas * 1000 + Generate.Bingus * 5000;
        clickValue = before * GameMultiply.multiplier * 5;
    }

    void OnApplicationPause (bool paused) {
        if (!paused) {
            float hoursSinceLastActive = (Time.realtimeSinceStartup / 15);

            if (Time.realtimeSinceStartup - lastBonusTime >= 15)
            {
                GameEvents.clicks += (uint)((hoursSinceLastActive - lastActiveHours) * clickValue);

                lastBonusTime = Time.realtimeSinceStartup;
            }

            lastActiveHours = hoursSinceLastActive;
        }
    }
}
