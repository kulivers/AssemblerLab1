using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace AssemblerLab1
{
    public class Cpu8b
    {
        public Dictionary<string, int> Regs;
        public Dictionary<string, int> Flags;
        public List<int> arr;
        public List<Command8B> commands;
        public int iCmd = 0; // index вып комманды
        public static string Word { get; private set; }

        public Cpu8b()
        {
            Regs = new Dictionary<string, int>() { { "AX", 0 }, { "CX", 0 }, { "PC", 0 }, { "BX", 0 }, { "DX", 0 } };
            Flags = new Dictionary<string, int>() { { "ZF", 0 }, { "CF", 0 }, { "SF", 0 }, { "OF", 0 } };
            arr = new List<int>() { 2, 3, 5, 10, 15 };                              //sf-<0        of-overflow
            commands = new List<Command8B>()
            {
                //new Command8B("movac",0), //pc =0
                //new Command8B("movm", 2),
                new Command8B("MOVAC_R", arr.Count), //cx = arr.length
                new Command8B("MOVM_R", 1),
                new Command8B("MOVAC_R", 0), //ax = 0
                new Command8B("ADD_L", arr[Regs["CX"]]), //ax += arr[i]
                new Command8B("DEC_R", 1), //dec cx
                new Command8B("JNZ_L", 3), //jump to 5(Add_L arr[i])
                new Command8B("exit", 0) //exit
            };
        }

        public void DoOneCommand()
        {
            if (commands.Count != 0)
            {
                if (Regs["PC"] == 5)
                {
                    Exit();
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
                    movac_r(commands[iCmd].Argument);
                    break;
                case 1:
                    //Debug.WriteLine("Regs[\"CX\"]" + ": " + Regs["CX"]);
                    //Debug.WriteLine("arr[ " + Regs["CX"]+ "]: " + (arr[Regs["CX"] - 1] ).ToString());
                    //Debug.WriteLine("");
                    Add_L(arr[Regs["CX"] - 1] );
                    break;
                case 2:
                    Movm_R(commands[iCmd].Argument);
                    break;
                case 3:
                    Jnz_L(commands[iCmd].Argument - 1);//-1 тк потом +1 прибовляем
                    break;
                case 4:
                    Dec_R(commands[iCmd].Argument);
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    throw new Exception("unknown cmd");
            }
        }
        //movac_r<A>; загрузить в регистр-аккумулятор число 
        public void movac_r(int a) //Movac_R
        {
            Regs["AX"] = a;

        }
        //ADD<B>; содержимое аккумулятора увеличить на значение числа 
        public void Add_L(int b) //Add_L
        {
            //Debug.WriteLine(b.ToString()+" is added");
            Regs["AX"] = Regs["AX"] + b;
        }
        //Movm_R<C>; сохранить содержимое аккумулятора в ячейке памяти С.
        public void Movm_R(int c)//у нас С - это индекс регистра куда
        {                      //MOVM_R
            string regName = Regs.ElementAt(c).Key;
            Regs[regName] = Regs["AX"];
        }
        //ax--
        public void Dec_R(int c)//у нас С - это индекс регистра
        {                     //Dec_R
            var regName = Regs.ElementAt(c).Key;
            Regs[regName]--;
            
            if(Regs[regName] == 0)
            {
                Flags["ZF"] = 1;
            }
        }
        public void Jnz_L(int c)//c - в какое место в массиве команд прыгаем, index
        {               //JNZ_L
            if (Flags["ZF"] == 1) return;
            iCmd = c;
            Flags["ZF"] = 0;
        }
        public void Exit()
        {               
            Application.Exit();
        }





    }
}