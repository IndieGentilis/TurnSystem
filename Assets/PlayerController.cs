using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MovingController {

    private Animator animator;

    protected override void OnCantMove<T>(T component) {
        throw new NotImplementedException();
    }

    protected override void Start () {
        animator = GetComponent<Animator>();

        base.Start();
	}
	
	// Update is called once per frame
	private void Update () {
        int horizontal = 0;
        int vertical = 0;

        horizontal = (int) Input.GetAxisRaw("Horizontal");
        vertical = (int)Input.GetAxisRaw("Vertical");

        if (horizontal != 0) {
            AttemptMove<Rock>(horizontal, 0);
        } else if (vertical != 0) {
            AttemptMove<Rock>(0, vertical);
        }
	}
}
