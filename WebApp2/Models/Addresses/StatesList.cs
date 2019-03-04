using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebApp2.Models.Addresses.StatesList;

namespace WebApp2.Models.Addresses
{

    public class StatesList : GetStatesListInterface
    {
        // experimenting with dependency injection
        public interface GetStatesListInterface
        { List<StatesList> GetStates(); }

        // for EntityFramework and genreal usage
        public int StatesListId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

        // internal list of states 
        public List<StatesList> _states_list { get; set; }

        // constructors, null for misc and parm for the trim function
        public StatesList() { }
        public StatesList(string state_name, string state_code)
        {
            this.StateCode = state_code.Trim();
            this.StateName = state_name.Trim();
        }

        // constructor, for dependency injection, pick a country 
        public StatesList(string country_code)
        {
            switch (country_code)
            {
                case "MEX": _states_list = GetStatesListMEX.GetStates(); break;
                case "CAN": _states_list = GetStatesListCAN.GetStates(); break;
                default: _states_list = GetStatesListUSA.GetStates(); break;
            }
        }

        // still working with DI,populate the states list based on the country code
        public List<StatesList> GetStates()
        {
            return _states_list;
        }
    }
}