using System;

namespace MYDDD.WinForm.Common
{
    public static class CommonFunc
    {
        public static string RoundString(float value, int decimalPoint)
        {
            var temp = Math.Round(value, decimalPoint);
            return temp.ToString("F" + decimalPoint);
        }
    }
}
