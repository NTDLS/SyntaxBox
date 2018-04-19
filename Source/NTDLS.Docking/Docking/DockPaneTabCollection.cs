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
using System.Collections;

namespace NTDLS.Docking
{
	/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/ClassDef/*'/>>
	public sealed class DockPaneTabCollection : IEnumerable
	{
		#region class DockPaneTabEnumerator
		private class DockPaneTabEnumerator : IEnumerator
		{
			private DockPaneTabCollection m_tabs;
			private int m_index;

			public DockPaneTabEnumerator(DockPaneTabCollection tabs)
			{
				m_tabs = tabs;
				Reset();
			}

			public bool MoveNext() 
			{
				m_index++;
				return(m_index < m_tabs.Count);
			}

			public object Current
			{
				get	{	return m_tabs[m_index];	}
			}

			public void Reset()
			{
				m_index = -1;
			}
		}
		#endregion

		#region IEnumerable Members
		/// <exclude/>
		public IEnumerator GetEnumerator()
		{
			return new DockPaneTabEnumerator(this);
		}
		#endregion

		internal DockPaneTabCollection(DockPane pane)
		{
			m_dockPane = pane;
		}

		private DockPane m_dockPane;
		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Property[@name="DockPane"]/*'/>>
		public DockPane DockPane
		{
			get	{	return m_dockPane;	}
		}

		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Property[@name="Count"]/*'/>>
		public int Count
		{
			get	{	return DockPane.DisplayingContents.Count;	}
		}

		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Property[@name="Item"]/*'/>>
		public DockPaneTab this[int index]
		{
			get
			{	
				IDockableWindow content = DockPane.DisplayingContents[index];
				if (content == null)
					throw(new IndexOutOfRangeException());
				return content.DockHandler.DockPaneTab;
			}
		}

		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Method[@name="Contains"]/*'/>>
		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Method[@name="Contains(DockPaneTab)"]/*'/>>
		public bool Contains(DockPaneTab tab)
		{
			return (IndexOf(tab) != -1);
		}

		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Method[@name="Contains(IDockContent)"]/*'/>>
		public bool Contains(IDockableWindow content)
		{
			return (IndexOf(content) != -1);
		}

		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Method[@name="IndexOf"]/*'/>>
		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Method[@name="IndexOf(DockPaneTab)"]/*'/>>
		public int IndexOf(DockPaneTab tab)
		{
			return DockPane.DisplayingContents.IndexOf(tab.Content);
		}

		/// <include file='CodeDoc\DockPaneTabCollection.xml' path='//CodeDoc/Class[@name="DockPaneTabCollection"]/Method[@name="IndexOf(IDockContent)"]/*'/>>
		public int IndexOf(IDockableWindow content)
		{
			return DockPane.DisplayingContents.IndexOf(content);
		}
	}
}
