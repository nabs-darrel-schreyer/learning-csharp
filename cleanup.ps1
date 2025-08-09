dotnet sln .\LearningCSharp.sln remove .\src\Domains\FinanceDomain\LearningCSharp.Domains.FinanceDomain.Dtos\LearningCSharp.Domains.FinanceDomain.Dtos.csproj
dotnet sln .\LearningCSharp.sln remove .\src\Domains\FinanceDomain\LearningCSharp.Domains.FinanceDomain.Persistence\LearningCSharp.Domains.FinanceDomain.Persistence.csproj
dotnet sln .\LearningCSharp.sln remove .\src\Domains\HumanResourcesDomain\LearningCSharp.Domains.HumanResourcesDomain.Dtos\LearningCSharp.Domains.HumanResourcesDomain.Dtos.csproj
dotnet sln .\LearningCSharp.sln remove .\src\Domains\LogisticsDomain\LearningCSharp.Domains.LogisticsDomain.Dtos\LearningCSharp.Domains.LogisticsDomain.Dtos.csproj
dotnet sln .\LearningCSharp.sln remove .\src\Domains\LogisticsDomain\LearningCSharp.Domains.LogisticsDomain.Persistence\LearningCSharp.Domains.LogisticsDomain.Persistence.csproj
dotnet sln .\LearningCSharp.sln remove .\src\Domains\SurveyDomain\LearningCSharp.Domains.SurveyDomain.Dtos\LearningCSharp.Domains.SurveyDomain.Dtos.csproj

Remove-Item -Path .\src\Domains -Recurse -Force
