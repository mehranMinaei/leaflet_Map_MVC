using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace useleaflet_Map.VM
{
    public class orderListVM
    {
        public string driveName { get; set; }
        public string drivePhone { get; set; }
        public string driveImagePath { get; set; }
        public string description { get; set; }
        public double Latitude_order { get; set; }
        public double Longitude_order { get; set; }
        public double Latitude_shop { get; set; }
        public double Longitude_shop { get; set; }
        public double Latitude_customer { get; set; }
        public double Longitude_customer { get; set; }
        public int order_id { get; set; }
        public int? status_id { get; set; }
        public string order_status { get; set; }
        public Int64 user_id { get; set; }
        public string userName { get; set; }
        public int flg_auto_accept { get; set; }
        public string ShopName { get; set; }
        public string CustomerName { get; set; }
        public string[] statusHeader { get; set; }
        public string ReitingComment { get; set; }
        public orderListVM(string driveName_, string drivePhone_, string driveImagePath_, string description_, double Latitude_order_,
            double Longitude_order_, double Latitude_shop_,
            double Longitude_shop_, double Latitude_customer_, double Longitude_customer_, int order_id_, int status_id_,
            string order_status_, Int64 user_id_, string userName_, int flg_auto_accept_, string ShopName_, string CustomerName_)
        {
            driveName = driveName_;
            drivePhone = drivePhone_;
            driveImagePath = driveImagePath_;
            description = description_;
            Latitude_order = Latitude_order_;
            Longitude_order = Longitude_order_;
            Latitude_shop = Latitude_shop_;
            Longitude_shop = Longitude_shop_;
            Latitude_customer = Latitude_customer_;
            Longitude_customer = Longitude_customer_;
            order_id = order_id_;
            status_id = status_id_;
            order_status = order_status_;
            user_id = user_id_;
            userName = userName_;
            flg_auto_accept = flg_auto_accept_;
            ShopName = ShopName_;
            CustomerName = CustomerName_;
        }

    }
}