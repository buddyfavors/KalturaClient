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

	public class KalturaUserService : KalturaServiceBase
	{
	public KalturaUserService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUser Add(KalturaUser user)
		{
			KalturaParams kparams = new KalturaParams();
			if (user != null)
				kparams.Add("user", user.ToParams());
			_Client.QueueServiceCall("user", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser Update(string userId, KalturaUser user)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			if (user != null)
				kparams.Add("user", user.ToParams());
			_Client.QueueServiceCall("user", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser Get()
		{
			return this.Get(null);
		}

		public KalturaUser Get(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser GetByLoginId(string loginId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("loginId", loginId);
			_Client.QueueServiceCall("user", "getByLoginId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser Delete(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUserListResponse List()
		{
			return this.List(null);
		}

		public KalturaUserListResponse List(KalturaUserFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUserListResponse List(KalturaUserFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("user", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserListResponse)KalturaObjectFactory.Create(result);
		}

		public void NotifyBan(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "notifyBan", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string Login(int partnerId, string userId, string password)
		{
			return this.Login(partnerId, userId, password, 86400);
		}

		public string Login(int partnerId, string userId, string password, int expiry)
		{
			return this.Login(partnerId, userId, password, expiry, "*");
		}

		public string Login(int partnerId, string userId, string password, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddStringIfNotNull("password", password);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("user", "login", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public string LoginByLoginId(string loginId, string password)
		{
			return this.LoginByLoginId(loginId, password, Int32.MinValue);
		}

		public string LoginByLoginId(string loginId, string password, int partnerId)
		{
			return this.LoginByLoginId(loginId, password, partnerId, 86400);
		}

		public string LoginByLoginId(string loginId, string password, int partnerId, int expiry)
		{
			return this.LoginByLoginId(loginId, password, partnerId, expiry, "*");
		}

		public string LoginByLoginId(string loginId, string password, int partnerId, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("loginId", loginId);
			kparams.AddStringIfNotNull("password", password);
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("user", "loginByLoginId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public void UpdateLoginData(string oldLoginId, string password)
		{
			this.UpdateLoginData(oldLoginId, password, "");
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, "");
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, newPassword, null);
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword, string newFirstName)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, newPassword, newFirstName, null);
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword, string newFirstName, string newLastName)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("oldLoginId", oldLoginId);
			kparams.AddStringIfNotNull("password", password);
			kparams.AddStringIfNotNull("newLoginId", newLoginId);
			kparams.AddStringIfNotNull("newPassword", newPassword);
			kparams.AddStringIfNotNull("newFirstName", newFirstName);
			kparams.AddStringIfNotNull("newLastName", newLastName);
			_Client.QueueServiceCall("user", "updateLoginData", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void ResetPassword(string email)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("email", email);
			_Client.QueueServiceCall("user", "resetPassword", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void SetInitialPassword(string hashKey, string newPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("hashKey", hashKey);
			kparams.AddStringIfNotNull("newPassword", newPassword);
			_Client.QueueServiceCall("user", "setInitialPassword", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUser EnableLogin(string userId, string loginId)
		{
			return this.EnableLogin(userId, loginId, null);
		}

		public KalturaUser EnableLogin(string userId, string loginId, string password)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddStringIfNotNull("loginId", loginId);
			kparams.AddStringIfNotNull("password", password);
			_Client.QueueServiceCall("user", "enableLogin", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser DisableLogin()
		{
			return this.DisableLogin(null);
		}

		public KalturaUser DisableLogin(string userId)
		{
			return this.DisableLogin(userId, null);
		}

		public KalturaUser DisableLogin(string userId, string loginId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddStringIfNotNull("loginId", loginId);
			_Client.QueueServiceCall("user", "disableLogin", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public string Index(string id)
		{
			return this.Index(id, true);
		}

		public string Index(string id, bool shouldUpdate)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddBoolIfNotNull("shouldUpdate", shouldUpdate);
			_Client.QueueServiceCall("user", "index", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaBulkUpload AddFromBulkUpload(FileStream fileData)
		{
			return this.AddFromBulkUpload(fileData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(FileStream fileData, KalturaBulkUploadJobData bulkUploadData)
		{
			return this.AddFromBulkUpload(fileData, bulkUploadData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(FileStream fileData, KalturaBulkUploadJobData bulkUploadData, KalturaBulkUploadUserData bulkUploadUserData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			if (bulkUploadData != null)
				kparams.Add("bulkUploadData", bulkUploadData.ToParams());
			if (bulkUploadUserData != null)
				kparams.Add("bulkUploadUserData", bulkUploadUserData.ToParams());
			_Client.QueueServiceCall("user", "addFromBulkUpload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result);
		}

		public bool CheckLoginDataExists(KalturaUserLoginDataFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("user", "checkLoginDataExists", kparams);
			if (this._Client.IsMultiRequest)
				return false;
			XmlElement result = _Client.DoQueue();
			if (result.InnerText == "1")
				return true;
			return false;
		}
	}
}
