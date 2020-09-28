using System.Xml.Serialization;
using System.Collections.Generic;

namespace SarsoShoppingData
{
   
        [XmlRoot(ElementName = "address")]
        public class Address
        {
            [XmlAttribute(AttributeName = "Address")]
            public string Addresses { get; set; }
            [XmlAttribute(AttributeName = "Billno")]
            public string Billno { get; set; }
            [XmlAttribute(AttributeName = "City")]
            public string City { get; set; }
            [XmlAttribute(AttributeName = "District")]
            public string District { get; set; }
            [XmlAttribute(AttributeName = "Fname")]
            public string Fname { get; set; }
            [XmlAttribute(AttributeName = "LName")]
            public string LName { get; set; }
            [XmlAttribute(AttributeName = "Mobile")]
            public string Mobile { get; set; }
            [XmlAttribute(AttributeName = "PiCode")]
            public string PiCode { get; set; }
            [XmlAttribute(AttributeName = "Regid")]
            public string Regid { get; set; }
            [XmlAttribute(AttributeName = "Reqno")]
            public string Reqno { get; set; }
            [XmlAttribute(AttributeName = "SAId")]
            public string SAId { get; set; }
            [XmlAttribute(AttributeName = "state")]
            public string State { get; set; }
        }

        [XmlRoot(ElementName = "Invoice")]
        public class Invoice
        {
            [XmlElement(ElementName = "Receipt")]
            public Receipt Receipt { get; set; }
        }

        [XmlRoot(ElementName = "Receipt")]
        public class Receipt
        {
            [XmlAttribute(AttributeName = "Add1")]
            public string Add1 { get; set; }
            [XmlAttribute(AttributeName = "Add2")]
            public string Add2 { get; set; }
            [XmlAttribute(AttributeName = "amount")]
            public string Amount { get; set; }
            [XmlAttribute(AttributeName = "City")]
            public string City { get; set; }
            [XmlAttribute(AttributeName = "CouponValue")]
            public string CouponValue { get; set; }
            [XmlAttribute(AttributeName = "crchrg")]
            public string Crchrg { get; set; }
            [XmlAttribute(AttributeName = "credit")]
            public string Credit { get; set; }
            [XmlAttribute(AttributeName = "District")]
            public string District { get; set; }
            [XmlAttribute(AttributeName = "Idno")]
            public string Idno { get; set; }
            [XmlElement(ElementName = "InvPrds")]
            public string InvPrds { get; set; }
            [XmlAttribute(AttributeName = "Mobile")]
            public string Mobile { get; set; }
            [XmlAttribute(AttributeName = "Name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "NetAmt")]
            public string NetAmt { get; set; }
            [XmlAttribute(AttributeName = "Pin")]
            public string Pin { get; set; }
            [XmlAttribute(AttributeName = "price")]
            public string Price { get; set; }
            [XmlAttribute(AttributeName = "pv")]
            public string Pv { get; set; }
            [XmlAttribute(AttributeName = "qty")]
            public string Qty { get; set; }
            [XmlElement(ElementName = "repurchasesales")]
            public Repurchasesales Repurchasesales { get; set; }
            [XmlElement(ElementName = "InvProducts")]
            public Repurchasesales InvProducts { get; set; }        
            [XmlAttribute(AttributeName = "reqdate")]
            public string Reqdate { get; set; }
            [XmlAttribute(AttributeName = "ReqNo")]
            public string ReqNo { get; set; }
            [XmlElement(ElementName = "Shoppingaddress")]
            public Shoppingaddress Shoppingaddress { get; set; }
            [XmlAttribute(AttributeName = "State")]
            public string State { get; set; }
            [XmlAttribute(AttributeName = "Taxamt")]
            public string Taxamt { get; set; }
            public bool CGSTP { get; set; }
            public bool SGSTP { get; set; }
            public bool IGSTP = false;
            public bool CGSTPV { get; set; }
            public bool SGSTPV { get; set; }
            public bool IGSTPV { get; set; }
            public string TaxType{ get; set; } 
        }

        [XmlRoot(ElementName = "repurchasesales")]
        public class Repurchasesales
        {
            [XmlElement(ElementName = "sales")]
            public List<Sales> Sales { get; set; }
        }

        [XmlRoot(ElementName = "sales")]
        public class Sales
        {
            [XmlAttribute(AttributeName = "amount")]
            public string Amount { get; set; }
            [XmlAttribute(AttributeName = "Attribute")]
            public string Attribute { get; set; }
            [XmlAttribute(AttributeName = "BasicRate")]
            public string BasicRate { get; set; }
            [XmlAttribute(AttributeName = "billdate")]
            public string Billdate { get; set; }
            [XmlAttribute(AttributeName = "billno")]
            public string Billno { get; set; }
            [XmlAttribute(AttributeName = "CGST")]
            public string CGST { get; set; }
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "DDPCommission")]
            public string DDPCommission { get; set; }
            [XmlAttribute(AttributeName = "FreePrd")]
            public string FreePrd { get; set; }
            [XmlAttribute(AttributeName = "GST")]
            public string GST { get; set; }
            [XmlAttribute(AttributeName = "IGST")]
            public string IGST { get; set; }
            [XmlAttribute(AttributeName = "itemcode")]
            public string Itemcode { get; set; }
            [XmlAttribute(AttributeName = "pcode")]
            public string Pcode { get; set; }
            [XmlAttribute(AttributeName = "pname")]
            public string Pname { get; set; }
            [XmlAttribute(AttributeName = "price")]
            public string Price { get; set; }
            [XmlAttribute(AttributeName = "pv")]
            public string Pv { get; set; }
            [XmlAttribute(AttributeName = "qty")]
            public string Qty { get; set; }
            [XmlAttribute(AttributeName = "regid")]
            public string Regid { get; set; }
            [XmlAttribute(AttributeName = "sesid")]
            public string Sesid { get; set; }
            [XmlAttribute(AttributeName = "SGST")]
            public string SGST { get; set; }
            [XmlAttribute(AttributeName = "slno")]
            public string Slno { get; set; }
            [XmlAttribute(AttributeName = "taxamt")]
            public string Taxamt { get; set; }
            [XmlAttribute(AttributeName = "taxper")]
            public string Taxper { get; set; }
            [XmlAttribute(AttributeName = "taxtype")]
            public string Taxtype { get; set; }
            [XmlAttribute(AttributeName = "Vat")]
            public string Vat { get; set; }
            [XmlAttribute(AttributeName = "VatAmt")]
            public string VatAmt { get; set; }
        }
       

    }
