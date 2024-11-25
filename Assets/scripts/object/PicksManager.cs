using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicksManager : MonoBehaviour
{
    void OnEnable()
    {
        trap.ActivateEvent += ActivateEventPicks;
    }
    void OnDisable()
    {
        trap.ActivateEvent -= ActivateEventPicks;
    }
    void ActivateEventPicks()
    {
        GameObject[] picks = GameObject.FindGameObjectsWithTag("pick");

        foreach (GameObject pick in picks)
        {
            if (!pick.GetComponent<Rigidbody>())
            {
                pick.AddComponent<Rigidbody>();
            }

            pick.GetComponent<Rigidbody>().useGravity = true;

            pick.AddComponent<DestroyOnCollision>();
        }
    }

    public class DestroyOnCollision : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    }
}
