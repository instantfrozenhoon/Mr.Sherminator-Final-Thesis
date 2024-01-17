using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FirstTutor : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private GameObject dialogBox;
/*    [SerializeField] private TextMeshProUGUI dialogText;
    [SerializeField] private TextMeshProUGUI dialogTextName;*/
    [SerializeField] private GameObject hint;
    [SerializeField] private bool playerInRange;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip Dialog;

    public bool interactedItem;

    private void Awake()
    {
        hint.SetActive(true);
        interactedItem = false;
    }

    public void ButtonClose()
    {
        dialogBox.SetActive(false);
        interactedItem = true;
    }

    public void ButtonTutor()
    {
        if (!interactedItem) {
            if (playerInRange)
            {
/*                dialogTextName.text = "";
                dialogText.text = "In this example, the shape looks like this. Put this shape in mind and go to next shape.";*/
                hint.SetActive(false);
                dialogBox.SetActive(true);
                audioSource.clip = Dialog;
                audioSource.Play();
            }
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
