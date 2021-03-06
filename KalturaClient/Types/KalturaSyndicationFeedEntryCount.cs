// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2011  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSyndicationFeedEntryCount : KalturaObjectBase
	{
		#region Private Fields
		private int _TotalEntryCount = Int32.MinValue;
		private int _ActualEntryCount = Int32.MinValue;
		private int _RequireTranscodingCount = Int32.MinValue;
		#endregion

		#region Properties
		public int TotalEntryCount
		{
			get { return _TotalEntryCount; }
			set 
			{ 
				_TotalEntryCount = value;
				OnPropertyChanged("TotalEntryCount");
			}
		}
		public int ActualEntryCount
		{
			get { return _ActualEntryCount; }
			set 
			{ 
				_ActualEntryCount = value;
				OnPropertyChanged("ActualEntryCount");
			}
		}
		public int RequireTranscodingCount
		{
			get { return _RequireTranscodingCount; }
			set 
			{ 
				_RequireTranscodingCount = value;
				OnPropertyChanged("RequireTranscodingCount");
			}
		}
		#endregion

		#region CTor
		public KalturaSyndicationFeedEntryCount()
		{
		}

		public KalturaSyndicationFeedEntryCount(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "totalEntryCount":
						this.TotalEntryCount = ParseInt(txt);
						continue;
					case "actualEntryCount":
						this.ActualEntryCount = ParseInt(txt);
						continue;
					case "requireTranscodingCount":
						this.RequireTranscodingCount = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSyndicationFeedEntryCount");
			kparams.AddIntIfNotNull("totalEntryCount", this.TotalEntryCount);
			kparams.AddIntIfNotNull("actualEntryCount", this.ActualEntryCount);
			kparams.AddIntIfNotNull("requireTranscodingCount", this.RequireTranscodingCount);
			return kparams;
		}
		#endregion
	}
}

