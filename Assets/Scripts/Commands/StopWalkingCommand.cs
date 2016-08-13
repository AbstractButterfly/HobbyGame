using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Commands
{
    public class StopWalkingCommand : ICommand
    {
        Rigidbody2D rigidbody2D;

        public StopWalkingCommand(Rigidbody2D rigidbody2D)
        {
            this.rigidbody2D = rigidbody2D;
        }

        public void Execute()
        {
            this.rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            //vector2 force = this.direction * this.speed;
            //this.rigidbody2d.addforce(force);
        }
    }
}
