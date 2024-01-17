using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoulderItemScript : MonoBehaviour
{

    public bool boulderRangePressure;
    public bool itemQuestRange;
    public bool levelClearRange;
    public bool boulderComplete;

    public bool checkDialog;

    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioClip dialogSound, pressurePlate;

    // Start is called before the first frame update
    void Start()
    {

        checkDialog = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (!checkDialog) {

            if (boulderRangePressure)
            {

                dialogText.text = "The pressure plate activated a mechanism!";
                Debug.Log("boulder pressure");
                audio1.clip = dialogSound;
                audio1.Play();
                audio2.clip = pressurePlate;
                audio2.Play();

                dialogBox.SetActive(true);
                checkDialog = true;
            }
        }
    }

    public void ButtonAction()
    {

        if (boulderRangePressure)
        {

            dialogBox.SetActive(false);
            checkDialog = false;
        }

        else
        {

            dialogBox.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("BoulderPressurePlate"))
        {

            boulderRangePressure = true;
            boulderComplete = true;
            Debug.Log("true");
        }
    }

    private void OnTriggerExit2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("BoulderPressurePlate"))
        {

            boulderRangePressure = false;
            boulderComplete = false;
        }
    }
}
