using UnityEngine;
using Assets.Scripts.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    // TODO Allow multiple commands per key mapping
    public class KeyboardController
    {
        private IDictionary<KeyCode, ICommand> keyMappings;
        private IDictionary<KeyCode, ICommand> keyDownMappings;
        private IDictionary<KeyCode, ICommand> keyUpMappings;

        public KeyboardController()
        {
            this.keyMappings = new Dictionary<KeyCode, ICommand>();
            this.keyDownMappings = new Dictionary<KeyCode, ICommand>();
            this.keyUpMappings = new Dictionary<KeyCode, ICommand>();
        }

        public void RegisterKey(KeyCode key, ICommand command)
        {
            this.keyMappings[key] = command;
        }
        
        public void RegisterKeyDown(KeyCode key, ICommand command)
        {
            this.keyDownMappings[key] = command;
        }

        public void RegisterKeyUp(KeyCode key, ICommand command)
        {
            this.keyUpMappings[key] = command;
        }

        public void Update()
        {
            foreach (KeyValuePair<KeyCode, ICommand> mapping in this.keyMappings)
            {
                if (Input.GetKey(mapping.Key))
                {
                    mapping.Value.Execute();
                }
            }

            foreach (KeyValuePair<KeyCode, ICommand> mapping in this.keyDownMappings)
            {
                if (Input.GetKeyDown(mapping.Key))
                {
                    mapping.Value.Execute();
                }
            }

            foreach (KeyValuePair<KeyCode, ICommand> mapping in this.keyUpMappings)
            {
                if (Input.GetKeyUp(mapping.Key))
                {
                    mapping.Value.Execute();
                }
            }
        }
    }
}
