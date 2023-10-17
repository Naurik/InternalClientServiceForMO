namespace Service.DATA.ResponseModel.MO_ISHASMR_ENBEKSERVICE
{
    public class MO_ISHASMR_ENBEKSERVICE
    {
// Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://geocenter.kz/services/enbek/schemas")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://geocenter.kz/services/enbek/schemas", IsNullable=false)]
public partial class MilitaryServiceResponse
        {

            private ulong requestNumberField;

            private System.DateTime requestDateField;

            private System.DateTime responseDateField;

            private ulong iINField;

            private string lastnameField;

            private string firstnameField;

            private string patronymicField;

            private System.DateTime birthdateField;

            private byte statusField;

            private string statusNameRuField;

            private string statusNameKzField;

            private string commentRuField;

            private string commentKzField;

            private Signature signatureField;

            /// <remarks/>
            public ulong requestNumber
            {
                get
                {
                    return this.requestNumberField;
                }
                set
                {
                    this.requestNumberField = value;
                }
            }

            /// <remarks/>
            public System.DateTime requestDate
            {
                get
                {
                    return this.requestDateField;
                }
                set
                {
                    this.requestDateField = value;
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
            public ulong IIN
            {
                get
                {
                    return this.iINField;
                }
                set
                {
                    this.iINField = value;
                }
            }

            /// <remarks/>
            public string lastname
            {
                get
                {
                    return this.lastnameField;
                }
                set
                {
                    this.lastnameField = value;
                }
            }

            /// <remarks/>
            public string firstname
            {
                get
                {
                    return this.firstnameField;
                }
                set
                {
                    this.firstnameField = value;
                }
            }

            /// <remarks/>
            public string patronymic
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
            public System.DateTime birthdate
            {
                get
                {
                    return this.birthdateField;
                }
                set
                {
                    this.birthdateField = value;
                }
            }

            /// <remarks/>
            public byte status
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
            public string statusNameRu
            {
                get
                {
                    return this.statusNameRuField;
                }
                set
                {
                    this.statusNameRuField = value;
                }
            }

            /// <remarks/>
            public string statusNameKz
            {
                get
                {
                    return this.statusNameKzField;
                }
                set
                {
                    this.statusNameKzField = value;
                }
            }

            /// <remarks/>
            public string commentRu
            {
                get
                {
                    return this.commentRuField;
                }
                set
                {
                    this.commentRuField = value;
                }
            }

            /// <remarks/>
            public string commentKz
            {
                get
                {
                    return this.commentKzField;
                }
                set
                {
                    this.commentKzField = value;
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
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
        public partial class Signature
        {

            private SignatureSignedInfo signedInfoField;

            private string signatureValueField;

            private SignatureKeyInfo keyInfoField;

            private byte idField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
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
}
