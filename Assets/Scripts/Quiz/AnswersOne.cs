using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersOne : MonoBehaviour
{

    public bool isCorrect = false;
    public QuizOneInductive quizManager;
    public Color startcolor;

    public void Answer ()
    {

        if (isCorrect)
        {

            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct");
            quizManager.Correct();
        }

        else
        {

            GetComponent<Image>().color = Color.gray;
            Debug.Log("Wrong");
            quizManager.Wrong();
        }
    }
}
