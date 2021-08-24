using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue[] Dialogues;
    public Actor[] Actors;
}

// Class that stores info about the dialogue
[System.Serializable]
public class Dialogue
{
    // Two fields each message should consist of
    public int actorId;
    public string dialogue;
}

// Class that stores info about the Actor and its portrait
[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}

// (!) This is a template that can also be reused with different data each time




// (!) The Dialogue Trigger is in charge of:
//      - Holding data about messages and actors
//      - Sends messages to Dialogue Manager
//      - Holds unique/separate data for every NPC (or button!)
    
// Dialogue Trigger holds TWO types of information:
//  1. Messages:
//      - A list of messages (in hierarchical order ex. 0 - 3)
//        with an actor ID
//      - Actors taking part in the conversation
//  2. Actors:
//      - The name of the actor
//      - The image for the actor
    
// Messages and actors will be linked!