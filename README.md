# TalentInsight

## Crear dbcontext y entidades

```bash
dotnet ef dbcontext scaffold "Server=localhost,1433;Database=vmt-bootcamp;User Id=sa;Password=Adminvmt@;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer \
--project TalentInsights.Domain/TalentInsights.Domain.csproj \
--startup-project TalentInsights.WebApi/TalentInsights.WebApi.csproj \
--context TalentDbContext \
--context-dir Database \
--output-dir Entities \
--force
```