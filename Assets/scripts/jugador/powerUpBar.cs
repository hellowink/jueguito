using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUpBar : MonoBehaviour
{
    public Image powerUp;

    public float powerActually = 0;
    public float powerMax= 10;
    public float powerMin = 0;
    void Update()
    {
        powerUp.fillAmount = powerActually / powerMax;
    }

    public void SumarPoder(int cantidad)
    {
        powerActually = Mathf.Min(powerActually + cantidad, powerMax);
    }
}
