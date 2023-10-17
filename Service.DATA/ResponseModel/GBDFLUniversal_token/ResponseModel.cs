namespace Service.DATA.ResponseModel.GBDFLUniversal_token
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

        private object messageIdField;

        private object correlationIdField;

        private object responseDateField;

        private responseResponseInfoStatus statusField;

        /// <remarks/>
        public object messageId
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
        public object correlationId
        {
            get
            {
                return this.correlationIdField;
            }
            set
            {
                this.correlationIdField = value;
            }
        }

        /// <remarks/>
        public object responseDate
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

        private object codeField;

        private string messageField;

        /// <remarks/>
        public object code
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

        private object messageIdField;

        private object messageDateField;

        private object requestIdField;

        private responseResponseDataDataSender senderField;

        private responseResponseDataDataReceiver receiverField;

        private responseResponseDataDataMessageResult messageResultField;

        private responseResponseDataDataPersons? personsField;

        private Signature signatureField;

        /// <remarks/>
        public object messageId
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
        public object messageDate
        {
            get
            {
                return this.messageDateField;
            }
            set
            {
                this.messageDateField = value;
            }
        }

        /// <remarks/>
        public object requestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataSender sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataReceiver receiver
        {
            get
            {
                return this.receiverField;
            }
            set
            {
                this.receiverField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataMessageResult messageResult
        {
            get
            {
                return this.messageResultField;
            }
            set
            {
                this.messageResultField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersons persons
        {
            get
            {
                return this.personsField;
            }
            set
            {
                this.personsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataSender
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataReceiver
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataMessageResult
    {

        private object codeField;

        private string nameRuField;

        private string nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public string nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public string nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersons
    {

        private responseResponseDataDataPersonsPerson personField;

        /// <remarks/>
        public responseResponseDataDataPersonsPerson person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPerson
    {

        private object iinField;

        private object surnameField;

        private object nameField;

        private object patronymicField;

        private object birthDateField;

        private responseResponseDataDataPersonsPersonGender genderField;

        private responseResponseDataDataPersonsPersonNationality nationalityField;

        private responseResponseDataDataPersonsPersonCitizenship citizenshipField;

        private responseResponseDataDataPersonsPersonLifeStatus lifeStatusField;

        private responseResponseDataDataPersonsPersonBirthPlace birthPlaceField;

        private responseResponseDataDataPersonsPersonRegAddress regAddressField;

        private responseResponseDataDataPersonsPersonDocuments documentsField;

        private object addressesField;

        /// <remarks/>
        public object iin
        {
            get
            {
                return this.iinField;
            }
            set
            {
                this.iinField = value;
            }
        }

        /// <remarks/>
        public object surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        public object name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public object patronymic
        {
            get
            {
                return this.patronymicField;
            }
            set
            {
                this.patronymicField = value;
            }
        }

        /// <remarks/>
        public object birthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonNationality nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonCitizenship citizenship
        {
            get
            {
                return this.citizenshipField;
            }
            set
            {
                this.citizenshipField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonLifeStatus lifeStatus
        {
            get
            {
                return this.lifeStatusField;
            }
            set
            {
                this.lifeStatusField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonBirthPlace birthPlace
        {
            get
            {
                return this.birthPlaceField;
            }
            set
            {
                this.birthPlaceField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonRegAddress regAddress
        {
            get
            {
                return this.regAddressField;
            }
            set
            {
                this.regAddressField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonDocuments documents
        {
            get
            {
                return this.documentsField;
            }
            set
            {
                this.documentsField = value;
            }
        }

        /// <remarks/>
        public object addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonGender
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonNationality
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonCitizenship
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonLifeStatus
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonBirthPlace
    {

        private responseResponseDataDataPersonsPersonBirthPlaceCountry countryField;

        private responseResponseDataDataPersonsPersonBirthPlaceDistrict districtField;

        private responseResponseDataDataPersonsPersonBirthPlaceRegion regionField;

        private object cityField;

        /// <remarks/>
        public responseResponseDataDataPersonsPersonBirthPlaceCountry country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonBirthPlaceDistrict district
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonBirthPlaceRegion region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public object city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonBirthPlaceCountry
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonBirthPlaceDistrict
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonBirthPlaceRegion
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonRegAddress
    {

        private responseResponseDataDataPersonsPersonRegAddressCountry countryField;

        private responseResponseDataDataPersonsPersonRegAddressDistrict districtField;

        private responseResponseDataDataPersonsPersonRegAddressRegion regionField;

        private object streetField;

        private object buildingField;

        private object beginDateField;

        private responseResponseDataDataPersonsPersonRegAddressStatus statusField;

        private responseResponseDataDataPersonsPersonRegAddressInvalidity invalidityField;

        private object arCodeField;

        /// <remarks/>
        public responseResponseDataDataPersonsPersonRegAddressCountry country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonRegAddressDistrict district
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonRegAddressRegion region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public object street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public object building
        {
            get
            {
                return this.buildingField;
            }
            set
            {
                this.buildingField = value;
            }
        }

        /// <remarks/>
        public object beginDate
        {
            get
            {
                return this.beginDateField;
            }
            set
            {
                this.beginDateField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonRegAddressStatus status
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
        public responseResponseDataDataPersonsPersonRegAddressInvalidity invalidity
        {
            get
            {
                return this.invalidityField;
            }
            set
            {
                this.invalidityField = value;
            }
        }

        /// <remarks/>
        public object arCode
        {
            get
            {
                return this.arCodeField;
            }
            set
            {
                this.arCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonRegAddressCountry
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonRegAddressDistrict
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonRegAddressRegion
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonRegAddressStatus
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonRegAddressInvalidity
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonDocuments
    {

        private responseResponseDataDataPersonsPersonDocumentsDocument documentField;

        /// <remarks/>
        public responseResponseDataDataPersonsPersonDocumentsDocument document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonDocumentsDocument
    {

        private responseResponseDataDataPersonsPersonDocumentsDocumentType typeField;

        private object numberField;

        private object beginDateField;

        private object endDateField;

        private responseResponseDataDataPersonsPersonDocumentsDocumentIssueOrganization issueOrganizationField;

        private responseResponseDataDataPersonsPersonDocumentsDocumentStatus statusField;

        private object surnameField;

        private object nameField;

        private object patronymicField;

        private object birthDateField;

        /// <remarks/>
        public responseResponseDataDataPersonsPersonDocumentsDocumentType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public object number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public object beginDate
        {
            get
            {
                return this.beginDateField;
            }
            set
            {
                this.beginDateField = value;
            }
        }

        /// <remarks/>
        public object endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonDocumentsDocumentIssueOrganization issueOrganization
        {
            get
            {
                return this.issueOrganizationField;
            }
            set
            {
                this.issueOrganizationField = value;
            }
        }

        /// <remarks/>
        public responseResponseDataDataPersonsPersonDocumentsDocumentStatus status
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
        public object surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        public object name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public object patronymic
        {
            get
            {
                return this.patronymicField;
            }
            set
            {
                this.patronymicField = value;
            }
        }

        /// <remarks/>
        public object birthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonDocumentsDocumentType
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonDocumentsDocumentIssueOrganization
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResponseDataDataPersonsPersonDocumentsDocumentStatus
    {

        private object codeField;

        private object nameRuField;

        private object nameKzField;

        private object changeDateField;

        /// <remarks/>
        public object code
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
        public object nameRu
        {
            get
            {
                return this.nameRuField;
            }
            set
            {
                this.nameRuField = value;
            }
        }

        /// <remarks/>
        public object nameKz
        {
            get
            {
                return this.nameKzField;
            }
            set
            {
                this.nameKzField = value;
            }
        }

        /// <remarks/>
        public object changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class Signature
    {

        private SignatureSignedInfo signedInfoField;

        private string signatureValueField;

        private SignatureKeyInfo keyInfoField;

        /// <remarks/>
        public SignatureSignedInfo SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public string SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public SignatureKeyInfo KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfo
    {

        private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

        private SignatureSignedInfoSignatureMethod signatureMethodField;

        private SignatureSignedInfoReference referenceField;

        /// <remarks/>
        public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoReference Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoCanonicalizationMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoSignatureMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReference
    {

        private SignatureSignedInfoReferenceTransform[] transformsField;

        private SignatureSignedInfoReferenceDigestMethod digestMethodField;

        private string digestValueField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public SignatureSignedInfoReferenceTransform[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoReferenceDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceTransform
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceDigestMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfo
    {

        private SignatureKeyInfoX509Data x509DataField;

        /// <remarks/>
        public SignatureKeyInfoX509Data X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfoX509Data
    {

        private string x509CertificateField;

        /// <remarks/>
        public string X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }
    }


}
