using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace InterOpIntro
{
	class Program
	{
		const uint MB_OK = 0x00000000;
		const uint MB_ICONINFORMATION = 0x00000040;

		//c# equivalent for NULL handle: IntPtr.Zero
		//u - unsigned
		//DWORD -> uint
		//refer to requirements section at the bottom of a documentation's page to find the dll to import

		//[in] - used on references passed in for pointer types that don't update the value,
		//e.g. function uses pointer -> if i use c# reference for it -> use [in] if the function does not change the value at the pointer
		//USED WHEN NO DATA IS RETURNED!

		//All documentation pages contain a Return section,
		//setLastError = true if mention in Return section, leaving it out defaults to false

		// Original definition.
		// int MessageBox(HWND hWnd, LPCTSTR lpText, LPCTSTR lpCaption, UINT uType);

		//OR symbol - combine flags - allows multiple flags to be specified for a single function parameter

		[DllImport("User32.dll", SetLastError = true)]
		static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

		static void Main(string[] args)
		{
			MessageBox(IntPtr.Zero, "Hello! I'm a message box called from C!", "Yay!", MB_OK | MB_ICONINFORMATION);
		}
	}
}
