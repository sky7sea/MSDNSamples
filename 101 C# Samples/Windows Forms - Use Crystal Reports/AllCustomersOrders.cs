//------------------------------------------------------------------------------

// <autogenerated>

//     This code was generated by a tool.

//     Runtime Version: 1.0.3705.209

//

//     Changes to this file may cause incorrect behavior and will be lost if 

//     the code is regenerated.

// </autogenerated>

//------------------------------------------------------------------------------

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;




public class AllCustomersOrders:ReportClass
{

    public AllCustomersOrders() 
	{

    }

    public override string ResourceName
	{

        get 
		{
            return "AllCustomersOrders.rpt";
        }

        set
		{
            //Do nothing
        }
    }

    [Browsable(false),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section1
	{

        get 
		{

            return this.ReportDefinition.Sections[0];

        }

    }

    [Browsable(false),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section2
	{

        get 
		{

            return this.ReportDefinition.Sections[1];

        }

    }

    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section6
	{
        get 
		{

            return this.ReportDefinition.Sections[2];

        }

    }

    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section3 
	{

        get 
		{

            return this.ReportDefinition.Sections[3];

        }

    }

    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section7
	{

        get 
		{

            return this.ReportDefinition.Sections[4];

        }

    }

    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section4
	{
        get 
		{

            return this.ReportDefinition.Sections[5];

        }

    }

    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section5
	{
        get 
		{
            return this.ReportDefinition.Sections[6];
        }

    }

    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IParameterField Parameter_PriceToCheck
	{

        get 
		{

            return this.DataDefinition.ParameterFields[0];

        }

    }

    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IParameterField Parameter_ColorToHighlight
	{

        get 
		{
            return this.DataDefinition.ParameterFields[1];
        }

    }

}

[System.Drawing.ToolboxBitmapAttribute(typeof(CrystalDecisions.Shared.ExportOptions), "report.bmp")]
public class CachedAllCustomersOrders:Component,ICachedReport

{

    public CachedAllCustomersOrders() 
	{

    }

    public virtual Boolean IsCacheable 
	{
        get 
		{

            return true;

        }

        set
		{

            //

        }

    }

    public virtual Boolean ShareDBLogonInfo 
	{
        get 
		{
            return false;
        }

        set
		{

            //

        }

    }

    public virtual TimeSpan CacheTimeOut 
	{
        get 
		{

            return CachedReportConstants.DEFAULT_TIMEOUT;

        }

        set
		{

            //

        }

    }

    public virtual ReportDocument CreateReport()  
	{

        AllCustomersOrders rpt  = new AllCustomersOrders();
        rpt.Site = this.Site;
        return rpt;

    }

    public virtual string GetCustomizedCacheKey
		(RequestContext request)
	{
     string  key = null;

        //// The following is the code used to generate the default
        //// cache key for caching report jobs in the ASP.NET Cache.
        //// Feel free to modify this code to suit your needs.
        //// Returning key == null causes the default cache key to
        //// be generated.
        //
        //key = RequestContext.BuildCompleteCacheKey(
        //    request,
        //    null,       // sReportFilename
        //    this.typeof(),
        //    this.ShareDBLogonInfo );

        return key;

    }

}

