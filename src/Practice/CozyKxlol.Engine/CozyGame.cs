﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyKxlol.Engine
{
    public class CozyGame : Game
    {
        protected GraphicsDeviceManager graphics;
        protected SpriteBatch spriteBatch;
        
        public static SpriteFont nolmalFont;

        public Point WindowSize
        {
            get
            {
                return CozyDirector.Instance.WindowSize;
            }
            set
            {
                graphics.PreferredBackBufferWidth   = value.X;
                graphics.PreferredBackBufferHeight  = value.Y;
                CozyDirector.Instance.WindowSize = value;
            }
        }

        public CozyGame()
        {
            graphics = new GraphicsDeviceManager(this);
            CozyDirector.Instance.GameInstance = this;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            nolmalFont = Content.Load<SpriteFont>("Font/Nolmal");
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.Immediate);
            CozyDirector.Instance.RunningScene.Draw(gameTime, spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        protected override void Update(GameTime gameTime)
        {
            CozyDirector.Instance.RunningScene.Update(gameTime);
            CozyDirector.Instance.ActionManagerInstance.Update(gameTime);
            base.Update(gameTime);
        }
    }
}
