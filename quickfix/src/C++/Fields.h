/* -*- C++ -*- */
/* ====================================================================
* The QuickFIX Software License, Version 1.0
*
* Copyright (c) 2001 ThoughtWorks, Inc.  All rights
* reserved.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions
* are met:
*
* 1. Redistributions of source code must retain the above copyright
*    notice, this list of conditions and the following disclaimer.
*
* 2. Redistributions in binary form must reproduce the above copyright
*    notice, this list of conditions and the following disclaimer in
*    the documentation and/or other materials provided with the
*    distribution.
*
* 3. The end-user documentation included with the redistribution,
*    if any, must include the following acknowledgment:
*       "This product includes software developed by
*        ThoughtWorks, Inc. (http://www.thoughtworks.com/)."
*    Alternately, this acknowledgment may appear in the software itself,
*    if and wherever such third-party acknowledgments normally appear.
*
* 4. The names "QuickFIX" and "ThoughtWorks, Inc." must
*    not be used to endorse or promote products derived from this
*    software without prior written permission. For written
*    permission, please contact quickfix-users@lists.sourceforge.net.
*
* 5. Products derived from this software may not be called "QuickFIX",
*    nor may "QuickFIX" appear in their name, without prior written
*    permission of ThoughtWorks, Inc.
*
* THIS SOFTWARE IS PROVIDED ``AS IS'' AND ANY EXPRESSED OR IMPLIED
* WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
* OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
* DISCLAIMED.  IN NO EVENT SHALL THOUGHTWORKS INC OR
* ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
* SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
* LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF
* USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
* ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
* OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT
* OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
* SUCH DAMAGE.
* ====================================================================
*/

#ifndef FIX_FIELDS_H
#define FIX_FIELDS_H
#undef Yield

#include "DeprecatedFields.h"
#include "Field.h"

namespace FIX
{
  
