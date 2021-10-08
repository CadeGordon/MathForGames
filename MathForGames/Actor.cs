﻿using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathForGames
{
    class Actor
    {
        private char _icon;
        private string _name;
        private Vector2 _position;

        public Vector2 Postion
        {
            get { return _position; }
            set { _position = value; }
        }
        
        public Actor(char icon, Vector2 position, string name = "Actor")
        {
            _icon = icon;
            _position = position;
            _name = name;
        }

        public virtual void Start()
        {

        }

        public virtual void Update()
        {
            _position.x = Postion.x + 1;
        }

        public virtual void Draw()
        {

        }

        public void End()
        {

        }
    }
}
