namespace QuickFix40
{
  public class Header : QuickFix.Message.Header
  {
    Header(QuickFix.Message message) : base(message) {}

      public void set(QuickFix.BeginString value)
      { setField(value); }
      public QuickFix.BeginString get(QuickFix.BeginString  value)
      { getField(value); return value; }
      public QuickFix.BeginString getBeginString()
      { QuickFix.BeginString value = new QuickFix.BeginString();
        getField(value); return value; }
      public bool isSet(QuickFix.BeginString field)
      { return isSetField(field); }
      public bool isSetBeginString()
      { return isSetField(8); }

      public void set(QuickFix.BodyLength value)
      { setField(value); }
      public QuickFix.BodyLength get(QuickFix.BodyLength  value)
      { getField(value); return value; }
      public QuickFix.BodyLength getBodyLength()
      { QuickFix.BodyLength value = new QuickFix.BodyLength();
        getField(value); return value; }
      public bool isSet(QuickFix.BodyLength field)
      { return isSetField(field); }
      public bool isSetBodyLength()
      { return isSetField(9); }

      public void set(QuickFix.MsgType value)
      { setField(value); }
      public QuickFix.MsgType get(QuickFix.MsgType  value)
      { getField(value); return value; }
      public QuickFix.MsgType getMsgType()
      { QuickFix.MsgType value = new QuickFix.MsgType();
        getField(value); return value; }
      public bool isSet(QuickFix.MsgType field)
      { return isSetField(field); }
      public bool isSetMsgType()
      { return isSetField(35); }

      public void set(QuickFix.SenderCompID value)
      { setField(value); }
      public QuickFix.SenderCompID get(QuickFix.SenderCompID  value)
      { getField(value); return value; }
      public QuickFix.SenderCompID getSenderCompID()
      { QuickFix.SenderCompID value = new QuickFix.SenderCompID();
        getField(value); return value; }
      public bool isSet(QuickFix.SenderCompID field)
      { return isSetField(field); }
      public bool isSetSenderCompID()
      { return isSetField(49); }

      public void set(QuickFix.TargetCompID value)
      { setField(value); }
      public QuickFix.TargetCompID get(QuickFix.TargetCompID  value)
      { getField(value); return value; }
      public QuickFix.TargetCompID getTargetCompID()
      { QuickFix.TargetCompID value = new QuickFix.TargetCompID();
        getField(value); return value; }
      public bool isSet(QuickFix.TargetCompID field)
      { return isSetField(field); }
      public bool isSetTargetCompID()
      { return isSetField(56); }

      public void set(QuickFix.OnBehalfOfCompID value)
      { setField(value); }
      public QuickFix.OnBehalfOfCompID get(QuickFix.OnBehalfOfCompID  value)
      { getField(value); return value; }
      public QuickFix.OnBehalfOfCompID getOnBehalfOfCompID()
      { QuickFix.OnBehalfOfCompID value = new QuickFix.OnBehalfOfCompID();
        getField(value); return value; }
      public bool isSet(QuickFix.OnBehalfOfCompID field)
      { return isSetField(field); }
      public bool isSetOnBehalfOfCompID()
      { return isSetField(115); }

      public void set(QuickFix.DeliverToCompID value)
      { setField(value); }
      public QuickFix.DeliverToCompID get(QuickFix.DeliverToCompID  value)
      { getField(value); return value; }
      public QuickFix.DeliverToCompID getDeliverToCompID()
      { QuickFix.DeliverToCompID value = new QuickFix.DeliverToCompID();
        getField(value); return value; }
      public bool isSet(QuickFix.DeliverToCompID field)
      { return isSetField(field); }
      public bool isSetDeliverToCompID()
      { return isSetField(128); }

      public void set(QuickFix.SecureDataLen value)
      { setField(value); }
      public QuickFix.SecureDataLen get(QuickFix.SecureDataLen  value)
      { getField(value); return value; }
      public QuickFix.SecureDataLen getSecureDataLen()
      { QuickFix.SecureDataLen value = new QuickFix.SecureDataLen();
        getField(value); return value; }
      public bool isSet(QuickFix.SecureDataLen field)
      { return isSetField(field); }
      public bool isSetSecureDataLen()
      { return isSetField(90); }

      public void set(QuickFix.SecureData value)
      { setField(value); }
      public QuickFix.SecureData get(QuickFix.SecureData  value)
      { getField(value); return value; }
      public QuickFix.SecureData getSecureData()
      { QuickFix.SecureData value = new QuickFix.SecureData();
        getField(value); return value; }
      public bool isSet(QuickFix.SecureData field)
      { return isSetField(field); }
      public bool isSetSecureData()
      { return isSetField(91); }

      public void set(QuickFix.MsgSeqNum value)
      { setField(value); }
      public QuickFix.MsgSeqNum get(QuickFix.MsgSeqNum  value)
      { getField(value); return value; }
      public QuickFix.MsgSeqNum getMsgSeqNum()
      { QuickFix.MsgSeqNum value = new QuickFix.MsgSeqNum();
        getField(value); return value; }
      public bool isSet(QuickFix.MsgSeqNum field)
      { return isSetField(field); }
      public bool isSetMsgSeqNum()
      { return isSetField(34); }

      public void set(QuickFix.SenderSubID value)
      { setField(value); }
      public QuickFix.SenderSubID get(QuickFix.SenderSubID  value)
      { getField(value); return value; }
      public QuickFix.SenderSubID getSenderSubID()
      { QuickFix.SenderSubID value = new QuickFix.SenderSubID();
        getField(value); return value; }
      public bool isSet(QuickFix.SenderSubID field)
      { return isSetField(field); }
      public bool isSetSenderSubID()
      { return isSetField(50); }

