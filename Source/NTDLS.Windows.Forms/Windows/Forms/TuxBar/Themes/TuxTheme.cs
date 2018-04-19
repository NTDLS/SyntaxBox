//    Copyright (C) 2005  Sebastian Faltoni
//	  Copyright (C) 2005  Riccardo Marzi
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

using System;
using System.Drawing;
using NTDLS.Windows.Forms.TuxBar;

namespace NTDLS.Windows.Forms.TuxBar.Themes
{
	
	public abstract class TuxTheme
	{
		public virtual void DrawTuxBarItemHeaderText(Graphics gfx, Rectangle dest,string s)
		{

		}

		public virtual void DrawTuxBarItemHeaderBK(Graphics gfx, Rectangle dest, HeaderState state)
		{
		}
		public virtual void DrawTuxBarItemHeaderButton(Graphics gfx, Rectangle bounds,HeaderState state)
		{
		}
		public virtual void DrawTuxBarItemMainBK(Graphics gfx, Rectangle dest)
		{
		}	
		public virtual void DrawTuxBarItemMainBorder(Graphics gfx, Rectangle dest)
		{
		}	

		public virtual void DrawTuxBarContainerBK(Graphics gfx, Rectangle dest)
		{
		}	
	} 

}