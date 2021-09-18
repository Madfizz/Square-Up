﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchpadMovement : MonoBehaviour
{
    // Movement constrictions
    public Transform target;
    public Transform returnTarget;

    void Start()
    {

    }

    // Launchpad comes out of wall to act as barrier for player
    public void BarrierLaunchpad()
    {
        StartCoroutine(Move(target));
    }

    // Launchpad retracts inside wall
    public void RetractLaunchpad()
    {
        StartCoroutine(Move(returnTarget));
    }

    // Move barrier depending on target position
    IEnumerator Move(Transform _target)
    {
        while (Vector3.Distance(transform.position, _target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, Time.deltaTime);

            yield return null;
        }
    }
}