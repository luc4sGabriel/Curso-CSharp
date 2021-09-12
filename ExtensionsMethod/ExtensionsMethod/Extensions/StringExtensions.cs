using System;


namespace System{
    public static class StringExtensions {
        public static string Cut(this string thisObj, int number) {
            string line = thisObj.Substring(0, number);
            return line;
        }
    }
}
