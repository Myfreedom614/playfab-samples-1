// Copyright (C) Microsoft Corporation. All rights reserved.

using System;

namespace TicTacToe.Models
{
    [Serializable]
    public class GameState
    {
        public int[] boardState;

        public string currentPlayerId;

        public int winner;
    }
}