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

	public class KalturaShortLinkService : KalturaServiceBase
	{
	public KalturaShortLinkService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaShortLinkListResponse List()
		{
			return this.List(null);
		}

		public KalturaShortLinkListResponse List(KalturaShortLinkFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaShortLinkListResponse List(KalturaShortLinkFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("shortlink_shortlink", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLinkListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaShortLink Add(KalturaShortLink shortLink)
		{
			KalturaParams kparams = new KalturaParams();
			if (shortLink != null)
				kparams.Add("shortLink", shortLink.ToParams());
			_Client.QueueServiceCall("shortlink_shortlink", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLink)KalturaObjectFactory.Create(result);
		}

		public KalturaShortLink Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("shortlink_shortlink", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLink)KalturaObjectFactory.Create(result);
		}

		public KalturaShortLink Update(string id, KalturaShortLink shortLink)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (shortLink != null)
				kparams.Add("shortLink", shortLink.ToParams());
			_Client.QueueServiceCall("shortlink_shortlink", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLink)KalturaObjectFactory.Create(result);
		}

		public KalturaShortLink Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("shortlink_shortlink", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLink)KalturaObjectFactory.Create(result);
		}
	}
}
