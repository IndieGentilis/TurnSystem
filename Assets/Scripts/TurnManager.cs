using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour {

    private static TurnManager turnManager;
    public Text turnText;
    public Text canRollText;
	void Start () {
        if (turnManager != null) {
            Destroy(this.gameObject);
        }
        turnManager = this;
    }
	
	void Update () {
        turnText.text = "Turno del jugador: " + GameCommon.instance.currentTurn;
        canRollText.text = "Puede tirar: " + GameCommon.instance.canRoll.ToString();
        switch (GameCommon.instance.currentTurn){
            case GameCommon.Turns.FIRST:
                //First Logic

                break;
            case GameCommon.Turns.SECOND:
                //Second logic

                break;
            case GameCommon.Turns.THIRD:
                // Third logic

                break;
            case GameCommon.Turns.FORTH:
                // Forth logic

                break;
            case GameCommon.Turns.DARKLORD:
                //DARKLORD LOGIC

                break;
            default:
                break;

        }
	}
}
