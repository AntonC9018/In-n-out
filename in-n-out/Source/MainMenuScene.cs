using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace in_n_out.Scenes
{
    class MainMenuScene : Scene
    {

        GameComponents gameComponents;

        public MainMenuScene()
        {
        }

        public void Load(GameComponents gameComponents)
        {
            this.gameComponents = gameComponents;
            MouseState mouseState = Mouse.GetState();
            Console.WriteLine("Hello");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Resume()
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(GameTime gameTime)
        {
            
        }
    }
}
