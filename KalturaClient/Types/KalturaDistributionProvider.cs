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
	public class KalturaDistributionProvider : KalturaObjectBase
	{
		#region Private Fields
		private KalturaDistributionProviderType _Type = null;
		private string _Name = null;
		private bool? _ScheduleUpdateEnabled = false;
		private bool? _AvailabilityUpdateEnabled = false;
		private bool? _DeleteInsteadUpdate = false;
		private int _IntervalBeforeSunrise = Int32.MinValue;
		private int _IntervalBeforeSunset = Int32.MinValue;
		private string _UpdateRequiredEntryFields = null;
		private string _UpdateRequiredMetadataXPaths = null;
		#endregion

		#region Properties
		public KalturaDistributionProviderType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public bool? ScheduleUpdateEnabled
		{
			get { return _ScheduleUpdateEnabled; }
			set 
			{ 
				_ScheduleUpdateEnabled = value;
				OnPropertyChanged("ScheduleUpdateEnabled");
			}
		}
		public bool? AvailabilityUpdateEnabled
		{
			get { return _AvailabilityUpdateEnabled; }
			set 
			{ 
				_AvailabilityUpdateEnabled = value;
				OnPropertyChanged("AvailabilityUpdateEnabled");
			}
		}
		public bool? DeleteInsteadUpdate
		{
			get { return _DeleteInsteadUpdate; }
			set 
			{ 
				_DeleteInsteadUpdate = value;
				OnPropertyChanged("DeleteInsteadUpdate");
			}
		}
		public int IntervalBeforeSunrise
		{
			get { return _IntervalBeforeSunrise; }
			set 
			{ 
				_IntervalBeforeSunrise = value;
				OnPropertyChanged("IntervalBeforeSunrise");
			}
		}
		public int IntervalBeforeSunset
		{
			get { return _IntervalBeforeSunset; }
			set 
			{ 
				_IntervalBeforeSunset = value;
				OnPropertyChanged("IntervalBeforeSunset");
			}
		}
		public string UpdateRequiredEntryFields
		{
			get { return _UpdateRequiredEntryFields; }
			set 
			{ 
				_UpdateRequiredEntryFields = value;
				OnPropertyChanged("UpdateRequiredEntryFields");
			}
		}
		public string UpdateRequiredMetadataXPaths
		{
			get { return _UpdateRequiredMetadataXPaths; }
			set 
			{ 
				_UpdateRequiredMetadataXPaths = value;
				OnPropertyChanged("UpdateRequiredMetadataXPaths");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionProvider()
		{
		}

		public KalturaDistributionProvider(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this.Type = (KalturaDistributionProviderType)KalturaStringEnum.Parse(typeof(KalturaDistributionProviderType), txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "scheduleUpdateEnabled":
						this.ScheduleUpdateEnabled = ParseBool(txt);
						continue;
					case "availabilityUpdateEnabled":
						this.AvailabilityUpdateEnabled = ParseBool(txt);
						continue;
					case "deleteInsteadUpdate":
						this.DeleteInsteadUpdate = ParseBool(txt);
						continue;
					case "intervalBeforeSunrise":
						this.IntervalBeforeSunrise = ParseInt(txt);
						continue;
					case "intervalBeforeSunset":
						this.IntervalBeforeSunset = ParseInt(txt);
						continue;
					case "updateRequiredEntryFields":
						this.UpdateRequiredEntryFields = txt;
						continue;
					case "updateRequiredMetadataXPaths":
						this.UpdateRequiredMetadataXPaths = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDistributionProvider");
			kparams.AddStringEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddBoolIfNotNull("scheduleUpdateEnabled", this.ScheduleUpdateEnabled);
			kparams.AddBoolIfNotNull("availabilityUpdateEnabled", this.AvailabilityUpdateEnabled);
			kparams.AddBoolIfNotNull("deleteInsteadUpdate", this.DeleteInsteadUpdate);
			kparams.AddIntIfNotNull("intervalBeforeSunrise", this.IntervalBeforeSunrise);
			kparams.AddIntIfNotNull("intervalBeforeSunset", this.IntervalBeforeSunset);
			kparams.AddStringIfNotNull("updateRequiredEntryFields", this.UpdateRequiredEntryFields);
			kparams.AddStringIfNotNull("updateRequiredMetadataXPaths", this.UpdateRequiredMetadataXPaths);
			return kparams;
		}
		#endregion
	}
}

