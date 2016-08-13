using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Commands
{
    public class JumpCommand : ICommand
    {
        private Rigidbody2D rigidBody;
        private float jumpSpeed;

        public JumpCommand(Rigidbody2D rigidBody, float jumpSpeed)
        {
            this.rigidBody = rigidBody;
            this.jumpSpeed = jumpSpeed;
        }

        public void Execute()
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
            //Vector2 force = new Vector2(0, 23);
            //this.player.AddForce(force);
        }
    }
}
