﻿using Microsoft.Xna.Framework;

namespace MonoGame_Core.Scripts
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

        public override void Update(GameTime gt)
        {
            base.Update(gt);
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}
