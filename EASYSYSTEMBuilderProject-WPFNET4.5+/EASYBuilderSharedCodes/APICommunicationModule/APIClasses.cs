using System;
using System.Collections.Generic;

namespace GlobalNET.Api
{
    /// <summary>
    /// ALL standard View AND Form API Call must end with "List" - These will automatic added for reports Definitions
    /// </summary>
    public enum ApiUrls
    {
        GlobalNETAttachmentList,
        GlobalNETAddressList,
        Authentication,
        BackendCheck,
        GlobalNETBranchList,
        GlobalNETCalendar,
        GlobalNETCreditNoteList,
        GlobalNETCreditNoteItemList,
        GlobalNETCurrencyList,
        GlobalNETDocumentAdviceList,
        GlobalNETExchangeRateList,
        GlobalNETIncomingInvoiceList,
        GlobalNETIncomingInvoiceItemList,
        GlobalNETIncomingOrderList,
        GlobalNETIncomingOrderItemList,
        GlobalNETItemList,
        GlobalNETLicenseActivationFailList,
        GlobalNETLicenseAlgorithmList,
        GlobalNETLoginHistoryList,
        GlobalNETMaturityList,
        GlobalNETMottoList,
        GlobalNETNotesList,
        GlobalNETOfferList,
        GlobalNETOfferItemList,
        GlobalNETOutgoingInvoiceList,
        GlobalNETOutgoingInvoiceItemList,
        GlobalNETOutgoingOrderList,
        GlobalNETOutgoingOrderItemList,
        GlobalNETParameterList,
        GlobalNETPaymentMethodList,
        GlobalNETPaymentStatusList,
        GlobalNETReceiptList,
        GlobalNETReceiptItemList,
        GlobalNETReportQueueList,
        GlobalNETReportList,
        GlobalNETServerSetting,
        GlobalNETUnitList,
        GlobalNETUsedLicenseList,
        GlobalNETUserList,
        GlobalNETUserRoleList,
        GlobalNETVatList,
        GlobalNETWarehouseList,

        GlobalNETTemplateClassList
    }

    /// <summary>
    /// Definition of Result API calls for Insert / Update / Delete
    /// </summary>
    public class DBResultMessage
    {
        public int insertedId { get; set; } = 0;
        public string status { get; set; }
        public int recordCount { get; set; } = -1;
        public string ErrorMessage { get; set; }
    }
}



