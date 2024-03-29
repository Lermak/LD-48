﻿using Microsoft.Xna.Framework;

namespace LD48.Scripts
{
    public class EmptyObject : GameObject
    {
        public EmptyObject(string tag) : base(tag)
        {

        }

        public override void Initilize()
        {
            base.Initilize();
        }

        public override void Update(float gt)
        {
            base.Update(gt);
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}
