using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCommon : MonoBehaviour {

    // Use this for initialization
    public static GameCommon instance = null;
    public enum Turns {FIRST,SECOND,THIRD,FORTH,DARKLORD };
    public Turns currentTurn;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        currentTurn = Turns.FIRST;
    }
}
