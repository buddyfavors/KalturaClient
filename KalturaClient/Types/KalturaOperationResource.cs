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
	public class KalturaOperationResource : KalturaContentResource
	{
		#region Private Fields
		private KalturaContentResource _Resource;
		private IList<KalturaOperationAttributes> _OperationAttributes;
		private int _AssetParamsId = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaContentResource Resource
		{
			get { return _Resource; }
			set 
			{ 
				_Resource = value;
				OnPropertyChanged("Resource");
			}
		}
		public IList<KalturaOperationAttributes> OperationAttributes
		{
			get { return _OperationAttributes; }
			set 
			{ 
				_OperationAttributes = value;
				OnPropertyChanged("OperationAttributes");
			}
		}
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		#endregion

		#region CTor
		public KalturaOperationResource()
		{
		}

		public KalturaOperationResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "resource":
						this.Resource = (KalturaContentResource)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "operationAttributes":
						this.OperationAttributes = new List<KalturaOperationAttributes>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.OperationAttributes.Add((KalturaOperationAttributes)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "assetParamsId":
						this.AssetParamsId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaOperationResource");
			if (this.Resource != null)
				kparams.Add("resource", this.Resource.ToParams());
			if (this.OperationAttributes != null)
			{
				if (this.OperationAttributes.Count == 0)
				{
					kparams.Add("operationAttributes:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaOperationAttributes item in this.OperationAttributes)
					{
						kparams.Add("operationAttributes:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("assetParamsId", this.AssetParamsId);
			return kparams;
		}
		#endregion
	}
}

