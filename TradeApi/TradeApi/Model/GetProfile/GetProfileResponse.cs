namespace TradeApi.Model.GetProfile
{
    public class GetProfileResponseAddress
    {
        public string zip { get; set; }
        public string address3 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string nation { get; set; }
        public string address1 { get; set; }
        public string state { get; set; }
    }
    public class GetProfileResponseBankAccount
    {
        public bool defaultBank { get; set; }
        public string accNo { get; set; }
        public object chequeName { get; set; }
        public string bankName { get; set; }
        public string accType { get; set; }
        public object micrCode { get; set; }
        public string ifscCode { get; set; }
    }
    public class GetProfileResponseData
    {
        public object upcomingPlan { get; set; }
        public GetProfileResponseProfile profile { get; set; }
    }
    public class GetProfileResponseProfile
    {
        public List<GetProfileResponseAddress> addresses { get; set; }
        public string gender { get; set; }
        public object turnOverBrokerageSaving { get; set; }
        public string dpid { get; set; }
        public List<GetProfileResponseBankAccount> bankAccounts { get; set; }
        public bool premiumPlanRenewed { get; set; }
        public object offerType { get; set; }
        public bool poaFlag { get; set; }
        public object inActiveFrom { get; set; }
        public string segment { get; set; }
        public string pan { get; set; }
        public object planEndDate { get; set; }
        public string email { get; set; }
        public object activeFrom { get; set; }
        public object planActualPrice { get; set; }
        public object planType { get; set; }
        public string address { get; set; }
        public string mobile { get; set; }
        public bool ddpiFlag { get; set; }
        public string clientCode { get; set; }
        public string dob { get; set; }
        public string name { get; set; }
        public bool showOfferPrice { get; set; }
        public object repositoryType { get; set; }
        public object planStartDate { get; set; }
        public bool premiumPlanActive { get; set; }
    }
    public class GetProfileResponse
    {
        public string infoID { get; set; }
        public GetProfileResponseData data { get; set; }
    }
}
