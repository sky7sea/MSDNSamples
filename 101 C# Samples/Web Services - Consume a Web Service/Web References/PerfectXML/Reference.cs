﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace HowTo.PerfectXML {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SalesRankNPriceSoap", Namespace="http://www.PerfectXML.com/NETWebSvcs/BookService")]
    public class SalesRankNPrice : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public SalesRankNPrice() {
            this.Url = "http://www.perfectxml.net/WebServices/SalesRankNPrice/BookService.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonSalesRank", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAmazonSalesRank(string ISBN) {
            object[] results = this.Invoke("GetAmazonSalesRank", new object[] {
                        ISBN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonSalesRank(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonSalesRank", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAmazonSalesRank(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonUKSalesRank", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAmazonUKSalesRank(string ISBN) {
            object[] results = this.Invoke("GetAmazonUKSalesRank", new object[] {
                        ISBN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonUKSalesRank(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonUKSalesRank", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAmazonUKSalesRank(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonDESalesRank", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAmazonDESalesRank(string ISBN) {
            object[] results = this.Invoke("GetAmazonDESalesRank", new object[] {
                        ISBN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonDESalesRank(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonDESalesRank", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAmazonDESalesRank(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetBNSalesRank", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetBNSalesRank(string ISBN) {
            object[] results = this.Invoke("GetBNSalesRank", new object[] {
                        ISBN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetBNSalesRank(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetBNSalesRank", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetBNSalesRank(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonPrice", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAmazonPrice(string ISBN) {
            object[] results = this.Invoke("GetAmazonPrice", new object[] {
                        ISBN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonPrice(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonPrice", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAmazonPrice(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonUKPrice", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAmazonUKPrice(string ISBN) {
            object[] results = this.Invoke("GetAmazonUKPrice", new object[] {
                        ISBN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonUKPrice(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonUKPrice", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAmazonUKPrice(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonDEPrice", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAmazonDEPrice(string ISBN) {
            object[] results = this.Invoke("GetAmazonDEPrice", new object[] {
                        ISBN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonDEPrice(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonDEPrice", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAmazonDEPrice(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetBNPrice", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetBNPrice(string ISBN) {
            object[] results = this.Invoke("GetBNPrice", new object[] {
                        ISBN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetBNPrice(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetBNPrice", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetBNPrice(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonSalesRankNPrice", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SalesRankNPrice1 GetAmazonSalesRankNPrice(string ISBN) {
            object[] results = this.Invoke("GetAmazonSalesRankNPrice", new object[] {
                        ISBN});
            return ((SalesRankNPrice1)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonSalesRankNPrice(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonSalesRankNPrice", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public SalesRankNPrice1 EndGetAmazonSalesRankNPrice(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SalesRankNPrice1)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonDESalesRankNPrice", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SalesRankNPrice1 GetAmazonDESalesRankNPrice(string ISBN) {
            object[] results = this.Invoke("GetAmazonDESalesRankNPrice", new object[] {
                        ISBN});
            return ((SalesRankNPrice1)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonDESalesRankNPrice(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonDESalesRankNPrice", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public SalesRankNPrice1 EndGetAmazonDESalesRankNPrice(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SalesRankNPrice1)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetBNSalesRankNPrice", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SalesRankNPrice1 GetBNSalesRankNPrice(string ISBN) {
            object[] results = this.Invoke("GetBNSalesRankNPrice", new object[] {
                        ISBN});
            return ((SalesRankNPrice1)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetBNSalesRankNPrice(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetBNSalesRankNPrice", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public SalesRankNPrice1 EndGetBNSalesRankNPrice(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SalesRankNPrice1)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonAndBNSalesRank", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SalesRanks GetAmazonAndBNSalesRank(string ISBN) {
            object[] results = this.Invoke("GetAmazonAndBNSalesRank", new object[] {
                        ISBN});
            return ((SalesRanks)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonAndBNSalesRank(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonAndBNSalesRank", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public SalesRanks EndGetAmazonAndBNSalesRank(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SalesRanks)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAmazonAndBNPrice", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Prices GetAmazonAndBNPrice(string ISBN) {
            object[] results = this.Invoke("GetAmazonAndBNPrice", new object[] {
                        ISBN});
            return ((Prices)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAmazonAndBNPrice(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAmazonAndBNPrice", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public Prices EndGetAmazonAndBNPrice(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Prices)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.PerfectXML.com/NETWebSvcs/BookService/GetAll", RequestNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", ResponseNamespace="http://www.PerfectXML.com/NETWebSvcs/BookService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public All GetAll(string ISBN) {
            object[] results = this.Invoke("GetAll", new object[] {
                        ISBN});
            return ((All)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAll(string ISBN, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAll", new object[] {
                        ISBN}, callback, asyncState);
        }
        
        /// <remarks/>
        public All EndGetAll(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((All)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.PerfectXML.com/NETWebSvcs/BookService")]
    public class SalesRankNPrice1 {
        
        /// <remarks/>
        public string SalesRank;
        
        /// <remarks/>
        public string Price;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.PerfectXML.com/NETWebSvcs/BookService")]
    public class All {
        
        /// <remarks/>
        public string AmazonSalesRank;
        
        /// <remarks/>
        public string AmazonPrice;
        
        /// <remarks/>
        public string BNSalesRank;
        
        /// <remarks/>
        public string BNPrice;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.PerfectXML.com/NETWebSvcs/BookService")]
    public class Prices {
        
        /// <remarks/>
        public string AmazonPrice;
        
        /// <remarks/>
        public string BNPrice;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.PerfectXML.com/NETWebSvcs/BookService")]
    public class SalesRanks {
        
        /// <remarks/>
        public string AmazonSalesRank;
        
        /// <remarks/>
        public string BNSalesRank;
    }
}
