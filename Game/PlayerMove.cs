using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] joystick joystick;

    Animator anim;


    public float moveSpeed = 3f;
    public float rotateSpeed = 10f;


    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        anim.SetBool("isMove", false);

        float h = joystick.Horizontal();
        float v = joystick.Vertical();

        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        if (!(h == 0 && v == 0))
        {
            anim.SetBool("isMove", true);
            transform.position += dir * moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
        }

    }
}
