using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace EASYTools.Input.Native
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct HARDWAREINPUT
    {
        internal int Msg;
        internal short ParamL;
        internal short ParamH;
    }
}
