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

	public class KalturaFlavorAssetService : KalturaServiceBase
	{
	public KalturaFlavorAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaFlavorAsset Add(string entryId, KalturaFlavorAsset flavorAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (flavorAsset != null)
				kparams.Add("flavorAsset", flavorAsset.ToParams());
			_Client.QueueServiceCall("flavorasset", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaFlavorAsset Update(string id, KalturaFlavorAsset flavorAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (flavorAsset != null)
				kparams.Add("flavorAsset", flavorAsset.ToParams());
			_Client.QueueServiceCall("flavorasset", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaFlavorAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (contentResource != null)
				kparams.Add("contentResource", contentResource.ToParams());
			_Client.QueueServiceCall("flavorasset", "setContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaFlavorAsset Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaFlavorAsset> GetByEntryId(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getByEntryId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAsset> list = new List<KalturaFlavorAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(node));
			}
			return list;
		}

		public KalturaFlavorAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaFlavorAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaFlavorAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("flavorasset", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAssetListResponse)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaFlavorAsset> GetWebPlayableByEntryId(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getWebPlayableByEntryId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAsset> list = new List<KalturaFlavorAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(node));
			}
			return list;
		}

		public void Convert(string entryId, int flavorParamsId)
		{
			this.Convert(entryId, flavorParamsId, 0);
		}

		public void Convert(string entryId, int flavorParamsId, int priority)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("flavorParamsId", flavorParamsId);
			kparams.AddIntIfNotNull("priority", priority);
			_Client.QueueServiceCall("flavorasset", "convert", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Reconvert(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "reconvert", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "delete", kparams);
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
			return this.GetUrl(id, storageId, false);
		}

		public string GetUrl(string id, int storageId, bool forceProxy)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddIntIfNotNull("storageId", storageId);
			kparams.AddBoolIfNotNull("forceProxy", forceProxy);
			_Client.QueueServiceCall("flavorasset", "getUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "getRemotePaths", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result);
		}

		public string GetDownloadUrl(string id)
		{
			return this.GetDownloadUrl(id, false);
		}

		public string GetDownloadUrl(string id, bool useCdn)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddBoolIfNotNull("useCdn", useCdn);
			_Client.QueueServiceCall("flavorasset", "getDownloadUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public IList<KalturaFlavorAssetWithParams> GetFlavorAssetsWithParams(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getFlavorAssetsWithParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAssetWithParams> list = new List<KalturaFlavorAssetWithParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAssetWithParams)KalturaObjectFactory.Create(node));
			}
			return list;
		}

		public KalturaFlavorAsset Export(string assetId, int storageProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("assetId", assetId);
			kparams.AddIntIfNotNull("storageProfileId", storageProfileId);
			_Client.QueueServiceCall("flavorasset", "export", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public void SetAsSource(string assetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("assetId", assetId);
			_Client.QueueServiceCall("flavorasset", "setAsSource", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
