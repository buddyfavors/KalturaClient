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

namespace Kaltura
{
	public class KalturaDropFolderFile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _DropFolderId = Int32.MinValue;
		private string _FileName = null;
		private float _FileSize = Single.MinValue;
		private int _FileSizeLastSetAt = Int32.MinValue;
		private KalturaDropFolderFileStatus _Status = (KalturaDropFolderFileStatus)Int32.MinValue;
		private string _ParsedSlug = null;
		private string _ParsedFlavor = null;
		private int _LeadDropFolderFileId = Int32.MinValue;
		private int _DeletedDropFolderFileId = Int32.MinValue;
		private string _EntryId = null;
		private KalturaDropFolderFileErrorCode _ErrorCode = null;
		private string _ErrorDescription = null;
		private string _LastModificationTime = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _UploadStartDetectedAt = Int32.MinValue;
		private int _UploadEndDetectedAt = Int32.MinValue;
		private int _ImportStartedAt = Int32.MinValue;
		private int _ImportEndedAt = Int32.MinValue;
		private int _BatchJobId = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public int DropFolderId
		{
			get { return _DropFolderId; }
			set 
			{ 
				_DropFolderId = value;
				OnPropertyChanged("DropFolderId");
			}
		}
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		public float FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		public int FileSizeLastSetAt
		{
			get { return _FileSizeLastSetAt; }
			set 
			{ 
				_FileSizeLastSetAt = value;
				OnPropertyChanged("FileSizeLastSetAt");
			}
		}
		public KalturaDropFolderFileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string ParsedSlug
		{
			get { return _ParsedSlug; }
			set 
			{ 
				_ParsedSlug = value;
				OnPropertyChanged("ParsedSlug");
			}
		}
		public string ParsedFlavor
		{
			get { return _ParsedFlavor; }
			set 
			{ 
				_ParsedFlavor = value;
				OnPropertyChanged("ParsedFlavor");
			}
		}
		public int LeadDropFolderFileId
		{
			get { return _LeadDropFolderFileId; }
			set 
			{ 
				_LeadDropFolderFileId = value;
				OnPropertyChanged("LeadDropFolderFileId");
			}
		}
		public int DeletedDropFolderFileId
		{
			get { return _DeletedDropFolderFileId; }
			set 
			{ 
				_DeletedDropFolderFileId = value;
				OnPropertyChanged("DeletedDropFolderFileId");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public KalturaDropFolderFileErrorCode ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		public string LastModificationTime
		{
			get { return _LastModificationTime; }
			set 
			{ 
				_LastModificationTime = value;
				OnPropertyChanged("LastModificationTime");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		public int UploadStartDetectedAt
		{
			get { return _UploadStartDetectedAt; }
			set 
			{ 
				_UploadStartDetectedAt = value;
				OnPropertyChanged("UploadStartDetectedAt");
			}
		}
		public int UploadEndDetectedAt
		{
			get { return _UploadEndDetectedAt; }
			set 
			{ 
				_UploadEndDetectedAt = value;
				OnPropertyChanged("UploadEndDetectedAt");
			}
		}
		public int ImportStartedAt
		{
			get { return _ImportStartedAt; }
			set 
			{ 
				_ImportStartedAt = value;
				OnPropertyChanged("ImportStartedAt");
			}
		}
		public int ImportEndedAt
		{
			get { return _ImportEndedAt; }
			set 
			{ 
				_ImportEndedAt = value;
				OnPropertyChanged("ImportEndedAt");
			}
		}
		public int BatchJobId
		{
			get { return _BatchJobId; }
			set 
			{ 
				_BatchJobId = value;
				OnPropertyChanged("BatchJobId");
			}
		}
		#endregion

		#region CTor
		public KalturaDropFolderFile()
		{
		}

		public KalturaDropFolderFile(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "dropFolderId":
						this.DropFolderId = ParseInt(txt);
						continue;
					case "fileName":
						this.FileName = txt;
						continue;
					case "fileSize":
						this.FileSize = ParseFloat(txt);
						continue;
					case "fileSizeLastSetAt":
						this.FileSizeLastSetAt = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaDropFolderFileStatus)ParseEnum(typeof(KalturaDropFolderFileStatus), txt);
						continue;
					case "parsedSlug":
						this.ParsedSlug = txt;
						continue;
					case "parsedFlavor":
						this.ParsedFlavor = txt;
						continue;
					case "leadDropFolderFileId":
						this.LeadDropFolderFileId = ParseInt(txt);
						continue;
					case "deletedDropFolderFileId":
						this.DeletedDropFolderFileId = ParseInt(txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "errorCode":
						this.ErrorCode = (KalturaDropFolderFileErrorCode)KalturaStringEnum.Parse(typeof(KalturaDropFolderFileErrorCode), txt);
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
					case "lastModificationTime":
						this.LastModificationTime = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "uploadStartDetectedAt":
						this.UploadStartDetectedAt = ParseInt(txt);
						continue;
					case "uploadEndDetectedAt":
						this.UploadEndDetectedAt = ParseInt(txt);
						continue;
					case "importStartedAt":
						this.ImportStartedAt = ParseInt(txt);
						continue;
					case "importEndedAt":
						this.ImportEndedAt = ParseInt(txt);
						continue;
					case "batchJobId":
						this.BatchJobId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDropFolderFile");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddIntIfNotNull("dropFolderId", this.DropFolderId);
			kparams.AddStringIfNotNull("fileName", this.FileName);
			kparams.AddFloatIfNotNull("fileSize", this.FileSize);
			kparams.AddIntIfNotNull("fileSizeLastSetAt", this.FileSizeLastSetAt);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("parsedSlug", this.ParsedSlug);
			kparams.AddStringIfNotNull("parsedFlavor", this.ParsedFlavor);
			kparams.AddIntIfNotNull("leadDropFolderFileId", this.LeadDropFolderFileId);
			kparams.AddIntIfNotNull("deletedDropFolderFileId", this.DeletedDropFolderFileId);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddStringEnumIfNotNull("errorCode", this.ErrorCode);
			kparams.AddStringIfNotNull("errorDescription", this.ErrorDescription);
			kparams.AddStringIfNotNull("lastModificationTime", this.LastModificationTime);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIntIfNotNull("uploadStartDetectedAt", this.UploadStartDetectedAt);
			kparams.AddIntIfNotNull("uploadEndDetectedAt", this.UploadEndDetectedAt);
			kparams.AddIntIfNotNull("importStartedAt", this.ImportStartedAt);
			kparams.AddIntIfNotNull("importEndedAt", this.ImportEndedAt);
			kparams.AddIntIfNotNull("batchJobId", this.BatchJobId);
			return kparams;
		}
		#endregion
	}
}

