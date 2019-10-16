using System;
using System.Collections.Generic;
using System.Globalization;
using CyberSource.Api;
using CyberSource.Model;

namespace Cybersource_rest_samples_dotnet.Samples.Reporting
{
    public class CreateReportSubscription
    {
        public static void Run()
        {
            string reportDefinitionName = "TransactionRequestClass";

            List <string> reportFields = new List <string>();
            reportFields.Add("Request.RequestID");
            reportFields.Add("Request.TransactionDate");
            reportFields.Add("Request.MerchantID");
            reportFields.Add("AFSFields.IPAddress");
            reportFields.Add("AFSFields.IPCountry");
            reportFields.Add("AFSFields.IPRoutingMethod");
            reportFields.Add("AFSFields.IPState");
            reportFields.Add("Application.Name");
            reportFields.Add("BankInfo.Address");
            reportFields.Add("BankInfo.BranchCode");
            reportFields.Add("BankInfo.City");
            reportFields.Add("BankInfo.Country");
            reportFields.Add("BankInfo.Name");
            reportFields.Add("BankInfo.SwiftCode");
            reportFields.Add("BillTo.Address1");
            reportFields.Add("BillTo.Address2");
            reportFields.Add("BillTo.City");
            reportFields.Add("BillTo.CompanyName");
            reportFields.Add("BillTo.CompanyTaxID");
            reportFields.Add("BillTo.Country");
            reportFields.Add("BillTo.Email");
            reportFields.Add("BillTo.FirstName");
            reportFields.Add("BillTo.LastName");
            reportFields.Add("BillTo.MiddleName");
            reportFields.Add("BillTo.NameSuffix");
            reportFields.Add("BillTo.PersonalID");
            reportFields.Add("BillTo.Phone");
            reportFields.Add("BillTo.State");
            reportFields.Add("BillTo.Title");
            reportFields.Add("BillTo.Zip");
            reportFields.Add("ChargebackAndRetrieval.AdjustmentAmount");
            reportFields.Add("ChargebackAndRetrieval.AdjustmentCurrency");
            reportFields.Add("ChargebackAndRetrieval.ARN");
            reportFields.Add("ChargebackAndRetrieval.CaseIdentifier");
            reportFields.Add("ChargebackAndRetrieval.CaseNumber");
            reportFields.Add("ChargebackAndRetrieval.CaseTime");
            reportFields.Add("ChargebackAndRetrieval.CaseType");
            reportFields.Add("ChargebackAndRetrieval.ChargebackAmount");
            reportFields.Add("ChargebackAndRetrieval.ChargebackCurrency");
            reportFields.Add("ChargebackAndRetrieval.ChargebackMessage");
            reportFields.Add("ChargebackAndRetrieval.ChargebackReasonCode");
            reportFields.Add("ChargebackAndRetrieval.ChargebackReasonCodeDescription");
            reportFields.Add("ChargebackAndRetrieval.ChargebackTime");
            reportFields.Add("ChargebackAndRetrieval.DocumentIndicator");
            reportFields.Add("ChargebackAndRetrieval.FeeAmount");
            reportFields.Add("ChargebackAndRetrieval.FeeCurrency");
            reportFields.Add("ChargebackAndRetrieval.FinancialImpact");
            reportFields.Add("ChargebackAndRetrieval.FinancialImpactType");
            reportFields.Add("ChargebackAndRetrieval.MerchantCategoryCode");
            reportFields.Add("ChargebackAndRetrieval.PartialIndicator");
            reportFields.Add("ChargebackAndRetrieval.ResolutionTime");
            reportFields.Add("ChargebackAndRetrieval.ResolvedToIndicator");
            reportFields.Add("ChargebackAndRetrieval.RespondByDate");
            reportFields.Add("ChargebackAndRetrieval.TransactionType");
            reportFields.Add("Check.AccountEncoderID");
            reportFields.Add("Check.BankTransitNumber");
            reportFields.Add("Check.SecCode");
            reportFields.Add("CustomerFields.BillingAddress1");
            reportFields.Add("CustomerFields.BillingAddress2");
            reportFields.Add("CustomerFields.BillingCity");
            reportFields.Add("CustomerFields.BillingCompanyName");
            reportFields.Add("CustomerFields.BillingCountry");
            reportFields.Add("CustomerFields.BillingEmail");
            reportFields.Add("CustomerFields.BillingFirstName");
            reportFields.Add("CustomerFields.BillingLastName");
            reportFields.Add("CustomerFields.BillingPhone");
            reportFields.Add("CustomerFields.BillingPostalCode");
            reportFields.Add("CustomerFields.BillingState");
            reportFields.Add("CustomerFields.CustomerID");
            reportFields.Add("CustomerFields.CustomerUserName");
            reportFields.Add("CustomerFields.PersonalId(CPF/CNPJ)");
            reportFields.Add("CustomerFields.ShippingAddress1");
            reportFields.Add("CustomerFields.ShippingAddress2");
            reportFields.Add("CustomerFields.ShippingCity");
            reportFields.Add("CustomerFields.ShippingCompanyName");
            reportFields.Add("CustomerFields.ShippingCountry");
            reportFields.Add("CustomerFields.ShippingFirstName");
            reportFields.Add("CustomerFields.ShippingLastName");
            reportFields.Add("CustomerFields.ShippingPhone");
            reportFields.Add("CustomerFields.ShippingPostalCode");
            reportFields.Add("CustomerFields.ShippingState");
            reportFields.Add("DecisionManagerEvents.EventPolicy");
            reportFields.Add("DecisionManagerEvents.TypeofEvent");
            reportFields.Add("Device.DeviceID");
            reportFields.Add("DeviceFingerprintFields.abcd");
            reportFields.Add("DeviceFingerprintFields.BrowserLanguage");
            reportFields.Add("DeviceFingerprintFields.DeviceLatitude");
            reportFields.Add("DeviceFingerprintFields.DeviceLongitude");
            reportFields.Add("DeviceFingerprintFields.displayNameFinalCheck");
            reportFields.Add("DeviceFingerprintFields.DMESignOffFieldEdit");
            reportFields.Add("DeviceFingerprintFields.Fingerprint/DeviceFingerprint");
            reportFields.Add("DeviceFingerprintFields.FlashEnabled");
            reportFields.Add("DeviceFingerprintFields.FlashOperatingSystem");
            reportFields.Add("DeviceFingerprintFields.FlashVersion");
            reportFields.Add("DeviceFingerprintFields.GPSAccuracy");
            reportFields.Add("DeviceFingerprintFields.ImagesEnabled");
            reportFields.Add("DeviceFingerprintFields.Jailbreak/RootPrivileges");
            reportFields.Add("DeviceFingerprintFields.JavaScriptEnabled");
            reportFields.Add("DeviceFingerprintFields.ProfiledURL");
            reportFields.Add("DeviceFingerprintFields.ProxyIPAddress");
            reportFields.Add("DeviceFingerprintFields.ProxyIPAddressActivities");
            reportFields.Add("DeviceFingerprintFields.ProxyServerType");
            reportFields.Add("DeviceFingerprintFields.ScreenResolution");
            reportFields.Add("DeviceFingerprintFields.SignOffFieldDMEEditNewOne");
            reportFields.Add("DeviceFingerprintFields.SmartID");
            reportFields.Add("DeviceFingerprintFields.SmartIDConfidenceLevel");
            reportFields.Add("DeviceFingerprintFields.TimeOnPage");
            reportFields.Add("DeviceFingerprintFields.TrueIPAddress");
            reportFields.Add("DeviceFingerprintFields.TrueIPAddressActivities");
            reportFields.Add("DeviceFingerprintFields.TrueIPAddressAttributes");
            reportFields.Add("DeviceFingerprintFields.txdea1");
            reportFields.Add("DeviceFingerprintFields.txdesv");
            reportFields.Add("EmailageFields.FraudType");
            reportFields.Add("EmailageFields.IP Postal");
            reportFields.Add("EmailageFields.IPCity");
            reportFields.Add("EmailageFields.IPCountry");
            reportFields.Add("EmailageFields.IPRegion");
            reportFields.Add("EmailageFields.SourceIndustry");
            reportFields.Add("Event.Amount");
            reportFields.Add("Event.CurrencyCode");
            reportFields.Add("Event.Event");
            reportFields.Add("Event.EventDate");
            reportFields.Add("Event.ProcessorMessage");
            reportFields.Add("Exception.Action");
            reportFields.Add("Exception.CYBSExceptionID");
            reportFields.Add("Exception.DccLookupStatus");
            reportFields.Add("Exception.ExceptionAmount");
            reportFields.Add("Exception.ExceptionAmountCurrency");
            reportFields.Add("Exception.ExceptionCategory");
            reportFields.Add("Exception.ExceptionDate");
            reportFields.Add("Exception.ExceptionDescription");
            reportFields.Add("Exception.ExceptionDeviceHardwareRevision");
            reportFields.Add("Exception.ExceptionDeviceID");
            reportFields.Add("Exception.ExceptionDeviceOS");
            reportFields.Add("Exception.ExceptionDeviceOSVersion");
            reportFields.Add("Exception.ExceptionDeviceTerminalID");
            reportFields.Add("Exception.ExceptionMessage");
            reportFields.Add("Exception.ExceptionReasonDescription");
            reportFields.Add("Exception.ExceptionStatus");
            reportFields.Add("Exception.ExceptionStatusCode");
            reportFields.Add("Exception.ExceptionType");
            reportFields.Add("Exception.FinancialStatus");
            reportFields.Add("Exception.LastActionDate");
            reportFields.Add("Exception.NextActionDate");
            reportFields.Add("Exception.OriginalTransactionSubmissionDate");
            reportFields.Add("Exception.PaymentNumber");
            reportFields.Add("Exception.ProcessorCaseID");
            reportFields.Add("Exception.ProcessorResponseCode");
            reportFields.Add("Exception.ReasonCode");
            reportFields.Add("Exception.RetryCount");
            reportFields.Add("Fee.AssessmentAmount");
            reportFields.Add("Fee.AssessmentCurrency");
            reportFields.Add("Fee.BillingCycle");
            reportFields.Add("Fee.BillingType");
            reportFields.Add("Fee.ClearedInterchangeLevel");
            reportFields.Add("Fee.DiscountAmount");
            reportFields.Add("Fee.DiscountCurrency");
            reportFields.Add("Fee.DiscountRate");
            reportFields.Add("Fee.DowngradeReasonCode");
            reportFields.Add("Fee.InterchangeAmount");
            reportFields.Add("Fee.InterchangeCurrency");
            reportFields.Add("Fee.InterchangeRate");
            reportFields.Add("Fee.PerItemFeeAmount");
            reportFields.Add("Fee.PerItemFeeCurrency");
            reportFields.Add("Fee.PricedInterchangeLevel");
            reportFields.Add("Fee.ServiceFeeAmount");
            reportFields.Add("Fee.ServiceFeeAmountCcy");
            reportFields.Add("Fee.ServiceFeeFixedAmount");
            reportFields.Add("Fee.ServiceFeeFixedAmountCcy");
            reportFields.Add("Fee.ServiceFeeRate");
            reportFields.Add("Fee.SettlementAmount");
            reportFields.Add("Fee.SettlementCurrency");
            reportFields.Add("Fee.SettlementTime");
            reportFields.Add("Fee.SettlementTimeZone");
            reportFields.Add("Fee.SourceDescriptor");
            reportFields.Add("Fee.TotalFeeAmount");
            reportFields.Add("Fee.TotalFeeCurrency");
            reportFields.Add("Funding.AdjustmentAmount");
            reportFields.Add("Funding.AdjustmentCurrency");
            reportFields.Add("Funding.AdjustmentDescription");
            reportFields.Add("Funding.AdjustmentType");
            reportFields.Add("FundTransfer.BankCheckDigit");
            reportFields.Add("FundTransfer.IbanIndicator");
            reportFields.Add("Invoice.BillingGroupDescription");
            reportFields.Add("Invoice.NotProcessed");
            reportFields.Add("Invoice.OrganizationID");
            reportFields.Add("Invoice.PerformedServices");
            reportFields.Add("Invoice.Processed");
            reportFields.Add("Invoice.Total");
            reportFields.Add("JP.Amount");
            reportFields.Add("JP.AuthForward");
            reportFields.Add("JP.AuthorizationCode");
            reportFields.Add("JP.CardSuffix");
            reportFields.Add("JP.Currency");
            reportFields.Add("JP.CustomerFirstName");
            reportFields.Add("JP.CustomerLastName");
            reportFields.Add("JP.Date");
            reportFields.Add("JP.Gateway");
            reportFields.Add("JP.JPOInstallmentMethod");
            reportFields.Add("JP.JPOPaymentMethod");
            reportFields.Add("JP.MerchantID");
            reportFields.Add("JP.MerchantReferenceNumber");
            reportFields.Add("JP.PaymentMethod");
            reportFields.Add("JP.RequestID");
            reportFields.Add("JP.SubscriptionID");
            reportFields.Add("JP.Time");
            reportFields.Add("JP.TransactionReferenceNumber");
            reportFields.Add("JP.TransactionType");
            reportFields.Add("LineItems.FulfillmentType");
            reportFields.Add("LineItems.InvoiceNumber");
            reportFields.Add("LineItems.MerchantProductSku");
            reportFields.Add("LineItems.ProductCode");
            reportFields.Add("LineItems.ProductName");
            reportFields.Add("LineItems.Quantity");
            reportFields.Add("LineItems.TaxAmount");
            reportFields.Add("LineItems.UnitPrice");
            reportFields.Add("MarkAsSuspectFields.MarkingDate");
            reportFields.Add("MarkAsSuspectFields.MarkingNotes");
            reportFields.Add("MarkAsSuspectFields.MarkingReason");
            reportFields.Add("MarkAsSuspectFields.MarkingUserName");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData1");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData10");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData100");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData11");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData12");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData13");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData14");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData15");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData16");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData17");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData18");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData19");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData2");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData20");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData21");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData22");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData23");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData24");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData25");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData26");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData27");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData28");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData29");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData3");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData30");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData31");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData32");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData34");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData35");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData36");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData37");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData39");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData4");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData40");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData41");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData43");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData44");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData45");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData46");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData48");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData49");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData5");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData50");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData52");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData53");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData54");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData56");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData57");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData58");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData59");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData6");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData61");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData62");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData63");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData65");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData66");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData67");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData68");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData7");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData70");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData71");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData72");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData73");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData74");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData75");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData76");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData77");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData78");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData79");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData8");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData80");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData81");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData82");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData83");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData84");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData85");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData86");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData87");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData88");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData89");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData9");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData90");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData91");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData92");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData93");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData94");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData95");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData96");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData97");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData98");
            reportFields.Add("Merchant-DefinedDataFields.MerchantDefinedData99");
            reportFields.Add("OctSummary.AccountId");
            reportFields.Add("OctSummary.ResellerId");
            reportFields.Add("OctSummary.SettlementAmountCurrency");
            reportFields.Add("OctSummary.SettlementDate");
            reportFields.Add("OctSummary.TransactionAmountCurrency");
            reportFields.Add("OrderFields.ConnectionMethod");
            reportFields.Add("OrderFields.MerchantID");
            reportFields.Add("OrderFields.MerchantReferenceNumber");
            reportFields.Add("OrderFields.ReasonCode");
            reportFields.Add("OrderFields.ReplyCode");
            reportFields.Add("OrderFields.ReplyFlag");
            reportFields.Add("OrderFields.ReplyMessage");
            reportFields.Add("OrderFields.RequestID");
            reportFields.Add("OrderFields.ShippingMethod");
            reportFields.Add("OrderFields.TransactionDate");
            reportFields.Add("PayerAuth.RequestID");
            reportFields.Add("PayerAuth.TransactionType");
            reportFields.Add("PaymentData.ACHVerificationResult");
            reportFields.Add("PaymentData.ACHVerificationResultMapped");
            reportFields.Add("PaymentData.AcquirerMerchantID");
            reportFields.Add("PaymentData.AuthIndicator");
            reportFields.Add("PaymentData.AuthorizationCode");
            reportFields.Add("PaymentData.AuthorizationType");
            reportFields.Add("PaymentData.AuthReversalAmount");
            reportFields.Add("PaymentData.AuthReversalResult");
            reportFields.Add("PaymentData.AVSResult");
            reportFields.Add("PaymentData.AVSResultMapped");
            reportFields.Add("PaymentData.BalanceAmount");
            reportFields.Add("PaymentData.BalanceCurrencyCode");
            reportFields.Add("PaymentData.BinNumber");
            reportFields.Add("PaymentData.CardCategory");
            reportFields.Add("PaymentData.CardCategoryCode");
            reportFields.Add("PaymentData.CardPresent");
            reportFields.Add("PaymentData.CurrencyCode");
            reportFields.Add("PaymentData.CVResult");
            reportFields.Add("PaymentData.DCCIndicator");
            reportFields.Add("PaymentData.EMVRequestFallBack");
            reportFields.Add("PaymentData.EVEmail");
            reportFields.Add("PaymentData.EVEmailRaw");
            reportFields.Add("PaymentData.EVName");
            reportFields.Add("PaymentData.EVNameRaw");
            reportFields.Add("PaymentData.EVPhoneNumber");
            reportFields.Add("PaymentData.EVPhoneNumberRaw");
            reportFields.Add("PaymentData.EVPostalCode");
            reportFields.Add("PaymentData.EVPostalCodeRaw");
            reportFields.Add("PaymentData.EVStreet");
            reportFields.Add("PaymentData.EVStreetRaw");
            reportFields.Add("PaymentData.ExchangeRate");
            reportFields.Add("PaymentData.ExchangeRateDate");
            reportFields.Add("PaymentData.MandateReferenceNumber");
            reportFields.Add("PaymentData.NetworkCode");
            reportFields.Add("PaymentData.NetworkTransactionID");
            reportFields.Add("PaymentData.NumberOfInstallments");
            reportFields.Add("PaymentData.OriginalAmount");
            reportFields.Add("PaymentData.OriginalCurrency");
            reportFields.Add("PaymentData.PaymentProductCode");
            reportFields.Add("PaymentData.POSEntryMode");
            reportFields.Add("PaymentData.ProcessorMID");
            reportFields.Add("PaymentData.ProcessorResponseCode");
            reportFields.Add("PaymentData.ProcessorResponseID");
            reportFields.Add("PaymentData.ProcessorTID");
            reportFields.Add("PaymentData.ProcessorTransactionID");
            reportFields.Add("PaymentData.RequestedAmount");
            reportFields.Add("PaymentData.RequestedAmountCurrencyCode");
            reportFields.Add("PaymentData.SubMerchantCity");
            reportFields.Add("PaymentData.SubMerchantCountry");
            reportFields.Add("PaymentData.SubMerchantEmail");
            reportFields.Add("PaymentData.SubMerchantID");
            reportFields.Add("PaymentData.SubMerchantName");
            reportFields.Add("PaymentData.SubMerchantPhone");
            reportFields.Add("PaymentData.SubMerchantPostalCode");
            reportFields.Add("PaymentData.SubMerchantState");
            reportFields.Add("PaymentData.SubMerchantStreet");
            reportFields.Add("PaymentData.TargetAmount");
            reportFields.Add("PaymentData.TargetCurrency");
            reportFields.Add("PaymentFields.AccountSuffix");
            reportFields.Add("PaymentFields.CardBIN");
            reportFields.Add("PaymentFields.CardBINCountry");
            reportFields.Add("PaymentFields.CardIssuer");
            reportFields.Add("PaymentFields.CardScheme");
            reportFields.Add("PaymentFields.CardType");
            reportFields.Add("PaymentFields.CardVerificationResult");
            reportFields.Add("PaymentMethod.AccountSuffix");
            reportFields.Add("PaymentMethod.AdditionalCardType");
            reportFields.Add("PaymentMethod.BankAccountName");
            reportFields.Add("PaymentMethod.BankCode");
            reportFields.Add("PaymentMethod.BoletoBarCodeNumber");
            reportFields.Add("PaymentMethod.BoletoNumber");
            reportFields.Add("PaymentMethod.CardType");
            reportFields.Add("PaymentMethod.CheckNumber");
            reportFields.Add("PaymentMethod.ExpirationMonth");
            reportFields.Add("PaymentMethod.ExpirationYear");
            reportFields.Add("PaymentMethod.IssueNumber");
            reportFields.Add("PaymentMethod.MandateId");
            reportFields.Add("PaymentMethod.StartMonth");
            reportFields.Add("PaymentMethod.StartYear");
            reportFields.Add("PaymentMethod.WalletType");
            reportFields.Add("POSTerminalExceptions.AccountSuffix");
            reportFields.Add("POSTerminalExceptions.CurrencyCode");
            reportFields.Add("POSTerminalExceptions.ExpirationMO");
            reportFields.Add("POSTerminalExceptions.ExpirationYR");
            reportFields.Add("POSTerminalExceptions.LastName");
            reportFields.Add("POSTerminalExceptions.MerchantID");
            reportFields.Add("Recipient.RecipientBillingAmount");
            reportFields.Add("Recipient.RecipientBillingCurrency");
            reportFields.Add("Recipient.ReferenceNumber");
            reportFields.Add("Request.PartnerOriginalTransactionID");
            reportFields.Add("Sender.Address");
            reportFields.Add("Sender.City");
            reportFields.Add("Sender.Country");
            reportFields.Add("Sender.DOB");
            reportFields.Add("Sender.FirstName");
            reportFields.Add("Sender.LastName");
            reportFields.Add("Sender.MiddleInitial");
            reportFields.Add("Sender.PhoneNumber");
            reportFields.Add("Sender.PostalCode");
            reportFields.Add("Sender.SenderReferenceNumber");
            reportFields.Add("Sender.SourceOfFunds");
            reportFields.Add("Sender.State");
            reportFields.Add("ShipTo.CompanyName");
            reportFields.Add("Subscriptions.Applications");
            reportFields.Add("Subscriptions.AuthAVSResults");
            reportFields.Add("Subscriptions.AuthCardVerificationResult");
            reportFields.Add("Subscriptions.AuthCode");
            reportFields.Add("Subscriptions.AuthRCode");
            reportFields.Add("Subscriptions.AuthResponseCode");
            reportFields.Add("Subscriptions.AuthType");
            reportFields.Add("Subscriptions.BillToAddress1");
            reportFields.Add("Subscriptions.BillToAddress2");
            reportFields.Add("Subscriptions.BillToCity");
            reportFields.Add("Subscriptions.BillToCompanyName");
            reportFields.Add("Subscriptions.BillToCountry");
            reportFields.Add("Subscriptions.BillToEmail");
            reportFields.Add("Subscriptions.BillToFirstName");
            reportFields.Add("Subscriptions.BillToLastName");
            reportFields.Add("Subscriptions.BillToState");
            reportFields.Add("Subscriptions.BillToZip");
            reportFields.Add("Subscriptions.CardType");
            reportFields.Add("Subscriptions.Comments");
            reportFields.Add("Subscriptions.ConsumerPhone");
            reportFields.Add("Subscriptions.CurrencyCode");
            reportFields.Add("Subscriptions.CustomerCCAccountSuffix");
            reportFields.Add("Subscriptions.CustomerCCExpiryMonth");
            reportFields.Add("Subscriptions.CustomerCCExpiryYear");
            reportFields.Add("Subscriptions.CustomerCCIssueNo");
            reportFields.Add("Subscriptions.CustomerCCRoutingNumber");
            reportFields.Add("Subscriptions.CustomerCCStartMonth");
            reportFields.Add("Subscriptions.CustomerCCStartYear");
            reportFields.Add("Subscriptions.CustomerCCSubTypeDescription");
            reportFields.Add("Subscriptions.EcommerceIndicator");
            reportFields.Add("Subscriptions.IPAddress");
            reportFields.Add("Subscriptions.MerchantDefinedData1");
            reportFields.Add("Subscriptions.MerchantDefinedData2");
            reportFields.Add("Subscriptions.MerchantDefinedData3");
            reportFields.Add("Subscriptions.MerchantDefinedData4");
            reportFields.Add("Subscriptions.MerchantRefNo");
            reportFields.Add("Subscriptions.MerchantSecureData1");
            reportFields.Add("Subscriptions.MerchantSecureData2");
            reportFields.Add("Subscriptions.MerchantSecureData3");
            reportFields.Add("Subscriptions.MerchantSecureData4");
            reportFields.Add("Subscriptions.PaymentProcessor");
            reportFields.Add("Subscriptions.PaymentsSuccess");
            reportFields.Add("Subscriptions.RCode");
            reportFields.Add("Subscriptions.ReasonCode");
            reportFields.Add("Subscriptions.RequestID");
            reportFields.Add("Subscriptions.RequestToken");
            reportFields.Add("Subscriptions.RFlag");
            reportFields.Add("Subscriptions.RMsg");
            reportFields.Add("Subscriptions.ShipToAddress1");
            reportFields.Add("Subscriptions.ShipToAddress2");
            reportFields.Add("Subscriptions.ShipToCity");
            reportFields.Add("Subscriptions.ShipToCompanyName");
            reportFields.Add("Subscriptions.ShipToCountry");
            reportFields.Add("Subscriptions.ShipToFirstName");
            reportFields.Add("Subscriptions.ShipToLastName");
            reportFields.Add("Subscriptions.ShipToState");
            reportFields.Add("Subscriptions.ShipToZip");
            reportFields.Add("Subscriptions.SubscriptionID");
            reportFields.Add("Subscriptions.TaxAmount");
            reportFields.Add("Subscriptions.TransactionDate");
            reportFields.Add("Subscriptions.TransRefNo");
            reportFields.Add("TaxCalculation.Status");
            reportFields.Add("Token.NetworkTokenTransType");
            reportFields.Add("Token.TokenCode");
            reportFields.Add("TransactionDetails.MerchantId");
            reportFields.Add("TransactionDetails.PaymentMethodDesc");
            reportFields.Add("TransactionDetails.PaymentMethodType");
            reportFields.Add("TransactionDetails.RequestId");
            reportFields.Add("TravelFields.DepartureTime");
            reportFields.Add("VelocityMorphing.FieldName");
            reportFields.Add("VelocityMorphing.InfoCode");
            reportFields.Add("WhitepagesProFields.EmailDomainCreationDate");
            string reportMimeType = "application/xml";
            string reportFrequency = "WEEKLY";
            string reportName = "testrest_subcription_v1";
            string timezone = "GMT";
            string startTime = "0900";
            int startDay = 1;
            var requestObj = new CreateReportSubscriptionRequest(
                ReportDefinitionName: reportDefinitionName,
                ReportFields: reportFields,
                ReportMimeType: reportMimeType,
                ReportFrequency: reportFrequency,
                ReportName: reportName,
                Timezone: timezone,
                StartTime: startTime,
                StartDay: startDay
           );

            string organizationId = null;
            try
            {
                var configDictionary = new Configuration().GetConfiguration();
                var clientConfig = new CyberSource.Client.Configuration(merchConfigDictObj: configDictionary);

                var apiInstance = new ReportSubscriptionsApi(clientConfig);
                apiInstance.CreateSubscription(requestObj, organizationId);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception on calling the API : " + e.Message);
            }
        }
    }
}