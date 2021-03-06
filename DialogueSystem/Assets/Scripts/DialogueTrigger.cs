using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// (!) This is a template that can also be reused with different data, on
//     different game objects, each time!

public class DialogueTrigger : MonoBehaviour
{
    public DialogueEntry[] dialogueEntries;
    public Actor[] actors;
    
    // Start the dialogue exchange!
    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(dialogueEntries, actors);
    }
}

// Class that stores info about the dialogue
[System.Serializable]
public class DialogueEntry
{
    // Two fields each dialogue should consist of
    public int actorId;
    public string dialogueText;
}

// Class that stores info about the Actor and its portrait
[System.Serializable]
public class Actor
{
    public string actorName;
    public Sprite actorSprite;
}





// (!) The Dialogue Trigger is in charge of:
//      - Holding data about messages and actors
//      - Sends messages to Dialogue Manager
//      - Holds unique/separate data for every NPC (or button!)
    
// Dialogue Trigger holds TWO types of information:
//  1. Dialogue Messages:
//      - A list of dialogue messages with an
//        actor ID
//      - Actors taking part in the conversation
//  2. Actors:
//      - The name of the actor
//      - The image for the actor
    
// Messages and actors will be linked!