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

	public class KalturaGenericDistributionProviderActionService : KalturaServiceBase
	{
	public KalturaGenericDistributionProviderActionService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaGenericDistributionProviderAction Add(KalturaGenericDistributionProviderAction genericDistributionProviderAction)
		{
			KalturaParams kparams = new KalturaParams();
			if (genericDistributionProviderAction != null)
				kparams.Add("genericDistributionProviderAction", genericDistributionProviderAction.ToParams());
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction AddMrssTransform(int id, string xslData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddStringIfNotNull("xslData", xslData);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "addMrssTransform", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction AddMrssTransformFromFile(int id, FileStream xslFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xslFile", xslFile);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "addMrssTransformFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction AddMrssValidate(int id, string xsdData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddStringIfNotNull("xsdData", xsdData);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "addMrssValidate", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction AddMrssValidateFromFile(int id, FileStream xsdFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xsdFile", xsdFile);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "addMrssValidateFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction AddResultsTransform(int id, string transformData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddStringIfNotNull("transformData", transformData);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "addResultsTransform", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction AddResultsTransformFromFile(int id, FileStream transformFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("transformFile", transformFile);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "addResultsTransformFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction GetByProviderId(int genericDistributionProviderId, KalturaDistributionAction actionType)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("genericDistributionProviderId", genericDistributionProviderId);
			kparams.AddEnumIfNotNull("actionType", actionType);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "getByProviderId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction UpdateByProviderId(int genericDistributionProviderId, KalturaDistributionAction actionType, KalturaGenericDistributionProviderAction genericDistributionProviderAction)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("genericDistributionProviderId", genericDistributionProviderId);
			kparams.AddEnumIfNotNull("actionType", actionType);
			if (genericDistributionProviderAction != null)
				kparams.Add("genericDistributionProviderAction", genericDistributionProviderAction.ToParams());
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "updateByProviderId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProviderAction Update(int id, KalturaGenericDistributionProviderAction genericDistributionProviderAction)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (genericDistributionProviderAction != null)
				kparams.Add("genericDistributionProviderAction", genericDistributionProviderAction.ToParams());
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderAction)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void DeleteByProviderId(int genericDistributionProviderId, KalturaDistributionAction actionType)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("genericDistributionProviderId", genericDistributionProviderId);
			kparams.AddEnumIfNotNull("actionType", actionType);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "deleteByProviderId", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaGenericDistributionProviderActionListResponse List()
		{
			return this.List(null);
		}

		public KalturaGenericDistributionProviderActionListResponse List(KalturaGenericDistributionProviderActionFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaGenericDistributionProviderActionListResponse List(KalturaGenericDistributionProviderActionFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovideraction", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderActionListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
