using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork
{
    /// <summary>
    /// Factory Design Method
    /// </summary>
    static class CreateMovement
    {

        // array list to add objects that have been created
        // to keep track that how many types of objects are created
        public static ArrayList arrayList = new ArrayList();


        /// <summary>
        /// Method to create left movement
        /// </summary>
        public static Movement MoveLeft()
        {
            Movement motion = new LeftMovement();
            arrayList.Add(motion);
            return motion;
        }

        /// <summary>
        /// Method to create Right movement
        /// </summary>
        public static Movement MoveRight()
        {
            Movement motion = new RigthMovement();
            arrayList.Add(motion);
            return motion;
        }

        /// <summary>
        /// Method to create Falling movement
        /// </summary>
        public static Movement MoveDown()
        {
            Movement motion = new FallingMovement();
            arrayList.Add(motion);
            return motion;
        }

        /// <summary>
        /// Method to create Keyboard Input movement
        /// </summary>
        public static Movement MoveWithKeyboardInput()
        {
            Movement motion = new KeyboardInputMovement();
            arrayList.Add(motion);
            return motion;
        }
    }
}
