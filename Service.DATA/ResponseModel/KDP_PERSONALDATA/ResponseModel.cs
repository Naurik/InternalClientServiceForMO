namespace Service.DATA.ResponseModel.KDP_PERSONALDATA
{
// Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
/// <remarks/>
[System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private SendMessageResponse sendMessageResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://bip.bee.kz/SyncChannel/v10/Types")]
        public SendMessageResponse SendMessageResponse
        {
            get
            {
                return this.sendMessageResponseField;
            }
            set
            {
                this.sendMessageResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bip.bee.kz/SyncChannel/v10/Types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://bip.bee.kz/SyncChannel/v10/Types", IsNullable = false)]
    public partial class SendMessageResponse
    {

        private response responseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public response response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class response
    {

        private responseResponseInfo responseInfoField;

        private responseResponseData responseDataField;

        /// <remarks/>
        public responseResponseInfo responseInfo
        {
            get
            {
                return this.responseInfoField;
            }
            set
            {
                this.responseInfoField = value;
            }
        }

        /// <remarks/>
        public responseResponseData responseData
        {
            get
            {
                return this.responseDataField;
            }
            set
            {
                this.responseDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseInfo
    {

        private string messageIdField;

        private System.DateTime responseDateField;

        private responseResponseInfoStatus statusField;

        /// <remarks/>
        public string messageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime responseDate
        {
            get
            {
                return this.responseDateField;
            }
            set
            {
                this.responseDateField = value;
            }
        }

        /// <remarks/>
        public responseResponseInfoStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseInfoStatus
    {

        private byte codeField;

        private string messageField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseData
    {

        private responseResponseDataData dataField;

        /// <remarks/>
        public responseResponseDataData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataData
    {

        private ulong uinField;

        private string r_pdataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://service.2fa-chain.kz/ns/kdp/personalData")]
        public ulong uin
        {
            get
            {
                return this.uinField;
            }
            set
            {
                this.uinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://service.2fa-chain.kz/ns/kdp/personalData")]
        public string r_pdata
        {
            get
            {
                return this.r_pdataField;
            }
            set
            {
                this.r_pdataField = value;
            }
        }
    }



}