  DEFINE_STRING(Account);
  DEFINE_STRING(AdvId);
  DEFINE_STRING(AdvRefID);
  DEFINE_CHAR(AdvSide);
  DEFINE_STRING(AdvTransType);
  DEFINE_PRICE(AvgPx);
  DEFINE_SEQNUM(BeginSeqNo);
  DEFINE_STRING(BeginString);
  DEFINE_LENGTH(BodyLength);
  DEFINE_CHECKSUM(CheckSum);
  DEFINE_STRING(ClOrdID);
  DEFINE_AMT(Commission);
  DEFINE_CHAR(CommType);
  DEFINE_QTY(CumQty);
  DEFINE_CURRENCY(Currency);
  DEFINE_SEQNUM(EndSeqNo);
  DEFINE_STRING(ExecID);
  DEFINE_MULTIPLEVALUESTRING(ExecInst);
  DEFINE_STRING(ExecRefID);
  DEFINE_CHAR(ExecTransType);
  DEFINE_CHAR(HandlInst);
  DEFINE_STRING(SecurityIDSource);
  DEFINE_STRING(IOIid);
  DEFINE_CHAR(IOIOthSvc);
  DEFINE_CHAR(IOIQltyInd);
  DEFINE_STRING(IOIRefID);
  DEFINE_STRING(IOIQty);
  DEFINE_CHAR(IOITransType);
  DEFINE_CHAR(LastCapacity);
  DEFINE_EXCHANGE(LastMkt);
  DEFINE_PRICE(LastPx);
  DEFINE_QTY(LastQty);
  DEFINE_NUMINGROUP(LinesOfText);
  DEFINE_SEQNUM(MsgSeqNum);
  DEFINE_STRING(MsgType);
  DEFINE_SEQNUM(NewSeqNo);
  DEFINE_STRING(OrderID);
  DEFINE_QTY(OrderQty);
  DEFINE_CHAR(OrdStatus);
  DEFINE_CHAR(OrdType);
  DEFINE_STRING(OrigClOrdID);
  DEFINE_UTCTIMESTAMP(OrigTime);
  DEFINE_BOOLEAN(PossDupFlag);
  DEFINE_PRICE(Price);
  DEFINE_SEQNUM(RefSeqNum);
  DEFINE_STRING(RelatdSym);
  DEFINE_CHAR(Rule80A);
  DEFINE_STRING(SecurityID);
  DEFINE_STRING(SenderCompID);
  DEFINE_STRING(SenderSubID);
  DEFINE_LOCALMKTDATE(SendingDate);
  DEFINE_UTCTIMESTAMP(SendingTime);
  DEFINE_QTY(Quantity);
  DEFINE_CHAR(Side);
  DEFINE_STRING(Symbol);
  DEFINE_STRING(TargetCompID);
  DEFINE_STRING(TargetSubID);
  DEFINE_STRING(Text);
  DEFINE_CHAR(TimeInForce);
  DEFINE_UTCTIMESTAMP(TransactTime);
  DEFINE_CHAR(Urgency);
  DEFINE_UTCTIMESTAMP(ValidUntilTime);
  DEFINE_CHAR(SettlmntTyp);
  DEFINE_LOCALMKTDATE(FutSettDate);
  DEFINE_STRING(SymbolSfx);
  DEFINE_STRING(ListID);
  DEFINE_INT(ListSeqNo);
  DEFINE_INT(TotNoOrders);
  DEFINE_INT(ListNoOrds);
  DEFINE_STRING(ListExecInst);
  DEFINE_STRING(AllocID);
  DEFINE_CHAR(AllocTransType);
  DEFINE_STRING(RefAllocID);
  DEFINE_NUMINGROUP(NoOrders);
  DEFINE_INT(AvgPrxPrecision);
  DEFINE_LOCALMKTDATE(TradeDate);
  DEFINE_STRING(ExecBroker);
  DEFINE_CHAR(PositionEffect);
  DEFINE_NUMINGROUP(NoAllocs);
  DEFINE_STRING(AllocAccount);
  DEFINE_QTY(AllocQty);
  DEFINE_CHAR(ProcessCode);
  DEFINE_NUMINGROUP(NoRpts);
  DEFINE_INT(RptSeq);
  DEFINE_QTY(CxlQty);
  DEFINE_INT(NoDlvyInst);
  DEFINE_STRING(DlvyInst);
  DEFINE_INT(AllocStatus);
  DEFINE_INT(AllocRejCode);
  DEFINE_DATA(Signature);
  DEFINE_LENGTH(SecureDataLen);
  DEFINE_DATA(SecureData);
  DEFINE_STRING(BrokerOfCredit);
  DEFINE_LENGTH(SignatureLength);
  DEFINE_CHAR(EmailType);
  DEFINE_LENGTH(RawDataLength);
  DEFINE_DATA(RawData);
  DEFINE_BOOLEAN(PossResend);
  DEFINE_INT(EncryptMethod);
  DEFINE_PRICE(StopPx);
  DEFINE_EXCHANGE(ExDestination);
  DEFINE_INT(CxlRejReason);
  DEFINE_INT(OrdRejReason);
  DEFINE_CHAR(IOIQualifier);
  DEFINE_STRING(WaveNo);
  DEFINE_STRING(Issuer);
  DEFINE_STRING(SecurityDesc);
  DEFINE_INT(HeartBtInt);
  DEFINE_STRING(ClientID);
  DEFINE_QTY(MinQty);
  DEFINE_QTY(MaxFloor);
  DEFINE_STRING(TestReqID);
  DEFINE_BOOLEAN(ReportToExch);
  DEFINE_BOOLEAN(LocateReqd);
  DEFINE_STRING(OnBehalfOfCompID);
  DEFINE_STRING(OnBehalfOfSubID);
  DEFINE_STRING(QuoteID);
  DEFINE_AMT(NetMoney);
  DEFINE_AMT(SettlCurrAmt);
  DEFINE_CURRENCY(SettlCurrency);
  DEFINE_BOOLEAN(ForexReq);
  DEFINE_UTCTIMESTAMP(OrigSendingTime);
  DEFINE_BOOLEAN(GapFillFlag);
  DEFINE_NUMINGROUP(NoExecs);
  DEFINE_CHAR(CxlType);
  DEFINE_UTCTIMESTAMP(ExpireTime);
  DEFINE_CHAR(DKReason);
  DEFINE_STRING(DeliverToCompID);
  DEFINE_STRING(DeliverToSubID);
  DEFINE_BOOLEAN(IOINaturalFlag);
  DEFINE_STRING(QuoteReqID);
  DEFINE_PRICE(BidPx);
  DEFINE_PRICE(OfferPx);
  DEFINE_QTY(BidSize);
  DEFINE_QTY(OfferSize);
  DEFINE_NUMINGROUP(NoMiscFees);
  DEFINE_AMT(MiscFeeAmt);
  DEFINE_CURRENCY(MiscFeeCurr);
  DEFINE_CHAR(MiscFeeType);
  DEFINE_PRICE(PrevClosePx);
  DEFINE_BOOLEAN(ResetSeqNumFlag);
  DEFINE_STRING(SenderLocationID);
  DEFINE_STRING(TargetLocationID);
  DEFINE_STRING(OnBehalfOfLocationID);
  DEFINE_STRING(DeliverToLocationID);
  DEFINE_NUMINGROUP(NoRelatedSym);
  DEFINE_STRING(Subject);
  DEFINE_STRING(Headline);
  DEFINE_STRING(URLLink);
  DEFINE_CHAR(ExecType);
  DEFINE_QTY(LeavesQty);
  DEFINE_QTY(CashOrderQty);
  DEFINE_PRICE(AllocAvgPx);
  DEFINE_AMT(AllocNetMoney);
  DEFINE_FLOAT(SettlCurrFxRate);
  DEFINE_CHAR(SettlCurrFxRateCalc);
  DEFINE_INT(NumDaysInterest);
  DEFINE_PERCENTAGE(AccruedInterestRate);
  DEFINE_AMT(AccruedInterestAmt);
  DEFINE_CHAR(SettlInstMode);
  DEFINE_STRING(AllocText);
  DEFINE_STRING(SettlInstID);
  DEFINE_CHAR(SettlInstTransType);
  DEFINE_STRING(EmailThreadID);
  DEFINE_CHAR(SettlInstSource);
  DEFINE_STRING(SettlLocation);
  DEFINE_STRING(SecurityType);
  DEFINE_UTCTIMESTAMP(EffectiveTime);
  DEFINE_INT(StandInstDbType);
  DEFINE_STRING(StandInstDbName);
  DEFINE_STRING(StandInstDbID);
  DEFINE_INT(SettlDeliveryType);
  DEFINE_STRING(SettlDepositoryCode);
  DEFINE_STRING(SettlBrkrCode);
  DEFINE_STRING(SettlInstCode);
  DEFINE_STRING(SecuritySettlAgentName);
  DEFINE_STRING(SecuritySettlAgentCode);
  DEFINE_STRING(SecuritySettlAgentAcctNum);
  DEFINE_STRING(SecuritySettlAgentAcctName);
  DEFINE_STRING(SecuritySettlAgentContactName);
  DEFINE_STRING(SecuritySettlAgentContactPhone);
  DEFINE_STRING(CashSettlAgentName);
  DEFINE_STRING(CashSettlAgentCode);
  DEFINE_STRING(CashSettlAgentAcctNum);
  DEFINE_STRING(CashSettlAgentAcctName);
  DEFINE_STRING(CashSettlAgentContactName);
  DEFINE_STRING(CashSettlAgentContactPhone);
  DEFINE_PRICE(BidSpotRate);
  DEFINE_PRICEOFFSET(BidForwardPoints);
  DEFINE_PRICE(OfferSpotRate);
  DEFINE_PRICEOFFSET(OfferForwardPoints);
  DEFINE_QTY(OrderQty2);
  DEFINE_LOCALMKTDATE(FutSettDate2);
  DEFINE_PRICE(LastSpotRate);
  DEFINE_PRICEOFFSET(LastForwardPoints);
  DEFINE_STRING(AllocLinkID);
  DEFINE_INT(AllocLinkType);
  DEFINE_STRING(SecondaryOrderID);
  DEFINE_NUMINGROUP(NoIOIQualifiers);
  DEFINE_MONTHYEAR(MaturityMonthYear);
  DEFINE_INT(PutOrCall);
  DEFINE_PRICE(StrikePrice);
  DEFINE_INT(CoveredOrUncovered);
  DEFINE_INT(CustomerOrFirm);
  DEFINE_DAYOFMONTH(MaturityDay);
  DEFINE_CHAR(OptAttribute);
  DEFINE_EXCHANGE(SecurityExchange);
  DEFINE_BOOLEAN(NotifyBrokerOfCredit);
  DEFINE_INT(AllocHandlInst);
  DEFINE_QTY(MaxShow);
  DEFINE_PRICEOFFSET(PegDifference);
  DEFINE_LENGTH(XmlDataLen);
  DEFINE_DATA(XmlData);
  DEFINE_STRING(SettlInstRefID);
  DEFINE_NUMINGROUP(NoRoutingIDs);
  DEFINE_INT(RoutingType);
  DEFINE_STRING(RoutingID);
  DEFINE_PRICEOFFSET(Spread);
  DEFINE_CHAR(Benchmark);
  DEFINE_CURRENCY(BenchmarkCurveCurrency);
  DEFINE_STRING(BenchmarkCurveName);
  DEFINE_STRING(BenchmarkCurvePoint);
  DEFINE_PERCENTAGE(CouponRate);
  DEFINE_UTCDATE(CouponPaymentDate);
  DEFINE_UTCDATE(IssueDate);
  DEFINE_INT(RepurchaseTerm);
  DEFINE_PERCENTAGE(RepurchaseRate);
  DEFINE_FLOAT(Factor);
  DEFINE_UTCDATE(TradeOriginationDate);
  DEFINE_UTCDATE(ExDate);
  DEFINE_FLOAT(ContractMultiplier);
  DEFINE_NUMINGROUP(NoStipulations);
  DEFINE_STRING(StipulationType);
  DEFINE_STRING(StipulationValue);
  DEFINE_STRING(YieldType);
  DEFINE_PERCENTAGE(Yield);
  DEFINE_AMT(TotalTakedown);
  DEFINE_AMT(Concession);
  DEFINE_INT(RepoCollateralSecurityType);
  DEFINE_UTCDATE(RedemptionDate);
  DEFINE_UTCDATE(UnderlyingCouponPaymentDate);
  DEFINE_UTCDATE(UnderlyingIssueDate);
  DEFINE_INT(UnderlyingRepoCollateralSecurityType);
  DEFINE_INT(UnderlyingRepurchaseTerm);
  DEFINE_PERCENTAGE(UnderlyingRepurchaseRate);
  DEFINE_FLOAT(UnderlyingFactor);
  DEFINE_UTCDATE(UnderlyingRedemptionDate);
  DEFINE_UTCDATE(LegCouponPaymentDate);
  DEFINE_UTCDATE(LegIssueDate);
  DEFINE_INT(LegRepoCollateralSecurityType);
  DEFINE_INT(LegRepurchaseTerm);
  DEFINE_PERCENTAGE(LegRepurchaseRate);
  DEFINE_FLOAT(LegFactor);
  DEFINE_UTCDATE(LegRedemptionDate);
  DEFINE_STRING(CreditRating);
  DEFINE_STRING(UnderlyingCreditRating);
  DEFINE_STRING(LegCreditRating);
  DEFINE_BOOLEAN(TradedFlatSwitch);
  DEFINE_UTCDATE(BasisFeatureDate);
  DEFINE_PRICE(BasisFeaturePrice);
  DEFINE_STRING(MDReqID);
  DEFINE_CHAR(SubscriptionRequestType);
  DEFINE_INT(MarketDepth);
  DEFINE_INT(MDUpdateType);
  DEFINE_BOOLEAN(AggregatedBook);
  DEFINE_NUMINGROUP(NoMDEntryTypes);
  DEFINE_NUMINGROUP(NoMDEntries);
  DEFINE_CHAR(MDEntryType);
  DEFINE_PRICE(MDEntryPx);
  DEFINE_QTY(MDEntrySize);
  DEFINE_UTCDATE(MDEntryDate);
  DEFINE_UTCTIMEONLY(MDEntryTime);
  DEFINE_CHAR(TickDirection);
  DEFINE_EXCHANGE(MDMkt);
  DEFINE_MULTIPLEVALUESTRING(QuoteCondition);
  DEFINE_MULTIPLEVALUESTRING(TradeCondition);
  DEFINE_STRING(MDEntryID);
  DEFINE_CHAR(MDUpdateAction);
  DEFINE_STRING(MDEntryRefID);
  DEFINE_CHAR(MDReqRejReason);
  DEFINE_STRING(MDEntryOriginator);
  DEFINE_STRING(LocationID);
  DEFINE_STRING(DeskID);
  DEFINE_CHAR(DeleteReason);
  DEFINE_MULTIPLEVALUESTRING(OpenCloseSettleFlag);
  DEFINE_INT(SellerDays);
  DEFINE_STRING(MDEntryBuyer);
  DEFINE_STRING(MDEntrySeller);
  DEFINE_INT(MDEntryPositionNo);
  DEFINE_MULTIPLEVALUESTRING(FinancialStatus);
  DEFINE_MULTIPLEVALUESTRING(CorporateAction);
  DEFINE_QTY(DefBidSize);
  DEFINE_QTY(DefOfferSize);
  DEFINE_NUMINGROUP(NoQuoteEntries);
  DEFINE_NUMINGROUP(NoQuoteSets);
  DEFINE_INT(QuoteStatus);
  DEFINE_INT(QuoteCancelType);
  DEFINE_STRING(QuoteEntryID);
  DEFINE_INT(QuoteRejectReason);
  DEFINE_INT(QuoteResponseLevel);
  DEFINE_STRING(QuoteSetID);
  DEFINE_INT(QuoteRequestType);
  DEFINE_INT(TotQuoteEntries);
  DEFINE_STRING(UnderlyingSecurityIDSource);
  DEFINE_STRING(UnderlyingIssuer);
  DEFINE_STRING(UnderlyingSecurityDesc);
  DEFINE_EXCHANGE(UnderlyingSecurityExchange);
  DEFINE_STRING(UnderlyingSecurityID);
  DEFINE_STRING(UnderlyingSecurityType);
  DEFINE_STRING(UnderlyingSymbol);
  DEFINE_STRING(UnderlyingSymbolSfx);
  DEFINE_MONTHYEAR(UnderlyingMaturityMonthYear);
  DEFINE_DAYOFMONTH(UnderlyingMaturityDay);
  DEFINE_INT(UnderlyingPutOrCall);
  DEFINE_PRICE(UnderlyingStrikePrice);
  DEFINE_CHAR(UnderlyingOptAttribute);
  DEFINE_CURRENCY(UnderlyingCurrency);
  DEFINE_QTY(RatioQty);
  DEFINE_STRING(SecurityReqID);
  DEFINE_INT(SecurityRequestType);
  DEFINE_STRING(SecurityResponseID);
  DEFINE_INT(SecurityResponseType);
  DEFINE_STRING(SecurityStatusReqID);
  DEFINE_BOOLEAN(UnsolicitedIndicator);
  DEFINE_INT(SecurityTradingStatus);
  DEFINE_CHAR(HaltReason);
  DEFINE_BOOLEAN(InViewOfCommon);
  DEFINE_BOOLEAN(DueToRelated);
  DEFINE_QTY(BuyVolume);
  DEFINE_QTY(SellVolume);
  DEFINE_PRICE(HighPx);
  DEFINE_PRICE(LowPx);
  DEFINE_INT(Adjustment);
  DEFINE_STRING(TradSesReqID);
  DEFINE_STRING(TradingSessionID);
  DEFINE_STRING(ContraTrader);
  DEFINE_INT(TradSesMethod);
  DEFINE_INT(TradSesMode);
  DEFINE_INT(TradSesStatus);
  DEFINE_UTCTIMESTAMP(TradSesStartTime);
  DEFINE_UTCTIMESTAMP(TradSesOpenTime);
  DEFINE_UTCTIMESTAMP(TradSesPreCloseTime);
  DEFINE_UTCTIMESTAMP(TradSesCloseTime);
  DEFINE_UTCTIMESTAMP(TradSesEndTime);
  DEFINE_INT(NumberOfOrders);
  DEFINE_STRING(MessageEncoding);
  DEFINE_LENGTH(EncodedIssuerLen);
  DEFINE_DATA(EncodedIssuer);
  DEFINE_LENGTH(EncodedSecurityDescLen);
  DEFINE_DATA(EncodedSecurityDesc);
  DEFINE_LENGTH(EncodedListExecInstLen);
  DEFINE_DATA(EncodedListExecInst);
  DEFINE_LENGTH(EncodedTextLen);
  DEFINE_DATA(EncodedText);
  DEFINE_LENGTH(EncodedSubjectLen);
  DEFINE_DATA(EncodedSubject);
  DEFINE_LENGTH(EncodedHeadlineLen);
  DEFINE_DATA(EncodedHeadline);
  DEFINE_LENGTH(EncodedAllocTextLen);
  DEFINE_DATA(EncodedAllocText);
  DEFINE_LENGTH(EncodedUnderlyingIssuerLen);
  DEFINE_DATA(EncodedUnderlyingIssuer);
  DEFINE_LENGTH(EncodedUnderlyingSecurityDescLen);
  DEFINE_DATA(EncodedUnderlyingSecurityDesc);
  DEFINE_PRICE(AllocPrice);
  DEFINE_UTCTIMESTAMP(QuoteSetValidUntilTime);
  DEFINE_INT(QuoteEntryRejectReason);
  DEFINE_SEQNUM(LastMsgSeqNumProcessed);
  DEFINE_UTCTIMESTAMP(OnBehalfOfSendingTime);
  DEFINE_INT(RefTagID);
  DEFINE_STRING(RefMsgType);
  DEFINE_INT(SessionRejectReason);
  DEFINE_CHAR(BidRequestTransType);
  DEFINE_STRING(ContraBroker);
  DEFINE_STRING(ComplianceID);
  DEFINE_BOOLEAN(SolicitedFlag);
  DEFINE_INT(ExecRestatementReason);
  DEFINE_STRING(BusinessRejectRefID);
  DEFINE_INT(BusinessRejectReason);
  DEFINE_AMT(GrossTradeAmt);
  DEFINE_NUMINGROUP(NoContraBrokers);
  DEFINE_LENGTH(MaxMessageSize);
  DEFINE_NUMINGROUP(NoMsgTypes);
  DEFINE_CHAR(MsgDirection);
  DEFINE_NUMINGROUP(NoTradingSessions);
  DEFINE_QTY(TotalVolumeTraded);
  DEFINE_CHAR(DiscretionInst);
  DEFINE_PRICEOFFSET(DiscretionOffset);
  DEFINE_STRING(BidID);
  DEFINE_STRING(ClientBidID);
  DEFINE_STRING(ListName);
  DEFINE_INT(TotalNumSecurities);
  DEFINE_INT(BidType);
  DEFINE_INT(NumTickets);
  DEFINE_AMT(SideValue1);
  DEFINE_AMT(SideValue2);
  DEFINE_NUMINGROUP(NoBidDescriptors);
  DEFINE_INT(BidDescriptorType);
  DEFINE_STRING(BidDescriptor);
  DEFINE_INT(SideValueInd);
  DEFINE_PERCENTAGE(LiquidityPctLow);
  DEFINE_PERCENTAGE(LiquidityPctHigh);
  DEFINE_AMT(LiquidityValue);
  DEFINE_PERCENTAGE(EFPTrackingError);
  DEFINE_AMT(FairValue);
  DEFINE_PERCENTAGE(OutsideIndexPct);
  DEFINE_AMT(ValueOfFutures);
  DEFINE_INT(LiquidityIndType);
  DEFINE_PERCENTAGE(WtAverageLiquidity);
  DEFINE_BOOLEAN(ExchangeForPhysical);
  DEFINE_AMT(OutMainCntryUIndex);
  DEFINE_PERCENTAGE(CrossPercent);
  DEFINE_INT(ProgRptReqs);
  DEFINE_INT(ProgPeriodInterval);
  DEFINE_INT(IncTaxInd);
  DEFINE_INT(NumBidders);
  DEFINE_CHAR(TradeType);
  DEFINE_CHAR(BasisPxType);
  DEFINE_NUMINGROUP(NoBidComponents);
  DEFINE_COUNTRY(Country);
  DEFINE_INT(TotNoStrikes);
  DEFINE_INT(PriceType);
  DEFINE_QTY(DayOrderQty);
  DEFINE_QTY(DayCumQty);
  DEFINE_PRICE(DayAvgPx);
  DEFINE_INT(GTBookingInst);
  DEFINE_NUMINGROUP(NoStrikes);
  DEFINE_INT(ListStatusType);
  DEFINE_INT(NetGrossInd);
  DEFINE_INT(ListOrderStatus);
  DEFINE_LOCALMKTDATE(ExpireDate);
  DEFINE_CHAR(ListExecInstType);
  DEFINE_CHAR(CxlRejResponseTo);
  DEFINE_PERCENTAGE(UnderlyingCouponRate);
  DEFINE_FLOAT(UnderlyingContractMultiplier);
  DEFINE_QTY(ContraTradeQty);
  DEFINE_UTCTIMESTAMP(ContraTradeTime);
  DEFINE_STRING(ClearingFirm);
  DEFINE_STRING(ClearingAccount);
  DEFINE_INT(LiquidityNumSecurities);
  DEFINE_CHAR(MultiLegReportingType);
  DEFINE_UTCTIMESTAMP(StrikeTime);
  DEFINE_STRING(ListStatusText);
  DEFINE_LENGTH(EncodedListStatusTextLen);
  DEFINE_DATA(EncodedListStatusText);
  DEFINE_CHAR(PartyIDSource);
  DEFINE_STRING(PartyID);
  DEFINE_UTCDATE(TotalVolumeTradedDate);
  DEFINE_UTCTIMEONLY(TotalVolumeTradedTime);
  DEFINE_PRICEOFFSET(NetChgPrevDay);
  DEFINE_INT(PartyRole);
  DEFINE_NUMINGROUP(NoPartyIDs);
  DEFINE_NUMINGROUP(NoSecurityAltID);
  DEFINE_STRING(SecurityAltID);
  DEFINE_STRING(SecurityAltIDSource);
  DEFINE_NUMINGROUP(NoUnderlyingSecurityAltID);
  DEFINE_STRING(UnderlyingSecurityAltID);
  DEFINE_STRING(UnderlyingSecurityAltIDSource);
  DEFINE_INT(Product);
  DEFINE_STRING(CFICode);
  DEFINE_INT(UnderlyingProduct);
  DEFINE_STRING(UnderlyingCFICode);
  DEFINE_BOOLEAN(TestMessageIndicator);
  DEFINE_INT(QuantityType);
  DEFINE_STRING(BookingRefID);
  DEFINE_STRING(IndividualAllocID);
  DEFINE_CHAR(RoundingDirection);
  DEFINE_FLOAT(RoundingModulus);
  DEFINE_COUNTRY(CountryOfIssue);
  DEFINE_STRING(StateOrProvinceOfIssue);
  DEFINE_STRING(LocaleOfIssue);
  DEFINE_NUMINGROUP(NoRegistDtls);
  DEFINE_STRING(MailingDtls);
  DEFINE_COUNTRY(InvestorCountryOfResidence);
  DEFINE_STRING(PaymentRef);
  DEFINE_INT(DistribPaymentMethod);
  DEFINE_CURRENCY(CashDistribCurr);
  DEFINE_CURRENCY(CommCurrency);
  DEFINE_CHAR(CancellationRights);
  DEFINE_CHAR(MoneyLaunderingStatus);
  DEFINE_STRING(MailingInst);
  DEFINE_UTCTIMESTAMP(TransBkdTime);
  DEFINE_CHAR(ExecPriceType);
  DEFINE_FLOAT(ExecPriceAdjustment);
  DEFINE_LOCALMKTDATE(DateOfBirth);
  DEFINE_CHAR(TradeReportTransType);
  DEFINE_STRING(CardHolderName);
  DEFINE_STRING(CardNumber);
  DEFINE_LOCALMKTDATE(CardExpDate);
  DEFINE_STRING(CardIssNo);
  DEFINE_INT(PaymentMethod);
  DEFINE_STRING(RegistAcctType);
  DEFINE_STRING(Designation);
  DEFINE_INT(TaxAdvantageType);
  DEFINE_STRING(RegistRejReasonText);
  DEFINE_CHAR(FundRenewWaiv);
  DEFINE_STRING(CashDistribAgentName);
  DEFINE_STRING(CashDistribAgentCode);
  DEFINE_STRING(CashDistribAgentAcctNumber);
  DEFINE_STRING(CashDistribPayRef);
  DEFINE_STRING(CashDistribAgentAcctName);
  DEFINE_LOCALMKTDATE(CardStartDate);
  DEFINE_LOCALMKTDATE(PaymentDate);
  DEFINE_STRING(PaymentRemitterID);
  DEFINE_CHAR(RegistStatus);
  DEFINE_INT(RegistRejReasonCode);
  DEFINE_STRING(RegistRefID);
  DEFINE_STRING(RegistDetls);
  DEFINE_NUMINGROUP(NoDistribInsts);
  DEFINE_STRING(RegistEmail);
  DEFINE_PERCENTAGE(DistribPercentage);
  DEFINE_STRING(RegistID);
  DEFINE_CHAR(RegistTransType);
  DEFINE_UTCTIMESTAMP(ExecValuationPoint);
  DEFINE_PERCENTAGE(OrderPercent);
  DEFINE_CHAR(OwnershipType);
  DEFINE_NUMINGROUP(NoContAmts);
  DEFINE_INT(ContAmtType);
  DEFINE_FLOAT(ContAmtValue);
  DEFINE_CURRENCY(ContAmtCurr);
  DEFINE_INT(OwnerType);
  DEFINE_STRING(PartySubID);
  DEFINE_STRING(NestedPartyID);
  DEFINE_CHAR(NestedPartyIDSource);
  DEFINE_STRING(SecondaryClOrdID);
  DEFINE_STRING(SecondaryExecID);
  DEFINE_CHAR(OrderCapacity);
  DEFINE_MULTIPLEVALUESTRING(OrderRestrictions);
  DEFINE_CHAR(MassCancelRequestType);
  DEFINE_CHAR(MassCancelResponse);
  DEFINE_CHAR(MassCancelRejectReason);
  DEFINE_INT(TotalAffectedOrders);
  DEFINE_INT(NoAffectedOrders);
  DEFINE_STRING(AffectedOrderID);
  DEFINE_STRING(AffectedSecondaryOrderID);
  DEFINE_INT(QuoteType);
  DEFINE_INT(NestedPartyRole);
  DEFINE_NUMINGROUP(NoNestedPartyIDs);
  DEFINE_AMT(TotalAccruedInterestAmt);
  DEFINE_LOCALMKTDATE(MaturityDate);
  DEFINE_LOCALMKTDATE(UnderlyingMaturityDate);
  DEFINE_STRING(InstrRegistry);
  DEFINE_CHAR(CashMargin);
  DEFINE_STRING(NestedPartySubID);
  DEFINE_MULTIPLEVALUESTRING(Scope);
  DEFINE_BOOLEAN(MDImplicitDelete);
  DEFINE_STRING(CrossID);
  DEFINE_INT(CrossType);
  DEFINE_INT(CrossPrioritization);
  DEFINE_STRING(OrigCrossID);
  DEFINE_NUMINGROUP(NoSides);
  DEFINE_STRING(Username);
  DEFINE_STRING(Password);
  DEFINE_NUMINGROUP(NoLegs);
  DEFINE_CURRENCY(LegCurrency);
  DEFINE_INT(TotalNumSecurityTypes);
  DEFINE_NUMINGROUP(NoSecurityTypes);
  DEFINE_INT(SecurityListRequestType);
  DEFINE_INT(SecurityRequestResult);
  DEFINE_QTY(RoundLot);
  DEFINE_QTY(MinTradeVol);
  DEFINE_INT(MultiLegRptTypeReq);
  DEFINE_CHAR(LegPositionEffect);
  DEFINE_INT(LegCoveredOrUncovered);
  DEFINE_PRICE(LegPrice);
  DEFINE_INT(TradSesStatusRejReason);
  DEFINE_STRING(TradeRequestID);
  DEFINE_INT(TradeRequestType);
  DEFINE_BOOLEAN(PreviouslyReported);
  DEFINE_STRING(TradeReportID);
  DEFINE_STRING(TradeReportRefID);
  DEFINE_CHAR(MatchStatus);
  DEFINE_STRING(MatchType);
  DEFINE_BOOLEAN(OddLot);
  DEFINE_INT(NoClearingInstructions);
  DEFINE_INT(ClearingInstruction);
  DEFINE_STRING(TradeInputSource);
  DEFINE_STRING(TradeInputDevice);
  DEFINE_INT(NoDates);
  DEFINE_INT(AccountType);
  DEFINE_INT(CustOrderCapacity);
  DEFINE_STRING(ClOrdLinkID);
  DEFINE_STRING(MassStatusReqID);
  DEFINE_INT(MassStatusReqType);
  DEFINE_UTCTIMESTAMP(OrigOrdModTime);
  DEFINE_CHAR(LegSettlmntTyp);
  DEFINE_LOCALMKTDATE(LegFutSettDate);
  DEFINE_CHAR(DayBookingInst);
  DEFINE_CHAR(BookingUnit);
  DEFINE_CHAR(PreallocMethod);
  DEFINE_COUNTRY(UnderlyingCountryOfIssue);
  DEFINE_STRING(UnderlyingStateOrProvinceOfIssue);
  DEFINE_STRING(UnderlyingLocaleOfIssue);
  DEFINE_STRING(UnderlyingInstrRegistry);
  DEFINE_COUNTRY(LegCountryOfIssue);
  DEFINE_STRING(LegStateOrProvinceOfIssue);
  DEFINE_STRING(LegLocaleOfIssue);
  DEFINE_STRING(LegInstrRegistry);
  DEFINE_STRING(LegSymbol);
  DEFINE_STRING(LegSymbolSfx);
  DEFINE_STRING(LegSecurityID);
  DEFINE_STRING(LegSecurityIDSource);
  DEFINE_STRING(NoLegSecurityAltID);
  DEFINE_STRING(LegSecurityAltID);
  DEFINE_STRING(LegSecurityAltIDSource);
  DEFINE_INT(LegProduct);
  DEFINE_STRING(LegCFICode);
  DEFINE_STRING(LegSecurityType);
  DEFINE_MONTHYEAR(LegMaturityMonthYear);
  DEFINE_LOCALMKTDATE(LegMaturityDate);
  DEFINE_PRICE(LegStrikePrice);
  DEFINE_CHAR(LegOptAttribute);
  DEFINE_FLOAT(LegContractMultiplier);
  DEFINE_PERCENTAGE(LegCouponRate);
  DEFINE_EXCHANGE(LegSecurityExchange);
  DEFINE_STRING(LegIssuer);
  DEFINE_LENGTH(EncodedLegIssuerLen);
  DEFINE_DATA(EncodedLegIssuer);
  DEFINE_STRING(LegSecurityDesc);
  DEFINE_LENGTH(EncodedLegSecurityDescLen);
  DEFINE_DATA(EncodedLegSecurityDesc);
  DEFINE_FLOAT(LegRatioQty);
  DEFINE_CHAR(LegSide);
  DEFINE_STRING(TradingSessionSubID);
  DEFINE_INT(AllocType);
  DEFINE_NUMINGROUP(NoHops);
  DEFINE_STRING(HopCompID);
  DEFINE_UTCTIMESTAMP(HopSendingTime);
  DEFINE_SEQNUM(HopRefID);
  DEFINE_PRICE(MidPx);
  DEFINE_PERCENTAGE(BidYield);
  DEFINE_PERCENTAGE(MidYield);
  DEFINE_PERCENTAGE(OfferYield);
  DEFINE_STRING(ClearingFeeIndicator);
  DEFINE_BOOLEAN(WorkingIndicator);
  DEFINE_PRICE(LegLastPx);
  DEFINE_INT(PriorityIndicator);
  DEFINE_PRICEOFFSET(PriceImprovement);
  DEFINE_PRICE(Price2);
  DEFINE_PRICEOFFSET(LastForwardPoints2);
  DEFINE_PRICEOFFSET(BidForwardPoints2);
  DEFINE_PRICEOFFSET(OfferForwardPoints2);
  DEFINE_STRING(RFQReqID);
  DEFINE_PRICE(MktBidPx);
  DEFINE_PRICE(MktOfferPx);
  DEFINE_QTY(MinBidSize);
  DEFINE_QTY(MinOfferSize);
  DEFINE_STRING(QuoteStatusReqID);
  DEFINE_BOOLEAN(LegalConfirm);
  DEFINE_PRICE(UnderlyingLastPx);
  DEFINE_QTY(UnderlyingLastQty);
  DEFINE_INT(SecDefStatus);
  DEFINE_STRING(LegRefID);
  DEFINE_STRING(ContraLegRefID);
  DEFINE_FLOAT(SettlCurrBidFxRate);
  DEFINE_FLOAT(SettlCurrOfferFxRate);
  DEFINE_INT(QuoteRequestRejectReason);
  DEFINE_STRING(SideComplianceID);
}
#endif //FIX_FIELDS_H
 