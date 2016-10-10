using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using DataAccess;

namespace DemoInformationService
{
    public class DemoInformationService : IDemoInformationService
    {
        public DataSet GetDemographicsWithOutDB()
        {
            return DADemographicsInformation.GetDemographicsWithOutDB();
        }

        public DataSet GetDemographicsUsingDBWithConfig()
        {
            return DADemographicsInformation.GetDemographicsUsingDBWithConfig();
        }

        public DataSet GetDemographicsUsingDBWithOutConfig()
        {
            return DADemographicsInformation.GetDemographicsUsingDBWithOutConfig();
        }
    }
}
