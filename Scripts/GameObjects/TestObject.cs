﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace LD48.Scripts
{
    public class TestObject : WorldObject
    {
        public TestObject(string texID, string tag) : base(texID, tag)
        {
            Transform.Resize(40, 40);
            SpriteRenderer.DrawArea = new Vector2(40, 40);
            BehaviorHandler.AddBehavior(new TestControls(0, RigidBody));
            ComponentHandler.AddComponent(new CollisionBox(this, 0, "myBox", false));

            ((CollisionHandler)ComponentHandler.GetComponent("collisionHandler")).myActions.Add(new CollisionActions("myBox", new List<string> { "myBox" }, new List<collisionAction> { CollisionBehaviors.UndoMinPen }));
        }
    }
}
