﻿using System.Collections.Generic;
using System.Numerics;

namespace PacMan.GameComponents.Ghosts
{
    public class EyesSpritesheetInfo
    {
        readonly Dictionary<Direction, Vector2> _positions;

        const int _width = 16;

        public EyesSpritesheetInfo(Vector2 position)
        {
            _positions = new();

            var toMove = new Vector2(_width, 0);

            _positions[Direction.Right] = position;

            var marker = position;
            marker = marker + toMove;

            _positions[Direction.Left] = marker;
            marker = marker + toMove;

            _positions[Direction.Up] = marker;
            marker = marker + toMove;

            _positions[Direction.Down] = marker;
        }

        public Vector2 GetSourcePosition(Direction direction) => _positions[direction];
    }
}