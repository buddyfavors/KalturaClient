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
	public class KalturaSshDropFolder : KalturaRemoteDropFolder
	{
		#region Private Fields
		private string _Host = null;
		private int _Port = Int32.MinValue;
		private string _Username = null;
		private string _Password = null;
		private string _PrivateKey = null;
		private string _PublicKey = null;
		private string _PassPhrase = null;
		#endregion

		#region Properties
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		public int Port
		{
			get { return _Port; }
			set 
			{ 
				_Port = value;
				OnPropertyChanged("Port");
			}
		}
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		public string PrivateKey
		{
			get { return _PrivateKey; }
			set 
			{ 
				_PrivateKey = value;
				OnPropertyChanged("PrivateKey");
			}
		}
		public string PublicKey
		{
			get { return _PublicKey; }
			set 
			{ 
				_PublicKey = value;
				OnPropertyChanged("PublicKey");
			}
		}
		public string PassPhrase
		{
			get { return _PassPhrase; }
			set 
			{ 
				_PassPhrase = value;
				OnPropertyChanged("PassPhrase");
			}
		}
		#endregion

		#region CTor
		public KalturaSshDropFolder()
		{
		}

		public KalturaSshDropFolder(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "host":
						this.Host = txt;
						continue;
					case "port":
						this.Port = ParseInt(txt);
						continue;
					case "username":
						this.Username = txt;
						continue;
					case "password":
						this.Password = txt;
						continue;
					case "privateKey":
						this.PrivateKey = txt;
						continue;
					case "publicKey":
						this.PublicKey = txt;
						continue;
					case "passPhrase":
						this.PassPhrase = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSshDropFolder");
			kparams.AddStringIfNotNull("host", this.Host);
			kparams.AddIntIfNotNull("port", this.Port);
			kparams.AddStringIfNotNull("username", this.Username);
			kparams.AddStringIfNotNull("password", this.Password);
			kparams.AddStringIfNotNull("privateKey", this.PrivateKey);
			kparams.AddStringIfNotNull("publicKey", this.PublicKey);
			kparams.AddStringIfNotNull("passPhrase", this.PassPhrase);
			return kparams;
		}
		#endregion
	}
}

