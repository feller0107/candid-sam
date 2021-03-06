using System.Threading.Tasks;

namespace Candid.GuideStarAPI.Resources
{
  public class CharityCheckResource : AbstractResource
  {
    public static string GetOrganization(string ein)
    {
      var EIN = new EIN(ein);

      return Get(BuildGetRequest(EIN, Domain.CharityCheckV1));
    }

    public static async Task<string> GetOrganizationAsync(string ein)
    {
      var EIN = new EIN(ein);

      return await GetAsync(BuildGetRequest(EIN, Domain.CharityCheckV1))
        .ConfigureAwait(false);
    }
  }
}
