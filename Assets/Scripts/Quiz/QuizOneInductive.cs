using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class QuizOneInductive : MonoBehaviour
{

    public List<QuestionsOne> QnA;
    public GameObject[] options;
    public GameObject[] optionsImage;
    public GameObject panelImage;

    public int currentQuestion;
    public int questionCounter = 0;
    public int score;

    public GameObject QuizPanel;
    public GameObject NextPanel;
    public GameObject ShowQuizPanel;

    public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI QuestionCounter;

    public TextMeshProUGUI quizOneScore;
    public TextMeshProUGUI quizTwoScore;
    public TextMeshProUGUI quizThreeScore;
    public TextMeshProUGUI quizFourScore;

    public Button[] buttonQuiz;

    public Color starColor;

    public string quizTypeString;
    private void Start()
    {

        NextPanel.SetActive(false);
        GenerateQuestion();
        starColor = GetComponent<Image>().color;
    }

    public void NextQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void ShowQuizScore()
    {

        QuizPanel.SetActive(false);
        NextPanel.SetActive(false);
        ShowQuizPanel.SetActive(true);
        DisplayScore();
    }

    void GameOver()
    {

        QuizPanel.SetActive(false);
        NextPanel.SetActive(true);
    }

    public void Correct()
    {

        score += 1;
        QnA.RemoveAt(currentQuestion);
        QuizScore(quizTypeString, score);
        StartCoroutine(WaitForNext());
    }

    public void Wrong()
    {

        QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());
    }

    void SetAnswers()
    {

        for (int i = 0; i < options.Length; i++)
        {

            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswersOne>().startcolor;
            options[i].GetComponent<AnswersOne>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];
            options[i].transform.GetChild(1).GetComponent<Image>().sprite = QnA[currentQuestion].AnswersImage[i];

            if (QnA[currentQuestion].CorrentAnswer == i + 1)
            {
                options[i].GetComponent<AnswersOne>().isCorrect = true;
            }
        }
    }

    void GenerateQuestion()
    {
        buttonQuiz[0].interactable = true;
        buttonQuiz[1].interactable = true;
        buttonQuiz[2].interactable = true;
        buttonQuiz[3].interactable = true;
        questionCounter += 1;
        QuestionCounter.SetText(questionCounter.ToString() + ".");

        if (QnA.Count > 0)
        {

            currentQuestion = Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;
            // QuestionImage.transform.GetChild(1).GetComponent<Image>().sprite = QnA[currentQuestion].QuestionImage;
            panelImage.transform.GetChild(1).GetComponent<Image>().sprite = QnA[currentQuestion].Image;
            SetAnswers();
        }

        else
        {

            Debug.Log("No more questions.");
            GameOver();
        }
    }

    public void QuizScore(string quizType, int score) {

        Debug.Log(quizType + score.ToString());

        if (quizType == "inductive") {

            PlayerPrefs.SetInt("inductiveQuizScore", score);
        }

        else if (quizType == "deductive") {

            PlayerPrefs.SetInt("deductiveQuizScore", score);
        }

        else if (quizType == "diagrammatic")
        {

            PlayerPrefs.SetInt("diagrammaticQuizScore", score);
        }

        else if (quizType == "abstract")
        {

            PlayerPrefs.SetInt("abstractQuizScore", score);
        }
    }

    IEnumerator WaitForNext()
    {
        buttonQuiz[0].interactable = false;
        buttonQuiz[1].interactable = false;
        buttonQuiz[2].interactable = false;
        buttonQuiz[3].interactable = false;
        yield return new WaitForSeconds(1);
        GenerateQuestion();
    }

    public void DisplayScore() {

        int quizOne = PlayerPrefs.GetInt("inductiveQuizScore");
        int quizTwo = PlayerPrefs.GetInt("deductiveQuizScore");
        int quizThree = PlayerPrefs.GetInt("diagrammaticQuizScore");
        int quizFour = PlayerPrefs.GetInt("abstractQuizScore");

        quizOneScore.SetText(quizOne.ToString() + "/10");
        quizTwoScore.SetText(quizTwo.ToString() + "/10");
        quizThreeScore.SetText(quizThree.ToString() + "/10");
        quizFourScore.SetText(quizFour.ToString() + "/10");
    }
}
