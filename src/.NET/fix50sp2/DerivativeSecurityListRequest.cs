namespace QuickFix50Sp2
{

  public class DerivativeSecurityListRequest : Message
  {
    public DerivativeSecurityListRequest() : base(MsgType()) {}
    static QuickFix.MsgType MsgType() { return new QuickFix.MsgType("z"); }

    public DerivativeSecurityListRequest(
      QuickFix.SecurityReqID aSecurityReqID,
      QuickFix.SecurityListRequestType aSecurityListRequestType )
    : base(MsgType()) {
      set(aSecurityReqID);
      set(aSecurityListRequestType);
    }

    public void set(QuickFix.SecurityReqID value)
    { setField(value); }
    public QuickFix.SecurityReqID get(QuickFix.SecurityReqID  value)
    { getField(value); return value; }
    public QuickFix.SecurityReqID getSecurityReqID()
    { QuickFix.SecurityReqID value = new QuickFix.SecurityReqID();
      getField(value); return value; }
    public bool isSet(QuickFix.SecurityReqID field)
    { return isSetField(field); }
    public bool isSetSecurityReqID()
    { return isSetField(320); }

    public void set(QuickFix.SecurityListRequestType value)
    { setField(value); }
    public QuickFix.SecurityListRequestType get(QuickFix.SecurityListRequestType  value)
    { getField(value); return value; }
    public QuickFix.SecurityListRequestType getSecurityListRequestType()
    { QuickFix.SecurityListRequestType value = new QuickFix.SecurityListRequestType();
      getField(value); return value; }
    public bool isSet(QuickFix.SecurityListRequestType field)
    { return isSetField(field); }
    public bool isSetSecurityListRequestType()
    { return isSetField(559); }

    public void set(QuickFix.MarketID value)
    { setField(value); }
    public QuickFix.MarketID get(QuickFix.MarketID  value)
    { getField(value); return value; }
    public QuickFix.MarketID getMarketID()
    { QuickFix.MarketID value = new QuickFix.MarketID();
      getField(value); return value; }
    public bool isSet(QuickFix.MarketID field)
    { return isSetField(field); }
    public bool isSetMarketID()
    { return isSetField(1301); }

    public void set(QuickFix.MarketSegmentID value)
    { setField(value); }
    public QuickFix.MarketSegmentID get(QuickFix.MarketSegmentID  value)
    { getField(value); return value; }
    public QuickFix.MarketSegmentID getMarketSegmentID()
    { QuickFix.MarketSegmentID value = new QuickFix.MarketSegmentID();
      getField(value); return value; }
    public bool isSet(QuickFix.MarketSegmentID field)
    { return isSetField(field); }
    public bool isSetMarketSegmentID()
    { return isSetField(1300); }

    public void set(QuickFix.UnderlyingSymbol value)
    { setField(value); }
    public QuickFix.UnderlyingSymbol get(QuickFix.UnderlyingSymbol  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSymbol getUnderlyingSymbol()
    { QuickFix.UnderlyingSymbol value = new QuickFix.UnderlyingSymbol();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSymbol field)
    { return isSetField(field); }
    public bool isSetUnderlyingSymbol()
    { return isSetField(311); }

    public void set(QuickFix.UnderlyingSymbolSfx value)
    { setField(value); }
    public QuickFix.UnderlyingSymbolSfx get(QuickFix.UnderlyingSymbolSfx  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSymbolSfx getUnderlyingSymbolSfx()
    { QuickFix.UnderlyingSymbolSfx value = new QuickFix.UnderlyingSymbolSfx();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSymbolSfx field)
    { return isSetField(field); }
    public bool isSetUnderlyingSymbolSfx()
    { return isSetField(312); }

    public void set(QuickFix.UnderlyingSecurityID value)
    { setField(value); }
    public QuickFix.UnderlyingSecurityID get(QuickFix.UnderlyingSecurityID  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSecurityID getUnderlyingSecurityID()
    { QuickFix.UnderlyingSecurityID value = new QuickFix.UnderlyingSecurityID();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSecurityID field)
    { return isSetField(field); }
    public bool isSetUnderlyingSecurityID()
    { return isSetField(309); }

    public void set(QuickFix.UnderlyingSecurityIDSource value)
    { setField(value); }
    public QuickFix.UnderlyingSecurityIDSource get(QuickFix.UnderlyingSecurityIDSource  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSecurityIDSource getUnderlyingSecurityIDSource()
    { QuickFix.UnderlyingSecurityIDSource value = new QuickFix.UnderlyingSecurityIDSource();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSecurityIDSource field)
    { return isSetField(field); }
    public bool isSetUnderlyingSecurityIDSource()
    { return isSetField(305); }

    public void set(QuickFix.UnderlyingProduct value)
    { setField(value); }
    public QuickFix.UnderlyingProduct get(QuickFix.UnderlyingProduct  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingProduct getUnderlyingProduct()
    { QuickFix.UnderlyingProduct value = new QuickFix.UnderlyingProduct();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingProduct field)
    { return isSetField(field); }
    public bool isSetUnderlyingProduct()
    { return isSetField(462); }

    public void set(QuickFix.UnderlyingCFICode value)
    { setField(value); }
    public QuickFix.UnderlyingCFICode get(QuickFix.UnderlyingCFICode  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCFICode getUnderlyingCFICode()
    { QuickFix.UnderlyingCFICode value = new QuickFix.UnderlyingCFICode();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCFICode field)
    { return isSetField(field); }
    public bool isSetUnderlyingCFICode()
    { return isSetField(463); }

    public void set(QuickFix.UnderlyingSecurityType value)
    { setField(value); }
    public QuickFix.UnderlyingSecurityType get(QuickFix.UnderlyingSecurityType  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSecurityType getUnderlyingSecurityType()
    { QuickFix.UnderlyingSecurityType value = new QuickFix.UnderlyingSecurityType();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSecurityType field)
    { return isSetField(field); }
    public bool isSetUnderlyingSecurityType()
    { return isSetField(310); }

    public void set(QuickFix.UnderlyingSecuritySubType value)
    { setField(value); }
    public QuickFix.UnderlyingSecuritySubType get(QuickFix.UnderlyingSecuritySubType  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSecuritySubType getUnderlyingSecuritySubType()
    { QuickFix.UnderlyingSecuritySubType value = new QuickFix.UnderlyingSecuritySubType();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSecuritySubType field)
    { return isSetField(field); }
    public bool isSetUnderlyingSecuritySubType()
    { return isSetField(763); }

    public void set(QuickFix.UnderlyingMaturityMonthYear value)
    { setField(value); }
    public QuickFix.UnderlyingMaturityMonthYear get(QuickFix.UnderlyingMaturityMonthYear  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingMaturityMonthYear getUnderlyingMaturityMonthYear()
    { QuickFix.UnderlyingMaturityMonthYear value = new QuickFix.UnderlyingMaturityMonthYear();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingMaturityMonthYear field)
    { return isSetField(field); }
    public bool isSetUnderlyingMaturityMonthYear()
    { return isSetField(313); }

    public void set(QuickFix.UnderlyingMaturityDate value)
    { setField(value); }
    public QuickFix.UnderlyingMaturityDate get(QuickFix.UnderlyingMaturityDate  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingMaturityDate getUnderlyingMaturityDate()
    { QuickFix.UnderlyingMaturityDate value = new QuickFix.UnderlyingMaturityDate();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingMaturityDate field)
    { return isSetField(field); }
    public bool isSetUnderlyingMaturityDate()
    { return isSetField(542); }

    public void set(QuickFix.UnderlyingMaturityTime value)
    { setField(value); }
    public QuickFix.UnderlyingMaturityTime get(QuickFix.UnderlyingMaturityTime  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingMaturityTime getUnderlyingMaturityTime()
    { QuickFix.UnderlyingMaturityTime value = new QuickFix.UnderlyingMaturityTime();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingMaturityTime field)
    { return isSetField(field); }
    public bool isSetUnderlyingMaturityTime()
    { return isSetField(1213); }

    public void set(QuickFix.UnderlyingCouponPaymentDate value)
    { setField(value); }
    public QuickFix.UnderlyingCouponPaymentDate get(QuickFix.UnderlyingCouponPaymentDate  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCouponPaymentDate getUnderlyingCouponPaymentDate()
    { QuickFix.UnderlyingCouponPaymentDate value = new QuickFix.UnderlyingCouponPaymentDate();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCouponPaymentDate field)
    { return isSetField(field); }
    public bool isSetUnderlyingCouponPaymentDate()
    { return isSetField(241); }

    public void set(QuickFix.UnderlyingIssueDate value)
    { setField(value); }
    public QuickFix.UnderlyingIssueDate get(QuickFix.UnderlyingIssueDate  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingIssueDate getUnderlyingIssueDate()
    { QuickFix.UnderlyingIssueDate value = new QuickFix.UnderlyingIssueDate();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingIssueDate field)
    { return isSetField(field); }
    public bool isSetUnderlyingIssueDate()
    { return isSetField(242); }

    public void set(QuickFix.UnderlyingRepoCollateralSecurityType value)
    { setField(value); }
    public QuickFix.UnderlyingRepoCollateralSecurityType get(QuickFix.UnderlyingRepoCollateralSecurityType  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingRepoCollateralSecurityType getUnderlyingRepoCollateralSecurityType()
    { QuickFix.UnderlyingRepoCollateralSecurityType value = new QuickFix.UnderlyingRepoCollateralSecurityType();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingRepoCollateralSecurityType field)
    { return isSetField(field); }
    public bool isSetUnderlyingRepoCollateralSecurityType()
    { return isSetField(243); }

    public void set(QuickFix.UnderlyingRepurchaseTerm value)
    { setField(value); }
    public QuickFix.UnderlyingRepurchaseTerm get(QuickFix.UnderlyingRepurchaseTerm  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingRepurchaseTerm getUnderlyingRepurchaseTerm()
    { QuickFix.UnderlyingRepurchaseTerm value = new QuickFix.UnderlyingRepurchaseTerm();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingRepurchaseTerm field)
    { return isSetField(field); }
    public bool isSetUnderlyingRepurchaseTerm()
    { return isSetField(244); }

    public void set(QuickFix.UnderlyingRepurchaseRate value)
    { setField(value); }
    public QuickFix.UnderlyingRepurchaseRate get(QuickFix.UnderlyingRepurchaseRate  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingRepurchaseRate getUnderlyingRepurchaseRate()
    { QuickFix.UnderlyingRepurchaseRate value = new QuickFix.UnderlyingRepurchaseRate();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingRepurchaseRate field)
    { return isSetField(field); }
    public bool isSetUnderlyingRepurchaseRate()
    { return isSetField(245); }

    public void set(QuickFix.UnderlyingFactor value)
    { setField(value); }
    public QuickFix.UnderlyingFactor get(QuickFix.UnderlyingFactor  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingFactor getUnderlyingFactor()
    { QuickFix.UnderlyingFactor value = new QuickFix.UnderlyingFactor();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingFactor field)
    { return isSetField(field); }
    public bool isSetUnderlyingFactor()
    { return isSetField(246); }

    public void set(QuickFix.UnderlyingCreditRating value)
    { setField(value); }
    public QuickFix.UnderlyingCreditRating get(QuickFix.UnderlyingCreditRating  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCreditRating getUnderlyingCreditRating()
    { QuickFix.UnderlyingCreditRating value = new QuickFix.UnderlyingCreditRating();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCreditRating field)
    { return isSetField(field); }
    public bool isSetUnderlyingCreditRating()
    { return isSetField(256); }

    public void set(QuickFix.UnderlyingInstrRegistry value)
    { setField(value); }
    public QuickFix.UnderlyingInstrRegistry get(QuickFix.UnderlyingInstrRegistry  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingInstrRegistry getUnderlyingInstrRegistry()
    { QuickFix.UnderlyingInstrRegistry value = new QuickFix.UnderlyingInstrRegistry();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingInstrRegistry field)
    { return isSetField(field); }
    public bool isSetUnderlyingInstrRegistry()
    { return isSetField(595); }

    public void set(QuickFix.UnderlyingCountryOfIssue value)
    { setField(value); }
    public QuickFix.UnderlyingCountryOfIssue get(QuickFix.UnderlyingCountryOfIssue  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCountryOfIssue getUnderlyingCountryOfIssue()
    { QuickFix.UnderlyingCountryOfIssue value = new QuickFix.UnderlyingCountryOfIssue();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCountryOfIssue field)
    { return isSetField(field); }
    public bool isSetUnderlyingCountryOfIssue()
    { return isSetField(592); }

    public void set(QuickFix.UnderlyingStateOrProvinceOfIssue value)
    { setField(value); }
    public QuickFix.UnderlyingStateOrProvinceOfIssue get(QuickFix.UnderlyingStateOrProvinceOfIssue  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingStateOrProvinceOfIssue getUnderlyingStateOrProvinceOfIssue()
    { QuickFix.UnderlyingStateOrProvinceOfIssue value = new QuickFix.UnderlyingStateOrProvinceOfIssue();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingStateOrProvinceOfIssue field)
    { return isSetField(field); }
    public bool isSetUnderlyingStateOrProvinceOfIssue()
    { return isSetField(593); }

    public void set(QuickFix.UnderlyingLocaleOfIssue value)
    { setField(value); }
    public QuickFix.UnderlyingLocaleOfIssue get(QuickFix.UnderlyingLocaleOfIssue  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingLocaleOfIssue getUnderlyingLocaleOfIssue()
    { QuickFix.UnderlyingLocaleOfIssue value = new QuickFix.UnderlyingLocaleOfIssue();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingLocaleOfIssue field)
    { return isSetField(field); }
    public bool isSetUnderlyingLocaleOfIssue()
    { return isSetField(594); }

    public void set(QuickFix.UnderlyingRedemptionDate value)
    { setField(value); }
    public QuickFix.UnderlyingRedemptionDate get(QuickFix.UnderlyingRedemptionDate  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingRedemptionDate getUnderlyingRedemptionDate()
    { QuickFix.UnderlyingRedemptionDate value = new QuickFix.UnderlyingRedemptionDate();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingRedemptionDate field)
    { return isSetField(field); }
    public bool isSetUnderlyingRedemptionDate()
    { return isSetField(247); }

    public void set(QuickFix.UnderlyingStrikePrice value)
    { setField(value); }
    public QuickFix.UnderlyingStrikePrice get(QuickFix.UnderlyingStrikePrice  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingStrikePrice getUnderlyingStrikePrice()
    { QuickFix.UnderlyingStrikePrice value = new QuickFix.UnderlyingStrikePrice();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingStrikePrice field)
    { return isSetField(field); }
    public bool isSetUnderlyingStrikePrice()
    { return isSetField(316); }

    public void set(QuickFix.UnderlyingStrikeCurrency value)
    { setField(value); }
    public QuickFix.UnderlyingStrikeCurrency get(QuickFix.UnderlyingStrikeCurrency  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingStrikeCurrency getUnderlyingStrikeCurrency()
    { QuickFix.UnderlyingStrikeCurrency value = new QuickFix.UnderlyingStrikeCurrency();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingStrikeCurrency field)
    { return isSetField(field); }
    public bool isSetUnderlyingStrikeCurrency()
    { return isSetField(941); }

    public void set(QuickFix.UnderlyingOptAttribute value)
    { setField(value); }
    public QuickFix.UnderlyingOptAttribute get(QuickFix.UnderlyingOptAttribute  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingOptAttribute getUnderlyingOptAttribute()
    { QuickFix.UnderlyingOptAttribute value = new QuickFix.UnderlyingOptAttribute();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingOptAttribute field)
    { return isSetField(field); }
    public bool isSetUnderlyingOptAttribute()
    { return isSetField(317); }

    public void set(QuickFix.UnderlyingContractMultiplier value)
    { setField(value); }
    public QuickFix.UnderlyingContractMultiplier get(QuickFix.UnderlyingContractMultiplier  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingContractMultiplier getUnderlyingContractMultiplier()
    { QuickFix.UnderlyingContractMultiplier value = new QuickFix.UnderlyingContractMultiplier();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingContractMultiplier field)
    { return isSetField(field); }
    public bool isSetUnderlyingContractMultiplier()
    { return isSetField(436); }

    public void set(QuickFix.UnderlyingUnitOfMeasure value)
    { setField(value); }
    public QuickFix.UnderlyingUnitOfMeasure get(QuickFix.UnderlyingUnitOfMeasure  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingUnitOfMeasure getUnderlyingUnitOfMeasure()
    { QuickFix.UnderlyingUnitOfMeasure value = new QuickFix.UnderlyingUnitOfMeasure();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingUnitOfMeasure field)
    { return isSetField(field); }
    public bool isSetUnderlyingUnitOfMeasure()
    { return isSetField(998); }

    public void set(QuickFix.UnderlyingUnitOfMeasureQty value)
    { setField(value); }
    public QuickFix.UnderlyingUnitOfMeasureQty get(QuickFix.UnderlyingUnitOfMeasureQty  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingUnitOfMeasureQty getUnderlyingUnitOfMeasureQty()
    { QuickFix.UnderlyingUnitOfMeasureQty value = new QuickFix.UnderlyingUnitOfMeasureQty();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingUnitOfMeasureQty field)
    { return isSetField(field); }
    public bool isSetUnderlyingUnitOfMeasureQty()
    { return isSetField(1423); }

    public void set(QuickFix.UnderlyingPriceUnitOfMeasure value)
    { setField(value); }
    public QuickFix.UnderlyingPriceUnitOfMeasure get(QuickFix.UnderlyingPriceUnitOfMeasure  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingPriceUnitOfMeasure getUnderlyingPriceUnitOfMeasure()
    { QuickFix.UnderlyingPriceUnitOfMeasure value = new QuickFix.UnderlyingPriceUnitOfMeasure();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingPriceUnitOfMeasure field)
    { return isSetField(field); }
    public bool isSetUnderlyingPriceUnitOfMeasure()
    { return isSetField(1424); }

    public void set(QuickFix.UnderlyingPriceUnitOfMeasureQty value)
    { setField(value); }
    public QuickFix.UnderlyingPriceUnitOfMeasureQty get(QuickFix.UnderlyingPriceUnitOfMeasureQty  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingPriceUnitOfMeasureQty getUnderlyingPriceUnitOfMeasureQty()
    { QuickFix.UnderlyingPriceUnitOfMeasureQty value = new QuickFix.UnderlyingPriceUnitOfMeasureQty();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingPriceUnitOfMeasureQty field)
    { return isSetField(field); }
    public bool isSetUnderlyingPriceUnitOfMeasureQty()
    { return isSetField(1425); }

    public void set(QuickFix.UnderlyingTimeUnit value)
    { setField(value); }
    public QuickFix.UnderlyingTimeUnit get(QuickFix.UnderlyingTimeUnit  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingTimeUnit getUnderlyingTimeUnit()
    { QuickFix.UnderlyingTimeUnit value = new QuickFix.UnderlyingTimeUnit();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingTimeUnit field)
    { return isSetField(field); }
    public bool isSetUnderlyingTimeUnit()
    { return isSetField(1000); }

    public void set(QuickFix.UnderlyingExerciseStyle value)
    { setField(value); }
    public QuickFix.UnderlyingExerciseStyle get(QuickFix.UnderlyingExerciseStyle  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingExerciseStyle getUnderlyingExerciseStyle()
    { QuickFix.UnderlyingExerciseStyle value = new QuickFix.UnderlyingExerciseStyle();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingExerciseStyle field)
    { return isSetField(field); }
    public bool isSetUnderlyingExerciseStyle()
    { return isSetField(1419); }

    public void set(QuickFix.UnderlyingCouponRate value)
    { setField(value); }
    public QuickFix.UnderlyingCouponRate get(QuickFix.UnderlyingCouponRate  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCouponRate getUnderlyingCouponRate()
    { QuickFix.UnderlyingCouponRate value = new QuickFix.UnderlyingCouponRate();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCouponRate field)
    { return isSetField(field); }
    public bool isSetUnderlyingCouponRate()
    { return isSetField(435); }

    public void set(QuickFix.UnderlyingSecurityExchange value)
    { setField(value); }
    public QuickFix.UnderlyingSecurityExchange get(QuickFix.UnderlyingSecurityExchange  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSecurityExchange getUnderlyingSecurityExchange()
    { QuickFix.UnderlyingSecurityExchange value = new QuickFix.UnderlyingSecurityExchange();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSecurityExchange field)
    { return isSetField(field); }
    public bool isSetUnderlyingSecurityExchange()
    { return isSetField(308); }

    public void set(QuickFix.UnderlyingIssuer value)
    { setField(value); }
    public QuickFix.UnderlyingIssuer get(QuickFix.UnderlyingIssuer  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingIssuer getUnderlyingIssuer()
    { QuickFix.UnderlyingIssuer value = new QuickFix.UnderlyingIssuer();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingIssuer field)
    { return isSetField(field); }
    public bool isSetUnderlyingIssuer()
    { return isSetField(306); }

    public void set(QuickFix.EncodedUnderlyingIssuerLen value)
    { setField(value); }
    public QuickFix.EncodedUnderlyingIssuerLen get(QuickFix.EncodedUnderlyingIssuerLen  value)
    { getField(value); return value; }
    public QuickFix.EncodedUnderlyingIssuerLen getEncodedUnderlyingIssuerLen()
    { QuickFix.EncodedUnderlyingIssuerLen value = new QuickFix.EncodedUnderlyingIssuerLen();
      getField(value); return value; }
    public bool isSet(QuickFix.EncodedUnderlyingIssuerLen field)
    { return isSetField(field); }
    public bool isSetEncodedUnderlyingIssuerLen()
    { return isSetField(362); }

    public void set(QuickFix.EncodedUnderlyingIssuer value)
    { setField(value); }
    public QuickFix.EncodedUnderlyingIssuer get(QuickFix.EncodedUnderlyingIssuer  value)
    { getField(value); return value; }
    public QuickFix.EncodedUnderlyingIssuer getEncodedUnderlyingIssuer()
    { QuickFix.EncodedUnderlyingIssuer value = new QuickFix.EncodedUnderlyingIssuer();
      getField(value); return value; }
    public bool isSet(QuickFix.EncodedUnderlyingIssuer field)
    { return isSetField(field); }
    public bool isSetEncodedUnderlyingIssuer()
    { return isSetField(363); }

    public void set(QuickFix.UnderlyingSecurityDesc value)
    { setField(value); }
    public QuickFix.UnderlyingSecurityDesc get(QuickFix.UnderlyingSecurityDesc  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSecurityDesc getUnderlyingSecurityDesc()
    { QuickFix.UnderlyingSecurityDesc value = new QuickFix.UnderlyingSecurityDesc();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSecurityDesc field)
    { return isSetField(field); }
    public bool isSetUnderlyingSecurityDesc()
    { return isSetField(307); }

    public void set(QuickFix.EncodedUnderlyingSecurityDescLen value)
    { setField(value); }
    public QuickFix.EncodedUnderlyingSecurityDescLen get(QuickFix.EncodedUnderlyingSecurityDescLen  value)
    { getField(value); return value; }
    public QuickFix.EncodedUnderlyingSecurityDescLen getEncodedUnderlyingSecurityDescLen()
    { QuickFix.EncodedUnderlyingSecurityDescLen value = new QuickFix.EncodedUnderlyingSecurityDescLen();
      getField(value); return value; }
    public bool isSet(QuickFix.EncodedUnderlyingSecurityDescLen field)
    { return isSetField(field); }
    public bool isSetEncodedUnderlyingSecurityDescLen()
    { return isSetField(364); }

    public void set(QuickFix.EncodedUnderlyingSecurityDesc value)
    { setField(value); }
    public QuickFix.EncodedUnderlyingSecurityDesc get(QuickFix.EncodedUnderlyingSecurityDesc  value)
    { getField(value); return value; }
    public QuickFix.EncodedUnderlyingSecurityDesc getEncodedUnderlyingSecurityDesc()
    { QuickFix.EncodedUnderlyingSecurityDesc value = new QuickFix.EncodedUnderlyingSecurityDesc();
      getField(value); return value; }
    public bool isSet(QuickFix.EncodedUnderlyingSecurityDesc field)
    { return isSetField(field); }
    public bool isSetEncodedUnderlyingSecurityDesc()
    { return isSetField(365); }

    public void set(QuickFix.UnderlyingCPProgram value)
    { setField(value); }
    public QuickFix.UnderlyingCPProgram get(QuickFix.UnderlyingCPProgram  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCPProgram getUnderlyingCPProgram()
    { QuickFix.UnderlyingCPProgram value = new QuickFix.UnderlyingCPProgram();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCPProgram field)
    { return isSetField(field); }
    public bool isSetUnderlyingCPProgram()
    { return isSetField(877); }

    public void set(QuickFix.UnderlyingCPRegType value)
    { setField(value); }
    public QuickFix.UnderlyingCPRegType get(QuickFix.UnderlyingCPRegType  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCPRegType getUnderlyingCPRegType()
    { QuickFix.UnderlyingCPRegType value = new QuickFix.UnderlyingCPRegType();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCPRegType field)
    { return isSetField(field); }
    public bool isSetUnderlyingCPRegType()
    { return isSetField(878); }

    public void set(QuickFix.UnderlyingAllocationPercent value)
    { setField(value); }
    public QuickFix.UnderlyingAllocationPercent get(QuickFix.UnderlyingAllocationPercent  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingAllocationPercent getUnderlyingAllocationPercent()
    { QuickFix.UnderlyingAllocationPercent value = new QuickFix.UnderlyingAllocationPercent();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingAllocationPercent field)
    { return isSetField(field); }
    public bool isSetUnderlyingAllocationPercent()
    { return isSetField(972); }

    public void set(QuickFix.UnderlyingCurrency value)
    { setField(value); }
    public QuickFix.UnderlyingCurrency get(QuickFix.UnderlyingCurrency  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCurrency getUnderlyingCurrency()
    { QuickFix.UnderlyingCurrency value = new QuickFix.UnderlyingCurrency();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCurrency field)
    { return isSetField(field); }
    public bool isSetUnderlyingCurrency()
    { return isSetField(318); }

    public void set(QuickFix.UnderlyingQty value)
    { setField(value); }
    public QuickFix.UnderlyingQty get(QuickFix.UnderlyingQty  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingQty getUnderlyingQty()
    { QuickFix.UnderlyingQty value = new QuickFix.UnderlyingQty();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingQty field)
    { return isSetField(field); }
    public bool isSetUnderlyingQty()
    { return isSetField(879); }

    public void set(QuickFix.UnderlyingSettlementType value)
    { setField(value); }
    public QuickFix.UnderlyingSettlementType get(QuickFix.UnderlyingSettlementType  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSettlementType getUnderlyingSettlementType()
    { QuickFix.UnderlyingSettlementType value = new QuickFix.UnderlyingSettlementType();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSettlementType field)
    { return isSetField(field); }
    public bool isSetUnderlyingSettlementType()
    { return isSetField(975); }

    public void set(QuickFix.UnderlyingCashAmount value)
    { setField(value); }
    public QuickFix.UnderlyingCashAmount get(QuickFix.UnderlyingCashAmount  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCashAmount getUnderlyingCashAmount()
    { QuickFix.UnderlyingCashAmount value = new QuickFix.UnderlyingCashAmount();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCashAmount field)
    { return isSetField(field); }
    public bool isSetUnderlyingCashAmount()
    { return isSetField(973); }

    public void set(QuickFix.UnderlyingCashType value)
    { setField(value); }
    public QuickFix.UnderlyingCashType get(QuickFix.UnderlyingCashType  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCashType getUnderlyingCashType()
    { QuickFix.UnderlyingCashType value = new QuickFix.UnderlyingCashType();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCashType field)
    { return isSetField(field); }
    public bool isSetUnderlyingCashType()
    { return isSetField(974); }

    public void set(QuickFix.UnderlyingPx value)
    { setField(value); }
    public QuickFix.UnderlyingPx get(QuickFix.UnderlyingPx  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingPx getUnderlyingPx()
    { QuickFix.UnderlyingPx value = new QuickFix.UnderlyingPx();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingPx field)
    { return isSetField(field); }
    public bool isSetUnderlyingPx()
    { return isSetField(810); }

    public void set(QuickFix.UnderlyingDirtyPrice value)
    { setField(value); }
    public QuickFix.UnderlyingDirtyPrice get(QuickFix.UnderlyingDirtyPrice  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingDirtyPrice getUnderlyingDirtyPrice()
    { QuickFix.UnderlyingDirtyPrice value = new QuickFix.UnderlyingDirtyPrice();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingDirtyPrice field)
    { return isSetField(field); }
    public bool isSetUnderlyingDirtyPrice()
    { return isSetField(882); }

    public void set(QuickFix.UnderlyingEndPrice value)
    { setField(value); }
    public QuickFix.UnderlyingEndPrice get(QuickFix.UnderlyingEndPrice  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingEndPrice getUnderlyingEndPrice()
    { QuickFix.UnderlyingEndPrice value = new QuickFix.UnderlyingEndPrice();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingEndPrice field)
    { return isSetField(field); }
    public bool isSetUnderlyingEndPrice()
    { return isSetField(883); }

    public void set(QuickFix.UnderlyingStartValue value)
    { setField(value); }
    public QuickFix.UnderlyingStartValue get(QuickFix.UnderlyingStartValue  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingStartValue getUnderlyingStartValue()
    { QuickFix.UnderlyingStartValue value = new QuickFix.UnderlyingStartValue();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingStartValue field)
    { return isSetField(field); }
    public bool isSetUnderlyingStartValue()
    { return isSetField(884); }

    public void set(QuickFix.UnderlyingCurrentValue value)
    { setField(value); }
    public QuickFix.UnderlyingCurrentValue get(QuickFix.UnderlyingCurrentValue  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCurrentValue getUnderlyingCurrentValue()
    { QuickFix.UnderlyingCurrentValue value = new QuickFix.UnderlyingCurrentValue();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCurrentValue field)
    { return isSetField(field); }
    public bool isSetUnderlyingCurrentValue()
    { return isSetField(885); }

    public void set(QuickFix.UnderlyingEndValue value)
    { setField(value); }
    public QuickFix.UnderlyingEndValue get(QuickFix.UnderlyingEndValue  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingEndValue getUnderlyingEndValue()
    { QuickFix.UnderlyingEndValue value = new QuickFix.UnderlyingEndValue();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingEndValue field)
    { return isSetField(field); }
    public bool isSetUnderlyingEndValue()
    { return isSetField(886); }

    public void set(QuickFix.UnderlyingAdjustedQuantity value)
    { setField(value); }
    public QuickFix.UnderlyingAdjustedQuantity get(QuickFix.UnderlyingAdjustedQuantity  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingAdjustedQuantity getUnderlyingAdjustedQuantity()
    { QuickFix.UnderlyingAdjustedQuantity value = new QuickFix.UnderlyingAdjustedQuantity();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingAdjustedQuantity field)
    { return isSetField(field); }
    public bool isSetUnderlyingAdjustedQuantity()
    { return isSetField(1044); }

    public void set(QuickFix.UnderlyingFXRate value)
    { setField(value); }
    public QuickFix.UnderlyingFXRate get(QuickFix.UnderlyingFXRate  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingFXRate getUnderlyingFXRate()
    { QuickFix.UnderlyingFXRate value = new QuickFix.UnderlyingFXRate();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingFXRate field)
    { return isSetField(field); }
    public bool isSetUnderlyingFXRate()
    { return isSetField(1045); }

    public void set(QuickFix.UnderlyingFXRateCalc value)
    { setField(value); }
    public QuickFix.UnderlyingFXRateCalc get(QuickFix.UnderlyingFXRateCalc  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingFXRateCalc getUnderlyingFXRateCalc()
    { QuickFix.UnderlyingFXRateCalc value = new QuickFix.UnderlyingFXRateCalc();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingFXRateCalc field)
    { return isSetField(field); }
    public bool isSetUnderlyingFXRateCalc()
    { return isSetField(1046); }

    public void set(QuickFix.UnderlyingCapValue value)
    { setField(value); }
    public QuickFix.UnderlyingCapValue get(QuickFix.UnderlyingCapValue  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingCapValue getUnderlyingCapValue()
    { QuickFix.UnderlyingCapValue value = new QuickFix.UnderlyingCapValue();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingCapValue field)
    { return isSetField(field); }
    public bool isSetUnderlyingCapValue()
    { return isSetField(1038); }

    public void set(QuickFix.UnderlyingSettlMethod value)
    { setField(value); }
    public QuickFix.UnderlyingSettlMethod get(QuickFix.UnderlyingSettlMethod  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSettlMethod getUnderlyingSettlMethod()
    { QuickFix.UnderlyingSettlMethod value = new QuickFix.UnderlyingSettlMethod();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSettlMethod field)
    { return isSetField(field); }
    public bool isSetUnderlyingSettlMethod()
    { return isSetField(1039); }

    public void set(QuickFix.UnderlyingPutOrCall value)
    { setField(value); }
    public QuickFix.UnderlyingPutOrCall get(QuickFix.UnderlyingPutOrCall  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingPutOrCall getUnderlyingPutOrCall()
    { QuickFix.UnderlyingPutOrCall value = new QuickFix.UnderlyingPutOrCall();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingPutOrCall field)
    { return isSetField(field); }
    public bool isSetUnderlyingPutOrCall()
    { return isSetField(315); }

    public void set(QuickFix.UnderlyingContractMultiplierUnit value)
    { setField(value); }
    public QuickFix.UnderlyingContractMultiplierUnit get(QuickFix.UnderlyingContractMultiplierUnit  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingContractMultiplierUnit getUnderlyingContractMultiplierUnit()
    { QuickFix.UnderlyingContractMultiplierUnit value = new QuickFix.UnderlyingContractMultiplierUnit();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingContractMultiplierUnit field)
    { return isSetField(field); }
    public bool isSetUnderlyingContractMultiplierUnit()
    { return isSetField(1437); }

    public void set(QuickFix.UnderlyingFlowScheduleType value)
    { setField(value); }
    public QuickFix.UnderlyingFlowScheduleType get(QuickFix.UnderlyingFlowScheduleType  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingFlowScheduleType getUnderlyingFlowScheduleType()
    { QuickFix.UnderlyingFlowScheduleType value = new QuickFix.UnderlyingFlowScheduleType();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingFlowScheduleType field)
    { return isSetField(field); }
    public bool isSetUnderlyingFlowScheduleType()
    { return isSetField(1441); }

    public void set(QuickFix.UnderlyingRestructuringType value)
    { setField(value); }
    public QuickFix.UnderlyingRestructuringType get(QuickFix.UnderlyingRestructuringType  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingRestructuringType getUnderlyingRestructuringType()
    { QuickFix.UnderlyingRestructuringType value = new QuickFix.UnderlyingRestructuringType();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingRestructuringType field)
    { return isSetField(field); }
    public bool isSetUnderlyingRestructuringType()
    { return isSetField(1453); }

    public void set(QuickFix.UnderlyingSeniority value)
    { setField(value); }
    public QuickFix.UnderlyingSeniority get(QuickFix.UnderlyingSeniority  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingSeniority getUnderlyingSeniority()
    { QuickFix.UnderlyingSeniority value = new QuickFix.UnderlyingSeniority();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingSeniority field)
    { return isSetField(field); }
    public bool isSetUnderlyingSeniority()
    { return isSetField(1454); }

    public void set(QuickFix.UnderlyingNotionalPercentageOutstanding value)
    { setField(value); }
    public QuickFix.UnderlyingNotionalPercentageOutstanding get(QuickFix.UnderlyingNotionalPercentageOutstanding  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingNotionalPercentageOutstanding getUnderlyingNotionalPercentageOutstanding()
    { QuickFix.UnderlyingNotionalPercentageOutstanding value = new QuickFix.UnderlyingNotionalPercentageOutstanding();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingNotionalPercentageOutstanding field)
    { return isSetField(field); }
    public bool isSetUnderlyingNotionalPercentageOutstanding()
    { return isSetField(1455); }

    public void set(QuickFix.UnderlyingOriginalNotionalPercentageOutstanding value)
    { setField(value); }
    public QuickFix.UnderlyingOriginalNotionalPercentageOutstanding get(QuickFix.UnderlyingOriginalNotionalPercentageOutstanding  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingOriginalNotionalPercentageOutstanding getUnderlyingOriginalNotionalPercentageOutstanding()
    { QuickFix.UnderlyingOriginalNotionalPercentageOutstanding value = new QuickFix.UnderlyingOriginalNotionalPercentageOutstanding();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingOriginalNotionalPercentageOutstanding field)
    { return isSetField(field); }
    public bool isSetUnderlyingOriginalNotionalPercentageOutstanding()
    { return isSetField(1456); }

    public void set(QuickFix.UnderlyingAttachmentPoint value)
    { setField(value); }
    public QuickFix.UnderlyingAttachmentPoint get(QuickFix.UnderlyingAttachmentPoint  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingAttachmentPoint getUnderlyingAttachmentPoint()
    { QuickFix.UnderlyingAttachmentPoint value = new QuickFix.UnderlyingAttachmentPoint();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingAttachmentPoint field)
    { return isSetField(field); }
    public bool isSetUnderlyingAttachmentPoint()
    { return isSetField(1459); }

    public void set(QuickFix.UnderlyingDetachmentPoint value)
    { setField(value); }
    public QuickFix.UnderlyingDetachmentPoint get(QuickFix.UnderlyingDetachmentPoint  value)
    { getField(value); return value; }
    public QuickFix.UnderlyingDetachmentPoint getUnderlyingDetachmentPoint()
    { QuickFix.UnderlyingDetachmentPoint value = new QuickFix.UnderlyingDetachmentPoint();
      getField(value); return value; }
    public bool isSet(QuickFix.UnderlyingDetachmentPoint field)
    { return isSetField(field); }
    public bool isSetUnderlyingDetachmentPoint()
    { return isSetField(1460); }

    public void set(QuickFix.DerivativeSymbol value)
    { setField(value); }
    public QuickFix.DerivativeSymbol get(QuickFix.DerivativeSymbol  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSymbol getDerivativeSymbol()
    { QuickFix.DerivativeSymbol value = new QuickFix.DerivativeSymbol();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSymbol field)
    { return isSetField(field); }
    public bool isSetDerivativeSymbol()
    { return isSetField(1214); }

    public void set(QuickFix.DerivativeSymbolSfx value)
    { setField(value); }
    public QuickFix.DerivativeSymbolSfx get(QuickFix.DerivativeSymbolSfx  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSymbolSfx getDerivativeSymbolSfx()
    { QuickFix.DerivativeSymbolSfx value = new QuickFix.DerivativeSymbolSfx();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSymbolSfx field)
    { return isSetField(field); }
    public bool isSetDerivativeSymbolSfx()
    { return isSetField(1215); }

    public void set(QuickFix.DerivativeSecurityID value)
    { setField(value); }
    public QuickFix.DerivativeSecurityID get(QuickFix.DerivativeSecurityID  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSecurityID getDerivativeSecurityID()
    { QuickFix.DerivativeSecurityID value = new QuickFix.DerivativeSecurityID();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSecurityID field)
    { return isSetField(field); }
    public bool isSetDerivativeSecurityID()
    { return isSetField(1216); }

    public void set(QuickFix.DerivativeSecurityIDSource value)
    { setField(value); }
    public QuickFix.DerivativeSecurityIDSource get(QuickFix.DerivativeSecurityIDSource  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSecurityIDSource getDerivativeSecurityIDSource()
    { QuickFix.DerivativeSecurityIDSource value = new QuickFix.DerivativeSecurityIDSource();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSecurityIDSource field)
    { return isSetField(field); }
    public bool isSetDerivativeSecurityIDSource()
    { return isSetField(1217); }

    public void set(QuickFix.DerivativeProduct value)
    { setField(value); }
    public QuickFix.DerivativeProduct get(QuickFix.DerivativeProduct  value)
    { getField(value); return value; }
    public QuickFix.DerivativeProduct getDerivativeProduct()
    { QuickFix.DerivativeProduct value = new QuickFix.DerivativeProduct();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeProduct field)
    { return isSetField(field); }
    public bool isSetDerivativeProduct()
    { return isSetField(1246); }

    public void set(QuickFix.DerivativeProductComplex value)
    { setField(value); }
    public QuickFix.DerivativeProductComplex get(QuickFix.DerivativeProductComplex  value)
    { getField(value); return value; }
    public QuickFix.DerivativeProductComplex getDerivativeProductComplex()
    { QuickFix.DerivativeProductComplex value = new QuickFix.DerivativeProductComplex();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeProductComplex field)
    { return isSetField(field); }
    public bool isSetDerivativeProductComplex()
    { return isSetField(1228); }

    public void set(QuickFix.DerivFlexProductEligibilityIndicator value)
    { setField(value); }
    public QuickFix.DerivFlexProductEligibilityIndicator get(QuickFix.DerivFlexProductEligibilityIndicator  value)
    { getField(value); return value; }
    public QuickFix.DerivFlexProductEligibilityIndicator getDerivFlexProductEligibilityIndicator()
    { QuickFix.DerivFlexProductEligibilityIndicator value = new QuickFix.DerivFlexProductEligibilityIndicator();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivFlexProductEligibilityIndicator field)
    { return isSetField(field); }
    public bool isSetDerivFlexProductEligibilityIndicator()
    { return isSetField(1243); }

    public void set(QuickFix.DerivativeSecurityGroup value)
    { setField(value); }
    public QuickFix.DerivativeSecurityGroup get(QuickFix.DerivativeSecurityGroup  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSecurityGroup getDerivativeSecurityGroup()
    { QuickFix.DerivativeSecurityGroup value = new QuickFix.DerivativeSecurityGroup();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSecurityGroup field)
    { return isSetField(field); }
    public bool isSetDerivativeSecurityGroup()
    { return isSetField(1247); }

    public void set(QuickFix.DerivativeCFICode value)
    { setField(value); }
    public QuickFix.DerivativeCFICode get(QuickFix.DerivativeCFICode  value)
    { getField(value); return value; }
    public QuickFix.DerivativeCFICode getDerivativeCFICode()
    { QuickFix.DerivativeCFICode value = new QuickFix.DerivativeCFICode();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeCFICode field)
    { return isSetField(field); }
    public bool isSetDerivativeCFICode()
    { return isSetField(1248); }

    public void set(QuickFix.DerivativeSecurityType value)
    { setField(value); }
    public QuickFix.DerivativeSecurityType get(QuickFix.DerivativeSecurityType  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSecurityType getDerivativeSecurityType()
    { QuickFix.DerivativeSecurityType value = new QuickFix.DerivativeSecurityType();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSecurityType field)
    { return isSetField(field); }
    public bool isSetDerivativeSecurityType()
    { return isSetField(1249); }

    public void set(QuickFix.DerivativeSecuritySubType value)
    { setField(value); }
    public QuickFix.DerivativeSecuritySubType get(QuickFix.DerivativeSecuritySubType  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSecuritySubType getDerivativeSecuritySubType()
    { QuickFix.DerivativeSecuritySubType value = new QuickFix.DerivativeSecuritySubType();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSecuritySubType field)
    { return isSetField(field); }
    public bool isSetDerivativeSecuritySubType()
    { return isSetField(1250); }

    public void set(QuickFix.DerivativeMaturityMonthYear value)
    { setField(value); }
    public QuickFix.DerivativeMaturityMonthYear get(QuickFix.DerivativeMaturityMonthYear  value)
    { getField(value); return value; }
    public QuickFix.DerivativeMaturityMonthYear getDerivativeMaturityMonthYear()
    { QuickFix.DerivativeMaturityMonthYear value = new QuickFix.DerivativeMaturityMonthYear();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeMaturityMonthYear field)
    { return isSetField(field); }
    public bool isSetDerivativeMaturityMonthYear()
    { return isSetField(1251); }

    public void set(QuickFix.DerivativeMaturityDate value)
    { setField(value); }
    public QuickFix.DerivativeMaturityDate get(QuickFix.DerivativeMaturityDate  value)
    { getField(value); return value; }
    public QuickFix.DerivativeMaturityDate getDerivativeMaturityDate()
    { QuickFix.DerivativeMaturityDate value = new QuickFix.DerivativeMaturityDate();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeMaturityDate field)
    { return isSetField(field); }
    public bool isSetDerivativeMaturityDate()
    { return isSetField(1252); }

    public void set(QuickFix.DerivativeMaturityTime value)
    { setField(value); }
    public QuickFix.DerivativeMaturityTime get(QuickFix.DerivativeMaturityTime  value)
    { getField(value); return value; }
    public QuickFix.DerivativeMaturityTime getDerivativeMaturityTime()
    { QuickFix.DerivativeMaturityTime value = new QuickFix.DerivativeMaturityTime();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeMaturityTime field)
    { return isSetField(field); }
    public bool isSetDerivativeMaturityTime()
    { return isSetField(1253); }

    public void set(QuickFix.DerivativeSettleOnOpenFlag value)
    { setField(value); }
    public QuickFix.DerivativeSettleOnOpenFlag get(QuickFix.DerivativeSettleOnOpenFlag  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSettleOnOpenFlag getDerivativeSettleOnOpenFlag()
    { QuickFix.DerivativeSettleOnOpenFlag value = new QuickFix.DerivativeSettleOnOpenFlag();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSettleOnOpenFlag field)
    { return isSetField(field); }
    public bool isSetDerivativeSettleOnOpenFlag()
    { return isSetField(1254); }

    public void set(QuickFix.DerivativeInstrmtAssignmentMethod value)
    { setField(value); }
    public QuickFix.DerivativeInstrmtAssignmentMethod get(QuickFix.DerivativeInstrmtAssignmentMethod  value)
    { getField(value); return value; }
    public QuickFix.DerivativeInstrmtAssignmentMethod getDerivativeInstrmtAssignmentMethod()
    { QuickFix.DerivativeInstrmtAssignmentMethod value = new QuickFix.DerivativeInstrmtAssignmentMethod();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeInstrmtAssignmentMethod field)
    { return isSetField(field); }
    public bool isSetDerivativeInstrmtAssignmentMethod()
    { return isSetField(1255); }

    public void set(QuickFix.DerivativeSecurityStatus value)
    { setField(value); }
    public QuickFix.DerivativeSecurityStatus get(QuickFix.DerivativeSecurityStatus  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSecurityStatus getDerivativeSecurityStatus()
    { QuickFix.DerivativeSecurityStatus value = new QuickFix.DerivativeSecurityStatus();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSecurityStatus field)
    { return isSetField(field); }
    public bool isSetDerivativeSecurityStatus()
    { return isSetField(1256); }

    public void set(QuickFix.DerivativeIssueDate value)
    { setField(value); }
    public QuickFix.DerivativeIssueDate get(QuickFix.DerivativeIssueDate  value)
    { getField(value); return value; }
    public QuickFix.DerivativeIssueDate getDerivativeIssueDate()
    { QuickFix.DerivativeIssueDate value = new QuickFix.DerivativeIssueDate();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeIssueDate field)
    { return isSetField(field); }
    public bool isSetDerivativeIssueDate()
    { return isSetField(1276); }

    public void set(QuickFix.DerivativeInstrRegistry value)
    { setField(value); }
    public QuickFix.DerivativeInstrRegistry get(QuickFix.DerivativeInstrRegistry  value)
    { getField(value); return value; }
    public QuickFix.DerivativeInstrRegistry getDerivativeInstrRegistry()
    { QuickFix.DerivativeInstrRegistry value = new QuickFix.DerivativeInstrRegistry();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeInstrRegistry field)
    { return isSetField(field); }
    public bool isSetDerivativeInstrRegistry()
    { return isSetField(1257); }

    public void set(QuickFix.DerivativeCountryOfIssue value)
    { setField(value); }
    public QuickFix.DerivativeCountryOfIssue get(QuickFix.DerivativeCountryOfIssue  value)
    { getField(value); return value; }
    public QuickFix.DerivativeCountryOfIssue getDerivativeCountryOfIssue()
    { QuickFix.DerivativeCountryOfIssue value = new QuickFix.DerivativeCountryOfIssue();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeCountryOfIssue field)
    { return isSetField(field); }
    public bool isSetDerivativeCountryOfIssue()
    { return isSetField(1258); }

    public void set(QuickFix.DerivativeStateOrProvinceOfIssue value)
    { setField(value); }
    public QuickFix.DerivativeStateOrProvinceOfIssue get(QuickFix.DerivativeStateOrProvinceOfIssue  value)
    { getField(value); return value; }
    public QuickFix.DerivativeStateOrProvinceOfIssue getDerivativeStateOrProvinceOfIssue()
    { QuickFix.DerivativeStateOrProvinceOfIssue value = new QuickFix.DerivativeStateOrProvinceOfIssue();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeStateOrProvinceOfIssue field)
    { return isSetField(field); }
    public bool isSetDerivativeStateOrProvinceOfIssue()
    { return isSetField(1259); }

    public void set(QuickFix.DerivativeLocaleOfIssue value)
    { setField(value); }
    public QuickFix.DerivativeLocaleOfIssue get(QuickFix.DerivativeLocaleOfIssue  value)
    { getField(value); return value; }
    public QuickFix.DerivativeLocaleOfIssue getDerivativeLocaleOfIssue()
    { QuickFix.DerivativeLocaleOfIssue value = new QuickFix.DerivativeLocaleOfIssue();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeLocaleOfIssue field)
    { return isSetField(field); }
    public bool isSetDerivativeLocaleOfIssue()
    { return isSetField(1260); }

    public void set(QuickFix.DerivativeStrikePrice value)
    { setField(value); }
    public QuickFix.DerivativeStrikePrice get(QuickFix.DerivativeStrikePrice  value)
    { getField(value); return value; }
    public QuickFix.DerivativeStrikePrice getDerivativeStrikePrice()
    { QuickFix.DerivativeStrikePrice value = new QuickFix.DerivativeStrikePrice();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeStrikePrice field)
    { return isSetField(field); }
    public bool isSetDerivativeStrikePrice()
    { return isSetField(1261); }

    public void set(QuickFix.DerivativeStrikeCurrency value)
    { setField(value); }
    public QuickFix.DerivativeStrikeCurrency get(QuickFix.DerivativeStrikeCurrency  value)
    { getField(value); return value; }
    public QuickFix.DerivativeStrikeCurrency getDerivativeStrikeCurrency()
    { QuickFix.DerivativeStrikeCurrency value = new QuickFix.DerivativeStrikeCurrency();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeStrikeCurrency field)
    { return isSetField(field); }
    public bool isSetDerivativeStrikeCurrency()
    { return isSetField(1262); }

    public void set(QuickFix.DerivativeStrikeMultiplier value)
    { setField(value); }
    public QuickFix.DerivativeStrikeMultiplier get(QuickFix.DerivativeStrikeMultiplier  value)
    { getField(value); return value; }
    public QuickFix.DerivativeStrikeMultiplier getDerivativeStrikeMultiplier()
    { QuickFix.DerivativeStrikeMultiplier value = new QuickFix.DerivativeStrikeMultiplier();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeStrikeMultiplier field)
    { return isSetField(field); }
    public bool isSetDerivativeStrikeMultiplier()
    { return isSetField(1263); }

    public void set(QuickFix.DerivativeStrikeValue value)
    { setField(value); }
    public QuickFix.DerivativeStrikeValue get(QuickFix.DerivativeStrikeValue  value)
    { getField(value); return value; }
    public QuickFix.DerivativeStrikeValue getDerivativeStrikeValue()
    { QuickFix.DerivativeStrikeValue value = new QuickFix.DerivativeStrikeValue();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeStrikeValue field)
    { return isSetField(field); }
    public bool isSetDerivativeStrikeValue()
    { return isSetField(1264); }

    public void set(QuickFix.DerivativeOptAttribute value)
    { setField(value); }
    public QuickFix.DerivativeOptAttribute get(QuickFix.DerivativeOptAttribute  value)
    { getField(value); return value; }
    public QuickFix.DerivativeOptAttribute getDerivativeOptAttribute()
    { QuickFix.DerivativeOptAttribute value = new QuickFix.DerivativeOptAttribute();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeOptAttribute field)
    { return isSetField(field); }
    public bool isSetDerivativeOptAttribute()
    { return isSetField(1265); }

    public void set(QuickFix.DerivativeContractMultiplier value)
    { setField(value); }
    public QuickFix.DerivativeContractMultiplier get(QuickFix.DerivativeContractMultiplier  value)
    { getField(value); return value; }
    public QuickFix.DerivativeContractMultiplier getDerivativeContractMultiplier()
    { QuickFix.DerivativeContractMultiplier value = new QuickFix.DerivativeContractMultiplier();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeContractMultiplier field)
    { return isSetField(field); }
    public bool isSetDerivativeContractMultiplier()
    { return isSetField(1266); }

    public void set(QuickFix.DerivativeMinPriceIncrement value)
    { setField(value); }
    public QuickFix.DerivativeMinPriceIncrement get(QuickFix.DerivativeMinPriceIncrement  value)
    { getField(value); return value; }
    public QuickFix.DerivativeMinPriceIncrement getDerivativeMinPriceIncrement()
    { QuickFix.DerivativeMinPriceIncrement value = new QuickFix.DerivativeMinPriceIncrement();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeMinPriceIncrement field)
    { return isSetField(field); }
    public bool isSetDerivativeMinPriceIncrement()
    { return isSetField(1267); }

    public void set(QuickFix.DerivativeMinPriceIncrementAmount value)
    { setField(value); }
    public QuickFix.DerivativeMinPriceIncrementAmount get(QuickFix.DerivativeMinPriceIncrementAmount  value)
    { getField(value); return value; }
    public QuickFix.DerivativeMinPriceIncrementAmount getDerivativeMinPriceIncrementAmount()
    { QuickFix.DerivativeMinPriceIncrementAmount value = new QuickFix.DerivativeMinPriceIncrementAmount();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeMinPriceIncrementAmount field)
    { return isSetField(field); }
    public bool isSetDerivativeMinPriceIncrementAmount()
    { return isSetField(1268); }

    public void set(QuickFix.DerivativeUnitOfMeasure value)
    { setField(value); }
    public QuickFix.DerivativeUnitOfMeasure get(QuickFix.DerivativeUnitOfMeasure  value)
    { getField(value); return value; }
    public QuickFix.DerivativeUnitOfMeasure getDerivativeUnitOfMeasure()
    { QuickFix.DerivativeUnitOfMeasure value = new QuickFix.DerivativeUnitOfMeasure();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeUnitOfMeasure field)
    { return isSetField(field); }
    public bool isSetDerivativeUnitOfMeasure()
    { return isSetField(1269); }

    public void set(QuickFix.DerivativeUnitOfMeasureQty value)
    { setField(value); }
    public QuickFix.DerivativeUnitOfMeasureQty get(QuickFix.DerivativeUnitOfMeasureQty  value)
    { getField(value); return value; }
    public QuickFix.DerivativeUnitOfMeasureQty getDerivativeUnitOfMeasureQty()
    { QuickFix.DerivativeUnitOfMeasureQty value = new QuickFix.DerivativeUnitOfMeasureQty();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeUnitOfMeasureQty field)
    { return isSetField(field); }
    public bool isSetDerivativeUnitOfMeasureQty()
    { return isSetField(1270); }

    public void set(QuickFix.DerivativePriceUnitOfMeasure value)
    { setField(value); }
    public QuickFix.DerivativePriceUnitOfMeasure get(QuickFix.DerivativePriceUnitOfMeasure  value)
    { getField(value); return value; }
    public QuickFix.DerivativePriceUnitOfMeasure getDerivativePriceUnitOfMeasure()
    { QuickFix.DerivativePriceUnitOfMeasure value = new QuickFix.DerivativePriceUnitOfMeasure();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativePriceUnitOfMeasure field)
    { return isSetField(field); }
    public bool isSetDerivativePriceUnitOfMeasure()
    { return isSetField(1315); }

    public void set(QuickFix.DerivativePriceUnitOfMeasureQty value)
    { setField(value); }
    public QuickFix.DerivativePriceUnitOfMeasureQty get(QuickFix.DerivativePriceUnitOfMeasureQty  value)
    { getField(value); return value; }
    public QuickFix.DerivativePriceUnitOfMeasureQty getDerivativePriceUnitOfMeasureQty()
    { QuickFix.DerivativePriceUnitOfMeasureQty value = new QuickFix.DerivativePriceUnitOfMeasureQty();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativePriceUnitOfMeasureQty field)
    { return isSetField(field); }
    public bool isSetDerivativePriceUnitOfMeasureQty()
    { return isSetField(1316); }

    public void set(QuickFix.DerivativeSettlMethod value)
    { setField(value); }
    public QuickFix.DerivativeSettlMethod get(QuickFix.DerivativeSettlMethod  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSettlMethod getDerivativeSettlMethod()
    { QuickFix.DerivativeSettlMethod value = new QuickFix.DerivativeSettlMethod();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSettlMethod field)
    { return isSetField(field); }
    public bool isSetDerivativeSettlMethod()
    { return isSetField(1317); }

    public void set(QuickFix.DerivativePriceQuoteMethod value)
    { setField(value); }
    public QuickFix.DerivativePriceQuoteMethod get(QuickFix.DerivativePriceQuoteMethod  value)
    { getField(value); return value; }
    public QuickFix.DerivativePriceQuoteMethod getDerivativePriceQuoteMethod()
    { QuickFix.DerivativePriceQuoteMethod value = new QuickFix.DerivativePriceQuoteMethod();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativePriceQuoteMethod field)
    { return isSetField(field); }
    public bool isSetDerivativePriceQuoteMethod()
    { return isSetField(1318); }

    public void set(QuickFix.DerivativeValuationMethod value)
    { setField(value); }
    public QuickFix.DerivativeValuationMethod get(QuickFix.DerivativeValuationMethod  value)
    { getField(value); return value; }
    public QuickFix.DerivativeValuationMethod getDerivativeValuationMethod()
    { QuickFix.DerivativeValuationMethod value = new QuickFix.DerivativeValuationMethod();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeValuationMethod field)
    { return isSetField(field); }
    public bool isSetDerivativeValuationMethod()
    { return isSetField(1319); }

    public void set(QuickFix.DerivativeListMethod value)
    { setField(value); }
    public QuickFix.DerivativeListMethod get(QuickFix.DerivativeListMethod  value)
    { getField(value); return value; }
    public QuickFix.DerivativeListMethod getDerivativeListMethod()
    { QuickFix.DerivativeListMethod value = new QuickFix.DerivativeListMethod();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeListMethod field)
    { return isSetField(field); }
    public bool isSetDerivativeListMethod()
    { return isSetField(1320); }

    public void set(QuickFix.DerivativeCapPrice value)
    { setField(value); }
    public QuickFix.DerivativeCapPrice get(QuickFix.DerivativeCapPrice  value)
    { getField(value); return value; }
    public QuickFix.DerivativeCapPrice getDerivativeCapPrice()
    { QuickFix.DerivativeCapPrice value = new QuickFix.DerivativeCapPrice();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeCapPrice field)
    { return isSetField(field); }
    public bool isSetDerivativeCapPrice()
    { return isSetField(1321); }

    public void set(QuickFix.DerivativeFloorPrice value)
    { setField(value); }
    public QuickFix.DerivativeFloorPrice get(QuickFix.DerivativeFloorPrice  value)
    { getField(value); return value; }
    public QuickFix.DerivativeFloorPrice getDerivativeFloorPrice()
    { QuickFix.DerivativeFloorPrice value = new QuickFix.DerivativeFloorPrice();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeFloorPrice field)
    { return isSetField(field); }
    public bool isSetDerivativeFloorPrice()
    { return isSetField(1322); }

    public void set(QuickFix.DerivativePutOrCall value)
    { setField(value); }
    public QuickFix.DerivativePutOrCall get(QuickFix.DerivativePutOrCall  value)
    { getField(value); return value; }
    public QuickFix.DerivativePutOrCall getDerivativePutOrCall()
    { QuickFix.DerivativePutOrCall value = new QuickFix.DerivativePutOrCall();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativePutOrCall field)
    { return isSetField(field); }
    public bool isSetDerivativePutOrCall()
    { return isSetField(1323); }

    public void set(QuickFix.DerivativeExerciseStyle value)
    { setField(value); }
    public QuickFix.DerivativeExerciseStyle get(QuickFix.DerivativeExerciseStyle  value)
    { getField(value); return value; }
    public QuickFix.DerivativeExerciseStyle getDerivativeExerciseStyle()
    { QuickFix.DerivativeExerciseStyle value = new QuickFix.DerivativeExerciseStyle();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeExerciseStyle field)
    { return isSetField(field); }
    public bool isSetDerivativeExerciseStyle()
    { return isSetField(1299); }

    public void set(QuickFix.DerivativeOptPayAmount value)
    { setField(value); }
    public QuickFix.DerivativeOptPayAmount get(QuickFix.DerivativeOptPayAmount  value)
    { getField(value); return value; }
    public QuickFix.DerivativeOptPayAmount getDerivativeOptPayAmount()
    { QuickFix.DerivativeOptPayAmount value = new QuickFix.DerivativeOptPayAmount();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeOptPayAmount field)
    { return isSetField(field); }
    public bool isSetDerivativeOptPayAmount()
    { return isSetField(1225); }

    public void set(QuickFix.DerivativeTimeUnit value)
    { setField(value); }
    public QuickFix.DerivativeTimeUnit get(QuickFix.DerivativeTimeUnit  value)
    { getField(value); return value; }
    public QuickFix.DerivativeTimeUnit getDerivativeTimeUnit()
    { QuickFix.DerivativeTimeUnit value = new QuickFix.DerivativeTimeUnit();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeTimeUnit field)
    { return isSetField(field); }
    public bool isSetDerivativeTimeUnit()
    { return isSetField(1271); }

    public void set(QuickFix.DerivativeSecurityExchange value)
    { setField(value); }
    public QuickFix.DerivativeSecurityExchange get(QuickFix.DerivativeSecurityExchange  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSecurityExchange getDerivativeSecurityExchange()
    { QuickFix.DerivativeSecurityExchange value = new QuickFix.DerivativeSecurityExchange();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSecurityExchange field)
    { return isSetField(field); }
    public bool isSetDerivativeSecurityExchange()
    { return isSetField(1272); }

    public void set(QuickFix.DerivativePositionLimit value)
    { setField(value); }
    public QuickFix.DerivativePositionLimit get(QuickFix.DerivativePositionLimit  value)
    { getField(value); return value; }
    public QuickFix.DerivativePositionLimit getDerivativePositionLimit()
    { QuickFix.DerivativePositionLimit value = new QuickFix.DerivativePositionLimit();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativePositionLimit field)
    { return isSetField(field); }
    public bool isSetDerivativePositionLimit()
    { return isSetField(1273); }

    public void set(QuickFix.DerivativeNTPositionLimit value)
    { setField(value); }
    public QuickFix.DerivativeNTPositionLimit get(QuickFix.DerivativeNTPositionLimit  value)
    { getField(value); return value; }
    public QuickFix.DerivativeNTPositionLimit getDerivativeNTPositionLimit()
    { QuickFix.DerivativeNTPositionLimit value = new QuickFix.DerivativeNTPositionLimit();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeNTPositionLimit field)
    { return isSetField(field); }
    public bool isSetDerivativeNTPositionLimit()
    { return isSetField(1274); }

    public void set(QuickFix.DerivativeIssuer value)
    { setField(value); }
    public QuickFix.DerivativeIssuer get(QuickFix.DerivativeIssuer  value)
    { getField(value); return value; }
    public QuickFix.DerivativeIssuer getDerivativeIssuer()
    { QuickFix.DerivativeIssuer value = new QuickFix.DerivativeIssuer();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeIssuer field)
    { return isSetField(field); }
    public bool isSetDerivativeIssuer()
    { return isSetField(1275); }

    public void set(QuickFix.DerivativeEncodedIssuerLen value)
    { setField(value); }
    public QuickFix.DerivativeEncodedIssuerLen get(QuickFix.DerivativeEncodedIssuerLen  value)
    { getField(value); return value; }
    public QuickFix.DerivativeEncodedIssuerLen getDerivativeEncodedIssuerLen()
    { QuickFix.DerivativeEncodedIssuerLen value = new QuickFix.DerivativeEncodedIssuerLen();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeEncodedIssuerLen field)
    { return isSetField(field); }
    public bool isSetDerivativeEncodedIssuerLen()
    { return isSetField(1277); }

    public void set(QuickFix.DerivativeEncodedIssuer value)
    { setField(value); }
    public QuickFix.DerivativeEncodedIssuer get(QuickFix.DerivativeEncodedIssuer  value)
    { getField(value); return value; }
    public QuickFix.DerivativeEncodedIssuer getDerivativeEncodedIssuer()
    { QuickFix.DerivativeEncodedIssuer value = new QuickFix.DerivativeEncodedIssuer();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeEncodedIssuer field)
    { return isSetField(field); }
    public bool isSetDerivativeEncodedIssuer()
    { return isSetField(1278); }

    public void set(QuickFix.DerivativeSecurityDesc value)
    { setField(value); }
    public QuickFix.DerivativeSecurityDesc get(QuickFix.DerivativeSecurityDesc  value)
    { getField(value); return value; }
    public QuickFix.DerivativeSecurityDesc getDerivativeSecurityDesc()
    { QuickFix.DerivativeSecurityDesc value = new QuickFix.DerivativeSecurityDesc();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeSecurityDesc field)
    { return isSetField(field); }
    public bool isSetDerivativeSecurityDesc()
    { return isSetField(1279); }

    public void set(QuickFix.DerivativeEncodedSecurityDescLen value)
    { setField(value); }
    public QuickFix.DerivativeEncodedSecurityDescLen get(QuickFix.DerivativeEncodedSecurityDescLen  value)
    { getField(value); return value; }
    public QuickFix.DerivativeEncodedSecurityDescLen getDerivativeEncodedSecurityDescLen()
    { QuickFix.DerivativeEncodedSecurityDescLen value = new QuickFix.DerivativeEncodedSecurityDescLen();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeEncodedSecurityDescLen field)
    { return isSetField(field); }
    public bool isSetDerivativeEncodedSecurityDescLen()
    { return isSetField(1280); }

    public void set(QuickFix.DerivativeEncodedSecurityDesc value)
    { setField(value); }
    public QuickFix.DerivativeEncodedSecurityDesc get(QuickFix.DerivativeEncodedSecurityDesc  value)
    { getField(value); return value; }
    public QuickFix.DerivativeEncodedSecurityDesc getDerivativeEncodedSecurityDesc()
    { QuickFix.DerivativeEncodedSecurityDesc value = new QuickFix.DerivativeEncodedSecurityDesc();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeEncodedSecurityDesc field)
    { return isSetField(field); }
    public bool isSetDerivativeEncodedSecurityDesc()
    { return isSetField(1281); }

    public void set(QuickFix.DerivativeContractSettlMonth value)
    { setField(value); }
    public QuickFix.DerivativeContractSettlMonth get(QuickFix.DerivativeContractSettlMonth  value)
    { getField(value); return value; }
    public QuickFix.DerivativeContractSettlMonth getDerivativeContractSettlMonth()
    { QuickFix.DerivativeContractSettlMonth value = new QuickFix.DerivativeContractSettlMonth();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeContractSettlMonth field)
    { return isSetField(field); }
    public bool isSetDerivativeContractSettlMonth()
    { return isSetField(1285); }

    public void set(QuickFix.DerivativeContractMultiplierUnit value)
    { setField(value); }
    public QuickFix.DerivativeContractMultiplierUnit get(QuickFix.DerivativeContractMultiplierUnit  value)
    { getField(value); return value; }
    public QuickFix.DerivativeContractMultiplierUnit getDerivativeContractMultiplierUnit()
    { QuickFix.DerivativeContractMultiplierUnit value = new QuickFix.DerivativeContractMultiplierUnit();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeContractMultiplierUnit field)
    { return isSetField(field); }
    public bool isSetDerivativeContractMultiplierUnit()
    { return isSetField(1438); }

    public void set(QuickFix.DerivativeFlowScheduleType value)
    { setField(value); }
    public QuickFix.DerivativeFlowScheduleType get(QuickFix.DerivativeFlowScheduleType  value)
    { getField(value); return value; }
    public QuickFix.DerivativeFlowScheduleType getDerivativeFlowScheduleType()
    { QuickFix.DerivativeFlowScheduleType value = new QuickFix.DerivativeFlowScheduleType();
      getField(value); return value; }
    public bool isSet(QuickFix.DerivativeFlowScheduleType field)
    { return isSetField(field); }
    public bool isSetDerivativeFlowScheduleType()
    { return isSetField(1442); }

    public void set(QuickFix.SecuritySubType value)
    { setField(value); }
    public QuickFix.SecuritySubType get(QuickFix.SecuritySubType  value)
    { getField(value); return value; }
    public QuickFix.SecuritySubType getSecuritySubType()
    { QuickFix.SecuritySubType value = new QuickFix.SecuritySubType();
      getField(value); return value; }
    public bool isSet(QuickFix.SecuritySubType field)
    { return isSetField(field); }
    public bool isSetSecuritySubType()
    { return isSetField(762); }

    public void set(QuickFix.Currency value)
    { setField(value); }
    public QuickFix.Currency get(QuickFix.Currency  value)
    { getField(value); return value; }
    public QuickFix.Currency getCurrency()
    { QuickFix.Currency value = new QuickFix.Currency();
      getField(value); return value; }
    public bool isSet(QuickFix.Currency field)
    { return isSetField(field); }
    public bool isSetCurrency()
    { return isSetField(15); }

    public void set(QuickFix.Text value)
    { setField(value); }
    public QuickFix.Text get(QuickFix.Text  value)
    { getField(value); return value; }
    public QuickFix.Text getText()
    { QuickFix.Text value = new QuickFix.Text();
      getField(value); return value; }
    public bool isSet(QuickFix.Text field)
    { return isSetField(field); }
    public bool isSetText()
    { return isSetField(58); }

    public void set(QuickFix.EncodedTextLen value)
    { setField(value); }
    public QuickFix.EncodedTextLen get(QuickFix.EncodedTextLen  value)
    { getField(value); return value; }
    public QuickFix.EncodedTextLen getEncodedTextLen()
    { QuickFix.EncodedTextLen value = new QuickFix.EncodedTextLen();
      getField(value); return value; }
    public bool isSet(QuickFix.EncodedTextLen field)
    { return isSetField(field); }
    public bool isSetEncodedTextLen()
    { return isSetField(354); }

    public void set(QuickFix.EncodedText value)
    { setField(value); }
    public QuickFix.EncodedText get(QuickFix.EncodedText  value)
    { getField(value); return value; }
    public QuickFix.EncodedText getEncodedText()
    { QuickFix.EncodedText value = new QuickFix.EncodedText();
      getField(value); return value; }
    public bool isSet(QuickFix.EncodedText field)
    { return isSetField(field); }
    public bool isSetEncodedText()
    { return isSetField(355); }

    public void set(QuickFix.TradingSessionID value)
    { setField(value); }
    public QuickFix.TradingSessionID get(QuickFix.TradingSessionID  value)
    { getField(value); return value; }
    public QuickFix.TradingSessionID getTradingSessionID()
    { QuickFix.TradingSessionID value = new QuickFix.TradingSessionID();
      getField(value); return value; }
    public bool isSet(QuickFix.TradingSessionID field)
    { return isSetField(field); }
    public bool isSetTradingSessionID()
    { return isSetField(336); }

    public void set(QuickFix.TradingSessionSubID value)
    { setField(value); }
    public QuickFix.TradingSessionSubID get(QuickFix.TradingSessionSubID  value)
    { getField(value); return value; }
    public QuickFix.TradingSessionSubID getTradingSessionSubID()
    { QuickFix.TradingSessionSubID value = new QuickFix.TradingSessionSubID();
      getField(value); return value; }
    public bool isSet(QuickFix.TradingSessionSubID field)
    { return isSetField(field); }
    public bool isSetTradingSessionSubID()
    { return isSetField(625); }

    public void set(QuickFix.SubscriptionRequestType value)
    { setField(value); }
    public QuickFix.SubscriptionRequestType get(QuickFix.SubscriptionRequestType  value)
    { getField(value); return value; }
    public QuickFix.SubscriptionRequestType getSubscriptionRequestType()
    { QuickFix.SubscriptionRequestType value = new QuickFix.SubscriptionRequestType();
      getField(value); return value; }
    public bool isSet(QuickFix.SubscriptionRequestType field)
    { return isSetField(field); }
    public bool isSetSubscriptionRequestType()
    { return isSetField(263); }

  };

}

