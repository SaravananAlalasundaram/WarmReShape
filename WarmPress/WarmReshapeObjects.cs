using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;
using System.CodeDom.Compiler;

namespace WarmPress
{
    internal class WarmReshapeObjects
    {
    }
    public class Root
    {
        public string serial_type { get; set; }
        public List<string> serials { get; set; }
        public Data data { get; set; }
    }
    public class zheightCheck
    {
        public string age { get; set; }
        public string project { get; set; }
        public string coponent { get; set; }
        public string created { get; set; }
        public List<historyList> history { get; set; }

}
        public class historyList
    { 
        public string Id { get; set; }
        public Data data { get; set; }
        public List<string> serials { get; set; }
        public string Event { get; set; }

        public string created { get; set; }
        public string agent_id { get; set; }
        public string process_id { get; set; }
        public string component_id { get; set; }


    }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class properties
    {
        public string age { get; set; }
        public string project { get; set; }
        public string component { get; set; }
        public string created { get; set; }
        public string history { get; set; }
        public List<string> serials { get; set; }
        public string Build { get; set; }
        public string Color { get; set; }
        public string Matrix { get; set; }
        public string Project { get; set; }
        public string Sidefire { get; set; }
        public string Line_type { get; set; }
    }
        public class Data
    {
       
        public Insight insight  { get; set; }
        
    }
    public class Insight
    {
        public TestAttributes test_attributes { get; set; }
        public TestStationAttributes test_station_attributes { get; set; }
        public Results results { get; set; }
        public UutAttributes uut_attributes { get; set; }
    }
    public class TestAttributes
    {
        public string test_result { get; set; }
        public string unit_serial_number { get; set; }
        public string uut_start { get; set; }
        public string uut_stop { get; set; }
    }
    public class TestStationAttributes
    {
        public string fixture_id { get; set; }
        public string line_id { get; set; }
        public string head_id { get; set; }
        public string software_name { get; set; }
        public string software_version { get; set; }
        public string station_id { get; set; }
    }
    public class Results
    {
        public List<Item> items { get; set; }
    }
    public class UutAttributes
    {
        
        public string full_sn { get; set; }
        public string fixture_id { get; set; }
        public string top_fixture_temp { get; set; }
        public string bottom_fixture_temp { get; set; }
        public string load_start_time { get; set; }
        public string unload_stop_time { get; set; }
        public string press_start_time { get; set; }
        public string press_stop_time { get; set; }
        

    }
    public class Item
    {
        public string test { get; set; }
        public string result { get; set; }
        public string value { get; set; }
        public string lower_limit { get; set; }
        public string message { get; set; }

        public string sub_sub_test { get; set; }
        public string sub_test { get; set; }
        public string turn_on { get; set; }
        public string units { get; set; }
        public string upper_limit { get; set; }



    }




    }
