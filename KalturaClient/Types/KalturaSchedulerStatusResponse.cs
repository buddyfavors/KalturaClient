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
	public class KalturaSchedulerStatusResponse : KalturaObjectBase
	{
		#region Private Fields
		private IList<KalturaBatchQueuesStatus> _QueuesStatus;
		private IList<KalturaControlPanelCommand> _ControlPanelCommands;
		private IList<KalturaSchedulerConfig> _SchedulerConfigs;
		#endregion

		#region Properties
		public IList<KalturaBatchQueuesStatus> QueuesStatus
		{
			get { return _QueuesStatus; }
			set 
			{ 
				_QueuesStatus = value;
				OnPropertyChanged("QueuesStatus");
			}
		}
		public IList<KalturaControlPanelCommand> ControlPanelCommands
		{
			get { return _ControlPanelCommands; }
			set 
			{ 
				_ControlPanelCommands = value;
				OnPropertyChanged("ControlPanelCommands");
			}
		}
		public IList<KalturaSchedulerConfig> SchedulerConfigs
		{
			get { return _SchedulerConfigs; }
			set 
			{ 
				_SchedulerConfigs = value;
				OnPropertyChanged("SchedulerConfigs");
			}
		}
		#endregion

		#region CTor
		public KalturaSchedulerStatusResponse()
		{
		}

		public KalturaSchedulerStatusResponse(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "queuesStatus":
						this.QueuesStatus = new List<KalturaBatchQueuesStatus>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.QueuesStatus.Add((KalturaBatchQueuesStatus)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "controlPanelCommands":
						this.ControlPanelCommands = new List<KalturaControlPanelCommand>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ControlPanelCommands.Add((KalturaControlPanelCommand)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "schedulerConfigs":
						this.SchedulerConfigs = new List<KalturaSchedulerConfig>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.SchedulerConfigs.Add((KalturaSchedulerConfig)KalturaObjectFactory.Create(arrayNode));
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
			kparams.AddReplace("objectType", "KalturaSchedulerStatusResponse");
			if (this.QueuesStatus != null)
			{
				if (this.QueuesStatus.Count == 0)
				{
					kparams.Add("queuesStatus:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaBatchQueuesStatus item in this.QueuesStatus)
					{
						kparams.Add("queuesStatus:" + i, item.ToParams());
						i++;
					}
				}
			}
			if (this.ControlPanelCommands != null)
			{
				if (this.ControlPanelCommands.Count == 0)
				{
					kparams.Add("controlPanelCommands:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaControlPanelCommand item in this.ControlPanelCommands)
					{
						kparams.Add("controlPanelCommands:" + i, item.ToParams());
						i++;
					}
				}
			}
			if (this.SchedulerConfigs != null)
			{
				if (this.SchedulerConfigs.Count == 0)
				{
					kparams.Add("schedulerConfigs:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaSchedulerConfig item in this.SchedulerConfigs)
					{
						kparams.Add("schedulerConfigs:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

