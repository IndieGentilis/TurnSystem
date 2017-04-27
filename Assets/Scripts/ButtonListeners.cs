using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListeners : MonoBehaviour {

public void nextTurn()
    {
        switch (GameCommon.instance.currentTurn)
        {
            case GameCommon.Turns.FIRST:
                GameCommon.instance.currentTurn = GameCommon.Turns.SECOND;
                break;
            case GameCommon.Turns.SECOND:
                GameCommon.instance.currentTurn = GameCommon.Turns.THIRD;
                break;
            case GameCommon.Turns.THIRD:
                GameCommon.instance.currentTurn = GameCommon.Turns.FORTH;
                break;
            case GameCommon.Turns.FORTH:
                GameCommon.instance.currentTurn = GameCommon.Turns.DARKLORD;
                break;
            case GameCommon.Turns.DARKLORD:
                GameCommon.instance.currentTurn = GameCommon.Turns.FIRST;
                break;
            default:
                break;

        }
    }
}
