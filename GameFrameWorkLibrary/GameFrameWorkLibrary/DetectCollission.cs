using System;
using System.Collections.Generic;
using System.Text;

namespace GameFrameWorkLibrary
{
    class DetectCollission
    {
        private List<GameObject> FirstGameObjects = new List<GameObject>();
        private List<GameObject> SecondGameObjects = new List<GameObject>();

        private static DetectCollission detectCollission = null;

        // to get instance of the class 
        public static DetectCollission GetInstance()
        {
            if (detectCollission != null)
                detectCollission = new DetectCollission();
            return detectCollission;
        }

        // method to add game objects for collision detection
        public void add(GameObject object1, GameObject object2)
        {
            FirstGameObjects.Add(object1);
            SecondGameObjects.Add(object2);
        }

        public void CheckCollision()
        {
            for (int i = 0; i < FirstGameObjects.Count; i++)
            {
                if(FirstGameObjects[i].PictureBox.Left == SecondGameObjects[i].PictureBox.Left &&
                    FirstGameObjects[i].PictureBox.Top == SecondGameObjects[i].PictureBox.Top)
                {
                    SecondGameObjects[i].PictureBox.Visible = false;
                    SecondGameObjects[i].PictureBox.Dispose(); // dispose method will release all the resourses used
                    SecondGameObjects.RemoveAt(i);
                }
            }
        }
    }
}
