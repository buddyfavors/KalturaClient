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
using System.IO;

namespace Kaltura
{

	public class KalturaLiveStreamService : KalturaServiceBase
	{
	public KalturaLiveStreamService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaLiveStreamAdminEntry Add(KalturaLiveStreamAdminEntry liveStreamEntry)
		{
			return this.Add(liveStreamEntry, null);
		}

		public KalturaLiveStreamAdminEntry Add(KalturaLiveStreamAdminEntry liveStreamEntry, KalturaSourceType sourceType)
		{
			KalturaParams kparams = new KalturaParams();
			if (liveStreamEntry != null)
				kparams.Add("liveStreamEntry", liveStreamEntry.ToParams());
			kparams.AddStringEnumIfNotNull("sourceType", sourceType);
			_Client.QueueServiceCall("livestream", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamAdminEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaLiveStreamEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaLiveStreamEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("livestream", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaLiveStreamAdminEntry Update(string entryId, KalturaLiveStreamAdminEntry liveStreamEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (liveStreamEntry != null)
				kparams.Add("liveStreamEntry", liveStreamEntry.ToParams());
			_Client.QueueServiceCall("livestream", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamAdminEntry)KalturaObjectFactory.Create(result);
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("livestream", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaLiveStreamListResponse List()
		{
			return this.List(null);
		}

		public KalturaLiveStreamListResponse List(KalturaLiveStreamEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaLiveStreamListResponse List(KalturaLiveStreamEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("livestream", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaLiveStreamEntry UpdateOfflineThumbnailJpeg(string entryId, FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("livestream", "updateOfflineThumbnailJpeg", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaLiveStreamEntry UpdateOfflineThumbnailFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("livestream", "updateOfflineThumbnailFromUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result);
		}

		public bool IsLive(string id, KalturaPlaybackProtocol protocol)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddStringEnumIfNotNull("protocol", protocol);
			_Client.QueueServiceCall("livestream", "isLive", kparams);
			if (this._Client.IsMultiRequest)
				return false;
			XmlElement result = _Client.DoQueue();
			if (result.InnerText == "1")
				return true;
			return false;
		}
	}
}
