﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//needed to add MSSE680_WilliamsLogMgmtPortal as a Reference
//under ServicesUnitTest
using MSSE680_WilliamsLogMgmtPortal.DAL;
using MSSE680_WilliamsLogMgmtPortal.Services;

namespace ServicesUnitTest
{
    [TestClass]
    public class OrganizationServiceTests
    {
        [TestMethod()]
        public void InsertOrganizationUsingOrganizationServiceImpl()
        {

            Organization organization = new Organization();
            //organization.OrganizationId = 1;  - this is auto-assigned in db
            organization.Name = "Service Implementation Organization";
            organization.Street = "Service Blvd";
            organization.City = "Service";
            organization.State = "CO";
            organization.Zip = "80601";
            organization.StartDate = System.DateTime.Now;

            //add organization to database using OrganizationSvcImpl
            OrganizationSvcImpl orgSvcImpl = new OrganizationSvcImpl();
            orgSvcImpl.AddOrganization(organization);

        }
    }
}