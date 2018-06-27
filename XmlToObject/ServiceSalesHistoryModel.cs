using Newtonsoft.Json;
using System.Collections.Generic;

namespace XmlToObject
{
    public class ServiceSalesHistoryModel
    {
        public ServiceSalesHistory ServiceSalesHistory { get; set; }
    }

    public class ServiceSalesHistory
    {
        [JsonProperty(PropertyName = "ServiceSalesClosed")]
        public List<ServiceSalesClosed> sscl { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class ServiceSalesClosed
    {
        public string Address { get; set; }

        public string CityStateZip { get; set; }

        public string CloseDate { get; set; }

        public string ContactEmailAddress { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string CustNo { get; set; }

        public string ErrorLevel { get; set; }

        public string ErrorMessage { get; set; }

        public string HostItemID { get; set; }

        public string LaborSaleCustomerPay { get; set; }

        public string LaborSaleInternal { get; set; }

        public string LaborSaleWarranty { get; set; }

        public string Make { get; set; }

        public string Mileage { get; set; }

        public string MileageOut { get; set; }

        public string Model { get; set; }

        public string Name1 { get; set; }

        public string Name2 { get; set; }

        public string OpenDate { get; set; }

        public string OpenedTime { get; set; }

        public string PartsSaleCustomerPay { get; set; }

        public string PartsSaleInternal { get; set; }

        public string PartsSaleWarranty { get; set; }

        public string PriorityValue { get; set; }

        public string PromisedDate { get; set; }

        public string PromisedTime { get; set; }

        public string ROComment1 { get; set; }

        public string ROComment2 { get; set; }

        public string ROComment3 { get; set; }

        public string ROComment4 { get; set; }

        public string ROComment5 { get; set; }

        public string ROComment6 { get; set; }

        public string ROComment7 { get; set; }

        public string ROComment8 { get; set; }

        public string ROComment9 { get; set; }

        public string RONumber { get; set; }

        public string ROStatusCode { get; set; }

        public string ROStatusCodeDesc { get; set; }

        public string ServiceAdvisor { get; set; }

        public string VIN { get; set; }

        public string Year { get; set; }
    }
}
