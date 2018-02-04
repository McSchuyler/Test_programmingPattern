using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class InputHandler : MonoBehaviour
    {
        //public for easy viewing in inspector
        public List<Command> listCommand = new List<Command>();
        
        public Command inputACommand;
        public Command inputSCommand;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                CommandExecute(inputACommand);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                CommandExecute(inputSCommand);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                ReplayCommand();
            }
        }

        //Replay all command that had been execute
        void ReplayCommand()
        {
            foreach(Command command in listCommand)
            {
                command.Execute();
            }
        }

        //Execute and record command in a list
        void CommandExecute(Command command)
        {
            command.Execute();
            listCommand.Add(command);
        }
    }
}

