using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ControllerComponent
{
    public class Controller : MonoBehaviour
    {
        Vector2 movementAxis = new Vector2();
        bool primaryAction = false;
        bool secondaryAction = false;
        Behaviour rb;

        // Sets the inputs for the controller every 60 frames
        private void Update()
        {
            float _x = Input.GetAxis("Horizontal");
            float _y = Input.GetAxis("Vertical");
            movementAxis = new Vector2(_x, _y);
            primaryAction = Input.GetButtonDown("Fire1");
            secondaryAction = Input.GetButtonDown("Fire2");
        }

        public void SetRigidBody(Behaviour _rb)
        {
            rb = _rb;
        }

        public Vector2 getMovementAxis()
        {
            return movementAxis;
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

    }
}