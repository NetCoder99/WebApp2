using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models.Addresses
{
    public class GetStatesListUSA 
    {
        public static List<StatesList> GetStates()
        {
            List<StatesList> rtn_list = new List<StatesList>();
            rtn_list.Add(new StatesList("ALABAMA", "	AL"));
            rtn_list.Add(new StatesList("ALASKA", "	AK"));
            rtn_list.Add(new StatesList("ARIZONA", "	AZ"));
            rtn_list.Add(new StatesList("ARKANSAS", "	AR"));
            rtn_list.Add(new StatesList("CALIFORNIA", "	CA"));
            rtn_list.Add(new StatesList("COLORADO", "	CO"));
            rtn_list.Add(new StatesList("CONNECTICUT", "	CT"));
            rtn_list.Add(new StatesList("DELAWARE", "	DE"));
            rtn_list.Add(new StatesList("FLORIDA", "	FL"));
            rtn_list.Add(new StatesList("GEORGIA", "	GA"));
            rtn_list.Add(new StatesList("HAWAII", "	HI"));
            rtn_list.Add(new StatesList("IDAHO", "	ID"));
            rtn_list.Add(new StatesList("ILLINOIS", "	IL"));
            rtn_list.Add(new StatesList("INDIANA", "	IN"));
            rtn_list.Add(new StatesList("IOWA", "	IA"));
            rtn_list.Add(new StatesList("KANSAS", "	KS"));
            rtn_list.Add(new StatesList("KENTUCKY", "	KY"));
            rtn_list.Add(new StatesList("LOUISIANA", "	LA"));
            rtn_list.Add(new StatesList("MAINE", "	ME"));
            rtn_list.Add(new StatesList("MARYLAND", "	MD"));
            rtn_list.Add(new StatesList("MASSACHUSETTS", "	MA"));
            rtn_list.Add(new StatesList("MICHIGAN", "	MI"));
            rtn_list.Add(new StatesList("MINNESOTA", "	MN"));
            rtn_list.Add(new StatesList("MISSISSIPPI", "	MS"));
            rtn_list.Add(new StatesList("MISSOURI", "	MO"));
            rtn_list.Add(new StatesList("MONTANA", "	MT"));
            rtn_list.Add(new StatesList("NEBRASKA", "	NE"));
            rtn_list.Add(new StatesList("NEVADA", "	NV"));
            rtn_list.Add(new StatesList("NEW HAMPSHIRE", "	NH"));
            rtn_list.Add(new StatesList("NEW JERSEY", "	NJ"));
            rtn_list.Add(new StatesList("NEW MEXICO", "	NM"));
            rtn_list.Add(new StatesList("NEW YORK", "	NY"));
            rtn_list.Add(new StatesList("NORTH CAROLINA", "	NC"));
            rtn_list.Add(new StatesList("NORTH DAKOTA", "	ND"));
            rtn_list.Add(new StatesList("OHIO", "	OH"));
            rtn_list.Add(new StatesList("OKLAHOMA", "	OK"));
            rtn_list.Add(new StatesList("OREGON", "	OR"));
            rtn_list.Add(new StatesList("PENNSYLVANIA", "	PA"));
            rtn_list.Add(new StatesList("RHODE ISLAND", "	RI"));
            rtn_list.Add(new StatesList("SOUTH CAROLINA", "	SC"));
            rtn_list.Add(new StatesList("SOUTH DAKOTA", "	SD"));
            rtn_list.Add(new StatesList("TENNESSEE", "	TN"));
            rtn_list.Add(new StatesList("TEXAS", "	TX"));
            rtn_list.Add(new StatesList("UTAH", "	UT"));
            rtn_list.Add(new StatesList("VERMONT", "	VT"));
            rtn_list.Add(new StatesList("VIRGINIA", "	VA"));
            rtn_list.Add(new StatesList("WASHINGTON", "	WA"));
            rtn_list.Add(new StatesList("WEST VIRGINIA", "	WV"));
            rtn_list.Add(new StatesList("WISCONSIN", "	WI"));
            rtn_list.Add(new StatesList("WYOMING", "	WY"));
            rtn_list.Add(new StatesList("GUAM", "	GU	"));
            rtn_list.Add(new StatesList("PUERTO RICO", "		PR	"));
            rtn_list.Add(new StatesList("VIRGIN ISLANDS", "		VI"));
            return rtn_list;
        }
    }
}