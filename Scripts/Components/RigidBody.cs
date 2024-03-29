﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace LD48.Scripts
{
    public class RigidBody : Component
    {
        public enum RigidBodyType { Static, Dynamic }

        Transform transform;
        RigidBodyType bodyType;
        float angularVelocity;
        Vector2 moveVelocity;
        float mass;

        public Transform Transform { get { return transform; } }
        public RigidBodyType BodyType { get { return bodyType; } }
        public float AngularVelocity { get { return angularVelocity; } }
        public Vector2 MoveVelocity { get { return moveVelocity; } }
        public float Mass { get { return mass; } }
        public float Force { get { return mass * moveVelocity.Length(); } }

        public RigidBody(string name, GameObject go, RigidBodyType rbt, int uo) : base(uo, name)
        {
            transform = (Transform)go.ComponentHandler.GetComponent("transform");
            bodyType = rbt;
            angularVelocity = 0;
            moveVelocity = new Vector2(0,0);
            mass = 0;
        }
        public RigidBody(GameObject go, RigidBodyType rbt, int uo) : base(uo, "rigidBody")
        {
            transform = (Transform)go.ComponentHandler.GetComponent("transform");
            bodyType = rbt;
            angularVelocity = 0;
            moveVelocity = new Vector2(0, 0);
            mass = 0;
        }

        public override void Update(float gt)
        {
            Transform.Move(moveVelocity);
            transform.Rotate(angularVelocity);
            moveVelocity = new Vector2();
            angularVelocity = 0;
            base.Update(gt);
        }

        public void UpdateVelocity(Vector2 v)
        {
            moveVelocity = v;
        }

        public void UpdateRotationalVelocity(float r)
        {
            angularVelocity = r;
        }
    }
}
