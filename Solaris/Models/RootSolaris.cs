using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solaris.Models
{




    public class RootSolaris //Parks
    {
        public List<Solaris> Data { get; set; }      //Park
    }

    public class Solaris
    {
        public DateTime reporting_period { get; set; }
        public string project_number { get; set; }
        public string legacy_project_number { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string sector { get; set; }
        public string program_type { get; set; }
        public string solicitation { get; set; }
        public DateTime date_application_received { get; set; }
        public DateTime date_install { get; set; }
        public string project_status { get; set; }
        public string contractor { get; set; }
        public string inverter_manufacturer { get; set; }
        public string primary_inverter_model_number { get; set; }
        public string inverter_quantity { get; set; }
        public string pv_module_manufacturer { get; set; }
        public string pv_module_model_number { get; set; }
        public string pv_module_quantity { get; set; }
        public string totalnameplatekwdc { get; set; }
        public string affordable_solar { get; set; }
        public string community_distributed_generation { get; set; }
        public string green_jobs_green_new_york_participant { get; set; }
        public Georeference georeference { get; set; }
        public string computed_region_yamh_8v7k { get; set; }
        public string computed_region_wbg7_3whc { get; set; }
        public string computed_region_kjdx_g34t { get; set; }
        public string computed_region_n8jy_tbqr { get; set; }
        public string electric_utility { get; set; }
        public string purchase_type { get; set; }
        public string incentive { get; set; }
        public string expected_kwh_annual_production { get; set; }
        public string project_cost { get; set; }
        public string remote_net_metering { get; set; }
    }

    public class Georeference
    {
        public string type { get; set; }
        public float[] coordinates { get; set; }
    }




}
