using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblerLab1
{
    static class Program
    {
        public static string GetBinForm(int value)
        {
            string binVal = Convert.ToString(value, 2);
            if (binVal.Length > 4)
            {
                throw new System.ArgumentException("Too big command type", "value");
            }
            if (binVal.Length < 4)
            {
                int zC = 4 - binVal.Length;
                for (int i = 0; i < zC; i++)
                {
                    binVal = "0" + binVal;
                }
            }
            return binVal;
        }
        /// <summary>
        /// The main entry point for the application.

        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Assembler_form());
        }
    }
}
