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
	public class KalturaEmailNotificationCategoryRecipientProvider : KalturaEmailNotificationRecipientProvider
	{
		#region Private Fields
		private KalturaStringValue _CategoryId;
		private KalturaCategoryUserProviderFilter _CategoryUserFilter;
		#endregion

		#region Properties
		public KalturaStringValue CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public KalturaCategoryUserProviderFilter CategoryUserFilter
		{
			get { return _CategoryUserFilter; }
			set 
			{ 
				_CategoryUserFilter = value;
				OnPropertyChanged("CategoryUserFilter");
			}
		}
		#endregion

		#region CTor
		public KalturaEmailNotificationCategoryRecipientProvider()
		{
		}

		public KalturaEmailNotificationCategoryRecipientProvider(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryId":
						this.CategoryId = (KalturaStringValue)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "categoryUserFilter":
						this.CategoryUserFilter = (KalturaCategoryUserProviderFilter)KalturaObjectFactory.Create(propertyNode);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEmailNotificationCategoryRecipientProvider");
			if (this.CategoryId != null)
				kparams.Add("categoryId", this.CategoryId.ToParams());
			if (this.CategoryUserFilter != null)
				kparams.Add("categoryUserFilter", this.CategoryUserFilter.ToParams());
			return kparams;
		}
		#endregion
	}
}

