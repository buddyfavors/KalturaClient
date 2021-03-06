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

	public class KalturaPartnerService : KalturaServiceBase
	{
	public KalturaPartnerService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPartner Register(KalturaPartner partner)
		{
			return this.Register(partner, "");
		}

		public KalturaPartner Register(KalturaPartner partner, string cmsPassword)
		{
			return this.Register(partner, cmsPassword, Int32.MinValue);
		}

		public KalturaPartner Register(KalturaPartner partner, string cmsPassword, int templatePartnerId)
		{
			return this.Register(partner, cmsPassword, templatePartnerId, false);
		}

		public KalturaPartner Register(KalturaPartner partner, string cmsPassword, int templatePartnerId, bool silent)
		{
			KalturaParams kparams = new KalturaParams();
			if (partner != null)
				kparams.Add("partner", partner.ToParams());
			kparams.AddStringIfNotNull("cmsPassword", cmsPassword);
			kparams.AddIntIfNotNull("templatePartnerId", templatePartnerId);
			kparams.AddBoolIfNotNull("silent", silent);
			_Client.QueueServiceCall("partner", "register", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result);
		}

		public KalturaPartner Update(KalturaPartner partner)
		{
			return this.Update(partner, false);
		}

		public KalturaPartner Update(KalturaPartner partner, bool allowEmpty)
		{
			KalturaParams kparams = new KalturaParams();
			if (partner != null)
				kparams.Add("partner", partner.ToParams());
			kparams.AddBoolIfNotNull("allowEmpty", allowEmpty);
			_Client.QueueServiceCall("partner", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result);
		}

		public KalturaPartner Get()
		{
			return this.Get(Int32.MinValue);
		}

		public KalturaPartner Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("partner", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result);
		}

		public KalturaPartner GetSecrets(int partnerId, string adminEmail, string cmsPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddStringIfNotNull("adminEmail", adminEmail);
			kparams.AddStringIfNotNull("cmsPassword", cmsPassword);
			_Client.QueueServiceCall("partner", "getSecrets", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result);
		}

		public KalturaPartner GetInfo()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("partner", "getInfo", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result);
		}

		public KalturaPartnerUsage GetUsage()
		{
			return this.GetUsage();
		}

		public KalturaPartnerUsage GetUsage(int year)
		{
			return this.GetUsage(year, 1);
		}

		public KalturaPartnerUsage GetUsage(int year, int month)
		{
			return this.GetUsage(year, month, null);
		}

		public KalturaPartnerUsage GetUsage(int year, int month, KalturaReportInterval resolution)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("year", year);
			kparams.AddIntIfNotNull("month", month);
			kparams.AddStringEnumIfNotNull("resolution", resolution);
			_Client.QueueServiceCall("partner", "getUsage", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerUsage)KalturaObjectFactory.Create(result);
		}

		public KalturaPartnerStatistics GetStatistics()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("partner", "getStatistics", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerStatistics)KalturaObjectFactory.Create(result);
		}

		public KalturaPartnerListResponse ListPartnersForUser()
		{
			return this.ListPartnersForUser(null);
		}

		public KalturaPartnerListResponse ListPartnersForUser(KalturaPartnerFilter partnerFilter)
		{
			return this.ListPartnersForUser(partnerFilter, null);
		}

		public KalturaPartnerListResponse ListPartnersForUser(KalturaPartnerFilter partnerFilter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (partnerFilter != null)
				kparams.Add("partnerFilter", partnerFilter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("partner", "listPartnersForUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaPartnerListResponse List()
		{
			return this.List(null);
		}

		public KalturaPartnerListResponse List(KalturaPartnerFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaPartnerListResponse List(KalturaPartnerFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("partner", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaFeatureStatusListResponse ListFeatureStatus()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("partner", "listFeatureStatus", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFeatureStatusListResponse)KalturaObjectFactory.Create(result);
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaPartnerFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("partner", "count", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}
	}
}
