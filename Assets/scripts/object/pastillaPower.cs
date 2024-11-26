using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pastilla : MonoBehaviour
{

    public GameObject candy;
    public bool grajea = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("grajea"))
        {           
            candy.SetActive(false);
            grajea = true;
            Destroy(other.gameObject);
            Invoke(nameof(DesactivarGrajea), 5f);
        }
    }

    private void DesactivarGrajea()
    {
        grajea = false;
    }
}
