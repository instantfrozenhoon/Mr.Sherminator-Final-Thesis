using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSecond : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private GameObject questionBox;
    [SerializeField] private GameObject questionBoxTwo;
    [SerializeField] private GameObject hint;
    [SerializeField] private GameObject correctAnswerPanel;
    [SerializeField] private GameObject wrongAnswerPanel;
    [SerializeField] private GameObject youLostPanel;
    [SerializeField] private GameObject fakeDoor;
    [SerializeField] private GameObject realDoor;
    [SerializeField] private GameObject lifeOne;
    [SerializeField] private GameObject lifeTwo;
    [SerializeField] private GameObject lifeThree;
    [SerializeField] private GameObject lifeOne2;
    [SerializeField] private GameObject lifeTwo2;
    [SerializeField] private GameObject lifeThree2;
    [SerializeField] private GameObject arrowHint;
    [SerializeField] private bool playerInRange;

    [SerializeField] private AudioSource audioSource, audioSourceTwo;
    [SerializeField] private AudioClip correctAnswerSound, wrongAnswerSound, stoneDoorSound;

    [SerializeField] private QuestionFirst questionFirst;

    public int playerLife;

    public bool interactedItem;
    public bool isCorrect;
    public bool isChanged;

    private void Awake()
    {
        hint.SetActive(false);
        interactedItem = false;
        isCorrect = false;
        fakeDoor.SetActive(true);
        realDoor.SetActive(false);
        isChanged = false;
    }

    private void Update()
    {
        if (isCorrect)
        {
            hint.SetActive(false);
        }

        else
        {
            if (questionFirst.isCorrect)
            {
                hint.SetActive(true);
            }

            else
            {
                hint.SetActive(false);
            }
        }

        ShowPlayerLife();
    }

    public void ButtonCorrect()
    {
        interactedItem = true;
        isCorrect = true;
        audioSource.clip = correctAnswerSound;
        audioSource.Play();
        StartCoroutine(ShowBannerCorrect());
        fakeDoor.SetActive(false);
        realDoor.SetActive(true);
        audioSourceTwo.clip = stoneDoorSound;
        audioSourceTwo.Play();
        arrowHint.SetActive(true);

        if (!isChanged)
        {
            isChanged = true;
        }
    }

    public void ButtonWrong()
    {
        questionFirst.playerLife -= 1;
        interactedItem = true;
        isCorrect = false;
        audioSource.clip = wrongAnswerSound;
        audioSource.Play();
        StartCoroutine(ShowBannerWrong());

        if (!isChanged)
        {
            isChanged = true;
        }
    }

    public void ButtonShowQuestion()
    {
        if (!interactedItem)
        {
            if (playerInRange)
            {
                int quizChecker = PlayerPrefs.GetInt("quizChanger");

                if (quizChecker == 0)
                {
                    hint.SetActive(false);
                    questionBoxTwo.SetActive(true);
                }

                if (quizChecker == 1)
                {
                    hint.SetActive(false);
                    questionBox.SetActive(true);
                }
            }
        }
    }

    private IEnumerator ShowBannerCorrect()
    {
        correctAnswerPanel.SetActive(true);
        yield return new WaitForSeconds(1f);
        correctAnswerPanel.SetActive(false);
        questionBox.SetActive(false);
        questionBoxTwo.SetActive(false);
        arrowHint.SetActive(true);
    }

    private IEnumerator ShowBannerWrong()
    {
        wrongAnswerPanel.SetActive(true);
        yield return new WaitForSeconds(1f);
        wrongAnswerPanel.SetActive(false);

        if (questionFirst.playerLife == 0)
        {
            youLostPanel.SetActive(true);
        }
    }

    public void ShowPlayerLife()
    {
        if (questionFirst.playerLife == 3)
        {
            lifeOne.SetActive(true);
            lifeTwo.SetActive(true);
            lifeThree.SetActive(true);
            lifeOne2.SetActive(true);
            lifeTwo2.SetActive(true);
            lifeThree2.SetActive(true);
        }

        if (questionFirst.playerLife == 2)
        {
            lifeOne.SetActive(true);
            lifeTwo.SetActive(true);
            lifeThree.SetActive(false);
            lifeOne2.SetActive(true);
            lifeTwo2.SetActive(true);
            lifeThree2.SetActive(false);
        }

        if (questionFirst.playerLife == 1)
        {
            lifeOne.SetActive(true);
            lifeTwo.SetActive(false);
            lifeThree.SetActive(false);
            lifeOne2.SetActive(true);
            lifeTwo2.SetActive(false);
            lifeThree2.SetActive(false);
        }

        if (questionFirst.playerLife == 0)
        {
            lifeOne.SetActive(false);
            lifeTwo.SetActive(false);
            lifeThree.SetActive(false);
            lifeOne2.SetActive(false);
            lifeTwo2.SetActive(false);
            lifeThree2.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
