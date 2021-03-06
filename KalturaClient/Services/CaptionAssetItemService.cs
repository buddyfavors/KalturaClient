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

	public class KalturaCaptionAssetItemService : KalturaServiceBase
	{
	public KalturaCaptionAssetItemService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCaptionAssetItemListResponse Search()
		{
			return this.Search(null);
		}

		public KalturaCaptionAssetItemListResponse Search(KalturaBaseEntryFilter entryFilter)
		{
			return this.Search(entryFilter, null);
		}

		public KalturaCaptionAssetItemListResponse Search(KalturaBaseEntryFilter entryFilter, KalturaCaptionAssetItemFilter captionAssetItemFilter)
		{
			return this.Search(entryFilter, captionAssetItemFilter, null);
		}

		public KalturaCaptionAssetItemListResponse Search(KalturaBaseEntryFilter entryFilter, KalturaCaptionAssetItemFilter captionAssetItemFilter, KalturaFilterPager captionAssetItemPager)
		{
			KalturaParams kparams = new KalturaParams();
			if (entryFilter != null)
				kparams.Add("entryFilter", entryFilter.ToParams());
			if (captionAssetItemFilter != null)
				kparams.Add("captionAssetItemFilter", captionAssetItemFilter.ToParams());
			if (captionAssetItemPager != null)
				kparams.Add("captionAssetItemPager", captionAssetItemPager.ToParams());
			_Client.QueueServiceCall("captionsearch_captionassetitem", "search", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAssetItemListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntryListResponse SearchEntries()
		{
			return this.SearchEntries(null);
		}

		public KalturaBaseEntryListResponse SearchEntries(KalturaBaseEntryFilter entryFilter)
		{
			return this.SearchEntries(entryFilter, null);
		}

		public KalturaBaseEntryListResponse SearchEntries(KalturaBaseEntryFilter entryFilter, KalturaCaptionAssetItemFilter captionAssetItemFilter)
		{
			return this.SearchEntries(entryFilter, captionAssetItemFilter, null);
		}

		public KalturaBaseEntryListResponse SearchEntries(KalturaBaseEntryFilter entryFilter, KalturaCaptionAssetItemFilter captionAssetItemFilter, KalturaFilterPager captionAssetItemPager)
		{
			KalturaParams kparams = new KalturaParams();
			if (entryFilter != null)
				kparams.Add("entryFilter", entryFilter.ToParams());
			if (captionAssetItemFilter != null)
				kparams.Add("captionAssetItemFilter", captionAssetItemFilter.ToParams());
			if (captionAssetItemPager != null)
				kparams.Add("captionAssetItemPager", captionAssetItemPager.ToParams());
			_Client.QueueServiceCall("captionsearch_captionassetitem", "searchEntries", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntryListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
