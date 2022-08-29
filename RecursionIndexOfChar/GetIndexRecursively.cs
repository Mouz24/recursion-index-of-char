using System;

namespace RecursionIndexOfChar
{
    public static class GetIndexRecursively
    {
        public static int GetIndexOfChar(string str, char value, int i = 0)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            if (str[0] == value)
            {
                return i;
            }

            if (i < str.Length - 1)
            {
                    i++;
            }

            return GetIndexRecursively.GetIndexOfChar(str[(str.Length - (str.Length - 1)) ..], value, i);
        }

        public static int GetIndexOfChar(string str, char value, int startIndex, int count)
        {
            // The method should return the position of a "value" char in the "str" string. If "str" string has no "value" char then returns -1.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str) || count == 0)
            {
                return -1;
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            int index = startIndex;
            if (str[index] == value)
            {
                return index;
            }

            return GetIndexRecursively.GetIndexOfChar(str, value, startIndex + 1, count - 1);
        }
    }
}
