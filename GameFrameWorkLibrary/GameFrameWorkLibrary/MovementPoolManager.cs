using System;
using System.Collections.Generic;
using System.Text;

namespace GameFrameWorkLibrary
{
    class MovementPoolManager
    {
        // list to add available movements
        List<IMovement> A_Movements = new List<IMovement>();

        // list to add occupied movements
        List<IMovement> O_Movements = new List<IMovement>();


        private static MovementPoolManager movementPoolManagerInstance = null;

        // method to get instance of this class
        public static MovementPoolManager GetMovementPoolManagerInstance()
        {
            if(movementPoolManagerInstance == null)
            {
                movementPoolManagerInstance = new MovementPoolManager();
            }
            return movementPoolManagerInstance;
        }

        // method to get movement
        public IMovement GetResourse(Type objectType)
        {
            foreach (IMovement movement1 in A_Movements)
            {
                if(movement1.GetType() == objectType)
                {
                    return movement1;
                }
            }
            IMovement movement = (IMovement)Activator.CreateInstance(objectType);
            A_Movements.Add(movement);
            return movement;
        }

        // method to release movement
        public void ReleaseResourse(IMovement movement)
        {
            bool is_already = false;
            foreach (IMovement movement1 in A_Movements)
            {
                if(movement == movement1)
                {
                    is_already = true;
                }
            }
            if(!is_already)
            A_Movements.Add(movement);
        }
    }
}
