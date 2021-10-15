using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MathLibrary;

namespace MathForGames
{
    class Engine
    {
        private static bool _applicationShouldClose = false;
        private static int _currentSeneIndex;
        private Scene[] _scenes = new Scene[0];
        private static Icon[,] _buffer;
        


        /// <summary>
        /// Called to beging the application
        /// </summary>
        public void Run()
        {
            //Call start for the entire application
            Start();

            //loop until the application is told to close
            while (!_applicationShouldClose)
            {
                Update();
                Draw();
                Thread.Sleep(1);
            }

            //Call end for entire application
            End();
        }


        





        /// <summary>
        /// Calls when the application starts
        /// </summary>
        private void Start()
        {

            Scene scene = new Scene();

            //top wall
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 0, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //bottom wall
            for (int i = 2; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 28, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //left side wall
            for (int i = 1; i < 130; i++)
            {
                Actor wall = new Actor('|', 2, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //right side wall
            for (int i = 1; i < 110; i++)
            {
                Actor wall = new Actor('|', 118, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall horizontal one
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 3, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall horizontal two
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 6, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall horizontal three
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 9, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall horizontal four
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 12, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall horizontal five
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 15, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall horizontal six
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 18, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall horizontal seven
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 21, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall horizontal eight
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 24, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            

            //sub wall vertical one
            for (int i = 1; i < 29; i++)
            {
                Actor wall = new Actor('|', 10, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }


            //sub wall veritcal two
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 19, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical three
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 28, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical four
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 37, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical five
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 46, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical six
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 55, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical seven
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 64, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical eight
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 73, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical nine
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 82, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical ten
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 91, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical eleven
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 100, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //sub wall vertical twelve
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('|', 109, i, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }


            //death barrier left side
            for (int i = 1; i < 118; i++)
            {
                Actor wall = new Actor('_', 1, i, "wall", ConsoleColor.Black);
                scene.AddActor(wall);

            }

            //death barrier bottom
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, 30, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //death barrier top
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, -1, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //death barrier top 2.0
            for (int i = 3; i < 118; i++)
            {
                Actor wall = new Actor('_', i, -2, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }

            //death barrier right side
            for (int i = 1; i < 110; i++)
            {
                Actor wall = new Actor('_', 119, i, "wall", ConsoleColor.Black);
                scene.AddActor(wall);

            }

            //death box one
            for (int i = 29; i < 37; i++)
            {
                Actor wall = new Actor('|', i, 2, "wall", ConsoleColor.Black);
                scene.AddActor(wall);

            }

            //death box one
            for (int i = 50; i < 37; i++)
            {
                Actor wall = new Actor('|', i, 2, "wall", ConsoleColor.White);
                scene.AddActor(wall);

            }





            Player player = new Player('@', 4, 1, 1, "Player", ConsoleColor.Magenta);


            scene.AddActor(player);

            _currentSeneIndex = AddScene(scene);

            _scenes[_currentSeneIndex].Start();

            Console.CursorVisible = false;
        }

        /// <summary>
        ///Called everytime the game loops 
        /// </summary>
        private void Update()
        {
            _scenes[_currentSeneIndex].Update();

            while (Console.KeyAvailable)
                Console.ReadKey(true);
        }

        /// <summary>
        /// Called every time the game loops to update visuals
        /// </summary>
        private void Draw()
        {
            //clear the stuff that was on scren in the last frame
            _buffer = new Icon[Console.WindowWidth, Console.WindowHeight - 1];

            //Reset the cursor position to the top so the previoous screen is drawn over
            Console.SetCursorPosition(0, 0);

            //Adds all actor icons to buffer
            _scenes[_currentSeneIndex].Draw();

            //Iterate through buffer
            for (int y = 0; y < _buffer.GetLength(1); y++)
            {
                for ( int x = 0; x < _buffer.GetLength(0); x++)
                {
                    if (_buffer[x, y].Symbol == '\0')
                        _buffer[x, y].Symbol = ' ';

                    //Set console text color to be the color of item at buffer
                    Console.ForegroundColor = _buffer[x, y].Color;
                    //Print the symbol of the item in the buffer
                    Console.Write(_buffer[x, y].Symbol);
                }

                //Skip a line once the end of a row has been reached
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Called when the application exits
        /// </summary>
        private void End()
        {
            _scenes[_currentSeneIndex].End();
        }

        /// <summary>
        /// Adds a scene to the engines scene array
        /// </summary>
        /// <param name="scene">The scene that will be added to the scene array</param>
        /// <returns>The index that new scene is located</returns>
        public int AddScene(Scene scene)
        {
            //Create a new temp array
            Scene[] tempArray = new Scene[_scenes.Length + 1];

            //copy all values from the old array into the new array
            for (int i = 0; i < _scenes.Length; i++)
            {
                tempArray[i] = _scenes[i];
            }

            //set the last index to be the new scene
            tempArray[_scenes.Length] = scene;

            //Set the old array to be the new array
            _scenes = tempArray;

            //retunr the last index
            return _scenes.Length - 1;
        }

        /// <summary>
        /// Gets the next key in the input stream
        /// </summary>
        /// <returns>The key that was pressed</returns>
        public static ConsoleKey GetNextKey()
        {   //If there is no key being pressed...
            if (!Console.KeyAvailable)
                //...return
                return 0;
            
            //Return the current key being pressed
            return Console.ReadKey(true).Key;
        }

        /// <summary>
        /// Adds the icon to the buffer to print to the screen in the next draw call.
        /// Prints the icon at the given positon in the buffer.
        /// </summary>
        /// <param name="icon">The icon to draw</param>
        /// <param name="position">The position of the icon in the buffer</param>
        /// <returns>False if the posiotion is outside the bounds of the buffer</returns>
        public static bool Render(Icon icon, Vector2 position)
        {
            //If the position is out of bounds...
            if (position.x < 0 || position.x >= _buffer.GetLength(0) || position.y < 0 || position.y >= _buffer.GetLength(1))
                //...return false
                return false;

            //set the buffer at the index of the given position to be the icon
            _buffer[(int)position.x, (int)position.y] = icon;
            return true;
        }

        /// <summary>
        /// Ends the application
        /// </summary>
        public static void CloseApplication()
        {
            _applicationShouldClose = true;
        }
    }
}
