using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> names;
    [SerializeField] private List<TextMeshProUGUI> scores;
    private string publicLeaderboardKey = "59748b72d7709006248e2be6a8c8593610d36f39edc9e8e51c79e779d2259f14";
    private string pirvateLeaderboardKey = "5993cb676e9e7a2f13866ba7a26ceb021f5bfc5462783b56e34b2538da4258b2e8899af088266a0163ddad2939637370bf4aa0a631a7645ee0b1d15e65ba37892afe3ca7403f87c23b9c5265350c596b0de115cfa979ce5d5555eba0204cce8f96f82b95c45bd9ea302da6a85638f41531538dacdff1e8f49fb753ae75a4e856";

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
