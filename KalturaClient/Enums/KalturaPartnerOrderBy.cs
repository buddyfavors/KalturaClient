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
	public sealed class KalturaPartnerOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPartnerOrderBy ADMIN_EMAIL_ASC = new KalturaPartnerOrderBy("+adminEmail");
		public static readonly KalturaPartnerOrderBy ADMIN_NAME_ASC = new KalturaPartnerOrderBy("+adminName");
		public static readonly KalturaPartnerOrderBy CREATED_AT_ASC = new KalturaPartnerOrderBy("+createdAt");
		public static readonly KalturaPartnerOrderBy ID_ASC = new KalturaPartnerOrderBy("+id");
		public static readonly KalturaPartnerOrderBy NAME_ASC = new KalturaPartnerOrderBy("+name");
		public static readonly KalturaPartnerOrderBy STATUS_ASC = new KalturaPartnerOrderBy("+status");
		public static readonly KalturaPartnerOrderBy WEBSITE_ASC = new KalturaPartnerOrderBy("+website");
		public static readonly KalturaPartnerOrderBy ADMIN_EMAIL_DESC = new KalturaPartnerOrderBy("-adminEmail");
		public static readonly KalturaPartnerOrderBy ADMIN_NAME_DESC = new KalturaPartnerOrderBy("-adminName");
		public static readonly KalturaPartnerOrderBy CREATED_AT_DESC = new KalturaPartnerOrderBy("-createdAt");
		public static readonly KalturaPartnerOrderBy ID_DESC = new KalturaPartnerOrderBy("-id");
		public static readonly KalturaPartnerOrderBy NAME_DESC = new KalturaPartnerOrderBy("-name");
		public static readonly KalturaPartnerOrderBy STATUS_DESC = new KalturaPartnerOrderBy("-status");
		public static readonly KalturaPartnerOrderBy WEBSITE_DESC = new KalturaPartnerOrderBy("-website");

		private KalturaPartnerOrderBy(string name) : base(name) { }
	}
}