      public void set(QuickFix.TargetSubID value)
      { setField(value); }
      public QuickFix.TargetSubID get(QuickFix.TargetSubID  value)
      { getField(value); return value; }
      public QuickFix.TargetSubID getTargetSubID()
      { QuickFix.TargetSubID value = new QuickFix.TargetSubID();
        getField(value); return value; }
      public bool isSet(QuickFix.TargetSubID field)
      { return isSetField(field); }
      public bool isSetTargetSubID()
      { return isSetField(57); }

      public void set(QuickFix.OnBehalfOfSubID value)
      { setField(value); }
      public QuickFix.OnBehalfOfSubID get(QuickFix.OnBehalfOfSubID  value)
      { getField(value); return value; }
      public QuickFix.OnBehalfOfSubID getOnBehalfOfSubID()
      { QuickFix.OnBehalfOfSubID value = new QuickFix.OnBehalfOfSubID();
        getField(value); return value; }
      public bool isSet(QuickFix.OnBehalfOfSubID field)
      { return isSetField(field); }
      public bool isSetOnBehalfOfSubID()
      { return isSetField(116); }

      public void set(QuickFix.DeliverToSubID value)
      { setField(value); }
      public QuickFix.DeliverToSubID get(QuickFix.DeliverToSubID  value)
      { getField(value); return value; }
      public QuickFix.DeliverToSubID getDeliverToSubID()
      { QuickFix.DeliverToSubID value = new QuickFix.DeliverToSubID();
        getField(value); return value; }
      public bool isSet(QuickFix.DeliverToSubID field)
      { return isSetField(field); }
      public bool isSetDeliverToSubID()
      { return isSetField(129); }

      public void set(QuickFix.PossDupFlag value)
      { setField(value); }
      public QuickFix.PossDupFlag get(QuickFix.PossDupFlag  value)
      { getField(value); return value; }
      public QuickFix.PossDupFlag getPossDupFlag()
      { QuickFix.PossDupFlag value = new QuickFix.PossDupFlag();
        getField(value); return value; }
      public bool isSet(QuickFix.PossDupFlag field)
      { return isSetField(field); }
      public bool isSetPossDupFlag()
      { return isSetField(43); }

      public void set(QuickFix.PossResend value)
      { setField(value); }
      public QuickFix.PossResend get(QuickFix.PossResend  value)
      { getField(value); return value; }
      public QuickFix.PossResend getPossResend()
      { QuickFix.PossResend value = new QuickFix.PossResend();
        getField(value); return value; }
      public bool isSet(QuickFix.PossResend field)
      { return isSetField(field); }
      public bool isSetPossResend()
      { return isSetField(97); }

      public void set(QuickFix.SendingTime value)
      { setField(value); }
      public QuickFix.SendingTime get(QuickFix.SendingTime  value)
      { getField(value); return value; }
      public QuickFix.SendingTime getSendingTime()
      { QuickFix.SendingTime value = new QuickFix.SendingTime();
        getField(value); return value; }
      public bool isSet(QuickFix.SendingTime field)
      { return isSetField(field); }
      public bool isSetSendingTime()
      { return isSetField(52); }

      public void set(QuickFix.OrigSendingTime value)
      { setField(value); }
      public QuickFix.OrigSendingTime get(QuickFix.OrigSendingTime  value)
      { getField(value); return value; }
      public QuickFix.OrigSendingTime getOrigSendingTime()
      { QuickFix.OrigSendingTime value = new QuickFix.OrigSendingTime();
        getField(value); return value; }
      public bool isSet(QuickFix.OrigSendingTime field)
      { return isSetField(field); }
      public bool isSetOrigSendingTime()
      { return isSetField(122); }

  };

  public class Trailer : QuickFix.Message.Trailer
  {
    Trailer(QuickFix.Message message) : base(message) {}

      public void set(QuickFix.SignatureLength value)
      { setField(value); }
      public QuickFix.SignatureLength get(QuickFix.SignatureLength  value)
      { getField(value); return value; }
      public QuickFix.SignatureLength getSignatureLength()
      { QuickFix.SignatureLength value = new QuickFix.SignatureLength();
        getField(value); return value; }
      public bool isSet(QuickFix.SignatureLength field)
      { return isSetField(field); }
      public bool isSetSignatureLength()
      { return isSetField(93); }

      public void set(QuickFix.Signature value)
      { setField(value); }
      public QuickFix.Signature get(QuickFix.Signature  value)
      { getField(value); return value; }
      public QuickFix.Signature getSignature()
      { QuickFix.Signature value = new QuickFix.Signature();
        getField(value); return value; }
      public bool isSet(QuickFix.Signature field)
      { return isSetField(field); }
      public bool isSetSignature()
      { return isSetField(89); }

      public void set(QuickFix.CheckSum value)
      { setField(value); }
      public QuickFix.CheckSum get(QuickFix.CheckSum  value)
      { getField(value); return value; }
      public QuickFix.CheckSum getCheckSum()
      { QuickFix.CheckSum value = new QuickFix.CheckSum();
        getField(value); return value; }
      public bool isSet(QuickFix.CheckSum field)
      { return isSetField(field); }
      public bool isSetCheckSum()
      { return isSetField(10); }

  };

  public class Message : QuickFix.Message
  {
    public Message() : base(new QuickFix.BeginString("FIX.4.0"))
    {
      m_header = new Header(this);
      m_trailer = new Trailer(this);
    }

    public Message( QuickFix.MsgType msgType ) : base(new QuickFix.BeginString("FIX.4.0"), msgType)
    {
      m_header = new Header(this);
      m_trailer = new Trailer(this);
    }

    public new Header getHeader() { return (Header)(base.getHeader()); }
    public new Trailer getTrailer() { return (Trailer)(base.getTrailer()); }
  };

}

