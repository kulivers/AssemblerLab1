using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssemblerLab1
{

    //здесь по новому, используется 8 бит на команду
    public class Command8B
    {

        public int CommandNumber;
        public string CommandName;
        public int Argument;
        public string BinCommand = "0000_0000_????_0000";
        
        //public Command8B(int _numberOfCommand, int _arg)
        //{
        //    this.CommandNumber = _numberOfCommand;
        //    this.CommandName = CalcNameByNum(_numberOfCommand);
        //    this.Argument = _arg;
        //    this.BinCommand = CalcBin(_numberOfCommand, _arg);
        //}
        public Command8B(string _commandName, int _arg)
        {
            this.CommandNumber = CalcNumByName(_commandName);
            this.CommandName = _commandName;
            this.Argument = _arg;
            this.BinCommand = CalcBin(CommandNumber, _arg);
        }//used
        //public Command8B(string _binCmd)
        //{
        //    CommandNumber = CalcNumByBin(_binCmd);
        //    CommandName = CalcNameByNum(CommandNumber);
        //    Argument = CalcArgByBin(_binCmd);
        //}
        public static int CalcArgByBin(string _binCmd)//не изменился, вытаскиваем аргумент

        {
            if (_binCmd.Length != 19)
            {
                throw new System.ArgumentException("Command_ length is not 16");
            }
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
        //public static int CalcNumByBin(string _binCmd)//не делал
        //{
        //    if (_binCmd.Length != 19) { throw new System.ArgumentException("Command_4b length is not 16"); }
        //    double sum = 0;
        //    for (int i = 0; i <= 3; i++)
        //    {
        //        int rank = 3 - i; //разряд(степень)
        //        int digit = int.Parse(_binCmd[i].ToString());
        //        double expr = Math.Pow(2, Convert.ToDouble(rank)) * digit;
        //        //            2^rank * digit 
        //        sum = sum + expr;
        //    }
        //    return Convert.ToInt32(sum);
        //}



        public static string CalcBin(int _commandNum, int _arg)//XXXX_XXXX_????_YYYY - ready
        {
            Func<int, string> MakeBin = x => Convert.ToString(x, 2);
            Func<string, string> SetZerosToCmd = binCmdNum =>
        {
            var builder = new StringBuilder(binCmdNum);
            //Debug.WriteLine("bin num before :" + builder);
            //Debug.WriteLine("bin num length before :" + builder.Length);
            if (builder.Length > 8)
            {
                throw new Exception("Bin number is too big");
            }

            if (builder.Length < 8)
            {
                while (builder.Length != 8)
                {
                    builder.Append('0');
                }
            }
            //Debug.WriteLine("bin num after :" + builder);
            return builder.ToString();
        };
            Func<string, string> set_ = str =>
            {
                var builder = new StringBuilder(str);

                if (str.Length == 8)
                {
                    //Debug.WriteLine("bin num before:" + builder);
                    builder.Insert(4, "_");
                    //Debug.WriteLine("bin num after :" + builder);
                    //bin num before: 10100000
                    //bin num after: 1010_0000
                }
                return builder.ToString();
            };
            Func<string, string> SetZerosToArg = binCmdNum =>
            {
                var builder = new StringBuilder(binCmdNum);
                //Debug.WriteLine("bin num before :" + builder);
                //Debug.WriteLine("bin num length before :" + builder.Length);
                if (builder.Length > 4)
                {
                    throw new Exception("arg number is too big");
                }

                if (builder.Length < 4)
                {
                    while (builder.Length != 4)
                    {
                        builder.Append('0');
                    }
                }
                //Debug.WriteLine("bin num after :" + builder);
                return builder.ToString();
            };

            return set_(SetZerosToCmd(MakeBin(_commandNum))) + "_????_" + SetZerosToArg(MakeBin(_arg));
        }
        public static int CalcNumByName(string _cmdName)
        {
            switch (_cmdName.ToUpper())
            {
                case "MOVAC_R":
                    return 0;
                case "MOVAC_L":
                    return 6;
                case "ADD_L":
                    return 1;
                case "ADD_R":
                    return 7;
                case "MOVM_R":
                    return 2;
                case "MOVM_L":
                    return 8;
                case "JNZ_L":
                    return 3;
                case "JNZ_R":
                    return 9;
                case "DEC_R":
                    return 4;
                case "DEC_L":
                    return 10;
                case "EXIT":
                    return 5;

                default:
                    throw new System.Exception("Unknown name of command");
            }
        }//ready
        public static string CalcNameByNum(int _numOfCmd)
        {
            switch (_numOfCmd)
            {
                case 0:
                    return "MOVAC_R";
                case 6:
                    return "MOVAC_L";
                case 1:
                    return "ADD_L";
                case 7:
                    return "ADD_R";
                case 2:
                    return "MOVM_R";
                case 8:
                    return "MOVM_L";
                case 3:
                    return "JNZ_L";
                case 9:
                    return "JNZ_R";
                case 4:
                    return "DEC_R";
                case 10:
                    return "DEC_L";
                case 5:
                    return "EXIT";

                default:
                    throw new System.Exception("Unknown num of command");
            }
        }//ready

    }

}
