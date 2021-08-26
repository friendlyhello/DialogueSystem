using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // (!) The Dialogue Manager is in charge of:
    //      - Opening and closing dialogue box
    //      - Displaying the correct text
    
    // Variables that will link the text and sprite objects in the editor
    public Image actorImage;
    public Text actorName;
    public Text dialogueText;
    public RectTransform dialogueBoxBg;

    // Variables for Actors and Dialogue messages in the -currently active- dialogue session
    public DialogueEntry[] currentDialogueEntries;
    public Actor[] currentActors;

    // Count current message progress
    private int activeDialogueCount = 0;
    
    //** NOW COMES THE MAGIC */
    // Method to get Actors and Dialogue Entries from DialogueTrigger.cs that will display
    // the first dialogue entry!
    
    // Method parameters are what info do we wanna get?
    public void OpenDialogue(DialogueEntry[] dialogueEntries, Actor[] actors)
    {
        // Assign parameters to the current variables in this script
        currentDialogueEntries = dialogueEntries;
        currentActors = actors;
        activeDialogueCount = 0;
        
        Debug.Log("Started conversation! Loaded dialogue: " + dialogueEntries.Length);  

    }
}
