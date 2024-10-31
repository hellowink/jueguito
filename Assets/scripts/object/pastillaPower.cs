using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pastilla : MonoBehaviour
{
    public bool grajea = false;




    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("grajea"))
        {
            grajea = true;
            Destroy(other.gameObject);
            Invoke(nameof(DesactivarGrajea), 6f);
        }
    }

    private void DesactivarGrajea()
    {
        grajea = false;
    }
}
