using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ForestLevel1 : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;

    public bool playerInRange;
    public bool itemQuestRange;
    public bool levelClearRange;
    public bool timerStart;

    public GameObject questItem;
    public int questStarted;
    public int logObtained;
    public bool interactCue;

    public GameObject interactCueImage;
    public GameObject interactCueImage2;
    public GameObject flameQuestProp;
    public GameObject doorOpen;
    public GameObject door2;
    public GameObject panelLevelClear;

    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    float currentTime = 0f;

    public AudioSource audio;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioClip dialogSound, flame, win, stoneDoor;

    public bool soundIsPlaying;

    void Start()
    {

        questStarted = 0;
        logObtained = 0;
        currentTime = 0f;
        soundIsPlaying = true;
    }

    private void Update()
    {

        if (timerStart)
        {

            Debug.Log("time start");
            currentTime += 1 * Time.deltaTime;

            Debug.Log(currentTime);
        }

        if (playerInRange)
        {
            interactCueImage.SetActive(true);
        }

        else
        {
            interactCueImage.SetActive(false);
        }

        if (itemQuestRange)
        {
            interactCueImage2.SetActive(true);
        }

        else
        {
            interactCueImage2.SetActive(false);
        }

        if (levelClearRange)
        {
            if (soundIsPlaying)
            {
                audio.clip = win;
                audio.Play();
                soundIsPlaying = false;
            }

            panelLevelClear.SetActive(true);
            Debug.Log("level clear");

            if (currentTime <= 40f)
            {

                int starScore = PlayerPrefs.GetInt("ForestOneScore");

                if (starScore <= 3)
                {

                    PlayerPrefs.SetInt("ForestOneScore", 3);
                    threeStar.SetActive(true);
                }

                else
                {

                    threeStar.SetActive(true);
                }
            }

            else if (currentTime > 40 && currentTime <= 60)
            {

                int starScore = PlayerPrefs.GetInt("ForestOneScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestOneScore", 2);
                    twoStar.SetActive(true);
                }

                else
                {

                    twoStar.SetActive(true);
                }
            }

            else if (currentTime > 60)
            {

                int starScore = PlayerPrefs.GetInt("ForestOneScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestOneScore", 1);
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

        if (logObtained == 0)
        {

            dialogText.text = "The bonefire seems to be unlit. I should find a way to start the fire.";

            if (playerInRange)
            {

                Debug.Log("player range");

                if (dialogBox.activeInHierarchy)
                {

                    dialogBox.SetActive(false);
                    questItem.SetActive(true);
                    audio.clip = dialogSound;
                    audio.Play();
                }

                else
                {

                    dialogBox.SetActive(true);
                    audio.clip = dialogSound;
                    audio.Play();

                    if (questStarted == 2)
                    {

                        questStarted = 2;
                    }

                    else if (questStarted == 0)
                    {
                        questStarted = 1;
                        questItem.SetActive(true);
                    }
                }
            }

            else if (itemQuestRange)
            {

                Debug.Log("item dialog");

                dialogText.text = "This log can be used to light up the bonfire. I must go back to the unlit bonfire now.";
                logObtained = 1;
                questStarted = 1;

                if (dialogBox.activeInHierarchy)
                {

                    dialogBox.SetActive(false);
                    audio.clip = dialogSound;
                    audio.Play();
                    questItem.SetActive(false);
                }

                else
                {
                    dialogBox.SetActive(true);
                    audio.clip = dialogSound;
                    audio.Play();
                    //scaleChange = new Vector2(-0.01f, -0.01f);
                    //questItem.transform.localScale = scaleChange;
                }
            }
        }

        else
        {

            if (playerInRange)
            {

                Debug.Log("player range");

                dialogText.text = "You placed the log, the bonfire lit up!....\n\nThe stone door gate opened!";
                questStarted = 2;
                flameQuestProp.SetActive(true);
                audio3.clip = stoneDoor;
                audio3.Play();

                if (dialogBox.activeInHierarchy)
                {

                    dialogBox.SetActive(false);
                    audio.clip = dialogSound;
                    audio.Play();
                }

                else
                {

                    dialogBox.SetActive(true);
                    Debug.Log("Door Opening");
                    door2.SetActive(false);
                    doorOpen.SetActive(true);
                    audio.clip = dialogSound;
                    audio.Play();
                    audio2.clip = flame;
                    audio2.Play();
                }
            }

            else if (itemQuestRange)
            {

                Debug.Log("item dialog");

                dialogText.text = "This log can be used to light up the bonfire. I must go back to the unlit bonfire now.";

                if (dialogBox.activeInHierarchy)
                {

                    dialogBox.SetActive(false);
                    questStarted = 1;
                    audio.clip = dialogSound;
                    audio.Play();
                    questItem.SetActive(false);
                }

                else
                {

                    dialogBox.SetActive(true);
                    questStarted = 1;
                    audio.clip = dialogSound;
                    audio.Play();
                    // scaleChange = new Vector2(0f, 0f);
                    // questItem.transform.localScale = scaleChange;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("ActivateQuest"))
        {

            playerInRange = true;
        }

        else if (insideQuestRange.CompareTag("QuestItem"))
        {

            itemQuestRange = true;
        }

        else if (insideQuestRange.CompareTag("LevelClear"))
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

        if (insideQuestRange.CompareTag("ActivateQuest"))
        {

            playerInRange = false;
            dialogBox.SetActive(false);
        }

        else if (insideQuestRange.CompareTag("QuestItem"))
        {

            itemQuestRange = false;
            dialogBox.SetActive(false);
        }

        else if (insideQuestRange.CompareTag("LevelClear"))
        {

            levelClearRange = false;
        }
    }
}
