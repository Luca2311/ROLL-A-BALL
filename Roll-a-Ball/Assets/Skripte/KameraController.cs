using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 pomak;
    private void Start()
    {
        pomak = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + pomak;
    }
}
