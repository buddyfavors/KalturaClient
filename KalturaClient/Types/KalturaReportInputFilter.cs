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
	public class KalturaReportInputFilter : KalturaReportInputBaseFilter
	{
		#region Private Fields
		private string _Keywords = null;
		private bool? _SearchInTags = false;
		private bool? _SearchInAdminTags = false;
		private string _Categories = null;
		private int _TimeZoneOffset = Int32.MinValue;
		private KalturaReportInterval _Interval = null;
		#endregion

		#region Properties
		public string Keywords
		{
			get { return _Keywords; }
			set 
			{ 
				_Keywords = value;
				OnPropertyChanged("Keywords");
			}
		}
		public bool? SearchInTags
		{
			get { return _SearchInTags; }
			set 
			{ 
				_SearchInTags = value;
				OnPropertyChanged("SearchInTags");
			}
		}
		public bool? SearchInAdminTags
		{
			get { return _SearchInAdminTags; }
			set 
			{ 
				_SearchInAdminTags = value;
				OnPropertyChanged("SearchInAdminTags");
			}
		}
		public string Categories
		{
			get { return _Categories; }
			set 
			{ 
				_Categories = value;
				OnPropertyChanged("Categories");
			}
		}
		public int TimeZoneOffset
		{
			get { return _TimeZoneOffset; }
			set 
			{ 
				_TimeZoneOffset = value;
				OnPropertyChanged("TimeZoneOffset");
			}
		}
		public KalturaReportInterval Interval
		{
			get { return _Interval; }
			set 
			{ 
				_Interval = value;
				OnPropertyChanged("Interval");
			}
		}
		#endregion

		#region CTor
		public KalturaReportInputFilter()
		{
		}

		public KalturaReportInputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "keywords":
						this.Keywords = txt;
						continue;
					case "searchInTags":
						this.SearchInTags = ParseBool(txt);
						continue;
					case "searchInAdminTags":
						this.SearchInAdminTags = ParseBool(txt);
						continue;
					case "categories":
						this.Categories = txt;
						continue;
					case "timeZoneOffset":
						this.TimeZoneOffset = ParseInt(txt);
						continue;
					case "interval":
						this.Interval = (KalturaReportInterval)KalturaStringEnum.Parse(typeof(KalturaReportInterval), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaReportInputFilter");
			kparams.AddStringIfNotNull("keywords", this.Keywords);
			kparams.AddBoolIfNotNull("searchInTags", this.SearchInTags);
			kparams.AddBoolIfNotNull("searchInAdminTags", this.SearchInAdminTags);
			kparams.AddStringIfNotNull("categories", this.Categories);
			kparams.AddIntIfNotNull("timeZoneOffset", this.TimeZoneOffset);
			kparams.AddStringEnumIfNotNull("interval", this.Interval);
			return kparams;
		}
		#endregion
	}
}

