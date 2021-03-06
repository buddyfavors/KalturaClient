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
	public sealed class KalturaCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaCuePointOrderBy CREATED_AT_ASC = new KalturaCuePointOrderBy("+createdAt");
		public static readonly KalturaCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaCuePointOrderBy START_TIME_ASC = new KalturaCuePointOrderBy("+startTime");
		public static readonly KalturaCuePointOrderBy UPDATED_AT_ASC = new KalturaCuePointOrderBy("+updatedAt");
		public static readonly KalturaCuePointOrderBy CREATED_AT_DESC = new KalturaCuePointOrderBy("-createdAt");
		public static readonly KalturaCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaCuePointOrderBy("-partnerSortValue");
		public static readonly KalturaCuePointOrderBy START_TIME_DESC = new KalturaCuePointOrderBy("-startTime");
		public static readonly KalturaCuePointOrderBy UPDATED_AT_DESC = new KalturaCuePointOrderBy("-updatedAt");

		private KalturaCuePointOrderBy(string name) : base(name) { }
	}
}
