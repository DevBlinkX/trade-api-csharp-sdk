using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TradeApi.Model.GetProfile
{
    public class GetProfileResponseAddress
    {
        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("nation")]
        public string Nation { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetProfileResponseBankAccount
    {
        [JsonProperty("defaultBank")]
        public bool DefaultBank { get; set; }

        [JsonProperty("accNo")]
        public string AccNo { get; set; }

        [JsonProperty("chequeName")]
        public object ChequeName { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("accType")]
        public string AccType { get; set; }

        [JsonProperty("micrCode")]
        public object MicrCode { get; set; }

        [JsonProperty("ifscCode")]
        public string IfscCode { get; set; }
    }

    public class GetProfileResponseData
    {
        [JsonProperty("upcomingPlan")]
        public object UpcomingPlan { get; set; }

        [JsonProperty("profile")]
        public GetProfileResponseProfile Profile { get; set; }
    }

    public class GetProfileResponseProfile
    {
        [JsonProperty("addresses")]
        public List<GetProfileResponseAddress> Addresses { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("turnOverBrokerageSaving")]
        public object TurnOverBrokerageSaving { get; set; }

        [JsonProperty("dpid")]
        public string Dpid { get; set; }

        [JsonProperty("bankAccounts")]
        public List<GetProfileResponseBankAccount> BankAccounts { get; set; }

        [JsonProperty("premiumPlanRenewed")]
        public bool PremiumPlanRenewed { get; set; }

        [JsonProperty("offerType")]
        public object OfferType { get; set; }

        [JsonProperty("poaFlag")]
        public bool PoaFlag { get; set; }

        [JsonProperty("inActiveFrom")]
        public object InActiveFrom { get; set; }

        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("pan")]
        public string Pan { get; set; }

        [JsonProperty("planEndDate")]
        public object PlanEndDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("activeFrom")]
        public object ActiveFrom { get; set; }

        [JsonProperty("planActualPrice")]
        public object PlanActualPrice { get; set; }

        [JsonProperty("planType")]
        public object PlanType { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("ddpiFlag")]
        public bool DdpiFlag { get; set; }

        [JsonProperty("clientCode")]
        public string ClientCode { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("showOfferPrice")]
        public bool ShowOfferPrice { get; set; }

        [JsonProperty("repositoryType")]
        public object RepositoryType { get; set; }

        [JsonProperty("planStartDate")]
        public object PlanStartDate { get; set; }

        [JsonProperty("premiumPlanActive")]
        public bool PremiumPlanActive { get; set; }
    }

    public class GetProfileResponse
    {
        [JsonProperty("infoID")]
        public string InfoID { get; set; }

        [JsonProperty("data")]
        public GetProfileResponseData Data { get; set; }
    }
}
