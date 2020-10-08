using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblerLab1
{

    class Command
    {
        public int CommandNumber;
        public string CommandName;
        public int Argument;
        public string BinArgument;
        public string BinCommand = "0000_????_????_0000";

        public Command(int _numberOfCommand, int _arg)
        {
            this.CommandNumber = _numberOfCommand;
            this.CommandName = Cpu.GetCmdName(_numberOfCommand);
            this.Argument = _arg;
            this.BinArgument = Program.GetBinForm(_arg);
            this.BinCommand = GetbinCommand(_numberOfCommand, _arg);
        }
        public Command(string _commandName, int _arg)
        {
            this.CommandNumber = Cpu.GetCmdNum(_commandName);
            this.CommandName = _commandName;
            this.Argument = _arg;
            this.BinArgument = Program.GetBinForm(_arg);
            this.BinCommand = GetbinCommand(CommandNumber, _arg);
        }
        public Command(string _binCmd)
        {

        }
        public static int GetArgNum(string _binCmd)
        {
            if (_binCmd.Length != 19) { throw new System.ArgumentException("Command length is not 16"); }
            double sum = 0;
            for (int i = 15; i <= 18; i++)
            {
                int rank = 18 - i; //разряд(степень)
                int digit = int.Parse(_binCmd[i].ToString());
                double expr = Math.Pow(2, Convert.ToDouble(rank)) * digit;
                //            2^rank * digit 
                sum = sum + expr;
            }
            return Convert.ToInt32(sum);
        }
        public static int GetCmdNum(string _binCmd)
        {
            if(_binCmd.Length != 19) { throw new System.ArgumentException("Command length is not 16"); }
            double sum = 0;
            for(int i = 0; i <= 3; i++)
            {
                int rank = 3 - i; //разряд(степень)
                int digit = int.Parse(_binCmd[i].ToString());
                double expr = Math.Pow(2, Convert.ToDouble(rank)) * digit;
                //            2^rank * digit 
                sum = sum + expr;
            }
            return Convert.ToInt32(sum);
        }
        public static string GetbinCommand(int _commandNum, int _arg)
        {
            string binCmdNum = Convert.ToString(_commandNum, 2);
            if (binCmdNum.Length > 4)
            {
                throw new System.ArgumentException("Too big command type", "_commandNum");
            }
            if (binCmdNum.Length < 4)
            {
                int zC = 4 - binCmdNum.Length;
                for(int i = 0; i < zC; i++)
                {
                    binCmdNum = "0" + binCmdNum;
                }
            }

            string binArg = Convert.ToString(_arg, 2);
            if (binArg.Length > 4)
            {
                throw new System.ArgumentException("Too big command type", "_arg in GetbinCommand");
            }
            if (binArg.Length < 4)
            {
                int zC = 4 - binArg.Length;
                for (int i = 0; i < zC; i++)
                {
                    binArg = "0" + binArg;
                }
            }

            return binCmdNum + "_????_????_" + binArg;

        }
    }

    class Cpu
    {
        List<int> arr = new List<int>() { 1, 2, 3, 45 };
        List<Command> commands = new List<Command>();
        public int ax { get; set; }
        public int cx { get; set; }
        public int zf { get; set; }
        public int cf { get; set; }
        public int sf { get; set; }
        public int of { get; set; }

        public static int GetCmdNum(string _cmdName)
        {
            _cmdName = _cmdName.ToUpper();
            switch (_cmdName)
            {

                case "MOV":
                    return 0;
                case "ADD":
                    return 1;
                case "DEC":
                    return 2;
                case "JNZ":
                    return 3;
                default:
                    throw new System.ArgumentException("Unknown command number");
            }
        }
        public static string GetCmdName(int _numOfCmd)
        {
            switch(_numOfCmd)
            {
                case 0:
                    return "MOV";
                case 1:
                    return "ADD";
                case 2:
                    return "DEC";
                case 3:
                    return "JNZ";
                default:
                    throw new System.ArgumentException("Unknown command name");
            }
        }

    }
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
