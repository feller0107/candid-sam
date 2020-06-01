﻿namespace Candid.GuideStarAPI
{
  public class SearchRequest
  {
    public string search_terms { get; set; }
    public int from { get; set; }
    public int size { get; set; }
    public Sort sort { get; set; }
    public Filters filters { get; set; }

    public SearchRequest()
    {
      sort = new Sort();
      filters = new Filters();
      filters.geography = new Geography();
      filters.organization = new Organization();
      filters.organization.affiliation_type = new Affiliation_Type();
      filters.organization.specific_exclusions = new Specific_Exclusions();
      filters.organization.number_of_employees_range = new Number_Of_Employees_Range();
      filters.organization.form_types = new Form_Types();
      filters.organization.audits = new Audits();
      filters.financials = new Financials();
      filters.financials.total_revenue = new Total_Revenue();
      filters.financials.total_expenses = new Total_Expenses();
      filters.financials.total_assets = new Total_Assets();
    }
  }

  public class Sort
  {
    public string sort_by { get; set; }
    public bool ascending { get; set; }
  }

  public class Filters
  {
    public Geography geography { get; set; }
    public Organization organization { get; set; }
    public Financials financials { get; set; }
  }

  public class Geography
  {
    public string[] state { get; set; }
    public string zip { get; set; }
    public int radius { get; set; }
    public string[] msa { get; set; }
    public string[] city { get; set; }
    public string[] county { get; set; }
  }

  public class Organization
  {
    public string[] profile_levels { get; set; }
    public string[] ntee_major_codes { get; set; }
    public string[] ntee_minor_codes { get; set; }
    public string[] subsection_codes { get; set; }
    public string[] foundation_codes { get; set; }
    public bool bmf_status { get; set; }
    public bool pub78_verified { get; set; }
    public Affiliation_Type affiliation_type { get; set; }
    public Specific_Exclusions specific_exclusions { get; set; }
    public Number_Of_Employees_Range number_of_employees_range { get; set; }
    public Form_Types form_types { get; set; }
    public Audits audits { get; set; }
  }

  public class Affiliation_Type
  {
    public bool parent { get; set; }
    public bool subordinate { get; set; }
    public bool independent { get; set; }
    public bool headquarter { get; set; }
  }

  public class Specific_Exclusions
  {
    public bool exclude_revoked_organizations { get; set; }
    public bool exclude_defunct_or_merged_organizations { get; set; }
  }

  public class Number_Of_Employees_Range
  {
    public int min { get; set; }
    public int max { get; set; }
  }

  public class Form_Types
  {
    public bool f990 { get; set; }
    public bool f990pf { get; set; }
    public bool required_to_file_990t { get; set; }
  }

  public class Audits
  {
    public bool a_133_audit_performed { get; set; }
  }

  public class Financials
  {
    public Total_Revenue total_revenue { get; set; }
    public Total_Expenses total_expenses { get; set; }
    public Total_Assets total_assets { get; set; }
  }

  public class Total_Revenue
  {
    public int min { get; set; }
    public int max { get; set; }
  }

  public class Total_Expenses
  {
    public int min { get; set; }
    public int max { get; set; }
  }

  public class Total_Assets
  {
    public int min { get; set; }
    public int max { get; set; }
  }
}