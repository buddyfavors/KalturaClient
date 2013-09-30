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
using System.Text;
using System.Xml;
using System.Runtime.Serialization;

namespace Kaltura
{
	public static class KalturaObjectFactory
	{
		public static object Create(XmlElement xmlElement)
		{
			if (xmlElement["objectType"] == null)
			{
				return null;
			}
			switch (xmlElement["objectType"].InnerText)
			{
				case "KalturaObject":
					return new KalturaObject(xmlElement);
				case "KalturaBaseRestriction":
					return new KalturaBaseRestriction(xmlElement);
				case "KalturaAccessControl":
					return new KalturaAccessControl(xmlElement);
				case "KalturaAccessControlAction":
					return new KalturaAccessControlAction(xmlElement);
				case "KalturaAccessControlContextTypeHolder":
					return new KalturaAccessControlContextTypeHolder(xmlElement);
				case "KalturaAccessControlListResponse":
					return new KalturaAccessControlListResponse(xmlElement);
				case "KalturaCondition":
					return new KalturaCondition(xmlElement);
				case "KalturaRule":
					return new KalturaRule(xmlElement);
				case "KalturaAccessControlProfile":
					return new KalturaAccessControlProfile(xmlElement);
				case "KalturaAccessControlProfileListResponse":
					return new KalturaAccessControlProfileListResponse(xmlElement);
				case "KalturaKeyValue":
					return new KalturaKeyValue(xmlElement);
				case "KalturaAccessControlScope":
					return new KalturaAccessControlScope(xmlElement);
				case "KalturaCuePoint":
					return new KalturaCuePoint(xmlElement);
				case "KalturaAnnotation":
					return new KalturaAnnotation(xmlElement);
				case "KalturaAnnotationListResponse":
					return new KalturaAnnotationListResponse(xmlElement);
				case "KalturaAsset":
					return new KalturaAsset(xmlElement);
				case "KalturaAssetDistributionCondition":
					return new KalturaAssetDistributionCondition(xmlElement);
				case "KalturaAssetDistributionRule":
					return new KalturaAssetDistributionRule(xmlElement);
				case "KalturaString":
					return new KalturaString(xmlElement);
				case "KalturaAssetParams":
					return new KalturaAssetParams(xmlElement);
				case "KalturaResource":
					return new KalturaResource(xmlElement);
				case "KalturaContentResource":
					return new KalturaContentResource(xmlElement);
				case "KalturaAssetParamsResourceContainer":
					return new KalturaAssetParamsResourceContainer(xmlElement);
				case "KalturaAttachmentAsset":
					return new KalturaAttachmentAsset(xmlElement);
				case "KalturaAttachmentAssetListResponse":
					return new KalturaAttachmentAssetListResponse(xmlElement);
				case "KalturaAuditTrailInfo":
					return new KalturaAuditTrailInfo(xmlElement);
				case "KalturaAuditTrail":
					return new KalturaAuditTrail(xmlElement);
				case "KalturaAuditTrailChangeItem":
					return new KalturaAuditTrailChangeItem(xmlElement);
				case "KalturaAuditTrailListResponse":
					return new KalturaAuditTrailListResponse(xmlElement);
				case "KalturaOperationAttributes":
					return new KalturaOperationAttributes(xmlElement);
				case "KalturaBaseEntry":
					return new KalturaBaseEntry(xmlElement);
				case "KalturaBaseEntryListResponse":
					return new KalturaBaseEntryListResponse(xmlElement);
				case "KalturaBaseSyndicationFeed":
					return new KalturaBaseSyndicationFeed(xmlElement);
				case "KalturaBaseSyndicationFeedListResponse":
					return new KalturaBaseSyndicationFeedListResponse(xmlElement);
				case "KalturaJobData":
					return new KalturaJobData(xmlElement);
				case "KalturaBatchHistoryData":
					return new KalturaBatchHistoryData(xmlElement);
				case "KalturaBatchJob":
					return new KalturaBatchJob(xmlElement);
				case "KalturaPlayerDeliveryType":
					return new KalturaPlayerDeliveryType(xmlElement);
				case "KalturaPlayerEmbedCodeType":
					return new KalturaPlayerEmbedCodeType(xmlElement);
				case "KalturaPartner":
					return new KalturaPartner(xmlElement);
				case "KalturaBatchGetExclusiveNotificationJobsResponse":
					return new KalturaBatchGetExclusiveNotificationJobsResponse(xmlElement);
				case "KalturaBatchJobListResponse":
					return new KalturaBatchJobListResponse(xmlElement);
				case "KalturaBatchJobResponse":
					return new KalturaBatchJobResponse(xmlElement);
				case "KalturaBatchQueuesStatus":
					return new KalturaBatchQueuesStatus(xmlElement);
				case "KalturaValue":
					return new KalturaValue(xmlElement);
				case "KalturaBooleanValue":
					return new KalturaBooleanValue(xmlElement);
				case "KalturaBulkUploadPluginData":
					return new KalturaBulkUploadPluginData(xmlElement);
				case "KalturaBulkUploadResult":
					return new KalturaBulkUploadResult(xmlElement);
				case "KalturaBulkUpload":
					return new KalturaBulkUpload(xmlElement);
				case "KalturaBulkUploadListResponse":
					return new KalturaBulkUploadListResponse(xmlElement);
				case "KalturaBulkUploadObjectData":
					return new KalturaBulkUploadObjectData(xmlElement);
				case "KalturaCEError":
					return new KalturaCEError(xmlElement);
				case "KalturaCaptionAsset":
					return new KalturaCaptionAsset(xmlElement);
				case "KalturaCaptionAssetItem":
					return new KalturaCaptionAssetItem(xmlElement);
				case "KalturaCaptionAssetItemListResponse":
					return new KalturaCaptionAssetItemListResponse(xmlElement);
				case "KalturaCaptionAssetListResponse":
					return new KalturaCaptionAssetListResponse(xmlElement);
				case "KalturaCaptionParams":
					return new KalturaCaptionParams(xmlElement);
				case "KalturaCaptionParamsListResponse":
					return new KalturaCaptionParamsListResponse(xmlElement);
				case "KalturaCategory":
					return new KalturaCategory(xmlElement);
				case "KalturaCategoryEntry":
					return new KalturaCategoryEntry(xmlElement);
				case "KalturaCategoryEntryListResponse":
					return new KalturaCategoryEntryListResponse(xmlElement);
				case "KalturaCategoryListResponse":
					return new KalturaCategoryListResponse(xmlElement);
				case "KalturaCategoryUser":
					return new KalturaCategoryUser(xmlElement);
				case "KalturaCategoryUserListResponse":
					return new KalturaCategoryUserListResponse(xmlElement);
				case "KalturaClientNotification":
					return new KalturaClientNotification(xmlElement);
				case "KalturaContext":
					return new KalturaContext(xmlElement);
				case "KalturaControlPanelCommand":
					return new KalturaControlPanelCommand(xmlElement);
				case "KalturaControlPanelCommandListResponse":
					return new KalturaControlPanelCommandListResponse(xmlElement);
				case "KalturaConversionAttribute":
					return new KalturaConversionAttribute(xmlElement);
				case "KalturaCropDimensions":
					return new KalturaCropDimensions(xmlElement);
				case "KalturaConversionProfile":
					return new KalturaConversionProfile(xmlElement);
				case "KalturaConversionProfileAssetParams":
					return new KalturaConversionProfileAssetParams(xmlElement);
				case "KalturaConversionProfileAssetParamsListResponse":
					return new KalturaConversionProfileAssetParamsListResponse(xmlElement);
				case "KalturaConversionProfileListResponse":
					return new KalturaConversionProfileListResponse(xmlElement);
				case "KalturaConvertCollectionFlavorData":
					return new KalturaConvertCollectionFlavorData(xmlElement);
				case "KalturaCuePointListResponse":
					return new KalturaCuePointListResponse(xmlElement);
				case "KalturaDataEntry":
					return new KalturaDataEntry(xmlElement);
				case "KalturaDataListResponse":
					return new KalturaDataListResponse(xmlElement);
				case "KalturaDistributionFieldConfig":
					return new KalturaDistributionFieldConfig(xmlElement);
				case "KalturaDistributionJobProviderData":
					return new KalturaDistributionJobProviderData(xmlElement);
				case "KalturaDistributionThumbDimensions":
					return new KalturaDistributionThumbDimensions(xmlElement);
				case "KalturaDistributionProfile":
					return new KalturaDistributionProfile(xmlElement);
				case "KalturaDistributionProfileListResponse":
					return new KalturaDistributionProfileListResponse(xmlElement);
				case "KalturaDistributionProvider":
					return new KalturaDistributionProvider(xmlElement);
				case "KalturaDistributionProviderListResponse":
					return new KalturaDistributionProviderListResponse(xmlElement);
				case "KalturaDistributionRemoteMediaFile":
					return new KalturaDistributionRemoteMediaFile(xmlElement);
				case "KalturaDistributionValidationError":
					return new KalturaDistributionValidationError(xmlElement);
				case "KalturaDocumentEntry":
					return new KalturaDocumentEntry(xmlElement);
				case "KalturaDocumentListResponse":
					return new KalturaDocumentListResponse(xmlElement);
				case "KalturaDropFolderFileHandlerConfig":
					return new KalturaDropFolderFileHandlerConfig(xmlElement);
				case "KalturaDropFolder":
					return new KalturaDropFolder(xmlElement);
				case "KalturaDropFolderFile":
					return new KalturaDropFolderFile(xmlElement);
				case "KalturaDropFolderFileListResponse":
					return new KalturaDropFolderFileListResponse(xmlElement);
				case "KalturaDropFolderListResponse":
					return new KalturaDropFolderListResponse(xmlElement);
				case "KalturaEmailIngestionProfile":
					return new KalturaEmailIngestionProfile(xmlElement);
				case "KalturaStringValue":
					return new KalturaStringValue(xmlElement);
				case "KalturaEmailNotificationRecipient":
					return new KalturaEmailNotificationRecipient(xmlElement);
				case "KalturaEmailNotificationRecipientJobData":
					return new KalturaEmailNotificationRecipientJobData(xmlElement);
				case "KalturaEmailNotificationRecipientProvider":
					return new KalturaEmailNotificationRecipientProvider(xmlElement);
				case "KalturaFlavorAsset":
					return new KalturaFlavorAsset(xmlElement);
				case "KalturaEntryContextDataResult":
					return new KalturaEntryContextDataResult(xmlElement);
				case "KalturaEntryDistribution":
					return new KalturaEntryDistribution(xmlElement);
				case "KalturaEntryDistributionListResponse":
					return new KalturaEntryDistributionListResponse(xmlElement);
				case "KalturaEventCondition":
					return new KalturaEventCondition(xmlElement);
				case "KalturaEventNotificationParameter":
					return new KalturaEventNotificationParameter(xmlElement);
				case "KalturaEventNotificationTemplate":
					return new KalturaEventNotificationTemplate(xmlElement);
				case "KalturaEventNotificationTemplateListResponse":
					return new KalturaEventNotificationTemplateListResponse(xmlElement);
				case "KalturaExclusiveLockKey":
					return new KalturaExclusiveLockKey(xmlElement);
				case "KalturaObjectIdentifier":
					return new KalturaObjectIdentifier(xmlElement);
				case "KalturaExtendingItemMrssParameter":
					return new KalturaExtendingItemMrssParameter(xmlElement);
				case "KalturaPlayableEntry":
					return new KalturaPlayableEntry(xmlElement);
				case "KalturaMediaEntry":
					return new KalturaMediaEntry(xmlElement);
				case "KalturaExternalMediaEntry":
					return new KalturaExternalMediaEntry(xmlElement);
				case "KalturaExternalMediaEntryListResponse":
					return new KalturaExternalMediaEntryListResponse(xmlElement);
				case "KalturaFeatureStatus":
					return new KalturaFeatureStatus(xmlElement);
				case "KalturaFeatureStatusListResponse":
					return new KalturaFeatureStatusListResponse(xmlElement);
				case "KalturaFileExistsResponse":
					return new KalturaFileExistsResponse(xmlElement);
				case "KalturaFileSync":
					return new KalturaFileSync(xmlElement);
				case "KalturaFileSyncListResponse":
					return new KalturaFileSyncListResponse(xmlElement);
				case "KalturaSearchItem":
					return new KalturaSearchItem(xmlElement);
				case "KalturaFilter":
					return new KalturaFilter(xmlElement);
				case "KalturaFilterPager":
					return new KalturaFilterPager(xmlElement);
				case "KalturaFlavorAssetListResponse":
					return new KalturaFlavorAssetListResponse(xmlElement);
				case "KalturaFlavorParams":
					return new KalturaFlavorParams(xmlElement);
				case "KalturaFlavorAssetWithParams":
					return new KalturaFlavorAssetWithParams(xmlElement);
				case "KalturaFlavorParamsListResponse":
					return new KalturaFlavorParamsListResponse(xmlElement);
				case "KalturaFlavorParamsOutput":
					return new KalturaFlavorParamsOutput(xmlElement);
				case "KalturaFlavorParamsOutputListResponse":
					return new KalturaFlavorParamsOutputListResponse(xmlElement);
				case "KalturaFreeJobResponse":
					return new KalturaFreeJobResponse(xmlElement);
				case "KalturaSchedulerStatus":
					return new KalturaSchedulerStatus(xmlElement);
				case "KalturaSchedulerConfig":
					return new KalturaSchedulerConfig(xmlElement);
				case "KalturaSchedulerWorker":
					return new KalturaSchedulerWorker(xmlElement);
				case "KalturaScheduler":
					return new KalturaScheduler(xmlElement);
				case "KalturaFullStatusResponse":
					return new KalturaFullStatusResponse(xmlElement);
				case "KalturaGenericDistributionProfileAction":
					return new KalturaGenericDistributionProfileAction(xmlElement);
				case "KalturaGenericDistributionProviderAction":
					return new KalturaGenericDistributionProviderAction(xmlElement);
				case "KalturaGenericDistributionProviderActionListResponse":
					return new KalturaGenericDistributionProviderActionListResponse(xmlElement);
				case "KalturaGenericDistributionProvider":
					return new KalturaGenericDistributionProvider(xmlElement);
				case "KalturaGenericDistributionProviderListResponse":
					return new KalturaGenericDistributionProviderListResponse(xmlElement);
				case "KalturaHttpNotification":
					return new KalturaHttpNotification(xmlElement);
				case "KalturaHttpNotificationData":
					return new KalturaHttpNotificationData(xmlElement);
				case "KalturaIntegerValue":
					return new KalturaIntegerValue(xmlElement);
				case "KalturaLiveStreamBitrate":
					return new KalturaLiveStreamBitrate(xmlElement);
				case "KalturaLiveStreamConfiguration":
					return new KalturaLiveStreamConfiguration(xmlElement);
				case "KalturaLiveStreamEntry":
					return new KalturaLiveStreamEntry(xmlElement);
				case "KalturaLiveStreamListResponse":
					return new KalturaLiveStreamListResponse(xmlElement);
				case "KalturaBaseEntryBaseFilter":
					return new KalturaBaseEntryBaseFilter(xmlElement);
				case "KalturaBaseEntryFilter":
					return new KalturaBaseEntryFilter(xmlElement);
				case "KalturaPlayableEntryBaseFilter":
					return new KalturaPlayableEntryBaseFilter(xmlElement);
				case "KalturaPlayableEntryFilter":
					return new KalturaPlayableEntryFilter(xmlElement);
				case "KalturaMediaEntryBaseFilter":
					return new KalturaMediaEntryBaseFilter(xmlElement);
				case "KalturaMediaEntryFilter":
					return new KalturaMediaEntryFilter(xmlElement);
				case "KalturaMediaEntryFilterForPlaylist":
					return new KalturaMediaEntryFilterForPlaylist(xmlElement);
				case "KalturaMediaInfo":
					return new KalturaMediaInfo(xmlElement);
				case "KalturaMediaInfoListResponse":
					return new KalturaMediaInfoListResponse(xmlElement);
				case "KalturaMediaListResponse":
					return new KalturaMediaListResponse(xmlElement);
				case "KalturaMetadata":
					return new KalturaMetadata(xmlElement);
				case "KalturaMetadataListResponse":
					return new KalturaMetadataListResponse(xmlElement);
				case "KalturaMetadataProfile":
					return new KalturaMetadataProfile(xmlElement);
				case "KalturaMetadataProfileField":
					return new KalturaMetadataProfileField(xmlElement);
				case "KalturaMetadataProfileFieldListResponse":
					return new KalturaMetadataProfileFieldListResponse(xmlElement);
				case "KalturaMetadataProfileListResponse":
					return new KalturaMetadataProfileListResponse(xmlElement);
				case "KalturaMixEntry":
					return new KalturaMixEntry(xmlElement);
				case "KalturaMixListResponse":
					return new KalturaMixListResponse(xmlElement);
				case "KalturaModerationFlag":
					return new KalturaModerationFlag(xmlElement);
				case "KalturaModerationFlagListResponse":
					return new KalturaModerationFlagListResponse(xmlElement);
				case "KalturaPartnerListResponse":
					return new KalturaPartnerListResponse(xmlElement);
				case "KalturaPartnerStatistics":
					return new KalturaPartnerStatistics(xmlElement);
				case "KalturaPartnerUsage":
					return new KalturaPartnerUsage(xmlElement);
				case "KalturaVarPartnerUsageItem":
					return new KalturaVarPartnerUsageItem(xmlElement);
				case "KalturaPartnerUsageListResponse":
					return new KalturaPartnerUsageListResponse(xmlElement);
				case "KalturaPermission":
					return new KalturaPermission(xmlElement);
				case "KalturaPermissionItem":
					return new KalturaPermissionItem(xmlElement);
				case "KalturaPermissionItemListResponse":
					return new KalturaPermissionItemListResponse(xmlElement);
				case "KalturaPermissionListResponse":
					return new KalturaPermissionListResponse(xmlElement);
				case "KalturaPlaylist":
					return new KalturaPlaylist(xmlElement);
				case "KalturaPlaylistListResponse":
					return new KalturaPlaylistListResponse(xmlElement);
				case "KalturaRemotePath":
					return new KalturaRemotePath(xmlElement);
				case "KalturaRemotePathListResponse":
					return new KalturaRemotePathListResponse(xmlElement);
				case "KalturaUrlResource":
					return new KalturaUrlResource(xmlElement);
				case "KalturaRemoteStorageResource":
					return new KalturaRemoteStorageResource(xmlElement);
				case "KalturaReport":
					return new KalturaReport(xmlElement);
				case "KalturaReportBaseTotal":
					return new KalturaReportBaseTotal(xmlElement);
				case "KalturaReportGraph":
					return new KalturaReportGraph(xmlElement);
				case "KalturaReportInputBaseFilter":
					return new KalturaReportInputBaseFilter(xmlElement);
				case "KalturaReportListResponse":
					return new KalturaReportListResponse(xmlElement);
				case "KalturaReportResponse":
					return new KalturaReportResponse(xmlElement);
				case "KalturaReportTable":
					return new KalturaReportTable(xmlElement);
				case "KalturaReportTotal":
					return new KalturaReportTotal(xmlElement);
				case "KalturaSchedulerListResponse":
					return new KalturaSchedulerListResponse(xmlElement);
				case "KalturaSchedulerStatusResponse":
					return new KalturaSchedulerStatusResponse(xmlElement);
				case "KalturaSchedulerWorkerListResponse":
					return new KalturaSchedulerWorkerListResponse(xmlElement);
				case "KalturaSearch":
					return new KalturaSearch(xmlElement);
				case "KalturaSearchAuthData":
					return new KalturaSearchAuthData(xmlElement);
				case "KalturaSearchResult":
					return new KalturaSearchResult(xmlElement);
				case "KalturaSearchResultResponse":
					return new KalturaSearchResultResponse(xmlElement);
				case "KalturaSessionInfo":
					return new KalturaSessionInfo(xmlElement);
				case "KalturaShortLink":
					return new KalturaShortLink(xmlElement);
				case "KalturaShortLinkListResponse":
					return new KalturaShortLinkListResponse(xmlElement);
				case "KalturaSourceFileSyncDescriptor":
					return new KalturaSourceFileSyncDescriptor(xmlElement);
				case "KalturaStartWidgetSessionResponse":
					return new KalturaStartWidgetSessionResponse(xmlElement);
				case "KalturaStatsEvent":
					return new KalturaStatsEvent(xmlElement);
				case "KalturaStatsKmcEvent":
					return new KalturaStatsKmcEvent(xmlElement);
				case "KalturaStorageProfile":
					return new KalturaStorageProfile(xmlElement);
				case "KalturaStorageProfileListResponse":
					return new KalturaStorageProfileListResponse(xmlElement);
				case "KalturaSupportedSubTypes":
					return new KalturaSupportedSubTypes(xmlElement);
				case "KalturaSyndicationFeedEntryCount":
					return new KalturaSyndicationFeedEntryCount(xmlElement);
				case "KalturaTag":
					return new KalturaTag(xmlElement);
				case "KalturaTagListResponse":
					return new KalturaTagListResponse(xmlElement);
				case "KalturaThumbAsset":
					return new KalturaThumbAsset(xmlElement);
				case "KalturaThumbAssetListResponse":
					return new KalturaThumbAssetListResponse(xmlElement);
				case "KalturaThumbParams":
					return new KalturaThumbParams(xmlElement);
				case "KalturaThumbParamsListResponse":
					return new KalturaThumbParamsListResponse(xmlElement);
				case "KalturaThumbParamsOutput":
					return new KalturaThumbParamsOutput(xmlElement);
				case "KalturaThumbParamsOutputListResponse":
					return new KalturaThumbParamsOutputListResponse(xmlElement);
				case "KalturaTransformMetadataResponse":
					return new KalturaTransformMetadataResponse(xmlElement);
				case "KalturaTypedArray":
					return new KalturaTypedArray(xmlElement);
				case "KalturaUiConf":
					return new KalturaUiConf(xmlElement);
				case "KalturaUiConfListResponse":
					return new KalturaUiConfListResponse(xmlElement);
				case "KalturaUiConfTypeInfo":
					return new KalturaUiConfTypeInfo(xmlElement);
				case "KalturaUpgradeMetadataResponse":
					return new KalturaUpgradeMetadataResponse(xmlElement);
				case "KalturaUploadResponse":
					return new KalturaUploadResponse(xmlElement);
				case "KalturaUploadToken":
					return new KalturaUploadToken(xmlElement);
				case "KalturaUploadTokenListResponse":
					return new KalturaUploadTokenListResponse(xmlElement);
				case "KalturaUser":
					return new KalturaUser(xmlElement);
				case "KalturaUserListResponse":
					return new KalturaUserListResponse(xmlElement);
				case "KalturaUserLoginData":
					return new KalturaUserLoginData(xmlElement);
				case "KalturaUserLoginDataListResponse":
					return new KalturaUserLoginDataListResponse(xmlElement);
				case "KalturaUserRole":
					return new KalturaUserRole(xmlElement);
				case "KalturaUserRoleListResponse":
					return new KalturaUserRoleListResponse(xmlElement);
				case "KalturaVirusScanProfile":
					return new KalturaVirusScanProfile(xmlElement);
				case "KalturaVirusScanProfileListResponse":
					return new KalturaVirusScanProfileListResponse(xmlElement);
				case "KalturaWidget":
					return new KalturaWidget(xmlElement);
				case "KalturaWidgetListResponse":
					return new KalturaWidgetListResponse(xmlElement);
				case "KalturaBatchJobBaseFilter":
					return new KalturaBatchJobBaseFilter(xmlElement);
				case "KalturaBatchJobFilter":
					return new KalturaBatchJobFilter(xmlElement);
				case "KalturaWorkerQueueFilter":
					return new KalturaWorkerQueueFilter(xmlElement);
				case "KalturaABCScreenersWatermarkCondition":
					return new KalturaABCScreenersWatermarkCondition(xmlElement);
				case "KalturaAccessControlBaseFilter":
					return new KalturaAccessControlBaseFilter(xmlElement);
				case "KalturaAccessControlBlockAction":
					return new KalturaAccessControlBlockAction(xmlElement);
				case "KalturaAccessControlLimitFlavorsAction":
					return new KalturaAccessControlLimitFlavorsAction(xmlElement);
				case "KalturaAccessControlPreviewAction":
					return new KalturaAccessControlPreviewAction(xmlElement);
				case "KalturaAccessControlProfileBaseFilter":
					return new KalturaAccessControlProfileBaseFilter(xmlElement);
				case "KalturaAdCuePoint":
					return new KalturaAdCuePoint(xmlElement);
				case "KalturaAdminUser":
					return new KalturaAdminUser(xmlElement);
				case "KalturaAmazonS3StorageProfile":
					return new KalturaAmazonS3StorageProfile(xmlElement);
				case "KalturaApiActionPermissionItem":
					return new KalturaApiActionPermissionItem(xmlElement);
				case "KalturaApiParameterPermissionItem":
					return new KalturaApiParameterPermissionItem(xmlElement);
				case "KalturaAssetBaseFilter":
					return new KalturaAssetBaseFilter(xmlElement);
				case "KalturaAssetDistributionPropertyCondition":
					return new KalturaAssetDistributionPropertyCondition(xmlElement);
				case "KalturaAssetParamsBaseFilter":
					return new KalturaAssetParamsBaseFilter(xmlElement);
				case "KalturaAssetParamsOutput":
					return new KalturaAssetParamsOutput(xmlElement);
				case "KalturaAssetPropertiesCompareCondition":
					return new KalturaAssetPropertiesCompareCondition(xmlElement);
				case "KalturaAssetsParamsResourceContainers":
					return new KalturaAssetsParamsResourceContainers(xmlElement);
				case "KalturaAuditTrailBaseFilter":
					return new KalturaAuditTrailBaseFilter(xmlElement);
				case "KalturaAuditTrailChangeInfo":
					return new KalturaAuditTrailChangeInfo(xmlElement);
				case "KalturaAuditTrailChangeXmlNode":
					return new KalturaAuditTrailChangeXmlNode(xmlElement);
				case "KalturaAuditTrailFileSyncCreateInfo":
					return new KalturaAuditTrailFileSyncCreateInfo(xmlElement);
				case "KalturaAuditTrailTextInfo":
					return new KalturaAuditTrailTextInfo(xmlElement);
				case "KalturaAuthenticatedCondition":
					return new KalturaAuthenticatedCondition(xmlElement);
				case "KalturaBaseSyndicationFeedBaseFilter":
					return new KalturaBaseSyndicationFeedBaseFilter(xmlElement);
				case "KalturaBulkDownloadJobData":
					return new KalturaBulkDownloadJobData(xmlElement);
				case "KalturaBulkUploadBaseFilter":
					return new KalturaBulkUploadBaseFilter(xmlElement);
				case "KalturaBulkUploadCategoryData":
					return new KalturaBulkUploadCategoryData(xmlElement);
				case "KalturaBulkUploadCategoryUserData":
					return new KalturaBulkUploadCategoryUserData(xmlElement);
				case "KalturaBulkUploadEntryData":
					return new KalturaBulkUploadEntryData(xmlElement);
				case "KalturaBulkUploadJobData":
					return new KalturaBulkUploadJobData(xmlElement);
				case "KalturaBulkUploadResultCategory":
					return new KalturaBulkUploadResultCategory(xmlElement);
				case "KalturaBulkUploadResultCategoryUser":
					return new KalturaBulkUploadResultCategoryUser(xmlElement);
				case "KalturaBulkUploadResultEntry":
					return new KalturaBulkUploadResultEntry(xmlElement);
				case "KalturaBulkUploadResultUser":
					return new KalturaBulkUploadResultUser(xmlElement);
				case "KalturaBulkUploadUserData":
					return new KalturaBulkUploadUserData(xmlElement);
				case "KalturaCaptureThumbJobData":
					return new KalturaCaptureThumbJobData(xmlElement);
				case "KalturaCategoryBaseFilter":
					return new KalturaCategoryBaseFilter(xmlElement);
				case "KalturaCategoryEntryAdvancedFilter":
					return new KalturaCategoryEntryAdvancedFilter(xmlElement);
				case "KalturaCategoryEntryBaseFilter":
					return new KalturaCategoryEntryBaseFilter(xmlElement);
				case "KalturaCategoryIdentifier":
					return new KalturaCategoryIdentifier(xmlElement);
				case "KalturaCategoryUserAdvancedFilter":
					return new KalturaCategoryUserAdvancedFilter(xmlElement);
				case "KalturaCategoryUserBaseFilter":
					return new KalturaCategoryUserBaseFilter(xmlElement);
				case "KalturaCategoryUserProviderFilter":
					return new KalturaCategoryUserProviderFilter(xmlElement);
				case "KalturaClipAttributes":
					return new KalturaClipAttributes(xmlElement);
				case "KalturaCodeCuePoint":
					return new KalturaCodeCuePoint(xmlElement);
				case "KalturaCompareCondition":
					return new KalturaCompareCondition(xmlElement);
				case "KalturaConfigurableDistributionJobProviderData":
					return new KalturaConfigurableDistributionJobProviderData(xmlElement);
				case "KalturaConfigurableDistributionProfile":
					return new KalturaConfigurableDistributionProfile(xmlElement);
				case "KalturaContentDistributionSearchItem":
					return new KalturaContentDistributionSearchItem(xmlElement);
				case "KalturaControlPanelCommandBaseFilter":
					return new KalturaControlPanelCommandBaseFilter(xmlElement);
				case "KalturaConvartableJobData":
					return new KalturaConvartableJobData(xmlElement);
				case "KalturaConversionProfileAssetParamsBaseFilter":
					return new KalturaConversionProfileAssetParamsBaseFilter(xmlElement);
				case "KalturaConversionProfileBaseFilter":
					return new KalturaConversionProfileBaseFilter(xmlElement);
				case "KalturaConvertProfileJobData":
					return new KalturaConvertProfileJobData(xmlElement);
				case "KalturaCountryRestriction":
					return new KalturaCountryRestriction(xmlElement);
				case "KalturaCuePointBaseFilter":
					return new KalturaCuePointBaseFilter(xmlElement);
				case "KalturaDeleteFileJobData":
					return new KalturaDeleteFileJobData(xmlElement);
				case "KalturaDeleteJobData":
					return new KalturaDeleteJobData(xmlElement);
				case "KalturaDirectoryRestriction":
					return new KalturaDirectoryRestriction(xmlElement);
				case "KalturaDistributionJobData":
					return new KalturaDistributionJobData(xmlElement);
				case "KalturaDistributionProfileBaseFilter":
					return new KalturaDistributionProfileBaseFilter(xmlElement);
				case "KalturaDistributionProviderBaseFilter":
					return new KalturaDistributionProviderBaseFilter(xmlElement);
				case "KalturaDistributionValidationErrorInvalidData":
					return new KalturaDistributionValidationErrorInvalidData(xmlElement);
				case "KalturaDistributionValidationErrorMissingAsset":
					return new KalturaDistributionValidationErrorMissingAsset(xmlElement);
				case "KalturaDistributionValidationErrorMissingFlavor":
					return new KalturaDistributionValidationErrorMissingFlavor(xmlElement);
				case "KalturaDistributionValidationErrorMissingMetadata":
					return new KalturaDistributionValidationErrorMissingMetadata(xmlElement);
				case "KalturaDistributionValidationErrorMissingThumbnail":
					return new KalturaDistributionValidationErrorMissingThumbnail(xmlElement);
				case "KalturaDropFolderBaseFilter":
					return new KalturaDropFolderBaseFilter(xmlElement);
				case "KalturaDropFolderContentFileHandlerConfig":
					return new KalturaDropFolderContentFileHandlerConfig(xmlElement);
				case "KalturaDropFolderContentProcessorJobData":
					return new KalturaDropFolderContentProcessorJobData(xmlElement);
				case "KalturaDropFolderFileBaseFilter":
					return new KalturaDropFolderFileBaseFilter(xmlElement);
				case "KalturaDropFolderXmlBulkUploadFileHandlerConfig":
					return new KalturaDropFolderXmlBulkUploadFileHandlerConfig(xmlElement);
				case "KalturaCategoryUserFilter":
					return new KalturaCategoryUserFilter(xmlElement);
				case "KalturaEmailNotificationCategoryRecipientJobData":
					return new KalturaEmailNotificationCategoryRecipientJobData(xmlElement);
				case "KalturaEmailNotificationCategoryRecipientProvider":
					return new KalturaEmailNotificationCategoryRecipientProvider(xmlElement);
				case "KalturaEmailNotificationParameter":
					return new KalturaEmailNotificationParameter(xmlElement);
				case "KalturaEmailNotificationStaticRecipientJobData":
					return new KalturaEmailNotificationStaticRecipientJobData(xmlElement);
				case "KalturaEmailNotificationStaticRecipientProvider":
					return new KalturaEmailNotificationStaticRecipientProvider(xmlElement);
				case "KalturaEmailNotificationTemplate":
					return new KalturaEmailNotificationTemplate(xmlElement);
				case "KalturaUserBaseFilter":
					return new KalturaUserBaseFilter(xmlElement);
				case "KalturaUserFilter":
					return new KalturaUserFilter(xmlElement);
				case "KalturaEmailNotificationUserRecipientJobData":
					return new KalturaEmailNotificationUserRecipientJobData(xmlElement);
				case "KalturaEmailNotificationUserRecipientProvider":
					return new KalturaEmailNotificationUserRecipientProvider(xmlElement);
				case "KalturaEntryContext":
					return new KalturaEntryContext(xmlElement);
				case "KalturaEntryContextDataParams":
					return new KalturaEntryContextDataParams(xmlElement);
				case "KalturaEntryDistributionBaseFilter":
					return new KalturaEntryDistributionBaseFilter(xmlElement);
				case "KalturaEntryIdentifier":
					return new KalturaEntryIdentifier(xmlElement);
				case "KalturaBooleanField":
					return new KalturaBooleanField(xmlElement);
				case "KalturaEventFieldCondition":
					return new KalturaEventFieldCondition(xmlElement);
				case "KalturaEventNotificationArrayParameter":
					return new KalturaEventNotificationArrayParameter(xmlElement);
				case "KalturaEventNotificationDispatchJobData":
					return new KalturaEventNotificationDispatchJobData(xmlElement);
				case "KalturaEventNotificationTemplateBaseFilter":
					return new KalturaEventNotificationTemplateBaseFilter(xmlElement);
				case "KalturaEventObjectChangedCondition":
					return new KalturaEventObjectChangedCondition(xmlElement);
				case "KalturaFileSyncBaseFilter":
					return new KalturaFileSyncBaseFilter(xmlElement);
				case "KalturaFileSyncImportJobData":
					return new KalturaFileSyncImportJobData(xmlElement);
				case "KalturaFlattenJobData":
					return new KalturaFlattenJobData(xmlElement);
				case "KalturaGenericDistributionJobProviderData":
					return new KalturaGenericDistributionJobProviderData(xmlElement);
				case "KalturaGenericDistributionProfile":
					return new KalturaGenericDistributionProfile(xmlElement);
				case "KalturaGenericDistributionProviderActionBaseFilter":
					return new KalturaGenericDistributionProviderActionBaseFilter(xmlElement);
				case "KalturaGenericSyndicationFeed":
					return new KalturaGenericSyndicationFeed(xmlElement);
				case "KalturaGoogleVideoSyndicationFeed":
					return new KalturaGoogleVideoSyndicationFeed(xmlElement);
				case "KalturaHttpNotificationDataFields":
					return new KalturaHttpNotificationDataFields(xmlElement);
				case "KalturaHttpNotificationDataText":
					return new KalturaHttpNotificationDataText(xmlElement);
				case "KalturaHttpNotificationObjectData":
					return new KalturaHttpNotificationObjectData(xmlElement);
				case "KalturaHttpNotificationTemplate":
					return new KalturaHttpNotificationTemplate(xmlElement);
				case "KalturaITunesSyndicationFeed":
					return new KalturaITunesSyndicationFeed(xmlElement);
				case "KalturaImportJobData":
					return new KalturaImportJobData(xmlElement);
				case "KalturaImportMetadataJobData":
					return new KalturaImportMetadataJobData(xmlElement);
				case "KalturaIndexAdvancedFilter":
					return new KalturaIndexAdvancedFilter(xmlElement);
				case "KalturaIndexJobData":
					return new KalturaIndexJobData(xmlElement);
				case "KalturaIndexTagsByPrivacyContextJobData":
					return new KalturaIndexTagsByPrivacyContextJobData(xmlElement);
				case "KalturaIpAddressRestriction":
					return new KalturaIpAddressRestriction(xmlElement);
				case "KalturaKontikiStorageProfile":
					return new KalturaKontikiStorageProfile(xmlElement);
				case "KalturaLimitFlavorsRestriction":
					return new KalturaLimitFlavorsRestriction(xmlElement);
				case "KalturaMailJobData":
					return new KalturaMailJobData(xmlElement);
				case "KalturaMatchCondition":
					return new KalturaMatchCondition(xmlElement);
				case "KalturaMediaInfoBaseFilter":
					return new KalturaMediaInfoBaseFilter(xmlElement);
				case "KalturaMetadataBaseFilter":
					return new KalturaMetadataBaseFilter(xmlElement);
				case "KalturaMetadataProfileBaseFilter":
					return new KalturaMetadataProfileBaseFilter(xmlElement);
				case "KalturaMoveCategoryEntriesJobData":
					return new KalturaMoveCategoryEntriesJobData(xmlElement);
				case "KalturaNotificationJobData":
					return new KalturaNotificationJobData(xmlElement);
				case "KalturaParseCaptionAssetJobData":
					return new KalturaParseCaptionAssetJobData(xmlElement);
				case "KalturaPartnerBaseFilter":
					return new KalturaPartnerBaseFilter(xmlElement);
				case "KalturaPermissionBaseFilter":
					return new KalturaPermissionBaseFilter(xmlElement);
				case "KalturaPermissionItemBaseFilter":
					return new KalturaPermissionItemBaseFilter(xmlElement);
				case "KalturaProvisionJobData":
					return new KalturaProvisionJobData(xmlElement);
				case "KalturaRemoteDropFolder":
					return new KalturaRemoteDropFolder(xmlElement);
				case "KalturaReportBaseFilter":
					return new KalturaReportBaseFilter(xmlElement);
				case "KalturaReportInputFilter":
					return new KalturaReportInputFilter(xmlElement);
				case "KalturaSearchCondition":
					return new KalturaSearchCondition(xmlElement);
				case "KalturaSearchOperator":
					return new KalturaSearchOperator(xmlElement);
				case "KalturaSessionRestriction":
					return new KalturaSessionRestriction(xmlElement);
				case "KalturaShortLinkBaseFilter":
					return new KalturaShortLinkBaseFilter(xmlElement);
				case "KalturaSiteRestriction":
					return new KalturaSiteRestriction(xmlElement);
				case "KalturaStorageJobData":
					return new KalturaStorageJobData(xmlElement);
				case "KalturaStorageProfileBaseFilter":
					return new KalturaStorageProfileBaseFilter(xmlElement);
				case "KalturaSyndicationDistributionProfile":
					return new KalturaSyndicationDistributionProfile(xmlElement);
				case "KalturaSyndicationDistributionProvider":
					return new KalturaSyndicationDistributionProvider(xmlElement);
				case "KalturaTagFilter":
					return new KalturaTagFilter(xmlElement);
				case "KalturaTransformMetadataJobData":
					return new KalturaTransformMetadataJobData(xmlElement);
				case "KalturaTubeMogulSyndicationFeed":
					return new KalturaTubeMogulSyndicationFeed(xmlElement);
				case "KalturaUiConfBaseFilter":
					return new KalturaUiConfBaseFilter(xmlElement);
				case "KalturaUploadTokenBaseFilter":
					return new KalturaUploadTokenBaseFilter(xmlElement);
				case "KalturaUserAgentRestriction":
					return new KalturaUserAgentRestriction(xmlElement);
				case "KalturaUserLoginDataBaseFilter":
					return new KalturaUserLoginDataBaseFilter(xmlElement);
				case "KalturaUserRoleBaseFilter":
					return new KalturaUserRoleBaseFilter(xmlElement);
				case "KalturaVarPartnerUsageTotalItem":
					return new KalturaVarPartnerUsageTotalItem(xmlElement);
				case "KalturaVirusScanJobData":
					return new KalturaVirusScanJobData(xmlElement);
				case "KalturaVirusScanProfileBaseFilter":
					return new KalturaVirusScanProfileBaseFilter(xmlElement);
				case "KalturaWidevineRepositorySyncJobData":
					return new KalturaWidevineRepositorySyncJobData(xmlElement);
				case "KalturaWidgetBaseFilter":
					return new KalturaWidgetBaseFilter(xmlElement);
				case "KalturaYahooSyndicationFeed":
					return new KalturaYahooSyndicationFeed(xmlElement);
				case "KalturaAccessControlFilter":
					return new KalturaAccessControlFilter(xmlElement);
				case "KalturaAccessControlProfileFilter":
					return new KalturaAccessControlProfileFilter(xmlElement);
				case "KalturaAkamaiProvisionJobData":
					return new KalturaAkamaiProvisionJobData(xmlElement);
				case "KalturaAkamaiUniversalProvisionJobData":
					return new KalturaAkamaiUniversalProvisionJobData(xmlElement);
				case "KalturaAssetFilter":
					return new KalturaAssetFilter(xmlElement);
				case "KalturaAssetParamsFilter":
					return new KalturaAssetParamsFilter(xmlElement);
				case "KalturaAssetResource":
					return new KalturaAssetResource(xmlElement);
				case "KalturaAuditTrailFilter":
					return new KalturaAuditTrailFilter(xmlElement);
				case "KalturaBaseSyndicationFeedFilter":
					return new KalturaBaseSyndicationFeedFilter(xmlElement);
				case "KalturaBulkUploadCsvJobData":
					return new KalturaBulkUploadCsvJobData(xmlElement);
				case "KalturaBulkUploadFilter":
					return new KalturaBulkUploadFilter(xmlElement);
				case "KalturaBulkUploadXmlJobData":
					return new KalturaBulkUploadXmlJobData(xmlElement);
				case "KalturaCategoryEntryFilter":
					return new KalturaCategoryEntryFilter(xmlElement);
				case "KalturaCategoryFilter":
					return new KalturaCategoryFilter(xmlElement);
				case "KalturaCompareMetadataCondition":
					return new KalturaCompareMetadataCondition(xmlElement);
				case "KalturaControlPanelCommandFilter":
					return new KalturaControlPanelCommandFilter(xmlElement);
				case "KalturaConversionProfileFilter":
					return new KalturaConversionProfileFilter(xmlElement);
				case "KalturaConversionProfileAssetParamsFilter":
					return new KalturaConversionProfileAssetParamsFilter(xmlElement);
				case "KalturaConvertCollectionJobData":
					return new KalturaConvertCollectionJobData(xmlElement);
				case "KalturaConvertJobData":
					return new KalturaConvertJobData(xmlElement);
				case "KalturaCountryCondition":
					return new KalturaCountryCondition(xmlElement);
				case "KalturaCuePointFilter":
					return new KalturaCuePointFilter(xmlElement);
				case "KalturaDataCenterContentResource":
					return new KalturaDataCenterContentResource(xmlElement);
				case "KalturaDistributionDeleteJobData":
					return new KalturaDistributionDeleteJobData(xmlElement);
				case "KalturaDistributionFetchReportJobData":
					return new KalturaDistributionFetchReportJobData(xmlElement);
				case "KalturaDistributionProfileFilter":
					return new KalturaDistributionProfileFilter(xmlElement);
				case "KalturaDistributionProviderFilter":
					return new KalturaDistributionProviderFilter(xmlElement);
				case "KalturaDistributionSubmitJobData":
					return new KalturaDistributionSubmitJobData(xmlElement);
				case "KalturaDistributionUpdateJobData":
					return new KalturaDistributionUpdateJobData(xmlElement);
				case "KalturaDistributionValidationErrorInvalidMetadata":
					return new KalturaDistributionValidationErrorInvalidMetadata(xmlElement);
				case "KalturaDocumentFlavorParams":
					return new KalturaDocumentFlavorParams(xmlElement);
				case "KalturaDropFolderFileFilter":
					return new KalturaDropFolderFileFilter(xmlElement);
				case "KalturaDropFolderFilter":
					return new KalturaDropFolderFilter(xmlElement);
				case "KalturaEmailNotificationDispatchJobData":
					return new KalturaEmailNotificationDispatchJobData(xmlElement);
				case "KalturaEndUserReportInputFilter":
					return new KalturaEndUserReportInputFilter(xmlElement);
				case "KalturaEntryDistributionFilter":
					return new KalturaEntryDistributionFilter(xmlElement);
				case "KalturaEntryResource":
					return new KalturaEntryResource(xmlElement);
				case "KalturaEventNotificationTemplateFilter":
					return new KalturaEventNotificationTemplateFilter(xmlElement);
				case "KalturaExtractMediaJobData":
					return new KalturaExtractMediaJobData(xmlElement);
				case "KalturaIntegerField":
					return new KalturaIntegerField(xmlElement);
				case "KalturaFieldCompareCondition":
					return new KalturaFieldCompareCondition(xmlElement);
				case "KalturaStringField":
					return new KalturaStringField(xmlElement);
				case "KalturaFieldMatchCondition":
					return new KalturaFieldMatchCondition(xmlElement);
				case "KalturaFileSyncFilter":
					return new KalturaFileSyncFilter(xmlElement);
				case "KalturaFileSyncResource":
					return new KalturaFileSyncResource(xmlElement);
				case "KalturaFtpDropFolder":
					return new KalturaFtpDropFolder(xmlElement);
				case "KalturaGenericDistributionProviderActionFilter":
					return new KalturaGenericDistributionProviderActionFilter(xmlElement);
				case "KalturaGenericXsltSyndicationFeed":
					return new KalturaGenericXsltSyndicationFeed(xmlElement);
				case "KalturaHttpNotificationDispatchJobData":
					return new KalturaHttpNotificationDispatchJobData(xmlElement);
				case "KalturaImageFlavorParams":
					return new KalturaImageFlavorParams(xmlElement);
				case "KalturaIpAddressCondition":
					return new KalturaIpAddressCondition(xmlElement);
				case "KalturaLiveAsset":
					return new KalturaLiveAsset(xmlElement);
				case "KalturaLiveParams":
					return new KalturaLiveParams(xmlElement);
				case "KalturaMatchMetadataCondition":
					return new KalturaMatchMetadataCondition(xmlElement);
				case "KalturaMediaFlavorParams":
					return new KalturaMediaFlavorParams(xmlElement);
				case "KalturaMediaInfoFilter":
					return new KalturaMediaInfoFilter(xmlElement);
				case "KalturaMetadataFieldChangedCondition":
					return new KalturaMetadataFieldChangedCondition(xmlElement);
				case "KalturaMetadataFilter":
					return new KalturaMetadataFilter(xmlElement);
				case "KalturaMetadataProfileFilter":
					return new KalturaMetadataProfileFilter(xmlElement);
				case "KalturaMetadataSearchItem":
					return new KalturaMetadataSearchItem(xmlElement);
				case "KalturaOperationResource":
					return new KalturaOperationResource(xmlElement);
				case "KalturaPartnerFilter":
					return new KalturaPartnerFilter(xmlElement);
				case "KalturaPdfFlavorParams":
					return new KalturaPdfFlavorParams(xmlElement);
				case "KalturaPermissionFilter":
					return new KalturaPermissionFilter(xmlElement);
				case "KalturaPermissionItemFilter":
					return new KalturaPermissionItemFilter(xmlElement);
				case "KalturaPostConvertJobData":
					return new KalturaPostConvertJobData(xmlElement);
				case "KalturaPreviewRestriction":
					return new KalturaPreviewRestriction(xmlElement);
				case "KalturaRegexCondition":
					return new KalturaRegexCondition(xmlElement);
				case "KalturaRemoteStorageResources":
					return new KalturaRemoteStorageResources(xmlElement);
				case "KalturaReportFilter":
					return new KalturaReportFilter(xmlElement);
				case "KalturaSearchComparableCondition":
					return new KalturaSearchComparableCondition(xmlElement);
				case "KalturaShortLinkFilter":
					return new KalturaShortLinkFilter(xmlElement);
				case "KalturaSiteCondition":
					return new KalturaSiteCondition(xmlElement);
				case "KalturaSshDropFolder":
					return new KalturaSshDropFolder(xmlElement);
				case "KalturaSshImportJobData":
					return new KalturaSshImportJobData(xmlElement);
				case "KalturaStorageDeleteJobData":
					return new KalturaStorageDeleteJobData(xmlElement);
				case "KalturaStorageExportJobData":
					return new KalturaStorageExportJobData(xmlElement);
				case "KalturaStorageProfileFilter":
					return new KalturaStorageProfileFilter(xmlElement);
				case "KalturaStringResource":
					return new KalturaStringResource(xmlElement);
				case "KalturaSwfFlavorParams":
					return new KalturaSwfFlavorParams(xmlElement);
				case "KalturaUiConfFilter":
					return new KalturaUiConfFilter(xmlElement);
				case "KalturaUploadTokenFilter":
					return new KalturaUploadTokenFilter(xmlElement);
				case "KalturaUserLoginDataFilter":
					return new KalturaUserLoginDataFilter(xmlElement);
				case "KalturaUserRoleFilter":
					return new KalturaUserRoleFilter(xmlElement);
				case "KalturaVelocixProvisionJobData":
					return new KalturaVelocixProvisionJobData(xmlElement);
				case "KalturaVirusScanProfileFilter":
					return new KalturaVirusScanProfileFilter(xmlElement);
				case "KalturaWidevineFlavorAsset":
					return new KalturaWidevineFlavorAsset(xmlElement);
				case "KalturaWidevineFlavorParams":
					return new KalturaWidevineFlavorParams(xmlElement);
				case "KalturaWidgetFilter":
					return new KalturaWidgetFilter(xmlElement);
				case "KalturaAdCuePointBaseFilter":
					return new KalturaAdCuePointBaseFilter(xmlElement);
				case "KalturaAdminUserBaseFilter":
					return new KalturaAdminUserBaseFilter(xmlElement);
				case "KalturaAmazonS3StorageExportJobData":
					return new KalturaAmazonS3StorageExportJobData(xmlElement);
				case "KalturaAmazonS3StorageProfileBaseFilter":
					return new KalturaAmazonS3StorageProfileBaseFilter(xmlElement);
				case "KalturaAnnotationBaseFilter":
					return new KalturaAnnotationBaseFilter(xmlElement);
				case "KalturaApiActionPermissionItemBaseFilter":
					return new KalturaApiActionPermissionItemBaseFilter(xmlElement);
				case "KalturaApiParameterPermissionItemBaseFilter":
					return new KalturaApiParameterPermissionItemBaseFilter(xmlElement);
				case "KalturaAssetParamsOutputBaseFilter":
					return new KalturaAssetParamsOutputBaseFilter(xmlElement);
				case "KalturaAttachmentAssetBaseFilter":
					return new KalturaAttachmentAssetBaseFilter(xmlElement);
				case "KalturaBatchJobFilterExt":
					return new KalturaBatchJobFilterExt(xmlElement);
				case "KalturaCaptionAssetBaseFilter":
					return new KalturaCaptionAssetBaseFilter(xmlElement);
				case "KalturaCaptionParamsBaseFilter":
					return new KalturaCaptionParamsBaseFilter(xmlElement);
				case "KalturaCodeCuePointBaseFilter":
					return new KalturaCodeCuePointBaseFilter(xmlElement);
				case "KalturaConfigurableDistributionProfileBaseFilter":
					return new KalturaConfigurableDistributionProfileBaseFilter(xmlElement);
				case "KalturaCountryContextField":
					return new KalturaCountryContextField(xmlElement);
				case "KalturaDataEntryBaseFilter":
					return new KalturaDataEntryBaseFilter(xmlElement);
				case "KalturaDistributionDisableJobData":
					return new KalturaDistributionDisableJobData(xmlElement);
				case "KalturaDistributionEnableJobData":
					return new KalturaDistributionEnableJobData(xmlElement);
				case "KalturaDocumentEntryBaseFilter":
					return new KalturaDocumentEntryBaseFilter(xmlElement);
				case "KalturaDocumentFlavorParamsOutput":
					return new KalturaDocumentFlavorParamsOutput(xmlElement);
				case "KalturaDropFolderFileResource":
					return new KalturaDropFolderFileResource(xmlElement);
				case "KalturaDropFolderImportJobData":
					return new KalturaDropFolderImportJobData(xmlElement);
				case "KalturaEmailNotificationTemplateBaseFilter":
					return new KalturaEmailNotificationTemplateBaseFilter(xmlElement);
				case "KalturaEvalBooleanField":
					return new KalturaEvalBooleanField(xmlElement);
				case "KalturaEvalStringField":
					return new KalturaEvalStringField(xmlElement);
				case "KalturaFlavorAssetBaseFilter":
					return new KalturaFlavorAssetBaseFilter(xmlElement);
				case "KalturaFlavorParamsBaseFilter":
					return new KalturaFlavorParamsBaseFilter(xmlElement);
				case "KalturaGenericDistributionProfileBaseFilter":
					return new KalturaGenericDistributionProfileBaseFilter(xmlElement);
				case "KalturaGenericDistributionProviderBaseFilter":
					return new KalturaGenericDistributionProviderBaseFilter(xmlElement);
				case "KalturaGenericSyndicationFeedBaseFilter":
					return new KalturaGenericSyndicationFeedBaseFilter(xmlElement);
				case "KalturaGoogleVideoSyndicationFeedBaseFilter":
					return new KalturaGoogleVideoSyndicationFeedBaseFilter(xmlElement);
				case "KalturaHttpNotificationTemplateBaseFilter":
					return new KalturaHttpNotificationTemplateBaseFilter(xmlElement);
				case "KalturaITunesSyndicationFeedBaseFilter":
					return new KalturaITunesSyndicationFeedBaseFilter(xmlElement);
				case "KalturaImageFlavorParamsOutput":
					return new KalturaImageFlavorParamsOutput(xmlElement);
				case "KalturaIpAddressContextField":
					return new KalturaIpAddressContextField(xmlElement);
				case "KalturaKontikiStorageDeleteJobData":
					return new KalturaKontikiStorageDeleteJobData(xmlElement);
				case "KalturaKontikiStorageExportJobData":
					return new KalturaKontikiStorageExportJobData(xmlElement);
				case "KalturaKontikiStorageProfileBaseFilter":
					return new KalturaKontikiStorageProfileBaseFilter(xmlElement);
				case "KalturaMediaFlavorParamsOutput":
					return new KalturaMediaFlavorParamsOutput(xmlElement);
				case "KalturaObjectIdField":
					return new KalturaObjectIdField(xmlElement);
				case "KalturaPdfFlavorParamsOutput":
					return new KalturaPdfFlavorParamsOutput(xmlElement);
				case "KalturaPlaylistBaseFilter":
					return new KalturaPlaylistBaseFilter(xmlElement);
				case "KalturaRemoteDropFolderBaseFilter":
					return new KalturaRemoteDropFolderBaseFilter(xmlElement);
				case "KalturaScpDropFolder":
					return new KalturaScpDropFolder(xmlElement);
				case "KalturaServerFileResource":
					return new KalturaServerFileResource(xmlElement);
				case "KalturaSftpDropFolder":
					return new KalturaSftpDropFolder(xmlElement);
				case "KalturaSshUrlResource":
					return new KalturaSshUrlResource(xmlElement);
				case "KalturaSwfFlavorParamsOutput":
					return new KalturaSwfFlavorParamsOutput(xmlElement);
				case "KalturaSyndicationDistributionProfileBaseFilter":
					return new KalturaSyndicationDistributionProfileBaseFilter(xmlElement);
				case "KalturaSyndicationDistributionProviderBaseFilter":
					return new KalturaSyndicationDistributionProviderBaseFilter(xmlElement);
				case "KalturaThumbAssetBaseFilter":
					return new KalturaThumbAssetBaseFilter(xmlElement);
				case "KalturaThumbParamsBaseFilter":
					return new KalturaThumbParamsBaseFilter(xmlElement);
				case "KalturaTimeContextField":
					return new KalturaTimeContextField(xmlElement);
				case "KalturaTubeMogulSyndicationFeedBaseFilter":
					return new KalturaTubeMogulSyndicationFeedBaseFilter(xmlElement);
				case "KalturaUploadedFileTokenResource":
					return new KalturaUploadedFileTokenResource(xmlElement);
				case "KalturaUserAgentCondition":
					return new KalturaUserAgentCondition(xmlElement);
				case "KalturaUserAgentContextField":
					return new KalturaUserAgentContextField(xmlElement);
				case "KalturaUserEmailContextField":
					return new KalturaUserEmailContextField(xmlElement);
				case "KalturaVarConsolePartnerFilter":
					return new KalturaVarConsolePartnerFilter(xmlElement);
				case "KalturaWebcamTokenResource":
					return new KalturaWebcamTokenResource(xmlElement);
				case "KalturaWidevineFlavorParamsOutput":
					return new KalturaWidevineFlavorParamsOutput(xmlElement);
				case "KalturaYahooSyndicationFeedBaseFilter":
					return new KalturaYahooSyndicationFeedBaseFilter(xmlElement);
				case "KalturaAdCuePointFilter":
					return new KalturaAdCuePointFilter(xmlElement);
				case "KalturaAdminUserFilter":
					return new KalturaAdminUserFilter(xmlElement);
				case "KalturaAmazonS3StorageProfileFilter":
					return new KalturaAmazonS3StorageProfileFilter(xmlElement);
				case "KalturaAnnotationFilter":
					return new KalturaAnnotationFilter(xmlElement);
				case "KalturaApiActionPermissionItemFilter":
					return new KalturaApiActionPermissionItemFilter(xmlElement);
				case "KalturaApiParameterPermissionItemFilter":
					return new KalturaApiParameterPermissionItemFilter(xmlElement);
				case "KalturaAssetParamsOutputFilter":
					return new KalturaAssetParamsOutputFilter(xmlElement);
				case "KalturaAttachmentAssetFilter":
					return new KalturaAttachmentAssetFilter(xmlElement);
				case "KalturaCaptionAssetFilter":
					return new KalturaCaptionAssetFilter(xmlElement);
				case "KalturaCaptionParamsFilter":
					return new KalturaCaptionParamsFilter(xmlElement);
				case "KalturaCodeCuePointFilter":
					return new KalturaCodeCuePointFilter(xmlElement);
				case "KalturaConfigurableDistributionProfileFilter":
					return new KalturaConfigurableDistributionProfileFilter(xmlElement);
				case "KalturaDataEntryFilter":
					return new KalturaDataEntryFilter(xmlElement);
				case "KalturaDocumentEntryFilter":
					return new KalturaDocumentEntryFilter(xmlElement);
				case "KalturaEmailNotificationTemplateFilter":
					return new KalturaEmailNotificationTemplateFilter(xmlElement);
				case "KalturaFlavorAssetFilter":
					return new KalturaFlavorAssetFilter(xmlElement);
				case "KalturaFlavorParamsFilter":
					return new KalturaFlavorParamsFilter(xmlElement);
				case "KalturaGenericDistributionProfileFilter":
					return new KalturaGenericDistributionProfileFilter(xmlElement);
				case "KalturaGenericDistributionProviderFilter":
					return new KalturaGenericDistributionProviderFilter(xmlElement);
				case "KalturaGenericSyndicationFeedFilter":
					return new KalturaGenericSyndicationFeedFilter(xmlElement);
				case "KalturaGoogleVideoSyndicationFeedFilter":
					return new KalturaGoogleVideoSyndicationFeedFilter(xmlElement);
				case "KalturaHttpNotificationTemplateFilter":
					return new KalturaHttpNotificationTemplateFilter(xmlElement);
				case "KalturaITunesSyndicationFeedFilter":
					return new KalturaITunesSyndicationFeedFilter(xmlElement);
				case "KalturaKontikiStorageProfileFilter":
					return new KalturaKontikiStorageProfileFilter(xmlElement);
				case "KalturaLiveStreamAdminEntry":
					return new KalturaLiveStreamAdminEntry(xmlElement);
				case "KalturaPlaylistFilter":
					return new KalturaPlaylistFilter(xmlElement);
				case "KalturaRemoteDropFolderFilter":
					return new KalturaRemoteDropFolderFilter(xmlElement);
				case "KalturaSyndicationDistributionProfileFilter":
					return new KalturaSyndicationDistributionProfileFilter(xmlElement);
				case "KalturaSyndicationDistributionProviderFilter":
					return new KalturaSyndicationDistributionProviderFilter(xmlElement);
				case "KalturaThumbAssetFilter":
					return new KalturaThumbAssetFilter(xmlElement);
				case "KalturaThumbParamsFilter":
					return new KalturaThumbParamsFilter(xmlElement);
				case "KalturaTubeMogulSyndicationFeedFilter":
					return new KalturaTubeMogulSyndicationFeedFilter(xmlElement);
				case "KalturaYahooSyndicationFeedFilter":
					return new KalturaYahooSyndicationFeedFilter(xmlElement);
				case "KalturaCaptionAssetItemFilter":
					return new KalturaCaptionAssetItemFilter(xmlElement);
				case "KalturaDocumentFlavorParamsBaseFilter":
					return new KalturaDocumentFlavorParamsBaseFilter(xmlElement);
				case "KalturaFlavorParamsOutputBaseFilter":
					return new KalturaFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaFtpDropFolderBaseFilter":
					return new KalturaFtpDropFolderBaseFilter(xmlElement);
				case "KalturaGenericXsltSyndicationFeedBaseFilter":
					return new KalturaGenericXsltSyndicationFeedBaseFilter(xmlElement);
				case "KalturaImageFlavorParamsBaseFilter":
					return new KalturaImageFlavorParamsBaseFilter(xmlElement);
				case "KalturaLiveAssetBaseFilter":
					return new KalturaLiveAssetBaseFilter(xmlElement);
				case "KalturaLiveParamsBaseFilter":
					return new KalturaLiveParamsBaseFilter(xmlElement);
				case "KalturaMediaFlavorParamsBaseFilter":
					return new KalturaMediaFlavorParamsBaseFilter(xmlElement);
				case "KalturaMixEntryBaseFilter":
					return new KalturaMixEntryBaseFilter(xmlElement);
				case "KalturaPdfFlavorParamsBaseFilter":
					return new KalturaPdfFlavorParamsBaseFilter(xmlElement);
				case "KalturaSshDropFolderBaseFilter":
					return new KalturaSshDropFolderBaseFilter(xmlElement);
				case "KalturaSwfFlavorParamsBaseFilter":
					return new KalturaSwfFlavorParamsBaseFilter(xmlElement);
				case "KalturaThumbParamsOutputBaseFilter":
					return new KalturaThumbParamsOutputBaseFilter(xmlElement);
				case "KalturaWidevineFlavorAssetBaseFilter":
					return new KalturaWidevineFlavorAssetBaseFilter(xmlElement);
				case "KalturaWidevineFlavorParamsBaseFilter":
					return new KalturaWidevineFlavorParamsBaseFilter(xmlElement);
				case "KalturaDocumentFlavorParamsFilter":
					return new KalturaDocumentFlavorParamsFilter(xmlElement);
				case "KalturaFlavorParamsOutputFilter":
					return new KalturaFlavorParamsOutputFilter(xmlElement);
				case "KalturaFtpDropFolderFilter":
					return new KalturaFtpDropFolderFilter(xmlElement);
				case "KalturaGenericXsltSyndicationFeedFilter":
					return new KalturaGenericXsltSyndicationFeedFilter(xmlElement);
				case "KalturaImageFlavorParamsFilter":
					return new KalturaImageFlavorParamsFilter(xmlElement);
				case "KalturaLiveAssetFilter":
					return new KalturaLiveAssetFilter(xmlElement);
				case "KalturaLiveParamsFilter":
					return new KalturaLiveParamsFilter(xmlElement);
				case "KalturaMediaFlavorParamsFilter":
					return new KalturaMediaFlavorParamsFilter(xmlElement);
				case "KalturaMixEntryFilter":
					return new KalturaMixEntryFilter(xmlElement);
				case "KalturaPdfFlavorParamsFilter":
					return new KalturaPdfFlavorParamsFilter(xmlElement);
				case "KalturaSshDropFolderFilter":
					return new KalturaSshDropFolderFilter(xmlElement);
				case "KalturaSwfFlavorParamsFilter":
					return new KalturaSwfFlavorParamsFilter(xmlElement);
				case "KalturaThumbParamsOutputFilter":
					return new KalturaThumbParamsOutputFilter(xmlElement);
				case "KalturaWidevineFlavorAssetFilter":
					return new KalturaWidevineFlavorAssetFilter(xmlElement);
				case "KalturaWidevineFlavorParamsFilter":
					return new KalturaWidevineFlavorParamsFilter(xmlElement);
				case "KalturaDocumentFlavorParamsOutputBaseFilter":
					return new KalturaDocumentFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaExternalMediaEntryBaseFilter":
					return new KalturaExternalMediaEntryBaseFilter(xmlElement);
				case "KalturaImageFlavorParamsOutputBaseFilter":
					return new KalturaImageFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaLiveStreamEntryBaseFilter":
					return new KalturaLiveStreamEntryBaseFilter(xmlElement);
				case "KalturaMediaFlavorParamsOutputBaseFilter":
					return new KalturaMediaFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaPdfFlavorParamsOutputBaseFilter":
					return new KalturaPdfFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaScpDropFolderBaseFilter":
					return new KalturaScpDropFolderBaseFilter(xmlElement);
				case "KalturaSftpDropFolderBaseFilter":
					return new KalturaSftpDropFolderBaseFilter(xmlElement);
				case "KalturaSwfFlavorParamsOutputBaseFilter":
					return new KalturaSwfFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaWidevineFlavorParamsOutputBaseFilter":
					return new KalturaWidevineFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaDocumentFlavorParamsOutputFilter":
					return new KalturaDocumentFlavorParamsOutputFilter(xmlElement);
				case "KalturaExternalMediaEntryFilter":
					return new KalturaExternalMediaEntryFilter(xmlElement);
				case "KalturaImageFlavorParamsOutputFilter":
					return new KalturaImageFlavorParamsOutputFilter(xmlElement);
				case "KalturaLiveStreamEntryFilter":
					return new KalturaLiveStreamEntryFilter(xmlElement);
				case "KalturaMediaFlavorParamsOutputFilter":
					return new KalturaMediaFlavorParamsOutputFilter(xmlElement);
				case "KalturaPdfFlavorParamsOutputFilter":
					return new KalturaPdfFlavorParamsOutputFilter(xmlElement);
				case "KalturaScpDropFolderFilter":
					return new KalturaScpDropFolderFilter(xmlElement);
				case "KalturaSftpDropFolderFilter":
					return new KalturaSftpDropFolderFilter(xmlElement);
				case "KalturaSwfFlavorParamsOutputFilter":
					return new KalturaSwfFlavorParamsOutputFilter(xmlElement);
				case "KalturaWidevineFlavorParamsOutputFilter":
					return new KalturaWidevineFlavorParamsOutputFilter(xmlElement);
				case "KalturaLiveStreamAdminEntryBaseFilter":
					return new KalturaLiveStreamAdminEntryBaseFilter(xmlElement);
				case "KalturaLiveStreamAdminEntryFilter":
					return new KalturaLiveStreamAdminEntryFilter(xmlElement);
			}
			throw new SerializationException("Invalid object type");
		}
	}
}
