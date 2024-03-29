﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace LD48.Scripts
{
    public class Scene
    {
        protected Vector2 size;
        protected ContentManager Content;
        public Vector2 Size { get { return size; } }

        public Dictionary<string, Texture2D> Textures = new Dictionary<string, Texture2D>();
        public Dictionary<string, GameObject> GameObjects = new Dictionary<string, GameObject>();
        public Dictionary<string, Song> Songs = new Dictionary<string, Song>();
        public Dictionary<string, SoundEffect> SoundEffects= new Dictionary<string, SoundEffect>();
        public virtual void Initilize(ContentManager c)
        {
            Content = c;
            CollisionManager.Clear();
            RenderingManager.Clear();
            SoundManager.Clear();
            Camera.Initilize();
        }

        public virtual void OnLoad()
        {

        }

        public virtual void OnExit()
        {

        }

        public virtual void Update(float gt)
        {
            foreach (GameObject go in GameObjects.Values)
            {
                go.Update(gt);
            }
        }
    }
}
