using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class GameObject
    {
        public Tile GameTile;
        public int Speed;
        public IMovement ObjectMotion;
        public GameObjectType objectType;
        public GameObjectMotionType MotionType;
        MovementPoolManager movementPoolManager;

        // constructor
        internal GameObject(Tile GameTile, int speed, GameObjectType gameObjectType, GameObjectMotionType motion)
        {
            GameTile.TileImage.BringToFront();
            this.GameTile = GameTile;
            Speed = speed;
            objectType = gameObjectType;
            MotionType = motion;
            movementPoolManager = MovementPoolManager.GetMovementPoolManagerInstance();
            ObjectMotion = movementPoolManager.GetResourse(MotionType);
        }

        // Destructor
        ~GameObject() { movementPoolManager.ReleaseResourse(ObjectMotion, MotionType); }

        public virtual void updatePosition()
        {
            ObjectMotion.update(GameTile.TileImage, Speed);
        }
    }
}
