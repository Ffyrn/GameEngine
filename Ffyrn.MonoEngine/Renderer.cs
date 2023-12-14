using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Ffyrn.MonoEngine
{
    public class Renderer
    {
        private readonly GraphicsDevice _graphicsDevice;
        private readonly SpriteBatch _spriteBatch;

        public Renderer(GraphicsDevice graphicsDevice)
        {
            _graphicsDevice = graphicsDevice;
            _spriteBatch = new SpriteBatch(_graphicsDevice);
        }
        
        public void DrawRectangle(Color color, int x, int y, int width, int height)
        {
            _spriteBatch.Begin();
            
            var rectangle = new Texture2D(_graphicsDevice, 1, 1); // Create a 1x1 texture for drawing rectangles
            rectangle.SetData(new[] { color }); // Set the colour of the texture
            
            _spriteBatch.Draw(rectangle, new Rectangle(x, y, width, height), Color.White);
            _spriteBatch.End();
        }
    }
}
