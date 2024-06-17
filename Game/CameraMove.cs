using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform player;

    void Start()
    {
        transform.position = new Vector3(0f, 9.76f, -10f);
        transform.rotation = Quaternion.Euler(33f, 0f, 0f);
    }

    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if(player.transform.position.z >= 2.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0f, 6f, 0f), 0.1f);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(20f, 0f, 0f), Time.deltaTime * 1.0f);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0f, 9.76f, -10f), 0.1f);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(33f, 0f, 0f), Time.deltaTime * 1.0f);

        }
    }
}
