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

namespace NTDLS.Docking
{
	/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/ClassDef/*'/>
	public class NestedDockingStatus
	{
		internal NestedDockingStatus(DockPane pane)
		{
			m_dockPane = pane;
		}

		private DockPane m_dockPane = null;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="DockPane"]/*'/>
		public DockPane DockPane
		{
			get	{	return m_dockPane;	}
		}
		
		private DockList m_dockList = null;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="DockList"]/*'/>
		public DockList DockList
		{
			get	{	return m_dockList;	}
		}
		
		private DockPane m_prevPane = null;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="PrevPane"]/*'/>
		public DockPane PrevPane
		{
			get	{	return m_prevPane;	}
		}

		private DockAlignment m_alignment = DockAlignment.Left;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="Alignment"]/*'/>
		public DockAlignment Alignment
		{
			get	{	return m_alignment;	}
		}

		private double m_proportion = 0.5;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="Proportion"]/*'/>
		public double Proportion
		{
			get	{	return m_proportion;	}
		}

		private bool m_isDisplaying = false;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="IsDisplaying"]/*'/>
		public bool IsDisplaying
		{
			get	{	return m_isDisplaying;	}
		}

		private DockPane m_displayingPrevPane = null;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="DisplayingPrevPane"]/*'/>
		public DockPane DisplayingPrevPane
		{
			get	{	return m_displayingPrevPane;	}
		}

		private DockAlignment m_displayingAlignment = DockAlignment.Left;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="DisplayingAlignment"]/*'/>
		public DockAlignment DisplayingAlignment
		{
			get	{	return m_displayingAlignment;	}
		}

		private double m_displayingProportion = 0.5;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="DisplayingProportion"]/*'/>
		public double DisplayingProportion
		{
			get	{	return m_displayingProportion;	}
		}

		private Rectangle m_logicalBounds = Rectangle.Empty; 
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="LogicalBounds"]/*'/>
		public Rectangle LogicalBounds
		{
			get	{	return m_logicalBounds;	}
		}

		private Rectangle m_paneBounds = Rectangle.Empty;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="PaneBounds"]/*'/>
		public Rectangle PaneBounds
		{
			get	{	return m_paneBounds;	}
		}

		private Rectangle m_splitterBounds = Rectangle.Empty;
		/// <include file='CodeDoc\NestedDockingStatus.xml' path='//CodeDoc/Class[@name="NestedDockingStatus"]/Property[@name="SplitterBounds"]/*'/>
		public Rectangle SplitterBounds
		{
			get	{	return m_splitterBounds;	}
		}

		internal void SetStatus(DockList list, DockPane prevPane, DockAlignment alignment, double proportion)
		{
			m_dockList = list;
			m_prevPane = prevPane;
			m_alignment = alignment;
			m_proportion = proportion;
		}

		internal void SetDisplayingStatus(bool isDisplaying, DockPane displayingPrevPane, DockAlignment displayingAlignment, double displayingProportion)
		{
			m_isDisplaying = isDisplaying;
			m_displayingPrevPane = displayingPrevPane;
			m_displayingAlignment = displayingAlignment;
			m_displayingProportion = displayingProportion;
		}

		internal void SetDisplayingBounds(Rectangle logicalBounds, Rectangle paneBounds, Rectangle splitterBounds)
		{
			m_logicalBounds = logicalBounds;
			m_paneBounds = paneBounds;
			m_splitterBounds = splitterBounds;
		}
	}
}
