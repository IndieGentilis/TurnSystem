using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour {

    private static TurnManager turnManager;

	void Start () {
        if (turnManager != null) {
            Destroy(this.gameObject);
        }
        turnManager = this;
    }
	
	void Update () {
        switch (GameCommon.instance.currentTurn){
            case GameCommon.Turns.FIRST:
                //First Logic
                Debug.Log("First");
                break;
            case GameCommon.Turns.SECOND:
                //Second logic
                Debug.Log("SECOND");
                break;
            case GameCommon.Turns.THIRD:
                // Third logic
                Debug.Log("THIRD");
                break;
            case GameCommon.Turns.FORTH:
                // Forth logic
                Debug.Log("FORTH");
                break;
            case GameCommon.Turns.DARKLORD:
                //DARKLORD LOGIC
                Debug.Log("DARKLORD");
                break;
            default:
                break;

        }
	}
}
