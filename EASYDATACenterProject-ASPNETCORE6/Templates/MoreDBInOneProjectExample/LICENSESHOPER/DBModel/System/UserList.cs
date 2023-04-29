using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESHOPER.DBModel
{
    public partial class UserList
    {
        public UserList()
        {
            AddressLists = new HashSet<AddressList>();
            AttachmentLists = new HashSet<AttachmentList>();
            BranchLists = new HashSet<BranchList>();
            Calendars = new HashSet<Calendar>();
            CreditNoteItemLists = new HashSet<CreditNoteItemList>();
            CreditNoteLists = new HashSet<CreditNoteList>();
            CurrencyLists = new HashSet<CurrencyList>();
            DocumentAdviceLists = new HashSet<DocumentAdviceList>();
            ExchangeRateLists = new HashSet<ExchangeRateList>();
            IncomingInvoiceItemLists = new HashSet<IncomingInvoiceItemList>();
            IncomingInvoiceLists = new HashSet<IncomingInvoiceList>();
            IncomingOrderItemLists = new HashSet<IncomingOrderItemList>();
            IncomingOrderLists = new HashSet<IncomingOrderList>();
            ItemLists = new HashSet<ItemList>();
            LicenseAlgorithmLists = new HashSet<LicenseAlgorithmList>();
            MaturityLists = new HashSet<MaturityList>();
            NotesLists = new HashSet<NotesList>();
            OfferItemLists = new HashSet<OfferItemList>();
            OfferLists = new HashSet<OfferList>();
            OutgoingInvoiceItemLists = new HashSet<OutgoingInvoiceItemList>();
            OutgoingInvoiceLists = new HashSet<OutgoingInvoiceList>();
            OutgoingOrderItemLists = new HashSet<OutgoingOrderItemList>();
            OutgoingOrderLists = new HashSet<OutgoingOrderList>();
            ParameterLists = new HashSet<ParameterList>();
            PaymentMethodLists = new HashSet<PaymentMethodList>();
            PaymentStatusLists = new HashSet<PaymentStatusList>();
            ReceiptItemLists = new HashSet<ReceiptItemList>();
            ReceiptLists = new HashSet<ReceiptList>();
            ReportLists = new HashSet<ReportList>();
            TemplateLists = new HashSet<TemplateList>();
            UnitLists = new HashSet<UnitList>();
            VatLists = new HashSet<VatList>();
            WarehouseLists = new HashSet<WarehouseList>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Token { get; set; }
        public DateTime? Expiration { get; set; }
        public byte[]? Photo { get; set; }
        public string? MimeType { get; set; }
        public string? PhotoPath { get; set; }
        public bool SystemAdmin { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserRoleList Role { get; set; } = null!;
        public virtual ICollection<AddressList> AddressLists { get; set; }
        public virtual ICollection<AttachmentList> AttachmentLists { get; set; }
        public virtual ICollection<BranchList> BranchLists { get; set; }
        public virtual ICollection<Calendar> Calendars { get; set; }
        public virtual ICollection<CreditNoteItemList> CreditNoteItemLists { get; set; }
        public virtual ICollection<CreditNoteList> CreditNoteLists { get; set; }
        public virtual ICollection<CurrencyList> CurrencyLists { get; set; }
        public virtual ICollection<DocumentAdviceList> DocumentAdviceLists { get; set; }
        public virtual ICollection<ExchangeRateList> ExchangeRateLists { get; set; }
        public virtual ICollection<IncomingInvoiceItemList> IncomingInvoiceItemLists { get; set; }
        public virtual ICollection<IncomingInvoiceList> IncomingInvoiceLists { get; set; }
        public virtual ICollection<IncomingOrderItemList> IncomingOrderItemLists { get; set; }
        public virtual ICollection<IncomingOrderList> IncomingOrderLists { get; set; }
        public virtual ICollection<ItemList> ItemLists { get; set; }
        public virtual ICollection<LicenseAlgorithmList> LicenseAlgorithmLists { get; set; }
        public virtual ICollection<MaturityList> MaturityLists { get; set; }
        public virtual ICollection<NotesList> NotesLists { get; set; }
        public virtual ICollection<OfferItemList> OfferItemLists { get; set; }
        public virtual ICollection<OfferList> OfferLists { get; set; }
        public virtual ICollection<OutgoingInvoiceItemList> OutgoingInvoiceItemLists { get; set; }
        public virtual ICollection<OutgoingInvoiceList> OutgoingInvoiceLists { get; set; }
        public virtual ICollection<OutgoingOrderItemList> OutgoingOrderItemLists { get; set; }
        public virtual ICollection<OutgoingOrderList> OutgoingOrderLists { get; set; }
        public virtual ICollection<ParameterList> ParameterLists { get; set; }
        public virtual ICollection<PaymentMethodList> PaymentMethodLists { get; set; }
        public virtual ICollection<PaymentStatusList> PaymentStatusLists { get; set; }
        public virtual ICollection<ReceiptItemList> ReceiptItemLists { get; set; }
        public virtual ICollection<ReceiptList> ReceiptLists { get; set; }
        public virtual ICollection<ReportList> ReportLists { get; set; }
        public virtual ICollection<TemplateList> TemplateLists { get; set; }
        public virtual ICollection<UnitList> UnitLists { get; set; }
        public virtual ICollection<VatList> VatLists { get; set; }
        public virtual ICollection<WarehouseList> WarehouseLists { get; set; }
    }
}
