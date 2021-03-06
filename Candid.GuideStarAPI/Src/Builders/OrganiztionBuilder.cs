using System;
using System.Collections.Generic;
using System.Linq;

namespace Candid.GuideStarAPI
{
  public class OrganizationBuilder
  {
    protected Organization _organization;

    private OrganizationBuilder() => _organization = new Organization();

    internal static OrganizationBuilder Create() => new OrganizationBuilder();

    public OrganizationBuilder HavingFoundationCode(IEnumerable<string> foundationCode)
    {
      _organization.foundation_codes = foundationCode.ToArray();
      return this;
    }

    public OrganizationBuilder HavingNTEEMajorCode(IEnumerable<string> nteeMajorCode)
    {
      _organization.ntee_major_codes = nteeMajorCode.ToArray();
      return this;
    }

    public OrganizationBuilder HavingNTEEMinorCode(IEnumerable<string> nteeMinorCode)
    {
      _organization.ntee_minor_codes = nteeMinorCode.ToArray();
      return this;
    }

    public OrganizationBuilder HavingProfileLevel(IEnumerable<string> level)
    {
      _organization.profile_levels = level.ToArray();
      return this;
    }

    public OrganizationBuilder HavingSubsectionCode(IEnumerable<string> subsectionCode)
    {
      _organization.subsection_codes = subsectionCode.ToArray();
      return this;
    }

    public OrganizationBuilder IsOnBMF(bool bmfStatus)
    {
      _organization.bmf_status = bmfStatus;
      return this;
    }

    public OrganizationBuilder IsPub78Verified(bool pubStatus)
    {
      _organization.pub78_verified = pubStatus;
      return this;
    }

    public OrganizationBuilder AffiliationType(Action<AffiliationTypeBuilder> action)
    {
      var _affiliationTypeBuilder = AffiliationTypeBuilder.Create();
      action(_affiliationTypeBuilder);
      _organization.affiliation_type = _affiliationTypeBuilder.Build();
      return this;
    }

    public OrganizationBuilder SpecificExclusions(Action<SpecificExclusionBuilder> action)
    {
      var _specificExclusionBuilder = SpecificExclusionBuilder.Create();
      action(_specificExclusionBuilder);
      _organization.specific_exclusions = _specificExclusionBuilder.Build();
      return this;
    }

    public OrganizationBuilder NumberOfEmployees(Action<MinMaxBuilder> action)
    {
      var _numberOfEmployeesBuilder = MinMaxBuilder.Create();
      action(_numberOfEmployeesBuilder);
      _organization.number_of_employees_range = _numberOfEmployeesBuilder.Build();
      return this;
    }

    public OrganizationBuilder FormTypes(Action<FormTypeBuilder> action)
    {
      var _formTypesBuilder = FormTypeBuilder.Create();
      action(_formTypesBuilder);
      _organization.form_types = _formTypesBuilder.Build();
      return this;
    }

    public OrganizationBuilder Audits(Action<AuditBuilder> action)
    {
      var _auditBuilder = AuditBuilder.Create();
      action(_auditBuilder);
      _organization.audits = _auditBuilder.Build();
      return this;
    }

    internal Organization Build() => _organization;
  }
}
