﻿#region LICENCE

// /*
//         The MIT License (MIT)
// 
//         Copyright (c) 2016 Johnathon M
// 
//         Permission is hereby granted, free of charge, to any person obtaining a copy
//         of this software and associated documentation files (the "Software"), to deal
//         in the Software without restriction, including without limitation the rights
//         to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//         copies of the Software, and to permit persons to whom the Software is
//         furnished to do so, subject to the following conditions:
// 
//         The above copyright notice and this permission notice shall be included in
//         all copies or substantial portions of the Software.
// 
//         THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//         IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//         FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//         AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//         LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//         OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//         THE SOFTWARE.
// 
// */

#endregion

using System;
using System.IO;

namespace TileIconifier.Custom
{
    internal static class CustomShortcutExtensionMethods
    {
        //These are potentially buggy!
        internal static string UnescapeVba(this string input)
        {
            return input.Replace("\"\"", "\"");
        }

        internal static string EscapeVba(this string input)
        {
            return input.Replace("\"", "\"\"");
        }

        /// <summary>
        ///     Extension method to wrap a string with double quotes
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Original string with " surrounding</returns>
        internal static string QuoteWrap(this string input)
        {
            return string.Format("{0}{1}{0}", "\"", input);
        }

        /// <summary>
        ///     Quick and dirty extension method to remove any invalid characters and replace with a space
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Cleaned string for paths/filenames</returns>
        internal static string CleanInvalidFilenameChars(this string input)
        {
            return
                string.Join("", input.Split(Path.GetInvalidFileNameChars(), StringSplitOptions.RemoveEmptyEntries))
                    .TrimEnd('.');
        }
    }
}