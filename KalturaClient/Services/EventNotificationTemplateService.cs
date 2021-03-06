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

	public class KalturaEventNotificationTemplateService : KalturaServiceBase
	{
	public KalturaEventNotificationTemplateService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaEventNotificationTemplate Add(KalturaEventNotificationTemplate eventNotificationTemplate)
		{
			KalturaParams kparams = new KalturaParams();
			if (eventNotificationTemplate != null)
				kparams.Add("eventNotificationTemplate", eventNotificationTemplate.ToParams());
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEventNotificationTemplate)KalturaObjectFactory.Create(result);
		}

		public KalturaEventNotificationTemplate Clone(int id)
		{
			return this.Clone(id, null);
		}

		public KalturaEventNotificationTemplate Clone(int id, KalturaEventNotificationTemplate eventNotificationTemplate)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (eventNotificationTemplate != null)
				kparams.Add("eventNotificationTemplate", eventNotificationTemplate.ToParams());
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "clone", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEventNotificationTemplate)KalturaObjectFactory.Create(result);
		}

		public KalturaEventNotificationTemplate Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEventNotificationTemplate)KalturaObjectFactory.Create(result);
		}

		public KalturaEventNotificationTemplate Update(int id, KalturaEventNotificationTemplate eventNotificationTemplate)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (eventNotificationTemplate != null)
				kparams.Add("eventNotificationTemplate", eventNotificationTemplate.ToParams());
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEventNotificationTemplate)KalturaObjectFactory.Create(result);
		}

		public KalturaEventNotificationTemplate UpdateStatus(int id, KalturaEventNotificationTemplateStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddEnumIfNotNull("status", status);
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "updateStatus", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEventNotificationTemplate)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaEventNotificationTemplateListResponse List()
		{
			return this.List(null);
		}

		public KalturaEventNotificationTemplateListResponse List(KalturaEventNotificationTemplateFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaEventNotificationTemplateListResponse List(KalturaEventNotificationTemplateFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEventNotificationTemplateListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaEventNotificationTemplateListResponse ListByPartner()
		{
			return this.ListByPartner(null);
		}

		public KalturaEventNotificationTemplateListResponse ListByPartner(KalturaPartnerFilter filter)
		{
			return this.ListByPartner(filter, null);
		}

		public KalturaEventNotificationTemplateListResponse ListByPartner(KalturaPartnerFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "listByPartner", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEventNotificationTemplateListResponse)KalturaObjectFactory.Create(result);
		}

		public int Dispatch(int id, KalturaEventNotificationDispatchJobData data)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (data != null)
				kparams.Add("data", data.ToParams());
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "dispatch", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaEventNotificationTemplateListResponse ListTemplates()
		{
			return this.ListTemplates(null);
		}

		public KalturaEventNotificationTemplateListResponse ListTemplates(KalturaEventNotificationTemplateFilter filter)
		{
			return this.ListTemplates(filter, null);
		}

		public KalturaEventNotificationTemplateListResponse ListTemplates(KalturaEventNotificationTemplateFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("eventnotification_eventnotificationtemplate", "listTemplates", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEventNotificationTemplateListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
