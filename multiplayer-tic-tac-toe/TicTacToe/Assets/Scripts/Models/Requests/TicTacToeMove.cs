// Copyright (C) Microsoft Corporation. All rights reserved.

using System;

namespace TicTacToe.Models.Requests
{
    [Serializable]

    public class TicTacToeMove
    {
        public int row { get; set; }
        public int col { get; set; }

        public bool Valid
        {
            get
            {
                return row != -1 && col != -1;
            }
        }
    }
}