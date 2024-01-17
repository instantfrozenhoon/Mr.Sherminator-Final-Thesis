using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ForestLevel5 : MonoBehaviour
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

    public GameObject blackscreen;
    public GameObject[] realSpike;
    public GameObject[] fakeSpike;
    public GameObject[] realFire;
    public GameObject[] fakeFire;

    float currentTime = 0f;

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioClip dialogSound, win, fail, flame, spike;

    public bool soundIsPlaying;
    public bool isDead;

    void Start()
    {

        dialogText.text = "The entrance to the cave is over there! I should get inside!";
        currentTime = 0f;
        soundIsPlaying = true;
        isDead = false;
        audio1.clip = dialogSound;
        audio1.Play();
        StartCoroutine(SpikeTrap());
        StartCoroutine(FireTrap());
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

                int starScore = PlayerPrefs.GetInt("ForestFiveScore");

                if (starScore <= 3)
                {

                    PlayerPrefs.SetInt("ForestFiveScore", 3);
                    threeStar.SetActive(true);
                }

                else
                {

                    threeStar.SetActive(true);
                }
            }

            else if (currentTime > 90 && currentTime <= 120)
            {

                int starScore = PlayerPrefs.GetInt("ForestFiveScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestFiveScore", 2);
                    twoStar.SetActive(true);
                }

                else
                {

                    twoStar.SetActive(true);
                }
            }

            else if (currentTime > 120)
            {

                int starScore = PlayerPrefs.GetInt("ForestFiveScore");

                if (starScore <= 2)
                {

                    PlayerPrefs.SetInt("ForestFiveScore", 1);
                    oneStar.SetActive(true);
                }

                else
                {

                    oneStar.SetActive(true);
                }
            }

            levelClearRange = false;
        }

        if (playerInRange)
        {
            if (!isDead)
            {
                audio2.clip = fail;
                audio2.Play();
                blackscreen.SetActive(true);
                isDead = true;
            }
        }
    }

    public void ButtonAction()
    {

        dialogText.text = "The entrance to the cave is over there! I should get inside!";

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

    public IEnumerator SpikeTrap()
    {

        while (true)
        {
            audio1.clip = spike;
            audio1.Play();

            fakeSpike[0].SetActive(false);
            realSpike[0].SetActive(true);

            fakeSpike[1].SetActive(false);
            realSpike[1].SetActive(true);

            fakeSpike[2].SetActive(false);
            realSpike[2].SetActive(true);

            fakeSpike[3].SetActive(false);
            realSpike[3].SetActive(true);

            fakeSpike[4].SetActive(false);
            realSpike[4].SetActive(true);

            fakeSpike[5].SetActive(false);
            realSpike[5].SetActive(true);

            fakeSpike[6].SetActive(false);
            realSpike[6].SetActive(true);

            fakeSpike[7].SetActive(false);
            realSpike[7].SetActive(true);

            fakeSpike[8].SetActive(false);
            realSpike[8].SetActive(true);

            yield return new WaitForSeconds(2.5f);

            realSpike[0].SetActive(false);
            fakeSpike[0].SetActive(true);

            realSpike[1].SetActive(false);
            fakeSpike[1].SetActive(true);

            realSpike[2].SetActive(false);
            fakeSpike[2].SetActive(true);

            realSpike[3].SetActive(false);
            fakeSpike[3].SetActive(true);

            realSpike[4].SetActive(false);
            fakeSpike[4].SetActive(true);

            realSpike[5].SetActive(false);
            fakeSpike[5].SetActive(true);

            realSpike[6].SetActive(false);
            fakeSpike[6].SetActive(true);

            realSpike[7].SetActive(false);
            fakeSpike[7].SetActive(true);

            realSpike[8].SetActive(false);
            fakeSpike[8].SetActive(true);
            yield return new WaitForSeconds(3f);
        }
    }

    public IEnumerator FireTrap()
    {

        while (true)
        {
            audio2.clip = flame;
            audio2.Play();

            fakeFire[0].SetActive(false);
            realFire[0].SetActive(true);

            fakeFire[1].SetActive(false);
            realFire[1].SetActive(true);

            fakeFire[2].SetActive(false);
            realFire[2].SetActive(true);

            fakeFire[3].SetActive(false);
            realFire[3].SetActive(true);

            fakeFire[4].SetActive(false);
            realFire[4].SetActive(true);

            yield return new WaitForSeconds(6f);

            realFire[0].SetActive(false);
            fakeFire[0].SetActive(true);

            realFire[1].SetActive(false);
            fakeFire[1].SetActive(true);

            realFire[2].SetActive(false);
            fakeFire[2].SetActive(true);

            realFire[3].SetActive(false);
            fakeFire[3].SetActive(true);

            realFire[4].SetActive(false);
            fakeFire[4].SetActive(true);

            yield return new WaitForSeconds(4f);
        }
    }

    private void OnTriggerEnter2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("Spike"))
        {

            playerInRange = true;
        }

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
