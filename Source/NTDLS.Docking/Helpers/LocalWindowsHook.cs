#region NTDLS License
//    Copyright (C) 2005  Sebastian Faltoni sebastian{at}dotnetNTDLS{dot}net
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

#endregion
#region Original License
// *****************************************************************************
// 
//  Copyright 2004, Weifen Luo
//  All rights reserved. The software and associated documentation 
//  supplied hereunder are the proprietary information of Weifen Luo
//  and are supplied subject to licence terms.
// 
//  WinFormsUI Library Version 1.0
// *****************************************************************************
#endregion


using System;
using System.Runtime.InteropServices;

namespace NTDLS.Docking
{
	internal class HookEventArgs : EventArgs
	{
		public int HookCode;    // Hook code
		public IntPtr wParam;   // WPARAM argument
		public IntPtr lParam;   // LPARAM argument
	}


	// Hook Types  
	internal enum HookType : int
	{
		WH_JOURNALRECORD = 0,
		WH_JOURNALPLAYBACK = 1,
		WH_KEYBOARD = 2,
		WH_GETMESSAGE = 3,
		WH_CALLWNDPROC = 4,
		WH_CBT = 5,
		WH_SYSMSGFILTER = 6,
		WH_MOUSE = 7,
		WH_HARDWARE = 8,
		WH_DEBUG = 9,
		WH_SHELL = 10,
		WH_FOREGROUNDIDLE = 11,
		WH_CALLWNDPROCRET = 12,        
		WH_KEYBOARD_LL = 13,
		WH_MOUSE_LL = 14
	}

	internal class LocalWindowsHook
	{
		public delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll")]
		private static extern IntPtr SetWindowsHookEx(HookType code, HookProc func, IntPtr hInstance, int threadID);

		[DllImport("user32.dll")]
		private static extern int UnhookWindowsHookEx(IntPtr hhook); 

		[DllImport("user32.dll")]
		private static extern int CallNextHookEx(IntPtr hhook, int code, IntPtr wParam, IntPtr lParam);

		// Internal properties
		private IntPtr m_hhook = IntPtr.Zero;
		private HookProc m_filterFunc = null;
		private HookType m_hookType;

		// Event delegate
		public delegate void HookEventHandler(object sender, HookEventArgs e);

		// Event: HookInvoked 
		public event HookEventHandler HookInvoked;
		protected void OnHookInvoked(HookEventArgs e)
		{
			if (HookInvoked != null)
				HookInvoked(this, e);
		}

		// Class constructor(s)
		public LocalWindowsHook(HookType hook)
		{
			m_hookType = hook;
			m_filterFunc = new HookProc(this.CoreHookProc);
		}

		public LocalWindowsHook(HookType hook, HookProc func)
		{
			m_hookType = hook;
			m_filterFunc = func; 
		}        

		// Default filter function
		public int CoreHookProc(int code, IntPtr wParam, IntPtr lParam)
		{
			if (code < 0)
				return CallNextHookEx(m_hhook, code, wParam, lParam);

			// Let clients determine what to do
			HookEventArgs e = new HookEventArgs();
			e.HookCode = code;
			e.wParam = wParam;
			e.lParam = lParam;
			OnHookInvoked(e);

			// Yield to the next hook in the chain
			return CallNextHookEx(m_hhook, code, wParam, lParam);
		}

		// Install the hook
		public void Install()
		{
			int threadId = Kernel32.GetCurrentThreadId();
			m_hhook = SetWindowsHookEx(m_hookType, m_filterFunc, IntPtr.Zero, threadId);
		}

		// Uninstall the hook
		public void Uninstall()
		{
			UnhookWindowsHookEx(m_hhook); 
		}
	}
}
