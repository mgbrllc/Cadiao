using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class TextGameScript : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI storytextMeshPro, hptextMeshPro, staminatextMeshPro;
    public string StoryText;
    public int HPVal = 10, STAMINAVal = 10;
    public GameObject MainMenuButtons, Level1Buttons;
    void Start()
    {
        storytextMeshPro.text = StoryText;
        StoryText = "Stardew Valley";
        Level1Buttons.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        storytextMeshPro.text = StoryText;
        hptextMeshPro.text = HPVal.ToString();
        staminatextMeshPro.text = STAMINAVal.ToString();
    }

    public void startGame()
    {
        MainMenuButtons.SetActive(false);
        Level1Buttons.SetActive(true);
        StoryText = "What would you like to do first?";
    }

    public void exit()
    {
        Application.Quit();
    }
    public void Button1()
    {
        StoryText = "Bacon and Eggs are my favorite!";
        STAMINAVal -= 1;
        HPVal += 1;
    }

    public void Button2()
    {
        StoryText = "My breath is fresh now!";
        STAMINAVal -= 1;
        HPVal += 1;
    }

    public void Button3()
    {
        StoryText = "Your pet wants more belly rubs!";
        STAMINAVal += 2;
        HPVal += 1;
    }
}
