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
	public class KalturaAssetParamsOutputBaseFilter : KalturaAssetParamsFilter
	{
		#region Private Fields
		private int _AssetParamsIdEqual = Int32.MinValue;
		private string _AssetParamsVersionEqual = null;
		private string _AssetIdEqual = null;
		private string _AssetVersionEqual = null;
		private KalturaContainerFormat _FormatEqual = null;
		#endregion

		#region Properties
		public int AssetParamsIdEqual
		{
			get { return _AssetParamsIdEqual; }
			set 
			{ 
				_AssetParamsIdEqual = value;
				OnPropertyChanged("AssetParamsIdEqual");
			}
		}
		public string AssetParamsVersionEqual
		{
			get { return _AssetParamsVersionEqual; }
			set 
			{ 
				_AssetParamsVersionEqual = value;
				OnPropertyChanged("AssetParamsVersionEqual");
			}
		}
		public string AssetIdEqual
		{
			get { return _AssetIdEqual; }
			set 
			{ 
				_AssetIdEqual = value;
				OnPropertyChanged("AssetIdEqual");
			}
		}
		public string AssetVersionEqual
		{
			get { return _AssetVersionEqual; }
			set 
			{ 
				_AssetVersionEqual = value;
				OnPropertyChanged("AssetVersionEqual");
			}
		}
		public KalturaContainerFormat FormatEqual
		{
			get { return _FormatEqual; }
			set 
			{ 
				_FormatEqual = value;
				OnPropertyChanged("FormatEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetParamsOutputBaseFilter()
		{
		}

		public KalturaAssetParamsOutputBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "assetParamsIdEqual":
						this.AssetParamsIdEqual = ParseInt(txt);
						continue;
					case "assetParamsVersionEqual":
						this.AssetParamsVersionEqual = txt;
						continue;
					case "assetIdEqual":
						this.AssetIdEqual = txt;
						continue;
					case "assetVersionEqual":
						this.AssetVersionEqual = txt;
						continue;
					case "formatEqual":
						this.FormatEqual = (KalturaContainerFormat)KalturaStringEnum.Parse(typeof(KalturaContainerFormat), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAssetParamsOutputBaseFilter");
			kparams.AddIntIfNotNull("assetParamsIdEqual", this.AssetParamsIdEqual);
			kparams.AddStringIfNotNull("assetParamsVersionEqual", this.AssetParamsVersionEqual);
			kparams.AddStringIfNotNull("assetIdEqual", this.AssetIdEqual);
			kparams.AddStringIfNotNull("assetVersionEqual", this.AssetVersionEqual);
			kparams.AddStringEnumIfNotNull("formatEqual", this.FormatEqual);
			return kparams;
		}
		#endregion
	}
}

