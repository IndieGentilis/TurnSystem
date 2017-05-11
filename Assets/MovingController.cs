using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingController : MonoBehaviour {

    public LayerMask blockingLayer;

    private BoxCollider2D boxCollider;
    private Rigidbody2D rigidBody;
    private float inverseMoveTime;
    public float moveTime = 0.1f;
    private bool moving;

    // Use this for initialization
    protected virtual void Start () {
        boxCollider = GetComponent<BoxCollider2D>();

        rigidBody = GetComponent<Rigidbody2D>();

        inverseMoveTime = 1f / moveTime;

        moving = false;
	}

    protected bool Move(int x, int y, out RaycastHit2D hit) {
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(x, y);
        boxCollider.enabled = false;
        hit = Physics2D.Linecast(start, end, blockingLayer);
        boxCollider.enabled = true;
        if(hit.transform == null) {
            StartCoroutine(SmoothMovement(end));

            return true;
        }

        return false;
    }

    private IEnumerator SmoothMovement(Vector3 end) {
        float distance = (transform.position - end).sqrMagnitude;
        moving = true;
        while(distance > float.Epsilon) {
            Vector3 newPosition = Vector3.MoveTowards(rigidBody.position, end, inverseMoveTime * Time.deltaTime);

            rigidBody.MovePosition(newPosition);

            distance = (transform.position - end).sqrMagnitude;

            yield return null;
        }
    }

    protected virtual void AttemptMove<T>(int xDir, int yDir) where T : Component {
        RaycastHit2D hit;

        bool canMove = Move(xDir, yDir, out hit) && !moving;

        if (hit.transform == null)
            return;

        T hitComponent = hit.transform.GetComponent<T>();

        if (!canMove && hitComponent != null)

            OnCantMove(hitComponent);
    }

    protected abstract void OnCantMove<T>(T component)
        where T : Component;


// Update is called once per frame
void Update () {
		
	}
}
