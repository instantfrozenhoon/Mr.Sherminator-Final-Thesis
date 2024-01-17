using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MountainOne : MonoBehaviour
{
    public bool playerInRange;
    public bool levelClearRange;
    public bool timerStart;
    public bool soundIsPlaying;

    float currentTime = 0f;

    public GameObject panelLevelClear;
    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    public AudioSource audioSource;
    public AudioSource audioSourceTwo;
    public AudioClip win;

    public TextMeshProUGUI textTimer;

    void Start()
    {
        currentTime = 0f;
        soundIsPlaying = true;
    }

    private void Update()
    {
        if (timerStart)
        {
            Debug.Log("time start");
            currentTime += 1 * Time.deltaTime;
            int currentTimeInt = (int)currentTime;
            textTimer.text = "Time: " + currentTimeInt + " s";
        }

        if (levelClearRange)
        {
            if (soundIsPlaying)
            {
                audioSource.clip = win;
                audioSource.Play();
                soundIsPlaying = false;
            }

            panelLevelClear.SetActive(true);
            Debug.Log("level clear");

            if (currentTime <= 40f)
            {
                int starScore = PlayerPrefs.GetInt("MountainOneScore");

                if (starScore <= 3)
                {

                    PlayerPrefs.SetInt("MountainOneScore", 3);
                    threeStar.SetActive(true);
                }

                else
                {

                    threeStar.SetActive(true);
                }
            }

            else if (currentTime > 40 && currentTime <= 60)
            {
                int starScore = PlayerPrefs.GetInt("MountainOneScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("MountainOneScore", 2);
                    twoStar.SetActive(true);
                }

                else
                {

                    twoStar.SetActive(true);
                }
            }

            else if (currentTime > 60)
            {
                int starScore = PlayerPrefs.GetInt("MountainOneScore");

                if (starScore <= 2)
                {
                    PlayerPrefs.SetInt("MountainOneScore", 1);
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

    private void OnTriggerEnter2D(Collider2D insideQuestRange)
    {
        if (insideQuestRange.CompareTag("LevelClear"))
        {
            levelClearRange = true;
        }

        if (insideQuestRange.CompareTag("TimerStart"))
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
