using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListeners : MonoBehaviour {

public void nextTurn()
    {
        if (!GameCommon.instance.isRolling) {

            switch (GameCommon.instance.currentTurn) {
                case GameCommon.Turns.FIRST:
                    GameCommon.instance.currentTurn = GameCommon.Turns.SECOND;
                    GameCommon.instance.canRoll = true;
                    break;
                case GameCommon.Turns.SECOND:
                    GameCommon.instance.currentTurn = GameCommon.Turns.THIRD;
                    GameCommon.instance.canRoll = true;
                    break;
                case GameCommon.Turns.THIRD:
                    GameCommon.instance.currentTurn = GameCommon.Turns.FORTH;
                    GameCommon.instance.canRoll = true;
                    break;
                case GameCommon.Turns.FORTH:
                    GameCommon.instance.currentTurn = GameCommon.Turns.DARKLORD;
                    GameCommon.instance.canRoll = true;
                    break;
                case GameCommon.Turns.DARKLORD:
                    GameCommon.instance.currentTurn = GameCommon.Turns.FIRST;
                    GameCommon.instance.canRoll = true;
                    break;
                default:
                    break;

            }

        }
    }
}
