using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    [SerializeField] Vector3 offset = new Vector3(0, 5, -10);

    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
