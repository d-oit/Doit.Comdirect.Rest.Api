<a name='assembly'></a>
# Comdirect.Rest.Api

## Contents

- [Account](#T-Comdirect-Rest-Api-Comdirect-Account 'Comdirect.Rest.Api.Comdirect.Account')
  - [AccountDisplayId](#P-Comdirect-Rest-Api-Comdirect-Account-AccountDisplayId 'Comdirect.Rest.Api.Comdirect.Account.AccountDisplayId')
  - [AccountId](#P-Comdirect-Rest-Api-Comdirect-Account-AccountId 'Comdirect.Rest.Api.Comdirect.Account.AccountId')
  - [AccountType](#P-Comdirect-Rest-Api-Comdirect-Account-AccountType 'Comdirect.Rest.Api.Comdirect.Account.AccountType')
  - [ClientId](#P-Comdirect-Rest-Api-Comdirect-Account-ClientId 'Comdirect.Rest.Api.Comdirect.Account.ClientId')
  - [CreditLimit](#P-Comdirect-Rest-Api-Comdirect-Account-CreditLimit 'Comdirect.Rest.Api.Comdirect.Account.CreditLimit')
  - [Currency](#P-Comdirect-Rest-Api-Comdirect-Account-Currency 'Comdirect.Rest.Api.Comdirect.Account.Currency')
  - [Iban](#P-Comdirect-Rest-Api-Comdirect-Account-Iban 'Comdirect.Rest.Api.Comdirect.Account.Iban')
- [AccountBalance](#T-Comdirect-Rest-Api-Comdirect-AccountBalance 'Comdirect.Rest.Api.Comdirect.AccountBalance')
  - [Account](#P-Comdirect-Rest-Api-Comdirect-AccountBalance-Account 'Comdirect.Rest.Api.Comdirect.AccountBalance.Account')
  - [AccountId](#P-Comdirect-Rest-Api-Comdirect-AccountBalance-AccountId 'Comdirect.Rest.Api.Comdirect.AccountBalance.AccountId')
  - [AvailableCashAmount](#P-Comdirect-Rest-Api-Comdirect-AccountBalance-AvailableCashAmount 'Comdirect.Rest.Api.Comdirect.AccountBalance.AvailableCashAmount')
  - [AvailableCashAmountEUR](#P-Comdirect-Rest-Api-Comdirect-AccountBalance-AvailableCashAmountEUR 'Comdirect.Rest.Api.Comdirect.AccountBalance.AvailableCashAmountEUR')
  - [Balance](#P-Comdirect-Rest-Api-Comdirect-AccountBalance-Balance 'Comdirect.Rest.Api.Comdirect.AccountBalance.Balance')
  - [BalanceEUR](#P-Comdirect-Rest-Api-Comdirect-AccountBalance-BalanceEUR 'Comdirect.Rest.Api.Comdirect.AccountBalance.BalanceEUR')
- [AccountInformation](#T-Comdirect-Rest-Api-Comdirect-AccountInformation 'Comdirect.Rest.Api.Comdirect.AccountInformation')
  - [Bic](#P-Comdirect-Rest-Api-Comdirect-AccountInformation-Bic 'Comdirect.Rest.Api.Comdirect.AccountInformation.Bic')
  - [HolderName](#P-Comdirect-Rest-Api-Comdirect-AccountInformation-HolderName 'Comdirect.Rest.Api.Comdirect.AccountInformation.HolderName')
  - [Iban](#P-Comdirect-Rest-Api-Comdirect-AccountInformation-Iban 'Comdirect.Rest.Api.Comdirect.AccountInformation.Iban')
- [AccountTransaction](#T-Comdirect-Rest-Api-Comdirect-AccountTransaction 'Comdirect.Rest.Api.Comdirect.AccountTransaction')
  - [Amount](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Amount 'Comdirect.Rest.Api.Comdirect.AccountTransaction.Amount')
  - [BookingDate](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-BookingDate 'Comdirect.Rest.Api.Comdirect.AccountTransaction.BookingDate')
  - [BookingStatus](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-BookingStatus 'Comdirect.Rest.Api.Comdirect.AccountTransaction.BookingStatus')
  - [Creditor](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Creditor 'Comdirect.Rest.Api.Comdirect.AccountTransaction.Creditor')
  - [Deptor](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Deptor 'Comdirect.Rest.Api.Comdirect.AccountTransaction.Deptor')
  - [DirectDebitCreditorId](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-DirectDebitCreditorId 'Comdirect.Rest.Api.Comdirect.AccountTransaction.DirectDebitCreditorId')
  - [DirectDebitMandateId](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-DirectDebitMandateId 'Comdirect.Rest.Api.Comdirect.AccountTransaction.DirectDebitMandateId')
  - [EndToEndReference](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-EndToEndReference 'Comdirect.Rest.Api.Comdirect.AccountTransaction.EndToEndReference')
  - [NewTransaction](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-NewTransaction 'Comdirect.Rest.Api.Comdirect.AccountTransaction.NewTransaction')
  - [Reference](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Reference 'Comdirect.Rest.Api.Comdirect.AccountTransaction.Reference')
  - [RemittanceInfo](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-RemittanceInfo 'Comdirect.Rest.Api.Comdirect.AccountTransaction.RemittanceInfo')
  - [Remitter](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Remitter 'Comdirect.Rest.Api.Comdirect.AccountTransaction.Remitter')
  - [TransactionType](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-TransactionType 'Comdirect.Rest.Api.Comdirect.AccountTransaction.TransactionType')
  - [ValutaDate](#P-Comdirect-Rest-Api-Comdirect-AccountTransaction-ValutaDate 'Comdirect.Rest.Api.Comdirect.AccountTransaction.ValutaDate')
- [AmountValue](#T-Comdirect-Rest-Api-Comdirect-AmountValue 'Comdirect.Rest.Api.Comdirect.AmountValue')
  - [Unit](#P-Comdirect-Rest-Api-Comdirect-AmountValue-Unit 'Comdirect.Rest.Api.Comdirect.AmountValue.Unit')
  - [Value](#P-Comdirect-Rest-Api-Comdirect-AmountValue-Value 'Comdirect.Rest.Api.Comdirect.AmountValue.Value')
- [AuthClient](#T-Comdirect-Rest-Api-AuthClient 'Comdirect.Rest.Api.AuthClient')
  - [#ctor(httpClient,comdirectCredentials)](#M-Comdirect-Rest-Api-AuthClient-#ctor-System-Net-Http-HttpClient,Comdirect-Auth-CSharp-ComdirectCredentials- 'Comdirect.Rest.Api.AuthClient.#ctor(System.Net.Http.HttpClient,Comdirect.Auth.CSharp.ComdirectCredentials)')
  - [RequestId](#P-Comdirect-Rest-Api-AuthClient-RequestId 'Comdirect.Rest.Api.AuthClient.RequestId')
  - [SessionId](#P-Comdirect-Rest-Api-AuthClient-SessionId 'Comdirect.Rest.Api.AuthClient.SessionId')
  - [ActivateSessionTanAsync(accessToken,sessionUUID,challangeId)](#M-Comdirect-Rest-Api-AuthClient-ActivateSessionTanAsync-System-String,System-String,System-String- 'Comdirect.Rest.Api.AuthClient.ActivateSessionTanAsync(System.String,System.String,System.String)')
  - [GenerateDigits(length)](#M-Comdirect-Rest-Api-AuthClient-GenerateDigits-System-Int32- 'Comdirect.Rest.Api.AuthClient.GenerateDigits(System.Int32)')
  - [GetHttpRequestInfoValue()](#M-Comdirect-Rest-Api-AuthClient-GetHttpRequestInfoValue 'Comdirect.Rest.Api.AuthClient.GetHttpRequestInfoValue')
  - [GetSessionStatusAsync(accessToken,accessToken)](#M-Comdirect-Rest-Api-AuthClient-GetSessionStatusAsync-System-String- 'Comdirect.Rest.Api.AuthClient.GetSessionStatusAsync(System.String)')
  - [GetTokenAndValidateSessionAsync()](#M-Comdirect-Rest-Api-AuthClient-GetTokenAndValidateSessionAsync 'Comdirect.Rest.Api.AuthClient.GetTokenAndValidateSessionAsync')
  - [GetTokenAsync()](#M-Comdirect-Rest-Api-AuthClient-GetTokenAsync 'Comdirect.Rest.Api.AuthClient.GetTokenAsync')
  - [PostSecondaryFlowAsync(accessToken)](#M-Comdirect-Rest-Api-AuthClient-PostSecondaryFlowAsync-System-String- 'Comdirect.Rest.Api.AuthClient.PostSecondaryFlowAsync(System.String)')
  - [PostValidateSessionStatusAsync(accessToken,sessionUUID)](#M-Comdirect-Rest-Api-AuthClient-PostValidateSessionStatusAsync-System-String,System-String- 'Comdirect.Rest.Api.AuthClient.PostValidateSessionStatusAsync(System.String,System.String)')
  - [RevokeTokenAsync(accessToken)](#M-Comdirect-Rest-Api-AuthClient-RevokeTokenAsync-System-String- 'Comdirect.Rest.Api.AuthClient.RevokeTokenAsync(System.String)')
  - [SetBody(sessionUUID,request)](#M-Comdirect-Rest-Api-AuthClient-SetBody-System-String,RestSharp-RestRequest- 'Comdirect.Rest.Api.AuthClient.SetBody(System.String,RestSharp.RestRequest)')
  - [SetRequestSessionInfo(request)](#M-Comdirect-Rest-Api-AuthClient-SetRequestSessionInfo-RestSharp-RestRequest- 'Comdirect.Rest.Api.AuthClient.SetRequestSessionInfo(RestSharp.RestRequest)')
- [Balance](#T-Comdirect-Rest-Api-Comdirect-Balance 'Comdirect.Rest.Api.Comdirect.Balance')
  - [AccountBalance](#P-Comdirect-Rest-Api-Comdirect-Balance-AccountBalance 'Comdirect.Rest.Api.Comdirect.Balance.AccountBalance')
  - [CardBalance](#P-Comdirect-Rest-Api-Comdirect-Balance-CardBalance 'Comdirect.Rest.Api.Comdirect.Balance.CardBalance')
  - [DepotAggregation](#P-Comdirect-Rest-Api-Comdirect-Balance-DepotAggregation 'Comdirect.Rest.Api.Comdirect.Balance.DepotAggregation')
  - [FixedTermSavings](#P-Comdirect-Rest-Api-Comdirect-Balance-FixedTermSavings 'Comdirect.Rest.Api.Comdirect.Balance.FixedTermSavings')
  - [InstallmentLoanBalance](#P-Comdirect-Rest-Api-Comdirect-Balance-InstallmentLoanBalance 'Comdirect.Rest.Api.Comdirect.Balance.InstallmentLoanBalance')
- [BusinessMessage](#T-Comdirect-Rest-Api-Comdirect-BusinessMessage 'Comdirect.Rest.Api.Comdirect.BusinessMessage')
  - [Args](#P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Args 'Comdirect.Rest.Api.Comdirect.BusinessMessage.Args')
  - [Key](#P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Key 'Comdirect.Rest.Api.Comdirect.BusinessMessage.Key')
  - [Message](#P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Message 'Comdirect.Rest.Api.Comdirect.BusinessMessage.Message')
  - [Origin](#P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Origin 'Comdirect.Rest.Api.Comdirect.BusinessMessage.Origin')
  - [Severity](#P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Severity 'Comdirect.Rest.Api.Comdirect.BusinessMessage.Severity')
- [Card](#T-Comdirect-Rest-Api-Comdirect-Card 'Comdirect.Rest.Api.Comdirect.Card')
  - [CardDisplayId](#P-Comdirect-Rest-Api-Comdirect-Card-CardDisplayId 'Comdirect.Rest.Api.Comdirect.Card.CardDisplayId')
  - [CardId](#P-Comdirect-Rest-Api-Comdirect-Card-CardId 'Comdirect.Rest.Api.Comdirect.Card.CardId')
  - [CardImage](#P-Comdirect-Rest-Api-Comdirect-Card-CardImage 'Comdirect.Rest.Api.Comdirect.Card.CardImage')
  - [CardLimit](#P-Comdirect-Rest-Api-Comdirect-Card-CardLimit 'Comdirect.Rest.Api.Comdirect.Card.CardLimit')
  - [CardType](#P-Comdirect-Rest-Api-Comdirect-Card-CardType 'Comdirect.Rest.Api.Comdirect.Card.CardType')
  - [CardValidity](#P-Comdirect-Rest-Api-Comdirect-Card-CardValidity 'Comdirect.Rest.Api.Comdirect.Card.CardValidity')
  - [ClientId](#P-Comdirect-Rest-Api-Comdirect-Card-ClientId 'Comdirect.Rest.Api.Comdirect.Card.ClientId')
  - [HolderName](#P-Comdirect-Rest-Api-Comdirect-Card-HolderName 'Comdirect.Rest.Api.Comdirect.Card.HolderName')
  - [ParticipantId](#P-Comdirect-Rest-Api-Comdirect-Card-ParticipantId 'Comdirect.Rest.Api.Comdirect.Card.ParticipantId')
  - [PrimaryAccountNumberSuffix](#P-Comdirect-Rest-Api-Comdirect-Card-PrimaryAccountNumberSuffix 'Comdirect.Rest.Api.Comdirect.Card.PrimaryAccountNumberSuffix')
  - [SettlementAccountId](#P-Comdirect-Rest-Api-Comdirect-Card-SettlementAccountId 'Comdirect.Rest.Api.Comdirect.Card.SettlementAccountId')
  - [Status](#P-Comdirect-Rest-Api-Comdirect-Card-Status 'Comdirect.Rest.Api.Comdirect.Card.Status')
- [CardBalance](#T-Comdirect-Rest-Api-Comdirect-CardBalance 'Comdirect.Rest.Api.Comdirect.CardBalance')
  - [AvailableCashAmount](#P-Comdirect-Rest-Api-Comdirect-CardBalance-AvailableCashAmount 'Comdirect.Rest.Api.Comdirect.CardBalance.AvailableCashAmount')
  - [Balance](#P-Comdirect-Rest-Api-Comdirect-CardBalance-Balance 'Comdirect.Rest.Api.Comdirect.CardBalance.Balance')
  - [Card](#P-Comdirect-Rest-Api-Comdirect-CardBalance-Card 'Comdirect.Rest.Api.Comdirect.CardBalance.Card')
  - [CardId](#P-Comdirect-Rest-Api-Comdirect-CardBalance-CardId 'Comdirect.Rest.Api.Comdirect.CardBalance.CardId')
- [ComdirectClient](#T-Comdirect-Rest-Api-Comdirect-ComdirectClient 'Comdirect.Rest.Api.Comdirect.ComdirectClient')
  - [BankingClientsV2AccountsBalancesAsync(user,without_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingClientsV2AccountsBalancesAsync-System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BankingClientsV2AccountsBalancesAsync(System.String,System.String)')
  - [BankingClientsV2AccountsBalancesAsync(cancellationToken,user,without_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingClientsV2AccountsBalancesAsync-System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BankingClientsV2AccountsBalancesAsync(System.String,System.String,System.Threading.CancellationToken)')
  - [BankingV1AccountsTransactionsAsync(accountId,transactionState,transactionDirection,paging_first,with_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingV1AccountsTransactionsAsync-System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-TransactionState},System-Nullable{Comdirect-Rest-Api-Comdirect-TransactionDirection},System-Nullable{System-Int32},System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BankingV1AccountsTransactionsAsync(System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionState},System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionDirection},System.Nullable{System.Int32},System.String)')
  - [BankingV1AccountsTransactionsAsync(cancellationToken,accountId,transactionState,transactionDirection,paging_first,with_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingV1AccountsTransactionsAsync-System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-TransactionState},System-Nullable{Comdirect-Rest-Api-Comdirect-TransactionDirection},System-Nullable{System-Int32},System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BankingV1AccountsTransactionsAsync(System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionState},System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionDirection},System.Nullable{System.Int32},System.String,System.Threading.CancellationToken)')
  - [BankingV2AccountsBalancesAsync(accountId,without_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingV2AccountsBalancesAsync-System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BankingV2AccountsBalancesAsync(System.String,System.String)')
  - [BankingV2AccountsBalancesAsync(cancellationToken,accountId,without_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingV2AccountsBalancesAsync-System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BankingV2AccountsBalancesAsync(System.String,System.String,System.Threading.CancellationToken)')
  - [BrokerageClientsV3DepotsAsync(userId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageClientsV3DepotsAsync-System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageClientsV3DepotsAsync(System.String)')
  - [BrokerageClientsV3DepotsAsync(cancellationToken,userId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageClientsV3DepotsAsync-System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageClientsV3DepotsAsync(System.String,System.Threading.CancellationToken)')
  - [BrokerageDepotsV3OrdersAsync(depotId,with_attr,without_attr,instrumentId,isin,wkn,orderStatus,venueId,orderType,min_creationTimeStamp,max_creationTimeStamp,side)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageDepotsV3OrdersAsync-System-String,System-String,System-String,System-String,System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderStatus},System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderType2},System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-Side}- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageDepotsV3OrdersAsync(System.String,System.String,System.String,System.String,System.String,System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.OrderStatus},System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType2},System.String,System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.Side})')
  - [BrokerageDepotsV3OrdersAsync(cancellationToken,depotId,with_attr,without_attr,instrumentId,isin,wkn,orderStatus,venueId,orderType,min_creationTimeStamp,max_creationTimeStamp,side)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageDepotsV3OrdersAsync-System-String,System-String,System-String,System-String,System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderStatus},System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderType2},System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-Side},System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageDepotsV3OrdersAsync(System.String,System.String,System.String,System.String,System.String,System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.OrderStatus},System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType2},System.String,System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.Side},System.Threading.CancellationToken)')
  - [BrokerageV1InstrumentsAsync(instrumentId,with_attr,without_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV1InstrumentsAsync-System-String,System-Collections-Generic-IEnumerable{Comdirect-Rest-Api-Comdirect-Anonymous},System-Collections-Generic-IEnumerable{System-String}- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV1InstrumentsAsync(System.String,System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous},System.Collections.Generic.IEnumerable{System.String})')
  - [BrokerageV1InstrumentsAsync(cancellationToken,instrumentId,with_attr,without_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV1InstrumentsAsync-System-String,System-Collections-Generic-IEnumerable{Comdirect-Rest-Api-Comdirect-Anonymous},System-Collections-Generic-IEnumerable{System-String},System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV1InstrumentsAsync(System.String,System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous},System.Collections.Generic.IEnumerable{System.String},System.Threading.CancellationToken)')
  - [BrokerageV3DepotsPositionsGetAsync(depotId,instrumentId,without_attr,with_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsPositionsGetAsync-System-String,System-String,System-Collections-Generic-IEnumerable{System-String},System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3DepotsPositionsGetAsync(System.String,System.String,System.Collections.Generic.IEnumerable{System.String},System.String)')
  - [BrokerageV3DepotsPositionsGetAsync(cancellationToken,depotId,instrumentId,without_attr,with_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsPositionsGetAsync-System-String,System-String,System-Collections-Generic-IEnumerable{System-String},System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3DepotsPositionsGetAsync(System.String,System.String,System.Collections.Generic.IEnumerable{System.String},System.String,System.Threading.CancellationToken)')
  - [BrokerageV3DepotsPositionsGetAsync(depotId,positionId,with_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsPositionsGetAsync-System-String,System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3DepotsPositionsGetAsync(System.String,System.String,System.String)')
  - [BrokerageV3DepotsPositionsGetAsync(cancellationToken,depotId,positionId,with_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsPositionsGetAsync-System-String,System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3DepotsPositionsGetAsync(System.String,System.String,System.String,System.Threading.CancellationToken)')
  - [BrokerageV3DepotsTransactionsAsync(depotId,isin,wkn,instrumentId,min_bookingDate)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsTransactionsAsync-System-String,System-String,System-String,System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3DepotsTransactionsAsync(System.String,System.String,System.String,System.String,System.String)')
  - [BrokerageV3DepotsTransactionsAsync(cancellationToken,depotId,isin,wkn,instrumentId,min_bookingDate)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsTransactionsAsync-System-String,System-String,System-String,System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3DepotsTransactionsAsync(System.String,System.String,System.String,System.String,System.String,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersCostindicationexantePostAsync(order)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersCostindicationexantePostAsync-Comdirect-Rest-Api-Comdirect-Order- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersCostindicationexantePostAsync(Comdirect.Rest.Api.Comdirect.Order)')
  - [BrokerageV3OrdersCostindicationexantePostAsync(cancellationToken,order)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersCostindicationexantePostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersCostindicationexantePostAsync(Comdirect.Rest.Api.Comdirect.Order,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersCostindicationexantePostAsync(orderId,order)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersCostindicationexantePostAsync-System-String,Comdirect-Rest-Api-Comdirect-Order- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersCostindicationexantePostAsync(System.String,Comdirect.Rest.Api.Comdirect.Order)')
  - [BrokerageV3OrdersCostindicationexantePostAsync(cancellationToken,orderId,order)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersCostindicationexantePostAsync-System-String,Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersCostindicationexantePostAsync(System.String,Comdirect.Rest.Api.Comdirect.Order,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersDeleteAsync(orderId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersDeleteAsync-System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersDeleteAsync(System.String)')
  - [BrokerageV3OrdersDeleteAsync(cancellationToken,orderId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersDeleteAsync-System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersDeleteAsync(System.String,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersDimensionsAsync(instrumentId,isin,wkn,custodyType,venueId,orderType,side,country,type)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersDimensionsAsync-System-String,System-String,System-String,System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderType3},System-Nullable{Comdirect-Rest-Api-Comdirect-Side2},System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-Type}- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersDimensionsAsync(System.String,System.String,System.String,System.String,System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType3},System.Nullable{Comdirect.Rest.Api.Comdirect.Side2},System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.Type})')
  - [BrokerageV3OrdersDimensionsAsync(cancellationToken,instrumentId,isin,wkn,custodyType,venueId,orderType,side,country,type)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersDimensionsAsync-System-String,System-String,System-String,System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderType3},System-Nullable{Comdirect-Rest-Api-Comdirect-Side2},System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-Type},System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersDimensionsAsync(System.String,System.String,System.String,System.String,System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType3},System.Nullable{Comdirect.Rest.Api.Comdirect.Side2},System.String,System.Nullable{Comdirect.Rest.Api.Comdirect.Type},System.Threading.CancellationToken)')
  - [BrokerageV3OrdersGetAsync(orderId,without_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersGetAsync-System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersGetAsync(System.String,System.String)')
  - [BrokerageV3OrdersGetAsync(cancellationToken,orderId,without_attr)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersGetAsync-System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersGetAsync(System.String,System.String,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersPatchAsync(orderId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPatchAsync-Comdirect-Rest-Api-Comdirect-Order,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersPatchAsync(Comdirect.Rest.Api.Comdirect.Order,System.String)')
  - [BrokerageV3OrdersPatchAsync(cancellationToken,orderId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPatchAsync-Comdirect-Rest-Api-Comdirect-Order,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersPatchAsync(Comdirect.Rest.Api.Comdirect.Order,System.String,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersPostAsync()](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPostAsync-Comdirect-Rest-Api-Comdirect-Order- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersPostAsync(Comdirect.Rest.Api.Comdirect.Order)')
  - [BrokerageV3OrdersPostAsync(cancellationToken)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersPostAsync(Comdirect.Rest.Api.Comdirect.Order,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersPrevalidationPostAsync()](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPrevalidationPostAsync-Comdirect-Rest-Api-Comdirect-Order- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersPrevalidationPostAsync(Comdirect.Rest.Api.Comdirect.Order)')
  - [BrokerageV3OrdersPrevalidationPostAsync(cancellationToken)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPrevalidationPostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersPrevalidationPostAsync(Comdirect.Rest.Api.Comdirect.Order,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersPrevalidationPostAsync(orderId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPrevalidationPostAsync-System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersPrevalidationPostAsync(System.String,System.String)')
  - [BrokerageV3OrdersPrevalidationPostAsync(cancellationToken,orderId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPrevalidationPostAsync-System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersPrevalidationPostAsync(System.String,System.String,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersValidationPostAsync()](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersValidationPostAsync-Comdirect-Rest-Api-Comdirect-Order- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersValidationPostAsync(Comdirect.Rest.Api.Comdirect.Order)')
  - [BrokerageV3OrdersValidationPostAsync(cancellationToken)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersValidationPostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersValidationPostAsync(Comdirect.Rest.Api.Comdirect.Order,System.Threading.CancellationToken)')
  - [BrokerageV3OrdersValidationPostAsync(orderId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersValidationPostAsync-System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersValidationPostAsync(System.String,System.String)')
  - [BrokerageV3OrdersValidationPostAsync(cancellationToken,orderId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersValidationPostAsync-System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3OrdersValidationPostAsync(System.String,System.String,System.Threading.CancellationToken)')
  - [BrokerageV3QuotesAsync()](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuotesAsync-Comdirect-Rest-Api-Comdirect-Quote- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3QuotesAsync(Comdirect.Rest.Api.Comdirect.Quote)')
  - [BrokerageV3QuotesAsync(cancellationToken)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuotesAsync-Comdirect-Rest-Api-Comdirect-Quote,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3QuotesAsync(Comdirect.Rest.Api.Comdirect.Quote,System.Threading.CancellationToken)')
  - [BrokerageV3QuoteticketPatchAsync(ticketId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuoteticketPatchAsync-System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3QuoteticketPatchAsync(System.String)')
  - [BrokerageV3QuoteticketPatchAsync(cancellationToken,ticketId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuoteticketPatchAsync-System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3QuoteticketPatchAsync(System.String,System.Threading.CancellationToken)')
  - [BrokerageV3QuoteticketPostAsync(order)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuoteticketPostAsync-Comdirect-Rest-Api-Comdirect-Order- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3QuoteticketPostAsync(Comdirect.Rest.Api.Comdirect.Order)')
  - [BrokerageV3QuoteticketPostAsync(cancellationToken,order)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuoteticketPostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.BrokerageV3QuoteticketPostAsync(Comdirect.Rest.Api.Comdirect.Order,System.Threading.CancellationToken)')
  - [MessagesClientsV2DocumentsAsync(user,paging_first,paging_count)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesClientsV2DocumentsAsync-System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.MessagesClientsV2DocumentsAsync(System.String,System.Nullable{System.Int32},System.Nullable{System.Int32})')
  - [MessagesClientsV2DocumentsAsync(cancellationToken,user,paging_first,paging_count)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesClientsV2DocumentsAsync-System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.MessagesClientsV2DocumentsAsync(System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Threading.CancellationToken)')
  - [MessagesV2DocumentsAsync(documentId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesV2DocumentsAsync-System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.MessagesV2DocumentsAsync(System.String)')
  - [MessagesV2DocumentsAsync(cancellationToken,documentId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesV2DocumentsAsync-System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.MessagesV2DocumentsAsync(System.String,System.Threading.CancellationToken)')
  - [MessagesV2DocumentsPredocumentAsync(documentId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesV2DocumentsPredocumentAsync-System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.MessagesV2DocumentsPredocumentAsync(System.String)')
  - [MessagesV2DocumentsPredocumentAsync(cancellationToken,documentId)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesV2DocumentsPredocumentAsync-System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.MessagesV2DocumentsPredocumentAsync(System.String,System.Threading.CancellationToken)')
  - [ReportsParticipantsV1AllbalancesAsync(user,clientConnectionType,targetClientId,without_attr,productType)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-ReportsParticipantsV1AllbalancesAsync-System-String,System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{Comdirect-Rest-Api-Comdirect-Anonymous2},System-Collections-Generic-IEnumerable{System-String}- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.ReportsParticipantsV1AllbalancesAsync(System.String,System.Collections.Generic.IEnumerable{System.String},System.Collections.Generic.IEnumerable{System.String},System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous2},System.Collections.Generic.IEnumerable{System.String})')
  - [ReportsParticipantsV1AllbalancesAsync(cancellationToken,user,clientConnectionType,targetClientId,without_attr,productType)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-ReportsParticipantsV1AllbalancesAsync-System-String,System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{Comdirect-Rest-Api-Comdirect-Anonymous2},System-Collections-Generic-IEnumerable{System-String},System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.ReportsParticipantsV1AllbalancesAsync(System.String,System.Collections.Generic.IEnumerable{System.String},System.Collections.Generic.IEnumerable{System.String},System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous2},System.Collections.Generic.IEnumerable{System.String},System.Threading.CancellationToken)')
  - [SessionClientsV1SessionsGetAsync(user)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsGetAsync-System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.SessionClientsV1SessionsGetAsync(System.String)')
  - [SessionClientsV1SessionsGetAsync(cancellationToken,user)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsGetAsync-System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.SessionClientsV1SessionsGetAsync(System.String,System.Threading.CancellationToken)')
  - [SessionClientsV1SessionsPatchAsync(user,session)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsPatchAsync-Comdirect-Rest-Api-Comdirect-Session,System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.SessionClientsV1SessionsPatchAsync(Comdirect.Rest.Api.Comdirect.Session,System.String,System.String)')
  - [SessionClientsV1SessionsPatchAsync(cancellationToken,user,session)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsPatchAsync-Comdirect-Rest-Api-Comdirect-Session,System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.SessionClientsV1SessionsPatchAsync(Comdirect.Rest.Api.Comdirect.Session,System.String,System.String,System.Threading.CancellationToken)')
  - [SessionClientsV1SessionsValidateAsync(user,session)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsValidateAsync-Comdirect-Rest-Api-Comdirect-Session,System-String,System-String- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.SessionClientsV1SessionsValidateAsync(Comdirect.Rest.Api.Comdirect.Session,System.String,System.String)')
  - [SessionClientsV1SessionsValidateAsync(cancellationToken,user,session)](#M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsValidateAsync-Comdirect-Rest-Api-Comdirect-Session,System-String,System-String,System-Threading-CancellationToken- 'Comdirect.Rest.Api.Comdirect.ComdirectClient.SessionClientsV1SessionsValidateAsync(Comdirect.Rest.Api.Comdirect.Session,System.String,System.String,System.Threading.CancellationToken)')
- [CostEntry](#T-Comdirect-Rest-Api-Comdirect-CostEntry 'Comdirect.Rest.Api.Comdirect.CostEntry')
  - [Amount](#P-Comdirect-Rest-Api-Comdirect-CostEntry-Amount 'Comdirect.Rest.Api.Comdirect.CostEntry.Amount')
  - [AmountReportingCurrency](#P-Comdirect-Rest-Api-Comdirect-CostEntry-AmountReportingCurrency 'Comdirect.Rest.Api.Comdirect.CostEntry.AmountReportingCurrency')
  - [Inducement](#P-Comdirect-Rest-Api-Comdirect-CostEntry-Inducement 'Comdirect.Rest.Api.Comdirect.CostEntry.Inducement')
  - [Label](#P-Comdirect-Rest-Api-Comdirect-CostEntry-Label 'Comdirect.Rest.Api.Comdirect.CostEntry.Label')
  - [Type](#P-Comdirect-Rest-Api-Comdirect-CostEntry-Type 'Comdirect.Rest.Api.Comdirect.CostEntry.Type')
- [CostGroup](#T-Comdirect-Rest-Api-Comdirect-CostGroup 'Comdirect.Rest.Api.Comdirect.CostGroup')
  - [Costs](#P-Comdirect-Rest-Api-Comdirect-CostGroup-Costs 'Comdirect.Rest.Api.Comdirect.CostGroup.Costs')
  - [Label](#P-Comdirect-Rest-Api-Comdirect-CostGroup-Label 'Comdirect.Rest.Api.Comdirect.CostGroup.Label')
  - [Sum](#P-Comdirect-Rest-Api-Comdirect-CostGroup-Sum 'Comdirect.Rest.Api.Comdirect.CostGroup.Sum')
  - [SumReportingCurrency](#P-Comdirect-Rest-Api-Comdirect-CostGroup-SumReportingCurrency 'Comdirect.Rest.Api.Comdirect.CostGroup.SumReportingCurrency')
  - [Type](#P-Comdirect-Rest-Api-Comdirect-CostGroup-Type 'Comdirect.Rest.Api.Comdirect.CostGroup.Type')
- [CostIndicationExAnte](#T-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte')
  - [CalculationSuccessful](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-CalculationSuccessful 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.CalculationSuccessful')
  - [DepotId](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-DepotId 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.DepotId')
  - [ExpectedSettlementCosts](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-ExpectedSettlementCosts 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.ExpectedSettlementCosts')
  - [ExpectedValue](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-ExpectedValue 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.ExpectedValue')
  - [FxRate](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-FxRate 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.FxRate')
  - [HoldingCosts](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-HoldingCosts 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.HoldingCosts')
  - [HoldingPeriod](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-HoldingPeriod 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.HoldingPeriod')
  - [Limit](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Limit 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.Limit')
  - [LinkCosts](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-LinkCosts 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.LinkCosts')
  - [LinkKid](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-LinkKid 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.LinkKid')
  - [Name](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Name 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.Name')
  - [PurchaseCosts](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-PurchaseCosts 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.PurchaseCosts')
  - [Quantity](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Quantity 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.Quantity')
  - [ReportingCurrency](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-ReportingCurrency 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.ReportingCurrency')
  - [SalesCosts](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-SalesCosts 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.SalesCosts')
  - [SettlementCurrency](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-SettlementCurrency 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.SettlementCurrency')
  - [Side](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Side 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.Side')
  - [TotalCostsAbs](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TotalCostsAbs 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.TotalCostsAbs')
  - [TotalCostsDetail](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TotalCostsDetail 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.TotalCostsDetail')
  - [TotalCostsRel](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TotalCostsRel 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.TotalCostsRel')
  - [TotalHoldingCosts](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TotalHoldingCosts 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.TotalHoldingCosts')
  - [TradingCurrency](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TradingCurrency 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.TradingCurrency')
  - [VenueName](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-VenueName 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.VenueName')
  - [Wkn](#P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Wkn 'Comdirect.Rest.Api.Comdirect.CostIndicationExAnte.Wkn')
- [Depot](#T-Comdirect-Rest-Api-Comdirect-Depot 'Comdirect.Rest.Api.Comdirect.Depot')
  - [ClientId](#P-Comdirect-Rest-Api-Comdirect-Depot-ClientId 'Comdirect.Rest.Api.Comdirect.Depot.ClientId')
  - [DefaultSettlementAccountId](#P-Comdirect-Rest-Api-Comdirect-Depot-DefaultSettlementAccountId 'Comdirect.Rest.Api.Comdirect.Depot.DefaultSettlementAccountId')
  - [DepotDisplayId](#P-Comdirect-Rest-Api-Comdirect-Depot-DepotDisplayId 'Comdirect.Rest.Api.Comdirect.Depot.DepotDisplayId')
  - [DepotId](#P-Comdirect-Rest-Api-Comdirect-Depot-DepotId 'Comdirect.Rest.Api.Comdirect.Depot.DepotId')
  - [SettlementAccountIds](#P-Comdirect-Rest-Api-Comdirect-Depot-SettlementAccountIds 'Comdirect.Rest.Api.Comdirect.Depot.SettlementAccountIds')
- [DepotAggregation](#T-Comdirect-Rest-Api-Comdirect-DepotAggregation 'Comdirect.Rest.Api.Comdirect.DepotAggregation')
  - [CurrentValue](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-CurrentValue 'Comdirect.Rest.Api.Comdirect.DepotAggregation.CurrentValue')
  - [DateLastUpdate](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-DateLastUpdate 'Comdirect.Rest.Api.Comdirect.DepotAggregation.DateLastUpdate')
  - [Depot](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-Depot 'Comdirect.Rest.Api.Comdirect.DepotAggregation.Depot')
  - [DepotId](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-DepotId 'Comdirect.Rest.Api.Comdirect.DepotAggregation.DepotId')
  - [LendingValue](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-LendingValue 'Comdirect.Rest.Api.Comdirect.DepotAggregation.LendingValue')
  - [PrevDayValue](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-PrevDayValue 'Comdirect.Rest.Api.Comdirect.DepotAggregation.PrevDayValue')
  - [ProfitLossPrevDayAbs](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-ProfitLossPrevDayAbs 'Comdirect.Rest.Api.Comdirect.DepotAggregation.ProfitLossPrevDayAbs')
  - [ProfitLossPrevDayRel](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-ProfitLossPrevDayRel 'Comdirect.Rest.Api.Comdirect.DepotAggregation.ProfitLossPrevDayRel')
  - [ProfitLossPurchaseAbs](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-ProfitLossPurchaseAbs 'Comdirect.Rest.Api.Comdirect.DepotAggregation.ProfitLossPurchaseAbs')
  - [ProfitLossPurchaseRel](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-ProfitLossPurchaseRel 'Comdirect.Rest.Api.Comdirect.DepotAggregation.ProfitLossPurchaseRel')
  - [PurchaseValue](#P-Comdirect-Rest-Api-Comdirect-DepotAggregation-PurchaseValue 'Comdirect.Rest.Api.Comdirect.DepotAggregation.PurchaseValue')
- [DepotPosition](#T-Comdirect-Rest-Api-Comdirect-DepotPosition 'Comdirect.Rest.Api.Comdirect.DepotPosition')
  - [AvailableQuantity](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-AvailableQuantity 'Comdirect.Rest.Api.Comdirect.DepotPosition.AvailableQuantity')
  - [CurrentPrice](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-CurrentPrice 'Comdirect.Rest.Api.Comdirect.DepotPosition.CurrentPrice')
  - [CurrentValue](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-CurrentValue 'Comdirect.Rest.Api.Comdirect.DepotPosition.CurrentValue')
  - [CustodyType](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-CustodyType 'Comdirect.Rest.Api.Comdirect.DepotPosition.CustodyType')
  - [DepotId](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-DepotId 'Comdirect.Rest.Api.Comdirect.DepotPosition.DepotId')
  - [Instrument](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-Instrument 'Comdirect.Rest.Api.Comdirect.DepotPosition.Instrument')
  - [PositionId](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-PositionId 'Comdirect.Rest.Api.Comdirect.DepotPosition.PositionId')
  - [PrevDayPrice](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-PrevDayPrice 'Comdirect.Rest.Api.Comdirect.DepotPosition.PrevDayPrice')
  - [PrevDayValue](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-PrevDayValue 'Comdirect.Rest.Api.Comdirect.DepotPosition.PrevDayValue')
  - [ProfitLossPrevDayAbs](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-ProfitLossPrevDayAbs 'Comdirect.Rest.Api.Comdirect.DepotPosition.ProfitLossPrevDayAbs')
  - [ProfitLossPrevDayRel](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-ProfitLossPrevDayRel 'Comdirect.Rest.Api.Comdirect.DepotPosition.ProfitLossPrevDayRel')
  - [ProfitLossPurchaseAbs](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-ProfitLossPurchaseAbs 'Comdirect.Rest.Api.Comdirect.DepotPosition.ProfitLossPurchaseAbs')
  - [ProfitLossPurchaseRel](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-ProfitLossPurchaseRel 'Comdirect.Rest.Api.Comdirect.DepotPosition.ProfitLossPurchaseRel')
  - [PurchasePrice](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-PurchasePrice 'Comdirect.Rest.Api.Comdirect.DepotPosition.PurchasePrice')
  - [PurchaseValue](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-PurchaseValue 'Comdirect.Rest.Api.Comdirect.DepotPosition.PurchaseValue')
  - [Quantity](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-Quantity 'Comdirect.Rest.Api.Comdirect.DepotPosition.Quantity')
  - [Version](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-Version 'Comdirect.Rest.Api.Comdirect.DepotPosition.Version')
  - [Wkn](#P-Comdirect-Rest-Api-Comdirect-DepotPosition-Wkn 'Comdirect.Rest.Api.Comdirect.DepotPosition.Wkn')
- [DepotTransaction](#T-Comdirect-Rest-Api-Comdirect-DepotTransaction 'Comdirect.Rest.Api.Comdirect.DepotTransaction')
  - [BookingDate](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-BookingDate 'Comdirect.Rest.Api.Comdirect.DepotTransaction.BookingDate')
  - [BookingStatus](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-BookingStatus 'Comdirect.Rest.Api.Comdirect.DepotTransaction.BookingStatus')
  - [BusinessDate](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-BusinessDate 'Comdirect.Rest.Api.Comdirect.DepotTransaction.BusinessDate')
  - [ExecutionPrice](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-ExecutionPrice 'Comdirect.Rest.Api.Comdirect.DepotTransaction.ExecutionPrice')
  - [FxRate](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-FxRate 'Comdirect.Rest.Api.Comdirect.DepotTransaction.FxRate')
  - [Instrument](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-Instrument 'Comdirect.Rest.Api.Comdirect.DepotTransaction.Instrument')
  - [InstrumentId](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-InstrumentId 'Comdirect.Rest.Api.Comdirect.DepotTransaction.InstrumentId')
  - [Quantity](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-Quantity 'Comdirect.Rest.Api.Comdirect.DepotTransaction.Quantity')
  - [SettlementDate](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-SettlementDate 'Comdirect.Rest.Api.Comdirect.DepotTransaction.SettlementDate')
  - [TransactionDirection](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-TransactionDirection 'Comdirect.Rest.Api.Comdirect.DepotTransaction.TransactionDirection')
  - [TransactionId](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-TransactionId 'Comdirect.Rest.Api.Comdirect.DepotTransaction.TransactionId')
  - [TransactionType](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-TransactionType 'Comdirect.Rest.Api.Comdirect.DepotTransaction.TransactionType')
  - [TransactionValue](#P-Comdirect-Rest-Api-Comdirect-DepotTransaction-TransactionValue 'Comdirect.Rest.Api.Comdirect.DepotTransaction.TransactionValue')
- [DerivativeData](#T-Comdirect-Rest-Api-Comdirect-DerivativeData 'Comdirect.Rest.Api.Comdirect.DerivativeData')
  - [CertificateType](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-CertificateType 'Comdirect.Rest.Api.Comdirect.DerivativeData.CertificateType')
  - [ExpiryDate](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-ExpiryDate 'Comdirect.Rest.Api.Comdirect.DerivativeData.ExpiryDate')
  - [InterestPaymentDate](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-InterestPaymentDate 'Comdirect.Rest.Api.Comdirect.DerivativeData.InterestPaymentDate')
  - [InterestPaymentInterval](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-InterestPaymentInterval 'Comdirect.Rest.Api.Comdirect.DerivativeData.InterestPaymentInterval')
  - [Leverage](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-Leverage 'Comdirect.Rest.Api.Comdirect.DerivativeData.Leverage')
  - [MaturityDate](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-MaturityDate 'Comdirect.Rest.Api.Comdirect.DerivativeData.MaturityDate')
  - [Multiplier](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-Multiplier 'Comdirect.Rest.Api.Comdirect.DerivativeData.Multiplier')
  - [NominalRate](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-NominalRate 'Comdirect.Rest.Api.Comdirect.DerivativeData.NominalRate')
  - [Rating](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-Rating 'Comdirect.Rest.Api.Comdirect.DerivativeData.Rating')
  - [RemainingTermInYears](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-RemainingTermInYears 'Comdirect.Rest.Api.Comdirect.DerivativeData.RemainingTermInYears')
  - [StrikePrice](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-StrikePrice 'Comdirect.Rest.Api.Comdirect.DerivativeData.StrikePrice')
  - [UnderlyingInstrument](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-UnderlyingInstrument 'Comdirect.Rest.Api.Comdirect.DerivativeData.UnderlyingInstrument')
  - [UnderlyingPrice](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-UnderlyingPrice 'Comdirect.Rest.Api.Comdirect.DerivativeData.UnderlyingPrice')
  - [WarrantType](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-WarrantType 'Comdirect.Rest.Api.Comdirect.DerivativeData.WarrantType')
  - [YieldPA](#P-Comdirect-Rest-Api-Comdirect-DerivativeData-YieldPA 'Comdirect.Rest.Api.Comdirect.DerivativeData.YieldPA')
- [Dimensions](#T-Comdirect-Rest-Api-Comdirect-Dimensions 'Comdirect.Rest.Api.Comdirect.Dimensions')
- [Document](#T-Comdirect-Rest-Api-Comdirect-Document 'Comdirect.Rest.Api.Comdirect.Document')
  - [Advertisement](#P-Comdirect-Rest-Api-Comdirect-Document-Advertisement 'Comdirect.Rest.Api.Comdirect.Document.Advertisement')
  - [DateCreation](#P-Comdirect-Rest-Api-Comdirect-Document-DateCreation 'Comdirect.Rest.Api.Comdirect.Document.DateCreation')
  - [Deletable](#P-Comdirect-Rest-Api-Comdirect-Document-Deletable 'Comdirect.Rest.Api.Comdirect.Document.Deletable')
  - [DocumentId](#P-Comdirect-Rest-Api-Comdirect-Document-DocumentId 'Comdirect.Rest.Api.Comdirect.Document.DocumentId')
  - [DocumentMetaData](#P-Comdirect-Rest-Api-Comdirect-Document-DocumentMetaData 'Comdirect.Rest.Api.Comdirect.Document.DocumentMetaData')
  - [MimeType](#P-Comdirect-Rest-Api-Comdirect-Document-MimeType 'Comdirect.Rest.Api.Comdirect.Document.MimeType')
  - [Name](#P-Comdirect-Rest-Api-Comdirect-Document-Name 'Comdirect.Rest.Api.Comdirect.Document.Name')
- [DocumentMetadata](#T-Comdirect-Rest-Api-Comdirect-DocumentMetadata 'Comdirect.Rest.Api.Comdirect.DocumentMetadata')
  - [AlreadyRead](#P-Comdirect-Rest-Api-Comdirect-DocumentMetadata-AlreadyRead 'Comdirect.Rest.Api.Comdirect.DocumentMetadata.AlreadyRead')
  - [Archived](#P-Comdirect-Rest-Api-Comdirect-DocumentMetadata-Archived 'Comdirect.Rest.Api.Comdirect.DocumentMetadata.Archived')
  - [DateRead](#P-Comdirect-Rest-Api-Comdirect-DocumentMetadata-DateRead 'Comdirect.Rest.Api.Comdirect.DocumentMetadata.DateRead')
- [EnumText](#T-Comdirect-Rest-Api-Comdirect-EnumText 'Comdirect.Rest.Api.Comdirect.EnumText')
  - [Key](#P-Comdirect-Rest-Api-Comdirect-EnumText-Key 'Comdirect.Rest.Api.Comdirect.EnumText.Key')
  - [Text](#P-Comdirect-Rest-Api-Comdirect-EnumText-Text 'Comdirect.Rest.Api.Comdirect.EnumText.Text')
- [Execution](#T-Comdirect-Rest-Api-Comdirect-Execution 'Comdirect.Rest.Api.Comdirect.Execution')
  - [ExecutedQuantity](#P-Comdirect-Rest-Api-Comdirect-Execution-ExecutedQuantity 'Comdirect.Rest.Api.Comdirect.Execution.ExecutedQuantity')
  - [ExecutionId](#P-Comdirect-Rest-Api-Comdirect-Execution-ExecutionId 'Comdirect.Rest.Api.Comdirect.Execution.ExecutionId')
  - [ExecutionNumber](#P-Comdirect-Rest-Api-Comdirect-Execution-ExecutionNumber 'Comdirect.Rest.Api.Comdirect.Execution.ExecutionNumber')
  - [ExecutionPrice](#P-Comdirect-Rest-Api-Comdirect-Execution-ExecutionPrice 'Comdirect.Rest.Api.Comdirect.Execution.ExecutionPrice')
  - [ExecutionTimestamp](#P-Comdirect-Rest-Api-Comdirect-Execution-ExecutionTimestamp 'Comdirect.Rest.Api.Comdirect.Execution.ExecutionTimestamp')
- [FXRateEUR](#T-Comdirect-Rest-Api-Comdirect-FXRateEUR 'Comdirect.Rest.Api.Comdirect.FXRateEUR')
  - [Ask](#P-Comdirect-Rest-Api-Comdirect-FXRateEUR-Ask 'Comdirect.Rest.Api.Comdirect.FXRateEUR.Ask')
  - [Bid](#P-Comdirect-Rest-Api-Comdirect-FXRateEUR-Bid 'Comdirect.Rest.Api.Comdirect.FXRateEUR.Bid')
- [FixedTermSavings](#T-Comdirect-Rest-Api-Comdirect-FixedTermSavings 'Comdirect.Rest.Api.Comdirect.FixedTermSavings')
  - [ContractPeriodInMonths](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-ContractPeriodInMonths 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.ContractPeriodInMonths')
  - [CreationDate](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-CreationDate 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.CreationDate')
  - [ExpirationDate](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-ExpirationDate 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.ExpirationDate')
  - [Extendable](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-Extendable 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.Extendable')
  - [FixedTermSavingsDisplayName](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-FixedTermSavingsDisplayName 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.FixedTermSavingsDisplayName')
  - [FixedTermSavingsId](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-FixedTermSavingsId 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.FixedTermSavingsId')
  - [FixedTermSavingsType](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-FixedTermSavingsType 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.FixedTermSavingsType')
  - [InterestRate](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-InterestRate 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.InterestRate')
  - [ProlongationAmount](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-ProlongationAmount 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.ProlongationAmount')
  - [SavingsAmount](#P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-SavingsAmount 'Comdirect.Rest.Api.Comdirect.FixedTermSavings.SavingsAmount')
- [FundDistribution](#T-Comdirect-Rest-Api-Comdirect-FundDistribution 'Comdirect.Rest.Api.Comdirect.FundDistribution')
  - [Bonification](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-Bonification 'Comdirect.Rest.Api.Comdirect.FundDistribution.Bonification')
  - [Currency](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-Currency 'Comdirect.Rest.Api.Comdirect.FundDistribution.Currency')
  - [DiscountIssueSurcharge](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-DiscountIssueSurcharge 'Comdirect.Rest.Api.Comdirect.FundDistribution.DiscountIssueSurcharge')
  - [FundFlags](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-FundFlags 'Comdirect.Rest.Api.Comdirect.FundDistribution.FundFlags')
  - [FundStatus](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-FundStatus 'Comdirect.Rest.Api.Comdirect.FundDistribution.FundStatus')
  - [IndividualIssueSurcharge](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-IndividualIssueSurcharge 'Comdirect.Rest.Api.Comdirect.FundDistribution.IndividualIssueSurcharge')
  - [InvestmentCategory](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-InvestmentCategory 'Comdirect.Rest.Api.Comdirect.FundDistribution.InvestmentCategory')
  - [IsIndividualIssueSurchargeCorrected](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-IsIndividualIssueSurchargeCorrected 'Comdirect.Rest.Api.Comdirect.FundDistribution.IsIndividualIssueSurchargeCorrected')
  - [Rating](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-Rating 'Comdirect.Rest.Api.Comdirect.FundDistribution.Rating')
  - [ReducedIssueSurcharge](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-ReducedIssueSurcharge 'Comdirect.Rest.Api.Comdirect.FundDistribution.ReducedIssueSurcharge')
  - [RegularIssueSurcharge](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-RegularIssueSurcharge 'Comdirect.Rest.Api.Comdirect.FundDistribution.RegularIssueSurcharge')
  - [TotalExpenseRatio](#P-Comdirect-Rest-Api-Comdirect-FundDistribution-TotalExpenseRatio 'Comdirect.Rest.Api.Comdirect.FundDistribution.TotalExpenseRatio')
- [Inducement](#T-Comdirect-Rest-Api-Comdirect-Inducement 'Comdirect.Rest.Api.Comdirect.Inducement')
  - [Amount](#P-Comdirect-Rest-Api-Comdirect-Inducement-Amount 'Comdirect.Rest.Api.Comdirect.Inducement.Amount')
  - [Estimated](#P-Comdirect-Rest-Api-Comdirect-Inducement-Estimated 'Comdirect.Rest.Api.Comdirect.Inducement.Estimated')
- [InstallmentLoan](#T-Comdirect-Rest-Api-Comdirect-InstallmentLoan 'Comdirect.Rest.Api.Comdirect.InstallmentLoan')
  - [ContractConclusionDate](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-ContractConclusionDate 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.ContractConclusionDate')
  - [ContractPeriodInMonths](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-ContractPeriodInMonths 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.ContractPeriodInMonths')
  - [CreditAmount](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-CreditAmount 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.CreditAmount')
  - [EffectiveInterest](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-EffectiveInterest 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.EffectiveInterest')
  - [InstallmentAmount](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-InstallmentAmount 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.InstallmentAmount')
  - [InstallmentLoanId](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-InstallmentLoanId 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.InstallmentLoanId')
  - [NetCreditAmount](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-NetCreditAmount 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.NetCreditAmount')
  - [NominalInterest](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-NominalInterest 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.NominalInterest')
  - [PaidOutAmount](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-PaidOutAmount 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.PaidOutAmount')
  - [ProductDisplayId](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-ProductDisplayId 'Comdirect.Rest.Api.Comdirect.InstallmentLoan.ProductDisplayId')
- [InstallmentLoanBalance](#T-Comdirect-Rest-Api-Comdirect-InstallmentLoanBalance 'Comdirect.Rest.Api.Comdirect.InstallmentLoanBalance')
  - [Balance](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoanBalance-Balance 'Comdirect.Rest.Api.Comdirect.InstallmentLoanBalance.Balance')
  - [InstallmentLoan](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoanBalance-InstallmentLoan 'Comdirect.Rest.Api.Comdirect.InstallmentLoanBalance.InstallmentLoan')
  - [InstallmentLoanId](#P-Comdirect-Rest-Api-Comdirect-InstallmentLoanBalance-InstallmentLoanId 'Comdirect.Rest.Api.Comdirect.InstallmentLoanBalance.InstallmentLoanId')
- [Instrument](#T-Comdirect-Rest-Api-Comdirect-Instrument 'Comdirect.Rest.Api.Comdirect.Instrument')
  - [DerivativeData](#P-Comdirect-Rest-Api-Comdirect-Instrument-DerivativeData 'Comdirect.Rest.Api.Comdirect.Instrument.DerivativeData')
  - [FundsDistribution](#P-Comdirect-Rest-Api-Comdirect-Instrument-FundsDistribution 'Comdirect.Rest.Api.Comdirect.Instrument.FundsDistribution')
  - [InstrumentId](#P-Comdirect-Rest-Api-Comdirect-Instrument-InstrumentId 'Comdirect.Rest.Api.Comdirect.Instrument.InstrumentId')
  - [Isin](#P-Comdirect-Rest-Api-Comdirect-Instrument-Isin 'Comdirect.Rest.Api.Comdirect.Instrument.Isin')
  - [Mnemonic](#P-Comdirect-Rest-Api-Comdirect-Instrument-Mnemonic 'Comdirect.Rest.Api.Comdirect.Instrument.Mnemonic')
  - [Name](#P-Comdirect-Rest-Api-Comdirect-Instrument-Name 'Comdirect.Rest.Api.Comdirect.Instrument.Name')
  - [OrderDimensions](#P-Comdirect-Rest-Api-Comdirect-Instrument-OrderDimensions 'Comdirect.Rest.Api.Comdirect.Instrument.OrderDimensions')
  - [ShortName](#P-Comdirect-Rest-Api-Comdirect-Instrument-ShortName 'Comdirect.Rest.Api.Comdirect.Instrument.ShortName')
  - [StaticData](#P-Comdirect-Rest-Api-Comdirect-Instrument-StaticData 'Comdirect.Rest.Api.Comdirect.Instrument.StaticData')
  - [Wkn](#P-Comdirect-Rest-Api-Comdirect-Instrument-Wkn 'Comdirect.Rest.Api.Comdirect.Instrument.Wkn')
- [Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order')
  - [BestEx](#P-Comdirect-Rest-Api-Comdirect-Order-BestEx 'Comdirect.Rest.Api.Comdirect.Order.BestEx')
  - [CancelledQuantity](#P-Comdirect-Rest-Api-Comdirect-Order-CancelledQuantity 'Comdirect.Rest.Api.Comdirect.Order.CancelledQuantity')
  - [CreationTimestamp](#P-Comdirect-Rest-Api-Comdirect-Order-CreationTimestamp 'Comdirect.Rest.Api.Comdirect.Order.CreationTimestamp')
  - [DepotId](#P-Comdirect-Rest-Api-Comdirect-Order-DepotId 'Comdirect.Rest.Api.Comdirect.Order.DepotId')
  - [ExecutedQuantity](#P-Comdirect-Rest-Api-Comdirect-Order-ExecutedQuantity 'Comdirect.Rest.Api.Comdirect.Order.ExecutedQuantity')
  - [Executions](#P-Comdirect-Rest-Api-Comdirect-Order-Executions 'Comdirect.Rest.Api.Comdirect.Order.Executions')
  - [ExpectedValue](#P-Comdirect-Rest-Api-Comdirect-Order-ExpectedValue 'Comdirect.Rest.Api.Comdirect.Order.ExpectedValue')
  - [InstrumentId](#P-Comdirect-Rest-Api-Comdirect-Order-InstrumentId 'Comdirect.Rest.Api.Comdirect.Order.InstrumentId')
  - [LegNumber](#P-Comdirect-Rest-Api-Comdirect-Order-LegNumber 'Comdirect.Rest.Api.Comdirect.Order.LegNumber')
  - [Limit](#P-Comdirect-Rest-Api-Comdirect-Order-Limit 'Comdirect.Rest.Api.Comdirect.Order.Limit')
  - [LimitExtension](#P-Comdirect-Rest-Api-Comdirect-Order-LimitExtension 'Comdirect.Rest.Api.Comdirect.Order.LimitExtension')
  - [OpenQuantity](#P-Comdirect-Rest-Api-Comdirect-Order-OpenQuantity 'Comdirect.Rest.Api.Comdirect.Order.OpenQuantity')
  - [OrderId](#P-Comdirect-Rest-Api-Comdirect-Order-OrderId 'Comdirect.Rest.Api.Comdirect.Order.OrderId')
  - [OrderStatus](#P-Comdirect-Rest-Api-Comdirect-Order-OrderStatus 'Comdirect.Rest.Api.Comdirect.Order.OrderStatus')
  - [OrderType](#P-Comdirect-Rest-Api-Comdirect-Order-OrderType 'Comdirect.Rest.Api.Comdirect.Order.OrderType')
  - [Quantity](#P-Comdirect-Rest-Api-Comdirect-Order-Quantity 'Comdirect.Rest.Api.Comdirect.Order.Quantity')
  - [QuoteId](#P-Comdirect-Rest-Api-Comdirect-Order-QuoteId 'Comdirect.Rest.Api.Comdirect.Order.QuoteId')
  - [QuoteTicketId](#P-Comdirect-Rest-Api-Comdirect-Order-QuoteTicketId 'Comdirect.Rest.Api.Comdirect.Order.QuoteTicketId')
  - [SettlementAccountId](#P-Comdirect-Rest-Api-Comdirect-Order-SettlementAccountId 'Comdirect.Rest.Api.Comdirect.Order.SettlementAccountId')
  - [Side](#P-Comdirect-Rest-Api-Comdirect-Order-Side 'Comdirect.Rest.Api.Comdirect.Order.Side')
  - [SubOrders](#P-Comdirect-Rest-Api-Comdirect-Order-SubOrders 'Comdirect.Rest.Api.Comdirect.Order.SubOrders')
  - [TradingRestriction](#P-Comdirect-Rest-Api-Comdirect-Order-TradingRestriction 'Comdirect.Rest.Api.Comdirect.Order.TradingRestriction')
  - [TrailingLimitDistAbs](#P-Comdirect-Rest-Api-Comdirect-Order-TrailingLimitDistAbs 'Comdirect.Rest.Api.Comdirect.Order.TrailingLimitDistAbs')
  - [TrailingLimitDistRel](#P-Comdirect-Rest-Api-Comdirect-Order-TrailingLimitDistRel 'Comdirect.Rest.Api.Comdirect.Order.TrailingLimitDistRel')
  - [TriggerLimit](#P-Comdirect-Rest-Api-Comdirect-Order-TriggerLimit 'Comdirect.Rest.Api.Comdirect.Order.TriggerLimit')
  - [Validity](#P-Comdirect-Rest-Api-Comdirect-Order-Validity 'Comdirect.Rest.Api.Comdirect.Order.Validity')
  - [ValidityType](#P-Comdirect-Rest-Api-Comdirect-Order-ValidityType 'Comdirect.Rest.Api.Comdirect.Order.ValidityType')
  - [VenueId](#P-Comdirect-Rest-Api-Comdirect-Order-VenueId 'Comdirect.Rest.Api.Comdirect.Order.VenueId')
  - [Version](#P-Comdirect-Rest-Api-Comdirect-Order-Version 'Comdirect.Rest.Api.Comdirect.Order.Version')
- [OrderStatus](#T-Comdirect-Rest-Api-Comdirect-OrderStatus 'Comdirect.Rest.Api.Comdirect.OrderStatus')
- [OrderType](#T-Comdirect-Rest-Api-Comdirect-OrderType 'Comdirect.Rest.Api.Comdirect.OrderType')
  - [LimitExtensions](#P-Comdirect-Rest-Api-Comdirect-OrderType-LimitExtensions 'Comdirect.Rest.Api.Comdirect.OrderType.LimitExtensions')
  - [TradingRestrictions](#P-Comdirect-Rest-Api-Comdirect-OrderType-TradingRestrictions 'Comdirect.Rest.Api.Comdirect.OrderType.TradingRestrictions')
- [OrderType2](#T-Comdirect-Rest-Api-Comdirect-OrderType2 'Comdirect.Rest.Api.Comdirect.OrderType2')
- [OrderType3](#T-Comdirect-Rest-Api-Comdirect-OrderType3 'Comdirect.Rest.Api.Comdirect.OrderType3')
- [PercentageString](#T-Comdirect-Rest-Api-Comdirect-PercentageString 'Comdirect.Rest.Api.Comdirect.PercentageString')
  - [DecimalPlaces](#P-Comdirect-Rest-Api-Comdirect-PercentageString-DecimalPlaces 'Comdirect.Rest.Api.Comdirect.PercentageString.DecimalPlaces')
  - [PreDecimalPlaces](#P-Comdirect-Rest-Api-Comdirect-PercentageString-PreDecimalPlaces 'Comdirect.Rest.Api.Comdirect.PercentageString.PreDecimalPlaces')
- [Price](#T-Comdirect-Rest-Api-Comdirect-Price 'Comdirect.Rest.Api.Comdirect.Price')
  - [Price1](#P-Comdirect-Rest-Api-Comdirect-Price-Price1 'Comdirect.Rest.Api.Comdirect.Price.Price1')
  - [PriceDateTime](#P-Comdirect-Rest-Api-Comdirect-Price-PriceDateTime 'Comdirect.Rest.Api.Comdirect.Price.PriceDateTime')
  - [Quantity](#P-Comdirect-Rest-Api-Comdirect-Price-Quantity 'Comdirect.Rest.Api.Comdirect.Price.Quantity')
  - [Type](#P-Comdirect-Rest-Api-Comdirect-Price-Type 'Comdirect.Rest.Api.Comdirect.Price.Type')
- [ProductBalance](#T-Comdirect-Rest-Api-Comdirect-ProductBalance 'Comdirect.Rest.Api.Comdirect.ProductBalance')
  - [Balance](#P-Comdirect-Rest-Api-Comdirect-ProductBalance-Balance 'Comdirect.Rest.Api.Comdirect.ProductBalance.Balance')
  - [ClientConnectionType](#P-Comdirect-Rest-Api-Comdirect-ProductBalance-ClientConnectionType 'Comdirect.Rest.Api.Comdirect.ProductBalance.ClientConnectionType')
  - [ProductId](#P-Comdirect-Rest-Api-Comdirect-ProductBalance-ProductId 'Comdirect.Rest.Api.Comdirect.ProductBalance.ProductId')
  - [ProductType](#P-Comdirect-Rest-Api-Comdirect-ProductBalance-ProductType 'Comdirect.Rest.Api.Comdirect.ProductBalance.ProductType')
  - [TargetClientId](#P-Comdirect-Rest-Api-Comdirect-ProductBalance-TargetClientId 'Comdirect.Rest.Api.Comdirect.ProductBalance.TargetClientId')
- [Quote](#T-Comdirect-Rest-Api-Comdirect-Quote 'Comdirect.Rest.Api.Comdirect.Quote')
  - [DepotId](#P-Comdirect-Rest-Api-Comdirect-Quote-DepotId 'Comdirect.Rest.Api.Comdirect.Quote.DepotId')
  - [InstrumentId](#P-Comdirect-Rest-Api-Comdirect-Quote-InstrumentId 'Comdirect.Rest.Api.Comdirect.Quote.InstrumentId')
  - [Quantity](#P-Comdirect-Rest-Api-Comdirect-Quote-Quantity 'Comdirect.Rest.Api.Comdirect.Quote.Quantity')
  - [Side](#P-Comdirect-Rest-Api-Comdirect-Quote-Side 'Comdirect.Rest.Api.Comdirect.Quote.Side')
  - [VenueId](#P-Comdirect-Rest-Api-Comdirect-Quote-VenueId 'Comdirect.Rest.Api.Comdirect.Quote.VenueId')
- [Rating](#T-Comdirect-Rest-Api-Comdirect-Rating 'Comdirect.Rest.Api.Comdirect.Rating')
  - [Moodys](#P-Comdirect-Rest-Api-Comdirect-Rating-Moodys 'Comdirect.Rest.Api.Comdirect.Rating.Moodys')
  - [Morningstar](#P-Comdirect-Rest-Api-Comdirect-Rating-Morningstar 'Comdirect.Rest.Api.Comdirect.Rating.Morningstar')
- [Session](#T-Comdirect-Rest-Api-Comdirect-Session 'Comdirect.Rest.Api.Comdirect.Session')
  - [Activated2FA](#P-Comdirect-Rest-Api-Comdirect-Session-Activated2FA 'Comdirect.Rest.Api.Comdirect.Session.Activated2FA')
  - [Identifier](#P-Comdirect-Rest-Api-Comdirect-Session-Identifier 'Comdirect.Rest.Api.Comdirect.Session.Identifier')
  - [SessionTanActive](#P-Comdirect-Rest-Api-Comdirect-Session-SessionTanActive 'Comdirect.Rest.Api.Comdirect.Session.SessionTanActive')
- [Side](#T-Comdirect-Rest-Api-Comdirect-Side 'Comdirect.Rest.Api.Comdirect.Side')
- [Side2](#T-Comdirect-Rest-Api-Comdirect-Side2 'Comdirect.Rest.Api.Comdirect.Side2')
- [StaticData](#T-Comdirect-Rest-Api-Comdirect-StaticData 'Comdirect.Rest.Api.Comdirect.StaticData')
  - [Currency](#P-Comdirect-Rest-Api-Comdirect-StaticData-Currency 'Comdirect.Rest.Api.Comdirect.StaticData.Currency')
  - [FundRedemptionLimited](#P-Comdirect-Rest-Api-Comdirect-StaticData-FundRedemptionLimited 'Comdirect.Rest.Api.Comdirect.StaticData.FundRedemptionLimited')
  - [InstrumentType](#P-Comdirect-Rest-Api-Comdirect-StaticData-InstrumentType 'Comdirect.Rest.Api.Comdirect.StaticData.InstrumentType')
  - [KidAvailable](#P-Comdirect-Rest-Api-Comdirect-StaticData-KidAvailable 'Comdirect.Rest.Api.Comdirect.StaticData.KidAvailable')
  - [Notation](#P-Comdirect-Rest-Api-Comdirect-StaticData-Notation 'Comdirect.Rest.Api.Comdirect.StaticData.Notation')
  - [PriipsRelevant](#P-Comdirect-Rest-Api-Comdirect-StaticData-PriipsRelevant 'Comdirect.Rest.Api.Comdirect.StaticData.PriipsRelevant')
  - [ShippingWaiverRequired](#P-Comdirect-Rest-Api-Comdirect-StaticData-ShippingWaiverRequired 'Comdirect.Rest.Api.Comdirect.StaticData.ShippingWaiverRequired')
- [TimestampString](#T-Comdirect-Rest-Api-Comdirect-TimestampString 'Comdirect.Rest.Api.Comdirect.TimestampString')
  - [Timestamp](#P-Comdirect-Rest-Api-Comdirect-TimestampString-Timestamp 'Comdirect.Rest.Api.Comdirect.TimestampString.Timestamp')
- [TotalCostBlock](#T-Comdirect-Rest-Api-Comdirect-TotalCostBlock 'Comdirect.Rest.Api.Comdirect.TotalCostBlock')
  - [ExternalCosts](#P-Comdirect-Rest-Api-Comdirect-TotalCostBlock-ExternalCosts 'Comdirect.Rest.Api.Comdirect.TotalCostBlock.ExternalCosts')
  - [ProductCosts](#P-Comdirect-Rest-Api-Comdirect-TotalCostBlock-ProductCosts 'Comdirect.Rest.Api.Comdirect.TotalCostBlock.ProductCosts')
  - [ServiceCosts](#P-Comdirect-Rest-Api-Comdirect-TotalCostBlock-ServiceCosts 'Comdirect.Rest.Api.Comdirect.TotalCostBlock.ServiceCosts')
  - [ServiceInducement](#P-Comdirect-Rest-Api-Comdirect-TotalCostBlock-ServiceInducement 'Comdirect.Rest.Api.Comdirect.TotalCostBlock.ServiceInducement')
- [TotalCostEntry](#T-Comdirect-Rest-Api-Comdirect-TotalCostEntry 'Comdirect.Rest.Api.Comdirect.TotalCostEntry')
  - [Amount](#P-Comdirect-Rest-Api-Comdirect-TotalCostEntry-Amount 'Comdirect.Rest.Api.Comdirect.TotalCostEntry.Amount')
  - [AverageReturnPA](#P-Comdirect-Rest-Api-Comdirect-TotalCostEntry-AverageReturnPA 'Comdirect.Rest.Api.Comdirect.TotalCostEntry.AverageReturnPA')
  - [Label](#P-Comdirect-Rest-Api-Comdirect-TotalCostEntry-Label 'Comdirect.Rest.Api.Comdirect.TotalCostEntry.Label')
  - [Type](#P-Comdirect-Rest-Api-Comdirect-TotalCostEntry-Type 'Comdirect.Rest.Api.Comdirect.TotalCostEntry.Type')
- [TotalHoldingCostBlock](#T-Comdirect-Rest-Api-Comdirect-TotalHoldingCostBlock 'Comdirect.Rest.Api.Comdirect.TotalHoldingCostBlock')
  - [Sales](#P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostBlock-Sales 'Comdirect.Rest.Api.Comdirect.TotalHoldingCostBlock.Sales')
  - [Year1](#P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostBlock-Year1 'Comdirect.Rest.Api.Comdirect.TotalHoldingCostBlock.Year1')
  - [Year2](#P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostBlock-Year2 'Comdirect.Rest.Api.Comdirect.TotalHoldingCostBlock.Year2')
- [TotalHoldingCostEntry](#T-Comdirect-Rest-Api-Comdirect-TotalHoldingCostEntry 'Comdirect.Rest.Api.Comdirect.TotalHoldingCostEntry')
  - [Amount](#P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostEntry-Amount 'Comdirect.Rest.Api.Comdirect.TotalHoldingCostEntry.Amount')
  - [AverageReturnPA](#P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostEntry-AverageReturnPA 'Comdirect.Rest.Api.Comdirect.TotalHoldingCostEntry.AverageReturnPA')
  - [Type](#P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostEntry-Type 'Comdirect.Rest.Api.Comdirect.TotalHoldingCostEntry.Type')
- [TransactionDirection](#T-Comdirect-Rest-Api-Comdirect-TransactionDirection 'Comdirect.Rest.Api.Comdirect.TransactionDirection')
- [TransactionState](#T-Comdirect-Rest-Api-Comdirect-TransactionState 'Comdirect.Rest.Api.Comdirect.TransactionState')
- [Type](#T-Comdirect-Rest-Api-Comdirect-Type 'Comdirect.Rest.Api.Comdirect.Type')
- [Venue](#T-Comdirect-Rest-Api-Comdirect-Venue 'Comdirect.Rest.Api.Comdirect.Venue')
- [VisaCardImage](#T-Comdirect-Rest-Api-Comdirect-VisaCardImage 'Comdirect.Rest.Api.Comdirect.VisaCardImage')
  - [ImageBaseFilename](#P-Comdirect-Rest-Api-Comdirect-VisaCardImage-ImageBaseFilename 'Comdirect.Rest.Api.Comdirect.VisaCardImage.ImageBaseFilename')
  - [ImageDescription](#P-Comdirect-Rest-Api-Comdirect-VisaCardImage-ImageDescription 'Comdirect.Rest.Api.Comdirect.VisaCardImage.ImageDescription')
  - [VisaCardImageId](#P-Comdirect-Rest-Api-Comdirect-VisaCardImage-VisaCardImageId 'Comdirect.Rest.Api.Comdirect.VisaCardImage.VisaCardImageId')

<a name='T-Comdirect-Rest-Api-Comdirect-Account'></a>
## Account `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Master data of an account

<a name='P-Comdirect-Rest-Api-Comdirect-Account-AccountDisplayId'></a>
### AccountDisplayId `property`

##### Summary

Account identfier

<a name='P-Comdirect-Rest-Api-Comdirect-Account-AccountId'></a>
### AccountId `property`

##### Summary

Account identifier (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Account-AccountType'></a>
### AccountType `property`

##### Summary

Account type. 'key' contains the product type, 'text' a description

<a name='P-Comdirect-Rest-Api-Comdirect-Account-ClientId'></a>
### ClientId `property`

##### Summary

Identification Code of the client (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Account-CreditLimit'></a>
### CreditLimit `property`

##### Summary

Credit limit, if available

<a name='P-Comdirect-Rest-Api-Comdirect-Account-Currency'></a>
### Currency `property`

##### Summary

Account currency

<a name='P-Comdirect-Rest-Api-Comdirect-Account-Iban'></a>
### Iban `property`

##### Summary

IBAN (International bank account number), if available

<a name='T-Comdirect-Rest-Api-Comdirect-AccountBalance'></a>
## AccountBalance `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Account information, including cash balance and buying power

<a name='P-Comdirect-Rest-Api-Comdirect-AccountBalance-Account'></a>
### Account `property`

##### Summary

The master data of this account (attribute can be suppressed by using the parameter 'without-attr=account')

<a name='P-Comdirect-Rest-Api-Comdirect-AccountBalance-AccountId'></a>
### AccountId `property`

##### Summary

Account identifier (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-AccountBalance-AvailableCashAmount'></a>
### AvailableCashAmount `property`

##### Summary

Sum of current account balance + credit limit - sum of funds, which are already planned but not yet booked. This is the maximum cash limit

<a name='P-Comdirect-Rest-Api-Comdirect-AccountBalance-AvailableCashAmountEUR'></a>
### AvailableCashAmountEUR `property`

##### Summary

As 'availableCashAmount', but in EUR

<a name='P-Comdirect-Rest-Api-Comdirect-AccountBalance-Balance'></a>
### Balance `property`

##### Summary

Current balance

<a name='P-Comdirect-Rest-Api-Comdirect-AccountBalance-BalanceEUR'></a>
### BalanceEUR `property`

##### Summary

Current balance in EUR

<a name='T-Comdirect-Rest-Api-Comdirect-AccountInformation'></a>
## AccountInformation `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for the information of an account (debtor/creditor).

<a name='P-Comdirect-Rest-Api-Comdirect-AccountInformation-Bic'></a>
### Bic `property`

##### Summary

The BIC (Bank Identifier Code) for the IBAN - if available

<a name='P-Comdirect-Rest-Api-Comdirect-AccountInformation-HolderName'></a>
### HolderName `property`

##### Summary

name of the account owner

<a name='P-Comdirect-Rest-Api-Comdirect-AccountInformation-Iban'></a>
### Iban `property`

##### Summary

The IBAN (International bank account number) for the account - if available

<a name='T-Comdirect-Rest-Api-Comdirect-AccountTransaction'></a>
## AccountTransaction `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for an account transaction.

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Amount'></a>
### Amount `property`

##### Summary

The amount

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-BookingDate'></a>
### BookingDate `property`

##### Summary

The booking date

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-BookingStatus'></a>
### BookingStatus `property`

##### Summary

Status of transaction

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Creditor'></a>
### Creditor `property`

##### Summary

includes the account information of the name, IBAN and BIC from the creditor

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Deptor'></a>
### Deptor `property`

##### Summary

Account information of name, IBAN and BIC of the debtor

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-DirectDebitCreditorId'></a>
### DirectDebitCreditorId `property`

##### Summary

Gives back the creditor identifier of an account transaction, if it is a direct debit.

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-DirectDebitMandateId'></a>
### DirectDebitMandateId `property`

##### Summary

Gives back the mandateId of an account transaction, if it is a direct debit.

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-EndToEndReference'></a>
### EndToEndReference `property`

##### Summary

Gives back the end-to-end-reference of an account transaction, if it is a direct debit.

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-NewTransaction'></a>
### NewTransaction `property`

##### Summary

Shows whether the client has seen the account transaction in web.

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Reference'></a>
### Reference `property`

##### Summary

unique reference code of the transaction

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-RemittanceInfo'></a>
### RemittanceInfo `property`

##### Summary

remittance information of the transaction. This can be more then one line with a length of 35 symbols. The lines will be numbered in case of an already booked transaction.

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-Remitter'></a>
### Remitter `property`

##### Summary

Account information of name, IBAN and BIC of the remitter.

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-TransactionType'></a>
### TransactionType `property`

##### Summary

Definition of account transaction type.

<a name='P-Comdirect-Rest-Api-Comdirect-AccountTransaction-ValutaDate'></a>
### ValutaDate `property`

##### Summary

Availability date (yyyy-mm-dd). Could be an invalid date e.g. 2019-12-32

<a name='T-Comdirect-Rest-Api-Comdirect-AmountValue'></a>
## AmountValue `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Represents the amount value with the currency.

<a name='P-Comdirect-Rest-Api-Comdirect-AmountValue-Unit'></a>
### Unit `property`

##### Summary

{XXX, XXC, XXM, XXP, XXU} or currencies according to ISO-4217 (EUR, USD, GBP,...)

<a name='P-Comdirect-Rest-Api-Comdirect-AmountValue-Value'></a>
### Value `property`

##### Summary

Nominal value in corresponding unit

<a name='T-Comdirect-Rest-Api-AuthClient'></a>
## AuthClient `type`

##### Namespace

Comdirect.Rest.Api

##### Summary

The auth client.

<a name='M-Comdirect-Rest-Api-AuthClient-#ctor-System-Net-Http-HttpClient,Comdirect-Auth-CSharp-ComdirectCredentials-'></a>
### #ctor(httpClient,comdirectCredentials) `constructor`

##### Summary

Initializes a new instance of the [AuthClient](#T-Comdirect-Rest-Api-AuthClient 'Comdirect.Rest.Api.AuthClient') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpClient | [System.Net.Http.HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient') | The HttpClient instance to be used for making HTTP requests. |
| comdirectCredentials | [Comdirect.Auth.CSharp.ComdirectCredentials](#T-Comdirect-Auth-CSharp-ComdirectCredentials 'Comdirect.Auth.CSharp.ComdirectCredentials') | The ComdirectCredentials object containing the client id, client secret, username, and pin. |

<a name='P-Comdirect-Rest-Api-AuthClient-RequestId'></a>
### RequestId `property`

##### Summary

Gets or sets the request id.

<a name='P-Comdirect-Rest-Api-AuthClient-SessionId'></a>
### SessionId `property`

##### Summary

Gets or sets the session id.

<a name='M-Comdirect-Rest-Api-AuthClient-ActivateSessionTanAsync-System-String,System-String,System-String-'></a>
### ActivateSessionTanAsync(accessToken,sessionUUID,challangeId) `method`

##### Summary

Activates the session tan async.

##### Returns

A Task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token. |
| sessionUUID | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The session u u i d. |
| challangeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The challange id. |

<a name='M-Comdirect-Rest-Api-AuthClient-GenerateDigits-System-Int32-'></a>
### GenerateDigits(length) `method`

##### Summary

Generates the digits.

##### Returns

A string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

<a name='M-Comdirect-Rest-Api-AuthClient-GetHttpRequestInfoValue'></a>
### GetHttpRequestInfoValue() `method`

##### Summary

Gets the HTTP request info value.
This method is used to create a JSON string that contains session and request IDs.
This string is then used as a header in HTTP requests to Comdirect API.

##### Returns

A string containing the serialized HTTP request info.

##### Parameters

This method has no parameters.

<a name='M-Comdirect-Rest-Api-AuthClient-GetSessionStatusAsync-System-String-'></a>
### GetSessionStatusAsync(accessToken,accessToken) `method`

##### Summary

Gets the session status async.

##### Returns

A Task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ApplicationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ApplicationException 'System.ApplicationException') | Thrown when the request to the Comdirect API fails. |

<a name='M-Comdirect-Rest-Api-AuthClient-GetTokenAndValidateSessionAsync'></a>
### GetTokenAndValidateSessionAsync() `method`

##### Summary

This method retrieves an access token and validates the user's session.

##### Returns

A Task that represents the asynchronous operation. The task result is the ValidateSessionAsync object.

##### Parameters

This method has no parameters.

<a name='M-Comdirect-Rest-Api-AuthClient-GetTokenAsync'></a>
### GetTokenAsync() `method`

##### Summary

Gets the token async.

##### Returns

A Task.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ApplicationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ApplicationException 'System.ApplicationException') | Thrown when the request to the Comdirect API fails or when the client id/secrets are not valid. |

<a name='M-Comdirect-Rest-Api-AuthClient-PostSecondaryFlowAsync-System-String-'></a>
### PostSecondaryFlowAsync(accessToken) `method`

##### Summary

Posts the secondary flow async.

##### Returns

A Task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token. |

<a name='M-Comdirect-Rest-Api-AuthClient-PostValidateSessionStatusAsync-System-String,System-String-'></a>
### PostValidateSessionStatusAsync(accessToken,sessionUUID) `method`

##### Summary

Posts the validate session status async.

##### Returns

A Task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token. |
| sessionUUID | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The session u u i d. |

<a name='M-Comdirect-Rest-Api-AuthClient-RevokeTokenAsync-System-String-'></a>
### RevokeTokenAsync(accessToken) `method`

##### Summary

Revokes the token async.

##### Returns

A Task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token. |

<a name='M-Comdirect-Rest-Api-AuthClient-SetBody-System-String,RestSharp-RestRequest-'></a>
### SetBody(sessionUUID,request) `method`

##### Summary

Sets the body.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sessionUUID | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The session u u i d. |
| request | [RestSharp.RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') | The request. |

<a name='M-Comdirect-Rest-Api-AuthClient-SetRequestSessionInfo-RestSharp-RestRequest-'></a>
### SetRequestSessionInfo(request) `method`

##### Summary

Sets the request session info.
This method is used to add a custom header to the RestRequest object.
The header contains session and request IDs in a serialized JSON format.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [RestSharp.RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') | The RestRequest object to which the header will be added. |

<a name='T-Comdirect-Rest-Api-Comdirect-Balance'></a>
## Balance `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

A balance object is equal to one of the types indicated by the attributes in this definition.

<a name='P-Comdirect-Rest-Api-Comdirect-Balance-AccountBalance'></a>
### AccountBalance `property`

##### Summary

Balance object for an account

<a name='P-Comdirect-Rest-Api-Comdirect-Balance-CardBalance'></a>
### CardBalance `property`

##### Summary

Balance object for a card

<a name='P-Comdirect-Rest-Api-Comdirect-Balance-DepotAggregation'></a>
### DepotAggregation `property`

##### Summary

Aggregation object for a depot

<a name='P-Comdirect-Rest-Api-Comdirect-Balance-FixedTermSavings'></a>
### FixedTermSavings `property`

##### Summary

Balance object for a fixed term saving

<a name='P-Comdirect-Rest-Api-Comdirect-Balance-InstallmentLoanBalance'></a>
### InstallmentLoanBalance `property`

##### Summary

Balance object for an installment loan

<a name='T-Comdirect-Rest-Api-Comdirect-BusinessMessage'></a>
## BusinessMessage `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for an error

<a name='P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Args'></a>
### Args `property`

##### Summary

Arguments for the error message

<a name='P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Key'></a>
### Key `property`

##### Summary

Identifier for the error

<a name='P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Message'></a>
### Message `property`

##### Summary

Default error message

<a name='P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Origin'></a>
### Origin `property`

##### Summary

List of properties causing validation errors

<a name='P-Comdirect-Rest-Api-Comdirect-BusinessMessage-Severity'></a>
### Severity `property`

##### Summary

Severity level of the error

<a name='T-Comdirect-Rest-Api-Comdirect-Card'></a>
## Card `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a card.

<a name='P-Comdirect-Rest-Api-Comdirect-Card-CardDisplayId'></a>
### CardDisplayId `property`

##### Summary

Partially masked credit card number.

<a name='P-Comdirect-Rest-Api-Comdirect-Card-CardId'></a>
### CardId `property`

##### Summary

Card identifier (UUID).

<a name='P-Comdirect-Rest-Api-Comdirect-Card-CardImage'></a>
### CardImage `property`

##### Summary

Image of the card.

<a name='P-Comdirect-Rest-Api-Comdirect-Card-CardLimit'></a>
### CardLimit `property`

##### Summary

Card limit if available. Will be 0.00 EUR if card has no limit.

<a name='P-Comdirect-Rest-Api-Comdirect-Card-CardType'></a>
### CardType `property`

##### Summary

Type of the card. 'key' contains the card type, 'text' a description

<a name='P-Comdirect-Rest-Api-Comdirect-Card-CardValidity'></a>
### CardValidity `property`

##### Summary

validity of the card. Format: MM/YY

<a name='P-Comdirect-Rest-Api-Comdirect-Card-ClientId'></a>
### ClientId `property`

##### Summary

Client connection uniquely assigned to the credit card account.

<a name='P-Comdirect-Rest-Api-Comdirect-Card-HolderName'></a>
### HolderName `property`

##### Summary

Name of the card holder

<a name='P-Comdirect-Rest-Api-Comdirect-Card-ParticipantId'></a>
### ParticipantId `property`

##### Summary

Contract code of the client uniquely assigned to the credit card account.

<a name='P-Comdirect-Rest-Api-Comdirect-Card-PrimaryAccountNumberSuffix'></a>
### PrimaryAccountNumberSuffix `property`

##### Summary

Last 4 digits of the credit card number

<a name='P-Comdirect-Rest-Api-Comdirect-Card-SettlementAccountId'></a>
### SettlementAccountId `property`

##### Summary

Default settlement account number uniquely assigned to the credit card account. In this case, it has to be the current account.

<a name='P-Comdirect-Rest-Api-Comdirect-Card-Status'></a>
### Status `property`

##### Summary

Status of the card.

<a name='T-Comdirect-Rest-Api-Comdirect-CardBalance'></a>
## CardBalance `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a card balance.

<a name='P-Comdirect-Rest-Api-Comdirect-CardBalance-AvailableCashAmount'></a>
### AvailableCashAmount `property`

##### Summary

Sum of current account balance + credit limit - sum of scheduled amounts which are not booked yet. This is the maximum cash limit.

<a name='P-Comdirect-Rest-Api-Comdirect-CardBalance-Balance'></a>
### Balance `property`

##### Summary

Current balance.

<a name='P-Comdirect-Rest-Api-Comdirect-CardBalance-Card'></a>
### Card `property`

##### Summary

Master data of the card.

<a name='P-Comdirect-Rest-Api-Comdirect-CardBalance-CardId'></a>
### CardId `property`

##### Summary

Card identifier (UUID).

<a name='T-Comdirect-Rest-Api-Comdirect-ComdirectClient'></a>
## ComdirectClient `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingClientsV2AccountsBalancesAsync-System-String,System-String-'></a>
### BankingClientsV2AccountsBalancesAsync(user,without_attr) `method`

##### Summary

Request for account information, including cash balance and buying power, for all accounts

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Can be either the customer identification number (UUID) or 'user' |
| without_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Suppresses the master data of the accounts |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingClientsV2AccountsBalancesAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### BankingClientsV2AccountsBalancesAsync(cancellationToken,user,without_attr) `method`

##### Summary

Request for account information, including cash balance and buying power, for all accounts

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| user | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Can be either the customer identification number (UUID) or 'user' |
| without_attr | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Suppresses the master data of the accounts |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingV1AccountsTransactionsAsync-System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-TransactionState},System-Nullable{Comdirect-Rest-Api-Comdirect-TransactionDirection},System-Nullable{System-Int32},System-String-'></a>
### BankingV1AccountsTransactionsAsync(accountId,transactionState,transactionDirection,paging_first,with_attr) `method`

##### Summary

Requests and returns a list of transactions for the given account

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accountId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Account identifier (UUID) |
| transactionState | [System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionState}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionState}') | Filters for AccountTransactions. Will return all AccountTransactions (BOTH), or return all booked AccountTransactions (BOOKED), or all not booked AccountTransactions (NOTBOOKED). |
| transactionDirection | [System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionDirection}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionDirection}') | Filters for CREDIT, DEBIT or CREDIT_AND_DEBIT |
| paging_first | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Index of the first transaction. |
| with_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Enforce to load the master data of an attribute. Currently supported attributes: account |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingV1AccountsTransactionsAsync-System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-TransactionState},System-Nullable{Comdirect-Rest-Api-Comdirect-TransactionDirection},System-Nullable{System-Int32},System-String,System-Threading-CancellationToken-'></a>
### BankingV1AccountsTransactionsAsync(cancellationToken,accountId,transactionState,transactionDirection,paging_first,with_attr) `method`

##### Summary

Requests and returns a list of transactions for the given account

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| accountId | [System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionState}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionState}') | Account identifier (UUID) |
| transactionState | [System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionDirection}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.TransactionDirection}') | Filters for AccountTransactions. Will return all AccountTransactions (BOTH), or return all booked AccountTransactions (BOOKED), or all not booked AccountTransactions (NOTBOOKED). |
| transactionDirection | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Filters for CREDIT, DEBIT or CREDIT_AND_DEBIT |
| paging_first | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Index of the first transaction. |
| with_attr | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Enforce to load the master data of an attribute. Currently supported attributes: account |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingV2AccountsBalancesAsync-System-String,System-String-'></a>
### BankingV2AccountsBalancesAsync(accountId,without_attr) `method`

##### Summary

Request for account information, including cash balance and buying power

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accountId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Account identifier (UUID) |
| without_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Suppresses the master data of the account |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BankingV2AccountsBalancesAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### BankingV2AccountsBalancesAsync(cancellationToken,accountId,without_attr) `method`

##### Summary

Request for account information, including cash balance and buying power

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| accountId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Account identifier (UUID) |
| without_attr | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Suppresses the master data of the account |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageClientsV3DepotsAsync-System-String-'></a>
### BrokerageClientsV3DepotsAsync(userId) `method`

##### Summary

Request for a list of the master data for the securities accounts of the registered user

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | UUID of the user to search depots for, or the string 'user' to use the logged in user |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageClientsV3DepotsAsync-System-String,System-Threading-CancellationToken-'></a>
### BrokerageClientsV3DepotsAsync(cancellationToken,userId) `method`

##### Summary

Request for a list of the master data for the securities accounts of the registered user

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| userId | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | UUID of the user to search depots for, or the string 'user' to use the logged in user |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageDepotsV3OrdersAsync-System-String,System-String,System-String,System-String,System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderStatus},System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderType2},System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-Side}-'></a>
### BrokerageDepotsV3OrdersAsync(depotId,with_attr,without_attr,instrumentId,isin,wkn,orderStatus,venueId,orderType,min_creationTimeStamp,max_creationTimeStamp,side) `method`

##### Summary

Delivers a list of all orders for the given depotId.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| depotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to securities account number (as UUID). |
| with_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | enables attribute: instrument. |
| without_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Disables attribute: executions. |
| instrumentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instrument id (UUID), unique identification of an instrument (security, derivative, etc.). |
| isin | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ISIN |
| wkn | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | WKN |
| orderStatus | [System.Nullable{Comdirect.Rest.Api.Comdirect.OrderStatus}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.OrderStatus}') | Status of the order. |
| venueId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Venue id (UUID), unique identification of a venue. |
| orderType | [System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType2}') | The order type. |
| min_creationTimeStamp | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Minimum value of order's creation timestamp in UTC with the following format: YYYY-MM-DDThh:mm:ss,ffffff+zz. |
| max_creationTimeStamp | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Maximum value of order's creation timestamp in UTC with the following format: YYYY-MM-DDThh:mm:ss,ffffff+zz. |
| side | [System.Nullable{Comdirect.Rest.Api.Comdirect.Side}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.Side}') | Possible transaction types |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageDepotsV3OrdersAsync-System-String,System-String,System-String,System-String,System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderStatus},System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderType2},System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-Side},System-Threading-CancellationToken-'></a>
### BrokerageDepotsV3OrdersAsync(cancellationToken,depotId,with_attr,without_attr,instrumentId,isin,wkn,orderStatus,venueId,orderType,min_creationTimeStamp,max_creationTimeStamp,side) `method`

##### Summary

Delivers a list of all orders for the given depotId.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| depotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to securities account number (as UUID). |
| with_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | enables attribute: instrument. |
| without_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Disables attribute: executions. |
| instrumentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instrument id (UUID), unique identification of an instrument (security, derivative, etc.). |
| isin | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ISIN |
| wkn | [System.Nullable{Comdirect.Rest.Api.Comdirect.OrderStatus}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.OrderStatus}') | WKN |
| orderStatus | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Status of the order. |
| venueId | [System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType2}') | Venue id (UUID), unique identification of a venue. |
| orderType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The order type. |
| min_creationTimeStamp | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Minimum value of order's creation timestamp in UTC with the following format: YYYY-MM-DDThh:mm:ss,ffffff+zz. |
| max_creationTimeStamp | [System.Nullable{Comdirect.Rest.Api.Comdirect.Side}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.Side}') | Maximum value of order's creation timestamp in UTC with the following format: YYYY-MM-DDThh:mm:ss,ffffff+zz. |
| side | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Possible transaction types |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV1InstrumentsAsync-System-String,System-Collections-Generic-IEnumerable{Comdirect-Rest-Api-Comdirect-Anonymous},System-Collections-Generic-IEnumerable{System-String}-'></a>
### BrokerageV1InstrumentsAsync(instrumentId,with_attr,without_attr) `method`

##### Summary

Request for an instrument's information

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instrumentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instrument identification - can be either the WKN, the ISIN or the symbol of the instrument |
| with_attr | [System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous}') | Enables attribute: orderDimensions |
| without_attr | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Disables attribute: staticData |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV1InstrumentsAsync-System-String,System-Collections-Generic-IEnumerable{Comdirect-Rest-Api-Comdirect-Anonymous},System-Collections-Generic-IEnumerable{System-String},System-Threading-CancellationToken-'></a>
### BrokerageV1InstrumentsAsync(cancellationToken,instrumentId,with_attr,without_attr) `method`

##### Summary

Request for an instrument's information

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| instrumentId | [System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous}') | Instrument identification - can be either the WKN, the ISIN or the symbol of the instrument |
| with_attr | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Enables attribute: orderDimensions |
| without_attr | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Disables attribute: staticData |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsPositionsGetAsync-System-String,System-String,System-Collections-Generic-IEnumerable{System-String},System-String-'></a>
### BrokerageV3DepotsPositionsGetAsync(depotId,instrumentId,without_attr,with_attr) `method`

##### Summary

Request for securities positions, optionally including only the total balance with securities account information

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| depotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to securities account number (as UUID). |
| instrumentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instrument identification - can either be the WKN, the ISIN or the UUID of the instrument. |
| without_attr | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Disables attributes for this request. Allowed attributes: depot, positions |
| with_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Enables additional attributes for this request. Allowed attributes: instrument |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsPositionsGetAsync-System-String,System-String,System-Collections-Generic-IEnumerable{System-String},System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3DepotsPositionsGetAsync(cancellationToken,depotId,instrumentId,without_attr,with_attr) `method`

##### Summary

Request for securities positions, optionally including only the total balance with securities account information

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| depotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to securities account number (as UUID). |
| instrumentId | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Instrument identification - can either be the WKN, the ISIN or the UUID of the instrument. |
| without_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Disables attributes for this request. Allowed attributes: depot, positions |
| with_attr | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Enables additional attributes for this request. Allowed attributes: instrument |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsPositionsGetAsync-System-String,System-String,System-String-'></a>
### BrokerageV3DepotsPositionsGetAsync(depotId,positionId,with_attr) `method`

##### Summary

Request for retrieving a single position of specific depot.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| depotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to securities account number (as UUID). |
| positionId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Position identification number in securities account (as UUID) |
| with_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Enables additional attributes for this request. Allowed attributes: instrument |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsPositionsGetAsync-System-String,System-String,System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3DepotsPositionsGetAsync(cancellationToken,depotId,positionId,with_attr) `method`

##### Summary

Request for retrieving a single position of specific depot.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| depotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to securities account number (as UUID). |
| positionId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Position identification number in securities account (as UUID) |
| with_attr | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Enables additional attributes for this request. Allowed attributes: instrument |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsTransactionsAsync-System-String,System-String,System-String,System-String,System-String-'></a>
### BrokerageV3DepotsTransactionsAsync(depotId,isin,wkn,instrumentId,min_bookingDate) `method`

##### Summary

Depot transactions.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| depotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to securities account number (as UUID). |
| isin | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ISIN |
| wkn | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | WKN |
| instrumentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instrument id (UUID), unique identification of an instrument. |
| min_bookingDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Earliest booking date of the transaction. Format: YYYY-MM-DD or as negative offset from the current date e.g. -10d |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3DepotsTransactionsAsync-System-String,System-String,System-String,System-String,System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3DepotsTransactionsAsync(cancellationToken,depotId,isin,wkn,instrumentId,min_bookingDate) `method`

##### Summary

Depot transactions.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| depotId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to securities account number (as UUID). |
| isin | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ISIN |
| wkn | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | WKN |
| instrumentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instrument id (UUID), unique identification of an instrument. |
| min_bookingDate | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Earliest booking date of the transaction. Format: YYYY-MM-DD or as negative offset from the current date e.g. -10d |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersCostindicationexantePostAsync-Comdirect-Rest-Api-Comdirect-Order-'></a>
### BrokerageV3OrdersCostindicationexantePostAsync(order) `method`

##### Summary

Generation of the ex-ante cost indication on the basis of the order data.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | The Order for which the cost indication is to be calculated |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersCostindicationexantePostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersCostindicationexantePostAsync(cancellationToken,order) `method`

##### Summary

Generation of the ex-ante cost indication on the basis of the order data.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| order | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The Order for which the cost indication is to be calculated |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersCostindicationexantePostAsync-System-String,Comdirect-Rest-Api-Comdirect-Order-'></a>
### BrokerageV3OrdersCostindicationexantePostAsync(orderId,order) `method`

##### Summary

Generation of the ex-ante cost indication on the basis of the order data.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to order identifier (as UUID). |
| order | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | The Order for which the cost indication is to be calculated |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersCostindicationexantePostAsync-System-String,Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersCostindicationexantePostAsync(cancellationToken,orderId,order) `method`

##### Summary

Generation of the ex-ante cost indication on the basis of the order data.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| orderId | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | Reference to order identifier (as UUID). |
| order | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The Order for which the cost indication is to be calculated |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersDeleteAsync-System-String-'></a>
### BrokerageV3OrdersDeleteAsync(orderId) `method`

##### Summary

Order cancellation.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to order identifier (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersDeleteAsync-System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersDeleteAsync(cancellationToken,orderId) `method`

##### Summary

Order cancellation.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| orderId | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Reference to order identifier (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersDimensionsAsync-System-String,System-String,System-String,System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderType3},System-Nullable{Comdirect-Rest-Api-Comdirect-Side2},System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-Type}-'></a>
### BrokerageV3OrdersDimensionsAsync(instrumentId,isin,wkn,custodyType,venueId,orderType,side,country,type) `method`

##### Summary

Request for the trading venue and order options for a particular instrument

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instrumentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instrument id (UUID), unique identification of an instrument (security, derivative, etc.). |
| isin | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ISIN |
| wkn | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | WKN |
| custodyType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The custody type. |
| venueId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Venue id (UUID), unique identification of a venue. |
| orderType | [System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType3}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType3}') | The order type. |
| side | [System.Nullable{Comdirect.Rest.Api.Comdirect.Side2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.Side2}') | Possible transaction types. |
| country | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Country of venue in ISO 3166-2. |
| type | [System.Nullable{Comdirect.Rest.Api.Comdirect.Type}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.Type}') | Type of venue. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersDimensionsAsync-System-String,System-String,System-String,System-String,System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-OrderType3},System-Nullable{Comdirect-Rest-Api-Comdirect-Side2},System-String,System-Nullable{Comdirect-Rest-Api-Comdirect-Type},System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersDimensionsAsync(cancellationToken,instrumentId,isin,wkn,custodyType,venueId,orderType,side,country,type) `method`

##### Summary

Request for the trading venue and order options for a particular instrument

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| instrumentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Instrument id (UUID), unique identification of an instrument (security, derivative, etc.). |
| isin | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ISIN |
| wkn | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | WKN |
| custodyType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The custody type. |
| venueId | [System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType3}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.OrderType3}') | Venue id (UUID), unique identification of a venue. |
| orderType | [System.Nullable{Comdirect.Rest.Api.Comdirect.Side2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.Side2}') | The order type. |
| side | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Possible transaction types. |
| country | [System.Nullable{Comdirect.Rest.Api.Comdirect.Type}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Comdirect.Rest.Api.Comdirect.Type}') | Country of venue in ISO 3166-2. |
| type | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Type of venue. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersGetAsync-System-String,System-String-'></a>
### BrokerageV3OrdersGetAsync(orderId,without_attr) `method`

##### Summary

Delivers an order for the given orderId.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique orderId (UUID). |
| without_attr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Disables attribute: executions. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersGetAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersGetAsync(cancellationToken,orderId,without_attr) `method`

##### Summary

Delivers an order for the given orderId.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unique orderId (UUID). |
| without_attr | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Disables attribute: executions. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPatchAsync-Comdirect-Rest-Api-Comdirect-Order,System-String-'></a>
### BrokerageV3OrdersPatchAsync(orderId) `method`

##### Summary

Order modification.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orderId | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | Reference to order identifier (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPatchAsync-Comdirect-Rest-Api-Comdirect-Order,System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersPatchAsync(cancellationToken,orderId) `method`

##### Summary

Order modification.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to order identifier (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPostAsync-Comdirect-Rest-Api-Comdirect-Order-'></a>
### BrokerageV3OrdersPostAsync() `method`

##### Summary

Order entry.

##### Returns

successful operation

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersPostAsync(cancellationToken) `method`

##### Summary

Order entry.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPrevalidationPostAsync-Comdirect-Rest-Api-Comdirect-Order-'></a>
### BrokerageV3OrdersPrevalidationPostAsync() `method`

##### Summary

Prevalidation of the order

##### Returns

successful operation

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPrevalidationPostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersPrevalidationPostAsync(cancellationToken) `method`

##### Summary

Prevalidation of the order

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPrevalidationPostAsync-System-String,System-String-'></a>
### BrokerageV3OrdersPrevalidationPostAsync(orderId) `method`

##### Summary

Prevalidation of an order modfication

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to order identifier (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersPrevalidationPostAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersPrevalidationPostAsync(cancellationToken,orderId) `method`

##### Summary

Prevalidation of an order modfication

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to order identifier (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersValidationPostAsync-Comdirect-Rest-Api-Comdirect-Order-'></a>
### BrokerageV3OrdersValidationPostAsync() `method`

##### Summary

Validation of an order entry and triggering of a TAN-Challenge in a non-usage case of a Session-TAN.

##### Returns

successful operation

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersValidationPostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersValidationPostAsync(cancellationToken) `method`

##### Summary

Validation of an order entry and triggering of a TAN-Challenge in a non-usage case of a Session-TAN.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersValidationPostAsync-System-String,System-String-'></a>
### BrokerageV3OrdersValidationPostAsync(orderId) `method`

##### Summary

Validation of an order modification or order cancellation and triggering of a TAN Challenge in a non-usage case of a Session-TAN.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to order identifier (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3OrdersValidationPostAsync-System-String,System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3OrdersValidationPostAsync(cancellationToken,orderId) `method`

##### Summary

Validation of an order modification or order cancellation and triggering of a TAN Challenge in a non-usage case of a Session-TAN.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| orderId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to order identifier (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuotesAsync-Comdirect-Rest-Api-Comdirect-Quote-'></a>
### BrokerageV3QuotesAsync() `method`

##### Summary

Sends a quote request to a venue

##### Returns

successful operation

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuotesAsync-Comdirect-Rest-Api-Comdirect-Quote,System-Threading-CancellationToken-'></a>
### BrokerageV3QuotesAsync(cancellationToken) `method`

##### Summary

Sends a quote request to a venue

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Quote](#T-Comdirect-Rest-Api-Comdirect-Quote 'Comdirect.Rest.Api.Comdirect.Quote') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuoteticketPatchAsync-System-String-'></a>
### BrokerageV3QuoteticketPatchAsync(ticketId) `method`

##### Summary

Initiate a TAN-Challange

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticketId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to the quote ticket (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuoteticketPatchAsync-System-String,System-Threading-CancellationToken-'></a>
### BrokerageV3QuoteticketPatchAsync(cancellationToken,ticketId) `method`

##### Summary

Initiate a TAN-Challange

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| ticketId | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Reference to the quote ticket (as UUID). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuoteticketPostAsync-Comdirect-Rest-Api-Comdirect-Order-'></a>
### BrokerageV3QuoteticketPostAsync(order) `method`

##### Summary

Initiates a TAN-Challenge

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | The order for which a ticket will be acquired |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-BrokerageV3QuoteticketPostAsync-Comdirect-Rest-Api-Comdirect-Order,System-Threading-CancellationToken-'></a>
### BrokerageV3QuoteticketPostAsync(cancellationToken,order) `method`

##### Summary

Initiates a TAN-Challenge

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Order](#T-Comdirect-Rest-Api-Comdirect-Order 'Comdirect.Rest.Api.Comdirect.Order') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| order | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The order for which a ticket will be acquired |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesClientsV2DocumentsAsync-System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}-'></a>
### MessagesClientsV2DocumentsAsync(user,paging_first,paging_count) `method`

##### Summary

Delivers a list of documents for the customer.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The literal "user" or the unique ID of the client. |
| paging_first | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Index of the returning results. |
| paging_count | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum number of results that will be returned. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesClientsV2DocumentsAsync-System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Threading-CancellationToken-'></a>
### MessagesClientsV2DocumentsAsync(cancellationToken,user,paging_first,paging_count) `method`

##### Summary

Delivers a list of documents for the customer.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| user | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The literal "user" or the unique ID of the client. |
| paging_first | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Index of the returning results. |
| paging_count | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The maximum number of results that will be returned. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesV2DocumentsAsync-System-String-'></a>
### MessagesV2DocumentsAsync(documentId) `method`

##### Summary

Delivers a document for the given UUID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The unique ID of the document. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesV2DocumentsAsync-System-String,System-Threading-CancellationToken-'></a>
### MessagesV2DocumentsAsync(cancellationToken,documentId) `method`

##### Summary

Delivers a document for the given UUID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| documentId | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The unique ID of the document. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesV2DocumentsPredocumentAsync-System-String-'></a>
### MessagesV2DocumentsPredocumentAsync(documentId) `method`

##### Summary

Delivers a predocument for the given UUID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The unique ID of the document. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-MessagesV2DocumentsPredocumentAsync-System-String,System-Threading-CancellationToken-'></a>
### MessagesV2DocumentsPredocumentAsync(cancellationToken,documentId) `method`

##### Summary

Delivers a predocument for the given UUID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| documentId | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The unique ID of the document. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-ReportsParticipantsV1AllbalancesAsync-System-String,System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{Comdirect-Rest-Api-Comdirect-Anonymous2},System-Collections-Generic-IEnumerable{System-String}-'></a>
### ReportsParticipantsV1AllbalancesAsync(user,clientConnectionType,targetClientId,without_attr,productType) `method`

##### Summary

List of all balances for a client's own and connected products.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The literal "user" or the UUID of the participant. |
| clientConnectionType | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | A single ConnectionType of a client connection or a list of ConnectionTypes. |
| targetClientId | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | A single UUID of a target client or a list of UUIDs. |
| without_attr | [System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous2}') | Prevents setting the static data in the balance objects. |
| productType | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Filter for a single or list of product types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-ReportsParticipantsV1AllbalancesAsync-System-String,System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{Comdirect-Rest-Api-Comdirect-Anonymous2},System-Collections-Generic-IEnumerable{System-String},System-Threading-CancellationToken-'></a>
### ReportsParticipantsV1AllbalancesAsync(cancellationToken,user,clientConnectionType,targetClientId,without_attr,productType) `method`

##### Summary

List of all balances for a client's own and connected products.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| user | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The literal "user" or the UUID of the participant. |
| clientConnectionType | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | A single ConnectionType of a client connection or a list of ConnectionTypes. |
| targetClientId | [System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Comdirect.Rest.Api.Comdirect.Anonymous2}') | A single UUID of a target client or a list of UUIDs. |
| without_attr | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Prevents setting the static data in the balance objects. |
| productType | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Filter for a single or list of product types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsGetAsync-System-String-'></a>
### SessionClientsV1SessionsGetAsync(user) `method`

##### Summary

Returns the current Session-Objects for the specified client, can handle the literal "user" for the currently logged in client.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The literal "user" or the UUID of the client. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsGetAsync-System-String,System-Threading-CancellationToken-'></a>
### SessionClientsV1SessionsGetAsync(cancellationToken,user) `method`

##### Summary

Returns the current Session-Objects for the specified client, can handle the literal "user" for the currently logged in client.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| user | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The literal "user" or the UUID of the client. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsPatchAsync-Comdirect-Rest-Api-Comdirect-Session,System-String,System-String-'></a>
### SessionClientsV1SessionsPatchAsync(user,session) `method`

##### Summary

Writes updates to a session

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Comdirect.Rest.Api.Comdirect.Session](#T-Comdirect-Rest-Api-Comdirect-Session 'Comdirect.Rest.Api.Comdirect.Session') | The literal "user" or the UUID of the client. |
| session | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to the session (UUID) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsPatchAsync-Comdirect-Rest-Api-Comdirect-Session,System-String,System-String,System-Threading-CancellationToken-'></a>
### SessionClientsV1SessionsPatchAsync(cancellationToken,user,session) `method`

##### Summary

Writes updates to a session

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Session](#T-Comdirect-Rest-Api-Comdirect-Session 'Comdirect.Rest.Api.Comdirect.Session') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| user | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The literal "user" or the UUID of the client. |
| session | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to the session (UUID) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsValidateAsync-Comdirect-Rest-Api-Comdirect-Session,System-String,System-String-'></a>
### SessionClientsV1SessionsValidateAsync(user,session) `method`

##### Summary

Validates the input and checks if the client is able to update the current session. An activated session TAN cannot be deactivated in the current session. It is necessary to provide a TAN when patching the activation of the session TAN.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Comdirect.Rest.Api.Comdirect.Session](#T-Comdirect-Rest-Api-Comdirect-Session 'Comdirect.Rest.Api.Comdirect.Session') | The literal "user" or the UUID of the client. |
| session | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to the session (UUID) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='M-Comdirect-Rest-Api-Comdirect-ComdirectClient-SessionClientsV1SessionsValidateAsync-Comdirect-Rest-Api-Comdirect-Session,System-String,System-String,System-Threading-CancellationToken-'></a>
### SessionClientsV1SessionsValidateAsync(cancellationToken,user,session) `method`

##### Summary

Validates the input and checks if the client is able to update the current session. An activated session TAN cannot be deactivated in the current session. It is necessary to provide a TAN when patching the activation of the session TAN.

##### Returns

successful operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [Comdirect.Rest.Api.Comdirect.Session](#T-Comdirect-Rest-Api-Comdirect-Session 'Comdirect.Rest.Api.Comdirect.Session') | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |
| user | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The literal "user" or the UUID of the client. |
| session | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reference to the session (UUID) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Comdirect.Rest.Api.Comdirect.ApiException](#T-Comdirect-Rest-Api-Comdirect-ApiException 'Comdirect.Rest.Api.Comdirect.ApiException') | A server side error occurred. |

<a name='T-Comdirect-Rest-Api-Comdirect-CostEntry'></a>
## CostEntry `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Cost entry of a cost group.

<a name='P-Comdirect-Rest-Api-Comdirect-CostEntry-Amount'></a>
### Amount `property`

##### Summary

Cost in trading currency

<a name='P-Comdirect-Rest-Api-Comdirect-CostEntry-AmountReportingCurrency'></a>
### AmountReportingCurrency `property`

##### Summary

Cost in reporting currency

<a name='P-Comdirect-Rest-Api-Comdirect-CostEntry-Inducement'></a>
### Inducement `property`

##### Summary

Inducement of the cost entry

<a name='P-Comdirect-Rest-Api-Comdirect-CostEntry-Label'></a>
### Label `property`

##### Summary

Label of the cost entry

<a name='P-Comdirect-Rest-Api-Comdirect-CostEntry-Type'></a>
### Type `property`

##### Summary

Type of the cost entry

<a name='T-Comdirect-Rest-Api-Comdirect-CostGroup'></a>
## CostGroup `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a cost group including a list of cost entries for this cost group.

<a name='P-Comdirect-Rest-Api-Comdirect-CostGroup-Costs'></a>
### Costs `property`

##### Summary

List of costs per cost group

<a name='P-Comdirect-Rest-Api-Comdirect-CostGroup-Label'></a>
### Label `property`

##### Summary

Name of cost group for showing in the cost-note

<a name='P-Comdirect-Rest-Api-Comdirect-CostGroup-Sum'></a>
### Sum `property`

##### Summary

Sum of the cost group in trading currency (quantity.amount.unit)

<a name='P-Comdirect-Rest-Api-Comdirect-CostGroup-SumReportingCurrency'></a>
### SumReportingCurrency `property`

##### Summary

Sum of the cost group in reporting currency

<a name='P-Comdirect-Rest-Api-Comdirect-CostGroup-Type'></a>
### Type `property`

##### Summary

Type of cost group. K: Costs of securities purchase, H: Costs of the holding period (per year), V: Costs of the sale of securities

<a name='T-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte'></a>
## CostIndicationExAnte `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Ex-ante cost indication on the basis of the order data.

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-CalculationSuccessful'></a>
### CalculationSuccessful `property`

##### Summary

Result of calculation of cost indication; if false, linkCosts will link to a generic cost indication

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-DepotId'></a>
### DepotId `property`

##### Summary

Securities account number (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-ExpectedSettlementCosts'></a>
### ExpectedSettlementCosts `property`

##### Summary

Expected costs for order analogue (real) settlement costs

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-ExpectedValue'></a>
### ExpectedValue `property`

##### Summary

Expected value (net costs) of the order: in trading currency

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-FxRate'></a>
### FxRate `property`

##### Summary

Exchange rate for settlement currency to FX, for buy and sell (both sides for conversion depending on BUY/SELL)

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-HoldingCosts'></a>
### HoldingCosts `property`

##### Summary

CostGroup type H

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-HoldingPeriod'></a>
### HoldingPeriod `property`

##### Summary

Holding period in years, displayed on purchase

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Limit'></a>
### Limit `property`

##### Summary

Limit analogous to Order.limit with trading currency

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-LinkCosts'></a>
### LinkCosts `property`

##### Summary

HTTP link to further cost information

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-LinkKid'></a>
### LinkKid `property`

##### Summary

HTTP link to key information document

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Name'></a>
### Name `property`

##### Summary

Instrument name analogous to Instrument.name

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-PurchaseCosts'></a>
### PurchaseCosts `property`

##### Summary

CostGroup type K

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Quantity'></a>
### Quantity `property`

##### Summary

Quantity analogous to Order.quantity

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-ReportingCurrency'></a>
### ReportingCurrency `property`

##### Summary

Reporting currency

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-SalesCosts'></a>
### SalesCosts `property`

##### Summary

CostGroup type V

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-SettlementCurrency'></a>
### SettlementCurrency `property`

##### Summary

Settlement currency analogous to Account.currency

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Side'></a>
### Side `property`

##### Summary

Type of transaction analogous to Order.side

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TotalCostsAbs'></a>
### TotalCostsAbs `property`

##### Summary

Absolute amount of the total costs

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TotalCostsDetail'></a>
### TotalCostsDetail `property`

##### Summary

Total cost block including total cost entries segregated as: E (own service costs of bank), F (external service costs), and P (product costs)

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TotalCostsRel'></a>
### TotalCostsRel `property`

##### Summary

Amount of total costs relative to the investment

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TotalHoldingCosts'></a>
### TotalHoldingCosts `property`

##### Summary

List of cost blocks over time

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-TradingCurrency'></a>
### TradingCurrency `property`

##### Summary

Trading currency

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-VenueName'></a>
### VenueName `property`

##### Summary

Execution venue as name for the display

<a name='P-Comdirect-Rest-Api-Comdirect-CostIndicationExAnte-Wkn'></a>
### Wkn `property`

##### Summary

WKN analogous to Instrument.wkn

<a name='T-Comdirect-Rest-Api-Comdirect-Depot'></a>
## Depot `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

<a name='P-Comdirect-Rest-Api-Comdirect-Depot-ClientId'></a>
### ClientId `property`

##### Summary

Identification code of the client uniquely assigned to the securities account

<a name='P-Comdirect-Rest-Api-Comdirect-Depot-DefaultSettlementAccountId'></a>
### DefaultSettlementAccountId `property`

##### Summary

Default settlement account number uniquely assigned to the securities account

<a name='P-Comdirect-Rest-Api-Comdirect-Depot-DepotDisplayId'></a>
### DepotDisplayId `property`

##### Summary

Securities account Number

<a name='P-Comdirect-Rest-Api-Comdirect-Depot-DepotId'></a>
### DepotId `property`

##### Summary

Securities account Identifier (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Depot-SettlementAccountIds'></a>
### SettlementAccountIds `property`

##### Summary

List of other settlement account identification numbers assigned to the securities account

<a name='T-Comdirect-Rest-Api-Comdirect-DepotAggregation'></a>
## DepotAggregation `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-CurrentValue'></a>
### CurrentValue `property`

##### Summary

Current value of the securities account (the sum of all the securities holdings at their current prices)

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-DateLastUpdate'></a>
### DateLastUpdate `property`

##### Summary

Date of the last update of securities holdings & master data. YYYY-MM-DD

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-Depot'></a>
### Depot `property`

##### Summary

The master data of this securities account (this attribute can be suppressed by using the parameter 'without-attr=depot')

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-DepotId'></a>
### DepotId `property`

##### Summary

Securities account Identifier (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-LendingValue'></a>
### LendingValue `property`

##### Summary

Sum of the lending values of all of the securities holdings

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-PrevDayValue'></a>
### PrevDayValue `property`

##### Summary

Value of the securities account (the sum of all the securities holdings at the closing prices of the previous day)

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-ProfitLossPrevDayAbs'></a>
### ProfitLossPrevDayAbs `property`

##### Summary

Absolute profit/loss compared to the previous day

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-ProfitLossPrevDayRel'></a>
### ProfitLossPrevDayRel `property`

##### Summary

Profit/Loss compared to the previous day in percentage

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-ProfitLossPurchaseAbs'></a>
### ProfitLossPurchaseAbs `property`

##### Summary

Profit/loss at the absolute purchase value

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-ProfitLossPurchaseRel'></a>
### ProfitLossPurchaseRel `property`

##### Summary

Profit/loss relative to purchase value in percentage

<a name='P-Comdirect-Rest-Api-Comdirect-DepotAggregation-PurchaseValue'></a>
### PurchaseValue `property`

##### Summary

Sum of the purchase values of all the securities holdings

<a name='T-Comdirect-Rest-Api-Comdirect-DepotPosition'></a>
## DepotPosition `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-AvailableQuantity'></a>
### AvailableQuantity `property`

##### Summary

Available quantity or nominal amount in case of a percentage quotation

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-CurrentPrice'></a>
### CurrentPrice `property`

##### Summary

Current price, if available

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-CurrentValue'></a>
### CurrentValue `property`

##### Summary

Current value of the position

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-CustodyType'></a>
### CustodyType `property`

##### Summary

Custody type

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-DepotId'></a>
### DepotId `property`

##### Summary

Securities account Identifier (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-Instrument'></a>
### Instrument `property`

##### Summary

Information about the instrument of the securities position

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-PositionId'></a>
### PositionId `property`

##### Summary

Position identification number in securities account

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-PrevDayPrice'></a>
### PrevDayPrice `property`

##### Summary

Price of the previous day, if available

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-PrevDayValue'></a>
### PrevDayValue `property`

##### Summary

Position value at previous day's closing price

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-ProfitLossPrevDayAbs'></a>
### ProfitLossPrevDayAbs `property`

##### Summary

Absolute profit/loss compared to previous day, if available

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-ProfitLossPrevDayRel'></a>
### ProfitLossPrevDayRel `property`

##### Summary

Profit/Loss compared to previous day in percentage, if available

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-ProfitLossPurchaseAbs'></a>
### ProfitLossPurchaseAbs `property`

##### Summary

Absolute profit/loss at purchase price, if available

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-ProfitLossPurchaseRel'></a>
### ProfitLossPurchaseRel `property`

##### Summary

Profit/loss relative to purchase value in percentage, if available

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-PurchasePrice'></a>
### PurchasePrice `property`

##### Summary

Purchase price, if available

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-PurchaseValue'></a>
### PurchaseValue `property`

##### Summary

Average purchase value of the position

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-Quantity'></a>
### Quantity `property`

##### Summary

Quantity or nominal amount in case of a percentage quotation

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-Version'></a>
### Version `property`

##### Summary

Position version, if available

<a name='P-Comdirect-Rest-Api-Comdirect-DepotPosition-Wkn'></a>
### Wkn `property`

##### Summary

Identification number of the instrument

<a name='T-Comdirect-Rest-Api-Comdirect-DepotTransaction'></a>
## DepotTransaction `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a depot transaction.

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-BookingDate'></a>
### BookingDate `property`

##### Summary

The booking date

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-BookingStatus'></a>
### BookingStatus `property`

##### Summary

Status of transaction

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-BusinessDate'></a>
### BusinessDate `property`

##### Summary

The business date

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-ExecutionPrice'></a>
### ExecutionPrice `property`

##### Summary

Price of the execution

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-FxRate'></a>
### FxRate `property`

##### Summary

Exchange rate settlement currency EUR to FX if exectionPrice amount is not notated in EUR

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-Instrument'></a>
### Instrument `property`

##### Summary

Information about the instrument of the securities position

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-InstrumentId'></a>
### InstrumentId `property`

##### Summary

InstrumentId as UUID

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-Quantity'></a>
### Quantity `property`

##### Summary

The quantity

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-SettlementDate'></a>
### SettlementDate `property`

##### Summary

Date and time of settlement

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-TransactionDirection'></a>
### TransactionDirection `property`

##### Summary

Transaction direction

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-TransactionId'></a>
### TransactionId `property`

##### Summary

Transaction Identifier (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-TransactionType'></a>
### TransactionType `property`

##### Summary

On the basis of securities account turnover transaction type

<a name='P-Comdirect-Rest-Api-Comdirect-DepotTransaction-TransactionValue'></a>
### TransactionValue `property`

##### Summary

Value of the transaction

<a name='T-Comdirect-Rest-Api-Comdirect-DerivativeData'></a>
## DerivativeData `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

additional data of a derivative

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-CertificateType'></a>
### CertificateType `property`

##### Summary

Certificate Type

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-ExpiryDate'></a>
### ExpiryDate `property`

##### Summary

expiry date of a derivative

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-InterestPaymentDate'></a>
### InterestPaymentDate `property`

##### Summary

date of the interest payment of a bond

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-InterestPaymentInterval'></a>
### InterestPaymentInterval `property`

##### Summary

interval of the interest payment of a bond",allowableValues = "monthly, quarterly, biannualy, annualy

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-Leverage'></a>
### Leverage `property`

##### Summary

Leverage of the derivate

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-MaturityDate'></a>
### MaturityDate `property`

##### Summary

maturity Date of a bonds

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-Multiplier'></a>
### Multiplier `property`

##### Summary

multiplier of the underlying

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-NominalRate'></a>
### NominalRate `property`

##### Summary

nominal rate

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-Rating'></a>
### Rating `property`

##### Summary

rating

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-RemainingTermInYears'></a>
### RemainingTermInYears `property`

##### Summary

remaining Term (expiryDate-today)

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-StrikePrice'></a>
### StrikePrice `property`

##### Summary

strike price of the underlying

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-UnderlyingInstrument'></a>
### UnderlyingInstrument `property`

##### Summary

the underlying instrument

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-UnderlyingPrice'></a>
### UnderlyingPrice `property`

##### Summary

Price of the underlying

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-WarrantType'></a>
### WarrantType `property`

##### Summary

Warrant Type

<a name='P-Comdirect-Rest-Api-Comdirect-DerivativeData-YieldPA'></a>
### YieldPA `property`

##### Summary

yield p.a.

<a name='T-Comdirect-Rest-Api-Comdirect-Dimensions'></a>
## Dimensions `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for dimensions.

<a name='T-Comdirect-Rest-Api-Comdirect-Document'></a>
## Document `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a document.

<a name='P-Comdirect-Rest-Api-Comdirect-Document-Advertisement'></a>
### Advertisement `property`

##### Summary

Is the document advertising comdirect products?

<a name='P-Comdirect-Rest-Api-Comdirect-Document-DateCreation'></a>
### DateCreation `property`

##### Summary

Date at which the Document was assigned to the client.

<a name='P-Comdirect-Rest-Api-Comdirect-Document-Deletable'></a>
### Deletable `property`

##### Summary

Is the client allowed to delete the document?

<a name='P-Comdirect-Rest-Api-Comdirect-Document-DocumentId'></a>
### DocumentId `property`

##### Summary

Unique ID of the document (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Document-DocumentMetaData'></a>
### DocumentMetaData `property`

##### Summary

Object containing optional information about the document. Available information will differ between categories.

<a name='P-Comdirect-Rest-Api-Comdirect-Document-MimeType'></a>
### MimeType `property`

##### Summary

The native mimeType of the document.

<a name='P-Comdirect-Rest-Api-Comdirect-Document-Name'></a>
### Name `property`

##### Summary

Name or description of the document.

<a name='T-Comdirect-Rest-Api-Comdirect-DocumentMetadata'></a>
## DocumentMetadata `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for category-specific metadata of documents.

<a name='P-Comdirect-Rest-Api-Comdirect-DocumentMetadata-AlreadyRead'></a>
### AlreadyRead `property`

##### Summary

Has the document been read?

<a name='P-Comdirect-Rest-Api-Comdirect-DocumentMetadata-Archived'></a>
### Archived `property`

##### Summary

Is document archived?

<a name='P-Comdirect-Rest-Api-Comdirect-DocumentMetadata-DateRead'></a>
### DateRead `property`

##### Summary

Date on which the document was read.

<a name='T-Comdirect-Rest-Api-Comdirect-EnumText'></a>
## EnumText `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Holds a unique key and the corresponding text.

<a name='P-Comdirect-Rest-Api-Comdirect-EnumText-Key'></a>
### Key `property`

##### Summary

Unique key value for an enumeration type.

<a name='P-Comdirect-Rest-Api-Comdirect-EnumText-Text'></a>
### Text `property`

##### Summary

Display text in German language.

<a name='T-Comdirect-Rest-Api-Comdirect-Execution'></a>
## Execution `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for an order's execution.

<a name='P-Comdirect-Rest-Api-Comdirect-Execution-ExecutedQuantity'></a>
### ExecutedQuantity `property`

##### Summary

Quantity of executed units or nominal amount

<a name='P-Comdirect-Rest-Api-Comdirect-Execution-ExecutionId'></a>
### ExecutionId `property`

##### Summary

Execution ID (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Execution-ExecutionNumber'></a>
### ExecutionNumber `property`

##### Summary

Position (by time) of the execution of an order

<a name='P-Comdirect-Rest-Api-Comdirect-Execution-ExecutionPrice'></a>
### ExecutionPrice `property`

##### Summary

Execution price

<a name='P-Comdirect-Rest-Api-Comdirect-Execution-ExecutionTimestamp'></a>
### ExecutionTimestamp `property`

##### Summary

Date/timestamp of the order entry in UTC in the following format: (MiFID II) YYYY-MM-DDThh:mm:ss,ffffff+zz

<a name='T-Comdirect-Rest-Api-Comdirect-FXRateEUR'></a>
## FXRateEUR `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Exchange rate for settlement currency to FX.

<a name='P-Comdirect-Rest-Api-Comdirect-FXRateEUR-Ask'></a>
### Ask `property`

##### Summary

Ask rate of settlement currency to FX

<a name='P-Comdirect-Rest-Api-Comdirect-FXRateEUR-Bid'></a>
### Bid `property`

##### Summary

Bid rate of settlement currency to FX

<a name='T-Comdirect-Rest-Api-Comdirect-FixedTermSavings'></a>
## FixedTermSavings `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-ContractPeriodInMonths'></a>
### ContractPeriodInMonths `property`

##### Summary

Contract period of the deposit account in months.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-CreationDate'></a>
### CreationDate `property`

##### Summary

Start date of investment.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-ExpirationDate'></a>
### ExpirationDate `property`

##### Summary

End date of investment.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-Extendable'></a>
### Extendable `property`

##### Summary

Indicates whether the investment can be extended.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-FixedTermSavingsDisplayName'></a>
### FixedTermSavingsDisplayName `property`

##### Summary

Name of the deposit account.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-FixedTermSavingsId'></a>
### FixedTermSavingsId `property`

##### Summary

UUID of the deposit account.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-FixedTermSavingsType'></a>
### FixedTermSavingsType `property`

##### Summary

Type of the deposit account.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-InterestRate'></a>
### InterestRate `property`

##### Summary

Interest rate of the deposit account.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-ProlongationAmount'></a>
### ProlongationAmount `property`

##### Summary

Amount of money for prolongation.

<a name='P-Comdirect-Rest-Api-Comdirect-FixedTermSavings-SavingsAmount'></a>
### SavingsAmount `property`

##### Summary

Total of investment.

<a name='T-Comdirect-Rest-Api-Comdirect-FundDistribution'></a>
## FundDistribution `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

additional fund data, if the instrument is a fund

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-Bonification'></a>
### Bonification `property`

##### Summary

Bonification

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-Currency'></a>
### Currency `property`

##### Summary

currency of fund

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-DiscountIssueSurcharge'></a>
### DiscountIssueSurcharge `property`

##### Summary

Discount issue surcharge

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-FundFlags'></a>
### FundFlags `property`

##### Summary

List of different features of funds

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-FundStatus'></a>
### FundStatus `property`

##### Summary

Status of fund

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-IndividualIssueSurcharge'></a>
### IndividualIssueSurcharge `property`

##### Summary

Individual issue surcharge

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-InvestmentCategory'></a>
### InvestmentCategory `property`

##### Summary

Investment category

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-IsIndividualIssueSurchargeCorrected'></a>
### IsIndividualIssueSurchargeCorrected `property`

##### Summary

Is individual issue surcharge corrected

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-Rating'></a>
### Rating `property`

##### Summary

Rating

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-ReducedIssueSurcharge'></a>
### ReducedIssueSurcharge `property`

##### Summary

Reduced issue surcharge

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-RegularIssueSurcharge'></a>
### RegularIssueSurcharge `property`

##### Summary

Regular issue surcharge

<a name='P-Comdirect-Rest-Api-Comdirect-FundDistribution-TotalExpenseRatio'></a>
### TotalExpenseRatio `property`

##### Summary

Total expense ratio

<a name='T-Comdirect-Rest-Api-Comdirect-Inducement'></a>
## Inducement `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for an inducement.

<a name='P-Comdirect-Rest-Api-Comdirect-Inducement-Amount'></a>
### Amount `property`

##### Summary

Amount of the inducement

<a name='P-Comdirect-Rest-Api-Comdirect-Inducement-Estimated'></a>
### Estimated `property`

##### Summary

TRUE, if the amount is an estimation

<a name='T-Comdirect-Rest-Api-Comdirect-InstallmentLoan'></a>
## InstallmentLoan `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Master data of an installment loan

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-ContractConclusionDate'></a>
### ContractConclusionDate `property`

##### Summary

Date of conclusion of the installment loan.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-ContractPeriodInMonths'></a>
### ContractPeriodInMonths `property`

##### Summary

Runtime of the installment loan in months.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-CreditAmount'></a>
### CreditAmount `property`

##### Summary

Approved loan amount of the initial conclusion of the loan in EUR, including residual debt insurance and interest.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-EffectiveInterest'></a>
### EffectiveInterest `property`

##### Summary

Effective interest rate.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-InstallmentAmount'></a>
### InstallmentAmount `property`

##### Summary

Amount of the installment loan in EUR.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-InstallmentLoanId'></a>
### InstallmentLoanId `property`

##### Summary

Installment loan identifier (UUID).

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-NetCreditAmount'></a>
### NetCreditAmount `property`

##### Summary

Approved loan amount of the initial conclusion of the loan in EUR, before residual debt insurance and interest.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-NominalInterest'></a>
### NominalInterest `property`

##### Summary

Nominal interest rate.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-PaidOutAmount'></a>
### PaidOutAmount `property`

##### Summary

Paid out amount of the approved loan, can include additions or deductions for residual debt insurance or interest.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoan-ProductDisplayId'></a>
### ProductDisplayId `property`

##### Summary

SWK number of the installment loan.

<a name='T-Comdirect-Rest-Api-Comdirect-InstallmentLoanBalance'></a>
## InstallmentLoanBalance `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Balance and master data of an installment loan

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoanBalance-Balance'></a>
### Balance `property`

##### Summary

Current balance of the installment loan in EUR, including residual debt insurance and interest.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoanBalance-InstallmentLoan'></a>
### InstallmentLoan `property`

##### Summary

Master data of the installment loan.

<a name='P-Comdirect-Rest-Api-Comdirect-InstallmentLoanBalance-InstallmentLoanId'></a>
### InstallmentLoanId `property`

##### Summary

Installment loan identifier (UUID).

<a name='T-Comdirect-Rest-Api-Comdirect-Instrument'></a>
## Instrument `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for an instrument.

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-DerivativeData'></a>
### DerivativeData `property`

##### Summary

additional data of a derivative

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-FundsDistribution'></a>
### FundsDistribution `property`

##### Summary

additional fund data, if the instrument is a fund

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-InstrumentId'></a>
### InstrumentId `property`

##### Summary

Instrument id (UUID), unique identification of an instrument (security, derivative, etc.) for future use

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-Isin'></a>
### Isin `property`

##### Summary

ISIN

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-Mnemonic'></a>
### Mnemonic `property`

##### Summary

Security symbol according to WM data-service

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-Name'></a>
### Name `property`

##### Summary

Name of the instrument

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-OrderDimensions'></a>
### OrderDimensions `property`

##### Summary

List of the trading venues including the attributes (orderDimensions)

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-ShortName'></a>
### ShortName `property`

##### Summary

Short name of the instrument

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-StaticData'></a>
### StaticData `property`

##### Summary

Static data of the instrument, e.g., notation, instrument type

<a name='P-Comdirect-Rest-Api-Comdirect-Instrument-Wkn'></a>
### Wkn `property`

##### Summary

WKN

<a name='T-Comdirect-Rest-Api-Comdirect-Order'></a>
## Order `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for an order.

<a name='P-Comdirect-Rest-Api-Comdirect-Order-BestEx'></a>
### BestEx `property`

##### Summary

Flag if order is a best-execution-order, default value is false

<a name='P-Comdirect-Rest-Api-Comdirect-Order-CancelledQuantity'></a>
### CancelledQuantity `property`

##### Summary

Canceled quantity or nominal amount

<a name='P-Comdirect-Rest-Api-Comdirect-Order-CreationTimestamp'></a>
### CreationTimestamp `property`

##### Summary

Date/timestamp of the order entry in UTC with the following format: YYYY-MM-DDThh:mm:ss,ffffff+zz

<a name='P-Comdirect-Rest-Api-Comdirect-Order-DepotId'></a>
### DepotId `property`

##### Summary

Unique securities account identification (as UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Order-ExecutedQuantity'></a>
### ExecutedQuantity `property`

##### Summary

Canceled quantity or nominal amount

<a name='P-Comdirect-Rest-Api-Comdirect-Order-Executions'></a>
### Executions `property`

##### Summary

List of execution types for the order

<a name='P-Comdirect-Rest-Api-Comdirect-Order-ExpectedValue'></a>
### ExpectedValue `property`

##### Summary

Expected value of the limit order

<a name='P-Comdirect-Rest-Api-Comdirect-Order-InstrumentId'></a>
### InstrumentId `property`

##### Summary

WKN, ISIN or uuId; wkn will be returned if instrumentId is entered as wkn, an ISIN is returned if instrumentId is entered as ISIN, a uuId is returned if instrumentId is entered as uuId

<a name='P-Comdirect-Rest-Api-Comdirect-Order-LegNumber'></a>
### LegNumber `property`

##### Summary

Order leg number (if ordertype is OCO or NEO)

<a name='P-Comdirect-Rest-Api-Comdirect-Order-Limit'></a>
### Limit `property`

##### Summary

Limit of the order, empty in case of a market order, stop market, trailing stop market order or a corresponding suborder

<a name='P-Comdirect-Rest-Api-Comdirect-Order-LimitExtension'></a>
### LimitExtension `property`

##### Summary

Order extensions (Fill-or-Kill, Immediate-or-Cancel, All-or-None)

<a name='P-Comdirect-Rest-Api-Comdirect-Order-OpenQuantity'></a>
### OpenQuantity `property`

##### Summary

Open quantity or nominal amount

<a name='P-Comdirect-Rest-Api-Comdirect-Order-OrderId'></a>
### OrderId `property`

##### Summary

Unique order-Id (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Order-OrderStatus'></a>
### OrderStatus `property`

##### Summary

Status of the order

<a name='P-Comdirect-Rest-Api-Comdirect-Order-OrderType'></a>
### OrderType `property`

##### Summary

Ordertype, partially executed and open orders are listed in the execution parameters

<a name='P-Comdirect-Rest-Api-Comdirect-Order-Quantity'></a>
### Quantity `property`

##### Summary

Quantity or nominal amount in the case of a percentage quotation

<a name='P-Comdirect-Rest-Api-Comdirect-Order-QuoteId'></a>
### QuoteId `property`

##### Summary

Quote-Id as reference for the quote received from the trading venue (issuer or exchange) on the quote request

<a name='P-Comdirect-Rest-Api-Comdirect-Order-QuoteTicketId'></a>
### QuoteTicketId `property`

##### Summary

Ticket UUID for the quote order. This is mandatory, if for a quote order

<a name='P-Comdirect-Rest-Api-Comdirect-Order-SettlementAccountId'></a>
### SettlementAccountId `property`

##### Summary

Reference settlement account for the securities account, if different from the settlement account assigned directly to the securities account (UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Order-Side'></a>
### Side `property`

##### Summary

Type of transaction

<a name='P-Comdirect-Rest-Api-Comdirect-Order-SubOrders'></a>
### SubOrders `property`

##### Summary

Parts of the orders, e.g. combination orders OCO, NEO (Next Order) with different order legs or partially executed or partially cancelled orders with different parts of an order

<a name='P-Comdirect-Rest-Api-Comdirect-Order-TradingRestriction'></a>
### TradingRestriction `property`

##### Summary

Restrictions on trade (Opening Auction Only, Auction Only, Closing Auction Only)

<a name='P-Comdirect-Rest-Api-Comdirect-Order-TrailingLimitDistAbs'></a>
### TrailingLimitDistAbs `property`

##### Summary

Distance trigger limit of the trailing stop order from the current absolute price

<a name='P-Comdirect-Rest-Api-Comdirect-Order-TrailingLimitDistRel'></a>
### TrailingLimitDistRel `property`

##### Summary

Distance trigger limit of the trailing stop order from the current price in percentage

<a name='P-Comdirect-Rest-Api-Comdirect-Order-TriggerLimit'></a>
### TriggerLimit `property`

##### Summary

Trigger limit: stop limit by which a Stop order is triggered (Stop, TLS, OCO)

<a name='P-Comdirect-Rest-Api-Comdirect-Order-Validity'></a>
### Validity `property`

##### Summary

Date of order validity in format YYYY-MM-DD; required for validityType=GTD

<a name='P-Comdirect-Rest-Api-Comdirect-Order-ValidityType'></a>
### ValidityType `property`

##### Summary

Type of order validity (Good-for-day (default), Good-til-date (incl. end of month))

<a name='P-Comdirect-Rest-Api-Comdirect-Order-VenueId'></a>
### VenueId `property`

##### Summary

UUID of the trading venue or partner. This is mandatory, if isBestEx=FALSE

<a name='P-Comdirect-Rest-Api-Comdirect-Order-Version'></a>
### Version `property`

##### Summary

Version of the position to be sold. Only applicable for sell

<a name='T-Comdirect-Rest-Api-Comdirect-OrderStatus'></a>
## OrderStatus `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Status of the order.

<a name='T-Comdirect-Rest-Api-Comdirect-OrderType'></a>
## OrderType `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for an order type.

<a name='P-Comdirect-Rest-Api-Comdirect-OrderType-LimitExtensions'></a>
### LimitExtensions `property`

##### Summary

Names of the possible limit extensions

<a name='P-Comdirect-Rest-Api-Comdirect-OrderType-TradingRestrictions'></a>
### TradingRestrictions `property`

##### Summary

Names of possible trading restrictions

<a name='T-Comdirect-Rest-Api-Comdirect-OrderType2'></a>
## OrderType2 `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

The order type.

<a name='T-Comdirect-Rest-Api-Comdirect-OrderType3'></a>
## OrderType3 `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

The order type.

<a name='T-Comdirect-Rest-Api-Comdirect-PercentageString'></a>
## PercentageString `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Represents the percentage value.

<a name='P-Comdirect-Rest-Api-Comdirect-PercentageString-DecimalPlaces'></a>
### DecimalPlaces `property`

##### Summary

Decimal places

<a name='P-Comdirect-Rest-Api-Comdirect-PercentageString-PreDecimalPlaces'></a>
### PreDecimalPlaces `property`

##### Summary

Pre-decimal places

<a name='T-Comdirect-Rest-Api-Comdirect-Price'></a>
## Price `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Represents a price.

<a name='P-Comdirect-Rest-Api-Comdirect-Price-Price1'></a>
### Price1 `property`

##### Summary

Price.

<a name='P-Comdirect-Rest-Api-Comdirect-Price-PriceDateTime'></a>
### PriceDateTime `property`

##### Summary

Datetime with format: 'yyyy-MM-dd'T'HH:mm:ssX

<a name='P-Comdirect-Rest-Api-Comdirect-Price-Quantity'></a>
### Quantity `property`

##### Summary

Quantity or nominal amount in case of a percentage quotation.

<a name='P-Comdirect-Rest-Api-Comdirect-Price-Type'></a>
### Type `property`

##### Summary

Type of the price. Can be one of the following: {LST, BID, ASK, MID}.

<a name='T-Comdirect-Rest-Api-Comdirect-ProductBalance'></a>
## ProductBalance `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a product balance.

<a name='P-Comdirect-Rest-Api-Comdirect-ProductBalance-Balance'></a>
### Balance `property`

##### Summary

Balance object based on the product type.

<a name='P-Comdirect-Rest-Api-Comdirect-ProductBalance-ClientConnectionType'></a>
### ClientConnectionType `property`

##### Summary

Type of the client connection.

<a name='P-Comdirect-Rest-Api-Comdirect-ProductBalance-ProductId'></a>
### ProductId `property`

##### Summary

Unique ID of the product (UUID).

<a name='P-Comdirect-Rest-Api-Comdirect-ProductBalance-ProductType'></a>
### ProductType `property`

##### Summary

Type of the product.

<a name='P-Comdirect-Rest-Api-Comdirect-ProductBalance-TargetClientId'></a>
### TargetClientId `property`

##### Summary

Unique Id of the target client (UUID).

<a name='T-Comdirect-Rest-Api-Comdirect-Quote'></a>
## Quote `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a quote request.

<a name='P-Comdirect-Rest-Api-Comdirect-Quote-DepotId'></a>
### DepotId `property`

##### Summary

Unique securities account identification (as UUID)

<a name='P-Comdirect-Rest-Api-Comdirect-Quote-InstrumentId'></a>
### InstrumentId `property`

##### Summary

WKN, ISIN or uuId; wkn will be returned if instrumentId is entered as wkn, an ISIN is returned if instrumentId is entered as ISIN, a uuId is returned if instrumentId is entered as uuId

<a name='P-Comdirect-Rest-Api-Comdirect-Quote-Quantity'></a>
### Quantity `property`

##### Summary

Quantity or nominal amount in the case of a percentage quotation

<a name='P-Comdirect-Rest-Api-Comdirect-Quote-Side'></a>
### Side `property`

##### Summary

Type of transaction

<a name='P-Comdirect-Rest-Api-Comdirect-Quote-VenueId'></a>
### VenueId `property`

##### Summary

UUID of the trading venue or partner. This is mandatory, if isBestEx=FALSE

<a name='T-Comdirect-Rest-Api-Comdirect-Rating'></a>
## Rating `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Rating of the instrument.

<a name='P-Comdirect-Rest-Api-Comdirect-Rating-Moodys'></a>
### Moodys `property`

##### Summary

Bonds Rating

<a name='P-Comdirect-Rest-Api-Comdirect-Rating-Morningstar'></a>
### Morningstar `property`

##### Summary

Funds Rating

<a name='T-Comdirect-Rest-Api-Comdirect-Session'></a>
## Session `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for the current session.

<a name='P-Comdirect-Rest-Api-Comdirect-Session-Activated2FA'></a>
### Activated2FA `property`

##### Summary

Boolean indicating whether a second factor is already added to this session

<a name='P-Comdirect-Rest-Api-Comdirect-Session-Identifier'></a>
### Identifier `property`

##### Summary

Identifier of the session

<a name='P-Comdirect-Rest-Api-Comdirect-Session-SessionTanActive'></a>
### SessionTanActive `property`

##### Summary

This boolean is used to point out whether or not the current session has an active session TAN (transaction authentication number). With an active session TAN some use cases, that are genuinely TAN protected, might be callable without asking the client for a TAN. The validation method of session TAN ready use cases will return "TAN_FREE" as a TAN type while the session TAN is activated. The session TAN will be available after a refresh of tokens and dies with the last pair of tokens (access and refresh token).

<a name='T-Comdirect-Rest-Api-Comdirect-Side'></a>
## Side `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Possible transaction types

<a name='T-Comdirect-Rest-Api-Comdirect-Side2'></a>
## Side2 `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Possible transaction types.

<a name='T-Comdirect-Rest-Api-Comdirect-StaticData'></a>
## StaticData `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Static data of the instrument.

<a name='P-Comdirect-Rest-Api-Comdirect-StaticData-Currency'></a>
### Currency `property`

##### Summary

instrument currency of a security, e.g., for bonds, bond and open real estate funds; additionally to ISO 4217 currency code the following values are possible: XXX (Pcs.), XXP (Pts.), XXU (Unknown)

<a name='P-Comdirect-Rest-Api-Comdirect-StaticData-FundRedemptionLimited'></a>
### FundRedemptionLimited `property`

##### Summary

Flag indicating - if TRUE - that within prevalidation and before placement of a buy order a static note must be displayed indicating that the redemption of the fund is limited.

<a name='P-Comdirect-Rest-Api-Comdirect-StaticData-InstrumentType'></a>
### InstrumentType `property`

##### Summary

Instrument type

<a name='P-Comdirect-Rest-Api-Comdirect-StaticData-KidAvailable'></a>
### KidAvailable `property`

##### Summary

Flag indicating - if TRUE - that a Key Information Document (KID) of the issuer is electronically available. Before order placement a static note ought to displayed in such a case.

<a name='P-Comdirect-Rest-Api-Comdirect-StaticData-Notation'></a>
### Notation `property`

##### Summary

Ticker symbol or notation of a security

<a name='P-Comdirect-Rest-Api-Comdirect-StaticData-PriipsRelevant'></a>
### PriipsRelevant `property`

##### Summary

Flag indicating - if TRUE - that EU-regulation referring to Packaged Retail and Insurance-based Investment Products - PRIIPs) is relevant for the instrument

<a name='P-Comdirect-Rest-Api-Comdirect-StaticData-ShippingWaiverRequired'></a>
### ShippingWaiverRequired `property`

##### Summary

Flag indicating - if TRUE - that within prevalidation and before placement of a buy order the investor must approve, e.g., by a frontend checkbox that no shipping of fund sales information is required (waiver); a static note regarding that information ought to be displayed in such a case. Without an explicit waiver the order placement must be prevented in the frontend.

<a name='T-Comdirect-Rest-Api-Comdirect-TimestampString'></a>
## TimestampString `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Represents the date with up to 6 fractions of seconds.

<a name='P-Comdirect-Rest-Api-Comdirect-TimestampString-Timestamp'></a>
### Timestamp `property`

##### Summary

Date and time with following format: 'yyyy-MM-dd'T'HH:mm:ss,SSSSSSX'

<a name='T-Comdirect-Rest-Api-Comdirect-TotalCostBlock'></a>
## TotalCostBlock `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a total cost block including total cost entries segregated as: E (own service costs of bank), F (external service costs), and P (product costs).

<a name='P-Comdirect-Rest-Api-Comdirect-TotalCostBlock-ExternalCosts'></a>
### ExternalCosts `property`

##### Summary

Total cost entry for external service costs (F)

<a name='P-Comdirect-Rest-Api-Comdirect-TotalCostBlock-ProductCosts'></a>
### ProductCosts `property`

##### Summary

Total cost entry for product costs (P)

<a name='P-Comdirect-Rest-Api-Comdirect-TotalCostBlock-ServiceCosts'></a>
### ServiceCosts `property`

##### Summary

Total cost entry for own service costs of bank (E)

<a name='P-Comdirect-Rest-Api-Comdirect-TotalCostBlock-ServiceInducement'></a>
### ServiceInducement `property`

##### Summary

Total amount of inducements for own service costs of bank

<a name='T-Comdirect-Rest-Api-Comdirect-TotalCostEntry'></a>
## TotalCostEntry `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a total cost entry.

<a name='P-Comdirect-Rest-Api-Comdirect-TotalCostEntry-Amount'></a>
### Amount `property`

##### Summary

Total cost in reporting currency

<a name='P-Comdirect-Rest-Api-Comdirect-TotalCostEntry-AverageReturnPA'></a>
### AverageReturnPA `property`

##### Summary

Average return reduction per year

<a name='P-Comdirect-Rest-Api-Comdirect-TotalCostEntry-Label'></a>
### Label `property`

##### Summary

Label of total cost entry

<a name='P-Comdirect-Rest-Api-Comdirect-TotalCostEntry-Type'></a>
### Type `property`

##### Summary

Type of total cost entry

<a name='T-Comdirect-Rest-Api-Comdirect-TotalHoldingCostBlock'></a>
## TotalHoldingCostBlock `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

List of cost blocks over time.

<a name='P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostBlock-Sales'></a>
### Sales `property`

##### Summary

Total holding cost entry for the year of the sale

<a name='P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostBlock-Year1'></a>
### Year1 `property`

##### Summary

Total holding cost entry for the first year

<a name='P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostBlock-Year2'></a>
### Year2 `property`

##### Summary

Total holding cost entry for the second year

<a name='T-Comdirect-Rest-Api-Comdirect-TotalHoldingCostEntry'></a>
## TotalHoldingCostEntry `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for cost block over time.

<a name='P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostEntry-Amount'></a>
### Amount `property`

##### Summary

Cost in reporting currency

<a name='P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostEntry-AverageReturnPA'></a>
### AverageReturnPA `property`

##### Summary

Average return reduction per year

<a name='P-Comdirect-Rest-Api-Comdirect-TotalHoldingCostEntry-Type'></a>
### Type `property`

##### Summary

Type of total holding cost entry

<a name='T-Comdirect-Rest-Api-Comdirect-TransactionDirection'></a>
## TransactionDirection `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Filters for CREDIT, DEBIT or CREDIT_AND_DEBIT

<a name='T-Comdirect-Rest-Api-Comdirect-TransactionState'></a>
## TransactionState `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Filters for AccountTransactions. Will return all AccountTransactions (BOTH), or return all booked AccountTransactions (BOOKED), or all not booked AccountTransactions (NOTBOOKED).

<a name='T-Comdirect-Rest-Api-Comdirect-Type'></a>
## Type `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Type of venue.

<a name='T-Comdirect-Rest-Api-Comdirect-Venue'></a>
## Venue `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

##### Summary

Model for a venue.

<a name='T-Comdirect-Rest-Api-Comdirect-VisaCardImage'></a>
## VisaCardImage `type`

##### Namespace

Comdirect.Rest.Api.Comdirect

<a name='P-Comdirect-Rest-Api-Comdirect-VisaCardImage-ImageBaseFilename'></a>
### ImageBaseFilename `property`

##### Summary

Base filename for the files representing the image. The name has to be extended with a postfix indicating the resolution and file type, e.g. -1x.jpg. The resulting filename can be used to retrieve the image from the comdirect CMS

<a name='P-Comdirect-Rest-Api-Comdirect-VisaCardImage-ImageDescription'></a>
### ImageDescription `property`

##### Summary

Description of the image

<a name='P-Comdirect-Rest-Api-Comdirect-VisaCardImage-VisaCardImageId'></a>
### VisaCardImageId `property`

##### Summary

Visa card image ID to be used in the application
