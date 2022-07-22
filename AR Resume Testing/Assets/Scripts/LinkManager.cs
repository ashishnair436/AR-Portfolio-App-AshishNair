using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LinkManager : MonoBehaviour
{

    public GameObject miniMilitiainfo;

    public GameObject SpaceShooterinfo;


    public GameObject HighTimeinfo;

    public GameObject SpaceShooterButton;
    public GameObject HighTimeButton;


   public void Start()
    {
        SpaceShooterButton.SetActive(true);
        HighTimeButton.SetActive(true);
        miniMilitiainfo.SetActive(false);
        SpaceShooterinfo.SetActive(false);
        HighTimeinfo.SetActive(false);
    }

    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/ashish-nair436/");
    }

    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/ashish_nair_95/");
    }
    public void OpenDiscord()
    {
        Application.OpenURL("https://discordapp.com/users/614745571449896962/");
    }
    public void OpenGithub()
    {
        Application.OpenURL("https://github.com/ashishnair436");
    }

    public void OpenWhatsapp()
    {
        Application.OpenURL("https://wa.me/918149705495");
    }


    public void Open3DMiniMilitia()
    {
        Application.OpenURL("https://github.com/ashishnair436/onlineshootergame");
    }

    public void OpenSpaceShooter()
    {
        Application.OpenURL("https://github.com/ashishnair436/Space-Shooter-Pro-LFS");
    }

    public void OpenResume()
    {
        Application.OpenURL("https://drive.google.com/file/d/1HWnc7inUPThFxWt3ppQFP_fhIqmegzlQ/view?usp=sharing");
    }
    
    public void OpenHighTime()
    {
        Application.OpenURL("https://github.com/yatharthgupta7/HIgh-TIme");
    }

    public void OpenMiniMilitiaInfo()
    {
        if (miniMilitiainfo.activeInHierarchy == true)
        {

            miniMilitiainfo.SetActive(false);
            SpaceShooterButton.SetActive(true);
            HighTimeButton.SetActive(true);
        }
        else
        {
            miniMilitiainfo.SetActive(true);
        SpaceShooterButton.SetActive(false);
        HighTimeButton.SetActive(false);
        }

        SpaceShooterinfo.SetActive(false);
        HighTimeinfo.SetActive(false);
    }

    public void OpenSpaceShooterInfo()
    {
        if (SpaceShooterinfo.activeInHierarchy == true)
        {

            SpaceShooterinfo.SetActive(false);
            HighTimeButton.SetActive(true);
        }
        else
        {
            SpaceShooterinfo.SetActive(true);
            HighTimeButton.SetActive(false);
        }
       
        miniMilitiainfo.SetActive(false);
       
        HighTimeinfo.SetActive(false);
    }

    public void OpenHighTimeInfo()
    {
        miniMilitiainfo.SetActive(false);
        SpaceShooterinfo.SetActive(false);

        if (HighTimeinfo.activeInHierarchy == true)
        {
        HighTimeinfo.SetActive(false);

        }
        else
        {
            HighTimeinfo.SetActive(true);
        }

    }

}
