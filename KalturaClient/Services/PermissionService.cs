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

	public class KalturaPermissionService : KalturaServiceBase
	{
	public KalturaPermissionService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPermission Add(KalturaPermission permission)
		{
			KalturaParams kparams = new KalturaParams();
			if (permission != null)
				kparams.Add("permission", permission.ToParams());
			_Client.QueueServiceCall("permission", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermission)KalturaObjectFactory.Create(result);
		}

		public KalturaPermission Get(string permissionName)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("permissionName", permissionName);
			_Client.QueueServiceCall("permission", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermission)KalturaObjectFactory.Create(result);
		}

		public KalturaPermission Update(string permissionName, KalturaPermission permission)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("permissionName", permissionName);
			if (permission != null)
				kparams.Add("permission", permission.ToParams());
			_Client.QueueServiceCall("permission", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermission)KalturaObjectFactory.Create(result);
		}

		public KalturaPermission Delete(string permissionName)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("permissionName", permissionName);
			_Client.QueueServiceCall("permission", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermission)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionListResponse List()
		{
			return this.List(null);
		}

		public KalturaPermissionListResponse List(KalturaPermissionFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaPermissionListResponse List(KalturaPermissionFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("permission", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionListResponse)KalturaObjectFactory.Create(result);
		}

		public string GetCurrentPermissions()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("permission", "getCurrentPermissions", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
