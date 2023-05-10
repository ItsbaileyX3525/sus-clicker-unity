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
        uint before = Generate.Greens * 2 + Generate.Callums * 5 + Generate.Taylors * 12 + Generate.Nathaniels * 25 + Generate.Wilsons * 60 + Generate.Floppas * 130 + Generate.Bingus * 250 + Generate.Soggas * 520 + Generate.Sauls * 1050 + Generate.Jesses * 2200 + Generate.Walters * 4500 + Generate.Mordecais * 9200 + Generate.Rigbys * 18500 + Generate.Bensons * 37500 + Generate.MMs * 76000;
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
