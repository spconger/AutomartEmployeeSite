﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class usp_GetVehicleandCustomerInfo_Result
{
    public string LastName { get; set; }
    public string Firstname { get; set; }
    public int VehicleID { get; set; }
    public string LicenseNumber { get; set; }
    public string vehicleMake { get; set; }
    public string VehicleYear { get; set; }
}

public partial class usp_ServiceDetails_Result
{
    public string ServiceName { get; set; }
    public Nullable<decimal> DiscountPercent { get; set; }
    public Nullable<decimal> TaxPercent { get; set; }
    public string ServiceNotes { get; set; }
}

public partial class usp_Services_Result
{
    public int VehicleServiceID { get; set; }
    public string LocationName { get; set; }
    public System.DateTime ServiceDate { get; set; }
    public System.TimeSpan ServiceTime { get; set; }
}
