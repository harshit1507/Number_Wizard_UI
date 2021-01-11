using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    string gameId = "3970371";
    bool testMode = true;
    private void Start() {
        Advertisement.Initialize(gameId, testMode);
        // Advertisement.show("video");
    }
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.E))
        // {
        //     if(Advertisement.IsReady("video"))
        //     {
        //         Advertisement.Show("video");
        //     }
        //     Debug.Log("E is Pressed");
        // }
    }
    public void showAds()
    {
        Advertisement.Show("video");
    }
}
