using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Diary : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;
    private int page = 0;
    

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && playerInRange)
        {
            if (dialogBox.activeInHierarchy && page == 8)
            {
                dialogBox.SetActive(false);
                page = 0;
            }
            else if (page == 0)
            {
                dialogBox.SetActive(true);
                dialogText.text = " Day 1: Today I arrived. I'm very excited to know more about this simulation. Tomorrow I'll go for a walk. \n"  +  " Next Page ->";
                page = 1;
            }
            else if (page == 1)
            {
                dialogBox.SetActive(true);
                dialogText.text = "Day 2: Everything is so beautiful! I loved talking to the NPC's. \n" + " Next Page ->";
                page = 2;

            }
            else if ( page == 2)
            {
                dialogBox.SetActive(true);
                dialogText.text = "Day 5: I think I'm happy with what I saw. Tomorrow I'll go to the dungeon and go back home. \n " + " Next Page ->";
                page = 3;
            }

            else if (page == 3)
            {
                dialogBox.SetActive(true);
                dialogText.text = "Day 6: Shit! I didn't find the boss! I don't know how to come back! \n" + " Next Page ->";
                page = 4;
            }

            else if (page == 4)
            {
                dialogBox.SetActive(true);
                dialogText.text = "Day 10: I still didn't find a way to come back. I hate this place, nothing changes. \n" + " Next Page ->";
                page = 5;
            }

            else if (page == 5)
            {
                dialogBox.SetActive(true);
                dialogText.text = "Day 13: These NPC's make me sick! \n" + " Next Page ->";
                page = 6;
            }

            else if (page == 6)
            {
                dialogBox.SetActive(true);
                dialogText.text = "Day 15: I don't know what is real anymore. What if my whole life was a simulation? \n" + " Next Page ->";
                page = 7;
            }

            else if (page == 7)
            {
                dialogBox.SetActive(true);
                dialogText.text = "Day 17: I'm going to the dungeon! The answer must be there! \n " +   "End.";
                page = 8;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
            page = 0;
        }
    }
}