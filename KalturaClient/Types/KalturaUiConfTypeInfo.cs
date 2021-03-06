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
	public class KalturaUiConfTypeInfo : KalturaObjectBase
	{
		#region Private Fields
		private KalturaUiConfObjType _Type = (KalturaUiConfObjType)Int32.MinValue;
		private IList<KalturaString> _Versions;
		private string _Directory = null;
		private string _Filename = null;
		#endregion

		#region Properties
		public KalturaUiConfObjType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public IList<KalturaString> Versions
		{
			get { return _Versions; }
			set 
			{ 
				_Versions = value;
				OnPropertyChanged("Versions");
			}
		}
		public string Directory
		{
			get { return _Directory; }
			set 
			{ 
				_Directory = value;
				OnPropertyChanged("Directory");
			}
		}
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		#endregion

		#region CTor
		public KalturaUiConfTypeInfo()
		{
		}

		public KalturaUiConfTypeInfo(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this.Type = (KalturaUiConfObjType)ParseEnum(typeof(KalturaUiConfObjType), txt);
						continue;
					case "versions":
						this.Versions = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Versions.Add((KalturaString)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "directory":
						this.Directory = txt;
						continue;
					case "filename":
						this.Filename = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUiConfTypeInfo");
			kparams.AddEnumIfNotNull("type", this.Type);
			if (this.Versions != null)
			{
				if (this.Versions.Count == 0)
				{
					kparams.Add("versions:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.Versions)
					{
						kparams.Add("versions:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("directory", this.Directory);
			kparams.AddStringIfNotNull("filename", this.Filename);
			return kparams;
		}
		#endregion
	}
}

