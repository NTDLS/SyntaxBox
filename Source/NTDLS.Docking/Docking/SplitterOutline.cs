#region NTDLS License
//    
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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NTDLS.Docking
{
	internal class SplitterOutline
	{
		public SplitterOutline()
		{
			m_dragForm = new DragForm();
			SetDragForm(Rectangle.Empty);
			DragForm.BackColor = Color.Black;
			DragForm.Opacity = 0.7;
			DragForm.Show(false);
		}

		DragForm m_dragForm;
		private DragForm DragForm
		{
			get	{	return m_dragForm;	}
		}

		public void Show(Rectangle rect)
		{
			SetDragForm(rect);
		}

		public void Close()
		{
			DragForm.Close();
		}

		private void SetDragForm(Rectangle rect)
		{
			DragForm.Bounds = rect;
			if (rect == Rectangle.Empty)
				DragForm.Region = new Region(Rectangle.Empty);
			else if (DragForm.Region != null)
				DragForm.Region = null;
		}
	}
}
