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

	public class KalturaPermissionItemService : KalturaServiceBase
	{
	public KalturaPermissionItemService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPermissionItem Add(KalturaPermissionItem permissionItem)
		{
			KalturaParams kparams = new KalturaParams();
			if (permissionItem != null)
				kparams.Add("permissionItem", permissionItem.ToParams());
			_Client.QueueServiceCall("permissionitem", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItem)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionItem Get(int permissionItemId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("permissionItemId", permissionItemId);
			_Client.QueueServiceCall("permissionitem", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItem)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionItem Update(int permissionItemId, KalturaPermissionItem permissionItem)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("permissionItemId", permissionItemId);
			if (permissionItem != null)
				kparams.Add("permissionItem", permissionItem.ToParams());
			_Client.QueueServiceCall("permissionitem", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItem)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionItem Delete(int permissionItemId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("permissionItemId", permissionItemId);
			_Client.QueueServiceCall("permissionitem", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItem)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionItemListResponse List()
		{
			return this.List(null);
		}

		public KalturaPermissionItemListResponse List(KalturaPermissionItemFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaPermissionItemListResponse List(KalturaPermissionItemFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("permissionitem", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItemListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
