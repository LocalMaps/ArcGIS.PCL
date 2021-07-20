using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ArcGIS.ServiceModel.Operation
{
    [DataContract]
    public class SearchGeocoders : SearchArcGISOnline
    {
        public SearchGeocoders(string orgid)
         : base(string.Format("orgid:{0} (access:account OR access:org OR access:shared OR access:public OR access:private)  (type:(\"Geocoding Service\"))", orgid))
        { }
    }
}
