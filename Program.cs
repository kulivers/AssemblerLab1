﻿using System;
using System.Collections;
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
            _cmdName.ToUpper();
            switch (_cmdName)
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



    class Cpu
    {
        public Cpu()
        {

        }

        static public Dictionary<string, int> regs = new Dictionary<string, int>() { { "AX", 0 }, { "CX", 0 }, { "PC", 0 }, { "BX", 0 }, { "DX", 0 } };
        static public Dictionary<string, int> flags = new Dictionary<string, int>() { { "ZF", 0 }, { "CF", 0 }, { "SF", 0 }, { "OF", 0 } };
        static List<int> arr = new List<int>() { 1, 2, 3, 4 };

        List<Command> commands = new List<Command>() {
            new Command("MOVAC",0), //pc =0
            new Command("movm", 2),
            new Command("movac", arr.Count), //cx = arr.length
            new Command("movm", 1),
            new Command("movac", 0), //ax = 0
            new Command("add", arr[regs["CX"]]), //ax += arr[i]
            new Command("dec", 1), //dec cx
            new Command("jnz", 5), //jump to 5(add arr[i])
            new Command("exit", 0) //exit
        };
        int iCmd = 0; // index вып комманды



        //MOVAC<A>; загрузить в регистр-аккумулятор число 
        public void Movac(int a)
        {
            regs["AX"] = a;

        }
        //ADD<B>; содержимое аккумулятора увеличить на значение числа 
        public void add(int b)
        {
            regs["AX"] += b;
        }
        //MOVM<C>; сохранить содержимое аккумулятора в ячейке памяти С.
        public void movm(int c)//у нас С - это индекс регистра
        {
            string regName = regs.ElementAt(c).Key;
            regs[regName] = c;
        }
        //ax--
        public void dec(int c)//у нас С - это индекс регистра
        {
            string regName = regs.ElementAt(c).Key;
            regs[regName]--;
            flags["ZF"] = (regs[regName] == 0) ? 1 : 0;
        }
        public void jnz(int c)//c - в какое место в массиве команд прыгаем, index
        {
            if (flags["ZF"] == 1)
            {
                iCmd = c;
                flags["ZF"] = 0;
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
