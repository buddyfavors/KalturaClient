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
	public class KalturaSearchOperator : KalturaSearchItem
	{
		#region Private Fields
		private KalturaSearchOperatorType _Type = (KalturaSearchOperatorType)Int32.MinValue;
		private IList<KalturaSearchItem> _Items;
		#endregion

		#region Properties
		public KalturaSearchOperatorType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public IList<KalturaSearchItem> Items
		{
			get { return _Items; }
			set 
			{ 
				_Items = value;
				OnPropertyChanged("Items");
			}
		}
		#endregion

		#region CTor
		public KalturaSearchOperator()
		{
		}

		public KalturaSearchOperator(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this.Type = (KalturaSearchOperatorType)ParseEnum(typeof(KalturaSearchOperatorType), txt);
						continue;
					case "items":
						this.Items = new List<KalturaSearchItem>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Items.Add((KalturaSearchItem)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSearchOperator");
			kparams.AddEnumIfNotNull("type", this.Type);
			if (this.Items != null)
			{
				if (this.Items.Count == 0)
				{
					kparams.Add("items:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaSearchItem item in this.Items)
					{
						kparams.Add("items:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

