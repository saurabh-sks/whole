using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WholesaleRaja.Database;
using WholesaleRaja.Website.Models;

namespace WholesaleRaja.Website.Helpers
{
    public class CommonHelper
    {
        public static int GetCountryCodeForIndia()
        {
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                return db.WSR_Country.Where(x => x.CountryName == "India").Select(y => y.CountryCode).FirstOrDefault();
            }
        }

        public static List<State> GetState(int countryCode)
        {
            List<State> stateList = new List<State>();
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                stateList = db.WSR_State.Where(x => x.CountryCode == countryCode).Select
                    (y =>
                            new State
                            {
                                StateCode = y.StateCode,
                                StateName = y.StateName
                            }
                    ).ToList();
            }
            return stateList;
        }

        public static List<City> GetCity(int stateCode)
        {
            List<City> cityList = new List<City>();
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                cityList = db.WSR_City.Where(x => x.StateCode == stateCode).Select
                    (y =>
                        new City
                        {
                            CityCode = y.CityCode,
                            CityName = y.CityName
                        }

                    ).ToList();
            }

            return cityList;
        }

    }
}