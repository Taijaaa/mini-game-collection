using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGameCollection.Games2025.Team11
{
    public class PlayerMovement : MiniGameBehaviour
    {
        public float moveSpeed = 5f;

        private Rigidbody2D rb;
        private Vector2 moveInput;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            moveInput = Vector2.zero;

            // Direct key checks
            if (ArcadeInput.Player1.Up.Held)
                moveInput.y += 1;
            if (ArcadeInput.Player1.Down.Held)
                moveInput.y -= 1;
            if (ArcadeInput.Player1.Left.Held)
                moveInput.x -= 1;
            if (ArcadeInput.Player1.Right.Held)
                moveInput.x += 1;

            // Normalize to prevent diagonal speed boost
            moveInput = moveInput.normalized;
        }

        void FixedUpdate()
        {
            rb.velocity = moveInput * moveSpeed;
        }
    }
}
