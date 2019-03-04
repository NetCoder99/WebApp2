using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models.Addresses
{
    public class GetStatesListMEX 
    {
        public static List<StatesList> GetStates()
        {
            List<StatesList> rtn_list = new List<StatesList>();
            rtn_list.Add(new StatesList("Aguascalientes", "AG"));
            rtn_list.Add(new StatesList("Baja California", "BC"));
            rtn_list.Add(new StatesList("Baja California Sur", "BS"));
            rtn_list.Add(new StatesList("Chihuahua", "CH"));
            rtn_list.Add(new StatesList("Colima", "CL"));
            rtn_list.Add(new StatesList("Campeche", "CM"));
            rtn_list.Add(new StatesList("Coahuila", "CO"));
            rtn_list.Add(new StatesList("Chiapas", "CS"));
            rtn_list.Add(new StatesList("Federal District", "DF"));
            rtn_list.Add(new StatesList("Durango", "DG"));
            rtn_list.Add(new StatesList("Guerrero", "GR"));
            rtn_list.Add(new StatesList("Guanajuato", "GT"));
            rtn_list.Add(new StatesList("Hidalgo", "HG"));
            rtn_list.Add(new StatesList("Jalisco", "JA"));
            rtn_list.Add(new StatesList("México State", "ME"));
            rtn_list.Add(new StatesList("Michoacán", "MI"));
            rtn_list.Add(new StatesList("Morelos", "MO"));
            rtn_list.Add(new StatesList("Nayarit", "NA"));
            rtn_list.Add(new StatesList("Nuevo León", "NL"));
            rtn_list.Add(new StatesList("Oaxaca", "OA"));
            rtn_list.Add(new StatesList("Puebla", "PB"));
            rtn_list.Add(new StatesList("Querétaro", "QE"));
            rtn_list.Add(new StatesList("Quintana Roo", "QR"));
            rtn_list.Add(new StatesList("Sinaloa", "SI"));
            rtn_list.Add(new StatesList("San Luis Potosí", "SL"));
            rtn_list.Add(new StatesList("Sonora", "SO"));
            rtn_list.Add(new StatesList("Tabasco", "TB"));
            rtn_list.Add(new StatesList("Tlaxcala", "TL"));
            rtn_list.Add(new StatesList("Tamaulipas", "TM"));
            rtn_list.Add(new StatesList("Veracruz", "VE"));
            rtn_list.Add(new StatesList("Yucatán", "YU"));
            rtn_list.Add(new StatesList("Zacatecas", "ZA"));
            return rtn_list;
        }
    }
}