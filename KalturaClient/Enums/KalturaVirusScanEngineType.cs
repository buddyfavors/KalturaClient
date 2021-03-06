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
namespace Kaltura
{
	public sealed class KalturaVirusScanEngineType : KalturaStringEnum
	{
		public static readonly KalturaVirusScanEngineType CLAMAV_SCAN_ENGINE = new KalturaVirusScanEngineType("clamAVScanEngine.ClamAV");
		public static readonly KalturaVirusScanEngineType SYMANTEC_SCAN_DIRECT_ENGINE = new KalturaVirusScanEngineType("symantecScanEngine.SymantecScanDirectEngine");
		public static readonly KalturaVirusScanEngineType SYMANTEC_SCAN_ENGINE = new KalturaVirusScanEngineType("symantecScanEngine.SymantecScanEngine");
		public static readonly KalturaVirusScanEngineType SYMANTEC_SCAN_JAVA_ENGINE = new KalturaVirusScanEngineType("symantecScanEngine.SymantecScanJavaEngine");

		private KalturaVirusScanEngineType(string name) : base(name) { }
	}
}
