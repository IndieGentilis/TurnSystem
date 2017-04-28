using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DetectingAcceleration : MonoBehaviour
{

    public Text text;

    private float accelerometerUpdateInterval = 1.0f / 60.0f;
    private float lowPassKernelWidthInSeconds = 1.0f;
    private float shakeDetectionThreshold = 2.0f;
    private float lowPassFilterFactor;
    

    public Sprite[] diceFaces;
    private bool isRolling;
    private int resultDiceFace;
    private float rollingTime = 3f;
    private bool detectedShake = false;
    private float time = 1f;

    Vector3 lowPassValue;

    void Start()
    {
        lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
        shakeDetectionThreshold *= shakeDetectionThreshold;
        lowPassValue = Input.acceleration;
        isRolling = false;

    }

    void Update()
    {
        Vector3 acceleration = Input.acceleration;
        lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
        Vector3 deltaAcceleration = acceleration - lowPassValue;

        if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold) {
            text.text = "Shake event detected at time " + Time.time;
            detectedShake = true;
            isRolling = true;

        }

        if (detectedShake && GameCommon.instance.canRoll)
        {
            if (isRolling && rollingTime > 0) rollingTime -= Time.time;
            StartCoroutine(startRollingDice());
        }
        
    }

    void generateRandomDiceFace()
    {
        resultDiceFace = Random.Range(0, 6);
        GetComponent<SpriteRenderer>().sprite = diceFaces[resultDiceFace];
    }
    IEnumerator startRollingDice()
    {
        generateRandomDiceFace();
        yield return new WaitForSeconds(time);
        if (isRolling && rollingTime > 0)
        {
            
            StartCoroutine(startRollingDice());
        }
        else
        {
            isRolling = false;
            GameCommon.instance.canRoll = false;
            detectedShake = false;
        }
    }
}
