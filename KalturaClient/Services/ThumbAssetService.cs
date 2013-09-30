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

	public class KalturaThumbAssetService : KalturaServiceBase
	{
	public KalturaThumbAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaThumbAsset Add(string entryId, KalturaThumbAsset thumbAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (thumbAsset != null)
				kparams.Add("thumbAsset", thumbAsset.ToParams());
			_Client.QueueServiceCall("thumbasset", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (contentResource != null)
				kparams.Add("contentResource", contentResource.ToParams());
			_Client.QueueServiceCall("thumbasset", "setContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbAsset Update(string id, KalturaThumbAsset thumbAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (thumbAsset != null)
				kparams.Add("thumbAsset", thumbAsset.ToParams());
			_Client.QueueServiceCall("thumbasset", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public void SetAsDefault(string thumbAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("thumbAssetId", thumbAssetId);
			_Client.QueueServiceCall("thumbasset", "setAsDefault", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaThumbAsset GenerateByEntryId(string entryId, int destThumbParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("destThumbParamsId", destThumbParamsId);
			_Client.QueueServiceCall("thumbasset", "generateByEntryId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbAsset Generate(string entryId, KalturaThumbParams thumbParams)
		{
			return this.Generate(entryId, thumbParams, null);
		}

		public KalturaThumbAsset Generate(string entryId, KalturaThumbParams thumbParams, string sourceAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (thumbParams != null)
				kparams.Add("thumbParams", thumbParams.ToParams());
			kparams.AddStringIfNotNull("sourceAssetId", sourceAssetId);
			_Client.QueueServiceCall("thumbasset", "generate", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbAsset Regenerate(string thumbAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("thumbAssetId", thumbAssetId);
			_Client.QueueServiceCall("thumbasset", "regenerate", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbAsset Get(string thumbAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("thumbAssetId", thumbAssetId);
			_Client.QueueServiceCall("thumbasset", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaThumbAsset> GetByEntryId(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("thumbasset", "getByEntryId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaThumbAsset> list = new List<KalturaThumbAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaThumbAsset)KalturaObjectFactory.Create(node));
			}
			return list;
		}

		public KalturaThumbAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaThumbAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaThumbAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("thumbasset", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAssetListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbAsset AddFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("thumbasset", "addFromUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbAsset AddFromImage(string entryId, FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("thumbasset", "addFromImage", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result);
		}

		public void Delete(string thumbAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("thumbAssetId", thumbAssetId);
			_Client.QueueServiceCall("thumbasset", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string GetUrl(string id)
		{
			return this.GetUrl(id, Int32.MinValue);
		}

		public string GetUrl(string id, int storageId)
		{
			return this.GetUrl(id, storageId, null);
		}

		public string GetUrl(string id, int storageId, KalturaThumbParams thumbParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddIntIfNotNull("storageId", storageId);
			if (thumbParams != null)
				kparams.Add("thumbParams", thumbParams.ToParams());
			_Client.QueueServiceCall("thumbasset", "getUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("thumbasset", "getRemotePaths", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
