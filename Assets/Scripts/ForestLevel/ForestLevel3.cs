using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ForestLevel3 : MonoBehaviour
{

    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;

    public bool playerInRange;
    public bool levelClearRange;
    public bool timerStart;


    public GameObject panelLevelClear;

    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    float currentTime = 0f;

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioClip dialogSound, win;

    public bool soundIsPlaying;

    void Start()
    {

        dialogText.text = "Is this some kind of bush maze? I should find my way out through this.";
        currentTime = 0f;
        soundIsPlaying = true;
        audio1.clip = dialogSound;
        audio1.Play();
    }

    private void Update()
    {

        if (timerStart)
        {

            Debug.Log("time start");
            currentTime += 1 * Time.deltaTime;

            Debug.Log(currentTime);
        }

        if (levelClearRange)
        {

            if (soundIsPlaying)
            {
                audio2.clip = win;
                audio2.Play();
                soundIsPlaying = false;
            }

            panelLevelClear.SetActive(true);
            Debug.Log("level clear");

            if (currentTime <= 90f)
            {

                int starScore = PlayerPrefs.GetInt("ForestThreeScore");

                if (starScore <= 3)
                {

                    PlayerPrefs.SetInt("ForestThreeScore", 3);
                    threeStar.SetActive(true);
                }

                else
                {

                    threeStar.SetActive(true);
                }
            }

            else if (currentTime > 90 && currentTime <= 120)
            {

                int starScore = PlayerPrefs.GetInt("ForestThreeScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestThreeScore", 2);
                    twoStar.SetActive(true);
                }

                else
                {

                    twoStar.SetActive(true);
                }
            }

            else if (currentTime > 120)
            {

                int starScore = PlayerPrefs.GetInt("ForestThreeScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestThreeScore", 1);
                    oneStar.SetActive(true);
                }

                else
                {

                    oneStar.SetActive(true);
                }
            }

            levelClearRange = false;
        }
    }

    public void ButtonAction()
    {

        dialogText.text = "Is this some kind of bush maze? I should find my way out through this.";
        Debug.Log("player range boulder");

        if (dialogBox.activeInHierarchy)
        {

            dialogBox.SetActive(false);
            Debug.Log("Dialog false");
            audio1.clip = dialogSound;
            audio1.Play();
        }

        else
        {

            dialogBox.SetActive(true);
            Debug.Log("Dialog true");
            audio1.clip = dialogSound;
            audio1.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("LevelClear"))
        {

            levelClearRange = true;
        }

        else if (insideQuestRange.CompareTag("TimerStart"))
        {

            timerStart = true;
        }
    }

    private void OnTriggerExit2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("LevelClear"))
        {

            levelClearRange = false;
        }
    }
}
