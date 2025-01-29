using Microsoft.Xna.Framework.Graphics;
using monogameGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class pipe : gameEntity
{
    
    public pipe(GameManager game, Vector2 initialPosition) : base(game, initialPosition)
    {
        sprite = gameManager.Content.Load<Texture2D>("googly-c");
    }
    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);
        if (position.X < 0 - sprite.Width)
        {

        }
    }
}