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

	public class KalturaStatsService : KalturaServiceBase
	{
	public KalturaStatsService(KalturaClient client)
			: base(client)
		{
		}

		public bool Collect(KalturaStatsEvent kevent)
		{
			KalturaParams kparams = new KalturaParams();
			if (kevent != null)
				kparams.Add("event", kevent.ToParams());
			_Client.QueueServiceCall("stats", "collect", kparams);
			if (this._Client.IsMultiRequest)
				return false;
			XmlElement result = _Client.DoQueue();
			if (result.InnerText == "1")
				return true;
			return false;
		}

		public void KmcCollect(KalturaStatsKmcEvent kmcEvent)
		{
			KalturaParams kparams = new KalturaParams();
			if (kmcEvent != null)
				kparams.Add("kmcEvent", kmcEvent.ToParams());
			_Client.QueueServiceCall("stats", "kmcCollect", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCEError ReportKceError(KalturaCEError kalturaCEError)
		{
			KalturaParams kparams = new KalturaParams();
			if (kalturaCEError != null)
				kparams.Add("kalturaCEError", kalturaCEError.ToParams());
			_Client.QueueServiceCall("stats", "reportKceError", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCEError)KalturaObjectFactory.Create(result);
		}

		public void ReportError(string errorCode, string errorMessage)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("errorCode", errorCode);
			kparams.AddStringIfNotNull("errorMessage", errorMessage);
			_Client.QueueServiceCall("stats", "reportError", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
