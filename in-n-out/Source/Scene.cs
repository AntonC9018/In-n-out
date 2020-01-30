using Game1.Source;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Source
{
    interface Scene
    {

        // Called before Start() to get all resources into memory:
        void Load(GameComponents graphicsStruct);

        // Called once when the Scene becomes the currently active scene
        // Doesn't get called on menu overlay. See Pause()
        void Start();

        // Called to do a clean-up of the graphics on the screen and
        // Save stuff on disk if necessary
        void Exit();

        // Called to temporarily stop in-game logic and animations 
        // once an overlay is applied
        void Pause();

        // Called once an overlay is removed
        void Resume();

        void Update(GameTime gameTime);

        void Draw(GameTime gameTime);

    }
}
