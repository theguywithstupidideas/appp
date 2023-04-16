using System.Runtime.InteropServices;

namespace Ultilib_GUI
{
    public class UltiLib
    {
        [DllImport("lib.dll")]
        public static extern int med(int a, int b, int c);
        [DllImport("lib.dll")]
        public static extern int medf(float a, float b, float c);
        [DllImport("lib.dll")]
        private static extern IntPtr op(int a, int b);

        public static string Op(int a, int b)
        {
            IntPtr buffer = op(a, b);
            if (buffer == IntPtr.Zero)
            {
                throw new Exception("Failed to allocate memory.");
            }

            string result = Marshal.PtrToStringAnsi(buffer);
            Marshal.FreeHGlobal(buffer);
            return result;
        }

        [DllImport("lib.dll")]
        public static extern int arr(int a);
        [DllImport("lib.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr sw(int a, int b);

        public static string Sw(int a, int b)
        {
            IntPtr buffer = sw(a, b);
            if (buffer == IntPtr.Zero)
            {
                throw new Exception("Failed to allocate memory.");
            }

            string result = Marshal.PtrToStringAnsi(buffer);
            Marshal.FreeHGlobal(buffer);
            return result;
        }

        [DllImport("lib.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr ps(int a);
        public static string Ps(int a)
        {
            IntPtr buffer = ps(a);
            if (buffer == IntPtr.Zero)
            {
                throw new Exception("error");
            }
            string result = Marshal.PtrToStringAnsi(buffer);
            Marshal.FreeHGlobal(buffer);
            return result;
        }
        [DllImport("lib.dll")]
        public static extern int quad(int a);
        [DllImport("lib.dll")]
        public static extern int parcheggio(int a);
    }
}
