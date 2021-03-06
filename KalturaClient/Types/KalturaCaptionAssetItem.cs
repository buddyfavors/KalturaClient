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
	public class KalturaCaptionAssetItem : KalturaObjectBase
	{
		#region Private Fields
		private KalturaCaptionAsset _Asset;
		private KalturaBaseEntry _Entry;
		private int _StartTime = Int32.MinValue;
		private int _EndTime = Int32.MinValue;
		private string _Content = null;
		#endregion

		#region Properties
		public KalturaCaptionAsset Asset
		{
			get { return _Asset; }
			set 
			{ 
				_Asset = value;
				OnPropertyChanged("Asset");
			}
		}
		public KalturaBaseEntry Entry
		{
			get { return _Entry; }
			set 
			{ 
				_Entry = value;
				OnPropertyChanged("Entry");
			}
		}
		public int StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		public string Content
		{
			get { return _Content; }
			set 
			{ 
				_Content = value;
				OnPropertyChanged("Content");
			}
		}
		#endregion

		#region CTor
		public KalturaCaptionAssetItem()
		{
		}

		public KalturaCaptionAssetItem(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "asset":
						this.Asset = (KalturaCaptionAsset)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "entry":
						this.Entry = (KalturaBaseEntry)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "startTime":
						this.StartTime = ParseInt(txt);
						continue;
					case "endTime":
						this.EndTime = ParseInt(txt);
						continue;
					case "content":
						this.Content = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCaptionAssetItem");
			if (this.Asset != null)
				kparams.Add("asset", this.Asset.ToParams());
			if (this.Entry != null)
				kparams.Add("entry", this.Entry.ToParams());
			kparams.AddIntIfNotNull("startTime", this.StartTime);
			kparams.AddIntIfNotNull("endTime", this.EndTime);
			kparams.AddStringIfNotNull("content", this.Content);
			return kparams;
		}
		#endregion
	}
}

