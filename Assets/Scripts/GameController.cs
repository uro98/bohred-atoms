using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{

    public Text Element1;
    public Text Element2;
    public Text ElectronCount1;
    public Text ElectronCount2;
    public Text Title;
    public Text ElementText;
    public Text Quote;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject RB1;
    public GameObject WinBoard;

    private float timer1;
    private float timer2;
    private bool win;
    private bool winMusic;
    private WinMusicPlayer wmp;

    List<string> element = new List<string>();
    List<string> quote = new List<string>();

    void Start()
    {
        wmp = GameObject.FindObjectOfType<WinMusicPlayer>();

        WinBoard.SetActive(false);
        win = false;
        winMusic = false;
        Player1.SetActive(true);
        Player2.SetActive(true);
        RB1.SetActive(true);

        Element1.text = "ARGON";
        Element2.text = "ARGON";
        ElectronCount1.text = "18";
        ElectronCount2.text = "18";

        element.Add("RIP");
        element.Add("HYDROGEN");
        element.Add("HELIUM");
        element.Add("LITHIUM");
        element.Add("BERYLLIUM");
        element.Add("BORON");
        element.Add("CARBON");
        element.Add("NITROGEN");
        element.Add("OXYGEN");
        element.Add("FLUORINE");
        element.Add("NEON");
        element.Add("SODIUM");
        element.Add("MAGNESIUM");
        element.Add("ALUMINIUM");
        element.Add("SILICON");
        element.Add("PHOSPHORUS");
        element.Add("SULFUR");
        element.Add("CHLORINE");

        quote.Add("\"100 skill, 0 luck.\""); //H
        quote.Add("\"Hehe!\""); //He
        quote.Add("\"That was Lit.\""); //Li
        quote.Add("\"Get Better.\""); //Be
        quote.Add("\"Bohr atom? No, Bohron.\""); //B
        quote.Add("\"C-ya\""); //C
        quote.Add("\"Sharp shooting N amazing jukes.\""); //N
        quote.Add("\"O why do I have such good hand-eye coordination?\""); //O
        quote.Add("\"Just Forfeit next time\""); //F
        quote.Add("\"Neon the ground before me.\""); //Ne
        quote.Add("\"Tough fight... Na.\""); //Na
        quote.Add("\"Mg I'm so good\""); //Mg
        quote.Add("\"That's not even Al I've got.\""); //Al
        quote.Add("\"I'm so slick with my shooting, that's why they call me Silic-on...\""); //Si
        quote.Add("\"If you were good, 'honorable opponents' as a description would be true for us, but for now it's Phosphorus.\""); //P
        quote.Add("\"My skill level is Sulfur above yours.\""); //S
        quote.Add("\"Close...\""); //Cl
        quote.Add("\"You... Argon!\""); //Ar
    }

    void Update()
    {
        //Flash electroncount
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;

        if (Destroy1.electronCount1 <= 3 && (win == false))
        {
            if (timer1 >= 0.5)
            {
                ElectronCount1.color = Color.red;
            }
            if (timer1 >= 1)
            {
                ElectronCount1.color = Color.white;
                timer1 = 0;
            }
        }

        if (Destroy2.electronCount2 <= 3 && (win == false))
        {
            if (timer2 >= 0.5)
            {
                ElectronCount2.color = Color.red;
            }
            if (timer2 >= 1)
            {
                ElectronCount2.color = Color.white;
                timer2 = 0;
            }
        }

        //Play win music
        if (winMusic)
        {
            Destroy (GameObject.Find("BGMusicPlayer"));
            wmp.PlayWinMusic();
            winMusic = false;
        }
    }

    //Display electron name
    public void ElementName1(int electronCount)
    {
        Element1.text = element[electronCount];
        ElectronCount1.text = electronCount.ToString();
    }

    public void ElementName2(int electronCount)
    {
        Element2.text = element[electronCount];
        ElectronCount2.text = electronCount.ToString();
    }

    //Win board
    public void Win()
    {
        Player1.SetActive(false);
        Player2.SetActive(false);
        RB1.SetActive(false);
        WinBoard.SetActive(true);
        win = true;
        winMusic = true;

        if (Destroy1.electronCount1 > Destroy2.electronCount2)
        {
            Title.text = "PLAYER 1 WINS";
            ElementText.text = "as " + Element1.text;
            Quote.text = quote[Destroy1.electronCount1 - 1] + " - Player 1";
            ElectronCount1.color = Color.white;
            ElectronCount2.color = Color.red;
        }
        else if (Destroy1.electronCount1 < Destroy2.electronCount2)
        {
            Title.text = "PLAYER 2 WINS";
            ElementText.text = "as " + Element2.text;
            Quote.text = quote[Destroy2.electronCount2 - 1] + " - Player 2";
            ElectronCount1.color = Color.red;
            ElectronCount2.color = Color.white;
        }
        else if (Destroy1.electronCount1 == Destroy2.electronCount2)
        {
            Title.text = "DRAW!";
            ElementText.text = "both as" + Element1.text;
            Quote.text = "\"How are draws even possible?!\" - Developer";
            ElectronCount1.color = Color.red;
            ElectronCount2.color = Color.red;
        }
    }
}
