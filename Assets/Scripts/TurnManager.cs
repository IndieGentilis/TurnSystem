using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour {
    public Button nextTurnButton;

    private enum Turns {FIRST,SECOND,THIRD,FORTH,DARKLORD};
    private Turns currentTurn;
    private static TurnManager turnManager;

	void Start () {
        if (turnManager != null) {
            Destroy(this.gameObject);
        }
        turnManager = this;
        currentTurn = Turns.FIRST;
        nextTurnButton.onClick.AddListener(() => nextTurn());
    }
	
	void Update () {
        switch (currentTurn){
            case Turns.FIRST:
                //First Logic
                Debug.Log("First");
                break;
            case Turns.SECOND:
                //Second logic
                Debug.Log("SECOND");
                break;
            case Turns.THIRD:
                // Third logic
                Debug.Log("THIRD");
                break;
            case Turns.FORTH:
                // Forth logic
                Debug.Log("FORTH");
                break;
            case Turns.DARKLORD:
                //DARKLORD LOGIC
                Debug.Log("DARKLORD");
                break;
            default:
                break;

        }
	}
    void nextTurn(){
        switch (currentTurn)
        {
            case Turns.FIRST:
                currentTurn = Turns.SECOND;
                break;
            case Turns.SECOND:
                currentTurn = Turns.THIRD;
                break;
            case Turns.THIRD:
                currentTurn = Turns.FORTH;
                break;
            case Turns.FORTH:
                currentTurn = Turns.DARKLORD;
                break;
            case Turns.DARKLORD:
                currentTurn = Turns.FIRST;
                break;
            default:
                break;

        }
    }
}
