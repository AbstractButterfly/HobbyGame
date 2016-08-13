using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Commands
{
    public class WalkCommand : ICommand
    {
        Rigidbody2D rigidbody2D;
        Vector2 direction;
        float speed;

        public WalkCommand(Rigidbody2D rigidbody2D, Vector2 direction, float speed)
        {
            this.rigidbody2D = rigidbody2D;
            this.direction = direction;
            this.speed = speed;
        }

        public void Execute()
        {
            Vector2 newVelocity = this.rigidbody2D.velocity;
            newVelocity.x = this.direction.x * this.speed;
            this.rigidbody2D.velocity = newVelocity;
            //vector2 force = this.direction * this.speed;
            //this.rigidbody2d.addforce(force);
        }
    }
}
