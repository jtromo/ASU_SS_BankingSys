﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using SoftSec_BankingApp_Se7en;
using System.Data.Entity;
using SoftSec_BankingApp_Se7en.Models;
using System.Data.SqlClient;

namespace SoftSec_BankingApp_Se7en
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            //SqlConnection.ClearAllPools();
            //Database.SetInitializer(new DropCreateDatabaseAlways<SSBankDBContext>());
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
