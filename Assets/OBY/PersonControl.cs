using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PersonControl : MonoBehaviour
{

    public KinectManager kinectManager;
    public GameObject[] PersonGroup;
    public VideoPlayer videoPlayer;
    private void Awake()
    {
        kinectManager.LostUser += UserLost;
        kinectManager.FindUser += UserDetected;
    }

    private void Start()
    {
        videoPlayer.url = Application.streamingAssetsPath + "/bg.mp4";
        videoPlayer.Play();
    }

    public void UserDetected(int userIndex)
    {
        if(userIndex < PersonGroup.Length)
        {
            if(userIndex != 0)
            {
                PersonGroup[userIndex].SetActive(true);
            }
        }
    }

    public void UserLost(int userIndex)
    {
        if (userIndex < PersonGroup.Length)
        {
            if (userIndex != 0)
            {
                PersonGroup[userIndex].SetActive(false);
            }
        }
    }
}
