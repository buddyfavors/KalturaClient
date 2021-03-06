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

	public class KalturaMetadataService : KalturaServiceBase
	{
	public KalturaMetadataService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaMetadata Add(int metadataProfileId, KalturaMetadataObjectType objectType, string objectId, string xmlData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			kparams.AddStringIfNotNull("xmlData", xmlData);
			_Client.QueueServiceCall("metadata_metadata", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata AddFromFile(int metadataProfileId, KalturaMetadataObjectType objectType, string objectId, FileStream xmlFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xmlFile", xmlFile);
			_Client.QueueServiceCall("metadata_metadata", "addFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata AddFromUrl(int metadataProfileId, KalturaMetadataObjectType objectType, string objectId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("metadata_metadata", "addFromUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata AddFromBulk(int metadataProfileId, KalturaMetadataObjectType objectType, string objectId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("metadata_metadata", "addFromBulk", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadata", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata Update(int id)
		{
			return this.Update(id, null);
		}

		public KalturaMetadata Update(int id, string xmlData)
		{
			return this.Update(id, xmlData, Int32.MinValue);
		}

		public KalturaMetadata Update(int id, string xmlData, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddStringIfNotNull("xmlData", xmlData);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("metadata_metadata", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata UpdateFromFile(int id)
		{
			return this.UpdateFromFile(id, null);
		}

		public KalturaMetadata UpdateFromFile(int id, FileStream xmlFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xmlFile", xmlFile);
			_Client.QueueServiceCall("metadata_metadata", "updateFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadataListResponse List()
		{
			return this.List(null);
		}

		public KalturaMetadataListResponse List(KalturaMetadataFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaMetadataListResponse List(KalturaMetadataFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("metadata_metadata", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataListResponse)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadata", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Invalidate(int id)
		{
			this.Invalidate(id, Int32.MinValue);
		}

		public void Invalidate(int id, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("metadata_metadata", "invalidate", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMetadata UpdateFromXSL(int id, FileStream xslFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xslFile", xslFile);
			_Client.QueueServiceCall("metadata_metadata", "updateFromXSL", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}
	}
}
