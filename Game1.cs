using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using System;


namespace SpinningAlj
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        float angle = 0;
        float rotSpeed = 0.01f;
        Vector3 rotAxis = new Vector3(1, 1, 1);


        Vector3 p1 = new Vector3(300, 300, 0);

        Vector3 p2 = new Vector3(200, 300, 0);


        Vector3 p3 = new Vector3(300, 200, 0);

        Vector3 p4 = new Vector3(200,200,0);



        Vector3 p5 = new Vector3(300, 300, -50);
        Vector3 p6 = new Vector3(200, 300, -50);
        Vector3 p7 = new Vector3(300, 200, -50);
        Vector3 p8 = new Vector3(200,200,-50);



        Quaternion rotation;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            rotation = Quaternion.CreateFromAxisAngle(rotAxis, rotSpeed);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();



            
            Vector3.Transform(ref p1,ref rotation,out p1);

            Vector3.Transform(ref p2, ref rotation, out p2);

            Vector3.Transform(ref p3, ref rotation, out p3);

            Vector3.Transform(ref p4, ref rotation, out p4);

            Vector3.Transform(ref p5, ref rotation, out p5);

            Vector3.Transform(ref p6, ref rotation, out p6);

            Vector3.Transform(ref p7, ref rotation, out p7);

            Vector3.Transform(ref p8, ref rotation, out p8);








            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);



            Vector2 origin = new Vector2(300, 300);
            // TODO: Add your drawing code here



            rotAxis.Normalize();
            _spriteBatch.Begin();

            _spriteBatch.DrawLine(new Vector2(p1.X, p1.Y), new Vector2(p2.X, p2.Y),Color.Red,4);
            _spriteBatch.DrawLine(new Vector2(p1.X, p1.Y), new Vector2(p3.X, p3.Y), Color.Red, 4);
            _spriteBatch.DrawLine(new Vector2(p2.X, p2.Y), new Vector2(p4.X, p4.Y), Color.Red, 4);
            _spriteBatch.DrawLine(new Vector2(p3.X, p3.Y), new Vector2(p4.X, p4.Y), Color.Red, 4);

            _spriteBatch.DrawLine(new Vector2(p5.X, p5.Y), new Vector2(p6.X, p6.Y), Color.Green, 4);
            _spriteBatch.DrawLine(new Vector2(p5.X, p5.Y), new Vector2(p7.X, p7.Y), Color.Green, 4);
            _spriteBatch.DrawLine(new Vector2(p6.X, p6.Y), new Vector2(p8.X, p8.Y), Color.Green, 4);
            _spriteBatch.DrawLine(new Vector2(p7.X, p7.Y), new Vector2(p8.X, p8.Y), Color.Green, 4);

            _spriteBatch.DrawLine(new Vector2(p1.X, p1.Y), new Vector2(p5.X, p5.Y), Color.Purple, 4);
            _spriteBatch.DrawLine(new Vector2(p2.X, p2.Y), new Vector2(p6.X, p6.Y), Color.Purple, 4);
            _spriteBatch.DrawLine(new Vector2(p3.X, p3.Y), new Vector2(p7.X, p7.Y), Color.Purple, 4);
            _spriteBatch.DrawLine(new Vector2(p4.X, p4.Y), new Vector2(p8.X, p8.Y), Color.Purple, 4);





            // I WILL KMS I WILL KMS I WILL KMS I WILL KMS I WILL KMS I WILL KMS I WILL KMS I WILL KMS I WILL KMS I WILL KMS I WILL KMS

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        public float RotX(Vector2 test, float angle)
        {

            return  test.X*MathF.Cos(angle)-test.Y*MathF.Sin(angle);

        }
        public float RotY(Vector2 test, float angle)
        {

            return test.X * MathF.Sin(angle) + test.Y * MathF.Cos(angle);

        }
        public Quaternion RotationAroundX(float angle)
        {

            // Equivalent to AngleAxis(new Vector3(1, 0, 0), angle)

            Quaternion q;
            q.X = MathF.Cos(angle / 2f);
            q.Y = 0f;
            q.Z = 0f;
            q.W = MathF.Cos(angle / 2f);

            return q;
        }

    }
}