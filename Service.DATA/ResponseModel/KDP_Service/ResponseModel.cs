namespace Service.DATA.ResponseModel.KDP_Service
{
    // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private object headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public object Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

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

        private sendMessageResponse sendMessageResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://service.2fa-chain.kz/ns/kdp")]
        public sendMessageResponse sendMessageResponse
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://service.2fa-chain.kz/ns/kdp")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.2fa-chain.kz/ns/kdp", IsNullable = false)]
    public partial class sendMessageResponse
    {

        private sendMessageResponseResponse responseField;

        /// <remarks/>
        public sendMessageResponseResponse response
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://service.2fa-chain.kz/ns/kdp")]
    public partial class sendMessageResponseResponse
    {

        private sendMessageResponseResponseResponseInfo responseInfoField;

        private sendMessageResponseResponseResponseData responseDataField;

        /// <remarks/>
        public sendMessageResponseResponseResponseInfo responseInfo
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
        public sendMessageResponseResponseResponseData responseData
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://service.2fa-chain.kz/ns/kdp")]
    public partial class sendMessageResponseResponseResponseInfo
    {

        private string messageIdField;

        private System.DateTime responseDateField;

        private object statusField;

        private string sessionIdField;

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
        public object status
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

        /// <remarks/>
        public string sessionId
        {
            get
            {
                return this.sessionIdField;
            }
            set
            {
                this.sessionIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://service.2fa-chain.kz/ns/kdp")]
    public partial class sendMessageResponseResponseResponseData
    {

        private sendMessageResponseResponseResponseDataData dataField;

        /// <remarks/>
        public sendMessageResponseResponseResponseDataData data
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://service.2fa-chain.kz/ns/kdp")]
    public partial class sendMessageResponseResponseResponseDataData
    {

        private string statusField;

        private string codeField;

        private string publickeyField;

        /// <remarks/>
        public string status
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

        /// <remarks/>
        public string code
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
        [System.Xml.Serialization.XmlElementAttribute("public-key")]
        public string publickey
        {
            get
            {
                return this.publickeyField;
            }
            set
            {
                this.publickeyField = value;
            }
        }
    }

}
