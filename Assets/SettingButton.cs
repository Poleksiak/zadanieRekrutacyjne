using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButton : MonoBehaviour
{
    public GameObject panel;

    public void TurnSettingOn()
    {
        panel.SetActive(true);
    }
    
    public void TurnSettingOff()
    {
        panel.SetActive(false);
    }
}

