using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonControl : MonoBehaviour
{

    public KinectManager kinectManager;
    public GameObject[] PersonGroup;

    private void Awake()
    {
        kinectManager.LostUser += UserLost;
        kinectManager.FindUser += UserDetected;
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
