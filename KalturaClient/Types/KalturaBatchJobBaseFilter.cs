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
	public class KalturaBatchJobBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private int _IdGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _PartnerIdNotIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _LockExpirationGreaterThanOrEqual = Int32.MinValue;
		private int _LockExpirationLessThanOrEqual = Int32.MinValue;
		private int _ExecutionAttemptsGreaterThanOrEqual = Int32.MinValue;
		private int _ExecutionAttemptsLessThanOrEqual = Int32.MinValue;
		private int _LockVersionGreaterThanOrEqual = Int32.MinValue;
		private int _LockVersionLessThanOrEqual = Int32.MinValue;
		private string _EntryIdEqual = null;
		private KalturaBatchJobType _JobTypeEqual = null;
		private string _JobTypeIn = null;
		private string _JobTypeNotIn = null;
		private int _JobSubTypeEqual = Int32.MinValue;
		private string _JobSubTypeIn = null;
		private string _JobSubTypeNotIn = null;
		private KalturaBatchJobStatus _StatusEqual = (KalturaBatchJobStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		private int _AbortEqual = Int32.MinValue;
		private int _CheckAgainTimeoutGreaterThanOrEqual = Int32.MinValue;
		private int _CheckAgainTimeoutLessThanOrEqual = Int32.MinValue;
		private int _PriorityGreaterThanOrEqual = Int32.MinValue;
		private int _PriorityLessThanOrEqual = Int32.MinValue;
		private int _PriorityEqual = Int32.MinValue;
		private string _PriorityIn = null;
		private string _PriorityNotIn = null;
		private int _BulkJobIdEqual = Int32.MinValue;
		private string _BulkJobIdIn = null;
		private string _BulkJobIdNotIn = null;
		private int _BatchVersionGreaterThanOrEqual = Int32.MinValue;
		private int _BatchVersionLessThanOrEqual = Int32.MinValue;
		private int _BatchVersionEqual = Int32.MinValue;
		private int _ParentJobIdEqual = Int32.MinValue;
		private string _ParentJobIdIn = null;
		private string _ParentJobIdNotIn = null;
		private int _RootJobIdEqual = Int32.MinValue;
		private string _RootJobIdIn = null;
		private string _RootJobIdNotIn = null;
		private int _QueueTimeGreaterThanOrEqual = Int32.MinValue;
		private int _QueueTimeLessThanOrEqual = Int32.MinValue;
		private int _FinishTimeGreaterThanOrEqual = Int32.MinValue;
		private int _FinishTimeLessThanOrEqual = Int32.MinValue;
		private KalturaBatchJobErrorTypes _ErrTypeEqual = (KalturaBatchJobErrorTypes)Int32.MinValue;
		private string _ErrTypeIn = null;
		private string _ErrTypeNotIn = null;
		private int _ErrNumberEqual = Int32.MinValue;
		private string _ErrNumberIn = null;
		private string _ErrNumberNotIn = null;
		private int _EstimatedEffortLessThan = Int32.MinValue;
		private int _EstimatedEffortGreaterThan = Int32.MinValue;
		private int _UrgencyLessThanOrEqual = Int32.MinValue;
		private int _UrgencyGreaterThanOrEqual = Int32.MinValue;
		private int _SchedulerIdEqual = Int32.MinValue;
		private string _SchedulerIdIn = null;
		private string _SchedulerIdNotIn = null;
		private int _WorkerIdEqual = Int32.MinValue;
		private string _WorkerIdIn = null;
		private string _WorkerIdNotIn = null;
		private int _BatchIndexEqual = Int32.MinValue;
		private string _BatchIndexIn = null;
		private string _BatchIndexNotIn = null;
		private int _LastSchedulerIdEqual = Int32.MinValue;
		private string _LastSchedulerIdIn = null;
		private string _LastSchedulerIdNotIn = null;
		private int _LastWorkerIdEqual = Int32.MinValue;
		private string _LastWorkerIdIn = null;
		private string _LastWorkerIdNotIn = null;
		private int _DcEqual = Int32.MinValue;
		private string _DcIn = null;
		private string _DcNotIn = null;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public int IdGreaterThanOrEqual
		{
			get { return _IdGreaterThanOrEqual; }
			set 
			{ 
				_IdGreaterThanOrEqual = value;
				OnPropertyChanged("IdGreaterThanOrEqual");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string PartnerIdNotIn
		{
			get { return _PartnerIdNotIn; }
			set 
			{ 
				_PartnerIdNotIn = value;
				OnPropertyChanged("PartnerIdNotIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int LockExpirationGreaterThanOrEqual
		{
			get { return _LockExpirationGreaterThanOrEqual; }
			set 
			{ 
				_LockExpirationGreaterThanOrEqual = value;
				OnPropertyChanged("LockExpirationGreaterThanOrEqual");
			}
		}
		public int LockExpirationLessThanOrEqual
		{
			get { return _LockExpirationLessThanOrEqual; }
			set 
			{ 
				_LockExpirationLessThanOrEqual = value;
				OnPropertyChanged("LockExpirationLessThanOrEqual");
			}
		}
		public int ExecutionAttemptsGreaterThanOrEqual
		{
			get { return _ExecutionAttemptsGreaterThanOrEqual; }
			set 
			{ 
				_ExecutionAttemptsGreaterThanOrEqual = value;
				OnPropertyChanged("ExecutionAttemptsGreaterThanOrEqual");
			}
		}
		public int ExecutionAttemptsLessThanOrEqual
		{
			get { return _ExecutionAttemptsLessThanOrEqual; }
			set 
			{ 
				_ExecutionAttemptsLessThanOrEqual = value;
				OnPropertyChanged("ExecutionAttemptsLessThanOrEqual");
			}
		}
		public int LockVersionGreaterThanOrEqual
		{
			get { return _LockVersionGreaterThanOrEqual; }
			set 
			{ 
				_LockVersionGreaterThanOrEqual = value;
				OnPropertyChanged("LockVersionGreaterThanOrEqual");
			}
		}
		public int LockVersionLessThanOrEqual
		{
			get { return _LockVersionLessThanOrEqual; }
			set 
			{ 
				_LockVersionLessThanOrEqual = value;
				OnPropertyChanged("LockVersionLessThanOrEqual");
			}
		}
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		public KalturaBatchJobType JobTypeEqual
		{
			get { return _JobTypeEqual; }
			set 
			{ 
				_JobTypeEqual = value;
				OnPropertyChanged("JobTypeEqual");
			}
		}
		public string JobTypeIn
		{
			get { return _JobTypeIn; }
			set 
			{ 
				_JobTypeIn = value;
				OnPropertyChanged("JobTypeIn");
			}
		}
		public string JobTypeNotIn
		{
			get { return _JobTypeNotIn; }
			set 
			{ 
				_JobTypeNotIn = value;
				OnPropertyChanged("JobTypeNotIn");
			}
		}
		public int JobSubTypeEqual
		{
			get { return _JobSubTypeEqual; }
			set 
			{ 
				_JobSubTypeEqual = value;
				OnPropertyChanged("JobSubTypeEqual");
			}
		}
		public string JobSubTypeIn
		{
			get { return _JobSubTypeIn; }
			set 
			{ 
				_JobSubTypeIn = value;
				OnPropertyChanged("JobSubTypeIn");
			}
		}
		public string JobSubTypeNotIn
		{
			get { return _JobSubTypeNotIn; }
			set 
			{ 
				_JobSubTypeNotIn = value;
				OnPropertyChanged("JobSubTypeNotIn");
			}
		}
		public KalturaBatchJobStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		public int AbortEqual
		{
			get { return _AbortEqual; }
			set 
			{ 
				_AbortEqual = value;
				OnPropertyChanged("AbortEqual");
			}
		}
		public int CheckAgainTimeoutGreaterThanOrEqual
		{
			get { return _CheckAgainTimeoutGreaterThanOrEqual; }
			set 
			{ 
				_CheckAgainTimeoutGreaterThanOrEqual = value;
				OnPropertyChanged("CheckAgainTimeoutGreaterThanOrEqual");
			}
		}
		public int CheckAgainTimeoutLessThanOrEqual
		{
			get { return _CheckAgainTimeoutLessThanOrEqual; }
			set 
			{ 
				_CheckAgainTimeoutLessThanOrEqual = value;
				OnPropertyChanged("CheckAgainTimeoutLessThanOrEqual");
			}
		}
		public int PriorityGreaterThanOrEqual
		{
			get { return _PriorityGreaterThanOrEqual; }
			set 
			{ 
				_PriorityGreaterThanOrEqual = value;
				OnPropertyChanged("PriorityGreaterThanOrEqual");
			}
		}
		public int PriorityLessThanOrEqual
		{
			get { return _PriorityLessThanOrEqual; }
			set 
			{ 
				_PriorityLessThanOrEqual = value;
				OnPropertyChanged("PriorityLessThanOrEqual");
			}
		}
		public int PriorityEqual
		{
			get { return _PriorityEqual; }
			set 
			{ 
				_PriorityEqual = value;
				OnPropertyChanged("PriorityEqual");
			}
		}
		public string PriorityIn
		{
			get { return _PriorityIn; }
			set 
			{ 
				_PriorityIn = value;
				OnPropertyChanged("PriorityIn");
			}
		}
		public string PriorityNotIn
		{
			get { return _PriorityNotIn; }
			set 
			{ 
				_PriorityNotIn = value;
				OnPropertyChanged("PriorityNotIn");
			}
		}
		public int BulkJobIdEqual
		{
			get { return _BulkJobIdEqual; }
			set 
			{ 
				_BulkJobIdEqual = value;
				OnPropertyChanged("BulkJobIdEqual");
			}
		}
		public string BulkJobIdIn
		{
			get { return _BulkJobIdIn; }
			set 
			{ 
				_BulkJobIdIn = value;
				OnPropertyChanged("BulkJobIdIn");
			}
		}
		public string BulkJobIdNotIn
		{
			get { return _BulkJobIdNotIn; }
			set 
			{ 
				_BulkJobIdNotIn = value;
				OnPropertyChanged("BulkJobIdNotIn");
			}
		}
		public int BatchVersionGreaterThanOrEqual
		{
			get { return _BatchVersionGreaterThanOrEqual; }
			set 
			{ 
				_BatchVersionGreaterThanOrEqual = value;
				OnPropertyChanged("BatchVersionGreaterThanOrEqual");
			}
		}
		public int BatchVersionLessThanOrEqual
		{
			get { return _BatchVersionLessThanOrEqual; }
			set 
			{ 
				_BatchVersionLessThanOrEqual = value;
				OnPropertyChanged("BatchVersionLessThanOrEqual");
			}
		}
		public int BatchVersionEqual
		{
			get { return _BatchVersionEqual; }
			set 
			{ 
				_BatchVersionEqual = value;
				OnPropertyChanged("BatchVersionEqual");
			}
		}
		public int ParentJobIdEqual
		{
			get { return _ParentJobIdEqual; }
			set 
			{ 
				_ParentJobIdEqual = value;
				OnPropertyChanged("ParentJobIdEqual");
			}
		}
		public string ParentJobIdIn
		{
			get { return _ParentJobIdIn; }
			set 
			{ 
				_ParentJobIdIn = value;
				OnPropertyChanged("ParentJobIdIn");
			}
		}
		public string ParentJobIdNotIn
		{
			get { return _ParentJobIdNotIn; }
			set 
			{ 
				_ParentJobIdNotIn = value;
				OnPropertyChanged("ParentJobIdNotIn");
			}
		}
		public int RootJobIdEqual
		{
			get { return _RootJobIdEqual; }
			set 
			{ 
				_RootJobIdEqual = value;
				OnPropertyChanged("RootJobIdEqual");
			}
		}
		public string RootJobIdIn
		{
			get { return _RootJobIdIn; }
			set 
			{ 
				_RootJobIdIn = value;
				OnPropertyChanged("RootJobIdIn");
			}
		}
		public string RootJobIdNotIn
		{
			get { return _RootJobIdNotIn; }
			set 
			{ 
				_RootJobIdNotIn = value;
				OnPropertyChanged("RootJobIdNotIn");
			}
		}
		public int QueueTimeGreaterThanOrEqual
		{
			get { return _QueueTimeGreaterThanOrEqual; }
			set 
			{ 
				_QueueTimeGreaterThanOrEqual = value;
				OnPropertyChanged("QueueTimeGreaterThanOrEqual");
			}
		}
		public int QueueTimeLessThanOrEqual
		{
			get { return _QueueTimeLessThanOrEqual; }
			set 
			{ 
				_QueueTimeLessThanOrEqual = value;
				OnPropertyChanged("QueueTimeLessThanOrEqual");
			}
		}
		public int FinishTimeGreaterThanOrEqual
		{
			get { return _FinishTimeGreaterThanOrEqual; }
			set 
			{ 
				_FinishTimeGreaterThanOrEqual = value;
				OnPropertyChanged("FinishTimeGreaterThanOrEqual");
			}
		}
		public int FinishTimeLessThanOrEqual
		{
			get { return _FinishTimeLessThanOrEqual; }
			set 
			{ 
				_FinishTimeLessThanOrEqual = value;
				OnPropertyChanged("FinishTimeLessThanOrEqual");
			}
		}
		public KalturaBatchJobErrorTypes ErrTypeEqual
		{
			get { return _ErrTypeEqual; }
			set 
			{ 
				_ErrTypeEqual = value;
				OnPropertyChanged("ErrTypeEqual");
			}
		}
		public string ErrTypeIn
		{
			get { return _ErrTypeIn; }
			set 
			{ 
				_ErrTypeIn = value;
				OnPropertyChanged("ErrTypeIn");
			}
		}
		public string ErrTypeNotIn
		{
			get { return _ErrTypeNotIn; }
			set 
			{ 
				_ErrTypeNotIn = value;
				OnPropertyChanged("ErrTypeNotIn");
			}
		}
		public int ErrNumberEqual
		{
			get { return _ErrNumberEqual; }
			set 
			{ 
				_ErrNumberEqual = value;
				OnPropertyChanged("ErrNumberEqual");
			}
		}
		public string ErrNumberIn
		{
			get { return _ErrNumberIn; }
			set 
			{ 
				_ErrNumberIn = value;
				OnPropertyChanged("ErrNumberIn");
			}
		}
		public string ErrNumberNotIn
		{
			get { return _ErrNumberNotIn; }
			set 
			{ 
				_ErrNumberNotIn = value;
				OnPropertyChanged("ErrNumberNotIn");
			}
		}
		public int EstimatedEffortLessThan
		{
			get { return _EstimatedEffortLessThan; }
			set 
			{ 
				_EstimatedEffortLessThan = value;
				OnPropertyChanged("EstimatedEffortLessThan");
			}
		}
		public int EstimatedEffortGreaterThan
		{
			get { return _EstimatedEffortGreaterThan; }
			set 
			{ 
				_EstimatedEffortGreaterThan = value;
				OnPropertyChanged("EstimatedEffortGreaterThan");
			}
		}
		public int UrgencyLessThanOrEqual
		{
			get { return _UrgencyLessThanOrEqual; }
			set 
			{ 
				_UrgencyLessThanOrEqual = value;
				OnPropertyChanged("UrgencyLessThanOrEqual");
			}
		}
		public int UrgencyGreaterThanOrEqual
		{
			get { return _UrgencyGreaterThanOrEqual; }
			set 
			{ 
				_UrgencyGreaterThanOrEqual = value;
				OnPropertyChanged("UrgencyGreaterThanOrEqual");
			}
		}
		public int SchedulerIdEqual
		{
			get { return _SchedulerIdEqual; }
			set 
			{ 
				_SchedulerIdEqual = value;
				OnPropertyChanged("SchedulerIdEqual");
			}
		}
		public string SchedulerIdIn
		{
			get { return _SchedulerIdIn; }
			set 
			{ 
				_SchedulerIdIn = value;
				OnPropertyChanged("SchedulerIdIn");
			}
		}
		public string SchedulerIdNotIn
		{
			get { return _SchedulerIdNotIn; }
			set 
			{ 
				_SchedulerIdNotIn = value;
				OnPropertyChanged("SchedulerIdNotIn");
			}
		}
		public int WorkerIdEqual
		{
			get { return _WorkerIdEqual; }
			set 
			{ 
				_WorkerIdEqual = value;
				OnPropertyChanged("WorkerIdEqual");
			}
		}
		public string WorkerIdIn
		{
			get { return _WorkerIdIn; }
			set 
			{ 
				_WorkerIdIn = value;
				OnPropertyChanged("WorkerIdIn");
			}
		}
		public string WorkerIdNotIn
		{
			get { return _WorkerIdNotIn; }
			set 
			{ 
				_WorkerIdNotIn = value;
				OnPropertyChanged("WorkerIdNotIn");
			}
		}
		public int BatchIndexEqual
		{
			get { return _BatchIndexEqual; }
			set 
			{ 
				_BatchIndexEqual = value;
				OnPropertyChanged("BatchIndexEqual");
			}
		}
		public string BatchIndexIn
		{
			get { return _BatchIndexIn; }
			set 
			{ 
				_BatchIndexIn = value;
				OnPropertyChanged("BatchIndexIn");
			}
		}
		public string BatchIndexNotIn
		{
			get { return _BatchIndexNotIn; }
			set 
			{ 
				_BatchIndexNotIn = value;
				OnPropertyChanged("BatchIndexNotIn");
			}
		}
		public int LastSchedulerIdEqual
		{
			get { return _LastSchedulerIdEqual; }
			set 
			{ 
				_LastSchedulerIdEqual = value;
				OnPropertyChanged("LastSchedulerIdEqual");
			}
		}
		public string LastSchedulerIdIn
		{
			get { return _LastSchedulerIdIn; }
			set 
			{ 
				_LastSchedulerIdIn = value;
				OnPropertyChanged("LastSchedulerIdIn");
			}
		}
		public string LastSchedulerIdNotIn
		{
			get { return _LastSchedulerIdNotIn; }
			set 
			{ 
				_LastSchedulerIdNotIn = value;
				OnPropertyChanged("LastSchedulerIdNotIn");
			}
		}
		public int LastWorkerIdEqual
		{
			get { return _LastWorkerIdEqual; }
			set 
			{ 
				_LastWorkerIdEqual = value;
				OnPropertyChanged("LastWorkerIdEqual");
			}
		}
		public string LastWorkerIdIn
		{
			get { return _LastWorkerIdIn; }
			set 
			{ 
				_LastWorkerIdIn = value;
				OnPropertyChanged("LastWorkerIdIn");
			}
		}
		public string LastWorkerIdNotIn
		{
			get { return _LastWorkerIdNotIn; }
			set 
			{ 
				_LastWorkerIdNotIn = value;
				OnPropertyChanged("LastWorkerIdNotIn");
			}
		}
		public int DcEqual
		{
			get { return _DcEqual; }
			set 
			{ 
				_DcEqual = value;
				OnPropertyChanged("DcEqual");
			}
		}
		public string DcIn
		{
			get { return _DcIn; }
			set 
			{ 
				_DcIn = value;
				OnPropertyChanged("DcIn");
			}
		}
		public string DcNotIn
		{
			get { return _DcNotIn; }
			set 
			{ 
				_DcNotIn = value;
				OnPropertyChanged("DcNotIn");
			}
		}
		#endregion

		#region CTor
		public KalturaBatchJobBaseFilter()
		{
		}

		public KalturaBatchJobBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idGreaterThanOrEqual":
						this.IdGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "partnerIdNotIn":
						this.PartnerIdNotIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "lockExpirationGreaterThanOrEqual":
						this.LockExpirationGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "lockExpirationLessThanOrEqual":
						this.LockExpirationLessThanOrEqual = ParseInt(txt);
						continue;
					case "executionAttemptsGreaterThanOrEqual":
						this.ExecutionAttemptsGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "executionAttemptsLessThanOrEqual":
						this.ExecutionAttemptsLessThanOrEqual = ParseInt(txt);
						continue;
					case "lockVersionGreaterThanOrEqual":
						this.LockVersionGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "lockVersionLessThanOrEqual":
						this.LockVersionLessThanOrEqual = ParseInt(txt);
						continue;
					case "entryIdEqual":
						this.EntryIdEqual = txt;
						continue;
					case "jobTypeEqual":
						this.JobTypeEqual = (KalturaBatchJobType)KalturaStringEnum.Parse(typeof(KalturaBatchJobType), txt);
						continue;
					case "jobTypeIn":
						this.JobTypeIn = txt;
						continue;
					case "jobTypeNotIn":
						this.JobTypeNotIn = txt;
						continue;
					case "jobSubTypeEqual":
						this.JobSubTypeEqual = ParseInt(txt);
						continue;
					case "jobSubTypeIn":
						this.JobSubTypeIn = txt;
						continue;
					case "jobSubTypeNotIn":
						this.JobSubTypeNotIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaBatchJobStatus)ParseEnum(typeof(KalturaBatchJobStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "statusNotIn":
						this.StatusNotIn = txt;
						continue;
					case "abortEqual":
						this.AbortEqual = ParseInt(txt);
						continue;
					case "checkAgainTimeoutGreaterThanOrEqual":
						this.CheckAgainTimeoutGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "checkAgainTimeoutLessThanOrEqual":
						this.CheckAgainTimeoutLessThanOrEqual = ParseInt(txt);
						continue;
					case "priorityGreaterThanOrEqual":
						this.PriorityGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "priorityLessThanOrEqual":
						this.PriorityLessThanOrEqual = ParseInt(txt);
						continue;
					case "priorityEqual":
						this.PriorityEqual = ParseInt(txt);
						continue;
					case "priorityIn":
						this.PriorityIn = txt;
						continue;
					case "priorityNotIn":
						this.PriorityNotIn = txt;
						continue;
					case "bulkJobIdEqual":
						this.BulkJobIdEqual = ParseInt(txt);
						continue;
					case "bulkJobIdIn":
						this.BulkJobIdIn = txt;
						continue;
					case "bulkJobIdNotIn":
						this.BulkJobIdNotIn = txt;
						continue;
					case "batchVersionGreaterThanOrEqual":
						this.BatchVersionGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "batchVersionLessThanOrEqual":
						this.BatchVersionLessThanOrEqual = ParseInt(txt);
						continue;
					case "batchVersionEqual":
						this.BatchVersionEqual = ParseInt(txt);
						continue;
					case "parentJobIdEqual":
						this.ParentJobIdEqual = ParseInt(txt);
						continue;
					case "parentJobIdIn":
						this.ParentJobIdIn = txt;
						continue;
					case "parentJobIdNotIn":
						this.ParentJobIdNotIn = txt;
						continue;
					case "rootJobIdEqual":
						this.RootJobIdEqual = ParseInt(txt);
						continue;
					case "rootJobIdIn":
						this.RootJobIdIn = txt;
						continue;
					case "rootJobIdNotIn":
						this.RootJobIdNotIn = txt;
						continue;
					case "queueTimeGreaterThanOrEqual":
						this.QueueTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "queueTimeLessThanOrEqual":
						this.QueueTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "finishTimeGreaterThanOrEqual":
						this.FinishTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "finishTimeLessThanOrEqual":
						this.FinishTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "errTypeEqual":
						this.ErrTypeEqual = (KalturaBatchJobErrorTypes)ParseEnum(typeof(KalturaBatchJobErrorTypes), txt);
						continue;
					case "errTypeIn":
						this.ErrTypeIn = txt;
						continue;
					case "errTypeNotIn":
						this.ErrTypeNotIn = txt;
						continue;
					case "errNumberEqual":
						this.ErrNumberEqual = ParseInt(txt);
						continue;
					case "errNumberIn":
						this.ErrNumberIn = txt;
						continue;
					case "errNumberNotIn":
						this.ErrNumberNotIn = txt;
						continue;
					case "estimatedEffortLessThan":
						this.EstimatedEffortLessThan = ParseInt(txt);
						continue;
					case "estimatedEffortGreaterThan":
						this.EstimatedEffortGreaterThan = ParseInt(txt);
						continue;
					case "urgencyLessThanOrEqual":
						this.UrgencyLessThanOrEqual = ParseInt(txt);
						continue;
					case "urgencyGreaterThanOrEqual":
						this.UrgencyGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "schedulerIdEqual":
						this.SchedulerIdEqual = ParseInt(txt);
						continue;
					case "schedulerIdIn":
						this.SchedulerIdIn = txt;
						continue;
					case "schedulerIdNotIn":
						this.SchedulerIdNotIn = txt;
						continue;
					case "workerIdEqual":
						this.WorkerIdEqual = ParseInt(txt);
						continue;
					case "workerIdIn":
						this.WorkerIdIn = txt;
						continue;
					case "workerIdNotIn":
						this.WorkerIdNotIn = txt;
						continue;
					case "batchIndexEqual":
						this.BatchIndexEqual = ParseInt(txt);
						continue;
					case "batchIndexIn":
						this.BatchIndexIn = txt;
						continue;
					case "batchIndexNotIn":
						this.BatchIndexNotIn = txt;
						continue;
					case "lastSchedulerIdEqual":
						this.LastSchedulerIdEqual = ParseInt(txt);
						continue;
					case "lastSchedulerIdIn":
						this.LastSchedulerIdIn = txt;
						continue;
					case "lastSchedulerIdNotIn":
						this.LastSchedulerIdNotIn = txt;
						continue;
					case "lastWorkerIdEqual":
						this.LastWorkerIdEqual = ParseInt(txt);
						continue;
					case "lastWorkerIdIn":
						this.LastWorkerIdIn = txt;
						continue;
					case "lastWorkerIdNotIn":
						this.LastWorkerIdNotIn = txt;
						continue;
					case "dcEqual":
						this.DcEqual = ParseInt(txt);
						continue;
					case "dcIn":
						this.DcIn = txt;
						continue;
					case "dcNotIn":
						this.DcNotIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBatchJobBaseFilter");
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddIntIfNotNull("idGreaterThanOrEqual", this.IdGreaterThanOrEqual);
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddStringIfNotNull("partnerIdNotIn", this.PartnerIdNotIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("lockExpirationGreaterThanOrEqual", this.LockExpirationGreaterThanOrEqual);
			kparams.AddIntIfNotNull("lockExpirationLessThanOrEqual", this.LockExpirationLessThanOrEqual);
			kparams.AddIntIfNotNull("executionAttemptsGreaterThanOrEqual", this.ExecutionAttemptsGreaterThanOrEqual);
			kparams.AddIntIfNotNull("executionAttemptsLessThanOrEqual", this.ExecutionAttemptsLessThanOrEqual);
			kparams.AddIntIfNotNull("lockVersionGreaterThanOrEqual", this.LockVersionGreaterThanOrEqual);
			kparams.AddIntIfNotNull("lockVersionLessThanOrEqual", this.LockVersionLessThanOrEqual);
			kparams.AddStringIfNotNull("entryIdEqual", this.EntryIdEqual);
			kparams.AddStringEnumIfNotNull("jobTypeEqual", this.JobTypeEqual);
			kparams.AddStringIfNotNull("jobTypeIn", this.JobTypeIn);
			kparams.AddStringIfNotNull("jobTypeNotIn", this.JobTypeNotIn);
			kparams.AddIntIfNotNull("jobSubTypeEqual", this.JobSubTypeEqual);
			kparams.AddStringIfNotNull("jobSubTypeIn", this.JobSubTypeIn);
			kparams.AddStringIfNotNull("jobSubTypeNotIn", this.JobSubTypeNotIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringIfNotNull("statusNotIn", this.StatusNotIn);
			kparams.AddIntIfNotNull("abortEqual", this.AbortEqual);
			kparams.AddIntIfNotNull("checkAgainTimeoutGreaterThanOrEqual", this.CheckAgainTimeoutGreaterThanOrEqual);
			kparams.AddIntIfNotNull("checkAgainTimeoutLessThanOrEqual", this.CheckAgainTimeoutLessThanOrEqual);
			kparams.AddIntIfNotNull("priorityGreaterThanOrEqual", this.PriorityGreaterThanOrEqual);
			kparams.AddIntIfNotNull("priorityLessThanOrEqual", this.PriorityLessThanOrEqual);
			kparams.AddIntIfNotNull("priorityEqual", this.PriorityEqual);
			kparams.AddStringIfNotNull("priorityIn", this.PriorityIn);
			kparams.AddStringIfNotNull("priorityNotIn", this.PriorityNotIn);
			kparams.AddIntIfNotNull("bulkJobIdEqual", this.BulkJobIdEqual);
			kparams.AddStringIfNotNull("bulkJobIdIn", this.BulkJobIdIn);
			kparams.AddStringIfNotNull("bulkJobIdNotIn", this.BulkJobIdNotIn);
			kparams.AddIntIfNotNull("batchVersionGreaterThanOrEqual", this.BatchVersionGreaterThanOrEqual);
			kparams.AddIntIfNotNull("batchVersionLessThanOrEqual", this.BatchVersionLessThanOrEqual);
			kparams.AddIntIfNotNull("batchVersionEqual", this.BatchVersionEqual);
			kparams.AddIntIfNotNull("parentJobIdEqual", this.ParentJobIdEqual);
			kparams.AddStringIfNotNull("parentJobIdIn", this.ParentJobIdIn);
			kparams.AddStringIfNotNull("parentJobIdNotIn", this.ParentJobIdNotIn);
			kparams.AddIntIfNotNull("rootJobIdEqual", this.RootJobIdEqual);
			kparams.AddStringIfNotNull("rootJobIdIn", this.RootJobIdIn);
			kparams.AddStringIfNotNull("rootJobIdNotIn", this.RootJobIdNotIn);
			kparams.AddIntIfNotNull("queueTimeGreaterThanOrEqual", this.QueueTimeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("queueTimeLessThanOrEqual", this.QueueTimeLessThanOrEqual);
			kparams.AddIntIfNotNull("finishTimeGreaterThanOrEqual", this.FinishTimeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("finishTimeLessThanOrEqual", this.FinishTimeLessThanOrEqual);
			kparams.AddEnumIfNotNull("errTypeEqual", this.ErrTypeEqual);
			kparams.AddStringIfNotNull("errTypeIn", this.ErrTypeIn);
			kparams.AddStringIfNotNull("errTypeNotIn", this.ErrTypeNotIn);
			kparams.AddIntIfNotNull("errNumberEqual", this.ErrNumberEqual);
			kparams.AddStringIfNotNull("errNumberIn", this.ErrNumberIn);
			kparams.AddStringIfNotNull("errNumberNotIn", this.ErrNumberNotIn);
			kparams.AddIntIfNotNull("estimatedEffortLessThan", this.EstimatedEffortLessThan);
			kparams.AddIntIfNotNull("estimatedEffortGreaterThan", this.EstimatedEffortGreaterThan);
			kparams.AddIntIfNotNull("urgencyLessThanOrEqual", this.UrgencyLessThanOrEqual);
			kparams.AddIntIfNotNull("urgencyGreaterThanOrEqual", this.UrgencyGreaterThanOrEqual);
			kparams.AddIntIfNotNull("schedulerIdEqual", this.SchedulerIdEqual);
			kparams.AddStringIfNotNull("schedulerIdIn", this.SchedulerIdIn);
			kparams.AddStringIfNotNull("schedulerIdNotIn", this.SchedulerIdNotIn);
			kparams.AddIntIfNotNull("workerIdEqual", this.WorkerIdEqual);
			kparams.AddStringIfNotNull("workerIdIn", this.WorkerIdIn);
			kparams.AddStringIfNotNull("workerIdNotIn", this.WorkerIdNotIn);
			kparams.AddIntIfNotNull("batchIndexEqual", this.BatchIndexEqual);
			kparams.AddStringIfNotNull("batchIndexIn", this.BatchIndexIn);
			kparams.AddStringIfNotNull("batchIndexNotIn", this.BatchIndexNotIn);
			kparams.AddIntIfNotNull("lastSchedulerIdEqual", this.LastSchedulerIdEqual);
			kparams.AddStringIfNotNull("lastSchedulerIdIn", this.LastSchedulerIdIn);
			kparams.AddStringIfNotNull("lastSchedulerIdNotIn", this.LastSchedulerIdNotIn);
			kparams.AddIntIfNotNull("lastWorkerIdEqual", this.LastWorkerIdEqual);
			kparams.AddStringIfNotNull("lastWorkerIdIn", this.LastWorkerIdIn);
			kparams.AddStringIfNotNull("lastWorkerIdNotIn", this.LastWorkerIdNotIn);
			kparams.AddIntIfNotNull("dcEqual", this.DcEqual);
			kparams.AddStringIfNotNull("dcIn", this.DcIn);
			kparams.AddStringIfNotNull("dcNotIn", this.DcNotIn);
			return kparams;
		}
		#endregion
	}
}

