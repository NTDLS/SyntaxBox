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
using System.ComponentModel;
using System.Windows.Forms;

namespace NTDLS.Docking
{
	/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAreas"]/EnumDef/*'/>
	[Flags]
	[Serializable]
	[Editor(typeof(DockAreasEditor), typeof(System.Drawing.Design.UITypeEditor))]
	public enum DockAreas
	{
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAreas"]/Member[@name="Float"]/*'/>
		Float = 1,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAreas"]/Member[@name="DockLeft"]/*'/>
		DockLeft = 2,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAreas"]/Member[@name="DockRight"]/*'/>
		DockRight = 4,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAreas"]/Member[@name="DockTop"]/*'/>
		DockTop = 8,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAreas"]/Member[@name="DockBottom"]/*'/>
		DockBottom = 16,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAreas"]/Member[@name="Document"]/*'/>
		Document = 32
	}

	/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/EnumDef/*'/>
	public enum DockState
	{
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="Unknown"]/*'/>
		Unknown = 0,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="Float"]/*'/>
		Float = 1,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="DockTopAutoHide"]/*'/>
		DockTopAutoHide = 2,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="DockLeftAutoHide"]/*'/>
		DockLeftAutoHide = 3,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="DockBottomAutoHide"]/*'/>
		DockBottomAutoHide = 4,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="DockRightAutoHide"]/*'/>
		DockRightAutoHide = 5,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="Document"]/*'/>
		Document = 6,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="DockTop"]/*'/>
		DockTop = 7,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="DockLeft"]/*'/>
		DockLeft = 8,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="DockBottom"]/*'/>
		DockBottom = 9,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="DockRight"]/*'/>
		DockRight = 10,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockState"]/Member[@name="Hidden"]/*'/>
		Hidden = 11
	}

	/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAlignment"]/EnumDef/*'/>
	public enum DockAlignment
	{
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAlignment"]/Member[@name="Left"]/*'/>
		Left,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAlignment"]/Member[@name="Right"]/*'/>
		Right,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAlignment"]/Member[@name="Top"]/*'/>
		Top,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DockAlignment"]/Member[@name="Bottom"]/*'/>
		Bottom
	}

	/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DocumentStyles"]/EnumDef/*'/>
	public enum DocumentStyles
	{
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DocumentStyles"]/Member[@name="DockingMdi"]/*'/>
		DockingMdi,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DocumentStyles"]/Member[@name="DockingWindow"]/*'/>
		DockingWindow,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DocumentStyles"]/Member[@name="DockingSdi"]/*'/>
		DockingSdi,
		/// <include file='CodeDoc\Enums.xml' path='//CodeDoc/Enum[@name="DocumentStyles"]/Member[@name="SystemMdi"]/*'/>
		SystemMdi,
	}
}
