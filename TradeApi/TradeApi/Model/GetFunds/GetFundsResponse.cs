namespace TradeApi.Model.GetFunds
{
    public class GetFundsResponseALL
    {
        public string allbrokeragePrsnt { get; set; }
        public string allcoMrgnReqd { get; set; }
        public string allmfAmt { get; set; }
        public string allvarMargn { get; set; }
        public string allcollateralVal { get; set; }
        public string allrealizedPNL { get; set; }
        public string allelmMargn { get; set; }
        public string alllossLimit { get; set; }
        public string allcncRealMTM { get; set; }
        public string allcncElmrMargn { get; set; }
        public string allbookedPnl { get; set; }
        public string allexpMargn { get; set; }
        public string allttlCashBal { get; set; }
        public string allcncUnRealMTM { get; set; }
        public string allremarks { get; set; }
        public string allstockCFS { get; set; }
        public string allcncMrgnUsed { get; set; }
        public string allbuypwr { get; set; }
        public string allFD { get; set; }
        public string allcncVarMargn { get; set; }
        public string allpremiumPrsnt { get; set; }
        public string alldebits { get; set; }
        public string allcategory { get; set; }
        public string alldirctColatrl { get; set; }
        public string allmargnUsed { get; set; }
        public string allViewUnrealMTM { get; set; }
        public string allt1GrossCollatrl { get; set; }
        public string allcncCredit { get; set; }
        public string allmfssAmntUsed { get; set; }
        public string allsegment { get; set; }
        public string alladhocMargn { get; set; }
        public string alldelivryMrgn { get; set; }
        public string alllien { get; set; }
        public string allmrgnSrpBskPrsnt { get; set; }
        public string allsellExp { get; set; }
        public string alladdPreExpMrgnPrsnt { get; set; }
        public string alltotalCollateralVal { get; set; }
        public string alladhocSrpMrgn { get; set; }
        public string allfoExpMgnNrmlPrsnt { get; set; }
        public string allpayout { get; set; }
        public string allrealLoss { get; set; }
        public string allnetCashAvail { get; set; }
        public string allmargnBlocked { get; set; }
        public string allutilizedMargin { get; set; }
        public string allcmMrgnCncPrsnt { get; set; }
        public string alltenderMrgnPrsnt { get; set; }
        public string allnotnalCash { get; set; }
        public string allscrpBsktMrgn { get; set; }
        public string allgrosscoltrl { get; set; }
        public string allunRealM2MLoss { get; set; }
        public string allgrossExp { get; set; }
        public string allvalDelry { get; set; }
        public string allunrealizedPNL { get; set; }
        public string alladdMrgnPrsnt { get; set; }
        public string allboMrgnReqd { get; set; }
        public string allcmMrgnMisPrct { get; set; }
        public string allmultiplier { get; set; }
        public string allcredits { get; set; }
        public string allunrealMTM { get; set; }
        public string allpayin { get; set; }
        public string allnfoSprdBenefit { get; set; }
        public string allcashBal { get; set; }
        public string allremarksAmnt { get; set; }
        public string allcurSpnMrgNrmlPrsnt { get; set; }
        public string allunbookPNL { get; set; }
        public string allcncBrkPrst { get; set; }
        public string allunRealLoss { get; set; }
        public string allcurExpMrgMisPrsnt { get; set; }
        public string allfoExpMrgnMisPrsnt { get; set; }
        public string allbuyExp { get; set; }
        public string allcdssprdBenefits { get; set; }
        public string allUnSetldCredit { get; set; }
        public string allspanMrgnNRML { get; set; }
        public string allrealPNL { get; set; }
        public string allspanMrgnMIS { get; set; }
        public string allbrnchAdhoc { get; set; }
        public string allipoAmt { get; set; }
        public string alladhoc { get; set; }
        public string allturnover { get; set; }
        public string allrealMTM { get; set; }
        public string allcurExpMrgNrmlPrsnt { get; set; }
        public string allspanMargn { get; set; }
        public string allrealM2MLoss { get; set; }
    }
    public class GetFundsResponseData
    {
        public GetFundsResponseALL ALL { get; set; }
    }
    public class GetFundsResponse
    {
        public string infoid { get; set; }
        public GetFundsResponseData data { get; set; }
        public string infomsg { get; set; }
        public long timestamp { get; set; }
    }
}
