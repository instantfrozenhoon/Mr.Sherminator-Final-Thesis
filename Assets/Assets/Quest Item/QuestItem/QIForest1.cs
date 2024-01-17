using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QIForest1 : MonoBehaviour
{

    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;
    public bool playerInRangeQI;

    public GameObject hideQI;
    private Vector3 scaleChange;

    void Update()
    {
        
    }

    public void ButtonAction()
    {

        if (playerInRangeQI)
        {

            dialogText.text = "This log can be used to light up the bonfire. I must go back to the unlit bonfire now.";
            scaleChange = new Vector3(-0.0f, -0.0f, -0.0f);

            if (dialogBox.activeInHierarchy)
            {

                dialogBox.SetActive(false);
            }

            else
            {

                dialogBox.SetActive(true);
                hideQI.transform.localScale = scaleChange;

                StartCoroutine(QuestItemTimer());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("Player"))
        {

            playerInRangeQI = true;
        }
    }

    private void OnTriggerExit2D(Collider2D insideQuestRange)
    {

        if (insideQuestRange.CompareTag("Player"))
        {

            playerInRangeQI = false;
            dialogBox.SetActive(false);
        }
    }

    public IEnumerator QuestItemTimer()
    {

        yield return new WaitForSeconds(5f);
        hideQI.SetActive(false);
    }
}
