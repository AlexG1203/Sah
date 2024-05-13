﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace SahUI
{
    public static class SahCursor
    {
        public static readonly Cursor WhiteCursor = LoadCursor("Assets/CursorW.cur");
        public static readonly Cursor BlackCursor = LoadCursor("Assets/CursorB.cur");

        private static Cursor LoadCursor(string filepath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filepath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
