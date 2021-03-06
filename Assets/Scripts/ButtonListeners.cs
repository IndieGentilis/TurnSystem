﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListeners : MonoBehaviour {

    [SerializeField]
    private Animator panelTurnAnimator;
    [SerializeField]
    private Text turnText;

    public void nextTurn(){
            if (!GameCommon.instance.isRolling) {
                switch (GameCommon.instance.currentTurn) {
                    case GameCommon.Turns.FIRST:
                        GameCommon.instance.currentTurn = GameCommon.Turns.SECOND;
                        GameCommon.instance.canRoll = true;
                        turnText.text = "SECOND";
                        panelTurnAnimator.SetTrigger("Display");
                        break;
                    case GameCommon.Turns.SECOND:
                        GameCommon.instance.currentTurn = GameCommon.Turns.THIRD;
                        GameCommon.instance.canRoll = true;
                        turnText.text = "THIRD";
                        panelTurnAnimator.SetTrigger("Display");
                    break;
                    case GameCommon.Turns.THIRD:
                        GameCommon.instance.currentTurn = GameCommon.Turns.FORTH;
                        GameCommon.instance.canRoll = true;
                        turnText.text = "FORTH";
                        panelTurnAnimator.SetTrigger("Display");
                    break;
                    case GameCommon.Turns.FORTH:
                        GameCommon.instance.currentTurn = GameCommon.Turns.DARKLORD;
                        GameCommon.instance.canRoll = true;
                        turnText.text = "DARKLORD";
                        panelTurnAnimator.SetTrigger("Display");
                    break;
                    case GameCommon.Turns.DARKLORD:
                        GameCommon.instance.currentTurn = GameCommon.Turns.FIRST;
                        GameCommon.instance.canRoll = true;
                        turnText.text = "FIRST";
                        panelTurnAnimator.SetTrigger("Display");
                    break;
                    default:
                        break;

                }

            }
    }
}
