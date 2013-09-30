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

	public class KalturaEntryDistributionService : KalturaServiceBase
	{
	public KalturaEntryDistributionService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaEntryDistribution Add(KalturaEntryDistribution entryDistribution)
		{
			KalturaParams kparams = new KalturaParams();
			if (entryDistribution != null)
				kparams.Add("entryDistribution", entryDistribution.ToParams());
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution Validate(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "validate", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution Update(int id, KalturaEntryDistribution entryDistribution)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (entryDistribution != null)
				kparams.Add("entryDistribution", entryDistribution.ToParams());
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaEntryDistributionListResponse List()
		{
			return this.List(null);
		}

		public KalturaEntryDistributionListResponse List(KalturaEntryDistributionFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaEntryDistributionListResponse List(KalturaEntryDistributionFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistributionListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution SubmitAdd(int id)
		{
			return this.SubmitAdd(id, false);
		}

		public KalturaEntryDistribution SubmitAdd(int id, bool submitWhenReady)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddBoolIfNotNull("submitWhenReady", submitWhenReady);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "submitAdd", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution SubmitUpdate(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "submitUpdate", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution SubmitFetchReport(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "submitFetchReport", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution SubmitDelete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "submitDelete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution RetrySubmit(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "retrySubmit", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}
	}
}
