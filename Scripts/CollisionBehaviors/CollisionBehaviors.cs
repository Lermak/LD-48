﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace LD48.Scripts
{
    public static class CollisionBehaviors
    {
        public static void UndoMinPen(CollisionBox a, CollisionBox b, Vector2 p)
        {
            ((WorldObject)a.MyObject).Transform.Move(p);
        }
    }
}
