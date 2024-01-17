using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ForestLevel2 : MonoBehaviour
{

    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;

    public BoulderItemScript boulderItemScript;
    public StarItemScript starItemScript;

    public bool playerInRange;
    public bool playerInRangeTwo;
    public bool itemQuestRange;
    public bool itemQuestRangeTwo;
    public bool levelClearRange;
    public bool timerStart;

    public int questStarted;
    public int logObtained;
    public bool interactCue;

    public int checkDialog;

    public GameObject interactCueImage;
    public GameObject interactCueImage2;
    public GameObject itemCueImage;
    public GameObject itemCueImage2;

    public GameObject doorOpen;
    public GameObject door2;
    public GameObject panelLevelClear;

    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    float currentTime = 0f;

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioClip dialogSound, pressurePlate, win, stoneDoor;

    public bool soundIsPlaying;

    void Start()
    {

        checkDialog = 0;
        questStarted = 0;
        logObtained = 0;
        currentTime = 0f;
        soundIsPlaying = true;
    }

    private void Update()
    {

        if (checkDialog == 0)
        {

            if (boulderItemScript.boulderComplete && starItemScript.starComplete)
            {

                audio3.clip = stoneDoor;
                audio3.Play();
                door2.SetActive(false);
                doorOpen.SetActive(true);
                Debug.Log("open door");

                dialogText.text = "The pressure plates opened the door!";
                dialogBox.SetActive(true);
                checkDialog = 1;
            }
        }

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

        if (playerInRangeTwo)
        {
            interactCueImage2.SetActive(true);
        }

        else
        {
            interactCueImage2.SetActive(false);
        }

        if (itemQuestRange)
        {
            itemCueImage.SetActive(true);
        }

        else
        {
            itemCueImage.SetActive(false);
        }

        if (itemQuestRangeTwo)
        {
            itemCueImage2.SetActive(true);
        }

        else
        {
            itemCueImage2.SetActive(false);
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

            if (currentTime <= 40f)
            {

                int starScore = PlayerPrefs.GetInt("ForestTwoScore");

                if (starScore <= 3)
                {

                    PlayerPrefs.SetInt("ForestTwoScore", 3);
                    threeStar.SetActive(true);
                }

                else
                {

                    threeStar.SetActive(true);
                }
            }

            else if (currentTime > 40f && currentTime <= 60f)
            {

                int starScore = PlayerPrefs.GetInt("ForestTwoScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestTwoScore", 2);
                    twoStar.SetActive(true);
                }

                else
                {

                    twoStar.SetActive(true);
                }
            }

            else if (currentTime > 60f)
            {

                int starScore = PlayerPrefs.GetInt("ForestTwoScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestTwoScore", 1);
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

        if (playerInRange)
        {

            dialogText.text = "This looks like a pressure plate, maybe I should find a object that resembles CIRCLE the shape and place it on top of the plate.";
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

        else if (playerInRangeTwo)
        {

            dialogText.text = "This looks like a pressure plate, maybe I should find a object that resembles the STAR shape and place it on top of the plate.";
            Debug.Log("player range star");

            if (dialogBox.activeInHierarchy)
            {

                dialogBox.SetActive(false);
                Debug.Log("Dialog false 2");
                audio1.clip = dialogSound;
                audio1.Play();
            }

            else
            {

                dialogBox.SetActive(true);
                Debug.Log("Dialog true 2");
                audio1.clip = dialogSound;
                audio1.Play();
            }
        }


        else if (itemQuestRange)
        {

            dialogText.text = "This stone can be pushed somewhere. I should place it on top of something that has the CIRCLE same shape.";
            Debug.Log("item boulder");

            if (dialogBox.activeInHierarchy)
            {

                dialogBox.SetActive(false);
                audio1.clip = dialogSound;
                audio1.Play();
            }

            else
            {
                dialogBox.SetActive(true);
                audio1.clip = dialogSound;
                audio1.Play();
            }
        }

        else if (itemQuestRangeTwo)
        {

            dialogText.text = "This stone can be pushed somewhere. I should place it on top of something that has the STAR same shape.";
            Debug.Log("item dialog");

            if (dialogBox.activeInHierarchy)
            {

                dialogBox.SetActive(false);
                audio1.clip = dialogSound;
                audio1.Play();
            }

            else
            {
                dialogBox.SetActive(true);
                audio1.clip = dialogSound;
                audio1.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("BoulderPressurePlate"))
        {

            playerInRange = true;
        }

        if (insideQuestRange.CompareTag("StarPressurePlate"))
        {

            playerInRangeTwo = true;
        }

        if (insideQuestRange.CompareTag("BoulderItem"))
        {

            itemQuestRange = true;
        }

        if (insideQuestRange.CompareTag("StarItem"))
        {

            itemQuestRangeTwo = true;
        }

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

        if (insideQuestRange.CompareTag("BoulderPressurePlate"))
        {

            playerInRange = false;
            dialogBox.SetActive(false);
        }

        if (insideQuestRange.CompareTag("StarPressurePlate"))
        {

            playerInRangeTwo = false;
            dialogBox.SetActive(false);
        }

        if (insideQuestRange.CompareTag("BoulderItem"))
        {

            itemQuestRange = false;
            dialogBox.SetActive(false);
        }

        if (insideQuestRange.CompareTag("StarItem"))
        {

            itemQuestRangeTwo = false;
            dialogBox.SetActive(false);
        }

        if (insideQuestRange.CompareTag("LevelClear"))
        {

            levelClearRange = false;
        }
    }
}
