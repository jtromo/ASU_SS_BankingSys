﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class InternalUser : System.Web.UI.Page
    {
        protected String siteKeySelected = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            img_site1.ImageUrl = "./Images/SiteKeys/SiteKey1.jpg";
            img_site2.ImageUrl = "./Images/SiteKeys/SiteKey2.jpg";
            img_site3.ImageUrl = "./Images/SiteKeys/SiteKey3.jpg";
            img_site4.ImageUrl = "./Images/SiteKeys/SiteKey4.jpg";
            img_site5.ImageUrl = "./Images/SiteKeys/SiteKey5.jpg";
            img_site6.ImageUrl = "./Images/SiteKeys/SiteKey6.jpg";
            img_site7.ImageUrl = "./Images/SiteKeys/SiteKey7.jpg";
            img_site8.ImageUrl = "./Images/SiteKeys/SiteKey8.jpg";
            img_site9.ImageUrl = "./Images/SiteKeys/SiteKey9.jpg";
            img_site10.ImageUrl = "./Images/SiteKeys/SiteKey10.jpg";
            img_site11.ImageUrl = "./Images/SiteKeys/SiteKey11.jpg";
            img_site12.ImageUrl = "./Images/SiteKeys/SiteKey12.jpg";
            img_site13.ImageUrl = "./Images/SiteKeys/SiteKey13.jpg";
            img_site14.ImageUrl = "./Images/SiteKeys/SiteKey14.jpg";
            img_site15.ImageUrl = "./Images/SiteKeys/SiteKey15.jpg";
            img_site16.ImageUrl = "./Images/SiteKeys/SiteKey16.jpg";
            img_site17.ImageUrl = "./Images/SiteKeys/SiteKey17.jpg";
            img_site18.ImageUrl = "./Images/SiteKeys/SiteKey18.jpg";
            img_site19.ImageUrl = "./Images/SiteKeys/SiteKey19.jpg";
            img_site20.ImageUrl = "./Images/SiteKeys/SiteKey20.jpg";
        }
        protected void deselect_All_Images()
        {
            siteKeySelected = "";
            img_site1.BorderStyle = BorderStyle.None;
            img_site2.BorderStyle = BorderStyle.None;
            img_site3.BorderStyle = BorderStyle.None;
            img_site4.BorderStyle = BorderStyle.None;
            img_site5.BorderStyle = BorderStyle.None;
            img_site6.BorderStyle = BorderStyle.None;
            img_site7.BorderStyle = BorderStyle.None;
            img_site8.BorderStyle = BorderStyle.None;
            img_site9.BorderStyle = BorderStyle.None;
            img_site10.BorderStyle = BorderStyle.None;
            img_site11.BorderStyle = BorderStyle.None;
            img_site12.BorderStyle = BorderStyle.None;
            img_site13.BorderStyle = BorderStyle.None;
            img_site14.BorderStyle = BorderStyle.None;
            img_site15.BorderStyle = BorderStyle.None;
            img_site16.BorderStyle = BorderStyle.None;
            img_site17.BorderStyle = BorderStyle.None;
            img_site18.BorderStyle = BorderStyle.None;
            img_site19.BorderStyle = BorderStyle.None;
            img_site20.BorderStyle = BorderStyle.None;
        }

        protected void img_site1_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "1";
            img_site1.BorderColor = System.Drawing.Color.DarkBlue;
            img_site1.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site2_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "2";
            img_site2.BorderColor = System.Drawing.Color.DarkBlue;
            img_site2.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site3_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "3";
            img_site3.BorderColor = System.Drawing.Color.DarkBlue;
            img_site3.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site4_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "4";
            img_site4.BorderColor = System.Drawing.Color.DarkBlue;
            img_site4.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site5_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "5";
            img_site5.BorderColor = System.Drawing.Color.DarkBlue;
            img_site5.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site6_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "6";
            img_site6.BorderColor = System.Drawing.Color.DarkBlue;
            img_site6.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site7_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "7";
            img_site7.BorderColor = System.Drawing.Color.DarkBlue;
            img_site7.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site8_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "8";
            img_site8.BorderColor = System.Drawing.Color.DarkBlue;
            img_site8.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site9_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "9";
            img_site9.BorderColor = System.Drawing.Color.DarkBlue;
            img_site9.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site10_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "10";
            img_site10.BorderColor = System.Drawing.Color.DarkBlue;
            img_site10.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site11_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "11";
            img_site11.BorderColor = System.Drawing.Color.DarkBlue;
            img_site11.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site12_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "12";
            img_site12.BorderColor = System.Drawing.Color.DarkBlue;
            img_site12.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site13_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "13";
            img_site13.BorderColor = System.Drawing.Color.DarkBlue;
            img_site13.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site14_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "14";
            img_site14.BorderColor = System.Drawing.Color.DarkBlue;
            img_site14.BorderStyle = BorderStyle.Solid;
        }

        protected void img_site15_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "15";
            img_site15.BorderColor = System.Drawing.Color.DarkBlue;
            img_site15.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site16_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "16";
            img_site16.BorderColor = System.Drawing.Color.DarkBlue;
            img_site16.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site17_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "17";
            img_site17.BorderColor = System.Drawing.Color.DarkBlue;
            img_site17.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site18_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "18";
            img_site18.BorderColor = System.Drawing.Color.DarkBlue;
            img_site18.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site19_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "19";
            img_site19.BorderColor = System.Drawing.Color.DarkBlue;
            img_site19.BorderStyle = BorderStyle.Solid;
        }
        protected void img_site20_Click(object sender, ImageClickEventArgs e)
        {
            deselect_All_Images();
            siteKeySelected = "20";
            img_site20.BorderColor = System.Drawing.Color.DarkBlue;
            img_site20.BorderStyle = BorderStyle.Solid;
        }
    }
}