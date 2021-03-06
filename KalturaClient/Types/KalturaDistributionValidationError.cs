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
	public class KalturaDistributionValidationError : KalturaObjectBase
	{
		#region Private Fields
		private KalturaDistributionAction _Action = (KalturaDistributionAction)Int32.MinValue;
		private KalturaDistributionErrorType _ErrorType = (KalturaDistributionErrorType)Int32.MinValue;
		private string _Description = null;
		#endregion

		#region Properties
		public KalturaDistributionAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public KalturaDistributionErrorType ErrorType
		{
			get { return _ErrorType; }
			set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionValidationError()
		{
		}

		public KalturaDistributionValidationError(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "action":
						this.Action = (KalturaDistributionAction)ParseEnum(typeof(KalturaDistributionAction), txt);
						continue;
					case "errorType":
						this.ErrorType = (KalturaDistributionErrorType)ParseEnum(typeof(KalturaDistributionErrorType), txt);
						continue;
					case "description":
						this.Description = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDistributionValidationError");
			kparams.AddEnumIfNotNull("action", this.Action);
			kparams.AddEnumIfNotNull("errorType", this.ErrorType);
			kparams.AddStringIfNotNull("description", this.Description);
			return kparams;
		}
		#endregion
	}
}

