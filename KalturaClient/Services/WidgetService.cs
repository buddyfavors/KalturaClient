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

	public class KalturaWidgetService : KalturaServiceBase
	{
	public KalturaWidgetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaWidget Add(KalturaWidget widget)
		{
			KalturaParams kparams = new KalturaParams();
			if (widget != null)
				kparams.Add("widget", widget.ToParams());
			_Client.QueueServiceCall("widget", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaWidget)KalturaObjectFactory.Create(result);
		}

		public KalturaWidget Update(string id, KalturaWidget widget)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (widget != null)
				kparams.Add("widget", widget.ToParams());
			_Client.QueueServiceCall("widget", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaWidget)KalturaObjectFactory.Create(result);
		}

		public KalturaWidget Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("widget", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaWidget)KalturaObjectFactory.Create(result);
		}

		public KalturaWidget Clone(KalturaWidget widget)
		{
			KalturaParams kparams = new KalturaParams();
			if (widget != null)
				kparams.Add("widget", widget.ToParams());
			_Client.QueueServiceCall("widget", "clone", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaWidget)KalturaObjectFactory.Create(result);
		}

		public KalturaWidgetListResponse List()
		{
			return this.List(null);
		}

		public KalturaWidgetListResponse List(KalturaWidgetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaWidgetListResponse List(KalturaWidgetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("widget", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaWidgetListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
