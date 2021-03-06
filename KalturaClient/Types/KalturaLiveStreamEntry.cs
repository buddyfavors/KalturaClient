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
	public class KalturaLiveStreamEntry : KalturaMediaEntry
	{
		#region Private Fields
		private string _OfflineMessage = null;
		private string _StreamRemoteId = null;
		private string _StreamRemoteBackupId = null;
		private IList<KalturaLiveStreamBitrate> _Bitrates;
		private string _PrimaryBroadcastingUrl = null;
		private string _SecondaryBroadcastingUrl = null;
		private string _StreamName = null;
		private string _StreamUrl = null;
		private string _HlsStreamUrl = null;
		private KalturaDVRStatus _DvrStatus = (KalturaDVRStatus)Int32.MinValue;
		private int _DvrWindow = Int32.MinValue;
		private string _UrlManager = null;
		private IList<KalturaLiveStreamConfiguration> _LiveStreamConfigurations;
		private string _EncodingIP1 = null;
		private string _EncodingIP2 = null;
		private string _StreamPassword = null;
		private string _StreamUsername = null;
		#endregion

		#region Properties
		public string OfflineMessage
		{
			get { return _OfflineMessage; }
			set 
			{ 
				_OfflineMessage = value;
				OnPropertyChanged("OfflineMessage");
			}
		}
		public string StreamRemoteId
		{
			get { return _StreamRemoteId; }
			set 
			{ 
				_StreamRemoteId = value;
				OnPropertyChanged("StreamRemoteId");
			}
		}
		public string StreamRemoteBackupId
		{
			get { return _StreamRemoteBackupId; }
			set 
			{ 
				_StreamRemoteBackupId = value;
				OnPropertyChanged("StreamRemoteBackupId");
			}
		}
		public IList<KalturaLiveStreamBitrate> Bitrates
		{
			get { return _Bitrates; }
			set 
			{ 
				_Bitrates = value;
				OnPropertyChanged("Bitrates");
			}
		}
		public string PrimaryBroadcastingUrl
		{
			get { return _PrimaryBroadcastingUrl; }
			set 
			{ 
				_PrimaryBroadcastingUrl = value;
				OnPropertyChanged("PrimaryBroadcastingUrl");
			}
		}
		public string SecondaryBroadcastingUrl
		{
			get { return _SecondaryBroadcastingUrl; }
			set 
			{ 
				_SecondaryBroadcastingUrl = value;
				OnPropertyChanged("SecondaryBroadcastingUrl");
			}
		}
		public string StreamName
		{
			get { return _StreamName; }
			set 
			{ 
				_StreamName = value;
				OnPropertyChanged("StreamName");
			}
		}
		public string StreamUrl
		{
			get { return _StreamUrl; }
			set 
			{ 
				_StreamUrl = value;
				OnPropertyChanged("StreamUrl");
			}
		}
		public string HlsStreamUrl
		{
			get { return _HlsStreamUrl; }
			set 
			{ 
				_HlsStreamUrl = value;
				OnPropertyChanged("HlsStreamUrl");
			}
		}
		public KalturaDVRStatus DvrStatus
		{
			get { return _DvrStatus; }
			set 
			{ 
				_DvrStatus = value;
				OnPropertyChanged("DvrStatus");
			}
		}
		public int DvrWindow
		{
			get { return _DvrWindow; }
			set 
			{ 
				_DvrWindow = value;
				OnPropertyChanged("DvrWindow");
			}
		}
		public string UrlManager
		{
			get { return _UrlManager; }
			set 
			{ 
				_UrlManager = value;
				OnPropertyChanged("UrlManager");
			}
		}
		public IList<KalturaLiveStreamConfiguration> LiveStreamConfigurations
		{
			get { return _LiveStreamConfigurations; }
			set 
			{ 
				_LiveStreamConfigurations = value;
				OnPropertyChanged("LiveStreamConfigurations");
			}
		}
		public string EncodingIP1
		{
			get { return _EncodingIP1; }
			set 
			{ 
				_EncodingIP1 = value;
				OnPropertyChanged("EncodingIP1");
			}
		}
		public string EncodingIP2
		{
			get { return _EncodingIP2; }
			set 
			{ 
				_EncodingIP2 = value;
				OnPropertyChanged("EncodingIP2");
			}
		}
		public string StreamPassword
		{
			get { return _StreamPassword; }
			set 
			{ 
				_StreamPassword = value;
				OnPropertyChanged("StreamPassword");
			}
		}
		public string StreamUsername
		{
			get { return _StreamUsername; }
			set 
			{ 
				_StreamUsername = value;
				OnPropertyChanged("StreamUsername");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveStreamEntry()
		{
		}

		public KalturaLiveStreamEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "offlineMessage":
						this.OfflineMessage = txt;
						continue;
					case "streamRemoteId":
						this.StreamRemoteId = txt;
						continue;
					case "streamRemoteBackupId":
						this.StreamRemoteBackupId = txt;
						continue;
					case "bitrates":
						this.Bitrates = new List<KalturaLiveStreamBitrate>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Bitrates.Add((KalturaLiveStreamBitrate)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "primaryBroadcastingUrl":
						this.PrimaryBroadcastingUrl = txt;
						continue;
					case "secondaryBroadcastingUrl":
						this.SecondaryBroadcastingUrl = txt;
						continue;
					case "streamName":
						this.StreamName = txt;
						continue;
					case "streamUrl":
						this.StreamUrl = txt;
						continue;
					case "hlsStreamUrl":
						this.HlsStreamUrl = txt;
						continue;
					case "dvrStatus":
						this.DvrStatus = (KalturaDVRStatus)ParseEnum(typeof(KalturaDVRStatus), txt);
						continue;
					case "dvrWindow":
						this.DvrWindow = ParseInt(txt);
						continue;
					case "urlManager":
						this.UrlManager = txt;
						continue;
					case "liveStreamConfigurations":
						this.LiveStreamConfigurations = new List<KalturaLiveStreamConfiguration>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.LiveStreamConfigurations.Add((KalturaLiveStreamConfiguration)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "encodingIP1":
						this.EncodingIP1 = txt;
						continue;
					case "encodingIP2":
						this.EncodingIP2 = txt;
						continue;
					case "streamPassword":
						this.StreamPassword = txt;
						continue;
					case "streamUsername":
						this.StreamUsername = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveStreamEntry");
			kparams.AddStringIfNotNull("offlineMessage", this.OfflineMessage);
			kparams.AddStringIfNotNull("streamRemoteId", this.StreamRemoteId);
			kparams.AddStringIfNotNull("streamRemoteBackupId", this.StreamRemoteBackupId);
			if (this.Bitrates != null)
			{
				if (this.Bitrates.Count == 0)
				{
					kparams.Add("bitrates:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaLiveStreamBitrate item in this.Bitrates)
					{
						kparams.Add("bitrates:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("primaryBroadcastingUrl", this.PrimaryBroadcastingUrl);
			kparams.AddStringIfNotNull("secondaryBroadcastingUrl", this.SecondaryBroadcastingUrl);
			kparams.AddStringIfNotNull("streamName", this.StreamName);
			kparams.AddStringIfNotNull("streamUrl", this.StreamUrl);
			kparams.AddStringIfNotNull("hlsStreamUrl", this.HlsStreamUrl);
			kparams.AddEnumIfNotNull("dvrStatus", this.DvrStatus);
			kparams.AddIntIfNotNull("dvrWindow", this.DvrWindow);
			kparams.AddStringIfNotNull("urlManager", this.UrlManager);
			if (this.LiveStreamConfigurations != null)
			{
				if (this.LiveStreamConfigurations.Count == 0)
				{
					kparams.Add("liveStreamConfigurations:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaLiveStreamConfiguration item in this.LiveStreamConfigurations)
					{
						kparams.Add("liveStreamConfigurations:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("encodingIP1", this.EncodingIP1);
			kparams.AddStringIfNotNull("encodingIP2", this.EncodingIP2);
			kparams.AddStringIfNotNull("streamPassword", this.StreamPassword);
			kparams.AddStringIfNotNull("streamUsername", this.StreamUsername);
			return kparams;
		}
		#endregion
	}
}

