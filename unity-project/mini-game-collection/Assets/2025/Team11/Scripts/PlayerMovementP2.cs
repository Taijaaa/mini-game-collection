using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGameCollection.Games2025.Team11
{
    public class PlayerMovementP2 : MiniGameBehaviour
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

            //Target
            if (ArcadeInput.Player2.Action1.Pressed)
            {
                Target();

            }
            // Direct key checks
            if (ArcadeInput.Player2.Up.Held)
                moveInput.y += 1;
            if (ArcadeInput.Player2.Down.Held)
                moveInput.y -= 1;
            if (ArcadeInput.Player2.Left.Held)
                moveInput.x -= 1;
            if (ArcadeInput.Player2.Right.Held)
                moveInput.x += 1;

            // Normalize to prevent diagonal speed boost
            moveInput = moveInput.normalized;
        }

        void FixedUpdate()
        {
            rb.velocity = moveInput * moveSpeed;
        }

        void Target()

        {
            float radius = 0.1f;
            Vector2 position = transform.position;
            ContactFilter2D filter = new ContactFilter2D();
            filter.useTriggers = true;
            Collider2D[] colliders = new Collider2D[2];

            int hits = Physics2D.OverlapCircle(position, radius, filter, colliders);

            Debug.Log(hits);
            foreach (Collider2D collider in colliders)
            {
                if (collider == null) return;
                if (collider.GetComponent<Balloon>() != null)
                {
                    if (!collider.GetComponent<Balloon>().player1) Debug.Log("PLAYER 2");
                    Destroy(collider.gameObject);
                }
            }
        }
    }


}
