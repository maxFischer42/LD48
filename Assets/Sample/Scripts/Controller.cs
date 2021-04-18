using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ControllerComponent
{
    public class Controller : MonoBehaviour
    {
        Vector2 movementAxis = new Vector2();
        Vector2 movementAxisRaw = new Vector2();
        bool primaryAction = false;
        bool secondaryAction = false;
        public LayerMask collisionLayers;
        private float collisionCastDistance = 0.1f;

        // Sets the inputs for the controller every 60 frames
        private void Update()
        {
            float _x = Input.GetAxis("Horizontal");
            float _y = Input.GetAxis("Vertical");
            movementAxis = new Vector2(_x, _y);
            primaryAction = Input.GetButtonDown("Fire1");
            secondaryAction = Input.GetButtonDown("Fire2");
            _x = Input.GetAxisRaw("Horizontal");
            _y = Input.GetAxisRaw("Vertical");
            movementAxisRaw = new Vector2(_x, _y);
        }

        public Vector2 getMovementAxis()
        {
            return movementAxis;
        }

        public Vector2 getMovementAxisRaw()
        {
            return movementAxisRaw;
        }

        public bool getAction(int _type)
        {
            switch(_type)
            {
                case 0:
                    return primaryAction;
                case 1:
                    return secondaryAction;
                default:
                    return false;
            }
        }

        // Check if there is a collidable object in the desired path
        public bool getRayToDirection2D(Vector2 direction)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, collisionCastDistance, collisionLayers);
            if (hit.collider)
            {
                return true;
            }
            return false;
        }

    }
}