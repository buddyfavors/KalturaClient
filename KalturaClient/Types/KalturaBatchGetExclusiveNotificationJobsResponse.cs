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
	public class KalturaBatchGetExclusiveNotificationJobsResponse : KalturaObjectBase
	{
		#region Private Fields
		private IList<KalturaBatchJob> _Notifications;
		private IList<KalturaPartner> _Partners;
		#endregion

		#region Properties
		public IList<KalturaBatchJob> Notifications
		{
			get { return _Notifications; }
			set 
			{ 
				_Notifications = value;
				OnPropertyChanged("Notifications");
			}
		}
		public IList<KalturaPartner> Partners
		{
			get { return _Partners; }
			set 
			{ 
				_Partners = value;
				OnPropertyChanged("Partners");
			}
		}
		#endregion

		#region CTor
		public KalturaBatchGetExclusiveNotificationJobsResponse()
		{
		}

		public KalturaBatchGetExclusiveNotificationJobsResponse(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "notifications":
						this.Notifications = new List<KalturaBatchJob>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Notifications.Add((KalturaBatchJob)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "partners":
						this.Partners = new List<KalturaPartner>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Partners.Add((KalturaPartner)KalturaObjectFactory.Create(arrayNode));
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
			kparams.AddReplace("objectType", "KalturaBatchGetExclusiveNotificationJobsResponse");
			if (this.Notifications != null)
			{
				if (this.Notifications.Count == 0)
				{
					kparams.Add("notifications:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaBatchJob item in this.Notifications)
					{
						kparams.Add("notifications:" + i, item.ToParams());
						i++;
					}
				}
			}
			if (this.Partners != null)
			{
				if (this.Partners.Count == 0)
				{
					kparams.Add("partners:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaPartner item in this.Partners)
					{
						kparams.Add("partners:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

