namespace Volo.Abp.EntityFrameworkCore.GlobalFilters;

public class AbpEfCoreGlobalFilterOptions
{
    public bool UseDbFunction { get; set; }

    public AbpEfCoreGlobalFilterOptions()
    {
        UseDbFunction = true;
    }
}
