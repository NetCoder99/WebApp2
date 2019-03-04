using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models.Addresses
{
    public class GetStatesListCAN 
    {
        public static List<StatesList> GetStates()
        {
            List<StatesList> rtn_list = new List<StatesList>();
            rtn_list.Add(new StatesList("Alberta", "AB"));
            rtn_list.Add(new StatesList("British Columbia", "BC"));
            rtn_list.Add(new StatesList("Manitoba", "MB"));
            rtn_list.Add(new StatesList("New Brunswick", " NB"));
            rtn_list.Add(new StatesList("Newfoundland and Labrador", "NL"));
            rtn_list.Add(new StatesList("Northwest Territories", "NT"));
            rtn_list.Add(new StatesList("Nova Scotia", "NS"));
            rtn_list.Add(new StatesList("Nunavut", "NU"));
            rtn_list.Add(new StatesList("Ontario", "ON"));
            rtn_list.Add(new StatesList("Prince Edward Island", "PE"));
            rtn_list.Add(new StatesList("Quebec", "QC"));
            rtn_list.Add(new StatesList("vSaskatchewan", "SK"));
            rtn_list.Add(new StatesList("Yukon", "YT"));
            return rtn_list;
        }
    }
}