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
	public class KalturaTagFilter : KalturaFilter
	{
		#region Private Fields
		private KalturaTaggedObjectType _ObjectTypeEqual = null;
		private string _TagEqual = null;
		private string _TagStartsWith = null;
		private int _InstanceCountEqual = Int32.MinValue;
		private int _InstanceCountIn = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaTaggedObjectType ObjectTypeEqual
		{
			get { return _ObjectTypeEqual; }
			set 
			{ 
				_ObjectTypeEqual = value;
				OnPropertyChanged("ObjectTypeEqual");
			}
		}
		public string TagEqual
		{
			get { return _TagEqual; }
			set 
			{ 
				_TagEqual = value;
				OnPropertyChanged("TagEqual");
			}
		}
		public string TagStartsWith
		{
			get { return _TagStartsWith; }
			set 
			{ 
				_TagStartsWith = value;
				OnPropertyChanged("TagStartsWith");
			}
		}
		public int InstanceCountEqual
		{
			get { return _InstanceCountEqual; }
			set 
			{ 
				_InstanceCountEqual = value;
				OnPropertyChanged("InstanceCountEqual");
			}
		}
		public int InstanceCountIn
		{
			get { return _InstanceCountIn; }
			set 
			{ 
				_InstanceCountIn = value;
				OnPropertyChanged("InstanceCountIn");
			}
		}
		#endregion

		#region CTor
		public KalturaTagFilter()
		{
		}

		public KalturaTagFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "objectTypeEqual":
						this.ObjectTypeEqual = (KalturaTaggedObjectType)KalturaStringEnum.Parse(typeof(KalturaTaggedObjectType), txt);
						continue;
					case "tagEqual":
						this.TagEqual = txt;
						continue;
					case "tagStartsWith":
						this.TagStartsWith = txt;
						continue;
					case "instanceCountEqual":
						this.InstanceCountEqual = ParseInt(txt);
						continue;
					case "instanceCountIn":
						this.InstanceCountIn = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaTagFilter");
			kparams.AddStringEnumIfNotNull("objectTypeEqual", this.ObjectTypeEqual);
			kparams.AddStringIfNotNull("tagEqual", this.TagEqual);
			kparams.AddStringIfNotNull("tagStartsWith", this.TagStartsWith);
			kparams.AddIntIfNotNull("instanceCountEqual", this.InstanceCountEqual);
			kparams.AddIntIfNotNull("instanceCountIn", this.InstanceCountIn);
			return kparams;
		}
		#endregion
	}
}

