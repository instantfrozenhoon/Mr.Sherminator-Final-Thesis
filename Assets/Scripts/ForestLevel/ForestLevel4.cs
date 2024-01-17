using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ForestLevel4 : MonoBehaviour
{

    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;

    public bool playerInRange;
    public bool playerInRangeTwo;
    public bool playerInRangeThree;
    public bool playerInRangeFour;

    public bool levelClearRange;
    public bool timerStart;

    public GameObject interactCueImage;
    public GameObject interactCueImage2;
    public GameObject interactCueImage3;
    public GameObject interactCueImage4;

    public GameObject bridge;
    public GameObject bridge2;
    public GameObject bridge3;
    public GameObject bridge4;

    public GameObject bridgefake;
    public GameObject bridgefake2;
    public GameObject bridgefake3;
    public GameObject bridgefake4;

    public GameObject blocker;
    public GameObject blocker2;
    public GameObject blocker3;
    public GameObject blocker4;

    public GameObject panelLevelClear;

    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    float currentTime = 0f;

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioClip dialogSound, lever, win, stoneDoor;

    public bool soundIsPlaying;

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

        if (playerInRangeThree)
        {
            interactCueImage3.SetActive(true);
        }

        else
        {
            interactCueImage3.SetActive(false);
        }

        if (playerInRangeFour)
        {
            interactCueImage4.SetActive(true);
        }

        else
        {
            interactCueImage4.SetActive(false);
        }

        if (levelClearRange)
        {

            if (soundIsPlaying)
            {
                audio1.clip = win;
                audio1.Play();
                soundIsPlaying = false;
            }

            panelLevelClear.SetActive(true);
            Debug.Log("level clear");

            if (currentTime <= 60f)
            {

                int starScore = PlayerPrefs.GetInt("ForestFourScore");

                if (starScore <= 3)
                {

                    PlayerPrefs.SetInt("ForestFourScore", 3);
                    threeStar.SetActive(true);
                }

                else
                {

                    threeStar.SetActive(true);
                }
            }

            else if (currentTime > 60f && currentTime <= 90f)
            {

                int starScore = PlayerPrefs.GetInt("ForestFourScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestFourScore", 2);
                    twoStar.SetActive(true);
                }

                else
                {

                    twoStar.SetActive(true);
                }
            }

            else if (currentTime > 90f)
            {

                int starScore = PlayerPrefs.GetInt("ForestFourScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestFourScore", 1);
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

            dialogText.text = "I activated the lever, the bridge connected to the other side!";
            bridgefake.SetActive(false);
            bridge.SetActive(true);
            blocker.SetActive(false);
            Debug.Log("lever1");
            audio2.clip = lever;
            audio2.Play();

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

        if (playerInRangeTwo)
        {

            dialogText.text = "I activated the lever, the bridge connected to the other side!";
            bridgefake2.SetActive(false);
            bridge2.SetActive(true);
            blocker2.SetActive(false);
            Debug.Log("lever2");
            audio2.clip = lever;
            audio2.Play();

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

        if (playerInRangeThree)
        {

            dialogText.text = "I activated the lever, the bridge connected to the other side!";
            bridgefake3.SetActive(false);
            bridge3.SetActive(true);
            blocker3.SetActive(false);
            Debug.Log("lever3");
            audio2.clip = lever;
            audio2.Play();

            if (dialogBox.activeInHierarchy)
            {

                dialogBox.SetActive(false);
                Debug.Log("Dialog false 3");
                audio1.clip = dialogSound;
                audio1.Play();
            }

            else
            {

                dialogBox.SetActive(true);
                Debug.Log("Dialog true 3");
                audio1.clip = dialogSound;
                audio1.Play();
            }
        }

        if (playerInRangeFour)
        {

            dialogText.text = "I activated the lever, the bridge connected to the other side!";
            bridgefake4.SetActive(false);
            bridge4.SetActive(true);
            blocker4.SetActive(false);
            Debug.Log("lever4");
            audio2.clip = lever;
            audio2.Play();

            if (dialogBox.activeInHierarchy)
            {

                dialogBox.SetActive(false);
                Debug.Log("Dialog false 4");
                audio1.clip = dialogSound;
                audio1.Play();
            }

            else
            {

                dialogBox.SetActive(true);
                Debug.Log("Dialog true 4");
                audio1.clip = dialogSound;
                audio1.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("Lever1"))
        {

            playerInRange = true;
            Debug.Log("lever1");
        }

        if (insideQuestRange.CompareTag("Lever2"))
        {

            playerInRangeTwo = true;
            Debug.Log("lever2");
        }

        if (insideQuestRange.CompareTag("Lever3"))
        {

            playerInRangeThree = true;
            Debug.Log("lever3");
        }

        if (insideQuestRange.CompareTag("Lever4"))
        {

            playerInRangeFour = true;
            Debug.Log("lever4");
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

        if (insideQuestRange.CompareTag("Lever1"))
        {

            playerInRange = false;
        }

        if (insideQuestRange.CompareTag("Lever2"))
        {

            playerInRangeTwo = false;
        }

        if (insideQuestRange.CompareTag("Lever3"))
        {

            playerInRangeThree = false;
        }

        if (insideQuestRange.CompareTag("Lever4"))
        {

            playerInRangeFour = false;
        }

        if (insideQuestRange.CompareTag("LevelClear"))
        {

            levelClearRange = false;
        }
    }
}
