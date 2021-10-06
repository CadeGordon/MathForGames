using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Engine
    {
        private static bool _applicationShouldClose = false;
        private static int _currentSeneIndex;
        private Scene[] _scenes = new Scene[0];


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
            }

            //Call end for entire application
            End();
        }

        /// <summary>
        /// Calls when the application starts
        /// </summary>
        private void Start()
        {
            _scenes[_currentSeneIndex].Start();
        }

        /// <summary>
        ///Called everytime the game loops 
        /// </summary>
        private void Update()
        {
            _scenes[_currentSeneIndex].Update();
        }

        /// <summary>
        /// Called every time the game loops to update visuals
        /// </summary>
        private void Draw()
        {
            _scenes[_currentSeneIndex].Draw();
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
    }
}
