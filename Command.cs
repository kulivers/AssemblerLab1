using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblerLab1
{
    public class Command
    {
        public int CommandNumber;
        public string CommandName;
        public int Argument;
        public string BinCommand = "0000_????_????_0000";

        public Command(int _numberOfCommand, int _arg)
        {
            this.CommandNumber = _numberOfCommand;
            this.CommandName = GetCmdName(_numberOfCommand);
            this.Argument = _arg;
            this.BinCommand = GetbinCommand(_numberOfCommand, _arg);
        }
        public Command(string _commandName, int _arg)
        {
            this.CommandNumber = GetCmdNumByName(_commandName);
            this.CommandName = _commandName;
            this.Argument = _arg;
            this.BinCommand = GetbinCommand(CommandNumber, _arg);
        }
        public Command(string _binCmd)
        {
            CommandNumber = GetCmdNumByBin(_binCmd);
            CommandName = GetCmdName(CommandNumber);
            Argument = GetArgNum(_binCmd);
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
        public static int GetCmdNumByBin(string _binCmd)
        {
            if (_binCmd.Length != 19) { throw new System.ArgumentException("Command length is not 16"); }
            double sum = 0;
            for (int i = 0; i <= 3; i++)
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
                for (int i = 0; i < zC; i++)
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
        public static int GetCmdNumByName(string _cmdName)
        {

            switch (_cmdName.ToUpper())
            {
                case "MOVAC":
                    return 0;
                case "ADD":
                    return 1;
                case "MOVM":
                    return 2;
                case "JNZ":
                    return 3;
                case "DEC":
                    return 4;
                case "EXIT":
                    return 5;
                default:
                    throw new System.Exception("Unknown name of command");
            }
        }
        public static string GetCmdName(int _numOfCmd)
        {
            switch (_numOfCmd)
            {
                case 0:
                    return "MOVAC";
                case 1:
                    return "ADD";
                case 2:
                    return "MOVM";
                case 3:
                    return "JNZ";
                case 4:
                    return "DEC";
                case 5:
                    return "EXIT";
                default:
                    throw new System.Exception("Unknown num of command");
            }
        }
    }
}