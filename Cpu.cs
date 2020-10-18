using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AssemblerLab1
{
    public class Cpu
    {
        public Cpu()
        {
            Regs = new Dictionary<string, int>() { { "AX", 0 }, { "CX", 0 }, { "PC", 0 }, { "BX", 0 }, { "DX", 0 } };
            Flags = new Dictionary<string, int>() { { "ZF", 0 }, { "CF", 0 }, { "SF", 0 }, { "OF", 0 } };
            arr = new List<int>() { 1, 2, 3, 4, 5};                              //sf-<0        of-overflow
            commands = new List<Command>() {
                //new Command("movac",0), //pc =0
                //new Command("movm", 2),
                new Command("movac", arr.Count), //cx = arr.length
                new Command("movm", 1),
                new Command("movac", 0), //ax = 0
                new Command("add", arr[Regs["CX"]]), //ax += arr[i]
                new Command("dec", 1), //dec cx
                new Command("jnz", 3), //jump to 5(add arr[i])
                new Command("exit", 0) //exit

            };
        }

        static void Printhello(string word)
        {
            
            Console.WriteLine(word);
        }

        public Dictionary<string, int> Regs;
        public Dictionary<string, int> Flags;
        public List<int> arr;


        public List<Command> commands;
        public int iCmd = 0; // index вып комманды
        public static string Word { get; private set; }


        public void DoOneCommand()
        {
            if (commands.Count != 0)
            {
                if (Regs["PC"] == 5)
                {
                    Application.Exit();
                }
                else
                {
                    if (iCmd != 0 || commands.Count != 1)
                    {
                        ParseAndDoCmd(commands[iCmd].CommandNumber);
                        Regs["PC"] = commands[iCmd + 1].CommandNumber;
                        iCmd++;
                    }
                    else
                    {
                        Regs["PC"] = commands[iCmd].CommandNumber;
                        ParseAndDoCmd(commands[iCmd].CommandNumber);
                        iCmd++;
                    }
                }
            }
            else
            {
                throw new Exception("command arr is empty");
            }
        }
        public void ParseAndDoCmd(int cmdNumber)
        {
            switch (commands[iCmd].CommandNumber)// parse cmd
            {
                case 0:
                    Movac(commands[iCmd].Argument);
                    break;
                case 1:
                    Add(Regs["CX"]);
                    break;
                case 2:
                    Movm(commands[iCmd].Argument);
                    break;
                case 3:
                    Jnz(commands[iCmd].Argument-1);//-1 тк потом +1 прибовляем
                    break;
                case 4:
                    Dec(commands[iCmd].Argument);
                    break;
                default:
                    throw new Exception("unknown cmd");
            }
        }
        //MOVAC<A>; загрузить в регистр-аккумулятор число 
        public void Movac(int a)
        {
            Regs["AX"] = a;

        }
        //ADD<B>; содержимое аккумулятора увеличить на значение числа 
        public void Add(int b)
        {
            Regs["AX"] = Regs["AX"] + b;
        }
        //MOVM<C>; сохранить содержимое аккумулятора в ячейке памяти С.
        public void Movm(int c)//у нас С - это индекс регистра куда
        {
            string regName = Regs.ElementAt(c).Key;
            Regs[regName] = Regs["AX"];
        }
        //ax--
        public void Dec(int c)//у нас С - это индекс регистра
        {
            var regName = Regs.ElementAt(c).Key;
            Regs[regName]--;
            
            if(Regs[regName] == 0)
            {
                Flags["ZF"] = 1;
            }
        }
        public void Jnz(int c)//c - в какое место в массиве команд прыгаем, index
        {
            if (Flags["ZF"] == 1) return;
            iCmd = c;
            Flags["ZF"] = 0;
        }





    }
}