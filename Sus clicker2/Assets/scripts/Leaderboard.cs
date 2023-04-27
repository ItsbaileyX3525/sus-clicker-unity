using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> names;
    [SerializeField] private List<TextMeshProUGUI> scores;
    private string publicLeaderboardKey = "735bbf8b72ff8c012f9819cce12b3d257fd8e4f2a9a83f8b690f0ab6cd7f48bc";

    private void Start()
    {
        GetLeaderboard();
    }
    
    public void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) => {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for (int i = 0; i < loopLength; i++)
            {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));
    }

    public void SetLeaderboardEntry(string username, int score)
    {

        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score,
        ((_) => {
            GetLeaderboard();
        }));
          
    }
}
