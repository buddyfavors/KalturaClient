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
	public class KalturaSearchResultResponse : KalturaObjectBase
	{
		#region Private Fields
		private IList<KalturaSearchResult> _Objects;
		private bool? _NeedMediaInfo = false;
		#endregion

		#region Properties
		public IList<KalturaSearchResult> Objects
		{
			get { return _Objects; }
			set 
			{ 
				_Objects = value;
				OnPropertyChanged("Objects");
			}
		}
		public bool? NeedMediaInfo
		{
			get { return _NeedMediaInfo; }
			set 
			{ 
				_NeedMediaInfo = value;
				OnPropertyChanged("NeedMediaInfo");
			}
		}
		#endregion

		#region CTor
		public KalturaSearchResultResponse()
		{
		}

		public KalturaSearchResultResponse(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "objects":
						this.Objects = new List<KalturaSearchResult>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Objects.Add((KalturaSearchResult)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "needMediaInfo":
						this.NeedMediaInfo = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSearchResultResponse");
			if (this.Objects != null)
			{
				if (this.Objects.Count == 0)
				{
					kparams.Add("objects:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaSearchResult item in this.Objects)
					{
						kparams.Add("objects:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddBoolIfNotNull("needMediaInfo", this.NeedMediaInfo);
			return kparams;
		}
		#endregion
	}
}

