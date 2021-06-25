using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class MovementPoolManager
    {
        // Dictionary to add available movements
        Dictionary<GameObjectMotionType, IMovement> A_Movements = new Dictionary<GameObjectMotionType, IMovement>();

        // Dictionary to add occupied movements
        Dictionary<GameObjectMotionType, IMovement> O_Movements = new Dictionary<GameObjectMotionType, IMovement>();

        Dictionary<GameObjectMotionType, IMovement> MotionTypes = new Dictionary<GameObjectMotionType, IMovement>() {
            { GameObjectMotionType.LEFT, new LeftMovement() },
            { GameObjectMotionType.RIGHT, new RightMovement() },
            { GameObjectMotionType.DOWN, new FallingMovement() },
            { GameObjectMotionType.KEYBOARD_INPUT, new KeyboardInputMovement() }};

        private static MovementPoolManager movementPoolManagerInstance = null;

        // method to get instance of this class
        public static MovementPoolManager GetMovementPoolManagerInstance()
        {
            if (movementPoolManagerInstance == null)
            {
                movementPoolManagerInstance = new MovementPoolManager();
            }
            return movementPoolManagerInstance;
        }

        // method to get movement
        public IMovement GetResourse(GameObjectMotionType objectType)
        {
            IMovement movement;
            try
            {
                movement = A_Movements[objectType];
                if(objectType == GameObjectMotionType.KEYBOARD_INPUT)
                {
                    O_Movements.Add(objectType , A_Movements[objectType]);
                    A_Movements.Remove(objectType);
                }
                return movement;
            }
            catch
            {
                A_Movements.Add(objectType , MotionTypes[objectType]);
                return MotionTypes[objectType];
            }
        }

        // method to release movement
        public void ReleaseResourse(IMovement movement, GameObjectMotionType objectType)
        {
            if (objectType == GameObjectMotionType.KEYBOARD_INPUT)
            {
                try
                {
                    A_Movements.Add(objectType, movement);
                    O_Movements.Remove(objectType);
                }
                catch
                {

                }
            }
        }
    }
}
