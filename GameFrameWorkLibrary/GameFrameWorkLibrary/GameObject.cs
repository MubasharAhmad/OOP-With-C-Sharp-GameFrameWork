using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GameFrameWorkLibrary
{
    class GameObject
    {
        public PictureBox PictureBox;
        public int Speed;
        public IMovement ObjectMotion;
        public GameObjectType objectType;
        MovementPoolManager movementPoolManager;

        // constructor
        internal GameObject(PictureBox pictureBox, int speed, GameObjectType gameObjectType, GameObjectMotionType motion)
        {
            PictureBox = pictureBox;
            Speed = speed;
            objectType = gameObjectType;
            movementPoolManager = MovementPoolManager.GetMovementPoolManagerInstance();
            ObjectMotion = movementPoolManager.GetResourse(this.GetType());
        }

        // Destructor
        ~GameObject() { movementPoolManager.ReleaseResourse(ObjectMotion); }

        public virtual void updatePosition()
        {
            ObjectMotion.update(PictureBox, Speed);
        }
    }
}
