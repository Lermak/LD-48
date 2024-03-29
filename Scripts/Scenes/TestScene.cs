﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace LD48.Scripts
{
    public class TestScene:Scene
    {
        public TestScene():base()
        {
            
        }

        public override void Initilize(ContentManager c)
        {
            base.Initilize(c);

            SoundManager.SongChannels["Melody"] = Content.Load<Song>("Music/TestSong");
            MediaPlayer.Play(SoundManager.SongChannels["Melody"]);

            SoundManager.SoundEffectChannels["TestHit"] = Content.Load<SoundEffect>("Sound/TestHit").CreateInstance();

            Textures = new Dictionary<string, Texture2D>();
            Textures["Test"] = Content.Load<Texture2D>("Test");

            GameObjects = new Dictionary<string, GameObject>();
            GameObjects.Add("test", new TestObject("Test", "testObj"));
            GameObjects.Add("testStatic", new TestStaticObject("Test", "testStatic"));
        }

        public override void Update(float gt)
        {
            base.Update(gt);
        }
    }
}
