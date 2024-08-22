using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveWhenTrigger : MonoBehaviour
{
    public Transform move;
    public float x;
    public float y;
    public float time;
    private bool moveIt = false;
    Vector3 targetPos;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveIt)
        {
            move.position = Vector3.SmoothDamp(move.position, targetPos,ref velocity,time);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            moveIt = true;
        }
    }
}
