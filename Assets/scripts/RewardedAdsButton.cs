using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using System.Collections;

public class RewardedAdsButton : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] Button _showAdButton;
    [SerializeField] Button _showAdButton2;
    [SerializeField] Button _showAdButton3;
    [SerializeField] string _androidAdUnitId = "Rewarded_Android";
    [SerializeField] string _androidAdUnitId2 = "Rewarded_Android2";
    [SerializeField] string _androidAdUnitId3 = "Rewarded_Android3";
    string _adUnitId = null; // This will remain null for unsupported platforms
    string _adUnitId2 = null;
    string _adUnitId3 = null;
    private bool ad1Loaded = false;
    private bool ad2Loaded = false;
    private bool ad3Loaded = false;
    void Awake()
    {   
#if UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
        _adUnitId2 = _androidAdUnitId2;
        _adUnitId3 = _androidAdUnitId3;
#endif

        //Disable the button until the ad is ready to show:
        _showAdButton.interactable = false;
        _showAdButton2.interactable = false;
        _showAdButton3.interactable = false;
    }
 
    // Load content to the Ad Unit:
    public void LoadAd()
    {
        // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
        Advertisement.Load(_adUnitId, this);

        Advertisement.Load(_adUnitId2, this);

        Advertisement.Load(_adUnitId3, this);
    }
 
    // If the ad successfully loads, add a listener to the button and enable it:
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
            
        //// Button 1 ////
        if (adUnitId.Equals(_adUnitId))
        {
            if (!ad1Loaded)
            {
                _showAdButton.onClick.AddListener(ShowAd);
                ad1Loaded = true;
            }
            // Enable the button for users to click:
            _showAdButton.interactable = true;

            
        }


        /// ad 2 ////         
        if (adUnitId.Equals(_adUnitId2))
        {
            if (!ad2Loaded)
            {
                _showAdButton2.onClick.AddListener(ShowAd2);
                ad2Loaded = true;
            }
            // Enable the button for users to click:
            _showAdButton2.interactable = true;
        }

        /// ad 3 ///
        if (adUnitId.Equals(_adUnitId3))
        {
            if (!ad3Loaded)
            {
                _showAdButton3.onClick.AddListener(ShowAd3);
            }
            _showAdButton3.interactable = true;
        }
    }

  
    // Implement a method to execute when the user clicks the button:
    public void ShowAd()
    {
        // Disable the button:
        _showAdButton.interactable = false;
        // Then show the ad:
        Advertisement.Show(_adUnitId, this);
    }
    public void ShowAd2()
    {
        // Disable the button:
        _showAdButton2.interactable = false;
        // Then show the ad:
        Advertisement.Show(_adUnitId2, this);
    }
 
    public void ShowAd3()
    {
        _showAdButton3.interactable = false;
        Advertisement.Show(_adUnitId3, this);
    }
    // Implement the Show Listener's OnUnityAdsShowComplete callback method to determine if the user gets a reward:
    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            GameEvents.clicks *= 3/2;
            // Load another ad:
            Advertisement.Load(_adUnitId, this);
        }

        if (adUnitId.Equals(_adUnitId2) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            // Grant a reward.
            GameEvents.genFrezyActiveF = true;
            GameEvents.genFrezyActive = true;
            // Load another ad:
            StartCoroutine(DoSomethingAfterDelay());
        }
        if (adUnitId.Equals(_adUnitId3) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            Generate.gen1Cost = Generate.gen1Cost / 2;
            Generate.CallumCost = Generate.CallumCost / 2;
            Generate.TaylorCost = Generate.TaylorCost / 2;
            Generate.NathanielCost = Generate.NathanielCost / 2;
            Generate.WilsonCost = Generate.WilsonCost / 2;
            Generate.FloppaCost = Generate.FloppaCost / 2;
            Generate.BingusCost = Generate.BingusCost / 2;
            Generate.SoggaCost = Generate.SoggaCost / 2;
            Generate.SaulCost = Generate.SaulCost / 2;
            Generate.JesseCost = Generate.JesseCost / 2;
            Generate.WalterCost = Generate.WalterCost / 2;
            Advertisement.Load(_adUnitId3, this);
        }
    }
 
    // Implement Load and Show Listener error callbacks:
    public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    {
        // Use the error details to determine whether to try to load another ad.
    }
 
    public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
        // Use the error details to determine whether to try to load another ad.
    }
 
    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }
 
    void OnDestroy()
    {
        // Clean up the button listeners:
        _showAdButton.onClick.RemoveAllListeners();
        _showAdButton2.onClick.RemoveAllListeners();
        _showAdButton3.onClick.RemoveAllListeners();
    }
    private IEnumerator DoSomethingAfterDelay()
    {
        yield return new WaitForSeconds(45);
        Advertisement.Load(_adUnitId2, this);
    }
}