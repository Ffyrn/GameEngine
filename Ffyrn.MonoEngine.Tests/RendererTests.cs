using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NSubstitute;
using Xunit;

namespace Ffyrn.MonoEngine.Tests
{
    public class RendererTests
    {
        // There is no clear way of mocking GraphicsDevice, but this test is here as an example.
        // [Fact]
        // public void DrawRectangle_CallsSpriteBatchBeginAndEnd()
        // {
        //     // Arrange
        //     var mockGraphicsDevice = Substitute.For<GraphicsDevice>();
        //     var mockSpriteBatch = Substitute.For<SpriteBatch>(mockGraphicsDevice);
        //     var renderer = Substitute.For<Renderer>();
        //
        //     // Act
        //     renderer.DrawRectangle(Color.Red, 0, 0, 10, 10);
        //
        //     // Assert
        //     mockSpriteBatch.Received(1).Begin();
        //     mockSpriteBatch.Received(1).End();
        // }
    }
}
